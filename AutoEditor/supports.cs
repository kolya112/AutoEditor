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
    public partial class supports : Form
    {
        public supports()
        {
            InitializeComponent();
        }

        private void supports_FormClosing(object sender, FormClosingEventArgs e)
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

        private void supports_Load(object sender, EventArgs e)
        {

        }

        private void goHub_Click(object sender, EventArgs e)
        {
            Form1 hub = new Form1();
            hub.Show();
            this.Hide();
        }

        private void addRemove_Click(object sender, EventArgs e)
        {
            if (removeNick.Text != null)
            {
                if (reasonBox.SelectedItem != null)
                {
                    string localDirectory = Directory.GetCurrentDirectory();
                    Directory.CreateDirectory(localDirectory + "\\common\\storage");
                    StreamWriter adminsFile = File.AppendText(localDirectory + "\\common\\storage\\removeSupports.editor");
                    adminsFile.WriteLine($"{removeNick.Text}|{reasonBox.Text}");
                    adminsFile.Flush();
                    adminsFile.Close();
                    ListViewItem item = new ListViewItem(removeNick.Text, 0);
                    item.Checked = true;
                    item.SubItems.Add(reasonBox.Text);
                    removeSupports.Items.AddRange(new ListViewItem[] { item });
                }
                else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addInvite_Click(object sender, EventArgs e)
        {
            if (inviteNick.Text != null)
            {
                    string localDirectory = Directory.GetCurrentDirectory();
                    Directory.CreateDirectory(localDirectory + "\\common\\storage");
                    StreamWriter adminsFile = File.AppendText(localDirectory + "\\common\\storage\\inviteSupports.editor");
                    adminsFile.WriteLine($"{inviteNick.Text}");
                    adminsFile.Flush();
                    adminsFile.Close();
                    ListViewItem item = new ListViewItem(inviteNick.Text, 0);
                    item.Checked = true;
                    inviteSupports.Items.AddRange(new ListViewItem[] { item });
            }
            else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addTransfer_Click(object sender, EventArgs e)
        {
            if (transferNick.Text != null)
            {
                string localDirectory = Directory.GetCurrentDirectory();
                Directory.CreateDirectory(localDirectory + "\\common\\storage");
                StreamWriter adminsFile = File.AppendText(localDirectory + "\\common\\storage\\transferSupports.editor");
                adminsFile.WriteLine($"{transferNick.Text}");
                adminsFile.Flush();
                adminsFile.Close();
                ListViewItem item = new ListViewItem(transferNick.Text, 0);
                item.Checked = true;
                transferSupports.Items.AddRange(new ListViewItem[] { item });
            }
            else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
