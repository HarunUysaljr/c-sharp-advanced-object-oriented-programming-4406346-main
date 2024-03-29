// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Working with properties and methods

// Define a class using the "class" keyword
class Rectangle {
    // The constructor accepts parameters used to create the object
    public Rectangle(int w, int h) {
        width = w;
        height = h;
    }

    // For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle(int side) {
        width = height = side;
    }

    // Classes can define methods that return values
    public int GetArea() {
        return width * height;
    }

    // TODO: Define Properties that allow access to the private data
    // These are called "backing field" properties
    public int Width
    {
        get { return  width; }
        set { width = value; }
    }
    public int Height
    {
        get{ return height; }
        set{ if (value < 0) 
        {
            throw new ArgumentOutOfRangeException("Height", "Sıfırdan küçük olamaz");
        }
            height = value;
        }
    }

    // TODO: Auto-implmeneted properties don't have a backing field

    public int borderSize
    {
        get; set;
    } = 1;

    // Properties and member variables hold data

    int width;
    int height;
}

class Araba{
    private string? marka;

    public string Marka{
        get{
            return marka;
        }
        set{
            marka = value;
        }
    }
}

public class Book
{
    private string title;
    private string author;
    private int pageNumber;

    // Başlık özelliği
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    // Yazar özelliği
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    // Sayfa sayısı özelliği
    public int PageNumber
    {
        get { return pageNumber; }
        set { pageNumber = value; }
    }

    // Kelime sayısı hesaplayan read-only property
    public int WordCount
    {
        get
        {
            // Basit bir kelime sayısı hesaplama: her kelime boşluk karakterinden sonra başlar
            // ve boşluk karakteri olmadan bir sonraki boşluğa kadar devam eder
            string[] words = title.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Length;
            return count;
        }
    }

    // Ortalama kelime uzunluğu hesaplayan read-only property
    public double AverageWordLength
    {
        get
        {
            // Tüm kelime uzunluklarının toplamını al ve kelime sayısına böl
            string[] words = title.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int totalLength = 0;
            foreach (string word in words)
            {
                totalLength += word.Length;
            }
            double averageLength = (double)totalLength / WordCount;
            return averageLength;
        }
    }
}
