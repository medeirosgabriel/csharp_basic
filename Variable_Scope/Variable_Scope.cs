using System;

class Variable_Scope {

    static int num3 = 3; // Static to use in the static method

    static void Main() {
       int num1 = 1;
       Console.WriteLine(num1);
       Console.WriteLine(num3);
       test();
    }

    static void test() {
        int num2 = 2;
        // Console.WriteLine(num1); Error
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }
}