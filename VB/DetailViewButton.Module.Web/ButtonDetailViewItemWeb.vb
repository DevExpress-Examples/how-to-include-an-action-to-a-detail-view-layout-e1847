Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.ExpressApp.Editors
Imports System.Web.UI.WebControls
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Web.Editors.ASPx

Namespace WebSolution.Module.Web
	Public Class ButtonDetailViewItemWeb
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
			Dim button As New ASPxButtonEx()
			button.Text = "MyButton Two"
			button.EnableClientSideAPI = True
			AddHandler button.Click, AddressOf button_Click
			Return button
		End Function
		Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Perform the required actions on the server side.
		End Sub
	End Class
End Namespace
