using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CondinalIfs
{
    internal class Program
    {
        static void Main(string[] args) { 
        
           /*
            int number = -1100;
            bool isAdmin = true;
                        
            /*
            // Several if's to meet multiple criteria (treated as separate cases)
            
            if(number > 0) 
            {
                Console.WriteLine("Number is positive");
            }

            if(number >= 100) 
            {
                Console.WriteLine("The number 100 or more");
            }

            // Several if's to meet multiple criteria - nesting is used


            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number >= 100)
            {
                Console.WriteLine("The number is 100 or more");
            }
            else if (number <= -100)
            {
                Console.WriteLine("The number is -100 or less");
                if (number <= -1000 && isAdmin)
                {
                    number = 0;
                    Console.WriteLine("The number is set to 0");
                }


            }
            else if (number == 0)
            {
                Console.WriteLine("The number is 0");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is 0");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }

            Console.WriteLine("THIS IS THE END OF OUR APPLICATION");

            
            //Task 1 A

            Console.WriteLine("Įveskite skaičių: ");
            int numberEntered = Convert.ToInt32(Console.ReadLine());

            

            if (numberEntered >= 100)
            {
                Console.WriteLine("The number is greater than 100");
            }
            else
            {
                Console.WriteLine("The number is less than 100");
            }

            //Task 1 B

            Console.WriteLine("Enter the day number");
            int dayNumberEntered = Convert.ToInt32(Console.ReadLine());

            if (dayNumberEntered == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayNumberEntered == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayNumberEntered == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayNumberEntered == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayNumberEntered == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayNumberEntered == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayNumberEntered == 7)
            {
                Console.WriteLine("Sunday");
            }
            else Console.WriteLine("Incorrect day number");

            */

            /*
            
            //Task 2 A

            
            
            Console.WriteLine("Enter the number");
            int numberEntered1 = Convert.ToInt32(Console.ReadLine());
            if (numberEntered1 % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }

            else if (numberEntered1 % 5 == 0)
            {
                Console.WriteLine("The number is divisible by 5"); 
            }

            else Console.WriteLine("Number does not meet any conditions");
            

            //Task 2 B

            Console.WriteLine("Enter the temperature");
            int temperature = Convert.ToInt32(Console.ReadLine());
            if (temperature < 0)
            {
                Console.WriteLine("Cold");
            }

            else if (temperature >= 0 && temperature <= 20)
            {
                Console.WriteLine("Cool");
            }

            else if (temperature > 20)
            {
                Console.WriteLine("Hot");
            }

            


            //Task 3 A

            Console.WriteLine("Enter the time");
            int wakeUpTime = Convert.ToInt32(Console.ReadLine());
            if (wakeUpTime < 12 && wakeUpTime > 0 )
            {
                Console.WriteLine("Good day!");
            }

            else if (wakeUpTime > 12 && wakeUpTime < 18)
            {
                Console.WriteLine("Good afternoon!");
            }

            else if (wakeUpTime > 18 && wakeUpTime < 24)
            {
                Console.WriteLine("Good evening!");
            }

            

            //Task 3 B

            string myPass = "namas";

            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            if (password == myPass)
            {
                Console.WriteLine("You have successfully logged in");
            }

            else if (password == "Mellon")
            {
                Console.WriteLine("You have successfully logged in");
            }

            else if (password == "01101001 01101110")
            {
                Console.WriteLine("Hacked..");
            }

            
            /*

            int number = 150;
            bool isAdmin = false;

            if (number >=50 && number <= 199) 
            {
                Console.WriteLine(number);
            }
            // is the number more or eaqual to 50 and number less or eaqual to 200 OR number is equal to 100 or is not Admin
            if ((number >=50 && number <= 200) || number == 100 || !isAdmin)
            {
                Console.WriteLine(number);
            }


            


            //Task 4

            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are a minor");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult");
            }
            else if (age >= 65)
            {
                Console.WriteLine("You are eligible for the Senior Citizen promotion");
            }
            
            

            //Task 5


            Console.WriteLine("Enter the number of years");
            int years = Convert.ToInt32(Console.ReadLine());
            
            if ((years % 4 == 0 && years % 100 != 0) || years % 400 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else Console.WriteLine("This is not a leap year");

            

            
            //Task 6

            Console.WriteLine("Enter the number of years");
            int numberStrange = Convert.ToInt32(Console.ReadLine());

            if (numberStrange % 3 == 0 && numberStrange % 5 == 0)
            {
                Console.WriteLine("BazingaPop");
            }
            else if (numberStrange % 3 == 0)
            {
                Console.WriteLine("BazingaPop");
            }
            else if (numberStrange % 5 == 0)
            {
                Console.WriteLine("Pop");
            }
            else
            {
                Console.WriteLine(numberStrange);
            }

                  
            //Task 7 A

            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 0 && num2 >= 0)
            {
                Console.WriteLine("Both numbers are positive");
            }
            else if (num1 >= 0 || num2 >= 0)
            {
                Console.WriteLine("Only one number is positive");
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("Neither number is positive");
            }

            
            //Task 7 B

            
            Console.WriteLine("Enter three numbers");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            int numb2 = Convert.ToInt32(Console.ReadLine());
            int numb3 = Convert.ToInt32(Console.ReadLine());

            if (numb1 == numb2 && numb2 == numb3)
            {
                Console.WriteLine("All numbers are equal");
            }
            else if (numb1 == numb2 || numb2 == numb3 || numb1 == numb3)
            {
                Console.WriteLine("Two numbers are equal");
            }
            else
            {
                Console.WriteLine("None of the numbers are equal");
            }

            

            
            //Task 8 A
            Console.WriteLine("Enter three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 &&  b >= 0 || a >= 0 && b >= 0 || b >= 0 && c >= 0 || a >= 0 && b >= 0 &&  c >= 0)
            {
                int result = a + b + c;
                Console.WriteLine(result);
            }
            else Console.WriteLine("Could not calculate sum");

                      

            //Task 8 B
            Console.WriteLine("Enter the year and month");
            string year = Console.ReadLine();
            string month = Console.ReadLine();

            if (month == "January" || month == "February" || month == "March")
            {
                Console.WriteLine("Cold period");
            }
            else if (month == "June" || month == "July" || month == "August")
            {
                Console.WriteLine("Hot period");
            }    
            else Console.WriteLine("Medium period month");

            


            //Task 9

            
            Console.WriteLine("Enter three numbers");
            int length1 = Convert.ToInt32(Console.ReadLine());
            int length2 = Convert.ToInt32(Console.ReadLine());
            int length3 = Convert.ToInt32(Console.ReadLine());

            if ((length1 + length2) > length3 || (length2 + length3) > length1 || (length3 + length1) > length2)
            {
                Console.WriteLine("Can form a triangle");
            }
            else
            {
                Console.WriteLine("Cannot form a triangle");
            }

            

            //Task 10

            string product1 = "bananas";
            string product2 = "apelsinas";
            string product3 = "ananasas";

            int product1Price = 2;
            int product2Price = 1;
            int product3Price = 4;

            Console.WriteLine("Please select 3 products");
            var selection1 = Console.ReadLine();
            var selection2 = Console.ReadLine();
            var selection3 = Console.ReadLine();

            if (selection1 == product1)

            {
                Console.WriteLine($"You selected {product1} and its price is {product1Price}");
            }
            if (selection2 == product2)
            {
                Console.WriteLine($"You selected {product2} and its price is {product2Price}");
            }
            if (selection3 == product3)
            {
                Console.WriteLine($"You selected {product3} and its price is {product3Price}");
            }
            else {
                Console.WriteLine("Unknown products and unknown prices - Bye");
            }

            */

        }
    }
}