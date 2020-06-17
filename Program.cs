using System;

namespace polymorphism
{
    class UserInput
    {
        public void ShowMeTheUserInput(int userData)
        {
            Console.WriteLine($"The user inputted {userData}");
        }
        public void ShowMeTheUserInput(string userData)
        {
            Console.WriteLine($"The user inputted {userData}");

        }

        public void ShowMeTheUserInput(double userData)
        {
            Console.WriteLine($"The user inputted a double  {userData}");         
        }
        public void ShowMeTheUserInput(double userData, double somethingNew)
        {
            Console.WriteLine($"The user inputted a double double {userData}");         
        }

        public void Addition(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }

        public void Addition(string numberOne, string numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // UserInput newUser = new UserInput();
            // newUser.ShowMeTheUserInput(123);
            // newUser.ShowMeTheUserInput("Jacob");
            // newUser.ShowMeTheUserInput(123.456);
            // newUser.ShowMeTheUserInput(123.456, 12.33);
            // newUser.Addition(123, 456);
            // newUser.Addition("123", "456");


            TypeConverter typeCon = new TypeConverter();
            typeCon.Conversion("1", 2);
            typeCon.Conversion(0.22m, null);
            typeCon.Conversion(true, 1.10f);
        }

    }
}
