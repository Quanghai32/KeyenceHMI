Imports System.Net
Imports System.ComponentModel
Imports System.Drawing.Design
Public Class PLCOutput
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
			If IsNothing(link) Then link = New PLCLink
			link.add.MemAdd = _PLCAdress
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
			link.usingmethod = Me
			link.enable = True
			CalcRequestCommand()
			_PLCLink.AddLink(link)
		End Set
	End Property
	Private _MemType As String
	<Category("PLC connection"),Editor(GetType(CustomListPropertiesEditor),GetType(UITypeEditor))>
	Public Property MemoryType() As String
		Get
			Return _MemType
		End Get
		Set(ByVal value As String)
			_MemType = value
			If IsNothing(link) Then link = New PLCLink
			link.add.MemType = _MemType
		End Set
	End Property

#End Region

	Private Delegate Sub SetUsedCallback(ByVal value As String)
	Public Sub useResult(result As String) Implements IPLCControl.useResult
		If Me.InvokeRequired Then
			Dim d As New SetUsedCallback(AddressOf useResult)
			Me.Invoke(d, New Object() {result})
		Else
			result = result.Replace(vbCrLf, "")
			If preValue <> result Then
				If String.Compare(result, "OK") = 0 Then
					CalcRequestCommand()
				Else
					Dim txt As Boolean
					txt = Convert.ToBoolean(Convert.ToInt16(result))
					If txt = True Then
						Button1.BackColor = Drawing.Color.Green
						Button1.Text = "ON"
					Else
						Button1.BackColor = Drawing.Color.Red
						Button1.Text = "OFF"
					End If
					preValue = result
				End If
			End If
		End If
	End Sub

	Public Sub CalcRequestCommand(Optional ByVal write As Boolean = False, Optional ByVal value As Integer = 0)
		If IsNothing(link) Then
			link = New PLCLink
		End If
		If write Then
			If value = 0 Then
				link.cmd = "RS " & link.add.MemType & link.add.MemAdd
			Else
				link.cmd = "ST " & link.add.MemType & link.add.MemAdd
			End If
		Else
			link.cmd = "RD " & link.add.MemType & link.add.MemAdd & link.add.format
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If Button1.Text = "ON" Then
			CalcRequestCommand(True, 0)
		Else
			CalcRequestCommand(True, 1)
		End If
	End Sub
End Class
