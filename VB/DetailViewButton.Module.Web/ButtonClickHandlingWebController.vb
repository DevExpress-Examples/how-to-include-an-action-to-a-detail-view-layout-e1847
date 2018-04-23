Imports System.ComponentModel
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
            Dim _view As DetailView = CType(View, DetailView)
            For Each item As ControlDetailItem In _view.GetItems(Of ControlDetailItem)()
                If (item.Id = "MyButton One") Then
                    AddHandler item.ControlCreated, AddressOf item_ControlCreated
                    If item.Control IsNot Nothing Then
                        CType(item.Control, ASPxButton).Text = "MyButton One"
                    End If
                End If
            Next item
        End Sub

        Private Sub item_ControlCreated(ByVal sender As Object, ByVal e As EventArgs)
            CType(CType(sender, ControlDetailItem).Control, ASPxButton).Text = "MyButton One"
            AddHandler CType(CType(sender, ControlDetailItem).Control, ASPxButton).Click, AddressOf ButtonClickHandlingWebController_Click
            RemoveHandler CType(sender, ControlDetailItem).ControlCreated, AddressOf item_ControlCreated
        End Sub
        Private Sub ButtonClickHandlingWebController_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Perform the required actions on the server side.
            RemoveHandler CType(sender, ASPxButton).Click, AddressOf ButtonClickHandlingWebController_Click
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler ViewControlsCreated, AddressOf ButtonClickHandlingWebController_ViewControlsCreated
            MyBase.OnDeactivated()
        End Sub
    End Class
End Namespace
