using System;

class Vehicle {

    public int maxSpeed;
    public bool on;

    public void turnOn() {
        this.on = true;
    }

    public void turnOff() {
        this.on = false;
    }

    public void info() {
        Console.WriteLine("On: {0}", this.on);
    }
}

class Car:Vehicle {
    public string name;
    public string color;

    public Car(string name, string color) {
        turnOff();
        this.maxSpeed = 200;
        this.name = name;
        this.color = color;
    }
}

class CombatCar:Car {
    public int bullets;

    public CombatCar(string name, string color, int bullets):base(name, color) {
        this.bullets = bullets;
    }
}

class Inheritance {
    static void Main() {
        Car car = new Car("Frontier", "Red");
        car.info();
        Console.WriteLine("{0} {1}", car.name, car.color);
        CombatCar cc = new CombatCar("Tank", "Green", 150);
        Console.WriteLine("{0} {1} {2} {3}", cc.name, cc.color, 
                        cc.maxSpeed, cc.bullets);
    }
}