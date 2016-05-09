Imports System.Net
Imports System.Timers
Imports System.Net.Sockets
Imports System.ComponentModel
Imports System.ComponentModel.Design

Public Class HostlinkKeyence
	Public ConnList As List(Of PLCLink)
	Private WithEvents periodTimer As Timer
	Private connection As TcpClient

#Region "Properties"
	Private _IP As String = "192.168.0.10"
	Private _port As Integer = 8501
	<DefaultValue("192.168.0.10")>
	Public Property IP As String
		Get
			Return _IP
		End Get
		Set(value As String)
			_IP = value
		End Set
	End Property
	<DefaultValue(8501)>
	Public Property port() As Integer
		Get
			Return _port
		End Get
		Set(ByVal value As Integer)
			_port = value
		End Set
	End Property
	Private _time As Double = 100
	<DefaultValue(100)>
	Public Property time() As Double
		Get
			Return _time
		End Get
		Set(ByVal value As Double)
			_time = value
			If IsNothing(periodTimer) Then
				periodTimer = New Timer
			End If
			periodTimer.Interval = value
			periodTimer.Start()
		End Set
	End Property
	Private m_Name As String
	<BrowsableAttribute(False)>
	Public Property Name As String
		Get
			Return m_Name
		End Get
		Set(value As String)
			m_Name = value
		End Set
	End Property
#End Region

	Public Sub SendRequest(ByRef link As PLCLink)
		If link.enable = False Then Return
		Dim returnStr As String
		If IsNothing(connection) Then
			Debug.Print("Creat connection")
			connection = New TcpClient()
		End If
		If Not connection.Connected Then
			Try
				'connection.ConnectAsync(_IP, _port)
				connection.Connect(_IP, _port)
				Debug.Print("Start connecting ...")
				Dim timeout As Integer = Environment.TickCount
				While ((timeout + 5000) > Environment.TickCount) And (connection.Connected = False)
				End While
				If connection.Connected = True Then
					Debug.Print("Connected!")
				End If
			Catch ex As Exception

			End Try
		End If

		If connection.Connected Then
			returnStr = ReadCommand(link)
			link.usingmethod.useResult(returnStr)
		Else

		End If
	End Sub
	Public Function ReadCommand(ByRef link As PLCLink) As String
		Dim str As String = link.cmd
		Dim dataByte() As Byte = System.Text.Encoding.ASCII.GetBytes(str)
		Dim dataByte2() As Byte = New Byte(0) {&HD}
		Dim stream As NetworkStream = connection.GetStream()
		Debug.Print("Start sending command ...")
		stream.Write(dataByte, 0, dataByte.Length)
		stream.Write(dataByte2, 0, dataByte2.Length)
		Debug.Print("Command was send!")
		Dim timeout As Integer = Environment.TickCount
		While connection.Available = 0 And (timeout + 5000) > Environment.TickCount

		End While
		If connection.Available <> 0 Then
			Debug.Print("Reading data ...")
			Dim receiveByte() As Byte = New Byte(connection.ReceiveBufferSize) {}
			stream.Read(receiveByte, 0, receiveByte.Length)
			Debug.Print("Data was read!")
			Dim retStr As String = System.Text.Encoding.ASCII.GetString(receiveByte, 0, receiveByte.Length)
			Return retStr
		End If
		Debug.Print("Time out!")
		Return ""
	End Function

	Public Sub AddLink(link As PLCLink)
		If IsNothing(ConnList) Then
			ConnList = New List(Of PLCLink)
		End If
		ConnList.Add(link)
	End Sub

	Public Sub SyncCircle(source As Object, e As ElapsedEventArgs) Handles periodTimer.Elapsed
		periodTimer.Enabled = False
		If IsNothing(ConnList) Then
			periodTimer.Start()
			Return
		End If
		If ConnList.Count = 0 Then
			periodTimer.Start()
			Return
		End If
		For i As Integer = 0 To ConnList.Count - 1
			SendRequest(ConnList(i))
		Next
		periodTimer.Start()
	End Sub
	
	Public Overrides Function ToString() As String
		Return ""
	End Function
	#Region "For design-time"
	Private WithEvents _compChServ As IComponentChangeService
	Public Overrides Property Site() As ISite
         Get
            Return MyBase.Site
         End Get
         Set(ByVal Value As ISite)
         	
         	If _compChServ IsNot Nothing Then 
         		RemoveHandler _compChServ.ComponentRename, AddressOf nameChanged
         	End If
         	MyBase.Site = Value
         	If value IsNot Nothing Then
         		If value.Component IsNot Nothing Then
         			CType(value.Component,HostlinkKeyence).Name = value.Name 
         		End If
         	End If
            _compChServ = CType(GetService(GetType(IComponentChangeService)), IComponentChangeService)
            
            If _compChServ IsNot Nothing Then 
            	AddHandler _compChServ.ComponentRename, AddressOf nameChanged
            End If
            	
         End Set
    End Property
    
    Private Sub nameChanged(ByVal sender As Object, ByVal e As _
                            ComponentRenameEventArgs)
    	CType(e.Component,HostlinkKeyence).Name = e.NewName
    End Sub
    
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        	If _compChServ IsNot Nothing Then 
        		RemoveHandler _compChServ.ComponentRename, AddressOf nameChanged
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
	#End Region
	
    
End Class
