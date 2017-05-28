using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCodeKata
{
    class Program
    {
        static void Main(string[] args)
        { //although this is a simple kata, i realized that i need to comment regardless of how simple the code may be. for my own understanding, i will comment, what the code is doing
            for (int i=1; i <=100; i++)//the for loop is great for counting, which is why it has good use in this particular exercise
                //integer assigned to variable i is equal to 1 as a starting point;
                //if i is less than or equal to 100;
                //i using the incrementer of ++ to increase 1 by 1, the next code will tell the program what to do when going through the loop and the incremented # results in a product of 3 or 5
            {
                if (i % 3 == 0) Console.WriteLine("Fizz"); //if i modulus 3 has a remainder of 0, then print "Fizz" to console
                if (i % 5 == 0) Console.WriteLine("Buzz"); //if i modulus 5 has a remainder of 0, then pring "Buzz" to the console
                if (Console.CursorLeft == 0) Console.WriteLine(i); // What does Console.CursorLeft do? Not familiar with this command. 
                                                                    //Microsoft Definition: Gets or sets the column position of the cursor within the buffer area
                                                                    //Note to self: Can FizzBuzz be solved without the Console.CursorLeft command?
                Console.WriteLine(); //prints a blank line within the end of the loop
            }
                Console.ReadLine(); //the command used when user input is needed in the console
        }
    }
}
