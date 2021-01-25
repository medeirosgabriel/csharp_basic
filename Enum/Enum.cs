using System;

class Enum {

    enum Days {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

    static void Main(string[] args) {
        Days d1 = Days.Sunday;
        Days d2 = (Days) 2;
        int d3 = (int) Days.Tuesday;
        Console.WriteLine("{0} {1} {2}", d1, d2, d3);

        Console.WriteLine("-------------- Days --------------");

        for (int i = 0; i < 6; i++) {
            Console.WriteLine("{0} - {1}", (Days) i, i);
        }
    }
}