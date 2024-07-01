using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

using MathNet.Numerics.Distributions;

namespace org.squ.md.gen.BusinessObjects
{
    public class Waxman : Network
    {
        //public List<Node> Nodes = new List<Node>();
        //public List<Link> Links = new List<Link>();
        //public string IpNetwork { get; set; }
        //public P2PNetwork P2PNetwork { get; set; }
        //public Dictionary<IPAddress, IPAddress> IPLinks { get; set; }

        public double lambda { get; set; }             // intensity of the Poisson process
        public double alpha { get; set; }              // parameter for the link probability
        public double beta { get; set; }               // parameter for the link probability
        public double[] domain { get; set; }           // bounds for the "geografical" domain

        // Domain
        public double xmin { get; set; }
        public double xmax { get; set; }
        public double ymin { get; set; }
        public double ymax { get; set; }

        //
        int npoints;
        public Dictionary<int, Coordinate> NodesCoordinates = new Dictionary<int, Coordinate>();
        public double[,] Distances;

        public Waxman(AppUIControls appSettings)
        {
            AppSettings = appSettings;

            SetupWaxman(double.Parse(appSettings.SG_WaxMan_Lambda.Text), 
                double.Parse(appSettings.SG_WaxMan_Alpha.Text), 
                double.Parse(appSettings.SG_WaxMan_Beta.Text), 
                new double[] { double.Parse(appSettings.SG_WaxMan_XMin.Text),
                    double.Parse(appSettings.SG_WaxMan_XMax.Text),
                    double.Parse(appSettings.SG_WaxMan_YMin.Text),
                    double.Parse(appSettings.SG_WaxMan_YMax.Text) },
                appSettings.SG_P2PIpNetwork.Text);
        }

        public Waxman(double l, double a, double b, double[] d, String ipNetwork)
        {
            SetupWaxman(l, a, b, d, ipNetwork);
        }

        public Waxman(double l, double a, double b, double xmin, double xmax, double ymin, double ymax, String ipNetwork)
        {
            SetupWaxman(l, a, b, new double[] { xmin, xmax, ymin, ymax }, ipNetwork);
        }

        public void SetupWaxman(double l, double a, double b, double[] d, String ipNetwork)
        {
            // Waxman initialization
            this.lambda = l;
            this.alpha = a;
            this.beta = b;
            this.domain = d;

            this.xmin = d[0];
            this.xmax = d[1];
            this.ymin = d[2];
            this.ymax = d[3];

            this.domain = new double[] { xmin, xmax, ymin, ymax };

            // IP Network initialization
            this.IpNetwork = ipNetwork;
            P2PNetwork = new P2PNetwork(IPAddress.Parse(IpNetwork));

            RunWaxman();
        }

        private void RunWaxman()
        {
            // number of points is Poisson distributed with intensity proportional to the area
            double area = (xmax - xmin) * (ymax - ymin);
            Poisson poisson = new Poisson(lambda);
            Random random = poisson.RandomSource;
            npoints = (int)Math.Round(area * random.NextDouble());

            // Create nodes with coordinates
            for (int n = 1; n <= npoints; n++)
            {
                Node node = new Node(n);

                Random rnd = new Random();
                Coordinate coor = new Coordinate(rnd.NextDouble() * (xmax - xmin) + xmin, rnd.NextDouble() * (ymax - ymin) + ymin);
                node.Coordinate = coor;

                Nodes.Add(node);
                NodesCoordinates.Add(n, coor);
            }

            // Recalculate Node distances to other nodes
            foreach (Node n in Nodes)
            {
                n.RecalculatePeerDistances();
            }

            // Calculate Distances
            Distances = new double[npoints, npoints];
            for (int i = 1; i <= npoints; i++)
            {
                Coordinate firstNodeCoordinates = NodesCoordinates[i];
                for (int j = 1; j <= npoints; j++)
                {
                    Coordinate secondNodeCoordinates = NodesCoordinates[j];
                    Distances[i - 1, j - 1] = distance(firstNodeCoordinates, secondNodeCoordinates);
                }
            }

            // max distance = diagonal
            double L = Math.Sqrt(Math.Pow((xmax - xmin), 2) + Math.Pow((ymax - ymin), 2));

            // Create Links
            Random rnd2 = new Random();

            int p2pNetworkInUse = 0;

            foreach (Node v in Nodes)
            {
                foreach (Node k in Nodes)
                {
                    if (v == k)
                    {
                        continue;
                    }

                    double d = v.Coordinate.DistanceTo(k.Coordinate);
                    double p = rnd2.NextDouble();
                    double p_waxman = alpha * Math.Exp(-d / (beta * L));

                    if (p < p_waxman)
                    {
                        if (!v.IsLinkedToPeer(k))
                        {
                            ConntectNodeToNode(v, k, p2pNetworkInUse);
                            p2pNetworkInUse++;
                        }
                    }

                }
                v.RecalculatePeerDistances();
            }
            var bleh = Nodes;
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

        private double distance(Coordinate firstNodeCoordinates, Coordinate secondNodeCoordinates)
        {
            return Math.Sqrt(Math.Pow((secondNodeCoordinates.Y - firstNodeCoordinates.Y), 2) + Math.Pow((secondNodeCoordinates.X - firstNodeCoordinates.X), 2));
        }

        public void Print()
        {
            Console.WriteLine("Waxman Network Topology Details:");
            Console.WriteLine("================================");
            Console.WriteLine("Lamdpa: " + lambda + ", alpha: " + alpha + ", beta: " + beta + ", domain: [ " + xmin + " " + xmax + " " + ymin + " " + ymax + " ]");
            Console.WriteLine("Number of Points: " + npoints);
            foreach (var entry in NodesCoordinates)
            {
                Console.WriteLine("\t Node: " + entry.Key + "\t " + entry.Value.X + ",\t " + entry.Value.Y);
            }
        }
    }
}
