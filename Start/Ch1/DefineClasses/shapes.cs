// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword

    // TODO: The constructor accepts parameters used to create the object


    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size


    // TODO: Classes can define methods that return values


    // TODO: member variables hold data

class Rectangle{

    public Rectangle(int w, int h){
        witht = w;
        hight = h;

    }

    public Rectangle(int side)
    {
        witht = hight = side;
    }


    public int GetArea() => witht * hight;

    public int witht;
    public int hight;

}