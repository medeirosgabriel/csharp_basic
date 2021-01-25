using System;

class Area {

    public static int area(int n1, int n2) {
        if (n1 == 0 & n2 == 0) {
            throw new Exception("Impossible!");
        } else {
            return n1 * n2;
        }
    }
}

class TryCatch {

    static void Main() {

        int res, n1, n2;
        res = n1 = n2 = 1;

        n1 = 10;

        try {
            res = n1/n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
            Area.area(0,0);
            //throw new Exception("Because i want!");
        } catch (Exception e) {
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Type: {0}", e.GetType());
            Console.WriteLine("Source: {0}", e.Source);
        } finally {
            Console.WriteLine("End of the process!");
        }
    }
}