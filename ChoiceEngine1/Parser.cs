using System;
using System.IO;
using System.Linq;

namespace ChoiceEngine1;

public class Parser
{
    public static void Parse(string path = "story.txt")
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var rootDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
        path = Path.Combine(rootDirectory, path);
        var lines = File.ReadAllLines(path);
        
        var model = lines.Select(p => new
        {
            Text = p.Split('|')[0],
            Decision1 = p.Split('|')[1],
            Decision1Id = p.Split('|')[2],
            Decision2 = p.Split('|')[3],
            Decision2Id = p.Split('|')[4],
            Combat = p.Split('|')[5],
        });
        var texts = model.Select(p => p.Text).ToArray();
        var firstDecisions = model.Select(p => p.Decision1).ToArray();
        var secondDecisions = model.Select(p => p.Decision2).ToArray();
        try
        {
            var firstDecisionIds = model.Select(p => p.Decision1Id).Select(int.Parse).ToArray();
            var secondDecisionIds = model.Select(p => p.Decision2Id).Select(int.Parse).ToArray();
            var combatsBools = model.Select(p => p.Combat).Select(bool.Parse).ToArray();
            DecisionController.NewDecisionBatch(texts, firstDecisions, secondDecisions, firstDecisionIds,
                secondDecisionIds, combatsBools);
        }
        catch (Exception e)
        {
            throw new Exception("Parsing error: " + e.Message + "\n" +
                                "Please check that all the decision ids are integers.");
        }

        
    }
}