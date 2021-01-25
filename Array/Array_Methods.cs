using System;

class Array_Methods {
    static void Main() {

        int[] vector1 = new int[5];
        int[,] matrix = new int[2,5]{{11,22,00,55,44},{66,77,88,99,00}};

        Console.WriteLine("------ Fill Vector ------");

        Random random = new Random();

        for (int i = 0; i < vector1.GetLength(0); i++) {
            vector1[i] = random.Next(50); // 50 == MaxValue
        }

        Console.Write("Vector 1 elements: ");

        foreach(int n in vector1) {
            Console.Write("{0} ", n);
        }

        Console.WriteLine("");

        Console.WriteLine("----- Binary Search -----");
        int wanted = 33;
        int pos = Array.BinarySearch(vector1, wanted);
        Console.WriteLine("The wanted position is {0}", pos);

        Console.WriteLine("------- Get Value -------");
        int n1 = Convert.ToInt32(vector1.GetValue(0));
        int n2 = Convert.ToInt32(matrix.GetValue(0,1));
        Console.WriteLine("vector[0] = {0} matrix[0][1] = {1}", n1, n2);

        Console.WriteLine("--------- Sort ----------");
        Array.Sort(vector1);
        foreach(int n in vector1) {
            Console.Write("{0} ", n);
        }

        Console.WriteLine("\n-------------------------");
    }
}