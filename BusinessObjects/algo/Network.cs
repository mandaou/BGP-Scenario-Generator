using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace org.squ.md.gen.BusinessObjects
{
    public abstract class Network
    {
        public List<Node> Nodes = new List<Node>();
        public List<Link> Links = new List<Link>();
        public string IpNetwork { get; set; }
        public P2PNetwork P2PNetwork { get; set; }
        public Dictionary<IPAddress, IPAddress> IPLinks = new Dictionary<IPAddress, IPAddress>();
        public AppUIControls AppSettings { get; set; }


        public int GetNumberOfNodes()
        {
            return Nodes.Count;
        }

        public int GetNumberOfLinks()
        {
            return Links.Count;
        }
    }
}
