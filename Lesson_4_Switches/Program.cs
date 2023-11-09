using System;

namespace Lesson_4_Switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
         /*
            
         /*
            int number = 0;
            //char symbol = 'A'

            switch (number) 
            {
                case 0: //case 'A':
                    Console.WriteLine("Number is 0");
                    break;
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                default: 
                    Console.WriteLine("Number is other");
                    break;
            }

            //The above is equal/similar to the b

            if (number == 0)
            {
                Console.WriteLine("Number is 0");
            }
            else if (number == 1)
            {
                Console.WriteLine("Number is 1");
            }
            else if (number == 2)
            {
                Console.WriteLine("Number is 2");
            }
            else Console.WriteLine("Number is other");



            char input = 'A';
            
            switch (input)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Number is 0");
                    break;
                case 'D':
                case 'E':
                    Console.WriteLine("hO HO Ho");
                    break;
                case '2':
                    Console.WriteLine("Number is 2");
                    break;
                default:
                    Console.WriteLine("Number is other");
                    break;
            }


            //Ranges

            int number1 = 20;
            
            switch (number1)
            {
                case int x when (x >= 0 && x <= 50): 
                    Console.WriteLine("0 - 50");
                    break;
                case int x when (x > 50 && x <= 100):
                    Console.WriteLine("51 - 100");
                    break;
                default:
                    Console.WriteLine("Number is other");
                    break;
            }

            int number2 = 20;

            switch (number2)
            {
                case >= 0 and <= 50:
                    Console.WriteLine("0 - 50");
                    break;
                case > 50 and <= 100:
                    Console.WriteLine("51 - 100");
                    break;
                default:
                    Console.WriteLine("Number is other");
                    break;
            }

            int number3 = 20;

            string range = number3 switch
            {
                >= 0 and <= 50 => "0 - 50",
                > 50 and <= 100 => "51 - 100",
                _ => "Hi",
            };


            int number4 = 20;

            string range1 = number4 switch
            {
                50 => "0 - 50",
                100 => "51 - 100",
                _ => "Hi",
            };

            switch (number3)
            {
                case >= 0 and <= 50:
                    Console.WriteLine("0 - 50");
                    break;
                case > 50 and <= 100:
                    Console.WriteLine("51 - 100");
                    break;
                default:
                    Console.WriteLine("Number is other");
                    break;
            }

            

            // Task 1 A

            

            Console.WriteLine("Input day of the week (1-7)");
            int dayInput = Convert.ToInt32(Console.ReadLine());

            switch (dayInput) 
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;
            }

            


            // Task 1 B

            Console.WriteLine("Please input your age (e.g. 69");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            switch (yourAge) 
            {
                case >= 7 and <= 18:
                    Console.WriteLine("Pupil");
                    break;
                case >=19 and <= 25:
                    Console.WriteLine("Student");
                    break;
                case >= 26 and <= 65:
                    Console.WriteLine("Employee");
                    break;
                case > 66:
                    Console.WriteLine("Retired");
                    break;

            }

            // Task 1 C

            Console.WriteLine("Input the month number to get the month name");
            int monthInput = Convert.ToInt32(Console.ReadLine());

            switch (monthInput)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }

            

            // Task 2 A

            Console.WriteLine("Please enter the name of one of the four different shapes - square, circle, triangle, rectangle");

            string shape = Console.ReadLine().ToLower();

            switch (shape) 
            {
                case "square":
                    Console.WriteLine("Please provide the side of a square to get the area of this shape");
                    double squareSide = Convert.ToInt32(Console.ReadLine());
                    double squareArea = Math.Pow(squareSide, 2);
                    Console.WriteLine($"The area of your {shape} is {squareArea}");
                    break;
                case "circle":
                    Console.WriteLine("Please provide the radius of a circle to get the area of this shape");
                    double circleRadius = Convert.ToInt32(Console.ReadLine());
                    double circleArea = Math.PI * circleRadius * circleRadius;
                    Console.WriteLine($"The area of your {shape} is {circleArea}");
                    break;
                case "triangle":
                    Console.WriteLine("Please provide the height of the triangle");
                    double triangleHeight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please provide the base of the triangle");
                    double triangleBase = Convert.ToInt32(Console.ReadLine());
                    double triangleArea = (triangleHeight * triangleBase) / 2;
                    Console.WriteLine($"The area of your {shape} is {triangleArea}");
                    break;
                case "rectangle":
                    Console.WriteLine("Please provide the length of the rectangle");
                    double rectangleLength = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please provide the width of the rectangle");
                    double rectangleWidth = Convert.ToInt32(Console.ReadLine());
                    double rectangleArea = (rectangleLength * rectangleWidth);
                    Console.WriteLine($"The area of your {shape} is {rectangleArea}");
                    break;

            }

            
            // Task 2 B

            Console.WriteLine("Please enter the name of one of the five basic elements (fire, water, air, earth, ether) to get its characteristic");

            string element = Console.ReadLine().ToLower();

            switch (element)
            {
                case "fire":
                    Console.WriteLine("Can't resist turning everything into a roast");
                    break;
                case "water":
                    Console.WriteLine("Always up for a deep conversation because they're so good at diving in");
                    break;
                case "air":
                    Console.WriteLine("If you ever need to find Air at a crowded event, just look for the helium balloons");
                    break;
                case "earth":
                    Console.WriteLine("The most down-to-earth of all the elements");
                    break;
                case "ether":
                    Console.WriteLine("Represents the unifying force that binds all elements together");
                    break;
            }
            

            // Task 2 C

            Console.WriteLine("Please choose one of four university majors: maths, computer science, biology, chemistry");

            string major = Console.ReadLine().ToLower();
            switch (major) 
            {
                case "maths":
                    Console.WriteLine("Please enter your grade point average");
                    double mathsGradeAverage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your final exam grade");
                    double mathsFinalGrade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please state how many times have you been a prizewinner in the country's Olympics");
                    double mathsTimesPrizewinner = Convert.ToInt32(Console.ReadLine());
                    double mathScore = 0.4 * mathsGradeAverage + 0.4 * mathsFinalGrade + 0.2 * mathsTimesPrizewinner; //Max potential score +- 10
                    Console.WriteLine($"Congratulations, your final score is {mathScore}");
                    break;
                case "computer science":
                    Console.WriteLine("Please enter your grade point average");
                    double computerscienceGradeAverage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your final exam grade");
                    double computerscienceFinalGrade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please state how many times have you been a prizewinner in the country's Olympics");
                    double computerscienceTimesPrizewinner = Convert.ToInt32(Console.ReadLine());
                    double computerscienceScore = 0.4 * computerscienceGradeAverage + 0.4 * computerscienceFinalGrade + 0.2 * computerscienceTimesPrizewinner; //Max potential score +- 10
                    Console.WriteLine($"Congratulations, your final score is {computerscienceScore}");
                    break;
                case "biology":
                    Console.WriteLine("Please enter your grade point average");
                    double biologyGradeAverage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your final exam grade");
                    double biologyFinalGrade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please state how many times have you been a prizewinner in the country's Olympics");
                    double biologyTimesPrizewinner = Convert.ToInt32(Console.ReadLine());
                    double biologyScore = 0.4 * biologyGradeAverage + 0.4 * biologyFinalGrade + 0.2 * biologyTimesPrizewinner; //Max potential score +- 10
                    Console.WriteLine($"Congratulations, your final score is {biologyScore}");

                    break;
                case "chemistry":
                    Console.WriteLine("Please enter your grade point average");
                    double chemistryGradeAverage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your final exam grade");
                    double chemistryFinalGrade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please state how many times have you been a prizewinner in the country's Olympics");
                    double chemistryTimesPrizewinner = Convert.ToInt32(Console.ReadLine());
                    double chemistryScore = 0.4 * chemistryGradeAverage + 0.4 * chemistryFinalGrade + 0.2 * chemistryTimesPrizewinner; //Max potential score +- 10
                    Console.WriteLine($"Congratulations, your final score is {chemistryScore}");
                    break;

            }

            

            // Task 3 A

            Console.WriteLine("Enter the month number to know if it is spring, summer, autumn or winter");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 12:
                case 1: 
                case 2:
                    Console.WriteLine("Seems to be Winter");
                    break;
                case > 2 and < 6:
                    Console.WriteLine("Happy spring!");
                    break;
                case >= 6 and < 9:
                    Console.WriteLine("Summer sadness");
                    break;
                case >= 9 and < 13:
                    Console.WriteLine("Freezing cold - seems to be Winter?");
                    break;
                default: Console.WriteLine("No such month, try next time");
                    break;
            }

           

            

            //Task 3 B

            Console.WriteLine("Please select one of the following actions: addition, subtraction, multiplication, division, squaring, root pulling");
            string action = Console.ReadLine();

            Console.WriteLine("Thanks for selecting action, please select the number 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select the number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());


            switch (action)
            {
                case "addition":
                    int addition = number1 + number2;
                    Console.WriteLine($"The sum of your two numbers is {addition}");
                    break;
                case "subtraction":
                    Console.WriteLine("Thanks for selecting action, please select the number 1");
                    int subtractionnum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please select the number 2");
                    int subtractionnum2 = Convert.ToInt32(Console.ReadLine());
                    int subtraction = subtractionnum1 - subtractionnum2;
                    Console.WriteLine($"The sum of your two numbers is {subtraction}");
                    break;
                case "multiplication":
                    Console.WriteLine("Thanks for selecting action, please select the number 1");
                    int multiplicationnum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please select the number 2");
                    int multiplicationnum2 = Convert.ToInt32(Console.ReadLine());
                    int multiplication = multiplicationnum1 * multiplicationnum2;
                    Console.WriteLine($"The sum of your two numbers is {multiplication}");
                    break;
                case "division":
                    Console.WriteLine("Thanks for selecting action, please select the number 1");
                    int subtractionnum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please select the number 2");
                    int subtractionnum2 = Convert.ToInt32(Console.ReadLine());
                    int subtraction = subtractionnum1 / subtractionnum2;
                    Console.WriteLine($"The sum of your two numbers is {subtraction}");
                    break;

            }

        
            

         //Task 3 B - updated version

            Console.WriteLine("Please select one of the following actions: addition, subtraction, multiplication, division, squaring, root pulling");
            string action = Console.ReadLine();

            Console.WriteLine("Thanks for selecting action, please select the number 1");
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select the number 2");
            double number2 = Convert.ToInt32(Console.ReadLine());


            switch (action)
            {
                case "addition":
                    double addition = number1 + number2;
                    Console.WriteLine($"The sum of your two numbers is {addition}");
                    break;
                case "subtraction":
                    double subtraction = number1 - number2;
                    Console.WriteLine($"The subtraction result of your two numbers is {subtraction}");
                    break;
                case "multiplication":
                    double multiplication = number1 * number2;
                    Console.WriteLine($"The multiplication result of your two numbers is {multiplication}");
                    break;
                case "division":
                    double division = number1 / number2;
                    Console.WriteLine($"The result is {division}");
                    break;
                case "squaring":
                    Console.WriteLine("We will square your first number only - sorry for inconvenience");
                    double squaring = number1 * number1;
                    Console.WriteLine($"The result is {squaring}");
                    break;
                case "rootPulling":
                    Console.WriteLine("We will proceed with root pulling using your first number only - sorry for inconvenience");
                    double rootPulling = Math.Sqrt(number1);
                    Console.WriteLine($"The sum of your two numbers is {rootPulling}");
                    break;
                default:
                    Console.WriteLine("such scenario is not available");
                    break;


                    

            }


            //Task 3 B (version1)

            

            Console.WriteLine("Please select one of the following actions: addition, subtraction, multiplication, division, squaring, root pulling");
            string action = Console.ReadLine();

            Console.WriteLine("Thanks for selecting action, please select the number 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select the number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());


            switch (action)
            {
                case "addition":
                    int addition = number1 + number2;
                    Console.WriteLine($"The sum of your two numbers is {addition}");
                    break;
                case "subtraction":
                    Console.WriteLine("Thanks for selecting action, please select the number 1");
                    int subtractionnum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please select the number 2");
                    int subtractionnum2 = Convert.ToInt32(Console.ReadLine());
                    int subtraction = subtractionnum1 - subtractionnum2;
                    Console.WriteLine($"The sum of your two numbers is {subtraction}");
                    break;
                case "multiplication":
                    Console.WriteLine("Thanks for selecting action, please select the number 1");
                    int multiplicationnum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please select the number 2");
                    int multiplicationnum2 = Convert.ToInt32(Console.ReadLine());
                    int multiplication = multiplicationnum1 * multiplicationnum2;
                    Console.WriteLine($"The sum of your two numbers is {multiplication}");
                    break;
                case "division":
                    Console.WriteLine("Thanks for selecting action, please select the number 1");
                    int subtractionnum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please select the number 2");
                    int subtractionnum2 = Convert.ToInt32(Console.ReadLine());
                    int subtraction = subtractionnum1 / subtractionnum2;
                    Console.WriteLine($"The sum of your two numbers is {subtraction}");
                    break;

            }

            */
            
        }

    }
}