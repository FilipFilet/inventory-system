namespace InventoryLibrary.Interfaces;

public interface IInventory
{
    List<IItem> Items { get; }

    void AddItem(IItem addItem);
    void RemoveItem(IItem removeItem);
}