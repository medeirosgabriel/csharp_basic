using System;

public interface Vehicle {

    void turnOn();

    void turnOff();

    void info();
}

public interface Combat {

    void shoot();
}

class Car:Vehicle,Combat {

    public bool on;
    public int bullets;

    public Car() {
        this.bullets = 100;
    }

    public void turnOn(){
        this.on = true;
    }

    public void turnOff(){
        this.on = true;
    }

    public void shoot() {
        this.bullets --;
    }

    public void info() {
        Console.WriteLine("On = {0} Bullets = {1}", this.on, this.bullets);
    }

}

class Interface {

    static void Main() {
        Car c = new Car();
        c.info();
        c.shoot();
        c.info();
    }
}