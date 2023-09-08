using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Octaves = new int[3, 12]
            {
                { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 },
                { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 },
                { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 },
            };
            int Octave = 0;
            int y = 0;
            int u = 404;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.A) // C 0
                {
                    u = 0;
                }
                else if (key.Key == ConsoleKey.S) // D 2
                {
                    u = 2;
                }
                else if (key.Key == ConsoleKey.D) // E 4
                {
                    u = 4;
                }
                else if (key.Key == ConsoleKey.F) // F 5
                {
                    u = 5;
                }
                else if (key.Key == ConsoleKey.G) // G  7
                {
                    u = 7;
                }
                else if (key.Key == ConsoleKey.H) // A 9
                {
                    u = 9;
                }
                else if (key.Key == ConsoleKey.J) // B 11
                {
                    u = 11;
                }
                else if (key.Key == ConsoleKey.Q) // C# 1
                {
                    u = 1;
                }
                else if (key.Key == ConsoleKey.E) // Eb 3 
                {
                    u = 3;
                }
                else if (key.Key == ConsoleKey.R) // F# 6
                {
                    u = 6;
                }
                else if (key.Key == ConsoleKey.T) // G# 8
                {
                    u = 8;
                }
                else if (key.Key == ConsoleKey.Y) // Bb 10
                {
                    u = 10;
                }

                else if (key.Key == ConsoleKey.F6)
                {
                    if (y > -1 & y < 2)
                    {
                        y++;
                    }
                    else
                    {
                        Console.WriteLine("Такой октавы нет.");
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                }
                else if (key.Key == ConsoleKey.F5)
                {
                    if (y > 0 & y < 3)
                    {
                        y--;
                    }
                    else
                    {
                        Console.WriteLine("Такой октавы нет.");
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                }
                if (u != 404)
                { 
                    Console.Beep(Octaves[y, u], 70);
                }
                u = 404;
                Console.Clear();

                }
                Console.Write("Ошибка");
            Console.ReadLine();

        }
    }
}
