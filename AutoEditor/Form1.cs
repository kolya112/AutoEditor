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
    public partial class Form1 : Form
    {
        public Form1(string sender = "")
        {
            InitializeComponent();
            if (sender != "this")
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
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goAdmins_Click(object sender, EventArgs e)
        {
            admins go = new admins();
            go.Show();
            this.Hide();
        }

        private void goLeaders_Click(object sender, EventArgs e)
        {
            leaders go = new leaders();
            go.Show();
            this.Hide();
        }

        private void goSupports_Click(object sender, EventArgs e)
        {
            supports go = new supports();
            go.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compiling c = new compiling();
            c.Show();
            this.Hide();
        }
    }
}
