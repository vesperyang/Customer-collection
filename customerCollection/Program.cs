using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _000000;

namespace CustCollectionApp
{
    class Program
    {

        static void Main(string[] args)
        {
            test test = new test();
            CustomerInfo aCollection = new CustomerInfo();
            //store customer information

            aCollection.Insert("Morris", "Scott", 11111111, "cash", 2);
            aCollection.Insert("Turnbull", "Malcolm", 22222222, "card", 0);
            aCollection.Insert("Rudd", "Kevin", 33333333, "cash", 1);
            aCollection.Insert("Howard", "John", 55555555, "card", 2);
            aCollection.Insert("Gillard", "Julia", 44444444, "card", 1);
            aCollection.Display();
            Console.WriteLine();
            aCollection.Sort();
            aCollection.Display();
            Console.WriteLine();
            //delete customer information
            aCollection.Delete("Morris", "Scott", 11111111, "cash", 2);
            aCollection.Display();
            Console.WriteLine();
            CustomerCollection lnklist = new CustomerCollection();
            ChooseSeat chooseSeat = new ChooseSeat();
            lnklist.PrintAllCsutomer();
            Console.WriteLine();
            //add customer without searching in the linked list
            lnklist.AddAtLast("Morris");
            lnklist.PrintAllCsutomer();
            Console.WriteLine();
            lnklist.AddAtLast("Turnbull");
            lnklist.PrintAllCsutomer();
            Console.WriteLine();
            lnklist.AddAtLast("Rudd");
            lnklist.PrintAllCsutomer();
            Console.WriteLine();
            lnklist.AddAtLast("Gillard");
            lnklist.PrintAllCsutomer();
            Console.WriteLine();
            lnklist.AddAtStart("Howard");
            lnklist.PrintAllCsutomer();
            Console.WriteLine();

            //remove customer when we find the match index
            lnklist.RemoveFromStart();
            Console.WriteLine();
            //serving customers
            // check if seats are available, if not stop serving customer
            // check if they exist in the system
            //  if exist sell ticket
            //  sell the ticket
            // if not insert customer's detail and sell the ticket

            bool isfound = false;
            string customer1 = "Rudd";


            for (int i = 0; i < 5;)// within the capacity of cinema
            {
                i++;
                //search customer
                if (lnklist.SearchElement(customer1) == !isfound)
                {
                    chooseSeat.pickSeat(i);
                    break;

                }
                else// when index doesn't match
                {
                    lnklist.AddAtLast(customer1);//add customer
                    lnklist.PrintAllCsutomer();//list all customers
                    aCollection.Insert("huh", "kok", 789065, "cash", 0);//insert customer information
                    aCollection.Display();//display information of all customer
                    lnklist.RemoveFromStart();//remove the firsr index in the linked list
                    lnklist.PrintAllCsutomer();//display the linked list
                    Console.WriteLine();
                    chooseSeat.pickSeat(i);//pick a seat when

                }
            }

            Console.WriteLine();
            //scheduling the movie
            FavoMovie FavoMovie = new FavoMovie();
            FavoMovie.push(3);//receive new moive
            FavoMovie.push(2);
            FavoMovie.push(1);
            Console.WriteLine("the recent playing movie is : " + FavoMovie.peek());// show the most recent movie
            Console.WriteLine("The number of movies in store is = " + FavoMovie.size());//display the number of movies in store
            Console.WriteLine("--------------------------------------------------------");
            FavoMovie.pop();//play the recent movie
            Console.WriteLine("the recent playing movie is: " + FavoMovie.peek());// show the next recent movie
            Console.WriteLine("The number of movies in store is = " + FavoMovie.size());// display the number of mocves in store
            FavoMovie.AddAtLast(FavoMovie.pop());// backup played movies
            FavoMovie.PrintAllMovie();//display the backup movies
            Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("the effeciency of Adding algorithms is:");
            //test.EffecientAddTest(int.MinValue);
            //Console.WriteLine("the effeciency of Searching algorithms is:");
            //test.EffecientSearchTest(int.MinValue);
            //Console.WriteLine("the effeciency of Deleting algorithms is:");
            //test.EffecientDeleteTest(int.MinValue);
            //Console.WriteLine("the effeciency of push algorithms is:");
            ///test.EffecientPushTest(int.MinValue);
            //Console.WriteLine("the effeciency of Pop algorithms is:");
            //test.EffecientPopTest(int.MinValue);
        }



    }



}





