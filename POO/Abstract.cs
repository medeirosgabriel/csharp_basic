using System;

abstract class Vehicle {

    protected int maxSpeed;
    protected int currentSpeed;
    protected bool on;

    public Vehicle() {
        this.on = false;
        this.currentSpeed = 0;
    }

    public void setOn(bool on) {
        this.on = on;
    }

    abstract public void aceleration(int time);

    public int getCurrSpeed() {
        return this.currentSpeed;
    }
}

class Car:Vehicle {
    public Car() {
        this.maxSpeed = 200;
    }

    override public void aceleration(int time) {
        this.currentSpeed += 10 * time;
    }
}


class Abstract {

    static void Main() {

        Car c = new Car();
        c.aceleration(2);
        Console.WriteLine(c.getCurrSpeed());

    }
}