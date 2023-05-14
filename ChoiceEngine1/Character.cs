using System.Data;
namespace ChoiceEngine1;

public abstract class Character
{
    protected Character(string name, int health, int stamina, int strength, bool isAlive, Inventory inventory)
    {
        Name = name;
        Health = health;
        Stamina = stamina;
        Strength = strength;
        IsAlive = isAlive;
        Inventory = inventory;
    }
    public int Health { get; set; }
    public bool IsAlive { get; set; }
    public Inventory Inventory { get; }
    public int Stamina { get; set; }
    public string Name { get; set; }
    public int Strength { get; }
    
    
    public void Attack(Character target)
    {
        target.ReceiveDamage(Strength);
    }
    public void ReceiveDamage(int damage)
    {
        if (Health - damage <= 0)
        {
            Health = 0;
            IsAlive = false;
        }
        else
        {
            Health -= damage;
        }
    }
}

public class Enemy : Character
{
    public Enemy(string name, int health, int stamina, int strength, bool isAlive) : base(name, health, stamina,
        strength, isAlive, new Inventory())
    {
    }
}

public class Player : Character
{
    public Player(string name, int health, int stamina, int strength, bool isAlive) : base(name, health, stamina,
        strength, isAlive, new Inventory())
    {
    }

    public DataTable GetStatsTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("Stat");
        dt.Columns.Add("Value");
        dt.Rows.Add("Name", Name);
        dt.Rows.Add("Health", Health);
        dt.Rows.Add("Stamina", Stamina);
        dt.Rows.Add("Strength", Strength);
        return dt;
    }

    public void Heal(int healAmount)
    {
        if (Health + healAmount > 100)
            Health = 100;
        else
            Health += healAmount;
    }
}