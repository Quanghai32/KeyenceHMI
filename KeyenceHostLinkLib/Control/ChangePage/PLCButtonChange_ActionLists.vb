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
Imports System.Windows.Forms

Public Class PLCButtonChange_ActionLists
	Inherits DesignerActionList
	Private dtc As PLCButtonChange
	Private designerActionUISvc As DesignerActionUIService
	Public Sub New(ByRef component As IComponent)
		MyBase.New(component)
		Me.dtc = TryCast(component, PLCButtonChange)

		' Cache a reference to DesignerActionUIService, so the
		' DesigneractionList can be refreshed.
		Me.designerActionUISvc = TryCast(GetService(GetType(DesignerActionUIService)), DesignerActionUIService)
	End Sub
	Property MainPage() As TabControl
		Get
			Return dtc.MainPage
		End Get
		Set(value As TabControl)
			GetPropertyByName("MainPage").SetValue(dtc, value)
		End Set
	End Property
	Property NextPage() As TabPage
		Get
			Return dtc.NextPage
		End Get
		Set(value As TabPage)
			GetPropertyByName("NextPage").SetValue(dtc, value)
		End Set
	End Property
	Property ButtonText As String
		Get
			Return dtc.Button1.Text
		End Get
		Set(value As String)
			GetPropertyByName("ButtonText").SetValue(dtc, value)
			dtc.Button1.Text = value
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
