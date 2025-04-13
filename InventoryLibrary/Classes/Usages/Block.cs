using System;
using InventoryLibrary.Interfaces;

public class Block : IUsage
{
    public void Use(IItem item)
    {
        var stats = item.GetItemStats();
        Console.WriteLine($"Blocking the enemy attack with {stats["ItemName"]}, which has a {stats["DmgNegation"]} damage negation!");
    }
}