using System.Security.Cryptography;

namespace GeometricShapes;

internal class Program {
    static void Main(string[] args) {

        Sqr s1 = new Sqr(6);
        Console.WriteLine($"The Perimeter for Sqr is {s1.Perimeter()} and the Area is {s1.Area()}.");

        Rect r1 = new Rect(5, 10);
        Console.WriteLine($"The Perimeter for Rect1 is {r1.Perimeter()} and the Area is {r1.Area()}.");

        Quad q1 = new Quad(3, 4, 5, 6);
        Console.WriteLine($"Perimeter for Quad1 is {q1.Perimeter()}.");
        Quad q2 = new Quad(11, 12, 13, 14);
        Console.WriteLine($"Perimeter for Quad2 is {q2.Perimeter()}.");

    }
}
