using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercice1
    {
        public static bool isPrimeNumber(int number)

        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
    public class Exercise_2
    {
        public static int findWeherToInsert(int[] table, int number)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (number <= table[i])
                {
                    return i;
                }
            }
            return table.Length;
        }
        public static int[] insertInATable(int[] tableOfNumbers, int number)
        {
            
            int position = findWeherToInsert(tableOfNumbers, number);
            Array.Resize<int>(ref tableOfNumbers, tableOfNumbers.Length+1);
            for (int i = tableOfNumbers.Length -1; i > position; i--)
            {
                tableOfNumbers[i] = tableOfNumbers[i - 1];
            }
            tableOfNumbers[position] = number;
            return tableOfNumbers;
        }

    }
    public class program
    {
        
        public static void Main(String[] arg)
        {
            Console.WriteLine("********************** Exercise 1 : Prime numbers *****************************");

            String input;   // the input of the user as a string
            bool IsValid_input = true; // a flag to determine if an input is valide or not
            int number; // to store the number we will check as Integer
            
            do
            {
                Console.Write("\tinput a number : "); // dispaly a message
                input = Console.ReadLine();     // read the input 
                IsValid_input = int.TryParse(input, out number); // check if the input is an Integer if not ask the user again
            } while (!IsValid_input);

            if (Exercice1.isPrimeNumber(number)) // check the return of the fucntion "isPrimeNumber" and display the corresponding message
                Console.WriteLine("\t" +number + " is a prime number.");
            else
                Console.WriteLine("\t" + number + " is not a prime number.");

            Console.WriteLine("********************** the end of the first Exercise *****************************\n\n");



            Console.WriteLine("********************** Exercise 2 : intsert a number in a sorted array  *****************************");

            int[] tableOfNumbers = { 12, 14, 15, 19 }; // a sorted array with 5 variables
            Console.Write("\tthe initial Array : ");
            foreach (var item in tableOfNumbers)
                Console.Write(item + " "); // print the entire array
            Console.WriteLine();
            do
            {
                Console.Write("\tinput a number : "); // ask for an input
                input = Console.ReadLine();     // read the input 
                IsValid_input = int.TryParse(input, out number);
            } while (!IsValid_input); // check if the input is an Integer if not ask again

            tableOfNumbers = Exercise_2.insertInATable(tableOfNumbers, number); // inserting the number in the array
            Console.Write("\tafter inserting " + number + " in the Array  :: ");
            foreach (var item in tableOfNumbers) // print the entire array 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        Console.WriteLine("********************* the end of the Second Exercise *****************************\n\n");
        }
    }
}
