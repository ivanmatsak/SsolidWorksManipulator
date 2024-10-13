
namespace SolidWorksSimulationManager
{
    partial class StressNodeListViewForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewStress = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonSX = new System.Windows.Forms.RadioButton();
            this.radioButtonSY = new System.Windows.Forms.RadioButton();
            this.radioButtonSZ = new System.Windows.Forms.RadioButton();
            this.radioButtonXY = new System.Windows.Forms.RadioButton();
            this.radioButtonYZ = new System.Windows.Forms.RadioButton();
            this.radioButtonXZ = new System.Windows.Forms.RadioButton();
            this.radioButtonP1 = new System.Windows.Forms.RadioButton();
            this.radioButtonP2 = new System.Windows.Forms.RadioButton();
            this.radioButtonP3 = new System.Windows.Forms.RadioButton();
            this.radioButtonVON = new System.Windows.Forms.RadioButton();
            this.radioButtonINT = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFindMinimum = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFindArea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMaxTitle = new System.Windows.Forms.Label();
            this.labelMinTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelTitleValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNodeNumberTitle = new System.Windows.Forms.Label();
            this.textBoxNodeValue = new System.Windows.Forms.TextBox();
            this.labelSelectParam = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.timerCalculate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(964, 451);
            this.splitContainer1.SplitterDistance = 635;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewStress);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица точек";
            // 
            // listViewStress
            // 
            this.listViewStress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewStress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewStress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStress.GridLines = true;
            this.listViewStress.HideSelection = false;
            this.listViewStress.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewStress.Location = new System.Drawing.Point(4, 19);
            this.listViewStress.Name = "listViewStress";
            this.listViewStress.Size = new System.Drawing.Size(627, 428);
            this.listViewStress.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewStress.TabIndex = 0;
            this.listViewStress.UseCompatibleStateImageBehavior = false;
            this.listViewStress.View = System.Windows.Forms.View.Details;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.buttonFindMinimum);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(309, 451);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.SplitterWidth = 20;
            this.splitContainer2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.radioButtonSX, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonSY, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonSZ, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonXY, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonYZ, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonXZ, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonP1, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonP2, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonP3, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonVON, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonINT, 0, 11);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 13;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(286, 299);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // radioButtonSX
            // 
            this.radioButtonSX.AutoSize = true;
            this.radioButtonSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonSX.Location = new System.Drawing.Point(3, 13);
            this.radioButtonSX.Name = "radioButtonSX";
            this.radioButtonSX.Size = new System.Drawing.Size(280, 20);
            this.radioButtonSX.TabIndex = 0;
            this.radioButtonSX.TabStop = true;
            this.radioButtonSX.Text = "SX";
            this.radioButtonSX.UseVisualStyleBackColor = true;
            this.radioButtonSX.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSY
            // 
            this.radioButtonSY.AutoSize = true;
            this.radioButtonSY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonSY.Location = new System.Drawing.Point(3, 39);
            this.radioButtonSY.Name = "radioButtonSY";
            this.radioButtonSY.Size = new System.Drawing.Size(280, 20);
            this.radioButtonSY.TabIndex = 1;
            this.radioButtonSY.TabStop = true;
            this.radioButtonSY.Text = "SY";
            this.radioButtonSY.UseVisualStyleBackColor = true;
            this.radioButtonSY.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSZ
            // 
            this.radioButtonSZ.AutoSize = true;
            this.radioButtonSZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonSZ.Location = new System.Drawing.Point(3, 65);
            this.radioButtonSZ.Name = "radioButtonSZ";
            this.radioButtonSZ.Size = new System.Drawing.Size(280, 20);
            this.radioButtonSZ.TabIndex = 2;
            this.radioButtonSZ.TabStop = true;
            this.radioButtonSZ.Text = "SZ";
            this.radioButtonSZ.UseVisualStyleBackColor = true;
            this.radioButtonSZ.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonXY
            // 
            this.radioButtonXY.AutoSize = true;
            this.radioButtonXY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonXY.Location = new System.Drawing.Point(3, 91);
            this.radioButtonXY.Name = "radioButtonXY";
            this.radioButtonXY.Size = new System.Drawing.Size(280, 20);
            this.radioButtonXY.TabIndex = 3;
            this.radioButtonXY.TabStop = true;
            this.radioButtonXY.Text = "XY";
            this.radioButtonXY.UseVisualStyleBackColor = true;
            this.radioButtonXY.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonYZ
            // 
            this.radioButtonYZ.AutoSize = true;
            this.radioButtonYZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonYZ.Location = new System.Drawing.Point(3, 117);
            this.radioButtonYZ.Name = "radioButtonYZ";
            this.radioButtonYZ.Size = new System.Drawing.Size(280, 20);
            this.radioButtonYZ.TabIndex = 4;
            this.radioButtonYZ.TabStop = true;
            this.radioButtonYZ.Text = "YZ";
            this.radioButtonYZ.UseVisualStyleBackColor = true;
            this.radioButtonYZ.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonXZ
            // 
            this.radioButtonXZ.AutoSize = true;
            this.radioButtonXZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonXZ.Location = new System.Drawing.Point(3, 143);
            this.radioButtonXZ.Name = "radioButtonXZ";
            this.radioButtonXZ.Size = new System.Drawing.Size(280, 20);
            this.radioButtonXZ.TabIndex = 5;
            this.radioButtonXZ.TabStop = true;
            this.radioButtonXZ.Text = "XZ";
            this.radioButtonXZ.UseVisualStyleBackColor = true;
            this.radioButtonXZ.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonP1
            // 
            this.radioButtonP1.AutoSize = true;
            this.radioButtonP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonP1.Location = new System.Drawing.Point(3, 169);
            this.radioButtonP1.Name = "radioButtonP1";
            this.radioButtonP1.Size = new System.Drawing.Size(280, 20);
            this.radioButtonP1.TabIndex = 6;
            this.radioButtonP1.TabStop = true;
            this.radioButtonP1.Text = "P1";
            this.radioButtonP1.UseVisualStyleBackColor = true;
            this.radioButtonP1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonP2
            // 
            this.radioButtonP2.AutoSize = true;
            this.radioButtonP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonP2.Location = new System.Drawing.Point(3, 195);
            this.radioButtonP2.Name = "radioButtonP2";
            this.radioButtonP2.Size = new System.Drawing.Size(280, 20);
            this.radioButtonP2.TabIndex = 7;
            this.radioButtonP2.TabStop = true;
            this.radioButtonP2.Text = "P2";
            this.radioButtonP2.UseVisualStyleBackColor = true;
            this.radioButtonP2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonP3
            // 
            this.radioButtonP3.AutoSize = true;
            this.radioButtonP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonP3.Location = new System.Drawing.Point(3, 221);
            this.radioButtonP3.Name = "radioButtonP3";
            this.radioButtonP3.Size = new System.Drawing.Size(280, 20);
            this.radioButtonP3.TabIndex = 8;
            this.radioButtonP3.TabStop = true;
            this.radioButtonP3.Text = "P3";
            this.radioButtonP3.UseVisualStyleBackColor = true;
            this.radioButtonP3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonVON
            // 
            this.radioButtonVON.AutoSize = true;
            this.radioButtonVON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonVON.Location = new System.Drawing.Point(3, 247);
            this.radioButtonVON.Name = "radioButtonVON";
            this.radioButtonVON.Size = new System.Drawing.Size(280, 20);
            this.radioButtonVON.TabIndex = 9;
            this.radioButtonVON.TabStop = true;
            this.radioButtonVON.Text = "VON";
            this.radioButtonVON.UseVisualStyleBackColor = true;
            this.radioButtonVON.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonINT
            // 
            this.radioButtonINT.AutoSize = true;
            this.radioButtonINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonINT.Location = new System.Drawing.Point(3, 273);
            this.radioButtonINT.Name = "radioButtonINT";
            this.radioButtonINT.Size = new System.Drawing.Size(280, 20);
            this.radioButtonINT.TabIndex = 10;
            this.radioButtonINT.TabStop = true;
            this.radioButtonINT.Text = "INT";
            this.radioButtonINT.UseVisualStyleBackColor = true;
            this.radioButtonINT.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 238);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройка поиска";
            // 
            // buttonFindMinimum
            // 
            this.buttonFindMinimum.Location = new System.Drawing.Point(3, 237);
            this.buttonFindMinimum.Name = "buttonFindMinimum";
            this.buttonFindMinimum.Size = new System.Drawing.Size(303, 38);
            this.buttonFindMinimum.TabIndex = 1;
            this.buttonFindMinimum.Text = "Найти минимум";
            this.buttonFindMinimum.UseVisualStyleBackColor = true;
            this.buttonFindMinimum.Click += new System.EventHandler(this.buttonFindMinimum_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonFindArea, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelMaxTitle, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelMinTitle, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelMax, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelMin, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelTitleValue, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelNodeNumberTitle, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNodeValue, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelSelectParam, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownMax, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownMin, 2, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 216);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(113, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonFindArea
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonFindArea, 4);
            this.buttonFindArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFindArea.Location = new System.Drawing.Point(0, 174);
            this.buttonFindArea.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFindArea.Name = "buttonFindArea";
            this.buttonFindArea.Size = new System.Drawing.Size(303, 40);
            this.buttonFindArea.TabIndex = 1;
            this.buttonFindArea.Text = "Поиск областей";
            this.buttonFindArea.UseVisualStyleBackColor = true;
            this.buttonFindArea.Click += new System.EventHandler(this.buttonFindArea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(113, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMaxTitle
            // 
            this.labelMaxTitle.AutoSize = true;
            this.labelMaxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxTitle.Location = new System.Drawing.Point(3, 58);
            this.labelMaxTitle.Name = "labelMaxTitle";
            this.labelMaxTitle.Size = new System.Drawing.Size(104, 32);
            this.labelMaxTitle.TabIndex = 2;
            this.labelMaxTitle.Text = "Верхняя граница";
            this.labelMaxTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMinTitle
            // 
            this.labelMinTitle.AutoSize = true;
            this.labelMinTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinTitle.Location = new System.Drawing.Point(3, 116);
            this.labelMinTitle.Name = "labelMinTitle";
            this.labelMinTitle.Size = new System.Drawing.Size(104, 32);
            this.labelMinTitle.TabIndex = 3;
            this.labelMinTitle.Text = "Нижняя граница";
            this.labelMinTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(243, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(243, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMax.Location = new System.Drawing.Point(133, 90);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(104, 16);
            this.labelMax.TabIndex = 8;
            this.labelMax.Text = "None";
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMin.Location = new System.Drawing.Point(133, 148);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(104, 16);
            this.labelMin.TabIndex = 9;
            this.labelMin.Text = "None";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleValue
            // 
            this.labelTitleValue.AutoSize = true;
            this.labelTitleValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleValue.Location = new System.Drawing.Point(3, 10);
            this.labelTitleValue.Name = "labelTitleValue";
            this.labelTitleValue.Size = new System.Drawing.Size(104, 22);
            this.labelTitleValue.TabIndex = 10;
            this.labelTitleValue.Text = "Значение";
            this.labelTitleValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(113, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNodeNumberTitle
            // 
            this.labelNodeNumberTitle.AutoSize = true;
            this.labelNodeNumberTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNodeNumberTitle.Location = new System.Drawing.Point(133, 32);
            this.labelNodeNumberTitle.Name = "labelNodeNumberTitle";
            this.labelNodeNumberTitle.Size = new System.Drawing.Size(104, 16);
            this.labelNodeNumberTitle.TabIndex = 12;
            this.labelNodeNumberTitle.Text = "None";
            this.labelNodeNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNodeValue
            // 
            this.textBoxNodeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNodeValue.Location = new System.Drawing.Point(130, 10);
            this.textBoxNodeValue.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNodeValue.Name = "textBoxNodeValue";
            this.textBoxNodeValue.Size = new System.Drawing.Size(110, 22);
            this.textBoxNodeValue.TabIndex = 13;
            this.textBoxNodeValue.Text = "0";
            this.textBoxNodeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSelectParam
            // 
            this.labelSelectParam.AutoSize = true;
            this.labelSelectParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectParam.Location = new System.Drawing.Point(243, 10);
            this.labelSelectParam.Name = "labelSelectParam";
            this.labelSelectParam.Size = new System.Drawing.Size(57, 22);
            this.labelSelectParam.TabIndex = 14;
            this.labelSelectParam.Text = "None";
            this.labelSelectParam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMax.Location = new System.Drawing.Point(130, 58);
            this.numericUpDownMax.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(110, 22);
            this.numericUpDownMax.TabIndex = 15;
            this.numericUpDownMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMin.Location = new System.Drawing.Point(130, 116);
            this.numericUpDownMin.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(110, 22);
            this.numericUpDownMin.TabIndex = 16;
            this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timerCalculate
            // 
            this.timerCalculate.Interval = 500;
            this.timerCalculate.Tick += new System.EventHandler(this.timerCalculate_Tick);
            // 
            // StressNodeListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StressNodeListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Точки STRESS";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewStress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton radioButtonSX;
        private System.Windows.Forms.RadioButton radioButtonSY;
        private System.Windows.Forms.RadioButton radioButtonSZ;
        private System.Windows.Forms.RadioButton radioButtonXY;
        private System.Windows.Forms.RadioButton radioButtonYZ;
        private System.Windows.Forms.RadioButton radioButtonXZ;
        private System.Windows.Forms.RadioButton radioButtonP1;
        private System.Windows.Forms.RadioButton radioButtonP2;
        private System.Windows.Forms.RadioButton radioButtonP3;
        private System.Windows.Forms.RadioButton radioButtonVON;
        private System.Windows.Forms.RadioButton radioButtonINT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFindArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaxTitle;
        private System.Windows.Forms.Label labelMinTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelTitleValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNodeNumberTitle;
        private System.Windows.Forms.TextBox textBoxNodeValue;
        private System.Windows.Forms.Label labelSelectParam;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Timer timerCalculate;
        private System.Windows.Forms.Button buttonFindMinimum;
    }
}