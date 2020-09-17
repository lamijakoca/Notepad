namespace Notepad
{
    partial class FormAbout
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductVersion = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(209, 266);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(109, 34);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(35, 39);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(46, 17);
            this.ProductName.TabIndex = 1;
            this.ProductName.Text = "label1";
            // 
            // ProductVersion
            // 
            this.ProductVersion.AutoSize = true;
            this.ProductVersion.Location = new System.Drawing.Point(35, 106);
            this.ProductVersion.Name = "ProductVersion";
            this.ProductVersion.Size = new System.Drawing.Size(46, 17);
            this.ProductVersion.TabIndex = 2;
            this.ProductVersion.Text = "label2";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(35, 167);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(46, 17);
            this.Copyright.TabIndex = 3;
            this.Copyright.Text = "label3";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 359);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.ProductVersion);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductVersion;
        private System.Windows.Forms.Label Copyright;
    }
}