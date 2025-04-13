using InventoryLibrary.Interfaces;
namespace InventoryLibrary.Classes;

public class CommonRarity : IRarity
{
    public string RarityName {get; set;} = "Common";
    public string[] Attributes {get; set;} = new string[1];

    public CommonRarity(string attribute)
    {
        Attributes[0] = attribute;
    }
}