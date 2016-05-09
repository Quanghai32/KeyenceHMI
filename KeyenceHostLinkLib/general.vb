Imports System.Net.Sockets

Public Module general
	
	Structure PLCMemory
		Public MemType As String
		Public MemAdd As Integer
		Public format As String
	End Structure
	Class PLCLink
		Public add As PLCMemory
		Public usingmethod As IPLCControl
		Public enable As Boolean
		Public cmd As String
	End Class
	Public Interface IPLCControl
		Sub useResult(ByVal result As String)
	End Interface
End Module
