using System;
using System.Collections.Generic;
using System.IO;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                string[] lines = File.ReadAllLines(args[0]);
                Queue<float> circle = new();

                foreach (string numbers in lines)
                {
                    foreach (var number in numbers.Split())
                        circle.Enqueue(float.Parse(number));
                }

                lines = File.ReadAllLines(args[1]);
                Queue<float> points = new();

                foreach (string numbers in lines)
                {
                    foreach (var number in numbers.Split())
                        points.Enqueue(float.Parse(number));
                }

                float Xc, Yc, Rc;
                Xc = circle.Dequeue();
                Yc = circle.Dequeue();
                Rc = circle.Dequeue();

                int lenght = points.Count / 2;
                float[,] coor = new float[lenght, 2];
                for (int i = 0; i < lenght; i++)
                    for (int j = 0; j < 2; j++)
                    {
                        coor[i, j] = points.Dequeue();
                    }

                for (int i = 0; i < coor.GetLength(0); i++)
                {
                    if (Math.Pow(coor[i, 0] - Xc, 2) + Math.Pow(coor[i, 1] - Yc, 2) < Math.Pow(Rc, 2))
                    {
                        Console.WriteLine("1");
                    }
                    else if (Math.Pow(coor[i, 0] - Xc, 2) + Math.Pow(coor[i, 1] - Yc, 2) == Math.Pow(Rc, 2))
                    {
                        Console.WriteLine("0");
                    }
                    else Console.WriteLine("2");
                }
            }
            else
            {
                Console.WriteLine("args.Length != 2");
            }
        }
    }
}
