using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Reminder
{
    public class DAL
    {
        private string _FileName = "db.txt";
        private FileStream _FileStream = null;

        public bool Write(Reminder reminder)
        {
            _FileStream = File.Open(_FileName, FileMode.Append);
            _FileStream.Write(reminder.ToString().ToCharArray() as byte[], 0, reminder.ToString().Length);
        }


    }
}
