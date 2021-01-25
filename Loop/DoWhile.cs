using System;

class DoWhile {

    static void Main(string[] args) {

        string password = "1234";
        string typedPass;
        int attempts = 0;

        do {
            Console.Clear();
            Console.Write("Type a Password: ");
            typedPass = Console.ReadLine();
            attempts++;
        } while (password != typedPass);

        Console.WriteLine("Correct Password! Attempts = {0}", attempts);

    }
}