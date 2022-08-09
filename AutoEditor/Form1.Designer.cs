namespace AutoEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.goAdmins = new System.Windows.Forms.Button();
            this.goLeaders = new System.Windows.Forms.Button();
            this.goSupports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goAdmins
            // 
            this.goAdmins.Location = new System.Drawing.Point(362, 12);
            this.goAdmins.Name = "goAdmins";
            this.goAdmins.Size = new System.Drawing.Size(200, 47);
            this.goAdmins.TabIndex = 0;
            this.goAdmins.Text = "Перейти к редактированию администрации";
            this.goAdmins.UseVisualStyleBackColor = true;
            this.goAdmins.Click += new System.EventHandler(this.goAdmins_Click);
            // 
            // goLeaders
            // 
            this.goLeaders.Location = new System.Drawing.Point(362, 65);
            this.goLeaders.Name = "goLeaders";
            this.goLeaders.Size = new System.Drawing.Size(200, 47);
            this.goLeaders.TabIndex = 1;
            this.goLeaders.Text = "Перейти к редактированию лидеров";
            this.goLeaders.UseVisualStyleBackColor = true;
            this.goLeaders.Click += new System.EventHandler(this.goLeaders_Click);
            // 
            // goSupports
            // 
            this.goSupports.Location = new System.Drawing.Point(362, 118);
            this.goSupports.Name = "goSupports";
            this.goSupports.Size = new System.Drawing.Size(200, 47);
            this.goSupports.TabIndex = 2;
            this.goSupports.Text = "Перейти к редактированию игровых помощников\r\n";
            this.goSupports.UseVisualStyleBackColor = true;
            this.goSupports.Click += new System.EventHandler(this.goSupports_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 152);
            this.button1.TabIndex = 3;
            this.button1.Text = "Компиляция";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goSupports);
            this.Controls.Add(this.goLeaders);
            this.Controls.Add(this.goAdmins);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoEditor by kly";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goAdmins;
        private System.Windows.Forms.Button goLeaders;
        private System.Windows.Forms.Button goSupports;
        private System.Windows.Forms.Button button1;
    }
}

