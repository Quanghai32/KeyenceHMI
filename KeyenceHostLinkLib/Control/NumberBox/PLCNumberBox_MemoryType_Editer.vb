'
' Created by SharpDevelop.
' User: v106804
' Date: 04-May-16
' Time: 11:41 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class PLCNumberBox_MemoryType_Editer
	Inherits CustomListPropertiesEditor
	Public Sub New()
		MyBase.MemoryName = New String(){"Relay (R)","Link relay (B)","Internal auxiliary relay (MR)","Latch relay (LR)","Control relay (CR)","Virtual relay (VB)","Data memory (DM)","Extended data memory (EM)","File register (FM)","File register (ZF)","Link register (W)","Temporary data memory (TM)","Index register (Z)","Timer (T)","Timer (current value) (TC)","Timer (setting value) (TS)","Counter (C)","Counter (current value) (CC)","Counter (setting value) (CS)","High-speed counter (CTH)","High-speed counter comparator (setting value) (CTC)","Digital trimmer (AT)","Control memory (CM)","Virtual memory (VM)"}
		MyBase.MemoryValue = New String(){"R","B","MR","LR","CR","VB","DM","EM","FM","ZF","W","TM","Z","T","TC","TS","C","CC","CS","CTH","CTC","AT","CM","VM"}
	End Sub
End Class
