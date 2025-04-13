using InventoryLibrary.Interfaces;

namespace InventoryLibrary.Classes;

public class LegendaryRarity : IRarity
{
    public string RarityName { get; set; } = "Legendary";
    public string[] Attributes { get; set; } = new string[3];

    public LegendaryRarity(string attribute1, string attribute2, string attribute3)
    {
        Attributes[0] = attribute1;
        Attributes[1] = attribute2;
        Attributes[2] = attribute3;
    }
}