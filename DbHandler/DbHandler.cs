using Newtonsoft.Json;
using Reminder.Interface;
using Reminder.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHandler
{
    public class DbHandler : IDbHandler
    {
        private string _AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string _RemindersFile = "reminders.json";

        public IEnumerable<Reminder.Model.Reminder> LoadReminders()
        {
            if(!File.Exists(_AppDataFolder + "\\" + _RemindersFile))
            {
                File.Create(_AppDataFolder + "\\" + _RemindersFile);
            }
            string fromFile = File.ReadAllText(_AppDataFolder + "\\" + _RemindersFile);
            return JsonConvert.DeserializeObject<IEnumerable<Reminder.Model.Reminder>>(fromFile);
        }

        public void StoreReminders(IEnumerable<Reminder.Model.Reminder> reminders)
        {
            string data = JsonConvert.SerializeObject(reminders);
            File.WriteAllText(_AppDataFolder + "\\" + _RemindersFile, data);
        }
    }
}
