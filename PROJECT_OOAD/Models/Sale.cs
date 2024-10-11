using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_OOAD.Models
{
    public class Sale
    {
        public int SID { get; set; }
        public int PID { get; set; }
        public int CID { get; set; }
        public string Quantity { get; set; }
        public string Amount { get; set; }

        public Sale(int sID, int pID, int cID, string quantity, string amount)
        {
            SID = sID;
            PID = pID;
            CID = cID;
            Quantity = quantity;
            Amount = amount;
        }
        public Sale() { }

    }
}