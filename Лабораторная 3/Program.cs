using System;

using RomanNumber_;

namespace Program
{
    class Program
    {
        private static void lab_2()
        {
            ushort t1 = ((ushort)23);
            ushort t2 = ((ushort)3);
            ushort t3 = ((ushort)15);
            ushort t4 = ((ushort)4);

            RomanNumber b1 = new RomanNumber(t1);
            RomanNumber b2 = new RomanNumber(t2);
            RomanNumber b3 = new RomanNumber(t3);
            RomanNumber b4 = new RomanNumber(t4);

            Console.WriteLine($"{t1} = " + b1.ToString());
            Console.WriteLine($"{t2} = " + b2.ToString());

            Console.WriteLine($"{t1} + {t2} = {t1 + t2} => " + b1.ToString() + " + " + b2.ToString() + " = " + (b1 + b2));
            Console.WriteLine($"{t1} - {t2} = {t1 - t2} => " + b1.ToString() + " - " + b2.ToString() + " = " + (b1 - b2));

            Console.WriteLine($"{t3} = " + b3.ToString());
            Console.WriteLine($"{t4} = " + b4.ToString());

            Console.WriteLine($"{t3} * {t4} = {t3 * t4} => " + b3.ToString() + " * " + b4.ToString() + " = " + (b3 * b4));
            Console.WriteLine($"{t3} / {t4} = {t3 / t4} => " + b3.ToString() + " / " + b4.ToString() + " = " + (b3 / b4));

            short[] Values = new short[]
            { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            RomanNumber[] b5 = new RomanNumber[Values.Length];

            Console.WriteLine("\nArray:");
            for (int i = 0; i < Values.Length; ++i)
            {
                b5[i] = new RomanNumber(((ushort)Values[i]));
                Console.Write(Values[i] + "(" + b5[i].ToString() + ")" + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nSorted Array:");
            Array.Sort(b5);
            foreach (object el in b5)
            {
                Console.Write(el.ToString() + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            lab_2();
        }
    }
}
