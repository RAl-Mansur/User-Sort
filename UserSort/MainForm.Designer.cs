namespace UserSort
{
    partial class MainForm
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(27, 26);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(107, 31);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Data";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(27, 91);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(745, 292);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(140, 26);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(111, 30);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import Files";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 395);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnSelect);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Sort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnImport;
    }
}

