using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingDifferenceBetweenTwoDatesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                // asking for  the first user input 
                Console.WriteLine("Enter first date: ");

                // parsing the user input into date format
                DateTime firstDate = DateTime.Parse(Console.ReadLine());

                // asking for the second user input
                Console.WriteLine("Enter second date: ");

                // parsing the user input into date format
                DateTime secondDate = DateTime.Parse(Console.ReadLine());

                // calculating the difference between two dates
                TimeSpan diff = firstDate - secondDate;

                // output in days, hours, and minutes 
                Console.WriteLine("Days : " + diff.TotalDays.ToString());
                Console.WriteLine("Hours : " + diff.TotalHours.ToString());
                Console.WriteLine("Minutes : " + diff.TotalMinutes.ToString());
                Console.ReadLine();


                


            }

        }
    }
}



