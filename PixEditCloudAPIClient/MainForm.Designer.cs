
namespace PixEditCloudAPIClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubscriptionKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.Authenticate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cmbOutputFileFormat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkOutputFile = new System.Windows.Forms.LinkLabel();
            this.lblAuthenticated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(13, 41);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(663, 31);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "https://api.pixeditcloud.com/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 108);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 31);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(458, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 31);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Serial number";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(234, 108);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(218, 31);
            this.txtSerialNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subscription key";
            // 
            // txtSubscriptionKey
            // 
            this.txtSubscriptionKey.Location = new System.Drawing.Point(13, 175);
            this.txtSubscriptionKey.Name = "txtSubscriptionKey";
            this.txtSubscriptionKey.Size = new System.Drawing.Size(439, 31);
            this.txtSubscriptionKey.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "API Info";
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.SystemColors.Info;
            this.txtInfo.Location = new System.Drawing.Point(729, 41);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(382, 165);
            this.txtInfo.TabIndex = 11;
            // 
            // Authenticate
            // 
            this.Authenticate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Authenticate.Location = new System.Drawing.Point(459, 173);
            this.Authenticate.Name = "Authenticate";
            this.Authenticate.Size = new System.Drawing.Size(170, 34);
            this.Authenticate.TabIndex = 12;
            this.Authenticate.Text = "Authenticate";
            this.Authenticate.UseVisualStyleBackColor = true;
            this.Authenticate.Click += new System.EventHandler(this.Authenticate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(12, 418);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1099, 362);
            this.textBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(13, 268);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(439, 31);
            this.txtFileName.TabIndex = 15;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(459, 267);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(112, 34);
            this.btnBrowseFile.TabIndex = 16;
            this.btnBrowseFile.Text = "Browse...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(459, 333);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 34);
            this.btnConvert.TabIndex = 17;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cmbOutputFileFormat
            // 
            this.cmbOutputFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutputFileFormat.FormattingEnabled = true;
            this.cmbOutputFileFormat.Items.AddRange(new object[] {
            "PDF-A1b",
            "PDF-A2b",
            "PDF-A3b",
            "PDF"});
            this.cmbOutputFileFormat.Location = new System.Drawing.Point(13, 334);
            this.cmbOutputFileFormat.Name = "cmbOutputFileFormat";
            this.cmbOutputFileFormat.Size = new System.Drawing.Size(236, 33);
            this.cmbOutputFileFormat.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Output file format";
            // 
            // linkOutputFile
            // 
            this.linkOutputFile.AutoSize = true;
            this.linkOutputFile.Location = new System.Drawing.Point(12, 374);
            this.linkOutputFile.Name = "linkOutputFile";
            this.linkOutputFile.Size = new System.Drawing.Size(97, 25);
            this.linkOutputFile.TabIndex = 20;
            this.linkOutputFile.TabStop = true;
            this.linkOutputFile.Text = "Output file";
            this.linkOutputFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOutputFile_LinkClicked);
            // 
            // lblAuthenticated
            // 
            this.lblAuthenticated.AutoSize = true;
            this.lblAuthenticated.Location = new System.Drawing.Point(636, 176);
            this.lblAuthenticated.Name = "lblAuthenticated";
            this.lblAuthenticated.Size = new System.Drawing.Size(0, 25);
            this.lblAuthenticated.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 792);
            this.Controls.Add(this.lblAuthenticated);
            this.Controls.Add(this.linkOutputFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbOutputFileFormat);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Authenticate);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSubscriptionKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "PixEdit Cloud API Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubscriptionKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button Authenticate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cmbOutputFileFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkOutputFile;
        private System.Windows.Forms.Label lblAuthenticated;
    }
}

