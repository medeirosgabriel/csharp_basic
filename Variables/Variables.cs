using System;

class Variables {
    static void Main() {
        byte nb = 10; // 0 - 255
        int num = 0;
        char word = 'c';
        float value = 5.3f;
        string name = "Gabriel";
        var aux = "Gabriel"; // Defines the type during execution
        Console.WriteLine("Variable Value = " + aux + "...");

        int num1, num2, num3;
        num1 = 1;
        num2 = 3;
        num3 = num1 * num2;
        Console.WriteLine("The multiplication between num1 and num2 is " + num3);
    }
}