﻿namespace vano___Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your First Name");
            var firstName = (Console.ReadLine());

            Console.Write("Write your Last Name");
            var lastName = (Console.ReadLine());

            Console.WriteLine("Write your age");
            var age = (Console.ReadLine());

            Console.WriteLine("Write your Gender");
            var gender = (Console.ReadLine());

            var fullName = "Hello, my Full name is:" + firstName + " " + lastName;
            Console.WriteLine(fullName);

            var about = $"my age is: {age}, my gender is: {gender} ";
            Console.WriteLine(about);   
        }
    }
}
