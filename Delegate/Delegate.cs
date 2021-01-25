using System;

delegate int Operation(int n1, int n2);

class Math_ {

    public static int sum_(int n1, int n2) {
        return n1 + n2;
    }

    public static int double_(int n) {
        return 2 * n;
    }

    public static int mult_(int n1, int n2) {
        return n1 * n2;
    }
}

class Delegate {

    static void Main() {

        int res;

        Operation op = new Operation(Math_.sum_);

        res = op(1,2);

        Console.WriteLine("Result = {0}", res);

        op = new Operation(Math_.mult_);

        res = op(1,2);

        Console.WriteLine("Result = {0}", res);


    }
}