using System;

class Car {

    private int[] maxSpeed = new int[5]{80,120,160,240,300};

    public int this[int i] {
        get {
            return maxSpeed[i];
        }
        set {
            if (value < 0) {
                this.maxSpeed[i] = 0;
            } else if (value > 300) {
                this.maxSpeed[i] = 300; 
            } else {
                this.maxSpeed[i] = value; 
            }
        }
    }


}

class Index {

    static void Main() {

        Car c = new Car();
        c[4] = 200;
        Console.WriteLine("Speed: {0}", c[4]);
    }
}