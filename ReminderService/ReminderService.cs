using Reminder.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
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
        private string _AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string _RemindersFile = "reminders.json";
        private FileSystemWatcher _FileSystemWatcher = null;

        public ReminderService()
        {
            // FileSystemWatcher

            if(!File.Exists(_AppDataFolder + "\\" + _RemindersFile))
            {
                File.Create(_AppDataFolder + "\\" + _RemindersFile);
            }

            _FileSystemWatcher = new FileSystemWatcher(_AppDataFolder + "\\" + _RemindersFile);
            _FileSystemWatcher.EnableRaisingEvents = true;
            _FileSystemWatcher.Changed += _FileSystemWatcher_Changed;

            // Session Watcher
            CanHandleSessionChangeEvent = true;

            _DbHandler = new DbHandler.DbHandler();
            _Reminders = new List<Reminder.Model.Reminder>();

            InitializeComponent();
        }

        private void _FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            // LOAD reminders data set again..
                        
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
