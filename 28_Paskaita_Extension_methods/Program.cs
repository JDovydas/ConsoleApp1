namespace _28_Paskaita_Extension_methods

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "Hello my name is Rokas";

            ////bool isAlphabetic = MyExtentionMethod.IsLetters(text); // IF WE DO NOT USE "THIS" IN THE METHOD

            //bool isAlphabetic = text.IsLetters(); // IF WE USE "THIS" IN THE METHOD

            //int wordCount = text.WordCount(' ');


            ////1
            //var number1 = -5;

            //Console.WriteLine(number1.IsNumberPositive());

            ////2
            //var number2 = 9;

            //Console.WriteLine(number2.IsNumberEven());

            ////3
            //Console.WriteLine("Enter your random number");
            //int input = Convert.ToInt32(Console.ReadLine());

            //var number3 = 10;

            //Console.WriteLine(number3.IsYourNumberGreater(input));

            //4

            //var sentence = "Gyvenu gerai";

            //Console.WriteLine(sentence.DoesSentenceContainSpaces());
            //Console.WriteLine(@$"Does the sentence ""{sentence}"" contain spaces? Answer: {sentence.DoesSentenceContainSpaces()}");

            ////5

            //string name = "Dovydas".ToLower();
            //string year = "1950".ToLower();
            //string domain = "gmail.com".ToLower();

            //string emailAddress = "";

            //Console.WriteLine($"Generated email address is: {emailAddress.ReturnEmailAddress(name, year, domain)}");

            ////6
            //List<string> words = new List<string>
            //{
            //    "BIGMAC",
            //    "YAMMI",
            //    "HESBURGER"
            //};

            //string objectToCheck = "BIGMAC";

            //Console.WriteLine($"Does the list contain word {objectToCheck}? Answer: {words.FindAndReturnIfEqual(objectToCheck)}");

            //7

            //var myList = new List<string>
            //{
            //    "Namas",
            //    "Bebras",
            //    "Kelias",
            //    "Uztvanka"
            //};

            //var newList = myList.EveryOtherWord();

            //Console.WriteLine(newList);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}


            //8

            string path = "LongStoryShort.txt";

            var shortStory = path.ReadEverySecondLine();

            foreach (var item in shortStory)
            {
                Console.WriteLine(item);
            }











        }
    }
}