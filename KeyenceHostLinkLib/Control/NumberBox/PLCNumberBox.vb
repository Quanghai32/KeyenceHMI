Imports System.Net
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Drawing
Imports System.Windows.Forms

<Serializable(), Designer(GetType(PLCNumberBox_Designer))>
Public Class PLCNumberBox
	Implements IPLCControl

	Private _IP As IPAddress
	Private _port As Integer
	Private preValue As String = ""
	Private link As PLCLink
#Region "Properties"
	Private _PLCAdress As Integer = 0
	<Category("PLC connection"), DefaultValue(0)>
	Public Property PLCAddress() As Integer
		Get
			Return _PLCAdress
		End Get
		Set(ByVal value As Integer)
			_PLCAdress = value
		End Set
	End Property
	Private _PLCLink As HostlinkKeyence = Nothing
	<Category("PLC connection")>
	Public Property PLCLink() As HostlinkKeyence
		Get
			Return _PLCLink
		End Get
		Set(ByVal value As HostlinkKeyence)
			If IsNothing(value) Then
				_PLCLink = value
				Return
			End If
			If IPAddress.TryParse(value.IP, _IP) Then
				_port = value.port
			End If
			_PLCLink = value
			If IsNothing(link) Then link = New PLCLink
			link.add.MemAdd = _PLCAdress
			'link.add.format = ".U"
			link.add.format = _dataFormat
			link.add.MemType = m_MemoryType
			link.usingmethod = Me
			link.enable = True
			CalcRequestCommand()
			_PLCLink.AddLink(link)
		End Set
	End Property
	Private _dataFormat As String = ".U"
	<Category("PLC connection"), Editor(GetType(PLCNumberbox_DataFormat_Editer), GetType(UITypeEditor)), DefaultValue(".U")>
	Public Property DataFormat() As String
		Get
			Return _dataFormat
		End Get
		Set(ByVal value As String)
			_dataFormat = value
		End Set
	End Property
	Private m_MemoryType As String = "DM"
	<Category("PLC connection"), Editor(GetType(PLCNumberBox_MemoryType_Editer), GetType(UITypeEditor)), DefaultValue("DM")>
	Public Property MemoryType As String
		Get
			Return m_MemoryType
		End Get
		Set(value As String)
			m_MemoryType = value
		End Set
	End Property
	<Category("Appearance")>
	Public Property InputColor() As Color
		Get
			Return txtValue.BackColor
		End Get
		Set(ByVal value As Color)
			txtValue.BackColor = value
		End Set
	End Property
	Public Overrides Property Font As Font
		Get
			Return txtValue.Font
		End Get
		Set(value As Font)
			txtValue.Font = value
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
	End Sub

	Public Sub CalcRequestCommand()
		If IsNothing(link) Then
			link = New PLCLink
		End If
		link.cmd = "RD " & link.add.MemType & link.add.MemAdd & link.add.format
		If _dataFormat = ".H" Then

		End If
	End Sub

End Class
