﻿using System;

namespace CSNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (args.GetLength(0) > 0) {
                Console.WriteLine(args.GetValue(0)); // Terminal Parameter
            }
        }
    }
}
