﻿// See https://aka.ms/new-console-template for more information
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

int a = 1_000_000;
int b = 1_000_000;

int d = a * b; // Overflow, but it is silient because it is not checked.
Console.WriteLine(d);

//int c = checked(a * b); // Throws an exception because overflow is not silent 
//Console.WriteLine(c);

// Note, decimals automatically wraps around; no impact by applying checked statement

int e = a * b; // No exception is thrown because the wrap around is automatic and silent.
Console.WriteLine(e);

// Project level setting to control arithmatic checking. Project -> "Your program" setting -> Build -> Advanced (check arithmatic overflow)
// 

// int h = int.MaxValue + 1; // This errors in compile time.
int f = unchecked(int.MaxValue + 1); // No error

short i = 1, j = 2;
// short k = i + j; // Compile time error because i and j are implicitly converted to int as they lack their own arithmatic operators
// Casting is required to assign the value back to k which is a short, 16-bit integral value. 

Console.WriteLine(double.NegativeInfinity);

Console.WriteLine(1.0 / 0.0); // Positive infinity (which is printed in console)
Console.WriteLine(0.0 / 0.0); // Not a number (NaN - which is printed in console)

// double type is base 2 and native to the processor whereas decimal is a base 10 non-native to the processor.
// double AND floats are presented in base 2 and only numbers expressible in base 2 can be presented precisely. 

// Use BitArray to store a collection of booleans because of the efficient use of space. 

// Classic: For value types the equality (==) is based on the actual value whereas for reference types its the reference we compare (==) which always return false.
// Enums are compared with its underlying integral value.

// Concept of short-cutting for boolean evaluations (& - non-shortcutting and && - shortcutting)
// & and | is perform bitwise operations when applied to numbers.

char newLine = '\u00A9'; // Escape sequence, single quote
Console.WriteLine(newLine);

// String represent an immutable sequence of unicode characters.
// Verbatim string representations
string verbatim = @"verbatim\string\single\""quote""";
Console.WriteLine(verbatim);

string concat = "first" + 2; // Works because ToString is called on the value
string concat2 = 2 + "third"; // Same as above, that means order does not matter

string interString = "4";
Console.WriteLine($"The interString here {interString}");
Console.WriteLine($"255 in hex is {byte.MaxValue:X2}"); // Formatting is possible within interpolated strings
// Inteoplated strings must complete in a single line unless verbitim strings are used.

// string does not support > or < instead ComparedTo must be used

// Arrays are contigious block of memory for faster access.
// Once an array has been created it cannot be resized
int[] someArray = new int[15];
Console.WriteLine(someArray.Length); // Returns the length of the array.
// System.Collection namespace offers higher level data structures
int[] anotherArray = new int[] { 1, 2, 3 };
// Initialising arrays sets element values to zero (default value)

// Note that if the array element type is a value, then part
// of the memory is allocated. Essentially values are stored
// in the array memory locations itself.
// When the array value type is a reference type, then each element
// is assigned a null value.
// Array itself is a reference type int[] a = null is legal.

// Indicies - refers to an element in an array
char[] malinda = new char[] { 'm', 'a', 'l', 'i', 'n', 'd', 'a' };
Console.WriteLine(malinda[^1]); // Last element "a"
Index lastTwo = ^2;
Console.WriteLine(malinda[lastTwo]); // Note the new Index type.

// Ranges - slices an array
Console.WriteLine(malinda[..2]); // First two "m" and "a"
Console.WriteLine(malinda[2..]); // Element 3 to the end

Range firstTwo = ..2;
Console.WriteLine(malinda[firstTwo]);
Range lastTwoChars = ^2..;
Console.WriteLine(malinda[lastTwoChars]);
// Remember hat sign refers from the end of the array.

// Multidimentional array - rectangular (n-dimentional) or jagged (array of arrays)
int[,] matrix = new int[3,3]; // Matrix of 3x3 


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

