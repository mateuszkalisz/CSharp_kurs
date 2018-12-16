using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIndex
{
    class Customer
    {
        private List<Address> CustomerAddresses = new List<Address>();

        public Customer()
        {
            CustomerAddresses.Add(new Address { Pin = 123456, Street = "JP", City = "Elk" });
            CustomerAddresses.Add(new Address { Pin = 654321, Street = "Pelczynskiego", City = "Warsaw" });
            CustomerAddresses.Add(new Address { Pin = 123456, Street = "Okulickiego", City = "Tomaszów Lubelski" });
        }

        public Address GetAddresses(int Pin)
        {
            foreach (Address item in CustomerAddresses)
            {
                if (item.Pin == Pin)
                    return item;
            }
            return null;
        }

        public Address this[int Pin]
        {
            get
            {
                foreach (Address item in CustomerAddresses)
                {
                    if (item.Pin == Pin)
                        return item;
                }
                return null;
            }
        }
    }

    


    public class Address
    {
        public int Pin { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}
