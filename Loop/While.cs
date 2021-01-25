using System;

class While {

    static void Main(string[] args) {

        int i = 9;
        int[] numbers = new int[10];

        while (i >= 0) {
            numbers[i] = i;
            i--;
        }

        Console.WriteLine("Loop End");

        for (i = 0; i < numbers.GetLength(0); i++) {
            Console.Write("numbers[{0}] = {1} ", i, numbers[i]);
        }
    }
}