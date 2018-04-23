using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchedulerFilterReminders {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK) {
                MainForm mainForm = new MainForm();
                mainForm.CurrentUserId = loginForm.SelectedUserId;
                loginForm.Dispose();
                Application.Run(mainForm);
            }
        }
    }
}