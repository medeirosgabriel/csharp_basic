using System;

class Player {
    public int energy = 100;
    public bool alive = true;
}

class ClassAndObjects {

    static void Main() {
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();
        Player[] players = new Player[3]{p1,p2,p3};
        p1.energy = 50;
        p2.alive = false;
        p3.energy = 30;
        foreach (Player p in players) {
            Console.WriteLine("Energy = {0} Alive = {1}",
                                p.energy, p.alive);
        }
    }
}