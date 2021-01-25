using System;

class Vehicle {

    public int currentSpeed;
    private int maxSpeed;
    protected bool on; // Accessible only to children of that class

    public Vehicle(int maxSpeed) {
        this.maxSpeed = maxSpeed;
        this.on = false;
        this.currentSpeed = 0;
    }

    public void turnOn() {
        this.on = true;
    }

    public void turnOff() {
        this.on = false;
    }

    public void info() {
        Console.WriteLine("Current Speed = {0}  Max Speed = {1}  On = {2}",
                        this.currentSpeed, this.maxSpeed, this.on);
    }
}

class Car:Vehicle {
    public string name;

    public Car(string name, int maxSpeed):base(maxSpeed) {
        this.on = false;
        // this.maxSpeed = maxSpeed; ERROR: maxSpeed is a private attribute
        this.name = name;
    }
}

class Inheritance {
    static void Main() {
        Car car = new Car("Frontier", 100);
        car.info();
    }
}