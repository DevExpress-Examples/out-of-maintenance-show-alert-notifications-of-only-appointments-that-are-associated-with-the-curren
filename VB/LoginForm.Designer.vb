Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerFilterReminders
	Partial Public Class LoginForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.button1 = New System.Windows.Forms.Button()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button1.Location = New System.Drawing.Point(82, 42)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 25)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Login"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(113, 12)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(111, 24)
			Me.comboBox1.TabIndex = 1
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 15)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(95, 17)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Select a user:"
			' 
			' LoginForm
			' 
			Me.AcceptButton = Me.button1
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(239, 78)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.button1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "LoginForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "LoginForm"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private button1 As System.Windows.Forms.Button
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label

	End Class
End Namespace

