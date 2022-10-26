using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercice1
    {
        public static bool isPrimeNumber(int number) // method to determine if a number is Prime or not

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
        public static int[] insertInATable(int[] tableOfNumbers, int number) // a method to insert a number in a sorted Array
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
        public static int findWeherToInsert(int[] table, int number) // method to locate where to insert
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

    }
    public class program 
    {
        
        public static void Main(String[] arg) // the Main method 
        {
            Console.WriteLine("********************** Exercise 1 : Prime numbers *****************************");

            String input;   // A variable to store the input
            bool IsValid_input = true; // a flag to determine if the input is valid or not
            int number; // a variable to store the input as an Integer
            
            do
            {
                Console.Write("\tinput a number : "); //asking for an input
                input = Console.ReadLine();     // reading the input form the console
                IsValid_input = int.TryParse(input, out number); // converting the input into Integer
            } while (!IsValid_input); // checking if the input is valid if not we ask again for an input

            if (Exercice1.isPrimeNumber(number)) // checking if the number is prime or not to display the corresponding output
                Console.WriteLine("\t" +number + " is a prime number.");
            else
                Console.WriteLine("\t" + number + " is not a prime number.");

            Console.WriteLine("********************** the end of the first Exercise *****************************\n\n");



            Console.WriteLine("********************** Exercise 2 : intsert a number in a sorted array  *****************************");

            int[] tableOfNumbers = { 12, 14, 15, 19 }; // the array where we will insert the number
            Console.Write("\tthe initial Array : ");// printing the array to the console
            foreach (var item in tableOfNumbers)
                Console.Write(item + " "); 
            Console.WriteLine();
            do
            {
                Console.Write("\tinput a number : "); // asking for an input
                input = Console.ReadLine();     // reading the input 
                IsValid_input = int.TryParse(input, out number);
            } while (!IsValid_input); // checking if the input is valid.

            tableOfNumbers = Exercise_2.insertInATable(tableOfNumbers, number); // inserting the number in the array
            Console.Write("\tafter inserting " + number + " in the Array  :: ");
            foreach (var item in tableOfNumbers) // printing the entire array 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        Console.WriteLine("********************* the end of the Second Exercise *****************************\n\n");
        }
    }
}
