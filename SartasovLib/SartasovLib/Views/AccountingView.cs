﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SartasovLib.Views
{
    public partial class AccountingView : Form
    {
        public AccountingView()
        {
            InitializeComponent();
        }

        private void AccountingViewOnFormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }
    }
}
