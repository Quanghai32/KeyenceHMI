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

Public Class PLCButtonChange_Designer
	Inherits System.Windows.Forms.Design.ControlDesigner
	Private _actionLists As DesignerActionListCollection
	Public Overrides ReadOnly Property actionLists As DesignerActionListCollection
		Get
			If IsNothing(_actionLists) Then
				_actionLists = New DesignerActionListCollection()
				_actionLists.Add(New PLCButtonChange_ActionLists(Me.Component))
			End If
			Return _actionLists
		End Get
	End Property
End Class
