﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_click(object sender, EventArgs e)
        {
            label1.Text = "Hello World";
            if (button1.Text == "Clicked")
            {
                button1.Text = "Unclicked";
            }
            else
            {
                button1.Text = "Clicked";
            }
        }
    }
}
