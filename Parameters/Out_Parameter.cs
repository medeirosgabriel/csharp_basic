using System;

class Out_Parameter {

    static void Main() {
        int dividend = 13, divider = 5, rest;
        int quotient = divide(dividend, divider, out rest);
        Console.WriteLine("{0} = {1} * {2} + {3}", 
                dividend, quotient, divider, rest);
    }

    static int divide(int dividend, int divider, out int rest) {
        int quotient = dividend/divider;
        rest = dividend % divider;
        return quotient;
    }
}