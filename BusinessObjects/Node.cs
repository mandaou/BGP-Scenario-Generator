using org.squ.md.gen.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace org.squ.md.gen.BusinessObjects
{

    public class Node
    {
        public int AsNumber { get; set; }
        public Coordinate Coordinate { get; set; }
        public List<Node> Peers { get; set; }
        public List<Link> Links { get; set; }

        public Dictionary<Node, double> DistanceToNodes { get; set; }

        public Node(int asNumber)
        {
            AsNumber = asNumber;
            Peers = new List<Node>();
            Links = new List<Link>();
            DistanceToNodes = new Dictionary<Node, double>();
        }


        public IPAddress GetRouterId()
        {
            List<IPAddress> myIPs = new List<IPAddress>();
            foreach (Link l in Links)
            {
                myIPs.Add(l.SourceIP);
            }

            return myIPs.Count > 0 ? myIPs.First() : IPAddress.Parse("255.255.255.255") ;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("router bgp " + AsNumber);
            return sb.ToString();
        }

        public string[] ToQuaggaConf()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("hostname router" + AsNumber + Environment.NewLine);
            sb.Append("!" + Environment.NewLine);
            sb.Append("router bgp " + AsNumber + Environment.NewLine);
            sb.Append(" bgp router-id " + GetRouterId() + Environment.NewLine);

            // Dirty fix, ToDo: create a textbox and grow networks correctly
            if (AsNumber <= 0 || AsNumber >= 256) { throw new OverflowException("Number of Nodes should not be less than 1 or more than 255"); }

            sb.Append(" network 10.0." + AsNumber + ".0/24" + Environment.NewLine);
            foreach (Link l in Links)
            {
                sb.Append(" neighbor " + l.DestinationIP + " remote-as " + l.DestinationASN + Environment.NewLine);
                sb.Append(" neighbor " + l.DestinationIP + " update-source " + l.SourceIP + Environment.NewLine);
                sb.Append(" neighbor " + l.DestinationIP + " soft-reconfiguration inbound" + Environment.NewLine);
            }
            sb.Append("!" + Environment.NewLine);
            return sb.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        public XmlDocument ToNbgpConf()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            #region Config
            XmlNode rootNode = doc.CreateElement("Config");
            doc.AppendChild(rootNode);

            #region Controller
            XmlNode controllerNode = doc.CreateElement("Controller");

            XmlAttribute asNumber = doc.CreateAttribute("ASNumber");
            asNumber.Value = AsNumber.ToString();
            controllerNode.Attributes.Append(asNumber);

            XmlAttribute asName = doc.CreateAttribute("ASName");
            asName.Value = "AS" + AsNumber;
            controllerNode.Attributes.Append(asName);

            XmlAttribute routerId = doc.CreateAttribute("RouterId");
            routerId.Value = GetRouterId().ToString();
            controllerNode.Attributes.Append(routerId);

            XmlAttribute holdTime = doc.CreateAttribute("HoldTime");
            holdTime.Value = 120.ToString();
            controllerNode.Attributes.Append(holdTime);

            XmlAttribute state = doc.CreateAttribute("State");
            state.Value = "BgpCfg.State.IP_AS_Configured";
            controllerNode.Attributes.Append(state);

            XmlAttribute nDNCapability = doc.CreateAttribute("NDNCapability");
            nDNCapability.Value = "True";
            controllerNode.Attributes.Append(nDNCapability);

            XmlAttribute advertisementTime = doc.CreateAttribute("AdvertisementTime");
            advertisementTime.Value = 3.ToString();
            controllerNode.Attributes.Append(advertisementTime);

            #region ProtocolsRedistribution
            XmlNode protocolsRedistributionNode = doc.CreateElement("ProtocolsRedistribution");
            XmlNode protocol = doc.CreateElement("Protocol");
            XmlAttribute protocolNumber = doc.CreateAttribute("ProtocolNumber");
            protocolNumber.Value = 65.ToString();
            protocol.Attributes.Append(protocolNumber);
            XmlAttribute protocolName = doc.CreateAttribute("ProtocolName");
            protocolName.Value = "client";
            protocol.Attributes.Append(protocolName);
            protocolsRedistributionNode.AppendChild(protocol);

            protocol = doc.CreateElement("Protocol");
            protocolNumber = doc.CreateAttribute("ProtocolNumber");
            protocolNumber.Value = 128.ToString();
            protocol.Attributes.Append(protocolNumber);
            protocolName = doc.CreateAttribute("ProtocolName");
            protocolName.Value = "NLSR";
            protocol.Attributes.Append(protocolName);
            protocolsRedistributionNode.AppendChild(protocol);

            protocol = doc.CreateElement("Protocol");
            protocolNumber = doc.CreateAttribute("ProtocolNumber");
            protocolNumber.Value = 255.ToString();
            protocol.Attributes.Append(protocolNumber);
            protocolName = doc.CreateAttribute("ProtocolName");
            protocolName.Value = "static";
            protocol.Attributes.Append(protocolName);
            protocolsRedistributionNode.AppendChild(protocol);

            controllerNode.AppendChild(protocolsRedistributionNode);
            #endregion ProtocolsRedistribution

            #region Networks
            XmlNode networksNode = doc.CreateElement("Networks");
            XmlNode network = doc.CreateElement("Network");
            XmlAttribute netName = doc.CreateAttribute("Name");
            netName.Value = "/AS" + AsNumber;
            network.Attributes.Append(netName);
            networksNode.AppendChild(network);
            controllerNode.AppendChild(networksNode);
            #endregion Networks

            #region Peers
            XmlNode peersNode = doc.CreateElement("Peers");
            foreach (Link l in Links)
            {
                XmlNode peer = doc.CreateElement("Peer");

                XmlAttribute att1 = doc.CreateAttribute("ASNumber");
                att1.Value = l.DestinationASN.ToString();
                peer.Attributes.Append(att1);

                XmlAttribute att2 = doc.CreateAttribute("ASName");
                att2.Value = "AS" + l.DestinationASN;
                peer.Attributes.Append(att2);

                XmlAttribute att3 = doc.CreateAttribute("IPAddress");
                att3.Value = l.DestinationIP.ToString();
                peer.Attributes.Append(att3);

                peersNode.AppendChild(peer);
            }
            controllerNode.AppendChild(peersNode);
            #endregion Peers

            rootNode.AppendChild(controllerNode);
            #endregion Controller

            #endregion Config

            return doc;
        }

        public double GetDistanceToPeer(Node n)
        {
            double distance;
            distance = DistanceToNodes[n];
            return distance;
        }

        public void AddPeer(Node n)
        {
            Peers.Add(n);
            DistanceToNodes.Add(n, Coordinate.DistanceTo(n.Coordinate));
        }

        public void RecalculatePeerDistances()
        {
            DistanceToNodes.Clear();
            foreach (Node n in Peers)
            {
                DistanceToNodes.Add(n, Coordinate.DistanceTo(n.Coordinate));
            }
        }

        public bool HasPeer(Node n)
        {
            return Peers.Contains(n);
        }

        public bool IsLinkedToPeer(Node n)
        {
            bool rightDirection = Links.Exists(l => l.SourceASN.Equals(AsNumber) && l.DestinationASN.Equals(n.AsNumber));
            bool leftDirection = Links.Exists(l => l.DestinationASN.Equals(AsNumber) && l.SourceASN.Equals(n.AsNumber));
            return rightDirection || leftDirection;
        }
    }
}
