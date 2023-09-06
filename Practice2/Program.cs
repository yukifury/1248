using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] FirstOctave = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 }; // 0C 1C# 2D 3Eb 4E 5F 6F# 7G 8G# 9A 10Bb 11B
            int[] SecondOctave = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 }; // 0C 2D 4E 5F 7G 9A 11B
            int[] ThirdOctave = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 }; // C#1  Eb3  F#6 G#8 Bb10  
            int Octave = 0;
            while (true)
            { 
                while (Octave == 0)
                { // FirstOctaveMode
                    Console.WriteLine("Чтобы менять октавы используйте F5 и F6");
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.Clear();
                    if (key.Key == ConsoleKey.A) // C 0
                    {
                        Console.Beep(FirstOctave[0], 70);
                        
                    }
                    else if (key.Key == ConsoleKey.S) // D 2
                    {
                        Console.Beep(FirstOctave[2], 70);
                    }
                    else if (key.Key == ConsoleKey.D) // E 4
                    {
                        Console.Beep(FirstOctave[4], 70); ;
                    }
                    else if (key.Key == ConsoleKey.F) // F 5
                    {
                        Console.Beep(FirstOctave[5], 70);
                    }
                    else if (key.Key == ConsoleKey.G) // G  7
                    {
                        Console.Beep(FirstOctave[7], 70);
                    }
                    else if (key.Key == ConsoleKey.H) // A 9
                    {
                        Console.Beep(FirstOctave[9], 70);
                    }
                    else if (key.Key == ConsoleKey.J) // B 11
                    {
                        Console.Beep(FirstOctave[11], 70);
                    }
                    else if (key.Key == ConsoleKey.Q) // C# 1
                    {
                        Console.Beep(FirstOctave[1], 70);
                    }
                    else if (key.Key == ConsoleKey.E) // Eb 3 
                    {
                        Console.Beep(FirstOctave[3], 70);
                    }
                    else if (key.Key == ConsoleKey.R) // F# 6
                    {
                        Console.Beep(FirstOctave[6], 70);
                    }
                    else if (key.Key == ConsoleKey.T) // G# 8
                    {
                        Console.Beep(FirstOctave[8], 70);  
                    }
                    else if (key.Key == ConsoleKey.Y) // Bb 10
                    {
                        Console.Beep(FirstOctave[10], 70); 
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
                    Console.Clear();
                    if (key.Key == ConsoleKey.A) // C 0
                    {
                        Console.Beep(SecondOctave[0], 70);

                    }
                    else if (key.Key == ConsoleKey.S) // D 2
                    {
                        Console.Beep(SecondOctave[2], 70);
                    }
                    else if (key.Key == ConsoleKey.D) // E 4
                    {
                        Console.Beep(SecondOctave[4], 70); ;
                    }
                    else if (key.Key == ConsoleKey.F) // F 5
                    {
                        Console.Beep(SecondOctave[5], 70);
                    }
                    else if (key.Key == ConsoleKey.G) // G  7
                    {
                        Console.Beep(SecondOctave[7], 70);
                    }
                    else if (key.Key == ConsoleKey.H) // A 9
                    {
                        Console.Beep(SecondOctave[9], 70);
                    }
                    else if (key.Key == ConsoleKey.J) // B 11
                    {
                        Console.Beep(SecondOctave[11], 70);
                    }
                    else if (key.Key == ConsoleKey.Q) // C# 1
                    {
                        Console.Beep(SecondOctave[1], 70);
                    }
                    else if (key.Key == ConsoleKey.E) // Eb 3
                    {
                        Console.Beep(SecondOctave[3], 70);
                    }
                    else if (key.Key == ConsoleKey.R) // F# 6
                    {
                        Console.Beep(SecondOctave[6], 70);
                    }
                    else if (key.Key == ConsoleKey.T) // G# 8
                    {
                        Console.Beep(SecondOctave[8], 70);
                    }
                    else if (key.Key == ConsoleKey.Y) // Bb 10
                    {
                        Console.Beep(SecondOctave[10], 70);
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
                        Console.WriteLine("Смена октавы вверх...");
                        Thread.Sleep(200);
                        Console.Clear();
                        Octave++;

                    }
                }
                while (Octave == 2) // ThirdOctaveMode
                { 
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.Clear();
                    if (key.Key == ConsoleKey.A) // C 0
                    {
                        Console.Beep(ThirdOctave[0], 70);

                    }
                    else if (key.Key == ConsoleKey.S) // D 2
                    {
                        Console.Beep(ThirdOctave[2], 70);
                    }
                    else if (key.Key == ConsoleKey.D) // E 4
                    {
                        Console.Beep(ThirdOctave[4], 70); ;
                    }
                    else if (key.Key == ConsoleKey.F) // F 5
                    {
                        Console.Beep(ThirdOctave[5], 70);
                    }
                    else if (key.Key == ConsoleKey.G) // G  7
                    {
                        Console.Beep(ThirdOctave[7], 70);
                    }
                    else if (key.Key == ConsoleKey.H) // A 9
                    {
                        Console.Beep(ThirdOctave[9], 70);
                    }
                    else if (key.Key == ConsoleKey.J) // B 11
                    {
                        Console.Beep(ThirdOctave[11], 70);
                    }
                    else if (key.Key == ConsoleKey.Q) // C# 1
                    {
                        Console.Beep(ThirdOctave[1], 70);
                    }
                    else if (key.Key == ConsoleKey.E) // Eb 3
                    {
                        Console.Beep(ThirdOctave[3], 70);
                    }
                    else if (key.Key == ConsoleKey.R) // F# 6
                    {
                        Console.Beep(ThirdOctave[6], 70);
                    }
                    else if (key.Key == ConsoleKey.T) // G# 8
                    {
                        Console.Beep(ThirdOctave[8], 70);
                    }
                    else if (key.Key == ConsoleKey.Y) // Bb 10
                    {
                        Console.Beep(ThirdOctave[10], 70);
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
            Console.Write("Ошибка");
            Console.ReadLine();

        }
    }
}
