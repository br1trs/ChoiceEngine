using System;
using System.Collections.Generic;
using System.Linq;

namespace ChoiceEngine1;

public class DecisionController
{
    
    private static readonly List<Decision> DecisionsList = new();
    private static int _currentDecision;
    private static int _currentDecisionId;
    public static Player Player { get; set; } = null!;

    public static int CurrentDecision { get; set; } = 0;
    public static string PlayerName { get; set; } = null!;
    
    private static void NewDecision(string text, string d1, string d2, int id, int d1Id, int d2Id, bool isCombatEnabled)
    {
        var newDecision = new Decision(text, d1, d2, id, d1Id, d2Id, isCombatEnabled);
        DecisionsList.Add(newDecision);
    }
    public static Decision GetDecisionById(int id)
    {
        return DecisionsList.FirstOrDefault(d => d.Id == id) ?? throw new Exception("Decision ID not found");
    }

    public static void NewDecisionBatch(string[] texts, string[] firstDecisions, string[] secondDecisions, int[] firstDecisionIds, int[] secondDecisionIds, bool[] isCombatEnabled)
    {
        for (var i = 0; i < texts.Length; i++) NewDecision(texts[i], firstDecisions[i], secondDecisions[i], i + 1, firstDecisionIds[i], secondDecisionIds[i], isCombatEnabled[i]);
    }
    
    public static void RegisterLastDecisionMade(int decisionNumber, int decisionId)
    {
        if (decisionNumber != 1 && decisionNumber != 2)
            throw new Exception("Invalid decision number. Must be 1 or 2");
        _currentDecision = decisionNumber;
        _currentDecisionId = decisionId;
    }
    
    public static void ResetDecisions()
    {
        _currentDecision = 0;
        _currentDecisionId = 0;
        Player = null;
    }
    
    public static void AddCombatToDecision(int decisionId, Character enemy, string additionalText)
    {
        var decision = DecisionsList.FirstOrDefault(d => d.Id == decisionId);
        if (decision == null) throw new Exception("Decision ID not found");
        decision.CombatEnemy = enemy;
        decision.CombatText = additionalText;
    }
    public static void AddItemToDecision(int decisionId, Item item, int quantity)
    {
        var decision = DecisionsList.FirstOrDefault(d => d.Id == decisionId);
        if (decision == null) throw new Exception("Decision ID not found");
        decision.Item.Add(item);
        decision.ItemQuantity.Add(quantity);
    }




}

public class Decision : DecisionController
{
    public readonly string Decision1;
    public readonly string Decision2;
    public readonly string DecisionText;
    public readonly int Id;
    public readonly int Decision1Id;
    public readonly int Decision2Id;
    public readonly bool IsCombatEnabled;
    public List<int> ItemQuantity = new();
    public List<Item> Item = new();
    public Character CombatEnemy;
    public string CombatText;
    public Decision(string text, string d1, string d2, int id, int d1Id, int d2Id, bool isCombatEnabled, Item item = null, int itemQuantity = 0, Character combatEnemy = null, string combatText = null)
    {
        DecisionText = text;
        Decision1 = d1;
        Decision2 = d2;
        Id = id;
        Decision1Id = d1Id;
        Decision2Id = d2Id;
        IsCombatEnabled = isCombatEnabled;
        if (item == null) return;
        Item.Add(item);
        ItemQuantity.Add(itemQuantity);
        CombatEnemy = combatEnemy;
        CombatText = combatText;
    }
    public Decision GetNextDecision(int decisionNumber)
    {
        
        Decision nextDecision = null!;
        if (decisionNumber != 1 && decisionNumber != 2)
            throw new Exception("Invalid decision number. Must be 1 or 2");
        nextDecision = decisionNumber switch
        {
            1 => GetDecisionById(Decision1Id),
            2 => GetDecisionById(Decision2Id),
            _ => nextDecision
        };
        return nextDecision;
    }
}