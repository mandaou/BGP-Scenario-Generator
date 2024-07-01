using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace org.squ.md.gen.BusinessObjects
{
    public class Link
    {
        public int SourceASN { get; set; }
        public IPAddress SourceIP { get; set; }
        public int DestinationASN { get; set; }
        public IPAddress DestinationIP { get; set; }

        public Link(int sourceASN, IPAddress sourceIP, int destinationASN, IPAddress destinationIP) {
            SourceASN = sourceASN;
            SourceIP = sourceIP;
            DestinationASN = destinationASN;
            DestinationIP = destinationIP;
        }

        public Link flip()
        {
            return new Link(DestinationASN, DestinationIP, SourceASN, SourceIP);
        }
    }
}
