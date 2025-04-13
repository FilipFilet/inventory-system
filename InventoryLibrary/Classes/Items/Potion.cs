using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class Potion : IItem
{
    public string ItemName { get; }
    public IRarity Rarity { get; }
    public IUsage Usage { get; }
    public string Effect { get; }

    public Potion(string itemName, IRarity rarity, string effect)
    {
        ItemName = itemName;
        Rarity = rarity;
        Effect = effect;
        Usage = new Drink();
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
            {"Rarity", Rarity.Attributes},
            {"Effect", Effect}
        };
    }
}