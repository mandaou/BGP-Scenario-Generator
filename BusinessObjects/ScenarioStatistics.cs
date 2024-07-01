using System;
using System.Collections.Generic;
using System.Text;

namespace org.squ.md.gen.BusinessObjects
{
    class ScenarioStatistics
    {
        private Scenario scenario;
        public ScenarioType ScenarioType { get; set; }
        public int NumberOfNodes { get; set; }
        public int NumberOfLinks { get; set; }
        public int MaxNumberOfLinks { get; set; }
        public double Density { get; set; }
        public double AverageLinksPerPeer { get; set; }

        public ScenarioStatistics(Scenario scenario)
        {
            this.scenario = scenario;
            ScenarioType = scenario.ScenarioType;
            SetNodes();
            SetLinks();
            CalculateMaxLinks();
            CalculateDensity();
            CalculateAverageLinksPerNode();
        }

        private void SetNodes()
        {
            NumberOfNodes = scenario.Nodes.Count;
        }

        private void SetLinks()
        {
            NumberOfLinks = scenario.Links.Count;
        }

        private void CalculateMaxLinks()
        {
            MaxNumberOfLinks = NumberOfNodes * (NumberOfNodes - 1) / 2;
        }

        private void CalculateDensity()
        {
            Density = (NumberOfLinks * 1d) / ( MaxNumberOfLinks * 1d);
        }

        private void CalculateAverageLinksPerNode()
        {
            int totalLinks = 0;
            foreach (Node n in scenario.Nodes)
            {
                totalLinks += n.Peers.Count;
            }
            AverageLinksPerPeer = totalLinks / scenario.Nodes.Count;
        }
    }
}
