using System;

class For {

    static void Main(string[] args) {
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.GetLength(0); i++) {
            numbers[i] = 2*i;
        }

        for (int i = 0; i < numbers.GetLength(0); i++) {
            Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
        } 
    }
}