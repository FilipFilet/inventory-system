using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class Bow : IItem
{
    public string ItemName { get; }
    public IRarity Rarity { get;} 
    public IUsage Usage { get;  }
    public int Durability { get;  }
    public double Damage { get; }
    public double Range { get;}

    // Using dependency injection to inject the rarity object
    public Bow(string itemName, IRarity rarity, double damage, double range, int durability)
    {
        ItemName = itemName;
        Rarity = rarity;
        Damage = damage;
        Range = range;
        Durability = durability;
        Usage = new Shoot();
    }

    public void UseItem()
    {
        Usage.Use(this);
    }

    public Dictionary<string, object> GetItemStats()
    {
        return new Dictionary<string, object>
        {
            // Change rarity to attributes, and add a rarity field. Maybe i need another solution because of problems in the Inventory class
            {"ItemName", ItemName},
            {"Rarity", Rarity.RarityName},
            {"Attributes", Rarity.Attributes},
            {"Damage", Damage},
            {"Range", Range},
            {"Durability", Durability}
        };
    }
}