namespace Session_3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Please enter a number:");
            bool isValid= int.TryParse(Console.ReadLine(), out int number);
            if (isValid)
            {
                Console.WriteLine($"The entered number: {number}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            #endregion
        }
    }
}
