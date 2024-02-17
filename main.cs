using System;

class Program
{
    static void Main(string[] args)
    {
        int X = 30; 

        for (int i = 1; i <= X; i++)
        {
            string output = i.ToString() + " - ";

            if (i % 3 == 0)
            {
                output += "Foo";
            }
            if (i % 5 == 0)
            {
                output += "Bar";
            }
            if (output == i.ToString() + " - ")
            {
                output += i.ToString();
            }

            Console.WriteLine(output);
        }
    }
}