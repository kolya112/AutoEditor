namespace AutoEditor
{
    partial class compiling
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
            this.compiledText = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // compiledText
            // 
            this.compiledText.Location = new System.Drawing.Point(3, 53);
            this.compiledText.Multiline = true;
            this.compiledText.Name = "compiledText";
            this.compiledText.ReadOnly = true;
            this.compiledText.Size = new System.Drawing.Size(531, 515);
            this.compiledText.TabIndex = 1;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(3, 3);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(531, 44);
            this.status.TabIndex = 2;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // compiling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 580);
            this.Controls.Add(this.status);
            this.Controls.Add(this.compiledText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "compiling";
            this.Text = "Компиляция";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.compiling_FormClosing);
            this.Load += new System.EventHandler(this.compiling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox compiledText;
        private System.Windows.Forms.TextBox status;
    }
}