using System;

class Chicken {
    private string name;
    private int numberEggs;

    public Chicken(string name) {
        this.name = name;
        this.numberEggs = 0;
    }

    public Egg toLaid() {
        this.numberEggs ++;
        return new Egg(this.numberEggs, this.name);
    }
}

class Egg {

    private int eggId;

    private string chickenName;

    public Egg(int eggId, string chickenName) {
        this.eggId = eggId;
        this.chickenName = chickenName;
        Console.WriteLine("Created Egg - Chcken Name: {0}  Egg Id: {1}", 
                        this.chickenName, this.eggId);
    }
}

class ReturningObjects {

    static void Main() {
        Chicken c = new Chicken("Jurema");
        c.toLaid();
        c.toLaid();
        c.toLaid();
    }
}