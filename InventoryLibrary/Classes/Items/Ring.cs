using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class Ring : IItem
{
    public string ItemName {get; }
    public IRarity Rarity {get;}
    public IUsage Usage { get; }
    public int Durability { get; }

    public Ring(string itemName, IRarity rarity , int durability)
    {
        ItemName = itemName;
        Rarity = rarity;
        Durability = durability;
        Usage = new DoNothing();
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
            {"Durability", Durability}
        };
    }

    public void DisplayItemStats()
    {
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Rarity: {Rarity.RarityName}");
        Console.WriteLine($"Durability: {Durability}");
        Console.WriteLine("----Attributes");
        foreach (var attribute in Rarity.Attributes)
        {
            Console.WriteLine($"{attribute}");
        }
    }
}