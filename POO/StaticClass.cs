using System;

static public class Player {

    public static int energy;
    public static bool alive;
    public static string name;

    public static void setAttrs(string name_, int energy_, bool alive_) {
        name = name_;
        energy = energy_;
        alive = alive_;
    }

    public static void info() {
        Console.WriteLine("Name...: {0}", name);
        Console.WriteLine("Energy.: {0}", energy);
        Console.WriteLine("Alive..: {0}", alive);
        Console.WriteLine("-----------------");
    }
}

public class Enemy {

    // Static:
    // All objects created will point to the same alert address
    static public bool alert;

    public string name;

    public Enemy(string name_) {
        alert = false;
        name = name_;
    }

    public void info() {
        Console.WriteLine("Name...: {0}", name);
        Console.WriteLine("Alert: {0}", alert);
        Console.WriteLine("-----------------");
    }
}

class StaticClass {
    
    static void Main() {
        Player.setAttrs("Gabriel", 100, true);
        Player.info();

        Enemy e1 = new Enemy("Joker");
        Enemy e2 = new Enemy("Two Faces");
        Enemy e3 = new Enemy("Ra's al Ghul");

        e1.info();
        e2.info();
        e3.info();

        Enemy.alert = true;

        e1.info();
        e2.info();
        e3.info();
        
        // All created enemies will point to the same alert address
        // Because alert is a static attribute
    }
}