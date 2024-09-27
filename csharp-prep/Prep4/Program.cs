using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int numbers;
        string b;
        List<int> numbers_list = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.\n");
       do{
        Console.WriteLine("Write a Number:");
        b = Console.ReadLine();
        numbers = int.Parse(b);
        numbers_list.Add(numbers);


       } while(numbers != 0);
        int count = 0;
        int largest = int.MinValue;
        int total = 0;

       foreach (int num in numbers_list)
       {
            count +=1;
            total += num;
            if (num > largest)
            {
                largest = num;
            }
       }

        float average = total/count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}