using System;
using InventoryLibrary.Interfaces;

public class Shoot : IUsage
{
    public void Use(IItem item)
    {
        var stats = item.GetItemStats();
        Console.WriteLine($"Shooting at the enemy with {stats["ItemName"]}, and deals {stats["Damage"]} damage!");
    }
}