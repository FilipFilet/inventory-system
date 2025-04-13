using System;
using InventoryLibrary.Interfaces;

public class Drink : IUsage
{
    public void Use(IItem item)
    {
        var stats = item.GetItemStats();
        Console.WriteLine($"Drinking the {stats["ItemName"]}, which has a {stats["Effect"]} effect!");
    }
}