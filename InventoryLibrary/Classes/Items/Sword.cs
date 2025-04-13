using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class Sword : IItem
{
    public string ItemName { get; set;}
    public IRarity Rarity {get; set;}
    public IUsage Usage { get; set;}
    public int Durability { get; set; }
    public double Damage { get; set; }

    public Sword(string itemName, IRarity rarity, int durability, double damage)
    {
        ItemName = itemName;
        Rarity = rarity;
        Usage = new Swing();
        Durability = durability;
        Damage = damage;
    }
}