using System;

namespace GuestModel
{
    public class GuestModel0
    {
        public string fName { get; set; }

        public string lName { get; set; }

        public int partySize { get; set; }

        public string guestInfo
        {
            get
            {
                return string.Format($"{fName}, {lName}, {partySize}");
            }
        }

    }
}
