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
}