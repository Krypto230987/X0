using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawField();
            int[,] array = new int[3, 3];
            string mark = "";
            int x = 0, y = 0;
            int order = 1;
            for(int i = 0; i<3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = -1;
                }
            }
            while (mark != "stop")
            {
                Console.WriteLine("Order: " + (order == 0 ? "0" : "X"));
                x = Convert.ToInt32(Console.ReadLine() ?? "0");
                y = Convert.ToInt32(Console.ReadLine() ?? "0");
                PutMark(order == 0 ? "0": "x", x, y);
                array[x,y] = order;
                if(order == 1)
                {
                    if (array[0, 0] == 1 && array[0, 1] == 1 && array[0,2] == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[0, 1] == 1 && array[1, 1] == 1 && array[2, 1] == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[0, 2] == 1 && array[1, 2] == '1' && array[2, 2] == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[0, 0] == 1 && array[0, 1] == 1 && array[0, 2] == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[1, 0] == 1 && array[1, 1] == 1 && array[1, 2] == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[2, 0] == 1 && array[2, 1] == 1 && array[2, 2] == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[0, 0] == 1 && array[1, 1] == 1 && array[2, 2] == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[2, 0] == 1 && array[1, 1] == 1 && array[0, 2] == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }

                }
                if (order == 0)
                {
                    if (array[0, 0] == 0 && array[0, 1] == 0 && array[0, 2] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win 0");
                    }
                    if (array[0, 1] == 0 && array[1, 1] == 0 && array[2, 1] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[0, 2] == 0 && array[1, 2] == 0 && array[2, 2] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win X");
                    }
                    if (array[0, 0] == 0 && array[0, 1] == 0 && array[0, 2] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win 0");
                    }
                    if (array[1, 0] == 0 && array[1, 1] == 0 && array[1, 2] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win 0");
                    }
                    if (array[2, 0] == 0 && array[2, 1] == 0 && array[2, 2] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win 0");
                    }
                    if (array[0, 0] == 0 && array[1, 1] == 0 && array[2, 2] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win 0");
                    }
                    if (array[2, 0] == 0 && array[1, 1] == 0 && array[0, 2] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Win 0");
                    }
                }
                order = (order + 1) % 2;
                Console.SetCursorPosition(0, 5);
            }

        }
        static void DrawField()
        {
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
        }

        static bool PutMark(string mark, int x, int y)
        {
            if (x > 2 || x < 0 || y > 2 || y < 0) return false;
            Console.SetCursorPosition((x * 4) + 1, y * 2);
            Console.Write(mark);
            return true;
        }

    }
}
