using Reminder.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ReminderService
{
    public partial class ReminderService : ServiceBase
    {
        private IDbHandler _DbHandler = null;
        private IEnumerable<Reminder.Model.Reminder> _Reminders = null;

        public ReminderService()
        {
            CanHandleSessionChangeEvent = true;
            _DbHandler = new DbHandler.DbHandler();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            
        }

        protected override void OnStop()
        {

        }

        protected override void OnSessionChange(SessionChangeDescription changeDescription)
        {
            if(changeDescription.Reason == SessionChangeReason.SessionLogon || changeDescription.Reason == SessionChangeReason.SessionUnlock)
            {
                _Reminders = _DbHandler.LoadReminders();
                foreach (var reminder in _Reminders)
                {
                    if(reminder.Date.Date == DateTime.Now.Date)
                    {
                        System.Windows.Forms.MessageBox.Show("Reminder: " + reminder.Event);
                    }
                }
            }
            base.OnSessionChange(changeDescription);
        }
    }
}
