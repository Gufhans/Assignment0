// See https://aka.ms/new-console-template for more information
using System;

namespace assignment0;


public class Exercise3 
{
    
    public static void Main(string[]args)
    {
        var machine = new Exercise3();
    }
    
    public Exercise3()
    {
        Console.WriteLine("Welcome to the find-out-leap-year-tron-3000!");
        Console.WriteLine("This system determines whether or not a given year after 1582 is a leap year.");
        Console.WriteLine("The system will respond with either a yay or nay.");
        Console.WriteLine("If you type Exit, the system will terminate.");
        inputSetup();
    }

    public Exercise3(string input)
    //For testing purposes, the integer does not need to be anything, this is just to overload the constructor
    {
        try 
        {
            int test = Int32.Parse(input);
        }
        catch (FormatException)
        {

        }
    }

    public void inputSetup() 
    {
        Console.WriteLine("Please type in a year:");
        string s = Console.ReadLine();
        if (s.Equals("Exit"))
        {
            Console.WriteLine("System terminated. Have a good leap year!");
            System.Environment.Exit(1);
        }
        try
        {
            int year = Int32.Parse(s);
            if (year < 1582)
            {
                Console.WriteLine("The system only accpets input larger than 1582");
                inputSetup();
            }

            var output = isLeapYear(year);

            if (output)
            {
                Console.WriteLine("yay");
            } else 
            {
                Console.WriteLine("nay");
            }
            inputSetup();
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to parse input - avoid letters and stick to numbers only!");
            inputSetup();
        }
    }

    public bool isLeapYear(int year)
    {   
        if (year%4 == 0 && year%100 !=0)
        {
            return true;
        }
        if (year%100 == 0 && year%400 == 0)
        {
            return true;
        }
        return false;
    }

    public bool isLeapYear(string year)
    {
        int test = Int32.Parse(year);
        if (test < 1582)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }
}