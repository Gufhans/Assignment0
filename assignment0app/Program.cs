// See https://aka.ms/new-console-template for more information
using System;

namespace assignment0;


public class Exercise3 
{
    
    public static void Main(string[]args)
    {
        
    }
    
    public Exercise3()
    {

    }

    public bool isLeapYear(int year) => (year%4 == 0 || year%400 == 0) ? true : false;
}