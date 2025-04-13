namespace InventoryLibrary.Interfaces;

public interface IItem
{
    string ItemName { get; }
    IRarity Rarity { get; }
    IUsage Usage { get; }

    void UseItem();

    // I use a dictonary for clarity when retrieving item stats
    Dictionary<string, object> GetItemStats();
}