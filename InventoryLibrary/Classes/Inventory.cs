using InventoryLibrary.Interfaces;

namespace InventoryLibrary.Classes;

public class Inventory : IInventory
{

    public List<IItem> Items { get; } = new();

    // No real lgoic since it is possible to have the same item multiple times
    public void AddItem(IItem addItem)
    {
        Items.Add(addItem);
    }

    public void RemoveItem(IItem removeItem)
    {
        if (!Items.Any(item => item.ItemName == removeItem.ItemName))
        {
            throw new Exception("Item not found in inventory.");
        }
        Items.Remove(removeItem);
    }
}