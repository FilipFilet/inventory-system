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
        Usage.Use();
    }
}