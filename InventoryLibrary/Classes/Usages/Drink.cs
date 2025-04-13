using System;
using InventoryLibrary.Interfaces;

public class Drink : IUsage
{
    public void Use()
    {
        Console.WriteLine("Drinking the potion");
    }
}