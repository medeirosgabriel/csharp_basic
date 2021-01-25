using System;

class Car {

    private int maxSpeed;

    public int mS {
        get {
            return maxSpeed;
        }
        set {
            if (value < 0) {
                this.maxSpeed = 0;
            } else if (value > 300) {
                this.maxSpeed = 300; 
            } else {
                this.maxSpeed = value; 
            }
        }
    }


}

class GetAndSet {

    static void Main() {

        Car c = new Car();
        c.mS = 200;
        Console.WriteLine("Speed: {0}", c.mS);
    }
}