namespace InventorryLibrary.Interfaces;

public interface IItem
{
    string ItemName { get; set; }
    int Durability { get; set; }
    IRarity Rarity { get; set; }
    IUsage Usage { get; set; }
}