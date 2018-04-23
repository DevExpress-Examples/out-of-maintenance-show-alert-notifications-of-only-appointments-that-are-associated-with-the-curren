# Show alert notifications of only appointments that are associated with the current user


<p>This example illustrates how to filter reminder alerts shown in the Reminder Form. They are filtered according to the currently logged user.</p><p>To implement this scenario, you should handle the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_ReminderAlerttopic"><u>SchedulerStorageBase.ReminderAlert Event</u></a> and the following property values to allow/ignore a particular alert notification:</p><p><a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerReminderBaseAlertNotification_Ignoretopic"><u>ReminderBaseAlertNotification.Ignore Property</u></a><br />
<a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerReminderBaseAlertNotification_Handledtopic"><u>ReminderBaseAlertNotification.Handled Property</u></a></p><p>Use the <strong>e.AlertNotifications</strong> parameter of the <strong>ReminderAlert</strong> event to iterate through the currently arrived alert notifications.</p><p><strong>See also:</strong><br />
<a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument1778"><u>Reminders for Appointments</u></a><br />
<a href="https://www.devexpress.com/Support/Center/p/E3000">How to handle the RemindersFormShowing event and invoke the reminder form manually</a></p>

<br/>


