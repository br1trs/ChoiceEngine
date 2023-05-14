
namespace ChoiceEngine1 {
    using System;
    using Terminal.Gui;
    public partial class Combat : Terminal.Gui.Dialog {
        
        private Terminal.Gui.ColorScheme whiteOnRed;
        
        private Terminal.Gui.ColorScheme tgDefault;
        
        private Terminal.Gui.ColorScheme greenOnBlack;
        
        private Terminal.Gui.ColorScheme greyOnBlack;
        
        private Terminal.Gui.ColorScheme blackOnGreen;
        
        private Terminal.Gui.ColorScheme blueOnBlack;
        
        private Terminal.Gui.FrameView frameView;
        
        private Terminal.Gui.TableView inventoryTable;
        
        private Terminal.Gui.TextView textView;
        
        private Terminal.Gui.FrameView enemyFrameView;
        
        private Terminal.Gui.ProgressBar enemyStats2;
        
        private Terminal.Gui.Button button;
        
        private Terminal.Gui.Button button2;
        
        private Terminal.Gui.FrameView playerFrameView;
        
        private Terminal.Gui.ProgressBar characterStats;
        
        private Terminal.Gui.Button button3;
        
        private Terminal.Gui.Button button5;
        
        private Terminal.Gui.Button button4;
        
        private void InitializeComponent() {
            this.button4 = new Terminal.Gui.Button();
            this.button5 = new Terminal.Gui.Button();
            this.button3 = new Terminal.Gui.Button();
            this.characterStats = new Terminal.Gui.ProgressBar();
            this.playerFrameView = new Terminal.Gui.FrameView();
            this.button2 = new Terminal.Gui.Button();
            this.button = new Terminal.Gui.Button();
            this.enemyStats2 = new Terminal.Gui.ProgressBar();
            this.enemyFrameView = new Terminal.Gui.FrameView();
            this.textView = new Terminal.Gui.TextView();
            this.inventoryTable = new Terminal.Gui.TableView();
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
            this.Width = Dim.Percent(85f);
            this.Height = Dim.Percent(85f);
            this.X = Pos.Center();
            this.Y = Pos.Center();
            this.Modal = true;
            this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.Border.BorderBrush = Terminal.Gui.Color.Blue;
            this.Border.Effect3D = true;
            this.Border.Effect3DBrush = null;
            this.Border.DrawMarginFrame = true;
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Title = "";
            this.frameView.Width = 39;
            this.frameView.Height = 12;
            this.frameView.X = 0;
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
            this.inventoryTable.Width = 30;
            this.inventoryTable.Height = 5;
            this.inventoryTable.X = 9;
            this.inventoryTable.Y = 1;
            this.inventoryTable.Data = "inventoryTable";
            this.inventoryTable.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.inventoryTable.FullRowSelect = false;
            this.inventoryTable.Style.AlwaysShowHeaders = false;
            this.inventoryTable.Style.ExpandLastColumn = true;
            this.inventoryTable.Style.InvertSelectedCellFirstCharacter = false;
            this.inventoryTable.Style.ShowHorizontalHeaderOverline = false;
            this.inventoryTable.Style.ShowHorizontalHeaderUnderline = false;
            this.inventoryTable.Style.ShowVerticalCellLines = false;
            this.inventoryTable.Style.ShowVerticalHeaderLines = false;
            System.Data.DataTable inventoryTableTable;
            inventoryTableTable = new System.Data.DataTable();
            System.Data.DataColumn inventoryTableTableColumn0;
            inventoryTableTableColumn0 = new System.Data.DataColumn();
            inventoryTableTableColumn0.ColumnName = "Column 0";
            inventoryTableTable.Columns.Add(inventoryTableTableColumn0);
            System.Data.DataColumn inventoryTableTableColumn1;
            inventoryTableTableColumn1 = new System.Data.DataColumn();
            inventoryTableTableColumn1.ColumnName = "Column 1";
            inventoryTableTable.Columns.Add(inventoryTableTableColumn1);
            this.inventoryTable.Table = inventoryTableTable;
            this.frameView.Add(this.inventoryTable);
            this.textView.Width = 50;
            this.textView.Height = 12;
            this.textView.X = 45;
            this.textView.Y = 1;
            this.textView.ColorScheme = this.greyOnBlack;
            this.textView.AllowsTab = true;
            this.textView.AllowsReturn = true;
            this.textView.WordWrap = true;
            this.textView.Data = "textView";
            this.textView.Text = "Heyad";
            this.textView.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.textView);
            this.enemyFrameView.Width = 39;
            this.enemyFrameView.Height = 5;
            this.enemyFrameView.X = 0;
            this.enemyFrameView.Y = 12;
            this.enemyFrameView.Data = "enemyFrameView";
            this.enemyFrameView.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.enemyFrameView.Border.BorderBrush = Terminal.Gui.Color.Black;
            this.enemyFrameView.Border.Effect3D = false;
            this.enemyFrameView.Border.Effect3DBrush = null;
            this.enemyFrameView.Border.DrawMarginFrame = true;
            this.enemyFrameView.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.enemyFrameView.Title = "Enemy";
            this.Add(this.enemyFrameView);
            this.enemyStats2.Width = 30;
            this.enemyStats2.Height = 2;
            this.enemyStats2.X = 3;
            this.enemyStats2.Y = 1;
            this.enemyStats2.ColorScheme = this.blueOnBlack;
            this.enemyStats2.Data = "enemyStats2";
            this.enemyStats2.Text = "100%";
            this.enemyStats2.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.enemyStats2.Fraction = 1F;
            this.enemyStats2.BidirectionalMarquee = false;
            this.enemyStats2.ProgressBarStyle = Terminal.Gui.ProgressBarStyle.Continuous;
            this.enemyStats2.ProgressBarFormat = Terminal.Gui.ProgressBarFormat.SimplePlusPercentage;
            this.enemyStats2.SegmentCharacter = '█';
            this.enemyFrameView.Add(this.enemyStats2);
            this.button.Width = 8;
            this.button.Height = 1;
            this.button.X = 47;
            this.button.Y = 14;
            this.button.Data = "button";
            this.button.Text = "Heya";
            this.button.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.button.IsDefault = false;
            this.Add(this.button);
            this.button2.Width = 11;
            this.button2.Height = 1;
            this.button2.X = 47;
            this.button2.Y = 16;
            this.button2.Data = "button2";
            this.button2.Text = "use cure";
            this.button2.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.button2.IsDefault = false;
            this.Add(this.button2);
            this.playerFrameView.Width = 39;
            this.playerFrameView.Height = 5;
            this.playerFrameView.X = 0;
            this.playerFrameView.Y = 18;
            this.playerFrameView.Data = "playerFrameView";
            this.playerFrameView.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.playerFrameView.Border.BorderBrush = Terminal.Gui.Color.Black;
            this.playerFrameView.Border.Effect3D = false;
            this.playerFrameView.Border.Effect3DBrush = null;
            this.playerFrameView.Border.DrawMarginFrame = true;
            this.playerFrameView.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.playerFrameView.Title = "Stats";
            this.Add(this.playerFrameView);
            this.characterStats.Width = 30;
            this.characterStats.Height = 2;
            this.characterStats.X = 3;
            this.characterStats.Y = 1;
            this.characterStats.Data = "characterStats";
            this.characterStats.Text = "100%";
            this.characterStats.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.characterStats.Fraction = 1F;
            this.characterStats.BidirectionalMarquee = true;
            this.characterStats.ProgressBarStyle = Terminal.Gui.ProgressBarStyle.Continuous;
            this.characterStats.ProgressBarFormat = Terminal.Gui.ProgressBarFormat.SimplePlusPercentage;
            this.characterStats.SegmentCharacter = '█';
            this.playerFrameView.Add(this.characterStats);
            this.button3.Width = 28;
            this.button3.Height = 1;
            this.button3.X = 47;
            this.button3.Y = 18;
            this.button3.Data = "button3";
            this.button3.Text = "use gun";
            this.button3.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.button3.IsDefault = false;
            this.Add(this.button3);
            this.button5.Width = 26;
            this.button5.Height = 1;
            this.button5.X = 47;
            this.button5.Y = 20;
            this.button5.Data = "button5";
            this.button5.Text = "Usar Bebida Energetica";
            this.button5.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.button5.IsDefault = false;
            this.Add(this.button5);
            this.button4.Width = 21;
            this.button4.Height = 1;
            this.button4.X = 47;
            this.button4.Y = 22;
            this.button4.Data = "button4";
            this.button4.Text = "use gun";
            this.button4.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.button4.IsDefault = false;
            this.Add(this.button4);
        }
    }
}
