using System;

namespace exersisesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //whrite a program that asks for user's first and last name 
            //the program greets the user by their name
            //the program asks the user to enter their year of birth and canculates the user's age
            //Convert.ToInt32(stringConvert);
            //If the user is 13 or older, then the program displays "Welcome to Instagram"
            //otherwise the program dispalyes "You are too young to have an Instogram account"
            Console.WriteLine("Enter your first name");
            int yearOfBirth;
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName}  {lastName} !");
            Console.WriteLine("Enter your Year of birth");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int currentyear = Convert.ToInt32(DateTime.Now.Year.ToString());

            int age = currentyear - yearOfBirth;

            if (age >= 13)
            {
                Console.WriteLine("Welcome to Instagram!");
            }
            else
            {
                Console.WriteLine("You are too far to use Instagram");
            }
            Console.WriteLine(DateTime.Now.ToString());
             Console.Read();
        }
    }
}
