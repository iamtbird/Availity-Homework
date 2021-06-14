using System;

namespace LISP_Checker
{
    class Program
    {
        static void Main(string[] args)
        {//runs the balance checker and displays whether it returned true or false
            Console.WriteLine(BalanceCheck());
        }

        static bool BalanceCheck()
        {//asks for input
            Console.WriteLine("This program checks to see if the parentheses of your LISP code are properly closed and nested. \n" +
                "Please enter a string to check against: ");

            //takes input and stores it
            string lispCode = Console.ReadLine();

            //initializes a counter int to keep track of pairs of parentheses
            int count = 0;

            //loops and checks each character in the user input string
            foreach (char c in lispCode)
            {             
                if (c == '(')//increments the counter by one to show that a parenthesis has been opened
                {
                    count++;
                }
                
                if (c == ')')//decrements the counter to show that a parenthesis closed an open parenthesis
                {
                    count--;
                }
                
                if (count == -1)//if the counter ever hits -1, a closing parenthesis appeared without an open parenthesis, causing a break
                {
                    break;
                }
            }

            if (count != 0)//if the counter is anything but 0, a parenthesis was opened and not closed
                           //or a break happened with a closing and no opening to it
            {
                return false;
            }
            else//if the counter is 0 all parentheses were opened and closed properly
            {
                return true;
            }
        }
    }
}
