namespace NetworkCURD
{
    partial class NetworkForm
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
            this.NetCodeLb = new System.Windows.Forms.Label();
            this.AffiliationLb = new System.Windows.Forms.Label();
            this.ConfigurationLb = new System.Windows.Forms.Label();
            this.NetCodeTxt = new System.Windows.Forms.TextBox();
            this.AffiliactionTxt = new System.Windows.Forms.TextBox();
            this.Createbtn = new System.Windows.Forms.Button();
            this.UpDateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.NetworkdataGridView = new System.Windows.Forms.DataGridView();
            this.ResertBTN = new System.Windows.Forms.Button();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.browseTXT = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.ConfigurationTxt = new System.Windows.Forms.TextBox();
            this.groupBoxDoDates = new System.Windows.Forms.GroupBox();
            this.groupBoxFullRoster = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NetworkdataGridView)).BeginInit();
            this.groupBoxDoDates.SuspendLayout();
            this.groupBoxFullRoster.SuspendLayout();
            this.SuspendLayout();
            // 
            // NetCodeLb
            // 
            this.NetCodeLb.AutoSize = true;
            this.NetCodeLb.Location = new System.Drawing.Point(9, 7);
            this.NetCodeLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NetCodeLb.Name = "NetCodeLb";
            this.NetCodeLb.Size = new System.Drawing.Size(53, 13);
            this.NetCodeLb.TabIndex = 0;
            this.NetCodeLb.Text = "NetCode*";
            // 
            // AffiliationLb
            // 
            this.AffiliationLb.AutoSize = true;
            this.AffiliationLb.Location = new System.Drawing.Point(7, 28);
            this.AffiliationLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AffiliationLb.Name = "AffiliationLb";
            this.AffiliationLb.Size = new System.Drawing.Size(53, 13);
            this.AffiliationLb.TabIndex = 0;
            this.AffiliationLb.Text = "Affiliation*";
            // 
            // ConfigurationLb
            // 
            this.ConfigurationLb.AutoSize = true;
            this.ConfigurationLb.Location = new System.Drawing.Point(236, 7);
            this.ConfigurationLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfigurationLb.Name = "ConfigurationLb";
            this.ConfigurationLb.Size = new System.Drawing.Size(69, 13);
            this.ConfigurationLb.TabIndex = 0;
            this.ConfigurationLb.Text = "Configuration";
            // 
            // NetCodeTxt
            // 
            this.NetCodeTxt.Location = new System.Drawing.Point(91, 5);
            this.NetCodeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NetCodeTxt.Name = "NetCodeTxt";
            this.NetCodeTxt.Size = new System.Drawing.Size(122, 20);
            this.NetCodeTxt.TabIndex = 0;
            // 
            // AffiliactionTxt
            // 
            this.AffiliactionTxt.Location = new System.Drawing.Point(91, 28);
            this.AffiliactionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AffiliactionTxt.Name = "AffiliactionTxt";
            this.AffiliactionTxt.Size = new System.Drawing.Size(122, 20);
            this.AffiliactionTxt.TabIndex = 1;
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Createbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Createbtn.Location = new System.Drawing.Point(9, 127);
            this.Createbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(56, 19);
            this.Createbtn.TabIndex = 5;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = false;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // UpDateBTN
            // 
            this.UpDateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UpDateBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpDateBTN.Location = new System.Drawing.Point(81, 127);
            this.UpDateBTN.Margin = new System.Windows.Forms.Padding(2);
            this.UpDateBTN.Name = "UpDateBTN";
            this.UpDateBTN.Size = new System.Drawing.Size(56, 19);
            this.UpDateBTN.TabIndex = 6;
            this.UpDateBTN.Text = "Update";
            this.UpDateBTN.UseVisualStyleBackColor = false;
            this.UpDateBTN.Click += new System.EventHandler(this.UpDateBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.Red;
            this.DeleteBTN.Location = new System.Drawing.Point(156, 127);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(56, 19);
            this.DeleteBTN.TabIndex = 7;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // NetworkdataGridView
            // 
            this.NetworkdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NetworkdataGridView.Location = new System.Drawing.Point(11, 209);
            this.NetworkdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.NetworkdataGridView.Name = "NetworkdataGridView";
            this.NetworkdataGridView.RowHeadersWidth = 51;
            this.NetworkdataGridView.RowTemplate.Height = 24;
            this.NetworkdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NetworkdataGridView.Size = new System.Drawing.Size(947, 259);
            this.NetworkdataGridView.TabIndex = 6;
            this.NetworkdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NetworkdataGridView_CellClick);
            this.NetworkdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NetworkdataGridView_CellContentClick);
            // 
            // ResertBTN
            // 
            this.ResertBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ResertBTN.Location = new System.Drawing.Point(228, 127);
            this.ResertBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ResertBTN.Name = "ResertBTN";
            this.ResertBTN.Size = new System.Drawing.Size(56, 19);
            this.ResertBTN.TabIndex = 9;
            this.ResertBTN.Text = "Reset";
            this.ResertBTN.UseVisualStyleBackColor = false;
            this.ResertBTN.Click += new System.EventHandler(this.ResertBTN_Click);
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BrowseBTN.Location = new System.Drawing.Point(736, 174);
            this.BrowseBTN.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(56, 19);
            this.BrowseBTN.TabIndex = 10;
            this.BrowseBTN.Text = "Browse ";
            this.BrowseBTN.UseVisualStyleBackColor = false;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // browseTXT
            // 
            this.browseTXT.Location = new System.Drawing.Point(796, 174);
            this.browseTXT.Margin = new System.Windows.Forms.Padding(2);
            this.browseTXT.Name = "browseTXT";
            this.browseTXT.Size = new System.Drawing.Size(161, 20);
            this.browseTXT.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 17);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "True";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(80, 17);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "False";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 17);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "True";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(64, 17);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 17);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "False";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // ConfigurationTxt
            // 
            this.ConfigurationTxt.Location = new System.Drawing.Point(310, 5);
            this.ConfigurationTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ConfigurationTxt.Multiline = true;
            this.ConfigurationTxt.Name = "ConfigurationTxt";
            this.ConfigurationTxt.Size = new System.Drawing.Size(648, 165);
            this.ConfigurationTxt.TabIndex = 1;
            // 
            // groupBoxDoDates
            // 
            this.groupBoxDoDates.Controls.Add(this.radioButton2);
            this.groupBoxDoDates.Controls.Add(this.radioButton1);
            this.groupBoxDoDates.Location = new System.Drawing.Point(11, 61);
            this.groupBoxDoDates.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDoDates.Name = "groupBoxDoDates";
            this.groupBoxDoDates.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDoDates.Size = new System.Drawing.Size(136, 42);
            this.groupBoxDoDates.TabIndex = 12;
            this.groupBoxDoDates.TabStop = false;
            this.groupBoxDoDates.Text = "DoDates";
            this.groupBoxDoDates.Enter += new System.EventHandler(this.groupBoxDoDates_Enter);
            // 
            // groupBoxFullRoster
            // 
            this.groupBoxFullRoster.Controls.Add(this.radioButton3);
            this.groupBoxFullRoster.Controls.Add(this.radioButton4);
            this.groupBoxFullRoster.Location = new System.Drawing.Point(152, 61);
            this.groupBoxFullRoster.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFullRoster.Name = "groupBoxFullRoster";
            this.groupBoxFullRoster.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFullRoster.Size = new System.Drawing.Size(133, 42);
            this.groupBoxFullRoster.TabIndex = 13;
            this.groupBoxFullRoster.TabStop = false;
            this.groupBoxFullRoster.Text = "FullRoster";
            this.groupBoxFullRoster.Enter += new System.EventHandler(this.groupBoxFullRoster_Enter);
            // 
            // NetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 674);
            this.Controls.Add(this.groupBoxFullRoster);
            this.Controls.Add(this.groupBoxDoDates);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.ResertBTN);
            this.Controls.Add(this.NetworkdataGridView);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.UpDateBTN);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.ConfigurationTxt);
            this.Controls.Add(this.browseTXT);
            this.Controls.Add(this.AffiliactionTxt);
            this.Controls.Add(this.NetCodeTxt);
            this.Controls.Add(this.ConfigurationLb);
            this.Controls.Add(this.AffiliationLb);
            this.Controls.Add(this.NetCodeLb);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NetworkForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NetworkdataGridView)).EndInit();
            this.groupBoxDoDates.ResumeLayout(false);
            this.groupBoxDoDates.PerformLayout();
            this.groupBoxFullRoster.ResumeLayout(false);
            this.groupBoxFullRoster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NetCodeLb;
        private System.Windows.Forms.Label AffiliationLb;
        private System.Windows.Forms.Label ConfigurationLb;
        private System.Windows.Forms.TextBox NetCodeTxt;
        private System.Windows.Forms.TextBox AffiliactionTxt;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button UpDateBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.DataGridView NetworkdataGridView;
        private System.Windows.Forms.Button ResertBTN;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.TextBox browseTXT;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox ConfigurationTxt;
        private System.Windows.Forms.GroupBox groupBoxDoDates;
        private System.Windows.Forms.GroupBox groupBoxFullRoster;
    }
}

