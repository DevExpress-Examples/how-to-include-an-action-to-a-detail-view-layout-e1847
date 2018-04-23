Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Layout

Namespace DetailViewButton.Module.Win
    Partial Public Class ButtonClickHandlingWinController
        Inherits ViewController

        Public Sub New()
            TargetViewId = "Person_DetailView"
            AddHandler ViewControlsCreated, AddressOf ButtonClickHandlingWinController_ViewControlsCreated
        End Sub
        Private Sub ButtonClickHandlingWinController_ViewControlsCreated(ByVal sender As Object, ByVal e As EventArgs)
            Dim _view As DetailView = CType(View, DetailView)
            For Each item As ControlDetailItem In _view.GetItems(Of ControlDetailItem)()
                If item.Id = "MyButton One" Then
                    TryCast(item.Control, Button).Text = "MyButton One"
                    AddHandler TryCast(item.Control, Button).Click, AddressOf ButtonClickHandlingWinController_Click
                    Exit For
                End If
            Next item
        End Sub
        Private Sub ButtonClickHandlingWinController_Click(ByVal sender As Object, ByVal e As EventArgs)
            'Perform the required actions here
        End Sub
    End Class
End Namespace