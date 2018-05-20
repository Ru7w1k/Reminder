namespace Reminder
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridViewReminders = new System.Windows.Forms.DataGridView();
            this.btnCreateReminder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewReminders
            // 
            this.gridViewReminders.AllowUserToAddRows = false;
            this.gridViewReminders.AllowUserToDeleteRows = false;
            this.gridViewReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewReminders.Location = new System.Drawing.Point(12, 12);
            this.gridViewReminders.Name = "gridViewReminders";
            this.gridViewReminders.ReadOnly = true;
            this.gridViewReminders.Size = new System.Drawing.Size(462, 398);
            this.gridViewReminders.TabIndex = 0;
            this.gridViewReminders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewReminders_CellContentClick);
            // 
            // btnCreateReminder
            // 
            this.btnCreateReminder.Location = new System.Drawing.Point(318, 416);
            this.btnCreateReminder.Name = "btnCreateReminder";
            this.btnCreateReminder.Size = new System.Drawing.Size(75, 23);
            this.btnCreateReminder.TabIndex = 1;
            this.btnCreateReminder.Text = "New ";
            this.btnCreateReminder.UseVisualStyleBackColor = true;
            this.btnCreateReminder.Click += new System.EventHandler(this.btnCreateReminder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(399, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 451);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateReminder);
            this.Controls.Add(this.gridViewReminders);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewReminders;
        private System.Windows.Forms.Button btnCreateReminder;
        private System.Windows.Forms.Button btnExit;
    }
}