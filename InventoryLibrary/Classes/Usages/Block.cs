using System;
using InventoryLibrary.Interfaces;

public class Block : IUsage
{
    public void Use()
    {
        Console.WriteLine("Blocking the enemy attack");
    }
}