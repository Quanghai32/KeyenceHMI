Imports System.ComponentModel
Imports System.Drawing
'<Serializable(), Designer(GetType(PLCRunningStatus_Designer))>
<Serializable(), Designer(GetType(PLCBaseControl_Designer(Of PLCRunningStatus_ActionLists)))>
Public Class PLCRunningStatus
	Implements IPLCControl

	Private _isRunning As Boolean
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
			If IsNothing(butRun) Then Return
			butRun.Font = value
		End Set
	End Property
	Private _DisplayOnly As Boolean
	Public Property DisplayOnly() As Boolean
		Get
			Return _DisplayOnly
		End Get
		Set(ByVal value As Boolean)
			_DisplayOnly = value
			butRun.Enabled = Not _DisplayOnly
		End Set
	End Property


#End Region

#Region "Impliment and inherit function"
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
						_isRunning = True
						butRun.BackColor = _RunColor
						butRun.Text = _RunText
					Else
						_isRunning = False
						butRun.BackColor = _StopColor
						butRun.Text = _StopText
					End If
					preValue = result
				End If
			End If
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

#End Region

#Region "Other function"
	Private Sub updateDisplay()
		If IsNothing(butRun) Then Return
		If _isRunning Then
			butRun.BackColor = _RunColor
			butRun.Text = _RunText
		Else
			butRun.BackColor = _StopColor
			butRun.Text = _StopText
		End If
	End Sub

	Private Sub butRun_Click(sender As Object, e As EventArgs) Handles butRun.Click
		If _DisplayOnly Then Return
		If butRun.Text = RunText Then
			CalcCommand(True, "0")
		Else
			CalcCommand(True, "1")
		End If
	End Sub
#End Region

End Class
