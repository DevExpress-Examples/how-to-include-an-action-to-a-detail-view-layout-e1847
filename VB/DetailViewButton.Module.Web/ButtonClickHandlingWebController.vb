Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Layout
Imports DevExpress.ExpressApp.Web.Editors.ASPx
Imports DevExpress.Web.ASPxEditors

Namespace DetailViewButton.Module.Web
	Partial Public Class ButtonClickHandlingWebController
		Inherits ViewController
		Public Sub New()
			TargetViewId = "Person_DetailView"
			AddHandler ViewControlsCreated, AddressOf ButtonClickHandlingWebController_ViewControlsCreated
		End Sub
		Private Sub ButtonClickHandlingWebController_ViewControlsCreated(ByVal sender As Object, ByVal e As EventArgs)
            Dim detailView As DetailView = CType(View, DetailView)
            For Each item As ControlDetailItem In detailView.GetItems(Of ControlDetailItem)()
                If item.Id = "MyButton One" Then
                    TryCast(item.Control, ASPxButton).Text = "MyButton One"
                    AddHandler TryCast(item.Control, ASPxButton).Click, AddressOf ButtonClickHandlingWebController_Click
                    Exit For
                End If
            Next item
		End Sub
		Private Sub ButtonClickHandlingWebController_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Perform the required actions on the server side.
		End Sub
	End Class
End Namespace
