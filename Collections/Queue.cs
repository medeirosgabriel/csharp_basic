using System;
using System.Collections.Generic;

class Queue {

    static void Main() {

        string[] array_colors = {"Red", "Blue", "Black"};

        Queue<string> colors = new Queue<string>(array_colors);

        colors.Enqueue("Gold");

        foreach (string c in colors) {
            Console.WriteLine("{0}", c);
        }

        Console.WriteLine("------------------");

        if (colors.Contains("Gold")) {
            Console.WriteLine("Contains");
        } else {
            Console.WriteLine("Doesn't contain");
        }
        
        Console.WriteLine("------------------");

        Console.WriteLine("Queue Size: {0}", colors.Count);

        Console.WriteLine("------------------");

        Console.WriteLine("First Element: {0}", colors.Dequeue());

        Console.WriteLine("------------------");

        Console.WriteLine("First Element: {0}", colors.Dequeue());

        Console.WriteLine("------------------");

        Console.WriteLine("Queue Size: {0}", colors.Count);

        Console.WriteLine("------------------");

        while (colors.Count > 0) {
            Console.WriteLine("Removed Element: {0}", colors.Dequeue());;
        }

        Console.WriteLine("Queue Size: {0}", colors.Count);

        Console.WriteLine("------------------");








    }
}