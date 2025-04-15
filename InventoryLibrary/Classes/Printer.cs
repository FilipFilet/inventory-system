using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class Printer
{
    public static void PrintInventory(IInventory inventory)
    {
        Console.WriteLine("------Inventory Items------");
        
        foreach (var item in inventory.Items)
        {
            var stats = item.GetItemStats();

            foreach (var stat in stats.Where(s => s.Key != "Attributes"))
            {
                Console.WriteLine($"{stat.Key}: {stat.Value}");
            }

            Console.WriteLine("----Item Attributes----");
            

            foreach (var attribute in item.Rarity.Attributes)
            {
                Console.WriteLine($"{attribute}");
            }

            Console.WriteLine("--------------------");
        }
    }
}