Partial Class StructIQe
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabstructIQe = Me.Factory.CreateRibbonTab
        Me.grpProjectManager = Me.Factory.CreateRibbonGroup
        Me.btnNewProject = Me.Factory.CreateRibbonButton
        Me.Button11 = Me.Factory.CreateRibbonButton
        Me.grp_MailManager = Me.Factory.CreateRibbonGroup
        Me.Button5 = Me.Factory.CreateRibbonButton
        Me.Button6 = Me.Factory.CreateRibbonButton
        Me.grp_QualityButtons = Me.Factory.CreateRibbonGroup
        Me.btnSubmit_for_QC = Me.Factory.CreateRibbonButton
        Me.Button2 = Me.Factory.CreateRibbonButton
        Me.Button17 = Me.Factory.CreateRibbonButton
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.Button18 = Me.Factory.CreateRibbonButton
        Me.grpTimeManager = Me.Factory.CreateRibbonGroup
        Me.Button7 = Me.Factory.CreateRibbonButton
        Me.Button16 = Me.Factory.CreateRibbonButton
        Me.Button8 = Me.Factory.CreateRibbonButton
        Me.grp_TaskManager = Me.Factory.CreateRibbonGroup
        Me.Button13 = Me.Factory.CreateRibbonButton
        Me.Button15 = Me.Factory.CreateRibbonButton
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.Button1 = Me.Factory.CreateRibbonButton
        Me.btnLicenseOptions = Me.Factory.CreateRibbonButton
        Me.grpCompanySettings = Me.Factory.CreateRibbonGroup
        Me.Button10 = Me.Factory.CreateRibbonButton
        Me.Button12 = Me.Factory.CreateRibbonButton
        Me.Button9 = Me.Factory.CreateRibbonButton
        Me.Group6 = Me.Factory.CreateRibbonGroup
        Me.Button_Check_for_Updates = Me.Factory.CreateRibbonButton
        Me.Button3 = Me.Factory.CreateRibbonButton
        Me.Button4 = Me.Factory.CreateRibbonButton
        Me.TabstructIQe.SuspendLayout()
        Me.grpProjectManager.SuspendLayout()
        Me.grp_MailManager.SuspendLayout()
        Me.grp_QualityButtons.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.grpTimeManager.SuspendLayout()
        Me.grp_TaskManager.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.grpCompanySettings.SuspendLayout()
        Me.Group6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabstructIQe
        '
        Me.TabstructIQe.Groups.Add(Me.grpProjectManager)
        Me.TabstructIQe.Groups.Add(Me.grp_MailManager)
        Me.TabstructIQe.Groups.Add(Me.grp_QualityButtons)
        Me.TabstructIQe.Groups.Add(Me.Group2)
        Me.TabstructIQe.Groups.Add(Me.grpTimeManager)
        Me.TabstructIQe.Groups.Add(Me.grp_TaskManager)
        Me.TabstructIQe.Groups.Add(Me.Group1)
        Me.TabstructIQe.Groups.Add(Me.grpCompanySettings)
        Me.TabstructIQe.Groups.Add(Me.Group6)
        Me.TabstructIQe.KeyTip = "P"
        Me.TabstructIQe.Label = "PROJECT Assist"
        Me.TabstructIQe.Name = "TabstructIQe"
        '
        'grpProjectManager
        '
        Me.grpProjectManager.Items.Add(Me.btnNewProject)
        Me.grpProjectManager.Items.Add(Me.Button11)
        Me.grpProjectManager.Label = "Project"
        Me.grpProjectManager.Name = "grpProjectManager"
        '
        'btnNewProject
        '
        Me.btnNewProject.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnNewProject.KeyTip = "QC"
        Me.btnNewProject.Label = "New"
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.OfficeImageId = "NewFolder"
        Me.btnNewProject.ScreenTip = "New"
        Me.btnNewProject.ShowImage = True
        Me.btnNewProject.SuperTip = "Create a new project following your company's guidelines."
        '
        'Button11
        '
        Me.Button11.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button11.KeyTip = "QC"
        Me.Button11.Label = "Manage"
        Me.Button11.Name = "Button11"
        Me.Button11.OfficeImageId = "ArrangeByAssignment"
        Me.Button11.ScreenTip = "Manage"
        Me.Button11.ShowImage = True
        Me.Button11.SuperTip = "Manage your projects by viewing, editing, or updating project details as per your" &
    " requirements."
        '
        'grp_MailManager
        '
        Me.grp_MailManager.Items.Add(Me.Button5)
        Me.grp_MailManager.Items.Add(Me.Button6)
        Me.grp_MailManager.Label = "Mail"
        Me.grp_MailManager.Name = "grp_MailManager"
        Me.grp_MailManager.Visible = False
        '
        'Button5
        '
        Me.Button5.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button5.KeyTip = "QC"
        Me.Button5.Label = "Archive"
        Me.Button5.Name = "Button5"
        Me.Button5.OfficeImageId = "MailMergeStartLabels"
        Me.Button5.ScreenTip = "Archive"
        Me.Button5.ShowImage = True
        '
        'Button6
        '
        Me.Button6.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button6.KeyTip = "QC"
        Me.Button6.Label = "Archive multiple"
        Me.Button6.Name = "Button6"
        Me.Button6.OfficeImageId = "MailMergeStartMailMergeMenu"
        Me.Button6.ScreenTip = "Archive multiple"
        Me.Button6.ShowImage = True
        '
        'grp_QualityButtons
        '
        Me.grp_QualityButtons.Items.Add(Me.btnSubmit_for_QC)
        Me.grp_QualityButtons.Items.Add(Me.Button2)
        Me.grp_QualityButtons.Items.Add(Me.Button17)
        Me.grp_QualityButtons.Label = "Quality"
        Me.grp_QualityButtons.Name = "grp_QualityButtons"
        '
        'btnSubmit_for_QC
        '
        Me.btnSubmit_for_QC.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnSubmit_for_QC.KeyTip = "QC"
        Me.btnSubmit_for_QC.Label = "Submit for QC"
        Me.btnSubmit_for_QC.Name = "btnSubmit_for_QC"
        Me.btnSubmit_for_QC.OfficeImageId = "ListToolImport"
        Me.btnSubmit_for_QC.ScreenTip = "Submit for QC"
        Me.btnSubmit_for_QC.ShowImage = True
        Me.btnSubmit_for_QC.SuperTip = "Submit Documents, Drawings or any other type of File for Internal Quality Checks." &
    ""
        '
        'Button2
        '
        Me.Button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button2.KeyTip = "QC"
        Me.Button2.Label = "Submit QC Status"
        Me.Button2.Name = "Button2"
        Me.Button2.OfficeImageId = "ReviewingPane"
        Me.Button2.ScreenTip = "Submit QC Status"
        Me.Button2.ShowImage = True
        Me.Button2.SuperTip = "Submit QC Report for the Documents, Drawings or any other type of File after Inte" &
    "rnal Quality Checks."
        '
        'Button17
        '
        Me.Button17.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button17.KeyTip = "QC"
        Me.Button17.Label = "Review QC Status"
        Me.Button17.Name = "Button17"
        Me.Button17.OfficeImageId = "ReviewingPane"
        Me.Button17.ScreenTip = "Review QC Status"
        Me.Button17.ShowImage = True
        Me.Button17.SuperTip = "Review QC Status/Reports for all Documents, Drawings or any other type of File fo" &
    "r a Project."
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.Button18)
        Me.Group2.Label = "Drawings"
        Me.Group2.Name = "Group2"
        Me.Group2.Visible = False
        '
        'Button18
        '
        Me.Button18.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button18.KeyTip = "QC"
        Me.Button18.Label = "Manage"
        Me.Button18.Name = "Button18"
        Me.Button18.OfficeImageId = "AccessFormModalDialog"
        Me.Button18.ScreenTip = "Manage Drawings"
        Me.Button18.ShowImage = True
        '
        'grpTimeManager
        '
        Me.grpTimeManager.Items.Add(Me.Button7)
        Me.grpTimeManager.Items.Add(Me.Button16)
        Me.grpTimeManager.Items.Add(Me.Button8)
        Me.grpTimeManager.Label = "Time Sheet"
        Me.grpTimeManager.Name = "grpTimeManager"
        Me.grpTimeManager.Visible = False
        '
        'Button7
        '
        Me.Button7.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button7.KeyTip = "QC"
        Me.Button7.Label = "Submit"
        Me.Button7.Name = "Button7"
        Me.Button7.OfficeImageId = "TimeInsert"
        Me.Button7.ScreenTip = "Submit"
        Me.Button7.ShowImage = True
        '
        'Button16
        '
        Me.Button16.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button16.KeyTip = "QC"
        Me.Button16.Label = "Approve"
        Me.Button16.Name = "Button16"
        Me.Button16.OfficeImageId = "KeepBackgroundRemoval"
        Me.Button16.ScreenTip = "Approve"
        Me.Button16.ShowImage = True
        '
        'Button8
        '
        Me.Button8.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button8.KeyTip = "QC"
        Me.Button8.Label = "View"
        Me.Button8.Name = "Button8"
        Me.Button8.OfficeImageId = "GroupHeaderFooterInsert"
        Me.Button8.ScreenTip = "View"
        Me.Button8.ShowImage = True
        '
        'grp_TaskManager
        '
        Me.grp_TaskManager.Items.Add(Me.Button13)
        Me.grp_TaskManager.Items.Add(Me.Button15)
        Me.grp_TaskManager.Label = "Tasks"
        Me.grp_TaskManager.Name = "grp_TaskManager"
        Me.grp_TaskManager.Visible = False
        '
        'Button13
        '
        Me.Button13.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button13.KeyTip = "QC"
        Me.Button13.Label = "Reminders"
        Me.Button13.Name = "Button13"
        Me.Button13.OfficeImageId = "SetAlerts"
        Me.Button13.ScreenTip = "Reminders"
        Me.Button13.ShowImage = True
        '
        'Button15
        '
        Me.Button15.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button15.KeyTip = "QC"
        Me.Button15.Label = "Company Policies"
        Me.Button15.Name = "Button15"
        Me.Button15.OfficeImageId = "AccessRequests"
        Me.Button15.ScreenTip = "Company Policies"
        Me.Button15.ShowImage = True
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.Button1)
        Me.Group1.Items.Add(Me.btnLicenseOptions)
        Me.Group1.Label = "User Settings"
        Me.Group1.Name = "Group1"
        '
        'Button1
        '
        Me.Button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button1.KeyTip = "QC"
        Me.Button1.Label = "User Settings"
        Me.Button1.Name = "Button1"
        Me.Button1.OfficeImageId = "AccountSettings"
        Me.Button1.ScreenTip = "User Settings"
        Me.Button1.ShowImage = True
        Me.Button1.SuperTip = "Update user settings such as Username, Project Group, Project directory, and more" &
    "."
        '
        'btnLicenseOptions
        '
        Me.btnLicenseOptions.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnLicenseOptions.KeyTip = "QC"
        Me.btnLicenseOptions.Label = "License Options"
        Me.btnLicenseOptions.Name = "btnLicenseOptions"
        Me.btnLicenseOptions.OfficeImageId = "InsertHighPrivilegeBlock"
        Me.btnLicenseOptions.ScreenTip = "License Options"
        Me.btnLicenseOptions.ShowImage = True
        '
        'grpCompanySettings
        '
        Me.grpCompanySettings.Items.Add(Me.Button10)
        Me.grpCompanySettings.Items.Add(Me.Button12)
        Me.grpCompanySettings.Items.Add(Me.Button9)
        Me.grpCompanySettings.Label = "Project Group"
        Me.grpCompanySettings.Name = "grpCompanySettings"
        '
        'Button10
        '
        Me.Button10.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button10.KeyTip = "QC"
        Me.Button10.Label = "Create"
        Me.Button10.Name = "Button10"
        Me.Button10.OfficeImageId = "UpdateFolderList"
        Me.Button10.ScreenTip = "Create"
        Me.Button10.ShowImage = True
        Me.Button10.SuperTip = "Create a New overarching Project Group to organize your projects or edit an exist" &
    "ing one."
        '
        'Button12
        '
        Me.Button12.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button12.KeyTip = "QC"
        Me.Button12.Label = "User Profiles"
        Me.Button12.Name = "Button12"
        Me.Button12.OfficeImageId = "InviteAttendees"
        Me.Button12.ScreenTip = "User Profiles"
        Me.Button12.ShowImage = True
        Me.Button12.SuperTip = "Manage users and define their roles within your company."
        '
        'Button9
        '
        Me.Button9.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button9.KeyTip = "QC"
        Me.Button9.Label = "Settings"
        Me.Button9.Name = "Button9"
        Me.Button9.OfficeImageId = "AnimationCustomActionVerbDialog"
        Me.Button9.ScreenTip = "Settings"
        Me.Button9.ShowImage = True
        Me.Button9.SuperTip = "Modify your company preferences here."
        '
        'Group6
        '
        Me.Group6.Items.Add(Me.Button_Check_for_Updates)
        Me.Group6.Items.Add(Me.Button3)
        Me.Group6.Items.Add(Me.Button4)
        Me.Group6.Label = "General"
        Me.Group6.Name = "Group6"
        '
        'Button_Check_for_Updates
        '
        Me.Button_Check_for_Updates.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button_Check_for_Updates.KeyTip = "QC"
        Me.Button_Check_for_Updates.Label = "Check for Updates"
        Me.Button_Check_for_Updates.Name = "Button_Check_for_Updates"
        Me.Button_Check_for_Updates.OfficeImageId = "Recurrence"
        Me.Button_Check_for_Updates.ScreenTip = "Check for Updates"
        Me.Button_Check_for_Updates.ShowImage = True
        '
        'Button3
        '
        Me.Button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button3.KeyTip = "QC"
        Me.Button3.Label = "Help"
        Me.Button3.Name = "Button3"
        Me.Button3.OfficeImageId = "Help"
        Me.Button3.ScreenTip = "Help"
        Me.Button3.ShowImage = True
        '
        'Button4
        '
        Me.Button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button4.KeyTip = "QC"
        Me.Button4.Label = "About"
        Me.Button4.Name = "Button4"
        Me.Button4.OfficeImageId = "Info"
        Me.Button4.ScreenTip = "About"
        Me.Button4.ShowImage = True
        Me.Button4.SuperTip = "About PROJECT Assist and structIQe Technologies Pvt Ltd."
        '
        'StructIQe
        '
        Me.Name = "StructIQe"
        Me.RibbonType = "Microsoft.Excel.Workbook, Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read" &
    ", Microsoft.Outlook.Response.Read, Microsoft.Word.Document"
        Me.Tabs.Add(Me.TabstructIQe)
        Me.TabstructIQe.ResumeLayout(False)
        Me.TabstructIQe.PerformLayout()
        Me.grpProjectManager.ResumeLayout(False)
        Me.grpProjectManager.PerformLayout()
        Me.grp_MailManager.ResumeLayout(False)
        Me.grp_MailManager.PerformLayout()
        Me.grp_QualityButtons.ResumeLayout(False)
        Me.grp_QualityButtons.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.grpTimeManager.ResumeLayout(False)
        Me.grpTimeManager.PerformLayout()
        Me.grp_TaskManager.ResumeLayout(False)
        Me.grp_TaskManager.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.grpCompanySettings.ResumeLayout(False)
        Me.grpCompanySettings.PerformLayout()
        Me.Group6.ResumeLayout(False)
        Me.Group6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabstructIQe As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents grp_QualityButtons As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnSubmit_for_QC As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button3 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpProjectManager As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnNewProject As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button4 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grp_MailManager As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button5 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button6 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnLicenseOptions As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpTimeManager As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button7 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button8 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button9 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group6 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents grpCompanySettings As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button10 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button11 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button12 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grp_TaskManager As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button13 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button_Check_for_Updates As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button15 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button16 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button17 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button18 As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property structIQe() As structIQe
        Get
            Return Me.GetRibbon(Of structIQe)()
        End Get
    End Property
End Class
