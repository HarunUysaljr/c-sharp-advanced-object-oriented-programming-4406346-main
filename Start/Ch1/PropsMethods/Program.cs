// Example file for Advanced C#: Object Oriented Programming by Joe Marini

// Create some rectangle objects
Rectangle rect1 = new Rectangle(10,20);
Rectangle rect2 = new Rectangle(30);

Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect2.GetArea());

// TODO: Operate on the Properties


// TODO: Try setting an invalid value
rect1.borderSize=5;


System.Console.WriteLine($"{rect1.borderSize}");
rect1.Height=-5;
rect1.Width=6;
System.Console.WriteLine($"{rect1.GetArea()}");