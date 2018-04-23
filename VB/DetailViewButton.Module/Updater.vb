Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl

Namespace DetailViewButton.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()

			Dim testPerson As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'Sam'"))
			If testPerson Is Nothing Then
				testPerson = ObjectSpace.CreateObject(Of Person)()
				testPerson.FirstName = "Sam"
				testPerson.Save()
			End If
		End Sub
	End Class
End Namespace
