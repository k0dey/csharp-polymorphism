using System;

namespace polymorphism
{

    class TypeConverter
    {
        private void convertType(string valueOne, int valueTwo)
        {

            int one = Convert.ToInt32(valueOne);
            string two = Convert.ToString(valueTwo);
            Console.WriteLine($"String to Int32: {one}, Int to String: {two}");
            // input string + int > convert them into a type of your choice and display them
        }

         private void convertType(bool valueOne, float valueTwo)
        {
            int one = Convert.ToByte(valueOne);
            float two = Convert.ToInt32(valueTwo);
            Console.WriteLine($"Bool to Byte: {one}, Float to Int32: {two}");
            // input bool + float > convert them into a type of your choice

        }


        private void convertType(decimal valueOne, Nullable<int> valueTwo)
        {
            double one = Convert.ToDouble(valueOne);
            bool two = Convert.ToBoolean(valueTwo);
            Console.WriteLine($"decimal to double: {one}, null to bool: {two}");
            // input decimal + null > convert them into a type of your choice

        }


        public void Conversion(dynamic inputOne, dynamic inputTwo)
        {
            convertType(inputOne, inputTwo);
        }

    }


}