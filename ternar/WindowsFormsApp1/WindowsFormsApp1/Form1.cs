﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "Чекнут";
            }
            else
            {
                label1.Text = "Чокнут";

                // if (number ==10)
                // {
                //     label1.Text = "Da";
                // }
                // else
                // {
                //     label1.Text = "Net";
                // }


            }
        }
    }
}