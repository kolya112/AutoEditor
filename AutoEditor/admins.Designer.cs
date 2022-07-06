namespace AutoEditor
{
    partial class admins
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
            this.addRemoveAdmin = new System.Windows.Forms.Button();
            this.reasonBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nickText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeadmins = new System.Windows.Forms.ListView();
            this.nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlBox = new System.Windows.Forms.ComboBox();
            this.addVostAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.vostNickBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vostAdmin = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vostLvlBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.goHub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addRemoveAdmin
            // 
            this.addRemoveAdmin.Location = new System.Drawing.Point(403, 120);
            this.addRemoveAdmin.Name = "addRemoveAdmin";
            this.addRemoveAdmin.Size = new System.Drawing.Size(210, 34);
            this.addRemoveAdmin.TabIndex = 21;
            this.addRemoveAdmin.Text = "Добавить";
            this.addRemoveAdmin.UseVisualStyleBackColor = true;
            this.addRemoveAdmin.Click += new System.EventHandler(this.addRemoveAdmin_Click);
            // 
            // reasonBox
            // 
            this.reasonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasonBox.FormattingEnabled = true;
            this.reasonBox.Items.AddRange(new object[] {
            "не справился",
            "собственное желание",
            "не разглашается"});
            this.reasonBox.Location = new System.Drawing.Point(459, 93);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(141, 21);
            this.reasonBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Причина:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Админ-уровень:";
            // 
            // nickText
            // 
            this.nickText.Location = new System.Drawing.Point(480, 39);
            this.nickText.MaxLength = 20;
            this.nickText.Name = "nickText";
            this.nickText.Size = new System.Drawing.Size(168, 20);
            this.nickText.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Игровой ник:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Снятые админы";
            // 
            // removeadmins
            // 
            this.removeadmins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nickname,
            this.lvl,
            this.reason});
            this.removeadmins.HideSelection = false;
            this.removeadmins.Location = new System.Drawing.Point(9, 39);
            this.removeadmins.Name = "removeadmins";
            this.removeadmins.Size = new System.Drawing.Size(388, 124);
            this.removeadmins.TabIndex = 14;
            this.removeadmins.UseCompatibleStateImageBehavior = false;
            this.removeadmins.View = System.Windows.Forms.View.Details;
            // 
            // nickname
            // 
            this.nickname.Text = "Игровой ник";
            this.nickname.Width = 122;
            // 
            // lvl
            // 
            this.lvl.Text = "Админ-уровень";
            this.lvl.Width = 91;
            // 
            // reason
            // 
            this.reason.Text = "Причина";
            this.reason.Width = 171;
            // 
            // lvlBox
            // 
            this.lvlBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lvlBox.FormattingEnabled = true;
            this.lvlBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.lvlBox.Location = new System.Drawing.Point(493, 66);
            this.lvlBox.Name = "lvlBox";
            this.lvlBox.Size = new System.Drawing.Size(36, 21);
            this.lvlBox.TabIndex = 13;
            // 
            // addVostAdmin
            // 
            this.addVostAdmin.Location = new System.Drawing.Point(403, 244);
            this.addVostAdmin.Name = "addVostAdmin";
            this.addVostAdmin.Size = new System.Drawing.Size(210, 34);
            this.addVostAdmin.TabIndex = 29;
            this.addVostAdmin.Text = "Добавить";
            this.addVostAdmin.UseVisualStyleBackColor = true;
            this.addVostAdmin.Click += new System.EventHandler(this.addVostAdmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Админ-уровень:";
            // 
            // vostNickBox
            // 
            this.vostNickBox.Location = new System.Drawing.Point(480, 190);
            this.vostNickBox.MaxLength = 20;
            this.vostNickBox.Name = "vostNickBox";
            this.vostNickBox.Size = new System.Drawing.Size(168, 20);
            this.vostNickBox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Игровой ник:";
            // 
            // vostAdmin
            // 
            this.vostAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.vostAdmin.HideSelection = false;
            this.vostAdmin.Location = new System.Drawing.Point(9, 190);
            this.vostAdmin.Name = "vostAdmin";
            this.vostAdmin.Size = new System.Drawing.Size(388, 124);
            this.vostAdmin.TabIndex = 23;
            this.vostAdmin.UseCompatibleStateImageBehavior = false;
            this.vostAdmin.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Игровой ник";
            this.columnHeader1.Width = 293;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Админ-уровень";
            this.columnHeader2.Width = 91;
            // 
            // vostLvlBox
            // 
            this.vostLvlBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vostLvlBox.FormattingEnabled = true;
            this.vostLvlBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.vostLvlBox.Location = new System.Drawing.Point(493, 217);
            this.vostLvlBox.Name = "vostLvlBox";
            this.vostLvlBox.Size = new System.Drawing.Size(36, 21);
            this.vostLvlBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Восстановленные админы";
            // 
            // goHub
            // 
            this.goHub.Location = new System.Drawing.Point(232, 356);
            this.goHub.Name = "goHub";
            this.goHub.Size = new System.Drawing.Size(221, 60);
            this.goHub.TabIndex = 39;
            this.goHub.Text = "Назад в Hub";
            this.goHub.UseVisualStyleBackColor = true;
            this.goHub.Click += new System.EventHandler(this.goHub_Click);
            // 
            // admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 468);
            this.Controls.Add(this.goHub);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addVostAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vostNickBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vostAdmin);
            this.Controls.Add(this.vostLvlBox);
            this.Controls.Add(this.addRemoveAdmin);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nickText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeadmins);
            this.Controls.Add(this.lvlBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admins";
            this.Text = "Администрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admins_FormClosing);
            this.Load += new System.EventHandler(this.admins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRemoveAdmin;
        private System.Windows.Forms.ComboBox reasonBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nickText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView removeadmins;
        private System.Windows.Forms.ColumnHeader nickname;
        private System.Windows.Forms.ColumnHeader lvl;
        private System.Windows.Forms.ColumnHeader reason;
        private System.Windows.Forms.ComboBox lvlBox;
        private System.Windows.Forms.Button addVostAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vostNickBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView vostAdmin;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox vostLvlBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button goHub;
    }
}