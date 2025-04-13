namespace InventoryLibrary.Interfaces;

public interface IItem
{
    string ItemName { get; set; }
    IRarity Rarity { get; set; }
    IUsage Usage { get; set; }
}