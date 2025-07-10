namespace Session_3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //Write a program that allows the user to enter a number then print it.
            /*
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
            */

            #endregion

            #region question2
            //2.	Write C# program that converts a string to an integer,
            //but the string contains non-numeric characters. And mention what will happen
            /*

            string input = "Ahmed123";
            // by using convert
            int convertedNumber = Convert.ToInt32(input);
            Console.WriteLine($"Converted number: {convertedNumber}"); // in this case , it will throw an exception because the string is not in valid format (non-numeric characters).

            // by using int.Parse
            int parsedNumber = int.Parse(input); // in this case , it will throw an exception because the string is not in valid format (non-numeric characters) and also if the string is null.
            Console.WriteLine($"Parsed number: {parsedNumber}");

            // by using TryParse
            int.TryParse(input, out int result);
            Console.WriteLine($"TryParse result: {result}"); // in this case, it will return 0 because the string is not in valid format (non-numeric characters) and it will not throw an exception.
            */
            #endregion


            #region question3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            #endregion

            #region question7
            //Write C# program that take two string variables and print them as one variable 
            /*
            Console.WriteLine("Please enter the first string:");
            string firstString = Console.ReadLine() ?? " "; // to show " " in case of null value
            Console.WriteLine("Please enter the second string:");
            string secondString = Console.ReadLine() ?? " ";
            Console.WriteLine($"Combined string: {firstString} {secondString}");
            */
            #endregion

            #region question8
            //Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //Note : The formula for simple interest is Interest = (principal * rate * time ) /100.

            /*
            Console.WriteLine("Please enter the principal amount:");
            double.TryParse(Console.ReadLine(), out double principal);
            Console.WriteLine("Please enter the rate of interest:");
            double.TryParse(Console.ReadLine(), out double rate);
            Console.WriteLine("Please enter the time in years:");
            double.TryParse(Console.ReadLine(), out double time);
            double interest = (principal * rate * time) / 100;
            Console.WriteLine($"The simple interest is: {interest}");
            */

            // to be more safe 
            /*
            Console.WriteLine("Please enter the principal amount:");
            bool isPrincipalValid= double.TryParse(Console.ReadLine(), out double principal);
            Console.WriteLine("Please enter the rate of interest:");
            bool isRateValid= double.TryParse(Console.ReadLine(), out double rate);
            Console.WriteLine("Please enter the time in years:");
            bool isTimeValid= double.TryParse(Console.ReadLine(), out double time);
            if(isPrincipalValid && isRateValid && isTimeValid)
            {
                double interest = (principal * rate * time) / 100;
                Console.WriteLine($"The simple interest is: {interest}");
            }
            else
            {
                Console.WriteLine("Invalid inputs. Please enter valid numbers.");

            }
            */

            #endregion

            #region question9
            //9.	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            //Note: The formula for BMI is BMI = (Weight) / (Height * Height)

            /*

            Console.WriteLine("please enter weight in Kg");
            bool isWeightValid = double.TryParse(Console.ReadLine(), out double weight);
            Console.WriteLine("please enter the height in M");
            bool isHeightValid = double.TryParse(Console.ReadLine(), out double height);

            if(isWeightValid && isHeightValid)
            {
                double BMI = (weight) / (weight * height);
                Console.WriteLine($"The Body Mass Index (BMI) is: {BMI}");
            }
            else
            {
                Console.WriteLine("Invalid inputs. Please enter valid numbers.");
            }
            */

            #endregion

            #region question10
            //10.	Write a program that uses the ternary operator to check if the temperature is too hot,
            //too cold, or just good. Assign the result in a variable then display the result. 
            /*
            Console.WriteLine("please enter the temp.");
            bool isTempValid = double.TryParse(Console.ReadLine(), out double temp);
            string message = isTempValid 
                ? (temp > 30 ? "just Hot" : temp < 10 ? "just cold." : "The temperature is just good.")
                : "Invalid input. Please enter a valid number.";
            Console.WriteLine(message);
            */
            #endregion

            #region question11
            //Write a program that takes the date from the user and displays it in various formats using string interpolation.
            #endregion

            #region question12
            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            Console.WriteLine("please enter the number");
            bool isNumberValid = int.TryParse(Console.ReadLine(), out int number);
            if (isNumberValid)
            {
                string result = (number % 3 == 0 && number % 4 == 0) ? "yes" : "no";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");

            }
            #endregion
        }
    }
}
