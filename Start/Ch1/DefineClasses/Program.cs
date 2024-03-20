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

System.Console.WriteLine("--PersonsExample--");


Persons persons = new Persons(14,2023);
System.Console.WriteLine(persons.GetArea());
System.Console.WriteLine("--");

persons.Vage = 24;
persons.Vyear = 2024;

System.Console.WriteLine(persons.GetArea());
