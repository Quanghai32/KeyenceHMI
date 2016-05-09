Imports System.ComponentModel
Public Class PLCRunningStatus
	Inherits PLCBaseControl
	Implements IPLCControl
	Friend WithEvents butRun As System.Windows.Forms.Button
	Private Sub Class1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		InitializeComponent()
		CalcCommand()
	End Sub
	<Browsable(False)>
	Property MemoryType As String
	<Browsable(False)>
	Property PLCAddress As Integer

	Private Sub InitializeComponent()
		Me.butRun = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'butRun
		'
		Me.butRun.BackColor = System.Drawing.Color.Lime
		Me.butRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.butRun.Location = New System.Drawing.Point(4, 4)
		Me.butRun.Name = "butRun"
		Me.butRun.Size = New System.Drawing.Size(153, 51)
		Me.butRun.TabIndex = 0
		Me.butRun.Text = "RUNNING"
		Me.butRun.UseVisualStyleBackColor = False
		'
		'Class1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.Controls.Add(Me.butRun)
		Me.Name = "Class1"
		Me.Size = New System.Drawing.Size(162, 60)
		Me.ResumeLayout(False)

	End Sub

	Private Delegate Sub useResultCallback(ByVal value As String)
	Public Sub useResult(result As String) Implements IPLCControl.useResult
		If Me.InvokeRequired Then
			Dim d As New useResultCallback(AddressOf useResult)
			Me.Invoke(d, New Object() {result})
		Else
			result = result.Replace(vbCrLf, "")
			If preValue <> result Then
				If String.Compare(result, "OK") = 0 Then
					CalcCommand()
				Else
					Dim txt As Boolean
					txt = Convert.ToBoolean(Convert.ToInt16(result))
					If txt = True Then
						butRun.BackColor = Drawing.Color.Green
						butRun.Text = "RUNNING"
					Else
						butRun.BackColor = Drawing.Color.Red
						butRun.Text = "STOP"
					End If
					preValue = result
				End If
			End If
		End If
	End Sub

	Private Sub butRun_Click(sender As Object, e As EventArgs) Handles butRun.Click
		If butRun.Text = "RUNNING" Then
			CalcCommand(True, "0")
		Else
			CalcCommand(True, "1")
		End If
	End Sub
	Public Overrides Sub CalcCommand(Optional Write As Boolean = False, Optional value As String = "")
		If IsNothing(link) Then
			link = New PLCLink
		End If
		If Write Then
			link.cmd = "M" & value
		Else
			link.cmd = "?M"
		End If
	End Sub
End Class
