Imports System.ComponentModel
Imports System.Net
<Serializable(), Designer(GetType(PLCEditBox_Designer))>
Public Class PLCEditBox
	Implements IPLCControl
	Private Delegate Sub SetUsedCallback(ByVal value As String)
	Public Sub useResult(result As String) Implements IPLCControl.useResult
		If Me.InvokeRequired Then
			Dim d As New SetUsedCallback(AddressOf useResult)
			Me.Invoke(d, New Object() {result})
		Else
			result = result.Replace(vbCrLf, "")
			If preValue <> result Then
				If String.Compare(result, "OK") = 0 Then
					CalcCommand()
				Else
					Dim txt As String
					Select Case DataFormat
						Case ".U"
							txt = Convert.ToUInt16(result)
						Case ".S"
							txt = Convert.ToInt16(result)
						Case ".D"
							txt = Convert.ToUInt32(result)
						Case ".L"
							txt = Convert.ToInt32(result)
						Case ".H"
							txt = result
						Case Else
							txt = Convert.ToUInt16(result)
					End Select
					txtValue.Text = txt
					preValue = result
				End If
			End If
		End If
	End Sub

	Private Sub butWrite_Click(sender As Object, e As EventArgs) Handles butWrite.Click
		If butWrite.Text = "W" Then
			link.enable = False
			txtValue.ReadOnly = False
			butWrite.Text = "S"
		Else
			butWrite.Text = "W"
			link.enable = True
			txtValue.ReadOnly = True
			preValue = ""
			CalcCommand(True, txtValue.Text.Replace(vbCrLf, ""))
		End If
	End Sub
End Class
