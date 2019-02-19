using System;

namespace problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text.EndsWith('y'))
            {
                text = text.Remove(text.Length - 1);
                text += "ies";
            }
            else if (text.EndsWith('o') || text.EndsWith("ch") || text.EndsWith('s') || text.EndsWith("sh") || text.EndsWith('x') || text.EndsWith('z'))
            {
                text += "es";
            }
            else
            {
                text += "s";
            }

            Console.WriteLine(text);
        }
    }
}