using Terminal.Gui;

namespace ChoiceEngine1 {
    public partial class Game : Terminal.Gui.Window {
        
        private Terminal.Gui.ColorScheme whiteOnRed;
        
        private Terminal.Gui.ColorScheme tgDefault;
        
        private Terminal.Gui.ColorScheme greenOnBlack;
        
        private Terminal.Gui.ColorScheme greyOnBlack;
        
        private Terminal.Gui.ColorScheme blackOnGreen;
        
        private Terminal.Gui.ColorScheme blueOnBlack;
        
        private Terminal.Gui.ColorScheme scheme;
        
        private Terminal.Gui.ColorScheme redOnBlack;
        
        private Terminal.Gui.ColorScheme scheme2;
        
        private Terminal.Gui.FrameView frameView;
        
        private Terminal.Gui.TableView invetoryTable;
        
        private Terminal.Gui.TextView textView;
        
        private Terminal.Gui.FrameView frameView2;
        
        private Terminal.Gui.TableView statsTable;
        
        private Terminal.Gui.Button option1;
        
        private Terminal.Gui.Button option2;
        
        private Terminal.Gui.Label debugLabel;
        
        private Terminal.Gui.Button restartButton;
        
        private void InitializeComponent() {
            this.restartButton = new Terminal.Gui.Button();
            this.debugLabel = new Terminal.Gui.Label();
            this.option2 = new Terminal.Gui.Button();
            this.option1 = new Terminal.Gui.Button();
            this.statsTable = new Terminal.Gui.TableView();
            this.frameView2 = new Terminal.Gui.FrameView();
            this.textView = new Terminal.Gui.TextView();
            this.invetoryTable = new Terminal.Gui.TableView();
            this.frameView = new Terminal.Gui.FrameView();
            this.whiteOnRed = new Terminal.Gui.ColorScheme();
            this.whiteOnRed.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red);
            this.whiteOnRed.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red);
            this.whiteOnRed.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red);
            this.whiteOnRed.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red);
            this.whiteOnRed.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Red);
            this.tgDefault = new Terminal.Gui.ColorScheme();
            this.tgDefault.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Blue);
            this.tgDefault.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightCyan, Terminal.Gui.Color.Blue);
            this.tgDefault.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Gray);
            this.tgDefault.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightBlue, Terminal.Gui.Color.Gray);
            this.tgDefault.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Brown, Terminal.Gui.Color.Blue);
            this.greenOnBlack = new Terminal.Gui.ColorScheme();
            this.greenOnBlack.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Green, Terminal.Gui.Color.Black);
            this.greenOnBlack.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightGreen, Terminal.Gui.Color.Black);
            this.greenOnBlack.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Green, Terminal.Gui.Color.Magenta);
            this.greenOnBlack.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightGreen, Terminal.Gui.Color.Magenta);
            this.greenOnBlack.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Gray, Terminal.Gui.Color.Black);
            this.greyOnBlack = new Terminal.Gui.ColorScheme();
            this.greyOnBlack.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black);
            this.greyOnBlack.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black);
            this.greyOnBlack.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.DarkGray);
            this.greyOnBlack.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.DarkGray);
            this.greyOnBlack.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black);
            this.blackOnGreen = new Terminal.Gui.ColorScheme();
            this.blackOnGreen.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green);
            this.blackOnGreen.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green);
            this.blackOnGreen.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green);
            this.blackOnGreen.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green);
            this.blackOnGreen.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Green);
            this.blueOnBlack = new Terminal.Gui.ColorScheme();
            this.blueOnBlack.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightBlue, Terminal.Gui.Color.Black);
            this.blueOnBlack.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Cyan, Terminal.Gui.Color.Black);
            this.blueOnBlack.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightBlue, Terminal.Gui.Color.BrightYellow);
            this.blueOnBlack.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Cyan, Terminal.Gui.Color.BrightYellow);
            this.blueOnBlack.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Gray, Terminal.Gui.Color.Black);
            this.scheme = new Terminal.Gui.ColorScheme();
            this.scheme.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Brown);
            this.scheme.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Brown);
            this.scheme.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Brown);
            this.scheme.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Brown);
            this.scheme.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Brown);
            this.redOnBlack = new Terminal.Gui.ColorScheme();
            this.redOnBlack.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Red, Terminal.Gui.Color.Black);
            this.redOnBlack.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightRed, Terminal.Gui.Color.Black);
            this.redOnBlack.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Red, Terminal.Gui.Color.Brown);
            this.redOnBlack.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightRed, Terminal.Gui.Color.Brown);
            this.redOnBlack.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Gray, Terminal.Gui.Color.Black);
            this.scheme2 = new Terminal.Gui.ColorScheme();
            this.scheme2.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black);
            this.scheme2.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black);
            this.scheme2.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black);
            this.scheme2.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black);
            this.scheme2.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Black);
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.ColorScheme = this.redOnBlack;
            this.Modal = false;
            this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.Border.BorderBrush = Terminal.Gui.Color.Blue;
            this.Border.Effect3D = false;
            this.Border.Effect3DBrush = null;
            this.Border.DrawMarginFrame = true;
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Title = "Zombies,Run!";
            this.frameView.Width = 39;
            this.frameView.Height = 18;
            this.frameView.X = 1;
            this.frameView.Y = 0;
            this.frameView.Data = "frameView";
            this.frameView.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.frameView.Border.BorderBrush = Terminal.Gui.Color.Black;
            this.frameView.Border.Effect3D = false;
            this.frameView.Border.Effect3DBrush = null;
            this.frameView.Border.DrawMarginFrame = true;
            this.frameView.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView.Title = "Inventory";
            this.Add(this.frameView);
            this.invetoryTable.Width = 30;
            this.invetoryTable.Height = 5;
            this.invetoryTable.X = 9;
            this.invetoryTable.Y = 1;
            this.invetoryTable.ColorScheme = this.scheme2;
            this.invetoryTable.Data = "invetoryTable";
            this.invetoryTable.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.invetoryTable.FullRowSelect = false;
            this.invetoryTable.Style.AlwaysShowHeaders = false;
            this.invetoryTable.Style.ExpandLastColumn = true;
            this.invetoryTable.Style.InvertSelectedCellFirstCharacter = false;
            this.invetoryTable.Style.ShowHorizontalHeaderOverline = false;
            this.invetoryTable.Style.ShowHorizontalHeaderUnderline = false;
            this.invetoryTable.Style.ShowVerticalCellLines = false;
            this.invetoryTable.Style.ShowVerticalHeaderLines = false;
            System.Data.DataTable invetoryTableTable;
            invetoryTableTable = new System.Data.DataTable();
            System.Data.DataColumn invetoryTableTableColumn0;
            invetoryTableTableColumn0 = new System.Data.DataColumn();
            invetoryTableTableColumn0.ColumnName = "Column 0";
            invetoryTableTable.Columns.Add(invetoryTableTableColumn0);
            System.Data.DataColumn invetoryTableTableColumn1;
            invetoryTableTableColumn1 = new System.Data.DataColumn();
            invetoryTableTableColumn1.ColumnName = "Column 1";
            invetoryTableTable.Columns.Add(invetoryTableTableColumn1);
            this.invetoryTable.Table = invetoryTableTable;
            this.frameView.Add(this.invetoryTable);
            this.textView.Width = 70;
            this.textView.Height = 17;
            this.textView.X = 43;
            this.textView.Y = 1;
            this.textView.ColorScheme = this.scheme;
            this.textView.AllowsTab = false;
            this.textView.AllowsReturn = true;
            this.textView.WordWrap = true;
            this.textView.Data = "textView";
            this.textView.Text = "as";
            this.textView.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.textView);
            this.frameView2.Width = 39;
            this.frameView2.Height = 10;
            this.frameView2.X = 1;
            this.frameView2.Y = 18;
            this.frameView2.Data = "frameView2";
            this.frameView2.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.frameView2.Border.BorderBrush = Terminal.Gui.Color.Black;
            this.frameView2.Border.Effect3D = false;
            this.frameView2.Border.Effect3DBrush = null;
            this.frameView2.Border.DrawMarginFrame = true;
            this.frameView2.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView2.Title = "Stats";
            this.Add(this.frameView2);
            this.statsTable.Width = 30;
            this.statsTable.Height = 5;
            this.statsTable.X = 9;
            this.statsTable.Y = 0;
            this.statsTable.Data = "statsTable";
            this.statsTable.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.statsTable.FullRowSelect = false;
            this.statsTable.Style.AlwaysShowHeaders = false;
            this.statsTable.Style.ExpandLastColumn = true;
            this.statsTable.Style.InvertSelectedCellFirstCharacter = false;
            this.statsTable.Style.ShowHorizontalHeaderOverline = false;
            this.statsTable.Style.ShowHorizontalHeaderUnderline = false;
            this.statsTable.Style.ShowVerticalCellLines = false;
            this.statsTable.Style.ShowVerticalHeaderLines = false;
            System.Data.DataTable statsTableTable;
            statsTableTable = new System.Data.DataTable();
            System.Data.DataColumn statsTableTableColumn0;
            statsTableTableColumn0 = new System.Data.DataColumn();
            statsTableTableColumn0.ColumnName = "Column 0";
            statsTableTable.Columns.Add(statsTableTableColumn0);
            System.Data.DataColumn statsTableTableColumn1;
            statsTableTableColumn1 = new System.Data.DataColumn();
            statsTableTableColumn1.ColumnName = "Column 1";
            statsTableTable.Columns.Add(statsTableTableColumn1);
            this.statsTable.Table = statsTableTable;
            this.frameView2.Add(this.statsTable);
            this.option1.Width = 7;
            this.option1.Height = 1;
            this.option1.X = 49;
            this.option1.Y = 19;
            this.option1.Data = "option1";
            this.option1.Text = "";
            this.option1.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.option1.IsDefault = false;
            this.Add(this.option1);
            this.option2.Width = 7;
            this.option2.Height = 1;
            this.option2.X = 49;
            this.option2.Y = 22;
            this.option2.Data = "option2";
            this.option2.Text = "";
            this.option2.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.option2.IsDefault = false;
            this.Add(this.option2);
            this.debugLabel.Width = 34;
            this.debugLabel.Height = 1;
            this.debugLabel.X = 54;
            this.debugLabel.Y = 26;
            this.debugLabel.Data = "debugLabel";
            this.debugLabel.Text = "Heya";
            this.debugLabel.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.debugLabel);
            this.restartButton.Width = 16;
            this.restartButton.Height = 1;
            this.restartButton.X = 101;
            this.restartButton.Y = 26;
            this.restartButton.Data = "restartButton";
            this.restartButton.Text = "restartLevel";
            this.restartButton.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.restartButton.IsDefault = false;
            this.Add(this.restartButton);
        }
    }
}
