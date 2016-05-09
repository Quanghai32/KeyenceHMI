'
' Created by SharpDevelop.
' User: v106804
' Date: 04-May-16
' Time: 11:59 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class PLCNumberbox_DataFormat_Editer
	Inherits CustomListPropertiesEditor
	Public Sub New()
		MyBase.MemoryName = New String(){"Unsigned 16-bit DEC (.U)","Signed 16-bit DEC (.S)","Unsigned 32-bit DEC (.D)","Signed 32-bit DEC (.L)","16-bit HEX (.H)"}
		MyBase.MemoryValue = New String(){".U",".S",".D",".L",".H"} 
	End Sub
End Class
