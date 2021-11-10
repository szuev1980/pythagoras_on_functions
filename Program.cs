using System;

namespace FUNCTIONS_PIFAGOR
{
    class Program
    {
        static int GetMax(int first, int second) 
        {
            int max = first * second;

            int digitMax = 0;

            for (int a = max; 0 < a; digitMax++)
            {
                a /= 10;
            }
            return digitMax;
        }

        static void Pifagor(int firstX, int lastX, int firstY, int lastY)
        {
            int max = lastX * lastY;

            int digitMax = GetMax(lastX, lastY);

            Console.WriteLine();

            for (int count = lastY; 0 < count; count /= 10)
            {
                Console.Write(" ");
            }
            Console.Write(" ");
            Console.Write("|");

            for (int toprow = firstX; toprow <= lastX; toprow++)
            {
                int count = 0;
                for (int i = toprow; i > 0; i /= 10)
                {
                    count++;
                }

                for (int topspaces = digitMax - count; 0 <= topspaces; topspaces--)
                {
                    Console.Write(" ");
                }
                Console.Write(toprow);
            }
            Console.WriteLine();

            for (int counthyphen = lastY; 0 < counthyphen; counthyphen /= 10)
            {
                Console.Write("-");
            }
            Console.Write("-");
            Console.Write("+");

            for (int hyphenrow = firstX; hyphenrow <= lastX; hyphenrow++)
            {
                for (int counthyphenrow = max; counthyphenrow > 0; counthyphenrow /= 10)
                {
                    Console.Write("-");
                }
                Console.Write("-");
            }

            for (int downrow = lastX; 0 < downrow; downrow /= 10)
            {
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int a = firstY; a <= lastY; a++)
            {
                int counterY = 0;

                for (int z = lastY; 0 < z; counterY++)
                {
                    z /= 10;
                }

                int countY = 0;
                for (int i = a; i > 0; i /= 10)
                {
                    countY++;
                }

                for (int downspaces = counterY - countY; 0 <= downspaces; downspaces--)
                {
                    Console.Write(" ");
                }

                Console.Write(a);

                Console.Write("|");

                for (int b = firstX; b <= lastX; b++)
                {
                    int count = 0;
                    for (int i = a * b; i > 0; i /= 10)
                    {
                        count++;
                    }

                    for (int spaces = digitMax - count; 0 <= spaces; spaces--)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(a * b);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first X");
            int firstX = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter last X");
            int lastX = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first Y");
            int firstY = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter last Y");
            int lastY = int.Parse(Console.ReadLine());

            Pifagor(firstX, lastX, firstY, lastY);
        }
    }
}

