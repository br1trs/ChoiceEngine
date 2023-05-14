using Terminal.Gui;

namespace ChoiceEngine1
{
    public sealed partial class MainMenu
    {
        public MainMenu(string title,bool chooseCharacterName = false, bool showDebugMode = false)
        {
            InitializeComponent();
            // ColorScheme = WindowController.selectedTheme;
            debugMode.Visible = showDebugMode;
            mainMenuText.Text = title;
            var mainMenu = this;
            playButton.Clicked += () => {
                debugMode.Visible = false;
                if (chooseCharacterName)
                {
                    Application.Run(new PlayerName());
                    Play(debugMode.Checked);
                }
                else
                {
                    Play(debugMode.Checked);
                }
                
            };
            
            exitButton.Clicked +=() => Application.RequestStop();
        }

        private static void Play(bool debugMode)
        {
            Application.RequestStop();
            Application.Run(new Game(DecisionController.GetDecisionById(1), debugMode));
        }
    }
}