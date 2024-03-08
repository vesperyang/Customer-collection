using System;
using System.Diagnostics;
using CustCollectionApp;

namespace _000000
{
    public class test
    {
        public test()
        {

        }
        public void EffecientSearchTest(int number)
        {
            CustomerCollection customer = new CustomerCollection();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 50; i++)
            {
                string lastname = i.ToString();
                customer.SearchElement(lastname);
            }

            sw.Stop();
            Console.WriteLine("ArrayList:\tMilliseconds = {0},\tTicks = {1}", sw.ElapsedMilliseconds, sw.ElapsedTicks);

        }
        public void EffecientAddTest(int number)
        {
            CustomerCollection customer = new CustomerCollection();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 10000; i++)
            {
                string lastname = i.ToString();
                customer.AddAtLast(lastname);
            }

            sw.Stop();
            Console.WriteLine("ArrayList:\tMilliseconds = {0},\tTicks = {1}", sw.ElapsedMilliseconds, sw.ElapsedTicks);
        }
        public void EffecientDeleteTest(int number)
        {
            CustomerCollection customer = new CustomerCollection();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 10000; i++)
            {
                string lastname = i.ToString();
                customer.RemoveFromStart();
            }

            sw.Stop();
            Console.WriteLine("ArrayList:\tMilliseconds = {0},\tTicks = {1}", sw.ElapsedMilliseconds, sw.ElapsedTicks);
        }
        public void EffecientPushTest(int number)
        {
            FavoMovie FavoMovie = new FavoMovie();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {

                FavoMovie.push(i);

            }

            sw.Stop();
            Console.WriteLine("ArrayList:\tMilliseconds = {0},\tTicks = {1}", sw.ElapsedMilliseconds, sw.ElapsedTicks);
        }
        public void EffecientPopTest(int number)
        {
            FavoMovie FavoMovie = new FavoMovie();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                FavoMovie.push(i);
                FavoMovie.pop();
            }

            sw.Stop();
            Console.WriteLine("ArrayList:\tMilliseconds = {0},\tTicks = {1}", sw.ElapsedMilliseconds, sw.ElapsedTicks);
        }

    }
}


