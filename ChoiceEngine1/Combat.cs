using System;
using Terminal.Gui;
namespace ChoiceEngine1
{
    
    public partial class Combat
    {
        public Combat(Character enemy,  string additionalText = "")
        {
            var player = DecisionController.Player;
            var guns = player.Inventory.GetGuns();
            bool secondGun = true;
            InitializeComponent();
            InitializeCombat();
            button.Clicked += () =>
            {
                if (enemy.Stamina > player.Stamina)
                {
                    enemy.Attack(player);
                    textView.Text =
                        $"You tried to attack {enemy.Name}, but are too weak, you are left with {player.Health} health";
                    UpdateHealthBar(player);
                }
                else
                {
                    player.Attack(enemy);
                    UpdateHealthBar(enemy);
                    textView.Text =
                        $"you attacked {enemy.Name}, giving {player.Strength} damage, {enemy.Name} counterattacks, you are left with {enemy.Strength} health";
                    enemy.Attack(player);
                    UpdateHealthBar(player);
                }

                CheckCharactersStatus();
            };

            button2.Clicked += () =>
            {
                var bandage = (Bandage)player.Inventory.GetBandage();
                player.Heal(bandage.Heal);
                player.Inventory.RemoveItem(1, bandage.Name);
                inventoryTable.Table = DecisionController.Player.Inventory.GetTable();
                UpdateHealthBar(player);
                if (player.Inventory.GetItemAmount(bandage.Name) == 0) button2.Enabled = false;
                CheckCharactersStatus();
            };

            button3.Clicked += () =>
            {
                var gun = (Gun)player.Inventory.GetItem(guns[0].Name);
                UseGun(gun);
                CheckCharactersStatus();
            };
            button4.Clicked += () =>
            {
                Gun gun;
                if (secondGun)
                    gun = (Gun)player.Inventory.GetItem(guns[1].Name);
                else
                    gun = (Gun)player.Inventory.GetItem(guns[2].Name);

                if (gun != null) UseGun(gun);
                CheckCharactersStatus();
            };
            button5.Clicked += () =>
            {
                var staminaDrink = (StaminaDrink)player.Inventory.GetEnergyDrink();
                staminaDrink.Drink(player);
                player.Inventory.RemoveItem(1, staminaDrink.Name);
                textView.Text = $"You drank {staminaDrink.Name}, your stamina is now {player.Stamina}";
                inventoryTable.Table = DecisionController.Player.Inventory.GetTable();
                if (player.Inventory.GetItemAmount(staminaDrink.Name) == 0) button5.Enabled = false;
                CheckCharactersStatus();
            };

            void UpdateHealthBar(Character character)
            {
                float health = character.Health;
                var fraction = health / 100;
                if (character == player)
                    characterStats.Fraction = fraction;
                else
                    enemyStats2.Fraction = fraction;
            }

            void InitializeCombat()
            {
                textView.ReadOnly = true;
                inventoryTable.Table = player.Inventory.GetTable();
                if (additionalText != "")
                {
                    textView.Text = additionalText + $"   You are fighting {enemy.Name}, what would you like to do?";
                    additionalText = "";
                }
                else
                {
                    textView.Text = $"You are fighting {enemy.Name}, what would you like to do?";
                }

                button.Text = "Attack";
                button2.Text = "Use Bandage";
                button5.Text = "Use Energy Drink";
                playerFrameView.Title = player.Name;
                enemyFrameView.Title = enemy.Name;
                enemy.Health = 100;
                player.Health = 100;
                enemyStats2.Fraction = 1;
                characterStats.Fraction = 1;
                if (player.Inventory.GetBandage() != null)
                    button2.Text = "Heal";
                else
                    button2.Enabled = false;

                if (guns.Length == 1)
                    button3.Text = "fire " + guns[0].Name;
                else
                    button3.Enabled = false;
                if (guns.Length == 2)
                {
                    button4.Text = "fire " + guns[1].Name;
                    secondGun = true;
                }
                else if (guns.Length ==3)
                {
                    button4.Text = "fire " + guns[2].Name;
                    secondGun = false;
                }
                else
                {
                    button4.Enabled = false;
                }

                if (player.Inventory.GetEnergyDrink() != null)
                    button5.Text = "Use Energy Drink";
                else
                    button5.Enabled = false;
            }

            void CheckCharactersStatus()
            {
                if (enemy.IsAlive == false)
                {
                    enemy.IsAlive = false;
                    textView.ColorScheme = blackOnGreen;
                        textView.Text = $"You killed {enemy.Name}";
                    Application.MainLoop.AddTimeout(TimeSpan.FromSeconds(3), mainL =>
                    {
                        player.Inventory.DeleteHistory();
                        Application.RequestStop();
                        return false;
                    });
                }
                else if (player.IsAlive == false)
                {
                    textView.ColorScheme = whiteOnRed;
                    textView.Text = "You died, restarting combat...";
                    Application.MainLoop.AddTimeout(TimeSpan.FromSeconds(3), mainL =>
                    {
                        InitializeCombat();
                        player.Inventory.UndoRemove();
                        textView.ColorScheme = greyOnBlack;
                        return false;
                    });
                }
            }

            void UseGun(Gun gun)
            {
                gun.Fire(enemy);
                UpdateHealthBar(enemy);
                textView.Text =
                    $"you shot {enemy.Name}, giving {gun.Damage} damage, there are {gun.Ammo} ammo left";
                Application.MainLoop.AddTimeout(TimeSpan.FromSeconds(3), mainL =>
                {
                    textView.Text = $" {enemy.Name} counterattacks, you are left with {enemy.Strength} health";
                    return false;
                });
                if (gun.Ammo == 0) button4.Enabled = false;
            }
        }

        // public Action<int> Button1Action { get; set; }
        // public void Button1OnClick(int n)
        // {
        //     
        // }
        // public Action<int> Button2Action { get; set; }
        // public void Button2OnClick(int n)
        // {
        //     
        // }
        // public Action<int> Button3Action { get; set; }
        // public void Button3OnClick(int n)
        // {
        //     
        // }
        // public Action<int> Button4Action { get; set; }
        // public void Button4OnClick(int n)
        // {
        //     
        // }
    }
}