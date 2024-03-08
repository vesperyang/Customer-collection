using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCollectionApp
{
    class CustomerInfo
    {
        private Customer[] customers;
        private int noCustomers;

        public CustomerInfo()
        {
            customers = new Customer[10];
            noCustomers = 0;
        }
        public void Insert(string lastname, string firstname, int mobile, string payment, int screening)
        {
            Customer aCustomer = new Customer(lastname, firstname, mobile, payment, screening);
            customers[noCustomers] = aCustomer;
            noCustomers++;
        }

        public void Insert(Customer aCustomer)
        {
            customers[noCustomers] = aCustomer;
            noCustomers++;
        }

        public void Delete(string lastname, string firstname, int mobile, string payment, int screening)
        {
            Customer aCustomer = new Customer(lastname, firstname, 0, payment, screening);
            int i = 0;
            while ((i < noCustomers) && (customers[i].CompareTo(aCustomer) != 0))
                i++;
            if (i == noCustomers)
                Console.WriteLine("The customer does not exist!");
            else
            {
                for (int j = i + 1; j < noCustomers; j++)
                    customers[j - 1] = customers[j];
                noCustomers--;
            }
        }

        public void Display()
        {
            for (int i = 0; i < noCustomers; i++)
                Console.Write(customers[i]);
        }

        public void Sort()
        {
            //Selection sort
            int min;
            Customer temp;
            for (int i = 0; i <= (noCustomers - 2); i++)
            {
                min = i;
                for (int j = (i + 1); j <= (noCustomers - 1); j++)
                    if (customers[j].CompareTo(customers[min]) == -1)
                        min = j;
                //swap customers[i] and customers[min]
                temp = customers[i];
                customers[i] = customers[min];
                customers[min] = temp;
            }
        }

    }
}



