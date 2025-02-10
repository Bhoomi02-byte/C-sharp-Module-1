
//Learn about the Variables, Data Types & Type Casting


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_1
{
    class Module1
    {
        static void Main(string[] args)

        {
            // Task2.1:- Create programs using all type of Variables(Variables, Constants, Display Variables, Multiple Variables, Identifiers). 
            //Variables are containers for storing data values.

            //type variableName = value;
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            float max = 2.3f;

            Console.WriteLine($"{myNum},{myDoubleNum},{myLetter},{myBool},{myText}, {max}");


            //Constants
            //If we don't want others to overwrite existing values, we can add the const keyword in front of the variable type.

            const int special = 10;

            Console.Write(special);
            Console.WriteLine(special);


            //Display Variables
            //The WriteLine() method is often used to display variable values to the console window.
            string firstName = "Bhoomi ";
            string lastName = "Agarwal";
            string fullName = firstName + lastName;

            Console.WriteLine(fullName);

            //Multiple Variables
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);



            //Identifiers


            //All C# variables must be identified with unique names.
            //These unique names are called identifiers.
            int m = 60;
            Console.WriteLine(m);

            //Task 2.2:-Create programs using all type of Data Types(int, long, float, double, bool, char, string)
            string college = "JSS";
            bool collegeId = true;
            int rollNo = 12;
            double fees = 12.4533d;
            float salary = 10.44f;
            char name = 'B';

            Console.WriteLine($"{college},{collegeId},{rollNo},{fees},{salary},{name}");


            //Task 2.3- Create programs for showing Type casting(Implicit & Explicit)

            //Implicit Casting
            //Implicit casting is done automatically when passing a smaller size type to a larger size type without any data loss:

            int num = 10;
            double nums = num;
            Console.WriteLine(num);
            Console.WriteLine(nums);

            //Explicit Casting
            //Explicit casting must be done manually by placing the type in parentheses in front of the value:

            double dd = 10.678;
            int copy = (int)(dd);
            Console.WriteLine(copy);


            //Type Conversion Methods
            //It is also possible to convert data types explicitly by using built-in methods,
            //    such as Convert.ToBoolean, 
            //    Convert.ToDouble, 
            //    Convert.ToString, 
            //    Convert.ToInt32(int) 
            //    and Convert.ToInt64(long):

            int myInt = 100;
            double myDouble = 5.25;
            bool myBools = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


            // 4. Parse and TryParse -> Convert the string ("123") to number
            // i) Parse throws error if string contains anything other than Numbers
            // In order to avoid errors we use safer version i.e. TryParse
            // TryParse first check if it can be parsed or not and then it parse it

            string numString = "12345";
            string numString2 = "123abc";  // It will give error when converted to int as it is not in the correct format
            Console.WriteLine($"{Convert.ToInt32(numString)}, {int.Parse(numString)}");
            if (int.TryParse(numString2, out var res))
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("The String is not in required format");
            }
            int a = 10;
            Console.WriteLine(a);


            //Task-3:-Operators(Arithmetic, Assignment, Comparison, Logical)

            //Task 3.1:-Basic Calculator – Take two numbers as input and perform addition,
            //subtraction, multiplication, division, and modulus operations.

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition:{num1 + num2}");
            Console.WriteLine($"Subtraction:{num1 - num2}");
            Console.WriteLine($"Multiply:{num1 * num2}");

            if (num2 != 0)
            {
                Console.WriteLine($"Remainder:{num1 % num2}");
                Console.WriteLine($"Dividend:{num1 / num2}");
            }
            else
            {
                Console.WriteLine("Error:Division by zero is not allowed");
            }

            //Task 3.2- Voting Eligibility Checker – Ask the user for their age and citizenship status(Y / N)
            //and determine if they are eligible to vote(Age ≥ 18 and must be a citizen).

            Console.Write("Enter the age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the citizenship status (Y/N):");
            char status = Convert.ToChar(Console.ReadLine());

            if (age >= 18 && (status == 'Y' || status == 'y'))
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            //Task 3.3:-Find the Largest Number – Take three numbers as
            //input and determine the largest using comparison operators.

            Console.Write("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int largest;

            if (n1 >= n2 && n1 >= n3)
            {
                largest = n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                largest = n2;
            }
            else
            {
                largest = n3;
            }

            Console.WriteLine($"The largest number is: {largest}");



            //Task 4- Strings(Concatenation, Interpolation, Access Strings, Special charec., Boolean

            //Task 4.1:Full Name Generator – Take first name and last name as input 
            //and display the full name using concatenation (+) and string interpolation($"").

            Console.Write("Enter the first name: ");
            string first_name = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string last_name = Console.ReadLine();



            Console.WriteLine(first_name + " " + last_name);
            Console.WriteLine($"Full name : {first_name} {last_name}");


            //Task 4.2- Character Extractor – Take a string as input and
            //print the first, last, and middle character(if the length is odd) using indexing.

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Check if the input is empty
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input! Please enter a valid string.");
                return;
            }

            // Extracting first and last character
            char firstChar = input[0];
            char lastChar = input[input.Length - 1];

            Console.WriteLine($"First character: {firstChar}");
            Console.WriteLine($"Last character: {lastChar}");

            // Check if the length is odd, then extract the middle character
            if (input.Length % 2 != 0)
            {
                char middleChar = input[input.Length / 2];
                Console.WriteLine($"Middle character: {middleChar}");
            }

            //Task 4.3- Escape Sequence Formatter – Print a multi - line formatted string using
            //special characters (\n, \t, \", \\) to display a structured output.

            Console.WriteLine("Escape Sequence Formatter\n");

            Console.WriteLine("1. New Line Example:");
            Console.WriteLine("Hello, World!\nWelcome to C# programming.\n");

            Console.WriteLine("2. Tab Example:");
            Console.WriteLine("Name:\tJohn Doe");
            Console.WriteLine("Age:\t25\n");

            Console.WriteLine("3. Quote Example:");
            Console.WriteLine("He said, \"C# is amazing!\"\n");

            Console.WriteLine("4. Backslash Example:");
            Console.WriteLine("C:\\Program Files\\Microsoft\\CSharp\n");


            //task 4.4:Even or Odd Checker – Take a number as input and use a boolean
            //expression to check if it is even (true) or odd (false).

            Console.Write("Enter a number: ");

            // Using TryParse to handle invalid inputs
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                return;
            }

            // Boolean expression to check even or odd
            bool isEven = (number % 2 == 0);

            // Display the result
            Console.WriteLine($"Is the number even? {isEven}");


            //Task 4.5:Login Authentication – Take a username and password as input,
            //compare them with predefined values, and return true if they match, otherwise false.


            // Predefined username and password
            string correctUsername = "admin";
        string correctPassword = "password123";

        // Taking user input
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        // Authentication check using a boolean expression
        bool isAuthenticated = (username == correctUsername && password == correctPassword);

        // Display result
        Console.WriteLine($"Login Successful: {isAuthenticated}");

            //task 4.5.1: Leap Year Validator – Take a year as input and check if
            //it is a leap year using boolean conditions (true for leap year, false otherwise).

            Console.Write("Enter a year: ");

            // Using TryParse to handle invalid inputs
            if (!int.TryParse(Console.ReadLine(), out int year) || year < 0)
            {
                Console.WriteLine("Invalid input! Please enter a valid positive year.");
                return;
            }

            // Boolean expression to check leap year conditions
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            // Display result
            Console.WriteLine($"Is {year} a leap year? {isLeapYear}");


            //Task 5: Statements(if, else, switch), Loop(for, foreach, while), Break and Continue
            //Task 5.1 :Statements(if, else, switch)

            //Task 5.1.1: Grade Calculator – Take a student's score as input 
            //and determine the grade (A, B, C, D, or F) using an if-else statement.

            Console.Write("Enter the marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 90)
            {
                Console.WriteLine("A grade");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("A grade");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("B grade");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("C grade");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("D grade");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("E grade");
            }
            else
            {
                Console.WriteLine("F grade");
            }

            //Task 5.1.2:Day of the Week – Take a number(1 - 7) as input
            //and display the corresponding day of the week using a switch statement.

            Console.Write("Enter a number between 1-7: ");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            switch (dayNum)
            {
                case 1:{
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Teusday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Input!! Please try again");
                        break;

                    }

            }
            //Task 5.1.3 : Even or Odd (Switch Expression) –
            //Use a switch expression to check if a number is even or odd.

            Console.Write("Enter a number : ");
            int checkNum = Convert.ToInt32(Console.ReadLine());

            switch (checkNum%2) {

                case 0:
                    Console.WriteLine($"{checkNum} is Even Number");
                    break;
                case 1:
                    Console.WriteLine($"{checkNum} is Odd Number is");
                    break;
             }


            //Task 5.2:Loops (for, foreach, while)
            //Task 5.2.1:Multiplication Table – Take a number as input
            //and print its multiplication table using a for loop.

            Console.Write("Enter a number : ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Multiplication table {i}:{inputNum*i}");
            }

            //Taske 5.2.2:Sum of Array Elements – Given an array of numbers,
            //use a foreach loop to calculate and display the sum.
            int[] array = { 12,23, 45, 6, 7 };
            int sum = 0;
            foreach (int i in array)
            {
                sum+= i;
            }
            Console.WriteLine($"Sum of the elements in array :{sum}\n");

            //Task 5.2.3:Number Guessing Game – Generate a random number (1-100)
            //and let the user guess it using a while loop until they get it right.
            Random random = new Random();
            int randomNum=random.Next(1,101);

            Console.WriteLine($" Random number from 1-100 : {randomNum}");

            Console.Write("Guess a number from 1-100 : ");
            int guessNum = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (randomNum == guessNum)
                {
                    Console.WriteLine("You guessed it right!! Hurray\n");
                    break;
                }
                Console.Write("Guess again : ");
                guessNum = Convert.ToInt32(Console.ReadLine());

            }

            //Task 5.3:Break and Continue
            //Task 5.3.1:Find First Divisible Number – Use a for loop to find the first number
            //divisible by both 3 and 5 in a given range. Use break to exit the loop when found.

            Console.Write("Enter a starting number : ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a ending number : ");
            int endNum = Convert.ToInt32(Console.ReadLine());

            for (int i = firstNum; i <= endNum; i++)
            {
                if((i%3==0) && (i % 5==0))
                {
                    Console.WriteLine($"Number is divisible by both 3 and 5: {i}\n");
                    break;
                }
                else
                {
                    Console.WriteLine("No nuumber is divisible\n");
                }
            }

            //task 5.3.2 :Skip Even Numbers – Print numbers from 1 to 10 using a for loop but skip even numbers using continue.

            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"Number present :{i}\n");
            }

            //task 5.3.3:User Login Attempts – Allow the user to enter a password with
            //a maximum of 3 attempts using a while loop and break if successful.

            Console.Write("Enter a password : ");
            

            int attempts = 0;
            while (true)
            {
                string passwordStr = Console.ReadLine() ?? "";
                if (correctPassword == passwordStr)
                {
                    Console.WriteLine("Correct Password!!\n ");
                    break;

                }
                attempts++;
                if (attempts == 3)
                {
                    Console.WriteLine("Your max limit is 3 ");
                    break;
                }
                Console.WriteLine("Wrong password!! Try again\n");

            }
































        }
    }
}


    
