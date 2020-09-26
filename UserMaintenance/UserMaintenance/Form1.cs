﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
