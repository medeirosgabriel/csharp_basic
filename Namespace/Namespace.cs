using System;

namespace Calc1 {

    class Area {

        public static int area(int n1, int n2) {
            if (n1 == 0 & n2 == 0) {
                throw new Exception("Impossible!");
            } else {
                int r = n1 * n2;
                return r;
            }
        }

    }
}

namespace Calc2 {

    class Area {

        public static double area(int n1, int n2) {
            if (n1 == 0 & n2 == 0) {
                throw new Exception("Impossible!");
            } else {
                int r = n1 * n2;
                return Convert.ToDouble(r);
            }
        }

    }
}

class Namespace {

    static void Main() {

        int res1, n1 = 10, n2 = 2;
        double res2;
        res1 = Calc1.Area.area(n1,n2);
        Console.WriteLine("Area Calc 1 = {0}", res1);
        res2 = Calc2.Area.area(n1,n2);
        Console.WriteLine("Area Calc 2 = {0}", res2);
    }
}