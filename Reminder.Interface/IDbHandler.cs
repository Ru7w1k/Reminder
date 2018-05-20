using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reminder.Model;

namespace Reminder.Interface
{
    public interface IDbHandler
    {
        IEnumerable<Reminder.Model.Reminder> LoadReminders();
        void StoreReminders(IEnumerable<Reminder.Model.Reminder> reminders);
    }
}
