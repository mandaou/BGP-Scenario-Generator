using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace org.squ.md.gen.BusinessObjects
{
    public class AppUIControls
    {
        // Radio Buttons
        public RadioButton SG_NetworkType_Damped { get; set; }
        public RadioButton SG_NetworkType_Mesh { get; set; }
        public RadioButton SG_NetworkType_Waxman { get; set; }

        public ScenarioType ScenarioType { get; set; }

        // Text Boxes - Universal
        public TextBox SG_NumberOfNodes { get; set; }
        public TextBox SG_P2PIpNetwork { get; set; }
        public TextBox SG_LinkDampingFactor { get; set; }

        // Text Boxes - Waxman
        public TextBox SG_WaxMan_Lambda { get; set; }
        public TextBox SG_WaxMan_Alpha { get; set; }
        public TextBox SG_WaxMan_Beta { get; set; }
        public TextBox SG_WaxMan_XMin { get; set; }
        public TextBox SG_WaxMan_XMax { get; set; }
        public TextBox SG_WaxMan_YMin { get; set; }
        public TextBox SG_WaxMan_YMax { get; set; }
        

        // Console Screen
        public TextBox ConsoleScreen { get; set; }

        // Status bar
        public ToolStripStatusLabel Status { get; set; }
    }
}
