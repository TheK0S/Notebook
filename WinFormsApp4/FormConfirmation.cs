﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FormConfirmation : Form
    {
        public FormConfirmation()
        {
            InitializeComponent();
        }

        private void CancelBatton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
