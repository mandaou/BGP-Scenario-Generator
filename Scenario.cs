using org.squ.md.gen.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace org.squ.md.gen
{
    class Scenario
    {
        public int TrialNumber { get; set; }
        public ScenarioType ScenarioType { get; set; }
        public int NumberOfNodes { get; set; }
        public string IpNetwork { get; set; }
        public int LinkDampingFactor { get; set; }
        public List<Node> Nodes;
        public P2PNetwork P2PNetwork { get; set; }
        public List<Link> Links;
        public Dictionary<IPAddress, IPAddress> IPLinks { get; set; }
        public ScenarioStatistics Statistics { get; set; }

        public TextBox ConsoleScreen;

        //public Scenario(TextBox consoleScreen, ScenarioType scenarioType, int trialNumber, int numberOfNodes, string ipNetwork, int linkDampingFactor)
        //{
        //    ConsoleScreen = consoleScreen;
        //    TrialNumber = trialNumber;
        //    ScenarioType = scenarioType;
        //    NumberOfNodes = numberOfNodes;
        //    IpNetwork = ipNetwork;
        //    LinkDampingFactor = linkDampingFactor;
        //    Nodes = new List<Node>();
        //    Links = new List<Link>();
        //    IPLinks = new Dictionary<IPAddress, IPAddress>();
        //    Make();
        //}

        public Scenario(AppUIControls appSettings, int lastTrial)
        {
            ConsoleScreen = appSettings.ConsoleScreen;
            TrialNumber = lastTrial;
            ScenarioType = appSettings.ScenarioType;
            IpNetwork = appSettings.SG_P2PIpNetwork.Text;
            IPLinks = new Dictionary<IPAddress, IPAddress>();
            P2PNetwork p2pNetwork = new P2PNetwork(IPAddress.Parse(IpNetwork));
            P2PNetwork = p2pNetwork;


            switch (ScenarioType)
            {
                case ScenarioType.Damped: case ScenarioType.Mesh:
                    NumberOfNodes = int.Parse(appSettings.SG_NumberOfNodes.Text);
                    LinkDampingFactor = int.Parse(appSettings.SG_LinkDampingFactor.Text);
                    Nodes = new List<Node>();
                    Links = new List<Link>();
                    Make();
                    break;
                case ScenarioType.Waxman:
                    //double lambda = double.Parse(appSettings.SG_WaxMan_Lambda.Text);
                    //double alpha = double.Parse(appSettings.SG_WaxMan_Alpha.Text);
                    //double beta = double.Parse(appSettings.SG_WaxMan_Beta.Text);
                    //double[] domain = new double[] { double.Parse(appSettings.SG_WaxMan_XMin.Text),
                    //    double.Parse(appSettings.SG_WaxMan_XMax.Text),
                    //    double.Parse(appSettings.SG_WaxMan_YMin.Text),
                    //    double.Parse(appSettings.SG_WaxMan_XMax.Text)};
                    Waxman waxman = new Waxman(appSettings);
                    NumberOfNodes = waxman.Nodes.Count;
                    Nodes = waxman.Nodes;
                    P2PNetwork = waxman.P2PNetwork;
                    Links = waxman.Links;
                    IPLinks = waxman.IPLinks;
                    Statistics = new ScenarioStatistics(this);
                    break;
                default:
                    break;
            }
           
        }

        internal void Make()
        {
            for (int i = 1; i <= NumberOfNodes; i++)
            {
                int asNumber = i;
                Nodes.Add(new Node(asNumber));
            }
            CreateLinks();
            Statistics = new ScenarioStatistics(this);
        }

        private void CreateLinks()
        {
            Random rnd = new Random();

            int p2pNetworkInUse = 0;
            double dfRemainder = (100d - LinkDampingFactor) / 100d;

            switch (ScenarioType)
            {
                case ScenarioType.Damped:
                    foreach (Node n in Nodes)
                    {                      
                        int maxConnectionsDamped = (int)Math.Floor((NumberOfNodes - 1) * dfRemainder);
                        if (maxConnectionsDamped == 0) { maxConnectionsDamped = 1; }
                        int numberOfLinksToGenerate = rnd.Next(1, maxConnectionsDamped);
                        List<Node> nodesToBeConnectedTo = Utils.ShuffleArrayAndReturn(Nodes, numberOfLinksToGenerate, n);
                        foreach (Node p in nodesToBeConnectedTo)
                        {
                            ConntectNodeToNode(n, p, p2pNetworkInUse);
                            p2pNetworkInUse++;
                        }
                    }
                    break;

                case ScenarioType.Mesh:
                    List<Node> srcNodes = Nodes;
                    List<Node> dstNodes = Nodes;
                    
                    foreach (Node n in srcNodes)
                    {
                        foreach (Node p in dstNodes)
                        {
                            if (n != p && !isConntected(n, p))
                            {
                                ConntectNodeToNode(n, p, p2pNetworkInUse);
                                p2pNetworkInUse++;
                            }
                        }
                    }

                    // Apply damping by removing DF % of links
                    if (LinkDampingFactor > 0)
                    {
                        int maximumNumberOfPossibleLinks = ((Nodes.Count) * (Nodes.Count - 1)) / 2;
                        double numberOfLinksToRemove = maximumNumberOfPossibleLinks * (LinkDampingFactor / 100d);
                        List<Link> linksToBeRemoved = Utils.ShuffleArrayAndReturn(Links, Convert.ToInt32(numberOfLinksToRemove));
                        ConsoleScreen.Text += "Removing: " + linksToBeRemoved.Count + " links of total of: " + maximumNumberOfPossibleLinks + Environment.NewLine;
                        int numberOfSkippedLinks = DeleteLinks(linksToBeRemoved);
                        while (numberOfSkippedLinks != 0)
                        {
                            ConsoleScreen.Text += "Compensate skipped links ..." + Environment.NewLine;
                            linksToBeRemoved = Utils.ShuffleArrayAndReturn(Links, Convert.ToInt32(numberOfSkippedLinks));
                            ConsoleScreen.Text += "Removing: " + linksToBeRemoved.Count + " links of total of: " + maximumNumberOfPossibleLinks + Environment.NewLine;
                            numberOfSkippedLinks = DeleteLinks(linksToBeRemoved);
                        }
                    }

                    break;
            }
        }

        private int DeleteLinks(List<Link> linksToBeRemoved)
        {
            // Note: Dont delete a link that will make a node disconnected or has one link only
            int numberOfSkippedLinks = 0;

            foreach (Link l in linksToBeRemoved)
            {
                Node srcNode = Nodes.Find(x => x.AsNumber == l.SourceASN);
                Node dstNode = Nodes.Find(x => x.AsNumber == l.DestinationASN);
                bool isLastTwoLinksForANode = (srcNode.Links.Count <= 2 || dstNode.Links.Count <= 2);
                ConsoleScreen.Text += "Trying to delete a link between " + srcNode.AsNumber + " (" + srcNode.Links.Count + ") and " + dstNode.AsNumber + "(" + dstNode.Links.Count + ") ... ";
                if (!isLastTwoLinksForANode)
                {
                    // Remove from IP Links
                    IPLinks.Remove(l.SourceIP);

                    // Delete from Links
                    Links.Remove(l);

                    // Update Nodes
                    srcNode.Peers.Remove(dstNode);
                    srcNode.Links.Remove(l);
                    dstNode.Peers.Remove(srcNode);
                    Link dstLink = dstNode.Links.Find(x => x.SourceASN == l.DestinationASN && x.DestinationASN == l.SourceASN);
                    dstNode.Links.Remove(dstLink);
                    ConsoleScreen.Text +=  "deleted" + Environment.NewLine;
                }
                else 
                {
                    ConsoleScreen.Text +=  "skipped" + Environment.NewLine;
                    numberOfSkippedLinks++;
                }
            }

            return numberOfSkippedLinks;
        }

        private void ConntectNodeToNode(Node n, Node p, int p2pNetworkInUse)
        {
            if (P2PNetwork.SubnetsFree <= 0) { P2PNetwork.Expand(); }
            Link l = new Link(n.AsNumber, P2PNetwork.Subnets[p2pNetworkInUse].FirstIpAddress, p.AsNumber, P2PNetwork.Subnets[p2pNetworkInUse].SecondIpAddress);
            Links.Add(l);
            IPLinks.Add(P2PNetwork.Subnets[p2pNetworkInUse].FirstIpAddress, P2PNetwork.Subnets[p2pNetworkInUse].SecondIpAddress);
            P2PNetwork.SubnetsFree--;
            P2PNetwork.SubnetsUsed++;
            n.Peers.Add(p);
            n.Links.Add(l);
            p.Peers.Add(n);
            p.Links.Add(l.flip());
        }

        private bool isConntected(Node srcNode, Node dstNode)
        {
            bool connected = Links.Exists(x => x.SourceASN == srcNode.AsNumber && x.DestinationASN == dstNode.AsNumber) || 
                Links.Exists(x => x.DestinationASN == srcNode.AsNumber && x.SourceASN == dstNode.AsNumber);
            return connected;
        }

        internal void ExportScenarioToFiles(string outputFolder)
        {
            // Export Nodes Configurations
            foreach (Node n in Nodes)
            {
                string fileName = "AS" + n.AsNumber + ".conf";
                string confFile = System.IO.Path.Combine(outputFolder, fileName);
                System.IO.File.WriteAllLines(confFile, n.ToQuaggaConf());
                XmlDocument doc = n.ToNbgpConf();
                string xmlFile = System.IO.Path.Combine(outputFolder, "AS" + n.AsNumber + ".xml");
                doc.Save(xmlFile);
            }

            // Export Nodes to CSV
            ExportNodesToCSV(outputFolder);

            ExportNodeCoordinatessToCSV(outputFolder);

            // Export IP Edges to CSV
            ExportIPEdgesToCSV(outputFolder);

            // Export Edges to CSV
            ExportEdgesToCSV(outputFolder);

            // Export Network to CSV
            ExportNetworkToCSV(outputFolder);

        }

        private void ExportNodesToCSV(string outputFolder)
        {
            string fileName = "nodes.csv";
            string csvFile = System.IO.Path.Combine(outputFolder, fileName);
            StringBuilder sb = new StringBuilder();

            foreach (Node n in Nodes)
            {
                sb.Append(n.AsNumber + "," );
                sb.Append(n.GetRouterId().ToString() + Environment.NewLine);
            }

            string[] content = sb.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            System.IO.File.WriteAllLines(csvFile, content);
        }

        private void ExportNodeCoordinatessToCSV(string outputFolder)
        {
            string fileName = "coordinates.csv";
            string csvFile = System.IO.Path.Combine(outputFolder, fileName);
            StringBuilder sb = new StringBuilder();

            foreach (Node n in Nodes)
            {
                if (ScenarioType == ScenarioType.Waxman)
                {
                    sb.Append(n.Coordinate.X + ",");
                    sb.Append(n.Coordinate.Y + Environment.NewLine);
                }
                else
                {
                    sb.Append("0.0, 0.0" + Environment.NewLine);
                }
            }

            string[] content = sb.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            System.IO.File.WriteAllLines(csvFile, content);
        }

        private void ExportIPEdgesToCSV(string outputFolder)
        {
            string fileName = "ipedges.csv";
            string csvFile = System.IO.Path.Combine(outputFolder, fileName);
            StringBuilder sb = new StringBuilder();

            foreach (var i in IPLinks)
            {
                sb.Append(i.Key.ToString() + ",");
                sb.Append(i.Value.ToString() + Environment.NewLine);
            }

            string[] content = sb.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            System.IO.File.WriteAllLines(csvFile, content);
        }

        internal void ExportEdgesToCSV(string outputFolder)
        {
            string fileName = "edges.csv";
            string csvFile = System.IO.Path.Combine(outputFolder, fileName);

            StringBuilder sb = new StringBuilder();
            //sb.Append("Speaker,Peer"+ Environment.NewLine);
            foreach (Link l in Links)
            {
                //sb.Append("AS" + l.SourceASN + ",AS" + l.DestinationASN + Environment.NewLine);
                sb.Append(l.SourceASN + "," + l.DestinationASN + Environment.NewLine);
            }
            string[] content = sb.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            System.IO.File.WriteAllLines(csvFile, content);
        }

        private void ExportNetworkToCSV(string outputFolder)
        {
            string fileName = "network.csv";
            string csvFile = System.IO.Path.Combine(outputFolder, fileName);
            StringBuilder sb = new StringBuilder();

            foreach (Link l in Links)
            {
                sb.Append(l.SourceASN + "," + l.DestinationASN + ",");
                sb.Append(l.SourceIP + "," + l.DestinationIP + Environment.NewLine);
            }

            string[] content = sb.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            System.IO.File.WriteAllLines(csvFile, content);
        }

        internal string[] GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            if (Statistics != null) 
            {
                sb.Append(Environment.NewLine + "==========" + Environment.NewLine);
                sb.Append("Statistics" + Environment.NewLine);
                sb.Append("==========" + Environment.NewLine);
                sb.Append("Scenario Type: " + Statistics.ScenarioType + Environment.NewLine);
                sb.Append("Total number of nodes: " + Statistics.NumberOfNodes + Environment.NewLine);
                sb.Append("Total number of links: " + Statistics.NumberOfLinks + Environment.NewLine);
                sb.Append(Environment.NewLine + "==========" + Environment.NewLine);
                sb.Append("Analysis" + Environment.NewLine);
                sb.Append("==========" + Environment.NewLine);
                sb.Append("Average number of links per peer: " + Statistics.AverageLinksPerPeer + Environment.NewLine);
                sb.Append("Potential network; maximum number of links: " + Statistics.MaxNumberOfLinks + Environment.NewLine);
                sb.Append("Network density: " + Statistics.Density + Environment.NewLine);
            }
            return sb.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
