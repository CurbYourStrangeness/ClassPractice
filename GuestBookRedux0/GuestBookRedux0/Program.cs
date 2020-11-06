using System;
using System.Collections.Generic;
using GuestModel;

namespace GuestBookRedux0
{
    class Program
    {

        static void Main(string[] args)
        {
            List<GuestModel0> gList = new List<GuestModel0>();

            GuestInfoCollection(gList);

            printgList(gList);

        }

        public static string getfName()
        {
            Console.WriteLine("Please enter a first name: ");
            string fName = Console.ReadLine();

            string badRet = "";

            bool isValidfName = true;
            foreach (char s in fName)
            {
                if (!(Char.IsLetter(s)) && (s != ' '))
                {
                    Console.WriteLine("Please enter a name which is purely alphabetical.");
                    isValidfName = false;
                }
            }

            if (isValidfName)
            {
                return fName;
            }
            else
            {
                return badRet;
            }
        }

        public static string getlName()
        {
            Console.WriteLine("Please enter a last name: ");
            string lName = Console.ReadLine();

            string badRet = "";

            bool isValidlName = true;
            foreach (char s in lName)
            {
                if (!(Char.IsLetter(s)) && (s != ' '))
                {
                    Console.WriteLine("Please enter a name which is purely alphabetical.");
                    isValidlName = false;
                }
            }

            if (isValidlName)
            {
                return lName;
            }
            else
            {
                return badRet;
            }
        }

        public static int getpSize()
        {
            Console.WriteLine("Please enter your party size: ");
            string party = Console.ReadLine();

            bool isValidpSize = int.TryParse(party, out int partySize);

            if (isValidpSize)
            {
                return partySize;
            }
            else
            {
                return 0;
            }

        }

        private static void printgList(List<GuestModel0> gList)
        {
            foreach (GuestModel0 gParty in gList)
            {
                Console.WriteLine(gParty.guestInfo);
            }
        }

        private static List<GuestModel0> GuestInfoCollection(List<GuestModel0> gList)
        {
            string moreGuests = "";
            do
            {
                GuestModel0 guest = new GuestModel0();

                guest.fName = getfName();

                guest.lName = getlName();

                guest.partySize = getpSize();


                gList.Add(guest);

                Console.WriteLine("Do you have any more parties? ");
                moreGuests = Console.ReadLine();


            } while (moreGuests.ToLower() == "yes");

            return gList;
        }
    }
}
