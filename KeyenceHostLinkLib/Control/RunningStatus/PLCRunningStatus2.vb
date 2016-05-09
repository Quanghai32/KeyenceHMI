Imports System.ComponentModel
Imports System.Drawing

'<Serializable(), Designer(GetType(PLCRunningStatus_Designer))>
Public Class PLCRunningStatus2
	Inherits PLCBaseControl
	Implements IPLCControl
	Friend WithEvents butRun As System.Windows.Forms.Button
	Private _isRunning As Boolean = True
#Region "Properties"
	<Browsable(False)>
	Shadows Property MemoryType As String
	<Browsable(False)>
	Shadows Property PLCAddress As Integer
	Private _RunColor As Color = Color.Green
	Public Property RunColor() As Color
		Get
			Return _RunColor
		End Get
		Set(ByVal value As Color)
			_RunColor = value
			updateDisplay()
		End Set
	End Property
	Private _StopColor As Color = Color.Red
	Public Property StopColor() As Color
		Get
			Return _StopColor
		End Get
		Set(ByVal value As Color)
			_StopColor = value
			updateDisplay()
		End Set
	End Property
	Private _RunText As String = "Running"
	Public Property RunText() As String
		Get
			Return _RunText
		End Get
		Set(ByVal value As String)
			_RunText = value
			updateDisplay()
		End Set
	End Property
	Private _StopText As String = "Stop"
	Public Property StopText() As String
		Get
			Return _StopText
		End Get
		Set(ByVal value As String)
			_StopText = value
			updateDisplay()
		End Set

	End Property
	Public Overrides Property Font() As Font
		Get
			If IsNothing(butRun) Then Return Nothing
			Return butRun.Font
		End Get
		Set(ByVal value As Font)
			'If IsNothing(butRun) Then Return
			'butRun.Font = value
		End Set
	End Property

#End Region

	Private Sub Class1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		InitializeComponent()
		'CalcCommand()
		'Me.butRun.BackColor = _RunColor
		'Me.butRun.Text = _RunText
	End Sub




	Private Sub InitializeComponent()
		Me.butRun = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'butRun
		'
		Me.butRun.BackColor = Color.Green
		Me.butRun.Dock = System.Windows.Forms.DockStyle.Fill
		Me.butRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.butRun.Location = New System.Drawing.Point(0, 0)
		Me.butRun.Name = "butRun"
		Me.butRun.Size = New System.Drawing.Size(162, 60)
		Me.butRun.TabIndex = 0
		Me.butRun.Text = "Running"
		Me.butRun.UseVisualStyleBackColor = False
		'
		'PLCRunningStatus
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoSize = True
		Me.Controls.Add(Me.butRun)
		Me.Name = "PLCRunningStatus"
		Me.Size = New System.Drawing.Size(162, 60)
		Me.ResumeLayout(False)

	End Sub

	Private Delegate Sub useResultCallback(ByVal value As String)
	Public Sub useResult(result As String) Implements IPLCControl.useResult
		'If Me.InvokeRequired Then
		'	Dim d As New useResultCallback(AddressOf useResult)
		'	Me.Invoke(d, New Object() {result})
		'Else
		'	result = result.Replace(vbCrLf, "")
		'	If preValue <> result Then
		'		If String.Compare(result, "OK") = 0 Then
		'			CalcCommand()
		'		Else
		'			Dim txt As Boolean
		'			txt = Convert.ToBoolean(Convert.ToInt16(result))
		'			If txt = True Then
		'				_isRunning = True
		'				butRun.BackColor = _RunColor
		'				butRun.Text = _RunText
		'			Else
		'				_isRunning = False
		'				butRun.BackColor = _StopColor
		'				butRun.Text = _StopText
		'			End If
		'			preValue = result
		'		End If
		'	End If
		'End If
	End Sub

	Private Sub butRun_Click(sender As Object, e As EventArgs) Handles butRun.Click
		'If butRun.Text = RunText Then
		'	CalcCommand(True, "0")
		'Else
		'	CalcCommand(True, "1")
		'End If
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
	Private Sub updateDisplay()
		'If IsNothing(butRun) Then Return
		'If _isRunning Then
		'	butRun.BackColor = _RunColor
		'	butRun.Text = _RunText
		'Else
		'	butRun.BackColor = _StopColor
		'	butRun.Text = _StopText
		'End If
	End Sub

End Class
