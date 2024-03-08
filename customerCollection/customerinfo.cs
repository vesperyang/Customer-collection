using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCollectionApp
{
    class Customer
    {
        private string lastname, payment;
        private string firstname;
        private int mobile, screening;

        public string FirstName
        {
            get { return firstname; }
        }

        public string LastName
        {
            get { return lastname; }
        }

        public int Mobile
        {
            get { return mobile; }
        }
        public string Payment
        {
            get { return payment; }
        }
        public int Screening
        {
            get { return screening; }
        }

        public Customer(string lastName, string firstName, int mobileNumber, string payment, int screening)
        {
            this.lastname = lastName;
            this.firstname = firstName;
            this.mobile = mobileNumber;
            this.payment = payment;
            this.screening = screening;
        }

        public int CompareTo(Customer another)
        {
            if (this.lastname.CompareTo(another.LastName) < 0)
                return -1;
            else
                if (this.lastname.CompareTo(another.LastName) == 0)
                return this.firstname.CompareTo(another.FirstName);
            else
                return 1;
        }


        public override string ToString()
        {
            return ("name:" + firstname + " " + lastname + " number is" + mobile.ToString() + "payment: " + payment + "\n");
        }
    }
}




