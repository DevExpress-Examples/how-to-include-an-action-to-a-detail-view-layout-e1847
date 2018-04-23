Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Layout

Namespace DetailViewButton.Module.Win
    Public Interface IModelButtonDetailViewItemWin
        Inherits IModelViewItem

    End Interface

    <ViewItemAttribute(GetType(IModelButtonDetailViewItemWin))> _
    Public Class ButtonDetailViewItemWin
        Inherits ViewItem

        Public Sub New(ByVal model As IModelViewItem, ByVal objectType As Type)
            MyBase.New(objectType, model.Id)
            CreateControl()
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
