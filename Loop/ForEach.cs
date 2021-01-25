using System;

class ForEach {

    static void Main(string[] args) {
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.GetLength(0); i++) {
            numbers[i] = 2*i;
        }

        foreach(int n in numbers) {
            Console.Write("{0} ", n);
        } 
    }
}