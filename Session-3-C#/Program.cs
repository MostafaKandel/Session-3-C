using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;
using System.Security.Claims;

namespace Session_3_C_

{
    class Point
    {
        public int X;
        public int Y;
    }
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
            /*
            int a = 10;
            int b = 20;
            double c = 3.5;
            float d = 4.5f;
            int sum = a + b; // it will be 30 and, so the result will be an integer.
            double sum2= c+d; // it will be 8.0 and, so the result will be a double.

            int divid= a/c; // in this case,  compile-time error, because i try to store the double result in an integer variable.
            double divid2= b/c; // in this case, the result will be a double.

            */
            #endregion

            #region question4
            //Write C# program that Extract a substring from a given string

            /*
            string originalString = "Hello";
            string subString = originalString.Substring(0, 3); // extracting the sub string 'Hel'
            Console.WriteLine($"sub string: {subString}");
            */

            #endregion

            #region question5
            //5.	Write C# program that Assigning one value type variable to another and modifying the
            //value of one variable and mention what will happen
            /*
            int a = 10;
            int b = a; // b is assigned the value of a b= 10
            b = 20; // modifying b to 20
            Console.WriteLine($"a: {a}, b: {b}"); // a will still be 10, b will be 20. This is because value types are copied by value, not by reference.
            */
            #endregion

            #region question6
            //6.	Write C# program that Assigning one reference type variable to another and modifying
            //the object through one variable and mention what will happen
            /*
            Point p1 = new Point();
            Point p2 = new Point();
            p2 = p1; // p2 is assigned the reference of p1, so both p1 and p2 have the same refernce in the heap.
            p1.X = 10; // modifying p1.X to 10
            p1.Y = 20; // modifying p1.Y to 20
            Console.WriteLine($"p1: ({p1.X}, {p1.Y}), p2: ({p2.X}, {p2.Y})"); // p1 and p2 will have the same values because reference types are copied by reference, not by value.
            */

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

            // first approach
            Console.WriteLine("Please enter the date");
            bool isDateValid = DateTime.TryParse(Console.ReadLine(), out DateTime date);
            if (isDateValid)
            {
                Console.WriteLine($"Short Date: {date.ToString("MM/dd/yyyy")}");
                Console.WriteLine($"Long Date: {date.ToString("dddd, dd MMMM yyyy")}");
                Console.WriteLine($"Full Date and day: {date.ToString("dddd, dd MMMM yyyy")}");
                Console.WriteLine($"date and time: {date.ToString("MM/dd/yyyy HH:mm")}");
                Console.WriteLine($"month and day: {date.ToString("MMMM dd")}");
                Console.WriteLine($"full date and time : {date.ToString("MM/dd/yyyy HH:mm:ss")}");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
            }

            // second approach (it is mentioned in the DateTime class class that there are  , ToShortDateString(), ToLongDateString(), )
            /*
            Console.WriteLine("Please enter the date");
            bool isDateValid = DateTime.TryParse(Console.ReadLine(), out DateTime date);
            if (isDateValid)
            {
               Console.WriteLine($"Short Date: {date.ToShortDateString()}");
               Console.WriteLine($"Long Date: {date.ToLongDateString()}");
                
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
            }
            */

            #endregion

            #region question12
            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            /*
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
            */
            #endregion

            #region question13
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            /*
            Console.WriteLine("please enter the number");
            bool isInputValid = double.TryParse(Console.ReadLine(), out double inputNumber);
            string message= isInputValid ? (inputNumber < 0 ? "negative" : "positive") : "Invalid input. Please enter a valid number.";
            Console.WriteLine(message);
            */
            #endregion

            #region question14
            //  Write a program that takes 3 integers from the user then prints the max element and the min element.

            // first approach
            /*
            Console.WriteLine("Please enter the first number:");
            bool isFirstValid = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please enter the second number:");
            bool isSecondValid = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Please enter the third number:");
            bool isThirdValid = int.TryParse(Console.ReadLine(), out int thirdNumber);
            if (isFirstValid && isSecondValid && isThirdValid)
            {
                int max = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
                int min = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
                Console.WriteLine($"Max: {max}, Min: {min}");
            }
            else
            {
                Console.WriteLine("Please enter valid numbers.");
            }
            */

            // second approach

            Console.WriteLine("Please enter the first number:");
            bool isFirstValid = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please enter the second number:");
            bool isSecondValid = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Please enter the third number:");
            bool isThirdValid = int.TryParse(Console.ReadLine(), out int thirdNumber);
            if (isFirstValid && isSecondValid && isThirdValid)
            {
                int max = firstNumber;
                int min = firstNumber;

                // max
                if (secondNumber > max)
                {
                    max = secondNumber;
                }
                if (thirdNumber > max)
                {
                    max = thirdNumber;
                }

                // min
                if (secondNumber < min)
                {
                    min = secondNumber;
                }
                if (thirdNumber < min)
                {
                    min = thirdNumber;
                }

                Console.WriteLine($"Max: {max}, Min: {min}");


            }
            else
            {
                Console.WriteLine("Please enter valid numbers.");
            }
            #endregion

            #region question15
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.
            /*
            Console.WriteLine("please enter the number");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int inputNumber); 
            string message = isInputValid ? (inputNumber % 2 == 0 ? "even" : "odd") : "Please enter a valid number.";
            Console.WriteLine(message);
            */
            #endregion

            #region question16
            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print 
            /*
            Console.WriteLine("Please enter a character:");
            bool isCharValid = char.TryParse(Console.ReadLine(), out char inputChar);
           
            if (isCharValid)
            {
                char vowel = char.ToLower(inputChar);
                switch (vowel)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("not vowel");
                        break;
                }
            }
            else
            {
               Console.WriteLine(" Please enter a valid character.");
            }
            */

            #endregion

            #region question17
            //Write a program to input the month number and print the number of days in that month.
            /*
            Console.WriteLine("Please enter the month number:");
            bool isMonthValid = int.TryParse(Console.ReadLine(), out int month);
            if (isMonthValid && month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("31 days");
                        break;
                    case 4: 
                    case 6: 
                    case 9: 
                    case 11: 
                        Console.WriteLine("30 days");
                        break;
                    case 2: 
                        Console.WriteLine("28 or 29 days");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid month number (1-12).");
            }
            */
            #endregion

        }
    }
}
