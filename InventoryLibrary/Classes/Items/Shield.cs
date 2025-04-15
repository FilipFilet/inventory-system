using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class Shield : IItem
{
    public string ItemName {get; }
    public IRarity Rarity {get;}
    public IUsage Usage { get; }
    public int Durability { get; }
    public double DmgNegation { get; }

    public Shield(string itemName, IRarity rarity, int durability, double dmgNegation)
    {
        ItemName = itemName;
        Rarity = rarity;
        Durability = durability;
        DmgNegation = dmgNegation;
        Usage = new Block();
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
            {"DmgNegation", DmgNegation}
        };
    }

    public void DisplayItemStats()
    {
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Rarity: {Rarity.RarityName}");
        Console.WriteLine($"Durability: {Durability}");
        Console.WriteLine($"DmgNegation: {DmgNegation}");
        Console.WriteLine("----Attributes");
        foreach (var attribute in Rarity.Attributes)
        {
            Console.WriteLine($"{attribute}");
        }
    }
}