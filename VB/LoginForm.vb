Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerFilterReminders
    Partial Public Class LoginForm
        Inherits Form

        Public ReadOnly Property SelectedUserId() As Integer
            Get
                Return comboBox1.SelectedIndex + 1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            comboBox1.DataSource = ExampleUtils.Users
        End Sub
    End Class
End Namespace