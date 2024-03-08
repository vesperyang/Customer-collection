using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _000000;

namespace CustCollectionApp
{

    public class CustomerCollection
    {
        private Customer head;
        private Customer current;//This will have latest node
        public int Count;
        public CustomerCollection()
        {
            head = new Customer();
            current = head;
        }
        public void AddAtLast(string lastname)
        {

            Customer newCustomer = new Customer();
            newCustomer.Value = lastname;
            current.Next = newCustomer;
            current = newCustomer;
            Count++;
        }
        public void AddAtStart(object lastname)
        {
            Customer newNode = new Customer() { Value = lastname };
            newNode.Next = head.Next;//new node will have reference of head's next reference
            head.Next = newNode;//and now head will refer to new node
            Count++;
        }
        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
            }
        }
        /// <summary>
        /// Traverse from head and print all nodes value
        /// </summary>

        public void PrintAllCsutomer()
        {
            //Traverse from head
            Console.Write("Head ->");
            Customer curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
        public class Customer
        {
            public Customer Next;
            public object Value;

        }
        //Search an element in the list
        public bool SearchElement(string searchValue)
        {
            Customer temp = new Customer();
            temp = this.head;
            int found = 0;
            int i = 0;

            while (temp != null)
            {
                i++;
                if (temp.Value == searchValue)
                {
                    found++;
                    break;

                }
                temp = temp.Next;
            }
            if (found == 1)
            {

                Console.WriteLine(searchValue + " is found at index = " + i + ".");
                Console.WriteLine("Profile already exists.Book directly");
                return true;
            }
            else
            {
                Console.WriteLine(searchValue + " is not found in the list.");
                Console.WriteLine("Input information to book a ticket");
                return false;


            }

        }
        public void Screening(object screening)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("already watched" + i + "screenings");
            }
            Console.WriteLine("congratulaitions,you get a free ticket");

        }
    }

}





