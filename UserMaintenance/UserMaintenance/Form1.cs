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
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<user> users = new BindingList<user>();
        public Form1()
        {
            InitializeComponent();
            {
                InitializeComponent();
                label1.Text = Resource1.FullName;

                button1.Text = Resource1.Add;
                button2.Text = Resource1.SaveFile;
                button3.Text = Resource1.Delete;





                listBox1.DataSource = users;
                listBox1.ValueMember = "ID";
                listBox1.DisplayMember = "FullName";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new user()
            {
                FullName = textBox1.Text

            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
          

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var u in users)
                {
                    sw.Write(u.ID);
                    sw.Write(";");
                    sw.Write(u.FullName);
                    sw.WriteLine();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            var id = listBox1.SelectedValue;
            var torles = from u in users
                         where u.ID.Equals(id)
                         select u;
            users.Remove(torles.FirstOrDefault());
        }
    }
}
