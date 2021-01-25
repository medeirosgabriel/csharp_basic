using System;

class PlayerPublic {
    public int energy;
    public string name;
    public PlayerPublic(string name, int energy) {
        this.energy = energy;
        this.name = name;
    }
    public void info() {
        Console.WriteLine("Name...: {0}", this.name);
        Console.WriteLine("Energy.: {0}", this.energy);
        Console.WriteLine("--------------------");
    }

    ~PlayerPublic() { // Called when the object is destroyed
        Console.WriteLine("Player {0} was destroyed", name);
    }
}

class PlayerPrivate {
    private int energy;
    private string name;
    public PlayerPrivate(string name, int energy) {
        this.energy = energy;
        this.name = name;
    }
    public void info() {
        Console.WriteLine("Name...: {0}", this.name);
        Console.WriteLine("Energy.: {0}", this.energy);
        Console.WriteLine("--------------------");
    }

    ~PlayerPrivate() { // Called when the object is destroyed
        Console.WriteLine("Player {0} was destroyed", name);
    }

    public int getEnergy() {
        return this.energy;
    }

    public void setEnergy(int energy) {
        this.energy = energy;
    }

    public string getName() {
        return this.name;
    }

    public void setName(string name) {
        this.name = name;
    }
}

class PublicVsPrivate {

    static void Main() {

        PlayerPublic p1 = new PlayerPublic("Gabriel", 80);
        PlayerPrivate p2 = new PlayerPrivate("Messi", 60);

        p1.info();
        p2.info();

        p1.energy = 100;
        //p2.energy = 70; Error -> Inaccessible
        p2.setEnergy(70); // OK
        p1.info();
        p2.info();

    }

}