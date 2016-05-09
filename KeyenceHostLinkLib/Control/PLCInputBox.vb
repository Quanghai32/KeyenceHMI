Imports System.ComponentModel
Imports System.Net

Public Class PLCInputBox
	Implements IPLCControl

	Private _IP As IPAddress
	Private _port As Integer
	Private preValue As String = ""
	Private link As PLCLink
#Region "Properties"
	Private _PLCAdress As Integer
	<Category("PLC connection")>
	Public Property PLCAddress() As Integer
		Get
			Return _PLCAdress
		End Get
		Set(ByVal value As Integer)
			_PLCAdress = value
		End Set
	End Property
	Private _PLCLink As HostlinkKeyence
	<Category("PLC connection")>
	Public Property PLCLink() As HostlinkKeyence
		Get
			Return _PLCLink
		End Get
		Set(ByVal value As HostlinkKeyence)
			If IPAddress.TryParse(value.IP, _IP) Then
				_port = value.port
			End If
			_PLCLink = value
			If IsNothing(link) Then link = New PLCLink
			link.add.MemAdd = _PLCAdress
			'link.add.format = ".U"
			link.add.format = _dataFormat
			link.add.MemType = "DM"
			link.usingmethod = Me
			link.enable = True
			CalcRequestCommand()
			_PLCLink.AddLink(link)
		End Set
	End Property
	Private _dataFormat As String
	<Description("Data format" & vbCrLf & ".U: Unsigned 16-bits DEC" & vbCrLf & ".S: Signed 16-bits DEC" & vbCrLf & ".D: Unsigned 32-bits DEC" & vbCrLf & ".L: Signed 32-bits DEC" & vbCrLf & ".H: 16-bits HEX"), Category("PLC connection")>
	Public Property dataFormat() As String
		Get
			Return _dataFormat
		End Get
		Set(ByVal value As String)
			_dataFormat = value
		End Set
	End Property

#End Region

	Private Sub PLCInputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
	Private Delegate Sub SetUsedCallback(ByVal value As String)
	Public Sub useResult(result As String) Implements IPLCControl.useResult
		If Me.InvokeRequired Then
			Dim d As New SetUsedCallback(AddressOf useResult)
			Me.Invoke(d, New Object() {result})
		Else
			If preValue <> result Then
				If String.Compare(result, "OK" & vbCrLf & "") = 0 Then
					CalcRequestCommand()
				Else
					Dim txt As String
					Select Case _dataFormat
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

	Public Sub CalcRequestCommand(Optional ByVal write As Boolean = False)
		If IsNothing(link) Then
			link = New PLCLink
		End If
		If write Then
			link.cmd = "WR " & link.add.MemType & link.add.MemAdd & link.add.format & " " & txtValue.Text
		Else
			link.cmd = "RD " & link.add.MemType & link.add.MemAdd & link.add.format
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
			CalcRequestCommand(True)
		End If
	End Sub
End Class
