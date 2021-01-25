using System;
using System.Collections.Generic;

class LinkedList {

    static void Main() {
        LinkedList<string> colors = new LinkedList<string>();

        colors.AddFirst("Blue");
        colors.AddFirst("Black");
        colors.AddFirst("Yellow");
        colors.AddFirst("Red");

        colors.AddLast("Gold");

        foreach (string c in colors) {
            Console.Write("{0} ", c);
        }

        Console.WriteLine("");

        LinkedListNode<string> node;

        node = colors.FindLast("Red");

        colors.AddAfter(node, "Gold");

        foreach (string c in colors) {
            Console.Write("{0} ", c);
        }

        if (colors.Find("Blue") == null) {
            Console.WriteLine("\nColor Not Found");
        } else {
            Console.WriteLine("\nColor Found");
        }

        colors.Remove("Blue");

        foreach (string c in colors) {
            Console.Write("{0} ", c);
        }
    }
}