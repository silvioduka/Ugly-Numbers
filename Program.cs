/*
Ugly Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-12 

A number is considered to be ugly if its only prime factors are 2, 3 or 5. 

[1, 2, 3, 4, 5, 6, 8, 9, 10, 12, 15, …] is the sequence of ugly numbers. 

By convention, 1 is also included.

Task: 
Create a program which takes a number n as input and checks if it's an ugly number. 

Hint: 
An ugly number U can be expressed as: U = 2^a * 3^b * 5^c, where a, b and c are non-negative integers. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UglyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2500; // Insert a number to check if it's an ugly number.

            Console.WriteLine($"The number {number} {((GDP(GDP(GDP(number, 2), 3), 5) == 1) ? "is" : "is NOT")} ugly number!");
        }

        static int GDP(int n, int p)
        {
            while (true)
            {
                if (n % p != 0) return n;
                n /= p;
            }            
        }
    }
}