using System;
using ChoiceEngine1;
using Terminal.Gui;
using Key = ChoiceEngine1.Key;

namespace ZombiesRun
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Application.Init();
            try
            {
                string title = @"
███████╗░█████╗░███╗░░░███╗██████╗░██╗███████╗░██████╗░░░  ██████╗░██╗░░░██╗███╗░░██╗██╗
╚════██║██╔══██╗████╗░████║██╔══██╗██║██╔════╝██╔════╝░░░  ██╔══██╗██║░░░██║████╗░██║██║
░░███╔═╝██║░░██║██╔████╔██║██████╦╝██║█████╗░░╚█████╗░░░░  ██████╔╝██║░░░██║██╔██╗██║██║
██╔══╝░░██║░░██║██║╚██╔╝██║██╔══██╗██║██╔══╝░░░╚═══██╗██╗  ██╔══██╗██║░░░██║██║╚████║╚═╝
███████╗╚█████╔╝██║░╚═╝░██║██████╦╝██║███████╗██████╔╝╚█║  ██║░░██║╚██████╔╝██║░╚███║██╗
╚══════╝░╚════╝░╚═╝░░░░░╚═╝╚═════╝░╚═╝╚══════╝╚═════╝░░╚╝  ╚═╝░░╚═╝░╚═════╝░╚═╝░░╚══╝╚═╝";
                Parser.Parse();
                WindowController.GameTitle = "Zombies Run";
                var player = new Player("John", 100, 50, 60, true);
                DecisionController.Player = player;
                var shotGun = new Gun("ShotGun", "the zombie killer", 10, 20, 30);
                var gunText = $"You found {shotGun.Name}, {shotGun.Description}";
                var zombie = new Enemy("Zombie", 100, 30, 30, true);
                DecisionController.AddCombatToDecision(9, zombie, gunText);
                DecisionController.AddItemToDecision(2, shotGun, 1);
                
                var staminaDrink = new StaminaDrink("Redbull", "Redbull gives you stamina", 10, 30);
                var staminaDrinkText = $"you get 2 {staminaDrink.Name}, {staminaDrink.Description}";
                var sussyZombie = new Enemy("sussy zombie", 100, 30, 30, true);
                DecisionController.AddCombatToDecision(11, sussyZombie, staminaDrinkText);
                DecisionController.AddItemToDecision(8, staminaDrink, 2);
                
                var pistol = new Gun("Classic", "not the most amazing gun, but it works", 20, 15, 10);
                DecisionController.Player.Inventory.AddItem(pistol, 1);

                var bandage = new Bandage("bandage", "cures you", 15);
                var bandageText = $"You enter the hospital and find 5 {bandage.Name}, {bandage.Description}";
                var brainEater = new Enemy("Brain Eater", 100, 50, 50, true);
                DecisionController.AddCombatToDecision(10, brainEater, bandageText);
                DecisionController.AddItemToDecision(9, bandage, 5);

                var frenzy = new Gun("Frenzy", "fast", 40, 20, 100);
                DecisionController.AddItemToDecision(11, frenzy, 1);
                Application.Run(new MainMenu(title, true,true));

            }
            finally
            {
                Application.Shutdown();
            }
        }
    }
}