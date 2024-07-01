using org.squ.md.gen.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace org.squ.md.gen
{
    public partial class MainForm : Form
    {
        public AppUIControls appUIControls { get; set; }

        public MainForm()
        {
            InitializeComponent();
            LoadApplicationSettings();
            PopulateSettingsToGui();
            appUIControls = new AppUIControls();
            MapUIControlsToClass();
        }

        private void MapUIControlsToClass()
        {
            appUIControls.SG_NetworkType_Damped = btn_SG_NT_Damped;
            appUIControls.SG_NetworkType_Mesh = btn_SG_NT_Mesh;
            appUIControls.SG_NetworkType_Waxman = btn_SG_NT_Waxman;
            appUIControls.SG_NumberOfNodes = tb_SG_NodesNumber;
            appUIControls.SG_P2PIpNetwork = tb_SG_IPNetwork;
            appUIControls.SG_LinkDampingFactor = tb_SG_LinkDampingFactor;
            appUIControls.SG_WaxMan_Lambda = tb_SG_Wax_lambda;
            appUIControls.SG_WaxMan_Alpha = tb_SG_Wax_alpha;
            appUIControls.SG_WaxMan_Beta = tb_SG_Wax_beta;
            appUIControls.SG_WaxMan_XMin = tb_SG_Wax_xmin;
            appUIControls.SG_WaxMan_XMax = tb_SG_Wax_xmax;
            appUIControls.SG_WaxMan_YMin = tb_SG_Wax_ymin;
            appUIControls.SG_WaxMan_YMax = tb_SG_Wax_ymax;
            appUIControls.ConsoleScreen = tb_Console;
            appUIControls.Status = toolStripStatusLabel;
        }

        private void LoadApplicationSettings()
        {
            tbOutputFolder.Text = Properties.Settings.Default.OutputFolder;
            tb_SG_NodesNumber.Text = Properties.Settings.Default.NumberOfNodes.ToString();
            tb_SG_IPNetwork.Text = Properties.Settings.Default.IPNetwork;
            tb_SG_LinkDampingFactor.Text = Properties.Settings.Default.LinkDampingFactor.ToString();

            // Waxman
            tb_SG_Wax_lambda.Text = Properties.Settings.Default.WaxmanLambda.ToString();
            tb_SG_Wax_alpha.Text = Properties.Settings.Default.WaxmanAlpha.ToString();
            tb_SG_Wax_beta.Text = Properties.Settings.Default.WaxmanBeta.ToString();
            tb_SG_Wax_xmin.Text = Properties.Settings.Default.WaxmanXMin.ToString();
            tb_SG_Wax_xmax.Text = Properties.Settings.Default.WaxmanXMax.ToString();
            tb_SG_Wax_ymin.Text = Properties.Settings.Default.WaxmanYMin.ToString();
            tb_SG_Wax_ymax.Text = Properties.Settings.Default.WaxmanYMax.ToString();
        }

        private void PopulateSettingsToGui()
        {
            tbOutputFolder.Text = Properties.Settings.Default.OutputFolder;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadApplicationSettings();
            PopulateSettingsToGui();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = tbOutputFolder.Text;
            Properties.Settings.Default.NumberOfNodes = int.Parse(tb_SG_NodesNumber.Text);
            Properties.Settings.Default.IPNetwork = tb_SG_IPNetwork.Text;
            Properties.Settings.Default.LinkDampingFactor = int.Parse(tb_SG_LinkDampingFactor.Text);

            // Waxman
            Properties.Settings.Default.WaxmanLambda = double.Parse(tb_SG_Wax_lambda.Text);
            Properties.Settings.Default.WaxmanAlpha = double.Parse(tb_SG_Wax_alpha.Text);
            Properties.Settings.Default.WaxmanBeta = double.Parse(tb_SG_Wax_beta.Text);
            Properties.Settings.Default.WaxmanXMin = double.Parse(tb_SG_Wax_xmin.Text);
            Properties.Settings.Default.WaxmanXMax = double.Parse(tb_SG_Wax_xmax.Text);
            Properties.Settings.Default.WaxmanYMin = double.Parse(tb_SG_Wax_ymin.Text);
            Properties.Settings.Default.WaxmanYMax = double.Parse(tb_SG_Wax_ymax.Text);

            Properties.Settings.Default.Save();
        }

        private void btn_ScenarioGen_Click(object sender, EventArgs e)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = System.IO.Path.Combine(appData, "MDGen");
            Properties.Settings.Default.OutputFolder = tbOutputFolder.Text = appFolder;
             
            if (!System.IO.Directory.Exists(appFolder)) {
                System.IO.Directory.CreateDirectory(appFolder);
            }

            string scenarioTrialNumber = Properties.Settings.Default.lastTrial.ToString().PadLeft(5,'0');

            // Check which radio button is selected: Damped of Mesh
            var checkedButton = tlp_ScenarioGen.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            ScenarioType scenarioType = ScenarioType.Damped;
            switch (checkedButton.Text)
            {
                case "Damped":
                    scenarioType = ScenarioType.Damped;
                    appUIControls.ScenarioType = ScenarioType.Damped; 
                    break;
                case "Mesh":
                    scenarioType = ScenarioType.Mesh;
                    appUIControls.ScenarioType = ScenarioType.Mesh;
                    break;
                case "Waxman":
                    scenarioType = ScenarioType.Waxman;
                    appUIControls.ScenarioType = ScenarioType.Waxman;
                    break;
                default:
                    break;
            }

            Scenario scenario = new Scenario(appUIControls, Properties.Settings.Default.lastTrial);
            IEnumerable<string> scenarioSettings = ExportSettings(scenarioTrialNumber);
            string[] scenarioStatistics = scenario.GetStatistics();

            Properties.Settings.Default.lastTrial++;
            Properties.Settings.Default.Save();

            string scenarioFolder;
            if (scenarioType != ScenarioType.Waxman)
            {
                scenarioFolder = System.IO.Path.Combine(appFolder, DateTime.Now.ToString("yyyyMMdd") + "-" + scenarioTrialNumber + " - " + scenarioType + " - " + scenario.NumberOfNodes + " Nodes with DF " + Properties.Settings.Default.LinkDampingFactor);
            }
            else
            {
                scenarioFolder = System.IO.Path.Combine(appFolder, DateTime.Now.ToString("yyyyMMdd") + "-" + scenarioTrialNumber + " - " + scenarioType + " - " + scenario.NumberOfNodes + " Nodes");
            }
            
            if (!System.IO.Directory.Exists(scenarioFolder))
            {
                System.IO.Directory.CreateDirectory(scenarioFolder);
            }
              
            scenario.ExportScenarioToFiles(scenarioFolder);
            string readmeFile = System.IO.Path.Combine(scenarioFolder, "readme.txt");
            System.IO.File.WriteAllLines(readmeFile, scenarioSettings);
            System.IO.File.AppendAllLines(readmeFile, scenarioStatistics);

            Utils.runMatlabExport(scenarioFolder);

            Process.Start("explorer.exe", scenarioFolder);
        }

        private IEnumerable<string> ExportSettings(string scenarioTrialNumber)
        {
            string[] results = new string[7];
            results[0] = "Output Folder: " + Properties.Settings.Default.OutputFolder;
            results[1] = "Scenario Number: " + DateTime.Now.ToString("yyyyMMdd") + "-" + scenarioTrialNumber;
            results[2] = "Number of Nodes: " + Properties.Settings.Default.NumberOfNodes;
            results[3] = "Link Damping Factor: " + Properties.Settings.Default.LinkDampingFactor + "%";
            results[4] = "IP Network: " + Properties.Settings.Default.IPNetwork;
            results[5] = "Trial Number: " + (Properties.Settings.Default.lastTrial - 1).ToString();
            results[6] = Environment.NewLine;
            return results;
        }

        private void tb_SG_NodesNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool isNumeric = int.TryParse(textBox.Text, out _);
            if (textBox != null && textBox.Text.Length != 0)
            {
                if (isNumeric)
                {
                    btn_ScenarioGen.Enabled = true;
                    Properties.Settings.Default.NumberOfNodes = int.Parse(textBox.Text);
                    Properties.Settings.Default.Save();
                }
                else
                {
                    btn_ScenarioGen.Enabled = false;
                }
            }
            else
            {
                btn_ScenarioGen.Enabled = false;
            }
        }

        private void tb_SG_LinkDampingFactor_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool isNumeric = int.TryParse(textBox.Text, out _);
            if (textBox != null && textBox.Text.Length != 0)
            {
                if (isNumeric)
                {
                    btn_ScenarioGen.Enabled = true;
                    Properties.Settings.Default.LinkDampingFactor = int.Parse(textBox.Text);
                    Properties.Settings.Default.Save();
                }
                else
                {
                    btn_ScenarioGen.Enabled = false;
                }
            }
            else
            {
                btn_ScenarioGen.Enabled = false;
            }
        }
    }

    public enum ScenarioType : int
    {
        Damped = 1,
        Mesh = 2,
        Waxman = 3
    }
}
