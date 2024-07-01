using org.squ.md.gen.BusinessObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace org.squ.md.gen
{
    class Utils
    {

        public static List<Node> ShuffleArrayAndReturn(List<Node> nodes, int numberOfReturnedEelements, Node nodeToExclude)
        {
            List<Node> results = new List<Node>();
            
            // Remove calling node from the selection
            nodes = nodes.Where(val => val != nodeToExclude).ToList();

            // Remove all already connected nodes
            foreach (Node n in nodeToExclude.Peers)
            {
                nodes = nodes.Where(val => val != n).ToList();
            }

            //int returnMinimum = Math.Min(numberOfReturnedEelements, nodes.Count);

            // Reduce it more
            // int returnMinimum = Math.Min(numberOfReturnedEelements, nodes.Count - nodeToExclude.Peers.Count);

            // Reduce even more
            int returnMinimum = Math.Min(numberOfReturnedEelements, nodes.Count - nodeToExclude.Peers.Count) / 2;

            // We don't want zero nodes
            returnMinimum = Math.Max(returnMinimum, 1);

            IEnumerable<Node> shuffled = nodes.OrderBy(n => Guid.NewGuid()).Take(returnMinimum);
            results = shuffled.ToList();
            return results;
        }


        public static List<Link> ShuffleArrayAndReturn(List<Link> links, int numberOfReturnedEelements)
        {
            List<Link> results = new List<Link>();
            IEnumerable<Link> shuffled = links.OrderBy(n => Guid.NewGuid()).Take(numberOfReturnedEelements);
            results = shuffled.ToList();
            return results;
        }


        public static void runMatlabExport(string scenarioFolder)
        {
            string srcMPath = Path.Combine(scenarioFolder, "..\\netplot.m");
            string dstMPath = Path.Combine(scenarioFolder, "netplot.m");
            File.Copy(srcMPath, dstMPath);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "matlab.exe";
            string args = "-nosplash -automation -nodesktop -r \"cd('" + scenarioFolder+"');netplot;exit\"";
            startInfo.Arguments = args;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
