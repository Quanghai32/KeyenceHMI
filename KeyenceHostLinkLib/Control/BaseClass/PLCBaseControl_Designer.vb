'
' Created by SharpDevelop.
' User: v106804
' Date: 28-Apr-16
' Time: 1:52 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.ComponentModel.Design
Imports System.Windows.Forms.Design

Public Class PLCBaseControl_Designer(Of T As {DesignerActionList})
	Inherits System.Windows.Forms.Design.ControlDesigner
	Private _actionLists As DesignerActionListCollection
	Public Overrides ReadOnly Property actionLists As DesignerActionListCollection
		Get
			If IsNothing(_actionLists) Then
				_actionLists = New DesignerActionListCollection()
				Dim aaa As Object = Activator.CreateInstance(GetType(T), Me.Component)
				_actionLists.Add(CType(aaa, T))
			End If
			Return _actionLists
		End Get
	End Property
End Class
