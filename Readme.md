<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636812/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3212)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ExampleUtils.cs](./CS/ExampleUtils.cs) (VB: [ExampleUtils.vb](./VB/ExampleUtils.vb))
* [LoginForm.cs](./CS/LoginForm.cs) (VB: [LoginForm.vb](./VB/LoginForm.vb))
* [MainForm.cs](./CS/MainForm.cs) (VB: [MainForm.vb](./VB/MainForm.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# Show alert notifications of only appointments that are associated with the current user


<p>This example illustrates how to filter reminder alerts shown in the Reminder Form. They are filtered according to the currently logged user.</p><p>To implement this scenario, you should handle the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_ReminderAlerttopic"><u>SchedulerStorageBase.ReminderAlert Event</u></a> and the following property values to allow/ignore a particular alert notification:</p><p><a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerReminderBaseAlertNotification_Ignoretopic"><u>ReminderBaseAlertNotification.Ignore Property</u></a><br />
<a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerReminderBaseAlertNotification_Handledtopic"><u>ReminderBaseAlertNotification.Handled Property</u></a></p><p>Use the <strong>e.AlertNotifications</strong> parameter of the <strong>ReminderAlert</strong> event to iterate through the currently arrived alert notifications.</p><p><strong>See also:</strong><br />
<a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument1778"><u>Reminders for Appointments</u></a><br />
<a href="https://www.devexpress.com/Support/Center/p/E3000">How to handle the RemindersFormShowing event and invoke the reminder form manually</a></p>

<br/>


