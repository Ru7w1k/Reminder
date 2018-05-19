using DbHandler;
using Reminder.Interface;
using Reminder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Repo
{
    public class ReminderRepo : IReminderRepo
    {
        private IDbHandler _DbHandler = null;
        private List<Reminder.Model.Reminder> _Reminders = null;

        public ReminderRepo()
        {
            _DbHandler = new DbHandler.DbHandler();
            _Reminders = new List<Model.Reminder>();

            var reminders = _DbHandler.LoadReminders();
            if (reminders != null && reminders.Count() != 0)
                _Reminders.AddRange(reminders);
        }

        public void Add(Model.Reminder reminder)
        {
            reminder.Id = _Reminders.Count();
            _Reminders.Add(reminder);
            _DbHandler.StoreReminders(_Reminders);
        }

        public void Delete(Model.Reminder reminder)
        {
            throw new NotImplementedException();
        }

        public Model.Reminder Get(int id)
        {
            return _Reminders.Where((reminder) => reminder.Id == id).FirstOrDefault();
        }

        public IEnumerable<Model.Reminder> GetAll()
        {
            return _Reminders;
        }

        public void Update(Model.Reminder reminder)
        {
            throw new NotImplementedException();
        }
    }
}
