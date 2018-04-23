Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace DetailViewButton.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()

			Dim testPerson As Person = Session.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'Sam'"))
			If testPerson Is Nothing Then
				testPerson = New Person(Session)
				testPerson.FirstName = "Sam"
				testPerson.Save()
			End If
		End Sub
	End Class
End Namespace
