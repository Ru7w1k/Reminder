using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reminder
{
    public partial class CreateReminder : Form
    {
        public CreateReminder()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime eventDate = dtReminderDate.Value;
            String strTitle = txtTitle.Text;
            Char repeat = 'N';

            if (rbMonthly.Checked) repeat = 'M';
            else if (rbYearly.Checked) repeat = 'Y';

            MessageBox.Show(eventDate + ":" + strTitle + ":" + repeat);
        }
    }
}
