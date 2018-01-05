Imports System.ComponentModel
<Serializable(), Designer(GetType(PLCBaseControl_Designer(Of PLCComment_ActionList)))>
Public Class PLCComment
	Implements IPLCControl

#Region "Properties"
	<Browsable(False)>
	Private Shadows Property DataFormat As String
#End Region

	Private Delegate Sub SetUsedCallback(ByVal value As String)
	Public Sub useResult(result As String) Implements IPLCControl.useResult
		If link.enable = False Then Return
		If Me.InvokeRequired Then
			Dim d As New SetUsedCallback(AddressOf useResult)
			Me.Invoke(d, New Object() {result})
		Else
			result = result.Replace(vbCrLf, "")
			If preValue <> result Then
				If result.CompareTo("E6") = 0 Then
					Label1.Text = "No comment"
				Else
					Label1.Text = result
				End If
				preValue = result
			End If
		End If
	End Sub
	Public Overrides Sub CalcCommand(Optional Write As Boolean = False, Optional value As String = "")
		'MyBase.CalcCommand(Write, value)
		If IsNothing(link) Then Return
		link.add.MemType = MemoryType
		link.add.MemAdd = PLCAddress
		link.cmd = "RDC " & link.add.MemType & link.add.MemAdd.ToString
	End Sub
End Class
