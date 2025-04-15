# Description of the Inventory System project
The idea cacme to me that i kinda wanted to make an inventory system, such as those found in video games. I thought this would be a fun little project for learning and reinforce good software design, and how to efficiently build an application for maintainability, scalability and so on. One of the things i inforce in this project is the use of the SOLID principles. A normal inventory system used in games are of course more complex than this, but again, i saw this as a golden opportunity to learn and get better.

## How to run the project?
To run the project, run it through the console application project called `InventoryConsole`. For example in vs code, just navigate to that folder, and type dotnet run in the terminal.

# Functionality of the Inventory System.
The inventory System should consist of an Inventory Class, which holds a list of items. An item can either be  of a common, rare or legendary rarity. The common items have one unique attribute, where the rare have two and the legendary have three, otherwise they have the same properties with different values. There are of course also different kinds of items, such as swords, bows, staffs and potions, which have their own use defined by their type. Some items might even not be usable!

# Class Diagram
Based on the description and functionality, i made a class diagram, depicting how the system should look like:

![Class Diagram](https://github.com/FilipFilet/inventory-system/raw/main/Attachments/ClassDiagram.jpg)
This class diagram shows how the system should look like in terms of what it should do, and how it is organized. While designing the class diagram i paid attention to adhere to the SOLID principles and also use the Strategy Pattern. The strategy pattern can be seen in play through the IUsage interface. Here a family of strategies (algoritms) are designed, making them interchangable through the interface. In each item type (Sword,  Bow, Shield etc.) is where the appropriate strategy gets assigned, and can be changed easily later on!

# Reflection and adherence to SOLID
There were some challenges with this project, such as how to eliminate code smells. One particular code smell present is, if we change something in an item, perhaps add a crit chance, then that could ripple out to the specific use strategy. This is because each strategy uses the `GetItemStats()` of the item it handles, and if something is added (crit chance), then some calculations (which isnt implemented, but could be in the future), is to be modified, making that ripple effect.
As to how the system adheres to SOLID, an overview can be seen below:

- **SRP:** This is mainly through the "printer" class. Originally the print method was in the Inventory class, but but since this added another responsability, i could extract it into another class. This is a bit overkill for such a small system, but if i wanted to extend the printing functionality, then that would make it quite alot easier.
- **OCP:** This can be seen in the `IRarity` interface for example. Here it is easy to extend and add another rarity, without modifying.
- **LSP:** The IItem interface is interchangable with its concrete implementations, without affecting behavior.
- **ISP:** The Sword item isnt dependent on methods it doesnt use. It uses the methods it implements. The interfaces are also kept as specific as possible.
- **DIP:** I made interfaces where a module would need to depend on another. This makes interchangability easier.