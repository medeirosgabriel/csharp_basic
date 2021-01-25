using System;

class Value_Reference {
    static void Main (string[] args) {
        int n = 10;
        doubleF(ref n);
        Console.WriteLine(n);
    }

    static void doubleF(ref int n) {
        n *= 2;
    }
}