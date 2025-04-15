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

    // public void DisplayItems()
    // {
    //     if (Items.Count == 0)
    //     {
    //         Console.WriteLine("Inventory is empty");
    //         return;
    //     }

    //     Console.WriteLine("Items in inventory:");
    //     foreach (var item in Items)
    //     {
    //         item.DisplayItemStats();
    //         Console.WriteLine("--------------------");
    //     }
    // }
}