using Terminal.Gui;

namespace ChoiceEngine1;

public class Themes
{
    public ColorScheme WhiteOnRed()
    {
        var whiteOnRed = new Terminal.Gui.ColorScheme
        {
            Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red),
            HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red),
            Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red),
            HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red),
            Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red)
        };
        return whiteOnRed;
    }

    public ColorScheme GreenOnBlack()
    {
        var greenOnBlack = new Terminal.Gui.ColorScheme
        {
            Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Green, Terminal.Gui.Color.Black),
            HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightGreen, Terminal.Gui.Color.Black),
            Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Green, Terminal.Gui.Color.Magenta),
            HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightGreen, Terminal.Gui.Color.Magenta),
            Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Gray, Terminal.Gui.Color.Black)
        };
       return greenOnBlack;
    }
    
    public ColorScheme WhiteOnBlack()
    {
        var whiteOnBlack = new Terminal.Gui.ColorScheme
        {
            Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black),
            HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black),
            Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black),
            HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black),
            Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black)
        };
        return whiteOnBlack;
    }

    public ColorScheme GreyOnBlack()
    {
        var greyOnBlack = new Terminal.Gui.ColorScheme
        {
            Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black),
            HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black),
            Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.DarkGray),
            HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.DarkGray),
            Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black)
        };
        return greyOnBlack;
    }

    public ColorScheme BlackOnGreen()
    {
        var blackOnGreen = new Terminal.Gui.ColorScheme
        {
            Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green),
            HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green),
            Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green),
            HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green),
            Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green)
        };
        return blackOnGreen;
    }

    public ColorScheme RedOnBlack()
    {
        var redOnBlack = new Terminal.Gui.ColorScheme
        {
            Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Red, Terminal.Gui.Color.Black),
            HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightRed, Terminal.Gui.Color.Black),
            Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Red, Terminal.Gui.Color.Brown),
            HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightRed, Terminal.Gui.Color.Brown),
            Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Gray, Terminal.Gui.Color.Black)
        };
        return redOnBlack;
    }
}