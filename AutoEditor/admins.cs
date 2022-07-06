using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoEditor
{
    public partial class admins : Form
    {
        public admins()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addRemoveAdmin_Click(object sender, EventArgs e)
        {
            if (nickText.Text != null)
            {
                if (lvlBox.SelectedItem != null)
                {
                    if (reasonBox.SelectedItem != null)
                    {
                        string localDirectory = Directory.GetCurrentDirectory();
                        Directory.CreateDirectory(localDirectory + "\\common\\storage");
                        StreamWriter adminsFile = File.AppendText(localDirectory + "\\common\\storage\\removeAdmins.editor");
                        adminsFile.WriteLine($"{nickText.Text}|{lvlBox.Text}|{reasonBox.Text}");
                        adminsFile.Flush();
                        adminsFile.Close();
                        ListViewItem item = new ListViewItem(nickText.Text, 0);
                        item.Checked = true;
                        item.SubItems.Add(lvlBox.Text);
                        item.SubItems.Add(reasonBox.Text);
                        removeadmins.Items.AddRange(new ListViewItem[] { item });
                    }
                    else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addVostAdmin_Click(object sender, EventArgs e)
        {
            if (vostNickBox.Text != null)
            {
                if (vostLvlBox.SelectedItem != null)
                {
                    string localDirectory = Directory.GetCurrentDirectory();
                    Directory.CreateDirectory(localDirectory + "\\common\\storage");
                    StreamWriter adminsFile = File.AppendText(localDirectory + "\\common\\storage\\vostAdmins.editor");
                    adminsFile.WriteLine($"{vostNickBox.Text}|{vostLvlBox.Text}");
                    adminsFile.Flush();
                    adminsFile.Close();
                    ListViewItem item = new ListViewItem(vostNickBox.Text, 0);
                    item.Checked = true;
                    item.SubItems.Add(vostLvlBox.Text);
                    vostAdmin.Items.AddRange(new ListViewItem[] { item });
                }
                else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Что ты делаешь? Поле пустое!", "Упс, произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void admins_FormClosing(object sender, FormClosingEventArgs e)
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
            Form1 hub = new Form1();
            hub.Show();
            this.Hide();
        }

        private void admins_Load(object sender, EventArgs e)
        {

        }
    }
}
