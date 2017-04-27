using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Global_Country_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Global Country List Application Console!\n");

            int input;

            Console.WriteLine("Please choose from the following options: \n");
            Console.WriteLine("1.To display a list of countries that have been visited\n\n2.To add a country to the file you plan to vist\n\n3.To exit the console\n");
            while (!int.TryParse(Console.ReadLine(), out input)) ;

            if (input == 1)
            {
                string FileContent = ReadFromFile();
                Console.WriteLine(FileContent);
            }
            else if (input == 2)
            {
                string input2;
                Console.WriteLine("Add the country to the list: ");
                input2 = Console.ReadLine();             
                WriteToFile(input2);
            }
            else if (input == 3)
            {
                Console.WriteLine("Good Bye!");
                return;
            }
        }
        public static string ReadFromFile()
        {
            StreamReader rd = new StreamReader("../../CountryList.txt");

            string FileContent = rd.ReadToEnd();

            rd.Close();

            return FileContent;
        }
        public static void WriteToFile(string input2)
        {
            StreamWriter sw = new StreamWriter("../../CountryList.txt", true);
            sw.WriteLine(input2);//This process is called resource managment when closing a file out to allow others to use it.

            sw.Close();
        }
    }
}
