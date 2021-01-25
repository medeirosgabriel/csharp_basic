using System;

class Input_Value {

    static void Main() {
        int n1, n2;
        string name;

        Console.Write("Type your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Your name is {0}", name);

        Console.Write("Type two numbers: ");
        string nStr = Console.ReadLine();
        string[] numbers = nStr.Split(' ');

        n1 = int.Parse(numbers[0]);
        n2 = Convert.ToInt32(numbers[1]);

        Console.WriteLine("{0} + {1} = {2}", n1, n2, (n1 + n2));
        
    }
}