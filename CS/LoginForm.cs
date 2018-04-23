using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SchedulerFilterReminders {
    public partial class LoginForm : Form {
        public int SelectedUserId { get { return comboBox1.SelectedIndex + 1; } }
        
        public LoginForm() {
            InitializeComponent();

            comboBox1.DataSource = ExampleUtils.Users;
        }
    }
}