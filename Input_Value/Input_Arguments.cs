using System;

class Input_Value {

    static void Main(string[] args) {

        int sum = 0;
        Console.WriteLine("Number of arguments: {0}", args.Length);

        for (int i = 0; i < args.Length; i++) {
            Console.Write("{0} ", args[i]);
            int n;
            if (int.TryParse(args[i], out n)) {
                sum += n;
            }
        }

        Console.WriteLine("\nNumbers sum: {0}", sum);

    }
}