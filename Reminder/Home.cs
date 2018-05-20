using Reminder.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class Home : Form
    {
        private IDbHandler _DbHandler = null;
        private static int _Flag = 0;

        public Home()
        {
            _DbHandler = new DbHandler.DbHandler();
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            
        }

        private void RefreshGridView()
        {
            var data = _DbHandler.LoadReminders();
            gridViewReminders.DataSource = data;
            
            if(data != null && _Flag == 0)
            {
                _Flag = 1;

                

                var EditBtnCol = new DataGridViewButtonColumn()
                {
                    Name = "edit",
                    Text = "Edit",
                };

                var DeleteBtnCol = new DataGridViewButtonColumn()
                {
                    Name = "delete",
                    Text = "Delete"
                };

                gridViewReminders.Columns.Add(EditBtnCol);
                gridViewReminders.Columns.Add(DeleteBtnCol);
                gridViewReminders.CellClick += GridViewReminders_CellClick;
            }
        }

        private void GridViewReminders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Edit Column
            if (e.ColumnIndex == 5)
            {
                // open create form with selected row index
            }

            // Delete Column
            if (e.ColumnIndex == 6)
            {
                // delete reminder from 
            }
        }

        private void btnCreateReminder_Click(object sender, EventArgs e)
        {
            new CreateReminder().ShowDialog();
            RefreshGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridViewReminders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
