using InventoryLibrary.Classes;
using InventoryLibrary.Interfaces;

// Setting up items
IItem sword = new Sword("Steel Sword", new CommonRarity("1% extra lifesteal"), 100, 10.0);
IItem shield = new Shield("Knights Shield", new RareRarity("Chance to parry attacks", "Enemies takes damage when blocked"), 100, 95.0);
IItem bow = new Bow("Fiery Longbow", new RareRarity("Chance to shoot two arrows", "Shoots fire arrows once in a while"), 30, 70.0, 100);
IItem potion = new Potion("Health Potion", new CommonRarity("If health is below 50%, heal additional 100 health"), "Heals 200 health");
IItem ring = new Ring("Ring of Power", new LegendaryRarity("Increases damage by 20%", "If health is below 30%, increase attack by 30%", "Burns enemies for 10 damage each second, for 20 seconds"), 100);

Inventory inventory = new Inventory();
inventory.AddItem(sword);
inventory.AddItem(shield);
inventory.AddItem(bow);
inventory.AddItem(potion);
inventory.AddItem(ring);

Printer.PrintInventory(inventory);

sword.UseItem();