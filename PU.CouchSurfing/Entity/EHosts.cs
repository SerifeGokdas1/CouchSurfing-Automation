using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU.CouchSurfing.Entity
{
    public class EHosts
    {
        public int HostId { get; set; }
        public string HostNameSurname { get; set; }
        public int HostPhone { get; set; }
        public string HostMail { get; set; }
        public string HostAddress { get; set; }
        public string HostAcceptGuests { get; set; }
    }
}
