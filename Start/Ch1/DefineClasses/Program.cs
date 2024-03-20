// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions


// TODO: Change the values of width and height


Rectangle rectangle = new Rectangle(10,20);

Rectangle rectangle2 = new Rectangle(50,20);

System.Console.WriteLine(rectangle.GetArea());
System.Console.WriteLine(rectangle2.GetArea());

rectangle2.hight = 7;
rectangle2.witht = 5;
System.Console.WriteLine("-");

System.Console.WriteLine(rectangle2.GetArea());