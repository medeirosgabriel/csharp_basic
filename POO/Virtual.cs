using System;

class Base {
    virtual public void info() {
        Console.WriteLine("Base");
    }
}

class Derivative_1:Base {
    override public void info() {
        Console.WriteLine("Derivative 1");
    }
}

class Derivative_2:Derivative_1 {
    override public void info() {
        Console.WriteLine("Derivative 2");
    }
}

class Virtual {

    static void Main() {
        Base b1 = new Base();
        Derivative_1 d1 = new Derivative_1();
        Derivative_2 d2 = new Derivative_2();
        Base b2;
        b2 = d1;

        b1.info();
        d1.info();
        d2.info();
        b2.info();
    }
}