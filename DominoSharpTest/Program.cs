using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominoSharp;
namespace DominoSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string street;
            string city;
            string state;
            string zip;
            Console.WriteLine("Enter Address\n------");
            Console.WriteLine("Street: ");
            street = Console.ReadLine();
            Console.WriteLine("City: ");
            city = Console.ReadLine();
            Console.WriteLine("State: ");
            state = Console.ReadLine();
            Console.WriteLine("Zip: ");
            zip = Console.ReadLine();
            Address testAddr = new Address(street, city, state, zip, URLs.Country.USA, Order.deliveryMethod.Delivery);
            Console.WriteLine($"\n Address: {testAddr.ToString()}\n");

            string first;
            string last;
            string email;
            string phone;
            Console.WriteLine("Enter Info\n------");
            Console.WriteLine("First Name: ");
            first = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            last = Console.ReadLine();
            Console.WriteLine("Email: ");
            email = Console.ReadLine();
            Console.WriteLine("Phone: ");
            phone = Console.ReadLine();
            Customer me = new Customer(first, last, testAddr, email, phone);
            Console.WriteLine("\n Info: " + me.ToString() + "\n");
            Store pizzapalace = me.getNearestStore();
            Console.WriteLine("\n" + pizzapalace.ToString());
            Menu daMenu = pizzapalace.getMenu();
            Console.WriteLine(pizzapalace.data);
        //    Console.WriteLine(daMenu.products);
        }
    }
}
