using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace org.squ.md.gen.BusinessObjects
{
    class NetworkGraph
    {

        public List<Node> Nodes { get; }
        public List<Link> Links { get; }

        private DataSet ds { get; set; }
        private int?[,] AdjacencyMatrix { get; set; }

        public NetworkGraph(List<Node> nodes, List<Link> links)
        {
            Nodes = nodes;
            Links = links;
            ds = new DataSet();
            Build();
        }

        private void Build()
        {
            PopulateVertices(ds);
            PolulateEdges(ds);
            CreateAdjMatrix();
        }

        private void PopulateVertices(DataSet dataSet)
        {
            DataTable dt = new DataTable("Vertices");

            // Add cloumns
            DataColumn idColumn = new DataColumn();
            idColumn.DataType = System.Type.GetType("System.Int32");
            idColumn.ColumnName = "id";
            dt.Columns.Add(idColumn);

            DataColumn nameColumn = new DataColumn();
            nameColumn.DataType = System.Type.GetType("System.Int32");
            nameColumn.ColumnName = "Name";
            dt.Columns.Add(nameColumn);

            int i = 0;
            foreach (Node n in Nodes)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = ++i;
                dr["Name"] = n.AsNumber;
                dt.Rows.Add(dr);
            }

            dataSet.Tables.Add(dt);
        }

        private void PolulateEdges(DataSet dataSet)
        {
            DataTable dt = new DataTable("Edges");

            // Add cloumns
            DataColumn srcColumn = new DataColumn();
            srcColumn.DataType = System.Type.GetType("System.Int32");
            srcColumn.ColumnName = "Source";
            dt.Columns.Add(srcColumn);

            DataColumn dstColumn = new DataColumn();
            dstColumn.DataType = System.Type.GetType("System.Int32");
            dstColumn.ColumnName = "Destination";
            dt.Columns.Add(dstColumn);

            foreach (Link l in Links)
            {
                DataRow dr = dt.NewRow();
                dr["Source"] = l.SourceASN;
                dr["Destination"] = l.DestinationASN ;
                dt.Rows.Add(dr);
            }

            dataSet.Tables.Add(dt);
        }

        private void CreateAdjMatrix()
        {
            AdjacencyMatrix = new int?[Nodes.Count, Nodes.Count];

            // Zero the matrix
            for (int i = 0; i < Nodes.Count; i++)
            {
                for (int j = 0; j < Nodes.Count; j++)
                {
                    int srcNode = Nodes[i].AsNumber;
                    int dstNode = Nodes[j].AsNumber;
                    bool isConntected = Links.Exists(x => x.SourceASN == srcNode && x.DestinationASN == dstNode);
                    AdjacencyMatrix[i, j] = isConntected ? 1 : 0;
                }
            }

            // Populate the matrix

        }

        public DataTable GetVertices()
        {
            return this.ds.Tables["Vertices"];
        }

        public DataTable GetEdges()
        {
            return this.ds.Tables["Edges"];
        }

        public int?[,] GetAdjacencyMatrix()
        {
            return this.AdjacencyMatrix;
        }
    }
}
