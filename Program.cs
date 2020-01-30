﻿// Roger Dominguez Program to show grade value based on input with a +- system
using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // User enters value
            Console.WriteLine("Please Enter Grade Value");
            // System reads user input
            string input = Console.ReadLine();
            // declare grade as an int from user input
            int grade = int.Parse(input);
            // start if and else if statement for all grade types while using && to designate +/-
            if (grade >= 98)
            {
                Console.WriteLine("A+");
            }
            else if (grade >= 92 && grade <= 97)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 90 && grade <= 91)
            {
                Console.WriteLine("A-");
            }
            else if (grade >= 88 && grade <= 89)
            {
                Console.WriteLine("B+");
            }
            else if (grade >= 82 && grade <= 87)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 80 && grade <= 81)
            {
                Console.WriteLine("B-");
            }
            else if (grade >= 78 && grade <= 79)
            {
                Console.WriteLine("C+");
            }
            else if (grade >= 72 && grade <= 77)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 70 && grade <= 71)
            {
                Console.WriteLine("C-");
            }
            else if (grade >= 68 && grade <= 69)
            {
                Console.WriteLine("D+");
            }
            else if (grade >= 62 && grade <= 67)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 60 && grade <= 61)
            {
                Console.WriteLine("D-");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
