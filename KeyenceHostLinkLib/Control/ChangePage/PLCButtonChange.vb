Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing

<Serializable(), Designer(GetType(PLCBaseControl_Designer(Of PLCButtonChange_ActionLists)))>
Public Class PLCButtonChange

#Region "Properties"
	Private _MainPage As TabControl
	Public Property MainPage() As TabControl
		Get
			Return _MainPage
		End Get
		Set(ByVal value As TabControl)
			_MainPage = value
		End Set
	End Property
	Private _NextPage As TabPage
	Public Property NextPage() As TabPage
		Get
			Return _NextPage
		End Get
		Set(ByVal value As TabPage)
			_NextPage = value
		End Set
	End Property
	Public Property ButtonText() As String
		Get
			Return Button1.Text
		End Get
		Set(ByVal value As String)
			Button1.Text = value
		End Set
	End Property
	Public Property ButtonType() As FlatStyle
		Get
			Return Button1.FlatStyle
		End Get
		Set(ByVal value As FlatStyle)
			Button1.FlatStyle = value
		End Set
	End Property

#End Region
	Private Sub PLCButtonChange_FontChanged(sender As Object, e As EventArgs) Handles MyBase.FontChanged
		Button1.Font = Font
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If Not IsNothing(MainPage) Then
			If Not IsNothing(NextPage) Then
				MainPage.SelectedTab = NextPage
			End If
		End If
	End Sub


	Private Sub PLCButtonChange_Load(sender As Object, e As EventArgs) Handles Me.Load
		If Not IsNothing(MainPage) And Not DesignMode Then
			MainPage.ItemSize = New Size(0, 1)
			'MainPage.SizeMode = TabSizeMode.Fixed
			'MainPage.Appearance = TabAppearance.FlatButtons
		End If
	End Sub
End Class
