// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 12 * 30;

Console.WriteLine(x); // Single line comment

/*
 * Multi line comment.
 */ 

int @int = 16;

Console.WriteLine(@int);

string helloWorld = "Hello World"; // String is a pre-defined type. It represent a sequence of characters.
// Pre-defined types are called built-in types. 

int y = helloWorld.ToString().Length;
DateTime dt =DateTime.Now;

float re = 4.9999F;

int po = (int)re; // No rounding is performed, instead the fraction is truncated
Console.WriteLine(po);

int i1 = 1000000001;
float f1 = i1; // Precision is lost
int i2 = (int)f1;
Console.WriteLine(i2); // Precision is lost

UnitConverter _ = new UnitConverter(10);
Console.WriteLine(_.Convert(20));
Console.WriteLine(UnitConverter.Population);

// Public members encapsulate private members.
// Non-zero value returned from main method indicate an error. 

int p = 10;

long t = 20L;

nint n = 30;

long l = 1_100_000_300; // Underscores are allowed.
decimal dd = 200M;

int converted = (int)t; // Explicit conversion because of the lossy behaviour

n.Incoming incoming = new n.Incoming();


int getData()
{
    return 10;
}

namespace n
{
    public struct Point { public int X, Y; } // Assignment of 

    public class Incoming
    {
        public Incoming()
        { 
            Point p = new Point();
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p.X);
        }
    }
}



namespace MyAnimals { 

    public class Animal
    {
        
    }
}

class UnitConverter
{
    public static int Population = default;

    private readonly int _ratio = 0; // member

    public UnitConverter(int ratio)
    {
        _ratio = ratio;
        Population += Population;
    }

    public int Convert(int y) // method
    {
        return y;
    }
}