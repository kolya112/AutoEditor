namespace AutoEditor
{
    partial class leaders
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
            this.addRemoveLeader = new System.Windows.Forms.Button();
            this.reasonBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nickText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.removeLeader = new System.Windows.Forms.ListView();
            this.nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.organization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reasonLeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orgBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addInvite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inviteNick = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inviteLeaders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inviteOrg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addTransfer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.transferNick = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.transferLeaders = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transferOrg = new System.Windows.Forms.ComboBox();
            this.goHub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addRemoveLeader
            // 
            this.addRemoveLeader.Location = new System.Drawing.Point(406, 112);
            this.addRemoveLeader.Name = "addRemoveLeader";
            this.addRemoveLeader.Size = new System.Drawing.Size(210, 34);
            this.addRemoveLeader.TabIndex = 29;
            this.addRemoveLeader.Text = "Добавить";
            this.addRemoveLeader.UseVisualStyleBackColor = true;
            this.addRemoveLeader.Click += new System.EventHandler(this.addRemoveLeader_Click);
            // 
            // reasonBox
            // 
            this.reasonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasonBox.FormattingEnabled = true;
            this.reasonBox.Items.AddRange(new object[] {
            "не справился",
            "собственное желание",
            "не разглашается"});
            this.reasonBox.Location = new System.Drawing.Point(462, 85);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(141, 21);
            this.reasonBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Причина:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Организация:";
            // 
            // nickText
            // 
            this.nickText.Location = new System.Drawing.Point(483, 31);
            this.nickText.MaxLength = 20;
            this.nickText.Name = "nickText";
            this.nickText.Size = new System.Drawing.Size(168, 20);
            this.nickText.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Игровой ник:";
            // 
            // removeLeader
            // 
            this.removeLeader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nickname,
            this.organization,
            this.reasonLeader});
            this.removeLeader.HideSelection = false;
            this.removeLeader.Location = new System.Drawing.Point(12, 31);
            this.removeLeader.Name = "removeLeader";
            this.removeLeader.Size = new System.Drawing.Size(388, 124);
            this.removeLeader.TabIndex = 23;
            this.removeLeader.UseCompatibleStateImageBehavior = false;
            this.removeLeader.View = System.Windows.Forms.View.Details;
            // 
            // nickname
            // 
            this.nickname.Text = "Игровой ник";
            this.nickname.Width = 122;
            // 
            // organization
            // 
            this.organization.Text = "Организация";
            this.organization.Width = 120;
            // 
            // reasonLeader
            // 
            this.reasonLeader.Text = "Причина";
            this.reasonLeader.Width = 141;
            // 
            // orgBox
            // 
            this.orgBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgBox.FormattingEnabled = true;
            this.orgBox.Items.AddRange(new object[] {
            "\"Правительство\"",
            "\"Армия России\"",
            "ГТРК \"Ритм\"",
            "\"Городская больница\"",
            "\"МВД\"",
            "\"ФСБ\"",
            "\"МЧС\""});
            this.orgBox.Location = new System.Drawing.Point(486, 58);
            this.orgBox.Name = "orgBox";
            this.orgBox.Size = new System.Drawing.Size(130, 21);
            this.orgBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Снятые лидеры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Поставленные лидеры:";
            // 
            // addInvite
            // 
            this.addInvite.Location = new System.Drawing.Point(406, 240);
            this.addInvite.Name = "addInvite";
            this.addInvite.Size = new System.Drawing.Size(210, 34);
            this.addInvite.TabIndex = 38;
            this.addInvite.Text = "Добавить";
            this.addInvite.UseVisualStyleBackColor = true;
            this.addInvite.Click += new System.EventHandler(this.addInvite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Организация:";
            // 
            // inviteNick
            // 
            this.inviteNick.Location = new System.Drawing.Point(483, 186);
            this.inviteNick.MaxLength = 20;
            this.inviteNick.Name = "inviteNick";
            this.inviteNick.Size = new System.Drawing.Size(168, 20);
            this.inviteNick.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Игровой ник:";
            // 
            // inviteLeaders
            // 
            this.inviteLeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.inviteLeaders.HideSelection = false;
            this.inviteLeaders.Location = new System.Drawing.Point(12, 186);
            this.inviteLeaders.Name = "inviteLeaders";
            this.inviteLeaders.Size = new System.Drawing.Size(388, 124);
            this.inviteLeaders.TabIndex = 32;
            this.inviteLeaders.UseCompatibleStateImageBehavior = false;
            this.inviteLeaders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Игровой ник";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Организация";
            this.columnHeader2.Width = 212;
            // 
            // inviteOrg
            // 
            this.inviteOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inviteOrg.FormattingEnabled = true;
            this.inviteOrg.Items.AddRange(new object[] {
            "\"Правительство\"",
            "\"Армия России\"",
            "ГТРК \"Ритм\"",
            "\"Городская больница\"",
            "\"МВД\"",
            "\"ФСБ\"",
            "\"МЧС\""});
            this.inviteOrg.Location = new System.Drawing.Point(486, 213);
            this.inviteOrg.Name = "inviteOrg";
            this.inviteOrg.Size = new System.Drawing.Size(130, 21);
            this.inviteOrg.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Переведенные лидеры:";
            // 
            // addTransfer
            // 
            this.addTransfer.Location = new System.Drawing.Point(406, 393);
            this.addTransfer.Name = "addTransfer";
            this.addTransfer.Size = new System.Drawing.Size(210, 34);
            this.addTransfer.TabIndex = 45;
            this.addTransfer.Text = "Добавить";
            this.addTransfer.UseVisualStyleBackColor = true;
            this.addTransfer.Click += new System.EventHandler(this.addTransfer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Организация:";
            // 
            // transferNick
            // 
            this.transferNick.Location = new System.Drawing.Point(483, 339);
            this.transferNick.MaxLength = 20;
            this.transferNick.Name = "transferNick";
            this.transferNick.Size = new System.Drawing.Size(168, 20);
            this.transferNick.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Игровой ник:";
            // 
            // transferLeaders
            // 
            this.transferLeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.transferLeaders.HideSelection = false;
            this.transferLeaders.Location = new System.Drawing.Point(12, 339);
            this.transferLeaders.Name = "transferLeaders";
            this.transferLeaders.Size = new System.Drawing.Size(388, 124);
            this.transferLeaders.TabIndex = 41;
            this.transferLeaders.UseCompatibleStateImageBehavior = false;
            this.transferLeaders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Игровой ник";
            this.columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Организация";
            this.columnHeader4.Width = 212;
            // 
            // transferOrg
            // 
            this.transferOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transferOrg.FormattingEnabled = true;
            this.transferOrg.Items.AddRange(new object[] {
            "\"Правительство\"",
            "\"Армия России\"",
            "ГТРК \"Ритм\"",
            "\"Городская больница\"",
            "\"МВД\"",
            "\"ФСБ\"",
            "\"МЧС\""});
            this.transferOrg.Location = new System.Drawing.Point(486, 366);
            this.transferOrg.Name = "transferOrg";
            this.transferOrg.Size = new System.Drawing.Size(130, 21);
            this.transferOrg.TabIndex = 40;
            // 
            // goHub
            // 
            this.goHub.Location = new System.Drawing.Point(188, 469);
            this.goHub.Name = "goHub";
            this.goHub.Size = new System.Drawing.Size(334, 65);
            this.goHub.TabIndex = 47;
            this.goHub.Text = "Назад в Hub";
            this.goHub.UseVisualStyleBackColor = true;
            this.goHub.Click += new System.EventHandler(this.goHub_Click);
            // 
            // leaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 546);
            this.Controls.Add(this.goHub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addTransfer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.transferNick);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.transferLeaders);
            this.Controls.Add(this.transferOrg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addInvite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inviteNick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inviteLeaders);
            this.Controls.Add(this.inviteOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRemoveLeader);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nickText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeLeader);
            this.Controls.Add(this.orgBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "leaders";
            this.Text = "Лидеры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.leaders_FormClosing);
            this.Load += new System.EventHandler(this.leaders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRemoveLeader;
        private System.Windows.Forms.ComboBox reasonBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nickText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView removeLeader;
        private System.Windows.Forms.ColumnHeader nickname;
        private System.Windows.Forms.ColumnHeader organization;
        private System.Windows.Forms.ComboBox orgBox;
        private System.Windows.Forms.ColumnHeader reasonLeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addInvite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inviteNick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView inviteLeaders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox inviteOrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addTransfer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox transferNick;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView transferLeaders;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox transferOrg;
        private System.Windows.Forms.Button goHub;
    }
}