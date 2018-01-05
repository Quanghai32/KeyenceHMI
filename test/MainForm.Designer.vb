<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PlcNumberBox2 = New KeyenceHostLinkLib.PLCNumberBox()
		Me.HostlinkKeyence1 = New KeyenceHostLinkLib.HostlinkKeyence(Me.components)
		Me.PlcComment2 = New KeyenceHostLinkLib.PLCComment()
		Me.PlcNumberBox1 = New KeyenceHostLinkLib.PLCNumberBox()
		Me.PlcComment1 = New KeyenceHostLinkLib.PLCComment()
		Me.PlcButtonChange1 = New KeyenceHostLinkLib.PLCButtonChange()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.PlcButtonChange3 = New KeyenceHostLinkLib.PLCButtonChange()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PlcRunningStatus1 = New KeyenceHostLinkLib.PLCRunningStatus()
		Me.PlcButtonChange4 = New KeyenceHostLinkLib.PLCButtonChange()
		Me.PlcEditBox3 = New KeyenceHostLinkLib.PLCEditBox()
		Me.PlcEditBox2 = New KeyenceHostLinkLib.PLCEditBox()
		Me.PlcEditBox1 = New KeyenceHostLinkLib.PLCEditBox()
		Me.PlcComment5 = New KeyenceHostLinkLib.PLCComment()
		Me.PlcComment6 = New KeyenceHostLinkLib.PLCComment()
		Me.PlcButtonChange2 = New KeyenceHostLinkLib.PLCButtonChange()
		Me.PlcNumberBox3 = New KeyenceHostLinkLib.PLCNumberBox()
		Me.PlcComment3 = New KeyenceHostLinkLib.PLCComment()
		Me.PlcNumberBox4 = New KeyenceHostLinkLib.PLCNumberBox()
		Me.PlcComment4 = New KeyenceHostLinkLib.PLCComment()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabControl1
		'
		Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(284, 242)
		Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
		Me.TabControl1.TabIndex = 0
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.Label3)
		Me.TabPage1.Controls.Add(Me.PlcNumberBox2)
		Me.TabPage1.Controls.Add(Me.PlcComment2)
		Me.TabPage1.Controls.Add(Me.PlcNumberBox1)
		Me.TabPage1.Controls.Add(Me.PlcComment1)
		Me.TabPage1.Controls.Add(Me.PlcButtonChange1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 25)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(276, 213)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "TabPage1"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(44, 3)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(188, 31)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Value in DEC"
		'
		'PlcNumberBox2
		'
		Me.PlcNumberBox2.InputColor = System.Drawing.SystemColors.Control
		Me.PlcNumberBox2.Location = New System.Drawing.Point(148, 97)
		Me.PlcNumberBox2.Name = "PlcNumberBox2"
		Me.PlcNumberBox2.PLCAddress = 101
		Me.PlcNumberBox2.PLCLink = Me.HostlinkKeyence1
		Me.PlcNumberBox2.Size = New System.Drawing.Size(118, 50)
		Me.PlcNumberBox2.TabIndex = 2
		Me.PlcNumberBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		'
		'HostlinkKeyence1
		'
		Me.HostlinkKeyence1.Name = "HostlinkKeyence1"
		Me.HostlinkKeyence1.time = 100.0R
		'
		'PlcComment2
		'
		Me.PlcComment2.Location = New System.Drawing.Point(8, 103)
		Me.PlcComment2.Name = "PlcComment2"
		Me.PlcComment2.PLCAddress = 101
		Me.PlcComment2.PLCLink = Me.HostlinkKeyence1
		Me.PlcComment2.Size = New System.Drawing.Size(134, 39)
		Me.PlcComment2.TabIndex = 1
		'
		'PlcNumberBox1
		'
		Me.PlcNumberBox1.InputColor = System.Drawing.SystemColors.Control
		Me.PlcNumberBox1.Location = New System.Drawing.Point(148, 41)
		Me.PlcNumberBox1.Name = "PlcNumberBox1"
		Me.PlcNumberBox1.PLCLink = Me.HostlinkKeyence1
		Me.PlcNumberBox1.Size = New System.Drawing.Size(118, 50)
		Me.PlcNumberBox1.TabIndex = 2
		Me.PlcNumberBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		'
		'PlcComment1
		'
		Me.PlcComment1.Location = New System.Drawing.Point(8, 47)
		Me.PlcComment1.Name = "PlcComment1"
		Me.PlcComment1.PLCLink = Me.HostlinkKeyence1
		Me.PlcComment1.Size = New System.Drawing.Size(134, 39)
		Me.PlcComment1.TabIndex = 1
		'
		'PlcButtonChange1
		'
		Me.PlcButtonChange1.AutoSize = True
		Me.PlcButtonChange1.BackColor = System.Drawing.Color.Lime
		Me.PlcButtonChange1.ButtonText = "NEXT"
		Me.PlcButtonChange1.ButtonType = System.Windows.Forms.FlatStyle.Flat
		Me.PlcButtonChange1.Location = New System.Drawing.Point(145, 174)
		Me.PlcButtonChange1.MainPage = Me.TabControl1
		Me.PlcButtonChange1.Name = "PlcButtonChange1"
		Me.PlcButtonChange1.NextPage = Me.TabPage2
		Me.PlcButtonChange1.Size = New System.Drawing.Size(123, 53)
		Me.PlcButtonChange1.TabIndex = 0
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.Label2)
		Me.TabPage2.Controls.Add(Me.PlcButtonChange3)
		Me.TabPage2.Controls.Add(Me.PlcButtonChange2)
		Me.TabPage2.Controls.Add(Me.PlcNumberBox3)
		Me.TabPage2.Controls.Add(Me.PlcComment3)
		Me.TabPage2.Controls.Add(Me.PlcNumberBox4)
		Me.TabPage2.Controls.Add(Me.PlcComment4)
		Me.TabPage2.Location = New System.Drawing.Point(4, 25)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(276, 213)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "TabPage2"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(49, 3)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(178, 31)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Value in Hex"
		'
		'PlcButtonChange3
		'
		Me.PlcButtonChange3.AutoSize = True
		Me.PlcButtonChange3.BackColor = System.Drawing.Color.Lime
		Me.PlcButtonChange3.ButtonText = "NEXT"
		Me.PlcButtonChange3.ButtonType = System.Windows.Forms.FlatStyle.Flat
		Me.PlcButtonChange3.Location = New System.Drawing.Point(147, 174)
		Me.PlcButtonChange3.MainPage = Me.TabControl1
		Me.PlcButtonChange3.Name = "PlcButtonChange3"
		Me.PlcButtonChange3.NextPage = Me.TabPage3
		Me.PlcButtonChange3.Size = New System.Drawing.Size(123, 53)
		Me.PlcButtonChange3.TabIndex = 7
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.Label1)
		Me.TabPage3.Controls.Add(Me.PlcRunningStatus1)
		Me.TabPage3.Controls.Add(Me.PlcButtonChange4)
		Me.TabPage3.Controls.Add(Me.PlcEditBox3)
		Me.TabPage3.Controls.Add(Me.PlcEditBox2)
		Me.TabPage3.Controls.Add(Me.PlcEditBox1)
		Me.TabPage3.Controls.Add(Me.PlcComment5)
		Me.TabPage3.Controls.Add(Me.PlcComment6)
		Me.TabPage3.Location = New System.Drawing.Point(4, 25)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(276, 213)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "TabPage3"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(70, 3)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(136, 31)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Set value"
		'
		'PlcRunningStatus1
		'
		Me.PlcRunningStatus1.BackColor = System.Drawing.Color.Green
		Me.PlcRunningStatus1.DisplayOnly = False
		Me.PlcRunningStatus1.Location = New System.Drawing.Point(0, 0)
		Me.PlcRunningStatus1.MemoryType = Nothing
		Me.PlcRunningStatus1.Name = "PlcRunningStatus1"
		Me.PlcRunningStatus1.PLCAddress = 0
		Me.PlcRunningStatus1.PLCLink = Me.HostlinkKeyence1
		Me.PlcRunningStatus1.RunColor = System.Drawing.Color.Green
		Me.PlcRunningStatus1.RunText = "R"
		Me.PlcRunningStatus1.Size = New System.Drawing.Size(49, 49)
		Me.PlcRunningStatus1.StopColor = System.Drawing.Color.Red
		Me.PlcRunningStatus1.StopText = "S"
		Me.PlcRunningStatus1.TabIndex = 7
		'
		'PlcButtonChange4
		'
		Me.PlcButtonChange4.AutoSize = True
		Me.PlcButtonChange4.BackColor = System.Drawing.Color.Lime
		Me.PlcButtonChange4.ButtonText = "BACK"
		Me.PlcButtonChange4.ButtonType = System.Windows.Forms.FlatStyle.Flat
		Me.PlcButtonChange4.Location = New System.Drawing.Point(6, 174)
		Me.PlcButtonChange4.MainPage = Me.TabControl1
		Me.PlcButtonChange4.Name = "PlcButtonChange4"
		Me.PlcButtonChange4.NextPage = Me.TabPage2
		Me.PlcButtonChange4.Size = New System.Drawing.Size(123, 53)
		Me.PlcButtonChange4.TabIndex = 6
		'
		'PlcEditBox3
		'
		Me.PlcEditBox3.Location = New System.Drawing.Point(156, 161)
		Me.PlcEditBox3.MemoryType = "R"
		Me.PlcEditBox3.Name = "PlcEditBox3"
		Me.PlcEditBox3.PLCAddress = 500
		Me.PlcEditBox3.PLCLink = Me.HostlinkKeyence1
		Me.PlcEditBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.PlcEditBox3.Size = New System.Drawing.Size(89, 36)
		Me.PlcEditBox3.TabIndex = 5
		'
		'PlcEditBox2
		'
		Me.PlcEditBox2.Location = New System.Drawing.Point(116, 109)
		Me.PlcEditBox2.Name = "PlcEditBox2"
		Me.PlcEditBox2.PLCAddress = 101
		Me.PlcEditBox2.PLCLink = Me.HostlinkKeyence1
		Me.PlcEditBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.PlcEditBox2.Size = New System.Drawing.Size(152, 49)
		Me.PlcEditBox2.TabIndex = 5
		'
		'PlcEditBox1
		'
		Me.PlcEditBox1.Location = New System.Drawing.Point(116, 53)
		Me.PlcEditBox1.Name = "PlcEditBox1"
		Me.PlcEditBox1.PLCLink = Me.HostlinkKeyence1
		Me.PlcEditBox1.Size = New System.Drawing.Size(152, 49)
		Me.PlcEditBox1.TabIndex = 5
		'
		'PlcComment5
		'
		Me.PlcComment5.Location = New System.Drawing.Point(10, 114)
		Me.PlcComment5.Name = "PlcComment5"
		Me.PlcComment5.PLCAddress = 101
		Me.PlcComment5.PLCLink = Me.HostlinkKeyence1
		Me.PlcComment5.Size = New System.Drawing.Size(100, 39)
		Me.PlcComment5.TabIndex = 3
		'
		'PlcComment6
		'
		Me.PlcComment6.Location = New System.Drawing.Point(10, 58)
		Me.PlcComment6.Name = "PlcComment6"
		Me.PlcComment6.PLCLink = Me.HostlinkKeyence1
		Me.PlcComment6.Size = New System.Drawing.Size(100, 39)
		Me.PlcComment6.TabIndex = 4
		'
		'PlcButtonChange2
		'
		Me.PlcButtonChange2.AutoSize = True
		Me.PlcButtonChange2.BackColor = System.Drawing.Color.Lime
		Me.PlcButtonChange2.ButtonText = "BACK"
		Me.PlcButtonChange2.ButtonType = System.Windows.Forms.FlatStyle.Flat
		Me.PlcButtonChange2.Location = New System.Drawing.Point(6, 174)
		Me.PlcButtonChange2.MainPage = Me.TabControl1
		Me.PlcButtonChange2.Name = "PlcButtonChange2"
		Me.PlcButtonChange2.NextPage = Me.TabPage1
		Me.PlcButtonChange2.Size = New System.Drawing.Size(123, 53)
		Me.PlcButtonChange2.TabIndex = 7
		'
		'PlcNumberBox3
		'
		Me.PlcNumberBox3.DataFormat = ".H"
		Me.PlcNumberBox3.InputColor = System.Drawing.SystemColors.Control
		Me.PlcNumberBox3.Location = New System.Drawing.Point(148, 99)
		Me.PlcNumberBox3.Name = "PlcNumberBox3"
		Me.PlcNumberBox3.PLCAddress = 101
		Me.PlcNumberBox3.PLCLink = Me.HostlinkKeyence1
		Me.PlcNumberBox3.Size = New System.Drawing.Size(118, 50)
		Me.PlcNumberBox3.TabIndex = 5
		Me.PlcNumberBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		'
		'PlcComment3
		'
		Me.PlcComment3.Location = New System.Drawing.Point(8, 105)
		Me.PlcComment3.Name = "PlcComment3"
		Me.PlcComment3.PLCAddress = 101
		Me.PlcComment3.PLCLink = Me.HostlinkKeyence1
		Me.PlcComment3.Size = New System.Drawing.Size(134, 39)
		Me.PlcComment3.TabIndex = 3
		'
		'PlcNumberBox4
		'
		Me.PlcNumberBox4.DataFormat = ".H"
		Me.PlcNumberBox4.InputColor = System.Drawing.SystemColors.Control
		Me.PlcNumberBox4.Location = New System.Drawing.Point(148, 43)
		Me.PlcNumberBox4.Name = "PlcNumberBox4"
		Me.PlcNumberBox4.PLCLink = Me.HostlinkKeyence1
		Me.PlcNumberBox4.Size = New System.Drawing.Size(118, 50)
		Me.PlcNumberBox4.TabIndex = 6
		Me.PlcNumberBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		'
		'PlcComment4
		'
		Me.PlcComment4.Location = New System.Drawing.Point(8, 49)
		Me.PlcComment4.Name = "PlcComment4"
		Me.PlcComment4.PLCLink = Me.HostlinkKeyence1
		Me.PlcComment4.Size = New System.Drawing.Size(134, 39)
		Me.PlcComment4.TabIndex = 4
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 242)
		Me.Controls.Add(Me.TabControl1)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Read PLC memory"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		Me.TabPage3.ResumeLayout(False)
		Me.TabPage3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
	Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
	Friend WithEvents PlcButtonChange1 As KeyenceHostLinkLib.PLCButtonChange
	Friend WithEvents PlcNumberBox1 As KeyenceHostLinkLib.PLCNumberBox
	Friend WithEvents PlcComment1 As KeyenceHostLinkLib.PLCComment
	Friend WithEvents HostlinkKeyence1 As KeyenceHostLinkLib.HostlinkKeyence
	Friend WithEvents PlcNumberBox2 As KeyenceHostLinkLib.PLCNumberBox
	Friend WithEvents PlcComment2 As KeyenceHostLinkLib.PLCComment
	Friend WithEvents PlcButtonChange3 As KeyenceHostLinkLib.PLCButtonChange
	Friend WithEvents PlcRunningStatus1 As KeyenceHostLinkLib.PLCRunningStatus
	Friend WithEvents PlcButtonChange4 As KeyenceHostLinkLib.PLCButtonChange
	Friend WithEvents PlcEditBox2 As KeyenceHostLinkLib.PLCEditBox
	Friend WithEvents PlcEditBox1 As KeyenceHostLinkLib.PLCEditBox
	Friend WithEvents PlcComment5 As KeyenceHostLinkLib.PLCComment
	Friend WithEvents PlcComment6 As KeyenceHostLinkLib.PLCComment
	Friend WithEvents PlcButtonChange2 As KeyenceHostLinkLib.PLCButtonChange
	Friend WithEvents PlcNumberBox3 As KeyenceHostLinkLib.PLCNumberBox
	Friend WithEvents PlcComment3 As KeyenceHostLinkLib.PLCComment
	Friend WithEvents PlcNumberBox4 As KeyenceHostLinkLib.PLCNumberBox
	Friend WithEvents PlcComment4 As KeyenceHostLinkLib.PLCComment
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents PlcEditBox3 As KeyenceHostLinkLib.PLCEditBox
End Class
