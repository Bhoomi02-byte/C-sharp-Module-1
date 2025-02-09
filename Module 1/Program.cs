
//Learn about the Variables, Data Types & Type Casting


using System;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
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

            if (age >= 18 && status == 'Y')
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


        }
    }













}


    
