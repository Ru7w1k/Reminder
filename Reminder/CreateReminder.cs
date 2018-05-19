using Reminder.Interface;
using Reminder.Model;
using Reminder.Repo;
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
        private IReminderRepo _ReminderRepo = null;

        public CreateReminder()
        {
            _ReminderRepo = new ReminderRepo();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reminder.Model.Reminder reminder = new Model.Reminder();
            reminder.Date = dtReminderDate.Value;
            reminder.Event = txtTitle.Text;

            if (rbMonthly.Checked) reminder.Repeat = Repeat.PerMonth;
            else if (rbYearly.Checked) reminder.Repeat = Repeat.PerYear;
            else reminder.Repeat = Repeat.Never;

            _ReminderRepo.Add(reminder);
        }
    }
}
