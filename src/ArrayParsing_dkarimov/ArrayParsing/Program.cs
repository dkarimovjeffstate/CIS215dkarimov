//the purpose of this program is to parse through a given input and give out numbers and reject anything not a numbers
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayParsing
{
    internal class Program
    {
        // this method where i put my while loop and it loops through my other method called ParseArray
        static void Main(string[] args)
        {
            bool response = true; 
            while (response) //this is my while loop and it is testing my ParseArray with a variable called response.
            {
                Console.Write("Give me a list of numbers with commas inbetween: ");
                string numberInput = Console.ReadLine();
                //Console.WriteLine(numberInput);

                ParseArray(numberInput); //this will take the string input and give you the output

                Console.WriteLine("Do you want to input another example? (Y/N): ");
                string userResponse = Console.ReadLine().ToLower();
                
                if (userResponse == "y")
                {       //this if state will check to see if the user wants to continue
                    response = true; //if user enters y it continues the loop in the while loop up in the main
                }
                else
                {
                    response = false; //if user enter anything else it returns false to stop the while loop in the main
                }
            }
            
            Console.ReadKey();
        }

        // this method checks to see if the string input is a decimal
        public static bool CheckInt(string input) { //this function check ints is where i do my error catching
            try
            {
                Convert.ToDecimal(input); //this block will try to convert what the string input is to a decimal
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //this catches the error and puts out a error message to the console
                return false;
            }
        
        }

        public static void ParseArray(string numberInput ) { //this method where i do the parsing and ask the user for inputs.

            string results = ""; //variable i put the numbers into

            foreach (string number in numberInput.Split(",")) //this foreach loop will the variable numberInput and take away the commas.
            {
                //Console.WriteLine(number.Trim());
                if (CheckInt(number)) // i use the CheckInt function to check to see if the number is a decimal
                {
                    //Console.WriteLine("thank you for the number");
                    results += number.Trim(); //this will take away the non numnbers that is input into the loop
                    results += ","; //this adds the comma back into the after taking away the non numbers

                }

            }
            Console.WriteLine();
            Console.WriteLine("Your output: " + results.Trim(',') + "\n"); 
        }
    }
}