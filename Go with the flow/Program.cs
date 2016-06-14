using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_with_the_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You just ordered a Whopper.  Would you like an order of fries?  Answer yes or no!");


            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")

                    {
                Console.WriteLine("Okay, would you also like a Pepsi?  Answer yes or no!");

                 answer = Console.ReadLine();

                if (answer.ToLower() == "yes")

                        {
                    Console.WriteLine("Okay, your whopper, fries and Pepsi will be up soon.  Please pay the cashier!");
                }
                else
                    Console.WriteLine("Okay, your whopper and fries will be up soon.  Please pay the cashier!");
            }
            else
                Console.WriteLine("Okay, would you also like Pepsi?  Answer yes or no!!");
             answer = Console.ReadLine();

            if (answer.ToLower() == "yes")

            {
                Console.WriteLine("Okay, your whopper and Pepsi will be up soon.  Please pay the cashier!");

            }
            else
                Console.WriteLine("Okay, your whopper will be up soon.  Please pay the cashier!");

            Console.ReadKey();
               
        }
    }


}
