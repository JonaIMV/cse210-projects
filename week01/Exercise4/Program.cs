using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Please enter a list of numbers, type 0 to end the list:");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userNumber))
            {
                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        int minPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }

        if (minPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
           numbers.Sort();


        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
        Console.WriteLine(number);
        }
    }
}
