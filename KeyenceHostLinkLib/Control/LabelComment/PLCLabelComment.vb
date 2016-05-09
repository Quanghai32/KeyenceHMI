Public Class PLCLabelComment
	Inherits PLCBaseControl
	Implements IPLCControl
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Public Sub New()
		InitializeComponent()
	End Sub
	Private Sub PLCLabelComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'InitializeComponent()
	End Sub
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(4, 4)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(95, 31)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Label1"
		'
		'PLCLabelComment
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.Controls.Add(Me.Label1)
		Me.MemoryType = "DM"
		Me.Name = "PLCLabelComment"
		Me.PLCAddress = 0
		Me.Size = New System.Drawing.Size(235, 41)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private Delegate Sub useResultCallback(ByVal value As String)
	Public Sub useResult(result As String) Implements IPLCControl.useResult
		If Me.InvokeRequired Then
			Dim d As New useResultCallback(AddressOf useResult)
			Me.Invoke(d, New Object() {result})
		Else
			result = result.Replace(vbCrLf, "")
			If preValue <> result Then
				If result.CompareTo("E6") = 0 Then
					Label1.Text = "No comment"
				Else
					Label1.Text = result
				End If
			End If
		End If
	End Sub

	Public Overrides Sub CalcCommand(Optional Write As Boolean = False, Optional value As String = "")
		link.cmd = "RDC " & link.add.MemType & link.add.MemAdd.ToString
	End Sub

	
	
End Class
