Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace DetailViewButton.Web
    Partial Public Class DetailViewButtonAspNetApplication
        Inherits WebApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private module3 As DetailViewButton.Module.DetailViewButtonModule
        Private module4 As DetailViewButton.Module.Web.DetailViewButtonAspNetModule
        Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
        Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

        Public Sub New()
            InitializeComponent()
           ' DelayedViewItemsInitialization = false;
        End Sub

        Private Sub DetailViewButtonAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub

        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.module3 = New DetailViewButton.Module.DetailViewButtonModule()
            Me.module4 = New DetailViewButton.Module.Web.DetailViewButtonAspNetModule()
            Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' module1
            ' 
            Me.module1.AdditionalExportedTypes.Add(GetType(DevExpress.Xpo.XPObjectType))
            ' 
            ' module5
            ' 
            Me.module5.AllowValidationDetailsAccess = True
            ' 
            ' DetailViewButtonAspNetApplication
            ' 
            Me.ApplicationName = "DetailViewButton"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module6)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.module5)
            Me.Modules.Add(Me.securityModule1)
'            Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.DetailViewButtonAspNetApplication_DatabaseVersionMismatch)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
