Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.ExpressApp.Editors
Imports System.Web.UI.WebControls
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Web.Editors.ASPx
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Layout

Namespace WebSolution.Module.Web
	Public Interface IModelButtonDetailViewItemWeb
        Inherits IModelViewItem
	End Interface
	<ViewItemAttribute(GetType(IModelButtonDetailViewItemWeb))> _
	Public Class ButtonDetailViewItemWeb
		Inherits ViewItem
        Public Sub New(ByVal model As IModelViewItem, ByVal objectType As Type)
            MyBase.New(objectType, model.Id)
            CreateControl()
        End Sub
		Protected Overrides Function CreateControlCore() As Object
			Dim button As New ASPxButton()
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
