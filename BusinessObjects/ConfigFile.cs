using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace org.squ.md.gen.BusinessObjects
{
    class ConfigFile
    {
        public int ASNumber { get; set; }
        public string ASName { get; set; }
        public IPAddress RouterId { get; set; }
        public List<Peer> Peers { get; set; }

        public ConfigFile(Node n)
        {
            ASNumber = n.AsNumber;
            ASName = "AS" + n.AsNumber;
            RouterId = n.GetRouterId();
            foreach (Link l in n.Links)
            {
                Peer peer = new Peer(l);
                Peers.Add(peer);
            }
        }
    }

    class Peer
    {
        public int ASNumber { get; set; }
        public string ASName { get; set; }

        public Peer(Link l)
        {
            ASNumber = l.DestinationASN;
            ASName = "AS" + l.DestinationASN;

        }
    }
}
