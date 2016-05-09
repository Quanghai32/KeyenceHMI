'
' Created by SharpDevelop.
' User: v106804
' Date: 28-Apr-16
' Time: 1:50 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.ComponentModel
Imports System.ComponentModel.Design

Public Class PLCRunningStatus_ActionLists
	Inherits DesignerActionList
	Private dtc As PLCBaseControl
	Private designerActionUISvc As DesignerActionUIService
	Public Sub New(ByRef component As IComponent)
		MyBase.New(component)
		Me.dtc = TryCast(component, PLCRunningStatus2)

		' Cache a reference to DesignerActionUIService, so the
		' DesigneractionList can be refreshed.
		Me.designerActionUISvc = TryCast(GetService(GetType(DesignerActionUIService)), DesignerActionUIService)
	End Sub
	
	Public Property PLC_Link() As HostlinkKeyence
		Get
			Return dtc.PLCLink
		End Get
		Set(value As HostlinkKeyence)
			'dtc.PLCLink = value
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
