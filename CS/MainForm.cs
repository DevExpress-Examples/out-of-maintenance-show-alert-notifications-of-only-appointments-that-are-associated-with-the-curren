using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SchedulerFilterReminders {
    public partial class MainForm : Form {
        private int currentUserId;
        public int CurrentUserId { get { return currentUserId; } set { currentUserId = value; } }

        public MainForm() {
            InitializeComponent();

            // To trigger an alert in five seconds
            schedulerStorage1.RemindersCheckInterval = 5000;

            schedulerControl1.Start = ExampleUtils.baseTime;
            schedulerControl1.GroupType = SchedulerGroupType.Resource;

            ExampleUtils.GenerateSampleResources(schedulerStorage1);
            ExampleUtils.GenerateSampleAppointments(schedulerStorage1);
        }

        private void schedulerStorage1_ReminderAlert(object sender, ReminderEventArgs e) {
            for (int i = 0; i < e.AlertNotifications.Count; i++) {
                ReminderAlertNotification reminderAlertNotification = e.AlertNotifications[i];

                reminderAlertNotification.Ignore = !reminderAlertNotification.ActualAppointment.ResourceId.Equals(currentUserId);
                reminderAlertNotification.Handled = true;
            }
        }
    }
}