using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hydrate
{
    public partial class ConfigureBox : Form
    {
        public ConfigureBox()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Constants.dateTimeStartTime = this.dateTimePickerStart.Value.ToLocalTime();
            Constants.dateTimeEndTime = this.dateTimePickerEnd.Value.ToLocalTime();
            Constants.decimalTimeInterval = this.numericUpDownInterval.Value;
            this.Hide();
        }
    }
}
