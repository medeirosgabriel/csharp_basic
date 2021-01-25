using System;
using System.Collections.Generic;

class List {

    static void Main() {
        List<string> colors_1 = new List<string>();
        List<string> colors_2 = new List<string>();

        colors_1.Add("Red");
        colors_1.Add("Blue");
        colors_1.Add("Black");
        colors_1.Add("Yellow");

        foreach (string c in colors_1) {
            Console.Write("{0} ", c);
        }

        Console.WriteLine("\n-------------------");

        colors_2.AddRange(colors_1);

        foreach (string c in colors_2) {
            Console.Write("{0} ", c);
        }

        Console.WriteLine("\n-------------------");

        if (colors_2.Contains("Blue")) {
            Console.WriteLine("Contains");
        } else {
            Console.WriteLine("Doesn't Contains");
        }

        foreach (string c in colors_2) {
            Console.WriteLine("Color: {0}   Position: {1}", 
                                    c, colors_2.IndexOf(c));
        }

        Console.WriteLine("-------------------");

        colors_2.Insert(1, "Gold");

        foreach (string c in colors_2) {
            Console.WriteLine("Color: {0}   Position: {1}", 
                                    c, colors_2.IndexOf(c));
        }

        Console.WriteLine("-------------------");

        colors_2.RemoveAt(1);

        foreach (string c in colors_2) {
            Console.WriteLine("Color: {0}   Position: {1}", 
                                    c, colors_2.IndexOf(c));
        }

        Console.WriteLine("-------------------");

        colors_2.Sort();

        foreach (string c in colors_2) {
            Console.WriteLine("Color: {0}   Position: {1}", 
                                    c, colors_2.IndexOf(c));
        }

        Console.WriteLine("-------------------");

        int size = colors_2.Count;
        
        Console.WriteLine("Colors_2 Count = {0}", size); 

        Console.WriteLine("-------------------");

        //colors_2.Capacity = 3;

        colors_2.Add("Green");

        foreach (string c in colors_2) {
            Console.WriteLine("Color: {0}   Position: {1}", 
                                    c, colors_2.IndexOf(c));
        }
        
    }
}