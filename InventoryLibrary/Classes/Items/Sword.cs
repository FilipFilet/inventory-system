using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class Sword : IItem
{
    public string ItemName { get;}
    public IRarity Rarity {get;}
    public IUsage Usage { get; }
    public int Durability { get; }
    public double Damage { get; }

    public Sword(string itemName, IRarity rarity, int durability, double damage)
    {
        ItemName = itemName;
        Rarity = rarity;
        Usage = new Swing();
        Durability = durability;
        Damage = damage;
    }


    public void UseItem()
    {
        Usage.Use(this);
    }

    public Dictionary<string, object> GetItemStats()
    {
        return new Dictionary<string, object>
        {
            {"ItemName", ItemName},
            {"Rarity", Rarity.RarityName},
            {"Attributes", Rarity.Attributes},
            {"Durability", Durability},
            {"Damage", Damage}
        };
    }

    public void DisplayItemStats()
    {
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Rarity: {Rarity.RarityName}");
        Console.WriteLine($"Durability: {Durability}");
        Console.WriteLine($"Damage: {Damage}");
        Console.WriteLine("----Attributes");
        foreach (var attribute in Rarity.Attributes)
        {
            Console.WriteLine($"{attribute}");
        }
    }
}