using System.Collections.Generic;

namespace Reminder.Interface
{
    public interface IReminderRepo
    {
        void Add(Reminder.Model.Reminder reminder);
        IEnumerable<Reminder.Model.Reminder> GetAll();
        Reminder.Model.Reminder Get(int id);
        void Delete(Reminder.Model.Reminder reminder);
        void Update(Reminder.Model.Reminder reminder);
    }
}