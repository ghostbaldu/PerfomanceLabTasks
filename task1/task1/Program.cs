using System;
using System.Collections.Generic;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int N = Convert.ToInt32(args[0]);
                int M = Convert.ToInt32(args[1]);

                Queue<int> qu1 = new();
                Queue<int> qu2 = new();

                bool fl = true;

                while (fl)
                {
                    for (int i = 0; i < Math.Ceiling((double)M / (double)N); i++)
                    {
                        for (int j = 1; j < N + 1; j++)
                            qu1.Enqueue(j);
                    }

                    qu2.Enqueue(qu1.Peek());
                    for (int i = 0; i < M; i++)
                    {
                        if (i != M - 1)
                        {
                            qu1.Dequeue();
                        }
                        else
                        {
                            if (qu1.Peek() == 1)
                                fl = false;
                        }
                    }
                }

                while (qu2.Count > 0)
                    Console.Write(qu2.Dequeue());
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("args.Length != 2");
            }
        }
    }
}
