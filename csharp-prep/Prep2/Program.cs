using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your grade percentage? ");
        string grade_percentage;
        grade_percentage = Console.ReadLine();
        int grade = int.Parse(grade_percentage);
        string letter_grade;

        if (grade >= 90)
        {
             letter_grade = "A";
        }
        else if (90 > grade && grade >= 80)
        {
             letter_grade = "B";
        }
        else if (80 > grade && grade >= 70)
        {
             letter_grade = "C";
        }
        else if (70 > grade && grade >= 60)
        {
             letter_grade = "D"; 
        }
        else
        {
             letter_grade = "F";
        }
        Console.WriteLine($"You got {letter_grade}!");



        if (grade >= 70) 
        {
            Console.WriteLine("Nice! You are passing the class too!");
        }
        else
        {   
            Console.WriteLine("Oh no! You are failing mate!");
        }

        

    }
}