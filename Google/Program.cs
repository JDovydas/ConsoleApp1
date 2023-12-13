namespace Google
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find most frequent element in the array of integers and return it (or any of them if there are multiple of them)

            {
                // Answer is 2
                int[] arr = { 1, 3, 2, 2, 3, 4, 3, 2, 1, 1, 3 };
                // how to solve?
                // what I have to use?
                int number = MostFrequentlyRepeated(arr);
                Console.WriteLine(number);
            }

            static int MostFrequentlyRepeated(int[] arr)
            {
                //number - how many times it is's repeated
                IDictionary<int, int> dictionary = new Dictionary<int, int>();

                foreach (int item in arr)
                {
                    //update
                    if (dictionary.ContainsKey(item))
                    {
                        dictionary[item] += 1;
                    }
                    else //creating new key
                    {
                        dictionary.Add(item, 1);
                    }

                }
                int maxValue = 0;
                int maxKey = 0;
                foreach (var keyPair in dictionary)
                {
                    if (keyPair.Value > maxValue)
                    {
                        maxValue = keyPair.Value;
                        maxKey = keyPair.Key;
                    }
                }

                return maxKey;
            }
        }
    }
}