using System;
namespace CustCollectionApp
{
    public class ChooseSeat
    {
        static int CAPACITY = 5;
        private int capacity;
        private int numElements;
        private int[] data;
        public ChooseSeat()
        {
            capacity = CAPACITY;
            numElements = 0;
            data = new int[CAPACITY];
        }

        public bool empty()
        {
            return numElements == 0;
        }

        public void pickSeat(int value)
        {
            if (numElements != capacity)
            {
                data[numElements] = value;
                numElements = numElements + 1;
                Console.WriteLine("ticket is booked successfully");
            }
            else
            {
                Console.WriteLine("Seat is full - come back next time");
            }
        }

    }
}


