using System;

class Switch {
    static void Main(string[] args) {
        Console.WriteLine("Travel: Belo Horizonte MG -> João Pessoa PB");
        Console.WriteLine("Transports:\n" +
                          "(a) Airplane\n(b) Bus\n(c) Car\n");
        Console.Write("Choose a Transport: ");

        char choice = Convert.ToChar(Console.ReadLine());
        int timeHours;
        switch(choice) {
            case 'A':
            case 'a':
                timeHours = 6;
                break;
            case 'B': 
            case 'b':
                timeHours = 48;
                break;
            case 'C': 
            case 'c':
                timeHours = 36;
                break;
            default:
                timeHours = -1;
                break;
        }

        if (timeHours == -1) {
            Console.WriteLine("Transport Unavailable");
        } else {
            Console.WriteLine("The travel time:\nHours: {0}\nMinutes: {1}", timeHours, (timeHours * 60));
        }
    }
}