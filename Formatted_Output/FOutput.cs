using System;

class FOutput {
    static void Main() {
        int num1, num2, num3;
        num1 = 1; num2 = 2; num3 = 3;
        // 0, 1, 2 are index
        Console.WriteLine("Num1 = {0} Num2 = {1} Num3 = {2}", num1, num2, num3);
        Console.WriteLine("\nNum1 =\t{0}\nNum2 =\t{1}\nNum3 =\t{2}\n", num1, num2, num3);

        double purchasePrice = 5.5;
        double salePrice;
        double profit = 0.1;
        string product = "Coke";

        salePrice = purchasePrice + (purchasePrice*profit);

        Console.WriteLine("Product..........:{0,15}", product); // 15 == spaces
        Console.WriteLine("Purchase Price...:{0,15:c}", purchasePrice);
        Console.WriteLine("Profit...........:{0,15:p}", profit);
        Console.WriteLine("Sale Price.......:{0,15:c}", salePrice);
    }
}