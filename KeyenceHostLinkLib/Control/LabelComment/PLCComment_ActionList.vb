Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design

Public Class PLCComment_ActionList
	Inherits DesignerActionList
	Friend dtc As PLCComment
	Public designerActionUISvc As DesignerActionUIService
	Public Sub New(ByRef component As IComponent)
		MyBase.New(component)
		Me.dtc = TryCast(component, PLCComment)

		' Cache a reference to DesignerActionUIService, so the
		' DesigneractionList can be refreshed.
		Me.designerActionUISvc = TryCast(GetService(GetType(DesignerActionUIService)), DesignerActionUIService)
	End Sub
	<Editor(GetType(PLCBaseControl_MemoryType_Editer), GetType(UITypeEditor)), DefaultValue(".U")>
	Public Property MemoryType() As String
		Get
			Return dtc.MemoryType
		End Get
		Set(value As String)
			GetPropertyByName("MemoryType").SetValue(dtc, value)
		End Set
	End Property
	Public Property MemoryAddress() As Integer
		Get
			Return dtc.PLCAddress
		End Get
		Set(value As Integer)
			GetPropertyByName("PLCAddress").SetValue(dtc, value)
		End Set
	End Property
	Public Property PLC_Link() As HostlinkKeyence
		Get
			Return dtc.PLCLink
		End Get
		Set(value As HostlinkKeyence)
			GetPropertyByName("PLCLink").SetValue(dtc, value)
		End Set
	End Property
	Private Function GetPropertyByName(propName As String) As PropertyDescriptor
		Dim prop As PropertyDescriptor
		prop = TypeDescriptor.GetProperties(dtc)(propName)
		If prop Is Nothing Then
			Throw New ArgumentException("Matching Target property not found!", propName)
		Else
			Return prop
		End If
	End Function
End Class