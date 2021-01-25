using System;

class If_Else {
    static void Main() {

        Console.Write("Type the grades: ");
        string[] grades = Console.ReadLine().Split(' ');

        double sum = 0;

        foreach (string grade in grades) {
            sum += Convert.ToDouble(grade);
        }

        Console.WriteLine(sum);

        double avg = sum/grades.Length;

        if (avg < 4) {
            Console.WriteLine("Average = {0} -> Failed", avg);
        } else if (avg >= 7) {
            Console.WriteLine("Average = {0} -> Passed", avg);
        } else {
            Console.WriteLine("Average = {0} -> Final", avg);
        }
    }
}