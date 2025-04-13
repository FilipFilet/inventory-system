using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class DoNothing : IUsage
{
    // Doesnt really matter what we do here, but we need to implement the interface
    public void Use(IItem item)
    {
        Console.WriteLine("This item has no direct use!");
    }
}