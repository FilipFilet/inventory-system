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
}