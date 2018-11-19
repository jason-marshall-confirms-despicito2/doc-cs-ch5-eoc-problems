namespace Program5_3
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
            this.listOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(4, 4);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(277, 251);
            this.listOutput.TabIndex = 0;
            this.listOutput.SelectedIndexChanged += new System.EventHandler(this.listOutput_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listOutput);
            this.Name = "Form1";
            this.Text = "Program5_3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOutput;
    }
}

