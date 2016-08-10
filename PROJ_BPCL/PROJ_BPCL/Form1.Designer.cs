namespace PROJ_BPCL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGrampanchayat = new System.Windows.Forms.ComboBox();
            this.cmbTown = new System.Windows.Forms.ComboBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.txtMotherNameSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFatherNameSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlSearchTIN_ID = new System.Windows.Forms.Panel();
            this.txtAHL_TIN = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNPR_TIN = new System.Windows.Forms.TextBox();
            this.pnlSearchInformation = new System.Windows.Forms.Panel();
            this.txtNameSearch_P3 = new System.Windows.Forms.TextBox();
            this.txtNameSearch_P2 = new System.Windows.Forms.TextBox();
            this.pnlSearchRadio = new System.Windows.Forms.Panel();
            this.rdInformation = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.rdTINID = new System.Windows.Forms.RadioButton();
            this.pnlSearchCombo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTaluka = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlToolstrip = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnClearSearchFields = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlSearchTIN_ID.SuspendLayout();
            this.pnlSearchInformation.SuspendLayout();
            this.pnlSearchRadio.SuspendLayout();
            this.pnlSearchCombo.SuspendLayout();
            this.pnlToolstrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grampanchyayat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Town :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name Search :";
            // 
            // cmbGrampanchayat
            // 
            this.cmbGrampanchayat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrampanchayat.FormattingEnabled = true;
            this.cmbGrampanchayat.Items.AddRange(new object[] {
            "All"});
            this.cmbGrampanchayat.Location = new System.Drawing.Point(695, 8);
            this.cmbGrampanchayat.Name = "cmbGrampanchayat";
            this.cmbGrampanchayat.Size = new System.Drawing.Size(260, 22);
            this.cmbGrampanchayat.TabIndex = 1;
            this.cmbGrampanchayat.SelectedIndexChanged += new System.EventHandler(this.cmbGrampanchayat_SelectedIndexChanged);
            // 
            // cmbTown
            // 
            this.cmbTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTown.FormattingEnabled = true;
            this.cmbTown.Items.AddRange(new object[] {
            "All"});
            this.cmbTown.Location = new System.Drawing.Point(695, 36);
            this.cmbTown.Name = "cmbTown";
            this.cmbTown.Size = new System.Drawing.Size(260, 22);
            this.cmbTown.TabIndex = 3;
            this.cmbTown.SelectedIndexChanged += new System.EventHandler(this.cmbTown_SelectedIndexChanged);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(164, 4);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(260, 22);
            this.txtNameSearch.TabIndex = 4;
            // 
            // dgvResult
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.GridColor = System.Drawing.SystemColors.Control;
            this.dgvResult.Location = new System.Drawing.Point(3, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResult.Size = new System.Drawing.Size(984, 352);
            this.dgvResult.TabIndex = 0;
            // 
            // txtMotherNameSearch
            // 
            this.txtMotherNameSearch.Location = new System.Drawing.Point(164, 32);
            this.txtMotherNameSearch.Name = "txtMotherNameSearch";
            this.txtMotherNameSearch.Size = new System.Drawing.Size(260, 22);
            this.txtMotherNameSearch.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mother Name Search :";
            // 
            // txtFatherNameSearch
            // 
            this.txtFatherNameSearch.Location = new System.Drawing.Point(164, 60);
            this.txtFatherNameSearch.Name = "txtFatherNameSearch";
            this.txtFatherNameSearch.Size = new System.Drawing.Size(260, 22);
            this.txtFatherNameSearch.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Father Name Search :";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlDataGrid);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 69);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(990, 544);
            this.pnlMain.TabIndex = 16;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.pnlDataGrid.Controls.Add(this.label11);
            this.pnlDataGrid.Controls.Add(this.label10);
            this.pnlDataGrid.Controls.Add(this.label9);
            this.pnlDataGrid.Controls.Add(this.label8);
            this.pnlDataGrid.Controls.Add(this.dgvResult);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 189);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlDataGrid.Size = new System.Drawing.Size(990, 355);
            this.pnlDataGrid.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(3, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 350);
            this.label11.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(986, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1, 350);
            this.label10.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(3, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(984, 1);
            this.label9.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(984, 1);
            this.label8.TabIndex = 12;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.pnlTop.Controls.Add(this.pnlSearchTIN_ID);
            this.pnlTop.Controls.Add(this.pnlSearchInformation);
            this.pnlTop.Controls.Add(this.pnlSearchRadio);
            this.pnlTop.Controls.Add(this.pnlSearchCombo);
            this.pnlTop.Controls.Add(this.label14);
            this.pnlTop.Controls.Add(this.label15);
            this.pnlTop.Controls.Add(this.label12);
            this.pnlTop.Controls.Add(this.label13);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(3);
            this.pnlTop.Size = new System.Drawing.Size(990, 189);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlSearchTIN_ID
            // 
            this.pnlSearchTIN_ID.Controls.Add(this.txtAHL_TIN);
            this.pnlSearchTIN_ID.Controls.Add(this.label16);
            this.pnlSearchTIN_ID.Controls.Add(this.label17);
            this.pnlSearchTIN_ID.Controls.Add(this.txtNPR_TIN);
            this.pnlSearchTIN_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchTIN_ID.Location = new System.Drawing.Point(4, 94);
            this.pnlSearchTIN_ID.Name = "pnlSearchTIN_ID";
            this.pnlSearchTIN_ID.Size = new System.Drawing.Size(982, 91);
            this.pnlSearchTIN_ID.TabIndex = 26;
            // 
            // txtAHL_TIN
            // 
            this.txtAHL_TIN.Location = new System.Drawing.Point(164, 4);
            this.txtAHL_TIN.Name = "txtAHL_TIN";
            this.txtAHL_TIN.Size = new System.Drawing.Size(260, 22);
            this.txtAHL_TIN.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(72, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 14);
            this.label16.TabIndex = 20;
            this.label16.Text = "AHL_TIN ID :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(603, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 14);
            this.label17.TabIndex = 22;
            this.label17.Text = "NPR_TIN ID :";
            this.label17.Visible = false;
            // 
            // txtNPR_TIN
            // 
            this.txtNPR_TIN.Location = new System.Drawing.Point(695, 5);
            this.txtNPR_TIN.Name = "txtNPR_TIN";
            this.txtNPR_TIN.Size = new System.Drawing.Size(260, 22);
            this.txtNPR_TIN.TabIndex = 21;
            this.txtNPR_TIN.Visible = false;
            // 
            // pnlSearchInformation
            // 
            this.pnlSearchInformation.Controls.Add(this.label4);
            this.pnlSearchInformation.Controls.Add(this.txtNameSearch);
            this.pnlSearchInformation.Controls.Add(this.label5);
            this.pnlSearchInformation.Controls.Add(this.txtMotherNameSearch);
            this.pnlSearchInformation.Controls.Add(this.label6);
            this.pnlSearchInformation.Controls.Add(this.txtNameSearch_P3);
            this.pnlSearchInformation.Controls.Add(this.txtFatherNameSearch);
            this.pnlSearchInformation.Controls.Add(this.txtNameSearch_P2);
            this.pnlSearchInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchInformation.Location = new System.Drawing.Point(4, 94);
            this.pnlSearchInformation.Name = "pnlSearchInformation";
            this.pnlSearchInformation.Size = new System.Drawing.Size(982, 91);
            this.pnlSearchInformation.TabIndex = 27;
            // 
            // txtNameSearch_P3
            // 
            this.txtNameSearch_P3.Location = new System.Drawing.Point(696, 4);
            this.txtNameSearch_P3.Name = "txtNameSearch_P3";
            this.txtNameSearch_P3.Size = new System.Drawing.Size(260, 22);
            this.txtNameSearch_P3.TabIndex = 6;
            // 
            // txtNameSearch_P2
            // 
            this.txtNameSearch_P2.Location = new System.Drawing.Point(430, 4);
            this.txtNameSearch_P2.Name = "txtNameSearch_P2";
            this.txtNameSearch_P2.Size = new System.Drawing.Size(260, 22);
            this.txtNameSearch_P2.TabIndex = 5;
            // 
            // pnlSearchRadio
            // 
            this.pnlSearchRadio.Controls.Add(this.rdInformation);
            this.pnlSearchRadio.Controls.Add(this.label18);
            this.pnlSearchRadio.Controls.Add(this.rdTINID);
            this.pnlSearchRadio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchRadio.Location = new System.Drawing.Point(4, 65);
            this.pnlSearchRadio.Name = "pnlSearchRadio";
            this.pnlSearchRadio.Size = new System.Drawing.Size(982, 29);
            this.pnlSearchRadio.TabIndex = 28;
            // 
            // rdInformation
            // 
            this.rdInformation.AutoSize = true;
            this.rdInformation.Location = new System.Drawing.Point(166, 5);
            this.rdInformation.Name = "rdInformation";
            this.rdInformation.Size = new System.Drawing.Size(98, 18);
            this.rdInformation.TabIndex = 24;
            this.rdInformation.TabStop = true;
            this.rdInformation.Tag = "0";
            this.rdInformation.Text = "Information";
            this.rdInformation.UseVisualStyleBackColor = true;
            this.rdInformation.CheckedChanged += new System.EventHandler(this.rdInformation_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(101, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 14);
            this.label18.TabIndex = 23;
            this.label18.Text = "Search :";
            // 
            // rdTINID
            // 
            this.rdTINID.AutoSize = true;
            this.rdTINID.Location = new System.Drawing.Point(315, 5);
            this.rdTINID.Name = "rdTINID";
            this.rdTINID.Size = new System.Drawing.Size(74, 18);
            this.rdTINID.TabIndex = 25;
            this.rdTINID.TabStop = true;
            this.rdTINID.Tag = "1";
            this.rdTINID.Text = "TIN ID\'s";
            this.rdTINID.UseVisualStyleBackColor = true;
            this.rdTINID.CheckedChanged += new System.EventHandler(this.rdTINID_CheckedChanged);
            // 
            // pnlSearchCombo
            // 
            this.pnlSearchCombo.Controls.Add(this.label7);
            this.pnlSearchCombo.Controls.Add(this.cmbTown);
            this.pnlSearchCombo.Controls.Add(this.label3);
            this.pnlSearchCombo.Controls.Add(this.label2);
            this.pnlSearchCombo.Controls.Add(this.cmbTaluka);
            this.pnlSearchCombo.Controls.Add(this.label1);
            this.pnlSearchCombo.Controls.Add(this.cmbGrampanchayat);
            this.pnlSearchCombo.Controls.Add(this.cmbGender);
            this.pnlSearchCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchCombo.Location = new System.Drawing.Point(4, 4);
            this.pnlSearchCombo.Name = "pnlSearchCombo";
            this.pnlSearchCombo.Size = new System.Drawing.Size(982, 61);
            this.pnlSearchCombo.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Taluka :";
            // 
            // cmbTaluka
            // 
            this.cmbTaluka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaluka.FormattingEnabled = true;
            this.cmbTaluka.Items.AddRange(new object[] {
            "All"});
            this.cmbTaluka.Location = new System.Drawing.Point(163, 8);
            this.cmbTaluka.Name = "cmbTaluka";
            this.cmbTaluka.Size = new System.Drawing.Size(260, 22);
            this.cmbTaluka.TabIndex = 0;
            this.cmbTaluka.SelectedIndexChanged += new System.EventHandler(this.cmbTaluka_SelectedIndexChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "ALL",
            "FEMALE",
            "MALE",
            "NA-0",
            "TRANSGENDER"});
            this.cmbGender.Location = new System.Drawing.Point(163, 36);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(260, 22);
            this.cmbGender.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label14.Location = new System.Drawing.Point(4, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(982, 1);
            this.label14.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(4, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(982, 1);
            this.label15.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1, 183);
            this.label12.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.Location = new System.Drawing.Point(986, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1, 183);
            this.label13.TabIndex = 14;
            // 
            // pnlToolstrip
            // 
            this.pnlToolstrip.AutoSize = true;
            this.pnlToolstrip.Controls.Add(this.toolStrip1);
            this.pnlToolstrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolstrip.Location = new System.Drawing.Point(0, 0);
            this.pnlToolstrip.Name = "pnlToolstrip";
            this.pnlToolstrip.Size = new System.Drawing.Size(990, 69);
            this.pnlToolstrip.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.btnClearSearchFields});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(990, 69);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 66);
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearchFields
            // 
            this.btnClearSearchFields.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearchFields.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSearchFields.Image")));
            this.btnClearSearchFields.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearSearchFields.Name = "btnClearSearchFields";
            this.btnClearSearchFields.Size = new System.Drawing.Size(52, 66);
            this.btnClearSearchFields.Text = "&Clear";
            this.btnClearSearchFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearSearchFields.Click += new System.EventHandler(this.btnClearSearchFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(990, 613);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlToolstrip);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlDataGrid.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlSearchTIN_ID.ResumeLayout(false);
            this.pnlSearchTIN_ID.PerformLayout();
            this.pnlSearchInformation.ResumeLayout(false);
            this.pnlSearchInformation.PerformLayout();
            this.pnlSearchRadio.ResumeLayout(false);
            this.pnlSearchRadio.PerformLayout();
            this.pnlSearchCombo.ResumeLayout(false);
            this.pnlSearchCombo.PerformLayout();
            this.pnlToolstrip.ResumeLayout(false);
            this.pnlToolstrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGrampanchayat;
        private System.Windows.Forms.ComboBox cmbTown;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TextBox txtMotherNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFatherNameSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtNameSearch_P3;
        private System.Windows.Forms.TextBox txtNameSearch_P2;
        private System.Windows.Forms.ComboBox cmbTaluka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNPR_TIN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAHL_TIN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rdTINID;
        private System.Windows.Forms.RadioButton rdInformation;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlSearchTIN_ID;
        private System.Windows.Forms.Panel pnlSearchInformation;
        private System.Windows.Forms.Panel pnlSearchRadio;
        private System.Windows.Forms.Panel pnlSearchCombo;
        private System.Windows.Forms.Panel pnlToolstrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnClearSearchFields;
    }
}

