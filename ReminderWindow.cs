using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Hydrate
{
    public partial class ReminderWindow : Form
    {
        public ReminderWindow()
        {
            InitializeComponent();
        }

        private void btnIDrankWater_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIAmBusy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
