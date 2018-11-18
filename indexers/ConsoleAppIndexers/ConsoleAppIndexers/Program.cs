using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIndexers
{
    /// <summary>
    /// Klasa pomocniczna
    /// </summary>
    /// 

        public class Customers
    {
        private List<Address> Addresses = new List<Address>();
        public Customers()
        {
            Addresses.Add(new Address { Pin = 123456, Street = "Marszalkowska", City = "Warszawa", Country = "Polska" });
            Addresses.Add(new Address { Pin = 654321, Street = "Mariampolska", City = "Ełk", Country = "Polska" });
            Addresses.Add(new Address { Pin = 135790, Street = "Okulickiego", City = "Tomaszów Lubelski", Country = "Polska" });
        
        }

        public Address GetAddress(int Pin)
        {
            foreach (Address item in Addresses)
            {
                if (item.Pin == Pin)
                    return item;
            }
            return null;
        }

        public Address GetAddress(string City)
        {
            foreach (Address item in Addresses)
            {
                if (item.City.Equals(City))
                    return item;
            }

            return null;
        }

        public Address this[int Pin] // stworzenie indexera
        {
            get
            {
                foreach (Address item in Addresses)
                {
                    if (item.Pin == Pin)
                        return item;
                }
                return null;
            }
        }

        public Address this[string City]
        {
            get
            { 

            foreach (Address item in Addresses)
            {
                if (item.City.Equals(City))
                    return item;
            }
            return null;
            }

        } // stworzenie indexera
    }

    /// <summary>
    /// Address class
    /// </summary>
    /// 
    public class Address
    {
        public int Pin { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Customers Customer = new Customers();
            Customer.GetAddress(123456);
            Customer.GetAddress("Ełk");

            var a = Customer[123456];
            var b = Customer["Ełk"];

            List<string> x = new List<string>();
            x.Add("xdxd");
            var c = x[0];
        }
    }
}
