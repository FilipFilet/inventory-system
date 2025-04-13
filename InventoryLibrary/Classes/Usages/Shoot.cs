using System;
using InventoryLibrary.Interfaces;

public class Shoot : IUsage
{
    public void Use()
    {
        Console.WriteLine("Shooting at the enemy");
    }
}