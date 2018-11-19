namespace Program5_5
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
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(13, 13);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(84, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Number of days:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(94, 13);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 1;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(13, 43);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(259, 199);
            this.listOutput.TabIndex = 2;
            this.listOutput.SelectedIndexChanged += new System.EventHandler(this.listOutput_SelectedIndexChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(201, 13);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(71, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDays);
            this.Name = "Form1";
            this.Text = "Program5_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.Button btnDisplay;
    }
}

