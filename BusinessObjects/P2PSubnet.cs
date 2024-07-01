using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace org.squ.md.gen.BusinessObjects
{
    public class P2PSubnet
    {
        public IPAddress NetworkAddress { get; set; }
        public IPAddress FirstIpAddress { get; set; }
        public IPAddress SecondIpAddress { get; set; }
        public IPAddress BroadcastAddress { get; set; }

        public P2PSubnet() { 
        }

        public P2PSubnet(IPAddress networkAddress, IPAddress firstIpAddress, IPAddress secondIpAddress, IPAddress broadcastAddress)
        {
            NetworkAddress = networkAddress;
            FirstIpAddress = firstIpAddress;
            SecondIpAddress = secondIpAddress;
            BroadcastAddress = broadcastAddress;
        }
    }
}
