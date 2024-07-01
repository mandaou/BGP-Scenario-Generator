using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace org.squ.md.gen.BusinessObjects
{
    public class P2PNetwork
    {
        public IPAddress NetworkAddress { get; set; }
        public List<P2PSubnet> Subnets { get; set; }
        public int NumberOfExpansions { get; set; }
        public int SubnetsTotal { get; set; }
        public int SubnetsUsed { get; set; }
        public int SubnetsFree { get; set; }

        public P2PNetwork(IPAddress networkAddress)
        {
            Subnets = new List<P2PSubnet>();
            SubnetsTotal = 0;
            SubnetsUsed = 0;
            SubnetsFree = 0;
            NumberOfExpansions = 0;

            NetworkAddress = networkAddress;

            Create(networkAddress);
        }

        private void Create(IPAddress networkAddress)
        {

            string[] ipArray = networkAddress.ToString().Split('.');
            int fourthOctet = int.Parse(ipArray[3]);

            while (fourthOctet < 255)
            {
                P2PSubnet subnet = new P2PSubnet();

                ipArray[3] = fourthOctet.ToString();
                string ip1 = string.Join('.', ipArray);
                subnet.NetworkAddress = IPAddress.Parse(ip1);

                ipArray[3] = (fourthOctet + 1).ToString();
                string ip2 = string.Join('.', ipArray);
                subnet.FirstIpAddress = IPAddress.Parse(ip2);

                ipArray[3] = (fourthOctet + 2).ToString();
                string ip3 = string.Join('.', ipArray);
                subnet.SecondIpAddress = IPAddress.Parse(ip3);

                ipArray[3] = (fourthOctet + 3).ToString();
                string ip4 = string.Join('.', ipArray);
                subnet.BroadcastAddress = IPAddress.Parse(ip4);

                Subnets.Add(subnet);
                SubnetsTotal++;
                SubnetsFree++;
                fourthOctet += 4;
            }
        }

        public void Expand()
        {
            string[] ipArray = NetworkAddress.ToString().Split('.');
            int thirdOctet = int.Parse(ipArray[2]);

            NumberOfExpansions++;
            thirdOctet += NumberOfExpansions;
            ipArray[2] = thirdOctet.ToString();


            string newNetwork = string.Join('.', ipArray);
            Create(IPAddress.Parse(newNetwork));
        }
    }
}