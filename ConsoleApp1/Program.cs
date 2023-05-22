using System;

namespace ConsoleApp1
{
    public class Strings
    {
        protected string value;

        public Strings(string value)
        {
            this.value = value;
        }

        public int CalculateLength()
        {
            return value.Length;
        }
    }

    public class SymbolStrings : Strings
    {
        public SymbolStrings(string value) : base(value)
        {
        }

        public void SortDescending()
        {
            char[] chars = value.ToCharArray();
            Array.Sort(chars, (a, b) => -1 * a.CompareTo(b));
            value = new string(chars);
        }

        public void DisplayString()
        {
            Console.WriteLine(value);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введіть рядок: ");
            string input = Console.ReadLine();

            SymbolStrings symbolStrings = new SymbolStrings(input);

            int length = symbolStrings.CalculateLength();
            Console.WriteLine("Довжина рядка: " + length);

            symbolStrings.SortDescending();
            Console.WriteLine("Відсортований рядок: ");
            symbolStrings.DisplayString();
        }
    }
}
