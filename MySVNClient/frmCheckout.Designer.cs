namespace MySVNClient
{
    partial class frmCheckout
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
            this.lblRepoURI = new System.Windows.Forms.Label();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.tbRepoURI = new System.Windows.Forms.TextBox();
            this.tbLocalPath = new System.Windows.Forms.TextBox();
            this.tbRevision = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuthenticate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblRepoURI
            // 
            this.lblRepoURI.AutoSize = true;
            this.lblRepoURI.Location = new System.Drawing.Point(13, 12);
            this.lblRepoURI.Name = "lblRepoURI";
            this.lblRepoURI.Size = new System.Drawing.Size(82, 13);
            this.lblRepoURI.TabIndex = 0;
            this.lblRepoURI.Text = "Repository URI:";
            this.lblRepoURI.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.AutoSize = true;
            this.lblLocalPath.Location = new System.Drawing.Point(13, 44);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(58, 13);
            this.lblLocalPath.TabIndex = 1;
            this.lblLocalPath.Text = "Local Path";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(13, 74);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(48, 13);
            this.lblRevision.TabIndex = 2;
            this.lblRevision.Text = "Revision";
            // 
            // tbRepoURI
            // 
            this.tbRepoURI.Location = new System.Drawing.Point(124, 12);
            this.tbRepoURI.Name = "tbRepoURI";
            this.tbRepoURI.Size = new System.Drawing.Size(247, 20);
            this.tbRepoURI.TabIndex = 3;
            this.tbRepoURI.Text = "https://desktop-dpeig4a:8443/svn/Demo/BookStoreJava";
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.Location = new System.Drawing.Point(124, 44);
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.Size = new System.Drawing.Size(247, 20);
            this.tbLocalPath.TabIndex = 4;
            this.tbLocalPath.Text = "c:/svntemp";
            // 
            // tbRevision
            // 
            this.tbRevision.Location = new System.Drawing.Point(124, 74);
            this.tbRevision.Name = "tbRevision";
            this.tbRevision.Size = new System.Drawing.Size(76, 20);
            this.tbRevision.TabIndex = 5;
            this.tbRevision.Text = "e.g. 21";
            this.tbRevision.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(125, 198);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(124, 168);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 8;
            // 
            // textUserid
            // 
            this.textUserid.Location = new System.Drawing.Point(124, 129);
            this.textUserid.Name = "textUserid";
            this.textUserid.Size = new System.Drawing.Size(100, 20);
            this.textUserid.TabIndex = 9;
            this.textUserid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Userid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbAuthenticate
            // 
            this.cbAuthenticate.AutoSize = true;
            this.cbAuthenticate.Location = new System.Drawing.Point(124, 100);
            this.cbAuthenticate.Name = "cbAuthenticate";
            this.cbAuthenticate.Size = new System.Drawing.Size(86, 17);
            this.cbAuthenticate.TabIndex = 12;
            this.cbAuthenticate.Text = "Authenticate";
            this.cbAuthenticate.UseVisualStyleBackColor = true;
            this.cbAuthenticate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 261);
            this.Controls.Add(this.cbAuthenticate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUserid);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.tbRevision);
            this.Controls.Add(this.tbLocalPath);
            this.Controls.Add(this.tbRepoURI);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.lblLocalPath);
            this.Controls.Add(this.lblRepoURI);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepoURI;
        private System.Windows.Forms.Label lblLocalPath;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.TextBox tbRepoURI;
        private System.Windows.Forms.TextBox tbLocalPath;
        private System.Windows.Forms.TextBox tbRevision;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAuthenticate;
    }
}