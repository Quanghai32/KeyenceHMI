Imports System.Net
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Drawing
Imports System.Windows.Forms

<Serializable(), Designer(GetType(PLCNumberBox_Designer))>
Public Class PLCNumberBox
	Implements IPLCControl

#Region "Properties"
	<Category("Appearance")>
	Public Property InputColor() As Color
		Get
			Return txtValue.BackColor
		End Get
		Set(ByVal value As Color)
			txtValue.BackColor = value
		End Set
	End Property
	<Category("Appearance")>
	Public Property TextAlign As HorizontalAlignment
		Get
			Return txtValue.TextAlign
		End Get
		Set(value As HorizontalAlignment)
			txtValue.TextAlign = value
		End Set
	End Property

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
	End Sub
End Class
