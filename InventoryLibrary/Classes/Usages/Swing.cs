using InventoryLibrary.Interfaces;
using System;
namespace InventoryLibrary.Classes;

public class Swing : IUsage
{
    public void Use()
    {
        Console.WriteLine("Swinging at the enemy");
    }
}