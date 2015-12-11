namespace Rooibos.RC.Win.Diagnostics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.checkBoxMode = new System.Windows.Forms.CheckBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewIO = new System.Windows.Forms.DataGridView();
            this.DateStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxAilerons = new System.Windows.Forms.GroupBox();
            this.numericUpDownAileronsLevelDegrees = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAileronsMinDegrees = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAileronsMaxDegrees = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxElevators = new System.Windows.Forms.GroupBox();
            this.numericUpDownElevatorsLevelDegrees = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownElevatorsMinDegrees = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownElevatorsMaxDegrees = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownRudderLevelDegrees = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRudderMinDegrees = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRudderMaxDegrees = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxProtocolTerminator = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStripStatusLabelTimeOpen = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIO)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxAilerons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAileronsLevelDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAileronsMinDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAileronsMaxDegrees)).BeginInit();
            this.groupBoxElevators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElevatorsLevelDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElevatorsMinDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElevatorsMaxDegrees)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRudderLevelDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRudderMinDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRudderMaxDegrees)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTimeOpen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxAutoScroll);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOpen);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxPorts);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMode);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartStop);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(748, 408);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 1;
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(377, 12);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.checkBoxAutoScroll.TabIndex = 4;
            this.checkBoxAutoScroll.Text = "Auto Scroll";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(215, 8);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click_1);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 10);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 2;
            // 
            // checkBoxMode
            // 
            this.checkBoxMode.AutoSize = true;
            this.checkBoxMode.Enabled = false;
            this.checkBoxMode.Location = new System.Drawing.Point(139, 12);
            this.checkBoxMode.Name = "checkBoxMode";
            this.checkBoxMode.Size = new System.Drawing.Size(70, 17);
            this.checkBoxMode.TabIndex = 1;
            this.checkBoxMode.Text = "Controller";
            this.checkBoxMode.UseVisualStyleBackColor = true;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Enabled = false;
            this.btnStartStop.Location = new System.Drawing.Point(296, 8);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start Test";
            this.btnStartStop.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 365);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewIO);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIO
            // 
            this.dataGridViewIO.AllowUserToAddRows = false;
            this.dataGridViewIO.AllowUserToDeleteRows = false;
            this.dataGridViewIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateStamp,
            this.Source,
            this.Command,
            this.Value});
            this.dataGridViewIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIO.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewIO.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewIO.Name = "dataGridViewIO";
            this.dataGridViewIO.Size = new System.Drawing.Size(734, 333);
            this.dataGridViewIO.TabIndex = 0;
            // 
            // DateStamp
            // 
            this.DateStamp.HeaderText = "DateStamp";
            this.DateStamp.Name = "DateStamp";
            this.DateStamp.ReadOnly = true;
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            // 
            // Command
            // 
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxAilerons);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxElevators);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(734, 333);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxAilerons
            // 
            this.groupBoxAilerons.Controls.Add(this.numericUpDownAileronsLevelDegrees);
            this.groupBoxAilerons.Controls.Add(this.numericUpDownAileronsMinDegrees);
            this.groupBoxAilerons.Controls.Add(this.numericUpDownAileronsMaxDegrees);
            this.groupBoxAilerons.Controls.Add(this.label3);
            this.groupBoxAilerons.Controls.Add(this.label2);
            this.groupBoxAilerons.Controls.Add(this.label1);
            this.groupBoxAilerons.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAilerons.Name = "groupBoxAilerons";
            this.groupBoxAilerons.Size = new System.Drawing.Size(174, 119);
            this.groupBoxAilerons.TabIndex = 0;
            this.groupBoxAilerons.TabStop = false;
            this.groupBoxAilerons.Text = "Ailerons";
            // 
            // numericUpDownAileronsLevelDegrees
            // 
            this.numericUpDownAileronsLevelDegrees.Location = new System.Drawing.Point(89, 76);
            this.numericUpDownAileronsLevelDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownAileronsLevelDegrees.Name = "numericUpDownAileronsLevelDegrees";
            this.numericUpDownAileronsLevelDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownAileronsLevelDegrees.TabIndex = 8;
            this.numericUpDownAileronsLevelDegrees.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDownAileronsMinDegrees
            // 
            this.numericUpDownAileronsMinDegrees.Location = new System.Drawing.Point(89, 50);
            this.numericUpDownAileronsMinDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownAileronsMinDegrees.Name = "numericUpDownAileronsMinDegrees";
            this.numericUpDownAileronsMinDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownAileronsMinDegrees.TabIndex = 7;
            this.numericUpDownAileronsMinDegrees.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numericUpDownAileronsMaxDegrees
            // 
            this.numericUpDownAileronsMaxDegrees.Location = new System.Drawing.Point(89, 24);
            this.numericUpDownAileronsMaxDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownAileronsMaxDegrees.Name = "numericUpDownAileronsMaxDegrees";
            this.numericUpDownAileronsMaxDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownAileronsMaxDegrees.TabIndex = 6;
            this.numericUpDownAileronsMaxDegrees.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Level Degrees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min Degrees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Degrees";
            // 
            // groupBoxElevators
            // 
            this.groupBoxElevators.Controls.Add(this.numericUpDownElevatorsLevelDegrees);
            this.groupBoxElevators.Controls.Add(this.numericUpDownElevatorsMinDegrees);
            this.groupBoxElevators.Controls.Add(this.numericUpDownElevatorsMaxDegrees);
            this.groupBoxElevators.Controls.Add(this.label4);
            this.groupBoxElevators.Controls.Add(this.label5);
            this.groupBoxElevators.Controls.Add(this.label6);
            this.groupBoxElevators.Location = new System.Drawing.Point(183, 3);
            this.groupBoxElevators.Name = "groupBoxElevators";
            this.groupBoxElevators.Size = new System.Drawing.Size(174, 119);
            this.groupBoxElevators.TabIndex = 9;
            this.groupBoxElevators.TabStop = false;
            this.groupBoxElevators.Text = "Elevators";
            // 
            // numericUpDownElevatorsLevelDegrees
            // 
            this.numericUpDownElevatorsLevelDegrees.Location = new System.Drawing.Point(89, 76);
            this.numericUpDownElevatorsLevelDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownElevatorsLevelDegrees.Name = "numericUpDownElevatorsLevelDegrees";
            this.numericUpDownElevatorsLevelDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownElevatorsLevelDegrees.TabIndex = 8;
            this.numericUpDownElevatorsLevelDegrees.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numericUpDownElevatorsMinDegrees
            // 
            this.numericUpDownElevatorsMinDegrees.Location = new System.Drawing.Point(89, 50);
            this.numericUpDownElevatorsMinDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownElevatorsMinDegrees.Name = "numericUpDownElevatorsMinDegrees";
            this.numericUpDownElevatorsMinDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownElevatorsMinDegrees.TabIndex = 7;
            this.numericUpDownElevatorsMinDegrees.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // numericUpDownElevatorsMaxDegrees
            // 
            this.numericUpDownElevatorsMaxDegrees.Location = new System.Drawing.Point(89, 24);
            this.numericUpDownElevatorsMaxDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownElevatorsMaxDegrees.Name = "numericUpDownElevatorsMaxDegrees";
            this.numericUpDownElevatorsMaxDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownElevatorsMaxDegrees.TabIndex = 6;
            this.numericUpDownElevatorsMaxDegrees.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Level Degrees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Min Degrees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Max Degrees";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownRudderLevelDegrees);
            this.groupBox1.Controls.Add(this.numericUpDownRudderMinDegrees);
            this.groupBox1.Controls.Add(this.numericUpDownRudderMaxDegrees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(363, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rudder";
            // 
            // numericUpDownRudderLevelDegrees
            // 
            this.numericUpDownRudderLevelDegrees.Location = new System.Drawing.Point(89, 76);
            this.numericUpDownRudderLevelDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownRudderLevelDegrees.Name = "numericUpDownRudderLevelDegrees";
            this.numericUpDownRudderLevelDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownRudderLevelDegrees.TabIndex = 8;
            this.numericUpDownRudderLevelDegrees.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // numericUpDownRudderMinDegrees
            // 
            this.numericUpDownRudderMinDegrees.Location = new System.Drawing.Point(89, 50);
            this.numericUpDownRudderMinDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownRudderMinDegrees.Name = "numericUpDownRudderMinDegrees";
            this.numericUpDownRudderMinDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownRudderMinDegrees.TabIndex = 7;
            this.numericUpDownRudderMinDegrees.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownRudderMaxDegrees
            // 
            this.numericUpDownRudderMaxDegrees.Location = new System.Drawing.Point(89, 24);
            this.numericUpDownRudderMaxDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownRudderMaxDegrees.Name = "numericUpDownRudderMaxDegrees";
            this.numericUpDownRudderMaxDegrees.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownRudderMaxDegrees.TabIndex = 6;
            this.numericUpDownRudderMaxDegrees.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Level Degrees";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Min Degrees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Max Degrees";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxProtocolTerminator);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(543, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 66);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Protocol";
            // 
            // textBoxProtocolTerminator
            // 
            this.textBoxProtocolTerminator.Location = new System.Drawing.Point(89, 13);
            this.textBoxProtocolTerminator.Name = "textBoxProtocolTerminator";
            this.textBoxProtocolTerminator.Size = new System.Drawing.Size(71, 20);
            this.textBoxProtocolTerminator.TabIndex = 1;
            this.textBoxProtocolTerminator.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Terminator";
            // 
            // toolStripStatusLabelTimeOpen
            // 
            this.toolStripStatusLabelTimeOpen.Name = "toolStripStatusLabelTimeOpen";
            this.toolStripStatusLabelTimeOpen.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 430);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "RC Diagnostics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIO)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxAilerons.ResumeLayout(false);
            this.groupBoxAilerons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAileronsLevelDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAileronsMinDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAileronsMaxDegrees)).EndInit();
            this.groupBoxElevators.ResumeLayout(false);
            this.groupBoxElevators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElevatorsLevelDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElevatorsMinDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElevatorsMaxDegrees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRudderLevelDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRudderMinDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRudderMaxDegrees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeOpen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBoxAutoScroll;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.CheckBox checkBoxMode;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxAilerons;
        private System.Windows.Forms.NumericUpDown numericUpDownAileronsLevelDegrees;
        private System.Windows.Forms.NumericUpDown numericUpDownAileronsMinDegrees;
        private System.Windows.Forms.NumericUpDown numericUpDownAileronsMaxDegrees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxElevators;
        private System.Windows.Forms.NumericUpDown numericUpDownElevatorsLevelDegrees;
        private System.Windows.Forms.NumericUpDown numericUpDownElevatorsMinDegrees;
        private System.Windows.Forms.NumericUpDown numericUpDownElevatorsMaxDegrees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownRudderLevelDegrees;
        private System.Windows.Forms.NumericUpDown numericUpDownRudderMinDegrees;
        private System.Windows.Forms.NumericUpDown numericUpDownRudderMaxDegrees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxProtocolTerminator;
        private System.Windows.Forms.Label label10;
    }
}

