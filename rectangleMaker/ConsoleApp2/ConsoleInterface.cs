using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp2
{
    class ConsoleInterface
    {
        static void Main()
        {
            makeQuad(16, 16, '#');
            Console.ReadKey();
        }
        static void makeQuad(int x, int y, char character = '@')
        {
            //column configuration
            string xaxis = string.Empty;
            for (int i = 0; i < x; i++)
            {
                xaxis += character + " ";
            }
            //writing to row
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine(xaxis);
            }
        }
    }

}