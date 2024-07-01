
namespace org.squ.md.gen
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageScenarioGen = new System.Windows.Forms.TabPage();
            this.tlp_ScenarioGen = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_SG_NetworkType = new System.Windows.Forms.Label();
            this.lbl_SG_NodesNumber = new System.Windows.Forms.Label();
            this.lbl_SG_IPNetwork = new System.Windows.Forms.Label();
            this.tb_SG_NodesNumber = new System.Windows.Forms.TextBox();
            this.tb_SG_IPNetwork = new System.Windows.Forms.TextBox();
            this.btn_ScenarioGen = new System.Windows.Forms.Button();
            this.lbl_SG_LinkDampingFactor = new System.Windows.Forms.Label();
            this.tb_SG_LinkDampingFactor = new System.Windows.Forms.TextBox();
            this.btn_SG_NT_Damped = new System.Windows.Forms.RadioButton();
            this.btn_SG_NT_Mesh = new System.Windows.Forms.RadioButton();
            this.btn_SG_NT_Waxman = new System.Windows.Forms.RadioButton();
            this.lbl_SG_Wax_lambda = new System.Windows.Forms.Label();
            this.lbl_SG_Wax_alpha = new System.Windows.Forms.Label();
            this.lbl_SG_Wax_beta = new System.Windows.Forms.Label();
            this.tb_SG_Wax_lambda = new System.Windows.Forms.TextBox();
            this.tb_SG_Wax_alpha = new System.Windows.Forms.TextBox();
            this.tb_SG_Wax_beta = new System.Windows.Forms.TextBox();
            this.lbl_SG_Wax_xmin = new System.Windows.Forms.Label();
            this.lbl_SG_Wax_xmax = new System.Windows.Forms.Label();
            this.lbl_SG_Wax_ymin = new System.Windows.Forms.Label();
            this.lbl_SG_Wax_ymax = new System.Windows.Forms.Label();
            this.tb_SG_Wax_xmin = new System.Windows.Forms.TextBox();
            this.tb_SG_Wax_xmax = new System.Windows.Forms.TextBox();
            this.tb_SG_Wax_ymin = new System.Windows.Forms.TextBox();
            this.tb_SG_Wax_ymax = new System.Windows.Forms.TextBox();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.tlp_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.tbOutputFolder = new System.Windows.Forms.TextBox();
            this.tabPageConsole = new System.Windows.Forms.TabPage();
            this.tb_Console = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageScenarioGen.SuspendLayout();
            this.tlp_ScenarioGen.SuspendLayout();
            this.pageSettings.SuspendLayout();
            this.tlp_Settings.SuspendLayout();
            this.tabPageConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 422);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(1054, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel.Text = "Idle";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageScenarioGen);
            this.tabControl1.Controls.Add(this.pageSettings);
            this.tabControl1.Controls.Add(this.tabPageConsole);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 398);
            this.tabControl1.TabIndex = 3;
            // 
            // pageScenarioGen
            // 
            this.pageScenarioGen.Controls.Add(this.tlp_ScenarioGen);
            this.pageScenarioGen.Location = new System.Drawing.Point(4, 24);
            this.pageScenarioGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageScenarioGen.Name = "pageScenarioGen";
            this.pageScenarioGen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageScenarioGen.Size = new System.Drawing.Size(1046, 370);
            this.pageScenarioGen.TabIndex = 0;
            this.pageScenarioGen.Text = "Scenario Generator";
            this.pageScenarioGen.UseVisualStyleBackColor = true;
            // 
            // tlp_ScenarioGen
            // 
            this.tlp_ScenarioGen.ColumnCount = 6;
            this.tlp_ScenarioGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlp_ScenarioGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScenarioGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlp_ScenarioGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScenarioGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_ScenarioGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_NetworkType, 0, 0);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_NodesNumber, 0, 1);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_IPNetwork, 0, 2);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_NodesNumber, 1, 1);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_IPNetwork, 1, 2);
            this.tlp_ScenarioGen.Controls.Add(this.btn_ScenarioGen, 5, 0);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_LinkDampingFactor, 0, 3);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_LinkDampingFactor, 1, 3);
            this.tlp_ScenarioGen.Controls.Add(this.btn_SG_NT_Damped, 1, 0);
            this.tlp_ScenarioGen.Controls.Add(this.btn_SG_NT_Mesh, 2, 0);
            this.tlp_ScenarioGen.Controls.Add(this.btn_SG_NT_Waxman, 3, 0);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_Wax_lambda, 2, 1);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_Wax_alpha, 2, 2);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_Wax_beta, 2, 3);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_Wax_lambda, 3, 1);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_Wax_alpha, 3, 2);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_Wax_beta, 3, 3);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_Wax_xmin, 2, 4);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_Wax_xmax, 2, 5);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_Wax_ymin, 2, 6);
            this.tlp_ScenarioGen.Controls.Add(this.lbl_SG_Wax_ymax, 2, 7);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_Wax_xmin, 3, 4);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_Wax_xmax, 3, 5);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_Wax_ymin, 3, 6);
            this.tlp_ScenarioGen.Controls.Add(this.tb_SG_Wax_ymax, 3, 7);
            this.tlp_ScenarioGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ScenarioGen.Location = new System.Drawing.Point(3, 2);
            this.tlp_ScenarioGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_ScenarioGen.Name = "tlp_ScenarioGen";
            this.tlp_ScenarioGen.RowCount = 9;
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ScenarioGen.Size = new System.Drawing.Size(1040, 366);
            this.tlp_ScenarioGen.TabIndex = 0;
            // 
            // lbl_SG_NetworkType
            // 
            this.lbl_SG_NetworkType.AutoSize = true;
            this.lbl_SG_NetworkType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_NetworkType.Location = new System.Drawing.Point(3, 0);
            this.lbl_SG_NetworkType.Name = "lbl_SG_NetworkType";
            this.lbl_SG_NetworkType.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_NetworkType.TabIndex = 1;
            this.lbl_SG_NetworkType.Text = "Network Type";
            this.lbl_SG_NetworkType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SG_NodesNumber
            // 
            this.lbl_SG_NodesNumber.AutoSize = true;
            this.lbl_SG_NodesNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_NodesNumber.Location = new System.Drawing.Point(3, 30);
            this.lbl_SG_NodesNumber.Name = "lbl_SG_NodesNumber";
            this.lbl_SG_NodesNumber.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_NodesNumber.TabIndex = 3;
            this.lbl_SG_NodesNumber.Text = "Number of Nodes";
            this.lbl_SG_NodesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SG_IPNetwork
            // 
            this.lbl_SG_IPNetwork.AutoSize = true;
            this.lbl_SG_IPNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_IPNetwork.Location = new System.Drawing.Point(3, 60);
            this.lbl_SG_IPNetwork.Name = "lbl_SG_IPNetwork";
            this.lbl_SG_IPNetwork.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_IPNetwork.TabIndex = 4;
            this.lbl_SG_IPNetwork.Text = "P2P IP Network ";
            this.lbl_SG_IPNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_SG_NodesNumber
            // 
            this.tb_SG_NodesNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_NodesNumber.Location = new System.Drawing.Point(178, 33);
            this.tb_SG_NodesNumber.Multiline = true;
            this.tb_SG_NodesNumber.Name = "tb_SG_NodesNumber";
            this.tb_SG_NodesNumber.Size = new System.Drawing.Size(239, 24);
            this.tb_SG_NodesNumber.TabIndex = 5;
            this.tb_SG_NodesNumber.TextChanged += new System.EventHandler(this.tb_SG_NodesNumber_TextChanged);
            // 
            // tb_SG_IPNetwork
            // 
            this.tb_SG_IPNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_IPNetwork.Location = new System.Drawing.Point(178, 63);
            this.tb_SG_IPNetwork.Multiline = true;
            this.tb_SG_IPNetwork.Name = "tb_SG_IPNetwork";
            this.tb_SG_IPNetwork.Size = new System.Drawing.Size(239, 24);
            this.tb_SG_IPNetwork.TabIndex = 6;
            // 
            // btn_ScenarioGen
            // 
            this.btn_ScenarioGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ScenarioGen.Location = new System.Drawing.Point(893, 2);
            this.btn_ScenarioGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ScenarioGen.Name = "btn_ScenarioGen";
            this.btn_ScenarioGen.Size = new System.Drawing.Size(144, 26);
            this.btn_ScenarioGen.TabIndex = 0;
            this.btn_ScenarioGen.Text = "Generate";
            this.btn_ScenarioGen.UseVisualStyleBackColor = true;
            this.btn_ScenarioGen.Click += new System.EventHandler(this.btn_ScenarioGen_Click);
            // 
            // lbl_SG_LinkDampingFactor
            // 
            this.lbl_SG_LinkDampingFactor.AutoSize = true;
            this.lbl_SG_LinkDampingFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_LinkDampingFactor.Location = new System.Drawing.Point(3, 90);
            this.lbl_SG_LinkDampingFactor.Name = "lbl_SG_LinkDampingFactor";
            this.lbl_SG_LinkDampingFactor.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_LinkDampingFactor.TabIndex = 7;
            this.lbl_SG_LinkDampingFactor.Text = "Link Damping Factor (0 - 100) ";
            this.lbl_SG_LinkDampingFactor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_SG_LinkDampingFactor
            // 
            this.tb_SG_LinkDampingFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_LinkDampingFactor.Location = new System.Drawing.Point(178, 93);
            this.tb_SG_LinkDampingFactor.Multiline = true;
            this.tb_SG_LinkDampingFactor.Name = "tb_SG_LinkDampingFactor";
            this.tb_SG_LinkDampingFactor.Size = new System.Drawing.Size(239, 24);
            this.tb_SG_LinkDampingFactor.TabIndex = 8;
            this.tb_SG_LinkDampingFactor.Text = "0";
            this.tb_SG_LinkDampingFactor.TextChanged += new System.EventHandler(this.tb_SG_LinkDampingFactor_TextChanged);
            // 
            // btn_SG_NT_Damped
            // 
            this.btn_SG_NT_Damped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SG_NT_Damped.AutoSize = true;
            this.btn_SG_NT_Damped.Checked = true;
            this.btn_SG_NT_Damped.Location = new System.Drawing.Point(178, 3);
            this.btn_SG_NT_Damped.Name = "btn_SG_NT_Damped";
            this.btn_SG_NT_Damped.Size = new System.Drawing.Size(61, 24);
            this.btn_SG_NT_Damped.TabIndex = 2;
            this.btn_SG_NT_Damped.TabStop = true;
            this.btn_SG_NT_Damped.Text = "Damped";
            this.btn_SG_NT_Damped.UseVisualStyleBackColor = true;
            // 
            // btn_SG_NT_Mesh
            // 
            this.btn_SG_NT_Mesh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SG_NT_Mesh.AutoSize = true;
            this.btn_SG_NT_Mesh.Location = new System.Drawing.Point(423, 3);
            this.btn_SG_NT_Mesh.Name = "btn_SG_NT_Mesh";
            this.btn_SG_NT_Mesh.Size = new System.Drawing.Size(54, 24);
            this.btn_SG_NT_Mesh.TabIndex = 9;
            this.btn_SG_NT_Mesh.TabStop = true;
            this.btn_SG_NT_Mesh.Text = "Mesh";
            this.btn_SG_NT_Mesh.UseVisualStyleBackColor = true;
            // 
            // btn_SG_NT_Waxman
            // 
            this.btn_SG_NT_Waxman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SG_NT_Waxman.AutoSize = true;
            this.btn_SG_NT_Waxman.Location = new System.Drawing.Point(598, 3);
            this.btn_SG_NT_Waxman.Name = "btn_SG_NT_Waxman";
            this.btn_SG_NT_Waxman.Size = new System.Drawing.Size(72, 24);
            this.btn_SG_NT_Waxman.TabIndex = 10;
            this.btn_SG_NT_Waxman.TabStop = true;
            this.btn_SG_NT_Waxman.Text = "Waxman";
            this.btn_SG_NT_Waxman.UseVisualStyleBackColor = true;
            // 
            // lbl_SG_Wax_lambda
            // 
            this.lbl_SG_Wax_lambda.AutoSize = true;
            this.lbl_SG_Wax_lambda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_Wax_lambda.Location = new System.Drawing.Point(423, 30);
            this.lbl_SG_Wax_lambda.Name = "lbl_SG_Wax_lambda";
            this.lbl_SG_Wax_lambda.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_Wax_lambda.TabIndex = 11;
            this.lbl_SG_Wax_lambda.Text = "Lambda";
            this.lbl_SG_Wax_lambda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SG_Wax_alpha
            // 
            this.lbl_SG_Wax_alpha.AutoSize = true;
            this.lbl_SG_Wax_alpha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_Wax_alpha.Location = new System.Drawing.Point(423, 60);
            this.lbl_SG_Wax_alpha.Name = "lbl_SG_Wax_alpha";
            this.lbl_SG_Wax_alpha.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_Wax_alpha.TabIndex = 12;
            this.lbl_SG_Wax_alpha.Text = "Alpha";
            this.lbl_SG_Wax_alpha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SG_Wax_beta
            // 
            this.lbl_SG_Wax_beta.AutoSize = true;
            this.lbl_SG_Wax_beta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_Wax_beta.Location = new System.Drawing.Point(423, 90);
            this.lbl_SG_Wax_beta.Name = "lbl_SG_Wax_beta";
            this.lbl_SG_Wax_beta.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_Wax_beta.TabIndex = 13;
            this.lbl_SG_Wax_beta.Text = "Beta";
            this.lbl_SG_Wax_beta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_SG_Wax_lambda
            // 
            this.tb_SG_Wax_lambda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_Wax_lambda.Location = new System.Drawing.Point(598, 33);
            this.tb_SG_Wax_lambda.Name = "tb_SG_Wax_lambda";
            this.tb_SG_Wax_lambda.Size = new System.Drawing.Size(239, 23);
            this.tb_SG_Wax_lambda.TabIndex = 16;
            // 
            // tb_SG_Wax_alpha
            // 
            this.tb_SG_Wax_alpha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_Wax_alpha.Location = new System.Drawing.Point(598, 63);
            this.tb_SG_Wax_alpha.Name = "tb_SG_Wax_alpha";
            this.tb_SG_Wax_alpha.Size = new System.Drawing.Size(239, 23);
            this.tb_SG_Wax_alpha.TabIndex = 17;
            // 
            // tb_SG_Wax_beta
            // 
            this.tb_SG_Wax_beta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_Wax_beta.Location = new System.Drawing.Point(598, 93);
            this.tb_SG_Wax_beta.Name = "tb_SG_Wax_beta";
            this.tb_SG_Wax_beta.Size = new System.Drawing.Size(239, 23);
            this.tb_SG_Wax_beta.TabIndex = 18;
            // 
            // lbl_SG_Wax_xmin
            // 
            this.lbl_SG_Wax_xmin.AutoSize = true;
            this.lbl_SG_Wax_xmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_Wax_xmin.Location = new System.Drawing.Point(423, 120);
            this.lbl_SG_Wax_xmin.Name = "lbl_SG_Wax_xmin";
            this.lbl_SG_Wax_xmin.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_Wax_xmin.TabIndex = 19;
            this.lbl_SG_Wax_xmin.Text = "X Min";
            this.lbl_SG_Wax_xmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SG_Wax_xmax
            // 
            this.lbl_SG_Wax_xmax.AutoSize = true;
            this.lbl_SG_Wax_xmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_Wax_xmax.Location = new System.Drawing.Point(423, 150);
            this.lbl_SG_Wax_xmax.Name = "lbl_SG_Wax_xmax";
            this.lbl_SG_Wax_xmax.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_Wax_xmax.TabIndex = 20;
            this.lbl_SG_Wax_xmax.Text = "X Max";
            this.lbl_SG_Wax_xmax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SG_Wax_ymin
            // 
            this.lbl_SG_Wax_ymin.AutoSize = true;
            this.lbl_SG_Wax_ymin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_Wax_ymin.Location = new System.Drawing.Point(423, 180);
            this.lbl_SG_Wax_ymin.Name = "lbl_SG_Wax_ymin";
            this.lbl_SG_Wax_ymin.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_Wax_ymin.TabIndex = 21;
            this.lbl_SG_Wax_ymin.Text = "Y Min";
            this.lbl_SG_Wax_ymin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SG_Wax_ymax
            // 
            this.lbl_SG_Wax_ymax.AutoSize = true;
            this.lbl_SG_Wax_ymax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SG_Wax_ymax.Location = new System.Drawing.Point(423, 210);
            this.lbl_SG_Wax_ymax.Name = "lbl_SG_Wax_ymax";
            this.lbl_SG_Wax_ymax.Size = new System.Drawing.Size(169, 30);
            this.lbl_SG_Wax_ymax.TabIndex = 22;
            this.lbl_SG_Wax_ymax.Text = "Y Max";
            this.lbl_SG_Wax_ymax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_SG_Wax_xmin
            // 
            this.tb_SG_Wax_xmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_Wax_xmin.Location = new System.Drawing.Point(598, 123);
            this.tb_SG_Wax_xmin.Name = "tb_SG_Wax_xmin";
            this.tb_SG_Wax_xmin.Size = new System.Drawing.Size(239, 23);
            this.tb_SG_Wax_xmin.TabIndex = 23;
            // 
            // tb_SG_Wax_xmax
            // 
            this.tb_SG_Wax_xmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_Wax_xmax.Location = new System.Drawing.Point(598, 153);
            this.tb_SG_Wax_xmax.Name = "tb_SG_Wax_xmax";
            this.tb_SG_Wax_xmax.Size = new System.Drawing.Size(239, 23);
            this.tb_SG_Wax_xmax.TabIndex = 24;
            // 
            // tb_SG_Wax_ymin
            // 
            this.tb_SG_Wax_ymin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_Wax_ymin.Location = new System.Drawing.Point(598, 183);
            this.tb_SG_Wax_ymin.Name = "tb_SG_Wax_ymin";
            this.tb_SG_Wax_ymin.Size = new System.Drawing.Size(239, 23);
            this.tb_SG_Wax_ymin.TabIndex = 25;
            // 
            // tb_SG_Wax_ymax
            // 
            this.tb_SG_Wax_ymax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SG_Wax_ymax.Location = new System.Drawing.Point(598, 213);
            this.tb_SG_Wax_ymax.Name = "tb_SG_Wax_ymax";
            this.tb_SG_Wax_ymax.Size = new System.Drawing.Size(239, 23);
            this.tb_SG_Wax_ymax.TabIndex = 26;
            // 
            // pageSettings
            // 
            this.pageSettings.Controls.Add(this.tlp_Settings);
            this.pageSettings.Location = new System.Drawing.Point(4, 24);
            this.pageSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageSettings.Size = new System.Drawing.Size(1046, 370);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "Settings";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // tlp_Settings
            // 
            this.tlp_Settings.ColumnCount = 4;
            this.tlp_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlp_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_Settings.Controls.Add(this.btnReload, 3, 0);
            this.tlp_Settings.Controls.Add(this.btnSave, 3, 1);
            this.tlp_Settings.Controls.Add(this.lblOutputFolder, 0, 0);
            this.tlp_Settings.Controls.Add(this.tbOutputFolder, 1, 0);
            this.tlp_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Settings.Location = new System.Drawing.Point(3, 2);
            this.tlp_Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_Settings.Name = "tlp_Settings";
            this.tlp_Settings.RowCount = 3;
            this.tlp_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Settings.Size = new System.Drawing.Size(1040, 366);
            this.tlp_Settings.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReload.Location = new System.Drawing.Point(893, 2);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(144, 26);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(893, 32);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutputFolder.Location = new System.Drawing.Point(3, 0);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(244, 30);
            this.lblOutputFolder.TabIndex = 2;
            this.lblOutputFolder.Text = "Output Folder";
            this.lblOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOutputFolder
            // 
            this.tbOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOutputFolder.Location = new System.Drawing.Point(253, 2);
            this.tbOutputFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOutputFolder.Multiline = true;
            this.tbOutputFolder.Name = "tbOutputFolder";
            this.tbOutputFolder.Size = new System.Drawing.Size(484, 26);
            this.tbOutputFolder.TabIndex = 3;
            // 
            // tabPageConsole
            // 
            this.tabPageConsole.Controls.Add(this.tb_Console);
            this.tabPageConsole.Location = new System.Drawing.Point(4, 24);
            this.tabPageConsole.Name = "tabPageConsole";
            this.tabPageConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsole.Size = new System.Drawing.Size(1046, 370);
            this.tabPageConsole.TabIndex = 2;
            this.tabPageConsole.Text = "Console";
            this.tabPageConsole.UseVisualStyleBackColor = true;
            // 
            // tb_Console
            // 
            this.tb_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Console.Location = new System.Drawing.Point(3, 3);
            this.tb_Console.Multiline = true;
            this.tb_Console.Name = "tb_Console";
            this.tb_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Console.Size = new System.Drawing.Size(1040, 364);
            this.tb_Console.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 444);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Scenario Generator";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pageScenarioGen.ResumeLayout(false);
            this.tlp_ScenarioGen.ResumeLayout(false);
            this.tlp_ScenarioGen.PerformLayout();
            this.pageSettings.ResumeLayout(false);
            this.tlp_Settings.ResumeLayout(false);
            this.tlp_Settings.PerformLayout();
            this.tabPageConsole.ResumeLayout(false);
            this.tabPageConsole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageScenarioGen;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.TextBox tbOutputFolder;
        private System.Windows.Forms.TableLayoutPanel tlp_ScenarioGen;
        private System.Windows.Forms.Button btn_ScenarioGen;
        private System.Windows.Forms.TableLayoutPanel tlp_Settings;
        private System.Windows.Forms.Label lbl_SG_NetworkType;
        private System.Windows.Forms.RadioButton btn_SG_NT_Damped;
        private System.Windows.Forms.RadioButton btn_SG_NT_Mesh;
        private System.Windows.Forms.Label lbl_SG_NodesNumber;
        private System.Windows.Forms.TextBox tb_SG_IPNetwork;
        private System.Windows.Forms.Label lbl_SG_IPNetwork;
        private System.Windows.Forms.TextBox tb_SG_NodesNumber;
        private System.Windows.Forms.Label lbl_SG_LinkDampingFactor;
        private System.Windows.Forms.TextBox tb_SG_LinkDampingFactor;
        private System.Windows.Forms.TabPage tabPageConsole;
        private System.Windows.Forms.TextBox tb_Console;
        private System.Windows.Forms.RadioButton btn_SG_NT_Waxman;
        private System.Windows.Forms.Label lbl_SG_Wax_lambda;
        private System.Windows.Forms.Label lbl_SG_Wax_alpha;
        private System.Windows.Forms.Label lbl_SG_Wax_beta;
        private System.Windows.Forms.TextBox tb_SG_Wax_lambda;
        private System.Windows.Forms.TextBox tb_SG_Wax_alpha;
        private System.Windows.Forms.TextBox tb_SG_Wax_beta;
        private System.Windows.Forms.Label lbl_SG_Wax_xmin;
        private System.Windows.Forms.Label lbl_SG_Wax_xmax;
        private System.Windows.Forms.Label lbl_SG_Wax_ymin;
        private System.Windows.Forms.Label lbl_SG_Wax_ymax;
        private System.Windows.Forms.TextBox tb_SG_Wax_xmin;
        private System.Windows.Forms.TextBox tb_SG_Wax_xmax;
        private System.Windows.Forms.TextBox tb_SG_Wax_ymin;
        private System.Windows.Forms.TextBox tb_SG_Wax_ymax;
    }
}

