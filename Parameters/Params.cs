using System;

class Params {
    static void Main() {

        Console.WriteLine("Sum = {0}", sum_(34,56,2,3,4,55,77));
        Console.WriteLine("Sum = {0}", sum_(11,24,3,64,5));

    }

    static int sum_(params int[]prs) { // 0 or more than 0 parameters
        int sum = 0;
        foreach(int n in prs) {sum += n;}
        return sum;
    }
}