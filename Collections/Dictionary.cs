using System;
using System.Collections.Generic;

class Dictionary {

    static void Main() {

        Dictionary<int, string> colors = new Dictionary<int, string>();

        colors.Add(1,"Yellow");
        colors.Add(2,"Red");
        colors.Add(3,"Blue");
        colors.Add(4,"Green");
        colors.Add(5,"Brown");

        Console.WriteLine("Dictionary Size: {0}", colors.Count);

        colors.Clear();
        Console.WriteLine("Dictionary Size: {0}", colors.Count);

        colors.Add(1,"Yellow");
        colors.Add(2,"Red");
        colors.Add(3,"Blue");
        colors.Add(4,"Green");
        colors.Add(5,"Brown");

        if (colors.ContainsKey(3)) {
            Console.WriteLine("Value = ", colors[3]);
        } else {
            Console.WriteLine("Absent!");
        }

        if (colors.ContainsValue("Balck")) {
            Console.WriteLine("Contains!");
        } else {
            Console.WriteLine("Doesn't contain!");
        }

        colors[6] = "Black";

        Dictionary<int, string>.ValueCollection values = colors.Values;

        foreach (string v in values) {
            Console.Write("{0} ", v);
        }
        Console.WriteLine("");

        foreach (KeyValuePair<int, string> v in colors) {
            Console.WriteLine("{0} - {1}", v.Key, v.Value);
        }

    }
}