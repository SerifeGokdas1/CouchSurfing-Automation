using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU.CouchSurfing.Entity
{
    public class EGuests
    {
        public int GuestId { get; set; }
        public int HostId { get; set; }
        public string GuestNameSurname { get; set; }
        public int GuestPhone { get; set; }
        public string GuestMail { get; set; }
        public string GuestAddress { get; set; }
        public string GuestGoTo { get; set; }
    }
}
