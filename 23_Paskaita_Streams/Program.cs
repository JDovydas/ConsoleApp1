using System.IO;
using System.IO.Pipes;
using System.Text;

namespace _23_Paskaita_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            string path1 = "C:\\Desktop\\text.txt"; //Use two "//" to access the folders
            string path2 = @"C:\Desktop\text.txt"; //Use @ to avid "//" 
            string path = "text.txt";



            File.WriteAllText(path, "This is changed text ********************\n This is new line");
            File.AppendAllText(path, "This is changed text ********************\n This is new line");

            string myText = File.ReadAllText(path);
            Console.WriteLine("This is file contant: " + myText);

            Thread.Sleep(1000);
            */
            /*
            string path = "text.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hey, hey hey");
                writer.WriteLine("Hey, hey hey");
                writer.WriteLine("Hey, hey hey");
                writer.WriteLine("Hey, hey hey");

            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null) // alternative way = while(reader.Peek() >= 0)
                {
                    Console.WriteLine("Reader: " + line);
                }
            }
            */
            /*
            string path2 = "testFileCreate.txt";
            using (FileStream writer = new FileStream(path2, FileMode.Create))
            {
                byte[] text = Encoding.ASCII.GetBytes("Hello");

                writer.Write(text);

            }

            using (FileStream reader = new FileStream(path2, FileMode.Open, FileAccess.Read, FileShare.None, 4096))
            //FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 4096);
            {
                List<byte> bytes = new List<byte>();
                int oneByte = 0;
                while ((oneByte = reader.ReadByte()) != -1)
                {
                    bytes.Add((byte)oneByte);
                }

                Console.WriteLine(Encoding.ASCII.GetString(bytes.ToArray()));
                //reader.Close();
            }
            */
            //1.1 Read the entire text file using the File.ReadAllText() method and print it to the console.
            /*
            string filePath = "test.txt";
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine($"File content: {fileContent}");
            */
            //1.2 Write the contents of the List<string> list to the file, each item as a new string. Using File.WriteAllLines().
            /*
            List<string> lines = new List<string>
            {
                "Line 1",
                "Line 2",
                "Line 3"
            };

            string filePath2 = "TestFile2.txt";

            File.WriteAllLines(filePath2, lines);

            foreach (string line in lines)

            {
                Console.WriteLine(line);
            }
            */
            //1.3 Copy the file from one location to another using the File.Copy() method
            /*


            string filePath = "test.txt";
            string filePath3 = "TextFile3.txt";

            File.Copy(filePath, filePath3);
            string file3Content = File.ReadAllText(filePath3);
            Console.WriteLine($"File content in the new file: {file3Content}");
            */
            //2.1 Read a large text file line by line and count the number of characters in each line. Use File.ReadLines()
            /*
            
            string textPath = "C:\\Users\\djuod\\OneDrive\\Paskaitos\\Level 2\\randomText.txt";

            foreach (string line in File.ReadLines(textPath))
            {
                int charCount = line.Length;
                Console.WriteLine($" Line: {line}, Character count: {charCount}");
            }
            */
            //2.2 Write to a file using the StreamWriter class, write both textual and numeric data.
            /*
            string filePath1 = "task2.txt";

            using (StreamWriter writer = new StreamWriter(filePath1))
            {
                string text = "hohoho";
                writer.WriteLine($"This is the text value: {text}");
                int number = 10;
                writer.WriteLine($"This is the numeric value: {number}");
            }

            using (StreamReader reader = new StreamReader(filePath1))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null) // alternative way = while(reader.Peek() >= 0)
                {
                    Console.WriteLine("Reader: " + line);
                }
            }
            */

            //2.3 Write the binary data to a file, try using BinaryReader and BinaryWriter

            string file = "textToBinary.txt";

            using (FileStream fileStream = new FileStream(file, FileMode.Create))
            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                string text = "Laba diena Lietuva";
                binaryWriter.Write(text);
                int numbers = 123456789;
                binaryWriter.Write(numbers);

            }


            using (FileStream fileStream = new FileStream(file, FileMode.Open))
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                string text = binaryReader.ReadString();
                Console.WriteLine($"Text:\n {text}");

                int numbers = binaryReader.ReadInt32();
                Console.WriteLine($"Numbers:\n {numbers}");

                binaryReader.PeekChar();




            }



        }
    }
}