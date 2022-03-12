using System;
using System.Collections.Generic;
using System.IO;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string[] lines = File.ReadAllLines(args[0]);
                List<int> ints = new();

                foreach (string numbers in lines)
                {
                    foreach (var number in numbers.Split())
                        ints.Add(int.Parse(number));
                }

                int sum = 0;

                for (int i = 0; i < ints.Count; i++)
                {
                    sum += ints[i];
                }

                int avg = sum / ints.Count;
                int score = 0;

                for (int i = 0; i < ints.Count; i++)
                {
                    while (ints[i] != avg)
                    {
                        if (ints[i] > avg)
                        {
                            ints[i]--;
                            score++;
                        }
                        else
                        {
                            ints[i]++;
                            score++;
                        }
                    }
                }

                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("args.Length != 1");
            }
        }
    }
}
