﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5FindMissingNumberInArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindMissingNumber x = new FindMissingNumber(textBox1.Text);
            label2.Text = x.getMissingNumber().ToString();
        }
    }
}
