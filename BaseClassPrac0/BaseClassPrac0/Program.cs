using System;
using System.Collections.Generic;

namespace BaseClassPrac0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<address> Addrs = new List<address>();

            List<Person> pers = new List<Person>();
            string fName = "";
           

            do
            {
                bool isValidfName = true;
                bool isValidlName = true;
                bool isValidstAddr = true;

                Person perso = new Person();

                address address = new address();

                Console.WriteLine("Please enter a first name, or 'exit' if you would care to abstain: ");
                fName = Console.ReadLine();

                foreach (char s in fName)
                {
                    if (!(Char.IsLetter(s)))
                    {
                        Console.WriteLine("Please enter a name which is purely alphabetical");
                        isValidfName = false;
                    }
                }

                if (isValidfName)
                {
                    perso.fName = fName;
                }

                Console.WriteLine("Please enter a last name");
                var lName = Console.ReadLine();

                foreach (char s in lName)
                {
                    if (!(Char.IsLetter(s)))
                    {
                        Console.WriteLine("Please enter a name which is purely alphabetical: ");
                        isValidlName = false;
                    }
                }

                if (isValidlName)
                {
                    perso.lName = lName;
                }

                Console.WriteLine("Please enter a street for your address: ");
                var stAddr = Console.ReadLine();

                foreach (char s in stAddr)
                {
                    if (!(Char.IsLetter(s)) && !(s.Equals(" ")))
                    {
                        Console.WriteLine("Please enter a street name which is purely alphabetical: ");
                        isValidstAddr = false;
                    }
                }

                if (isValidstAddr)
                {
                   address.street = stAddr;
                }


                Addrs.Add(address);

                pers.Add(perso);

            } while (fName.ToLower() != "exit");

            foreach(Person p in pers)
            {
                Console.WriteLine($"{p.fName} is the first name, and {p.lName} is the last name.");
            }

            foreach (address a in Addrs)
            {
                Console.WriteLine($"One street is {a.street}.");
            }
        }
    }
}
