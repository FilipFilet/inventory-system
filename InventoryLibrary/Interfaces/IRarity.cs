namespace InventoryLibrary.Interfaces;

public interface IRarity
{
    string RarityName { get; set; }
    string[] Attributes { get; set; }
}