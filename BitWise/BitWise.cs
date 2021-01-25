using System;
class BitWise {
    static void Main() {
        int n1 = 10; // n = 10 = ...1010
        n1 = n1 << 1; // n = 20 = ...10100 -> Left shift
        Console.WriteLine(n1);
        int n2 = 10; // n = 10 = ...1010
        n2 = n2 >> 1; // n = 5 = ...0101 -> Right shift
        Console.WriteLine(n2);
    }
}