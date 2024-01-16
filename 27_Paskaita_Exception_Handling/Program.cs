namespace _27_Paskaita_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    //int zero = 0;
            //    //int division = 8 / zero;
            //    //Console.WriteLine(division);
            //    Test.Test1();

            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    Console.WriteLine(ex.Message.ToString());

            //}
            //finally
            //{
            //    Console.WriteLine();
            //}

            //Console.WriteLine("End");

            /*
            int retry = 0;
            int index = 0;

            while (retry < 3)
            {
                try
                {
                    int[] ints = { 1, 20, 3, 0, 1, 1 };

                    for (int i = index; i < ints.Length; i++)
                    {

                        index = i;
                        int number = 10;
                        int division = number / ints[i];
                        Console.WriteLine(division);
                        break;

                    }
                    break;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    retry++;
                    Console.WriteLine($"We had {retry} retries");

                }



            }
            Console.WriteLine("End");
            */

            //1
            /*
            string invalidString1 = "abc";
            string invalidString2 = "12345678945642345647869789453643526132156456489";

            try
            {
                //double result1 = Convert.ToDouble(invalidString1);
                int result2 = Convert.ToInt32(invalidString2);
                Console.WriteLine(result2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("End");
            */

            //2

            // Declare an array of max index 4

            int[] arr = { 1, 2, 3, 4, 5 };

            // Display values of array elements

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            try
            //Try to access invalid index of array
            {
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //int[] arr = { 19, 0, 75, 52 };
            //// Try to generate an exception         
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine(arr[i] / arr[i + 1]);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);

            //    }
            //}

            //int[] arr = { 19, 0, 75, 52 };
            //try
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i] / arr[i + 1]);
            //    }
            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            /* 
            Task 4
            -   Create a file reading class.
            -   What errors can occur when trying to read a file?
            -   Trying to find a file?
            -   Create mechanisms to protect against "breaking the programme
            */

            /*
            string filePath1 = "example.txt";
            FileReader fileReader = new FileReader(filePath1);

            string fileContent = fileReader.ReadFile();


            if (fileContent != null)
            {
                Console.WriteLine("File content:\n" + fileContent);
            }
            else
            {
                Console.WriteLine("Failed to read the file.");
            }

            */


        }
    }
}