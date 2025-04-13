using InventoryLibrary.Interfaces;
using System;
namespace InventoryLibrary.Classes;

public class Swing : IUsage
{
    public void Use(IItem item)
    {
        var stats = item.GetItemStats();
        Console.WriteLine($"Swinging {stats["ItemName"]} at the enemy, dealing {stats["Damage"]} damage!");
    }
}