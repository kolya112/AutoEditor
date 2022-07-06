namespace AutoEditor
{
    partial class supports
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
            this.goHub = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addTransfer = new System.Windows.Forms.Button();
            this.transferNick = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.transferSupports = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.addInvite = new System.Windows.Forms.Button();
            this.inviteNick = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inviteSupports = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.addRemove = new System.Windows.Forms.Button();
            this.reasonBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.removeNick = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.removeSupports = new System.Windows.Forms.ListView();
            this.nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reasonLeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goHub
            // 
            this.goHub.Location = new System.Drawing.Point(183, 463);
            this.goHub.Name = "goHub";
            this.goHub.Size = new System.Drawing.Size(334, 65);
            this.goHub.TabIndex = 71;
            this.goHub.Text = "Назад в Hub";
            this.goHub.UseVisualStyleBackColor = true;
            this.goHub.Click += new System.EventHandler(this.goHub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Переведенные игровые помощники:\r\n";
            // 
            // addTransfer
            // 
            this.addTransfer.Location = new System.Drawing.Point(406, 359);
            this.addTransfer.Name = "addTransfer";
            this.addTransfer.Size = new System.Drawing.Size(210, 34);
            this.addTransfer.TabIndex = 69;
            this.addTransfer.Text = "Добавить";
            this.addTransfer.UseVisualStyleBackColor = true;
            this.addTransfer.Click += new System.EventHandler(this.addTransfer_Click);
            // 
            // transferNick
            // 
            this.transferNick.Location = new System.Drawing.Point(483, 333);
            this.transferNick.MaxLength = 20;
            this.transferNick.Name = "transferNick";
            this.transferNick.Size = new System.Drawing.Size(168, 20);
            this.transferNick.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Игровой ник:";
            // 
            // transferSupports
            // 
            this.transferSupports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.transferSupports.HideSelection = false;
            this.transferSupports.Location = new System.Drawing.Point(12, 333);
            this.transferSupports.Name = "transferSupports";
            this.transferSupports.Size = new System.Drawing.Size(388, 124);
            this.transferSupports.TabIndex = 65;
            this.transferSupports.UseCompatibleStateImageBehavior = false;
            this.transferSupports.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Игровой ник";
            this.columnHeader3.Width = 384;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Поставленные игровые помощники:\r\n";
            // 
            // addInvite
            // 
            this.addInvite.Location = new System.Drawing.Point(406, 206);
            this.addInvite.Name = "addInvite";
            this.addInvite.Size = new System.Drawing.Size(210, 34);
            this.addInvite.TabIndex = 62;
            this.addInvite.Text = "Добавить";
            this.addInvite.UseVisualStyleBackColor = true;
            this.addInvite.Click += new System.EventHandler(this.addInvite_Click);
            // 
            // inviteNick
            // 
            this.inviteNick.Location = new System.Drawing.Point(483, 180);
            this.inviteNick.MaxLength = 20;
            this.inviteNick.Name = "inviteNick";
            this.inviteNick.Size = new System.Drawing.Size(168, 20);
            this.inviteNick.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Игровой ник:";
            // 
            // inviteSupports
            // 
            this.inviteSupports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.inviteSupports.HideSelection = false;
            this.inviteSupports.Location = new System.Drawing.Point(12, 180);
            this.inviteSupports.Name = "inviteSupports";
            this.inviteSupports.Size = new System.Drawing.Size(388, 124);
            this.inviteSupports.TabIndex = 58;
            this.inviteSupports.UseCompatibleStateImageBehavior = false;
            this.inviteSupports.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Игровой ник";
            this.columnHeader1.Width = 384;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, -37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Снятые лидеры:";
            // 
            // addRemove
            // 
            this.addRemove.Location = new System.Drawing.Point(406, 76);
            this.addRemove.Name = "addRemove";
            this.addRemove.Size = new System.Drawing.Size(210, 34);
            this.addRemove.TabIndex = 55;
            this.addRemove.Text = "Добавить";
            this.addRemove.UseVisualStyleBackColor = true;
            this.addRemove.Click += new System.EventHandler(this.addRemove_Click);
            // 
            // reasonBox
            // 
            this.reasonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasonBox.FormattingEnabled = true;
            this.reasonBox.Items.AddRange(new object[] {
            "не справился",
            "собственное желание",
            "не разглашается"});
            this.reasonBox.Location = new System.Drawing.Point(465, 49);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(141, 21);
            this.reasonBox.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Причина:";
            // 
            // removeNick
            // 
            this.removeNick.Location = new System.Drawing.Point(483, 25);
            this.removeNick.MaxLength = 20;
            this.removeNick.Name = "removeNick";
            this.removeNick.Size = new System.Drawing.Size(168, 20);
            this.removeNick.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Игровой ник:";
            // 
            // removeSupports
            // 
            this.removeSupports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nickname,
            this.reasonLeader});
            this.removeSupports.HideSelection = false;
            this.removeSupports.Location = new System.Drawing.Point(12, 25);
            this.removeSupports.Name = "removeSupports";
            this.removeSupports.Size = new System.Drawing.Size(388, 124);
            this.removeSupports.TabIndex = 49;
            this.removeSupports.UseCompatibleStateImageBehavior = false;
            this.removeSupports.View = System.Windows.Forms.View.Details;
            // 
            // nickname
            // 
            this.nickname.Text = "Игровой ник";
            this.nickname.Width = 194;
            // 
            // reasonLeader
            // 
            this.reasonLeader.Text = "Причина";
            this.reasonLeader.Width = 189;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Снятые игровые помощники:";
            // 
            // supports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 540);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.goHub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addTransfer);
            this.Controls.Add(this.transferNick);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.transferSupports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addInvite);
            this.Controls.Add(this.inviteNick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inviteSupports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRemove);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.removeNick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeSupports);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "supports";
            this.Text = "Игровые помощники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.supports_FormClosing);
            this.Load += new System.EventHandler(this.supports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goHub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addTransfer;
        private System.Windows.Forms.TextBox transferNick;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView transferSupports;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addInvite;
        private System.Windows.Forms.TextBox inviteNick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView inviteSupports;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRemove;
        private System.Windows.Forms.ComboBox reasonBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox removeNick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView removeSupports;
        private System.Windows.Forms.ColumnHeader nickname;
        private System.Windows.Forms.ColumnHeader reasonLeader;
        private System.Windows.Forms.Label label11;
    }
}