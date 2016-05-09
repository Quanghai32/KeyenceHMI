'
' Created by SharpDevelop.
' User: v106804
' Date: 04-May-16
' Time: 10:20 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Drawing.Design
Imports System.Windows.Forms.Design
Imports System.Windows.Forms
Public Class CustomListPropertiesEditor
	Inherits UITypeEditor
	Public MemoryName() As String = New String(){"Relay","Link relay","Internal auxiliary relay","Latch relay","Control relay","Virtual relay","Data memory","Extended data memory","File register","Link register (FM)","Link register (ZF)","Temporary data memory","Index register","Timer","Timer (current value)","Timer (setting value)","Counter","Counter (current value)","Counter (setting value)","High-speed counter","High-speed counter comparator (setting value)","Digital trimmer","Control memory","Virtual memory"} 
	Public MemoryValue() As String = New String(){"R","B","MR","LR","CR","VB","DM","EM","FM","ZF","W","TM","Z","T","TC","TS","C","CC","CS","CTH","CTC","AT","CM","VM"}
	Private frmsvr As IWindowsFormsEditorService
	Public Sub New()
		
	End Sub
	Public Overrides Function GetEditStyle(context As System.ComponentModel.ITypeDescriptorContext) As UITypeEditorEditStyle
		Return UITypeEditorEditStyle.DropDown
	End Function
	Public Overrides Function EditValue(context As System.ComponentModel.ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
		frmsvr = CType(provider.GetService(GetType(IWindowsFormsEditorService)),IWindowsFormsEditorService)
		If (IsNothing(frmsvr)) Then
			return nothing
		End If
		Dim lstbox As ListBox = New ListBox()
		lstbox.Items.AddRange(MemoryName)
		lstbox.SelectedIndex = 0
		AddHandler lstbox.SelectedIndexChanged, AddressOf ListBox1SelectedIndexChanged
		frmsvr.DropDownControl(lstbox)
		Return MemoryValue(lstbox.SelectedIndex)
	End Function
	
	Private Sub ListBox1SelectedIndexChanged(sender As Object, e As EventArgs)
		frmsvr.CloseDropDown()
	End Sub
End Class
