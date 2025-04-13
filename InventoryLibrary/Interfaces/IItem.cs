namespace InventoryLibrary.Interfaces;

public interface IItem
{
    string ItemName { get; }
    IRarity Rarity { get; }
    IUsage Usage { get; }

    void UseItem();
}