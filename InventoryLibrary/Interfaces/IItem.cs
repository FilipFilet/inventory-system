namespace InventoryLibrary.Interfaces;

public interface IItem
{
    string ItemName { get; }
    IRarity Rarity { get; }
    IUsage Usage { get; }

    void UseItem();

    // I use a dictonary for clarity when retrieving item stats.
    // It leads to some code smells (if changes happen in specific implementation, then multiple places needs to be changed),
    // but this is the way i found that minimized the smell the most for now.
    Dictionary<string, object> GetItemStats();
}