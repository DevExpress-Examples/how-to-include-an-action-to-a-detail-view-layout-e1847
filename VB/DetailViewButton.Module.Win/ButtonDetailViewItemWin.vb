Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Editors
Imports System.Windows.Forms

Namespace DetailViewButton.Module.Win
	Public Class ButtonDetailViewItemWin
		Inherits DetailViewItem
		Public Sub New(ByVal id As String, ByVal caption As String)
			MyBase.New(id)
		End Sub
		Public Sub New(ByVal id As String)
			Me.New(id, Nothing)
		End Sub
		Public Sub New(ByVal objectType As Type, ByVal info As DictionaryNode)
			MyBase.New(objectType, info)
		End Sub
		Protected Overrides Function CreateControlCore() As Object
			Dim button As New Button()
			button.Text = "MyButton Two"
			AddHandler button.Click, AddressOf button_Click
			Return button
		End Function
		Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
			'Perform the required actions here
		End Sub
	End Class
End Namespace
