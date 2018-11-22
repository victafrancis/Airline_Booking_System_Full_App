using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAirlineProject
{
    class CustomerManager
    {
        private static int currentCustNo;
        private int maxCustomers;
        private int numCustomers;
        private Customer[] listCustomer;

        public CustomerManager(int seed, int maxCust)
        {
            currentCustNo = seed;
            maxCustomers = maxCust;
            numCustomers = 0;
            listCustomer = new Customer[maxCustomers];
        }

        public bool addCustomer(string fName, string lName, string phone)
        {
            if (numCustomers >= maxCustomers) return false;
            listCustomer[numCustomers] = new Customer(currentCustNo, fName, lName, phone);
            numCustomers++;
            currentCustNo++;
            return true;
        }

        private int findCustomer(int custId)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (listCustomer[i].getCustomerId() == custId)
                    return i;
            }
            return -1;
        }

        public bool customerExist(int custId)
        {
            if (findCustomer(custId) == -1) return false;
            return true;
        }

        public Customer getCustomer(int custId)
        {
            int loc = findCustomer(custId);
            return listCustomer[loc];
        }

        public bool deleteCustomer(int custId)
        {
            if (!customerExist(custId)) return false;
            int loc = findCustomer(custId);
            listCustomer[loc] = listCustomer[numCustomers - 1];
            numCustomers--;
            return true;
        }

        public string getCustomerList()
        {
            string output = "[ID] - [Name] - [Phone]\n";
            for (int i = 0; i < numCustomers; i++)
            {
                output += listCustomer[i].getCustomerId() + " - " + listCustomer[i].getFirstName() + " " +
                    listCustomer[i].getLastName() + " - " + listCustomer[i].getPhone() + "\n";
            }
            return output;
        }

    }
}
