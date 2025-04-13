using InventoryLibrary.Interfaces;

namespace InventoryLibrary.Classes;

public class RareRarity : IRarity
{
    public string RarityName {get; set;} = "Rare";
    public string[] Attributes {get; set;} = new string[2];

    public RareRarity(string attribute1, string attribute2)
    {
        Attributes[0] = attribute1;
        Attributes[1] = attribute2;
    }
}