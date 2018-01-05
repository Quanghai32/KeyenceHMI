Imports System.Net
Imports System.ComponentModel
Imports System.Drawing.Design

<Serializable(), Designer(GetType(PLCBaseControl_Designer(Of PLCBaseControl_ActionLists)))>
Public Class PLCBaseControl
	Inherits System.Windows.Forms.UserControl
	Public preValue As String = ""
	Public link As PLCLink
#Region "Properties"
	Private _PLCAdress As Integer = 100
	<Category("PLC connection"), DefaultValue(100)>
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
			'If IsNothing(link) Then Return
			_PLCLink = value
			If IsNothing(value) Then Return
			If IsNothing(link) Then link = New PLCLink
			link.usingmethod = Me
			link.enable = True
			CalcCommand()
			_PLCLink.AddLink(link)
		End Set
	End Property
	Private _dataFormat As String = ".U"
	<Category("PLC connection"), Editor(GetType(PLCBaseControl_DataFormat_Editer), GetType(UITypeEditor)), DefaultValue(".U")>
	Public Property DataFormat() As String
		Get
			Return _dataFormat
		End Get
		Set(ByVal value As String)
			_dataFormat = value
			If IsNothing(link) Then link = New PLCLink
			link.add.format = value
			CalcCommand()
		End Set
	End Property
	Private _MemType As String = "DM"
	<Category("PLC connection"), Editor(GetType(PLCBaseControl_MemoryType_Editer), GetType(UITypeEditor)), DefaultValue("DM")>
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
		link.add.MemType = MemoryType
		link.add.MemAdd = PLCAddress
		link.add.format = DataFormat
		If Write Then
			link.cmd = "WR " & link.add.MemType & link.add.MemAdd & link.add.format & " " & value
		Else
			link.cmd = "RD " & link.add.MemType & link.add.MemAdd & link.add.format
		End If
	End Sub
End Class
