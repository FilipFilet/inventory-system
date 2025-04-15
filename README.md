# Description of the Inventory System project
The idea cacme to me that i kinda wanted to make an inventory system, such as those found in video games. I thought this would be a fun little project for learning and reinforce good software design, and how to efficiently build an application for maintainability, scalability and so on. One of the things i inforce in this project is the use of the SOLID principles. A normal inventory system used in games are of course more complex than this, but again, i saw this as a golden opportunity to learn and get better.

# Functionality of the Inventory System.
The inventory System should consist of an Inventory Class, which holds a list of items. An item can either be  of a common, rare or legendary rarity. The common items have one unique attribute, where the rare have two and the legendary have three, otherwise they have the same properties with different values. There are of course also different kinds of items, such as swords, bows, staffs and potions, which have their own use defined by their type. Some items might even not be usable!

# Class Diagram
Based on the description and functionality, i made a class diagram, depicting how the system should look like:

![Class Diagram](https://github.com/FilipFilet/inventory-system/raw/master/Attachments/ClassDiagram.jpg)