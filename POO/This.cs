using System;

class Calculation {

    public int v1;

    public int v2;

    public Calculation (int v1, int v2) {
        this.v1 = v1;
        this.v2 = v2;
    } 

    public int sum_() {
        return this.v1 + this.v2;
    }
}

class This {
    static void Main() {
        Calculation calc = new Calculation(10,2);
        Console.WriteLine(calc.sum_());
    }
}