using System;

class GoTo {
    static void Main(string[] args) {

        char choice;
        int timeHours;
        
        start:

        Console.Clear(); // Clear terminal

        Console.WriteLine("Travel: Belo Horizonte MG -> João Pessoa PB");
        Console.WriteLine("Transports:\n" +
                          "(a) Airplane\n(b) Bus\n(c) Car\n");
        Console.Write("Choose a Transport: ");

        choice = Convert.ToChar(Console.ReadLine());
        
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

        Console.Clear();

        if (timeHours == -1) {
            Console.WriteLine("Transport Unavailable");
            goto start;
        } else {
            Console.WriteLine("The travel time:\nHours: {0}\nMinutes: {1}", timeHours, (timeHours * 60));
        }
    
        Console.Write("Choose other Transport? (s/n)");
        choice = Convert.ToChar(Console.ReadLine());
        switch(choice) {
            case 'S':
            case 's':
                goto start;
                break;
            default:
                Console.Clear();
                Console.Write("Byeeee...");
                break;
        }
    }
}