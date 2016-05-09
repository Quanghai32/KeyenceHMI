Imports System.Net
Imports System.ComponentModel

Public Class PLCBaseControl
	Public preValue As String = ""
	Public link As PLCLink
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
			CalcCommand()
		End Set
	End Property
	Private _PLCLink As HostlinkKeyence
	<Category("PLC connection")>
	Public Property PLCLink() As HostlinkKeyence
		Get
			Return _PLCLink
		End Get
		Set(ByVal value As HostlinkKeyence)
			_PLCLink = value
			If IsNothing(link) Then link = New PLCLink
			link.usingmethod = Me
			link.enable = True
			CalcCommand()
			_PLCLink.AddLink(link)
		End Set
	End Property
	Private _MemType As String
	<Category("PLC connection")>
	Public Property MemoryType() As String
		Get
			Return _MemType
		End Get
		Set(ByVal value As String)
			_MemType = value
			If IsNothing(link) Then link = New PLCLink
			link.add.MemType = _MemType
			CalcCommand()
		End Set
	End Property
#End Region
	Public Overridable Sub CalcCommand(Optional ByVal Write As Boolean = False, Optional ByVal value As String = "")
		If IsNothing(link) Then
			link = New PLCLink
		End If
		If Write Then
			link.cmd = "WR " & link.add.MemType & link.add.MemAdd & link.add.format & " " & value
		Else
			link.cmd = "RD " & link.add.MemType & link.add.MemAdd & link.add.format
		End If
	End Sub
End Class
