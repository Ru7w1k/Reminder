using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Model
{
    public enum Repeat
    {
        Never,
        PerMonth,
        PerYear
    }

    public class Reminder
    {
        public int? Id { get; set; }
        public string Event { get; set; }
        public DateTime Date { get; set; }
        public Repeat Repeat { get; set; } 
    }
}
