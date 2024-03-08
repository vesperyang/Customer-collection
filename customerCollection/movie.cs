using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCollectionApp
{

    class FavoMovie
    {
        static int CAPACITY = 100000;
        private int capacity;
        private int numElements;
        private int[] data;


        /// constructor initializes stack
        public FavoMovie()
        {
            capacity = CAPACITY;
            numElements = 0;
            data = new int[CAPACITY];
            head = new storeMovie();
            current = head;

        }

        /// returns number of elements in the stack
        public int size()
        {
            return numElements;
        }

        /// return true if the stack is empty
        public bool empty()
        {
            return numElements == 0;
        }

        /// adds an element to the top of the stack
        public void push(int value)
        {
            if (numElements != capacity)
            {
                data[numElements] = value;
                numElements = numElements + 1;
            }
            else
            {
                Console.WriteLine("movie store is full - cannot add any more movies to storage");
            }
        }

        /// returns the element from the top of the stack and removes it
        public int pop()
        {
            int topValue = data[numElements - 1];
            numElements = numElements - 1;
            return topValue;
        }

        /// returns the element from the top of the stack
        public int peek()
        {
            return data[numElements - 1];
        }
        public class storeMovie
        {
            public storeMovie Next;
            public object Value;


        }
        private storeMovie head;
        private storeMovie current;//This will have latest node
        public int Count;
        public void AddAtLast(object value)
        {

            storeMovie newMovie = new storeMovie();
            newMovie.Value = pop();
            current.Next = newMovie;
            current = newMovie;
            Count++;
        }
        public void PrintAllMovie()
        {
            //Traverse from head
            Console.Write("Head ->");
            storeMovie curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }

    }
}






