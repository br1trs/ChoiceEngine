namespace ChoiceEngine1;

public abstract class Item
{
    protected Item(string name, string description, int damage)
    {
        Name = name;
        Description = description;
        Damage = damage;
    }

    protected Item(string name, string description)
    {
        Name = name;
        Description = description;
    }

    void Use(Character target)
    {
        
    }
    public int Damage { get; }
    public string Description { get; }
    public string Name { get; }
}

public class Gun : Item
{
    public int Ammo{get; private set;}
    private int Pelllets{get;}
    public Gun(string name, string description, int damage, int pellets, int ammo) : base(name, description, damage)
    {
        Pelllets = pellets;
        Ammo = ammo;
    }

    public void Fire(Character target)
    {
        
        if (Ammo <= 0) return;
        if (Ammo - Pelllets <= 0)
        {
            target.ReceiveDamage(Damage);
            Ammo = 0;
        }
        else
        {
            target.ReceiveDamage(Damage);
            Ammo -= Pelllets;
        }
    }
}

public class Bandage : Item
{
    public int Heal { get;}

    public Bandage(string name, string description, int healAmount) : base(name, description)
    {
        Heal = healAmount;
    }
}

public class StaminaDrink : Item
{
    private int Stamina { get;}

    public StaminaDrink(string name, string description, int damage, int staminaAmount) : base(name, description,
        damage)
    {
        Stamina = staminaAmount;
    }

    public void Drink(Character target)
    {
        target.Stamina += Stamina;
    }
}

public class Key : Item
{
    public Key(string name, string description) : base(name, description)
    {
    }
}