using System;

class Player {
    public int energy;
    public bool alive;
    public string name;

    public Player() {
        energy = 100;
        alive = true;
        name = "Player";
    }

    public Player(string name_) {
        energy = 100;
        alive = true;
        name = name_;
    }

    public Player(string name_, int e) {
        energy = e;
        alive = true;
        name = name_;
    }

    public Player(string name_, int energy_, bool alive_) {
        energy = energy_;
        alive = alive_;
        name = name_;
    }

    public void info() {
        Console.WriteLine("Name...: {0}", name);
        Console.WriteLine("Energy.: {0}", energy);
        Console.WriteLine("Alive..: {0}", alive);
    }

    ~Player() { // Called when the object is destroyed
        Console.WriteLine("Player {0} was destroyed", name);
    }
}

class Constructors {

    static void Main() {
        Player p1 = new Player();
        Player p2 = new Player("Gabriel");
        Player p3 = new Player("João", 30, false);
        Player p4 = new Player("Pedro", 70);
        Player[] players = new Player[4]{p1,p2,p3,p4};
        foreach (Player p in players) {
            p.info();
            Console.WriteLine("----------------");
        }
    }
}