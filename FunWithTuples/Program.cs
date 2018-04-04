using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {

            (string, int, string) values = ("a", 5, "c");

            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");

            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");

            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");

            //Using the item notation still works!
            Console.WriteLine($"First item: {valuesWithNames.Item1}");
            Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            Console.WriteLine($"Third item: {valuesWithNames.Item3}");

            Console.WriteLine("=> Inferred Tuple Names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1}, {bar.Prop2}");

            FillTheseValues(out int a, out string b, out bool c);
            var samples = (a, b, c);
            Console.WriteLine("Int is: {0}", samples.a);
            Console.WriteLine("String is: {0}", samples.b);
            Console.WriteLine("Bool is: {0}", samples.c);

            Console.WriteLine();

            var samples2 = FillTheseValues2();
            Console.WriteLine($"Int is {samples2.a}");
            Console.WriteLine($"String is {samples2.b}");
            Console.WriteLine($"Bool is {samples2.c}");

            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first}:{last}");

            Console.WriteLine();

            Point p = new Point(7, 5);
            var pointValues = p.Deconstruct();
            Console.WriteLine($"X is: {pointValues.xpos}");
            Console.WriteLine($"Y is: {pointValues.ypos}");


        }

        static void FillTheseValues (out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        static (int a, string b, bool c) FillTheseValues2()
        {
            return (10, "Noice!", false);
        }

        static (string first, string middle, string last) SplitNames(string fullName)
        {
            //do what is needed to split the name apart
            return ("Philip", "F", "Japikse");
        }

        struct Point
        {
            //Fields
            public int x;
            public int y;

            //constructor
            public Point (int xpos, int ypos)
            {
                x = xpos;
                y = ypos;
            }

            public (int xpos, int ypos) Deconstruct() => (x, y);
        }
    }
}
