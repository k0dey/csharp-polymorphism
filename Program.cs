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
            Console.WriteLine($"The user inputted a double double {userData}, {somethingNew}");
        }

        public void Addition(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }

        public void Addition(string numberOne, string numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }

        public string EqualSlices(int total, int recipients, int slices)
        {
            int slicesNeeded = recipients * slices;
            dynamic returnString = "test";
            if (recipients == 0)
            {
                Console.WriteLine($"There's nobody here, pal. It's all yours.");
            }
            else if (total >= slicesNeeded)
            {
                int remainingSlices = total % slicesNeeded;
                Console.WriteLine($"You can ABSOLUTELY give {recipients} people {slices} slices each, with {remainingSlices} left over.");
            }
            else
            {
                int alternativeRemaining = total % recipients;
                int alternativeSlices = (total - alternativeRemaining) / recipients;

                Console.WriteLine($"That's a no go, bud. But you CAN do {alternativeSlices} each, with {alternativeRemaining} slices left over.");
            }

            return returnString;
        }


        
        // public bool EqualSlices(int total, int recipients, int slices)
        // {
        //     return total >= (recipients * slices);
        // }



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


            // TypeConverter typeCon = new TypeConverter();
            // typeCon.Conversion("1", 2);
            // typeCon.Conversion(0.22m, null);
            // typeCon.Conversion(true, 1.10f);

            UserInput pizza = new UserInput();
            pizza.EqualSlices(11, 5, 3); // false
            pizza.EqualSlices(8, 3, 2); // true
            pizza.EqualSlices(8, 0, 3); // true
            // Console.WriteLine(pizza.EqualSlices(11, 5, 3));
        }

    }
}
