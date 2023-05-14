using Terminal.Gui;

namespace ChoiceEngine1;

public static class WindowController
{
    public static MainMenu MainMenu { get; set; }
    
    public static string GameTitle { get; set; }
    
    public static Themes Themes { get; set; }

    public static ColorScheme selectedTheme { get; set; }
    public static void RunMainMenu()
    {
        Application.RequestStop();
        Application.Run(MainMenu);
    }
}