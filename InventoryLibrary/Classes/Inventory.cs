using InventoryLibrary.Interfaces;

namespace InventoryLibrary.Classes;

public class Inventory
{
    private List<IItem> _items = new List<IItem>();

    // No real lgoic since it is possible to have the same item multiple times
    public void AddItem(IItem addItem)
    {
        _items.Add(addItem);
    }

    public void RemoveItem(IItem removeItem)
    {
        if (!_items.Any(item => item.ItemName == removeItem.ItemName))
        {
            throw new Exception("Item not found in inventory.");
        }
        _items.Remove(removeItem);
    }

    public void DisplayItems()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine("Inventory is empty");
            return;
        }

        Console.WriteLine("Items in inventory:");
        foreach (var item in _items)
        {
            var stats = item.GetItemStats();
            foreach (var stat in stats)
            {
                  // Problem is that when displaying stats, the attributes "value" is an array so it writes system.string[]
                Console.WriteLine($"{stat.Key}: {stat.Value}");
            }

            // Might check for type safety here
            foreach (var attribute in (Array)stats["Rarity"])
            {
                Console.WriteLine(attribute);
                
            }
            Console.WriteLine("--------------------");
        }
    }
}