using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEditor
{
    public partial class leaders : Form
    {
        public leaders()
        {
            InitializeComponent();
        }

        private void leaders_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] files = { "addLeaders.editor", "inviteSupports.editor", "removeAdmins.editor", "removeLeaders.editor", "removeSupports.editor", "transferLeaders.editor", "transferSupports.editor", "vostAdmins.editor" };
            try
            {
                foreach (string file in files)
                {
                    File.Delete(Directory.GetCurrentDirectory() + "\\common\\storage\\" + file);
                }
            }
            catch (IOException)
            {

            }
            Application.Exit();
        }

        private void goHub_Click(object sender, EventArgs e)
        {
            Form1 hub = new Form1("this");
            hub.Show();
            this.Hide();
        }

        private void addInvite_Click(object sender, EventArgs e)
        {
            if (inviteNick.Text != null)
            {
                if (inviteOrg.SelectedItem != null)
                {
                        string localDirectory = Directory.GetCurrentDirectory();
                        Directory.CreateDirectory(localDirectory + "\\common\\storage");
                        StreamWriter adminsFile = File.AppendText(localDirectory + "\\common\\storage\\addLeaders.editor");
                        adminsFile.WriteLine($"{inviteNick.Text}|{inviteOrg.Text}");
                        adminsFile.Flush();
                        adminsFile.Close();
                        ListViewItem item = new ListViewItem(inviteNick.Text, 0);
                        item.Checked = true;
                        item.SubItems.Add(inviteOrg.Text);
                        inviteLeaders.Items.AddRange(new ListViewItem[] { item });
                }
                else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addRemoveLeader_Click(object sender, EventArgs e)
        {
            if (nickText.Text != null)
            {
                if (orgBox.SelectedItem != null)
                {
                    if (reasonBox.SelectedItem != null)
                    {
                        string localDirectory = Directory.GetCurrentDirectory();
                        Directory.CreateDirectory(localDirectory + "\\common\\storage");
                        StreamWriter adminsFile = File.AppendText(localDirectory + "\\common\\storage\\removeLeaders.editor");
                        adminsFile.WriteLine($"{nickText.Text}|{orgBox.Text}|{reasonBox.Text}");
                        adminsFile.Flush();
                        adminsFile.Close();
                        ListViewItem item = new ListViewItem(nickText.Text, 0);
                        item.Checked = true;
                        item.SubItems.Add(orgBox.Text);
                        item.SubItems.Add(reasonBox.Text);
                        removeLeader.Items.AddRange(new ListViewItem[] { item });
                    }
                }
                else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addTransfer_Click(object sender, EventArgs e)
        {
            if (transferNick.Text != null)
            {
                if (transferOrg.SelectedItem != null)
                {
                    string localDirectory = Directory.GetCurrentDirectory();
                    Directory.CreateDirectory(localDirectory + "\\common\\storage");
                    StreamWriter adminsFile = File.AppendText(localDirectory + "\\common\\storage\\transferLeaders.editor");
                    adminsFile.WriteLine($"{transferNick.Text}|{transferOrg.Text}");
                    adminsFile.Flush();
                    adminsFile.Close();
                    ListViewItem item = new ListViewItem(transferNick.Text, 0);
                    item.Checked = true;
                    item.SubItems.Add(transferOrg.Text);
                    transferLeaders.Items.AddRange(new ListViewItem[] { item });
                }
                else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void leaders_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            compiling c = new compiling();
            c.Show();
        }
    }
}
