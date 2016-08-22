namespace PROJ_BPCL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnGo = new System.Windows.Forms.Button();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnServerClear = new System.Windows.Forms.Button();
            this.btnServerConnect = new System.Windows.Forms.Button();
            this.rdServerSQL = new System.Windows.Forms.RadioButton();
            this.rdServerWindows = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(133, 91);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(96, 27);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Generate";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtMachineName
            // 
            this.txtMachineName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineName.Location = new System.Drawing.Point(149, 27);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(182, 22);
            this.txtMachineName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Machine Name : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(149, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password : ";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(235, 91);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(57, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(308, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "* Mandatory Fields";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnServerClear);
            this.groupBox1.Controls.Add(this.btnServerConnect);
            this.groupBox1.Controls.Add(this.rdServerSQL);
            this.groupBox1.Controls.Add(this.rdServerWindows);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 178);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Details";
            this.groupBox1.Visible = false;
            // 
            // btnServerClear
            // 
            this.btnServerClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerClear.Location = new System.Drawing.Point(223, 136);
            this.btnServerClear.Name = "btnServerClear";
            this.btnServerClear.Size = new System.Drawing.Size(96, 27);
            this.btnServerClear.TabIndex = 20;
            this.btnServerClear.Text = "Clear";
            this.btnServerClear.UseVisualStyleBackColor = true;
            this.btnServerClear.Click += new System.EventHandler(this.btnServerClear_Click);
            // 
            // btnServerConnect
            // 
            this.btnServerConnect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerConnect.Location = new System.Drawing.Point(121, 136);
            this.btnServerConnect.Name = "btnServerConnect";
            this.btnServerConnect.Size = new System.Drawing.Size(96, 27);
            this.btnServerConnect.TabIndex = 19;
            this.btnServerConnect.Text = "Connect";
            this.btnServerConnect.UseVisualStyleBackColor = true;
            this.btnServerConnect.Click += new System.EventHandler(this.btnServerConnect_Click);
            // 
            // rdServerSQL
            // 
            this.rdServerSQL.AutoSize = true;
            this.rdServerSQL.Location = new System.Drawing.Point(234, 65);
            this.rdServerSQL.Name = "rdServerSQL";
            this.rdServerSQL.Size = new System.Drawing.Size(95, 18);
            this.rdServerSQL.TabIndex = 18;
            this.rdServerSQL.TabStop = true;
            this.rdServerSQL.Text = "SQL Server";
            this.rdServerSQL.UseVisualStyleBackColor = true;
            this.rdServerSQL.CheckedChanged += new System.EventHandler(this.rdServerSQL_CheckedChanged);
            // 
            // rdServerWindows
            // 
            this.rdServerWindows.AutoSize = true;
            this.rdServerWindows.Location = new System.Drawing.Point(121, 65);
            this.rdServerWindows.Name = "rdServerWindows";
            this.rdServerWindows.Size = new System.Drawing.Size(83, 18);
            this.rdServerWindows.TabIndex = 17;
            this.rdServerWindows.TabStop = true;
            this.rdServerWindows.Text = "Windows";
            this.rdServerWindows.UseVisualStyleBackColor = true;
            this.rdServerWindows.CheckedChanged += new System.EventHandler(this.rdServerWindows_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "Authentication : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(58, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Server : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(269, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(270, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Database : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(35, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Username : ";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(121, 27);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(145, 22);
            this.txtServer.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(121, 93);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 22);
            this.txtUsername.TabIndex = 13;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(357, 27);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(150, 22);
            this.txtDB.TabIndex = 14;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(357, 94);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(150, 22);
            this.txtPwd.TabIndex = 15;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 163);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.RadioButton rdServerSQL;
        private System.Windows.Forms.RadioButton rdServerWindows;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnServerClear;
        private System.Windows.Forms.Button btnServerConnect;
    }
}