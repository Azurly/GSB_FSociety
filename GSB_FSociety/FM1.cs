﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_FSociety
{
    public partial class FM1 : Form
    {
        public FM1()
        {
            InitializeComponent();
        }
        private void FM1_Load(object sender, EventArgs e)
        {
            FM1_Login fm1Login = new FM1_Login();
            fm1Login.ShowDialog();
            this.Close();
        }
    }
}