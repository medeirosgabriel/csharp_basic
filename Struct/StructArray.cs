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

class StructArray {

    static void Main() {
        
        Car[] cars = new Car[3];

        cars[0].name = "F40";
        cars[0].color = "Red";
        cars[0].brand = "Ferrari";

        cars[1].name = "Ram 2500";
        cars[1].color = "Balck";
        cars[1].brand = "Dodge";

        cars[2].name = "Italia";
        cars[2].color = "Yellow";
        cars[2].brand = "Ferrari";

        foreach (Car c in cars) {
            c.info();
        }
    } 
}