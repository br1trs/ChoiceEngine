using System;
using Terminal.Gui;

namespace ChoiceEngine1{

    public partial class Game
    {
        private readonly bool _debugMode;
        public Game(Decision decision, bool debugMode, string text = null)
        {
            if (decision.Item != null)
            {
                for (var i = 0; i < decision.Item.Count; i++)
                {
                    DecisionController.Player.Inventory.AddItem(decision.Item[i], decision.ItemQuantity[i]);
                }
            }
            // ColorScheme = WindowController.selectedTheme;
            if (decision.IsCombatEnabled)
            {
                Application.Run(new Combat(decision.CombatEnemy, decision.CombatText));
            }
            _debugMode = debugMode;
            InitializeComponent();
            var player = DecisionController.Player ?? throw new InvalidOperationException();
            textView.ReadOnly = true;
            textView.Text = decision.DecisionText;
            invetoryTable.Table = player?.Inventory.GetTable();
            option1.Text = decision.Decision1;
            option2.Text = decision.Decision2;
            statsTable.Table = player?.GetStatsTable();
            if (!_debugMode)
            {
                debugLabel.Visible = false;
                restartButton.Visible = false;
            }
            restartButton.Clicked += Restart;
            option1.Clicked += () =>
            {
                if (decision.Decision1Id == 01)
                {
                    Restart();
                }
                else
                {
                    RunNextDecision(decision.GetNextDecision(1));
                }
            };
            option2.Clicked += () =>
            {
                if (decision.Decision2Id == 01)
                {
                    Restart();
                }
                else
                {
                    RunNextDecision(decision.GetNextDecision(2));
                }
            };
        }
        

        private void Restart()
        {
            DecisionController.ResetDecisions();
            WindowController.RunMainMenu();
        }

        private void RunNextDecision(Decision decision)
        {
            Application.RequestStop();
            Application.Run(new Game(decision, _debugMode));
        }

    }
    }
