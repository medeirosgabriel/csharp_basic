using System;

struct Car {

    public string name;
    public string color;
    public string brand;

    public Car(string name, string color, string brand) {
        this.name = name;
        this.color = color;
        this.brand = brand;
    }

    public void info() {
        Console.WriteLine("Name = {0} Color = {1} Brand = {2}",
            this.name, this.color, this.brand);
    }
}

class Struct {

    static void Main() {
        Car c1 = new Car("F40", "Red", "Ferrari");
        c1.info();
        Car c2;
        c2.name = "Ram";
        c2.color = "Black";
        c2.brand = "Dodge";
        c2.info();
    }
}