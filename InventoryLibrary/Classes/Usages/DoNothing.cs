using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class DoNothing : IUsage
{
    public void Use()
    {
        Console.WriteLine("This item has no direct use!");
    }
}