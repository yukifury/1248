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
            int[] FirstOctave = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] SecondOctave = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] ThirdOctave = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            int Octave = 0;
            while (Octave == 0)
            { // FirstOctaveMode
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(FirstOctave[1], 100);
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(FirstOctave[2], 100);
                }
                else if (key.Key == ConsoleKey.F6)
                {
                    Console.WriteLine("Смена откавы вверх...");
                    Thread.Sleep(200);
                    Console.Clear();
                    Octave++;
                 
                }
            }
            while (Octave == 1) // SecondOctaveMode
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(SecondOctave[1], 100);
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(SecondOctave[2], 100);
                }
                else if (key.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("Смена октавы вниз...");
                    Thread.Sleep(200);
                    Console.Clear();
                    Octave--;
                }
                else if (key.Key == ConsoleKey.F6)
                {
                    Console.WriteLine("Смена откавы вверх...");
                    Thread.Sleep(200);
                    Console.Clear();
                    Octave++;

                }
            }
            while (Octave == 2)
            { // FirstOctaveMode
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(ThirdOctave[1], 100);
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(ThirdOctave[2], 100);
                }
                else if (key.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("Смена откавы вниз...");
                    Thread.Sleep(200);
                    Console.Clear();
                    Octave--;

                }
            }

        }
        static int OctaveCore()
        {
            int NullPointerException = 404;
            int OctaveSwitcher = 1;
            int OctaveNum = OctaveCore();
            if (OctaveNum == 1)
            {
                OctaveSwitcher = 2;
                
            }

            return NullPointerException;
        }
    }
}
