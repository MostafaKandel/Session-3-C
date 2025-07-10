namespace Session_3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Please enter a number:");
            bool isValid = int.TryParse(Console.ReadLine(), out int number);
            if (isValid)
            {
                Console.WriteLine($"The entered number: {number}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            #endregion
            #region question2
            //2.	Write C# program that converts a string to an integer,
            //but the string contains non-numeric characters. And mention what will happen

            string input = "Ahmed123";
            // by using convert
            int convertedNumber = Convert.ToInt32(input);
            Console.WriteLine($"Converted number: {convertedNumber}"); // in this case , it will throw an exception because the string is not in valid format (non-numeric characters).

            // by using int.Parse
            int parsedNumber= int.Parse(input); // in this case , it will throw an exception because the string is not in valid format (non-numeric characters) and also if the string is null.
            Console.WriteLine($"Parsed number: {parsedNumber}");

            // by using TryParse
            int.TryParse(input, out int result);
            Console.WriteLine($"TryParse result: {result}"); // in this case, it will return 0 because the string is not in valid format (non-numeric characters) and it will not throw an exception.

            #endregion
        }
    }
}
