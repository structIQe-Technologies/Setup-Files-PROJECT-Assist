Imports Microsoft.Office.Tools.Ribbon
Imports Microsoft.Office.Interop.Outlook
Imports System.Windows.Forms
Imports System.IO
Imports Project_Assist_Common_Library
Imports Aladdin.HASP
Imports Microsoft.Office.Interop.Excel
Imports System.Collections.Specialized

Public Class StructIQe

    Private Sub Button14_Click(sender As Object, e As RibbonControlEventArgs) Handles Button_Check_for_Updates.Click
        'SharedRibbonButtons.Launch_Licensing_App()
        Program_Controls.UPDATE_Program()

    End Sub

    Private Sub StructIQe_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

        reset_ribbon()

    End Sub

    Sub Reset_ribbon()

        'Load the settings from the JSON file
        Dim settings = AppSettings.LoadSettings()

        If SharedClass.LICENSE_check_silent(SettingsHelper.License_Project_Manager) = False Or settings.Project_management_license_Check = False Then
            ' grpProjectManager.Visible = False
            btnNewProject.Visible = False
        Else
            'grpProjectManager.Visible = True
            btnNewProject.Visible = True
        End If
        If SharedClass.LICENSE_check_silent(SettingsHelper.License_Mail_Manager) = False Or settings.Mail_management_license_Check = False Then
            grp_MailManager.Visible = False
        Else
            grp_MailManager.Visible = True
        End If
        If SharedClass.LICENSE_check_silent(SettingsHelper.License_Quality_Manager) = False Or settings.Quality_management_license_Check = False Then
            grp_QualityButtons.Visible = False
        Else
            grp_QualityButtons.Visible = True
        End If
        If SharedClass.LICENSE_check_silent(SettingsHelper.License_Time_Manager) = False Or settings.Time_management_license_Check = False Then
            grpTimeManager.Visible = False
        Else
            grpTimeManager.Visible = True
        End If
        If SharedClass.LICENSE_check_silent(SettingsHelper.License_Task_Manager) = False Or settings.Task_management_license_Check = False Then
            grp_TaskManager.Visible = False
        Else
            grp_TaskManager.Visible = True
        End If

        If SharedClass.LICENSE_check_silent(SettingsHelper.License_Project_Group_Manager) = False Then
            grpCompanySettings.Visible = False
        Else
            grpCompanySettings.Visible = True
        End If

    End Sub
    Private Sub BtnNewProject_Click(sender As Object, e As RibbonControlEventArgs) Handles btnNewProject.Click

        SharedRibbonButtons.Button_New_Project(False)

    End Sub

    Private Sub Button11_Click(sender As Object, e As RibbonControlEventArgs) Handles Button11.Click

        SharedRibbonButtons.Button_Manage_Projects()

    End Sub


    Private Sub Button5_Click(sender As Object, e As RibbonControlEventArgs) Handles Button5.Click

        SharedRibbonButtons.Button_Archive_this_mail()

    End Sub

    Private Sub Button6_Click(sender As Object, e As RibbonControlEventArgs) Handles Button6.Click

        SharedRibbonButtons.Button_Archive_multiple_mails()

    End Sub


    Private Sub BtnSubmit_for_QC_Click(sender As Object, e As RibbonControlEventArgs) Handles btnSubmit_for_QC.Click

        SharedQualityCheckClass.Button_Submit_for_QC("", "")

    End Sub

    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs) Handles Button2.Click

        MsgBox("Under Development", MsgBoxStyle.Information, SettingsHelper.App_Name)

        ' SharedQualityCheckClass.Button_Submit_QC_Status()

    End Sub

    Private Sub Button17_Click(sender As Object, e As RibbonControlEventArgs) Handles Button17.Click

        SharedQualityCheckClass.Button_Review_QC_Status()

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click

        SharedRibbonButtons.Button_User_Settings()

    End Sub


    Private Sub Button7_Click(sender As Object, e As RibbonControlEventArgs) Handles btnLicenseOptions.Click

        SharedRibbonButtons.Button_License_Options()

        Call Reset_ribbon()

    End Sub

    Private Sub Button9_Click(sender As Object, e As RibbonControlEventArgs) Handles Button9.Click

        SharedRibbonButtons.Button_ProjectGroup_Edit_Settings()

    End Sub

    Private Sub Button3_Click(sender As Object, e As RibbonControlEventArgs) Handles Button3.Click

        SharedRibbonButtons.Button_Help()

    End Sub

    Private Sub Button4_Click(sender As Object, e As RibbonControlEventArgs) Handles Button4.Click

        SharedRibbonButtons.Button_About_Box()

    End Sub

    Private Sub Button12_Click(sender As Object, e As RibbonControlEventArgs) Handles Button12.Click
        SharedRibbonButtons.Button_User_Profiles()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As RibbonControlEventArgs) Handles Button7.Click
        SharedRibbonButtons.Button_Submit_Timesheet()
    End Sub

    Private Sub Button10_Click(sender As Object, e As RibbonControlEventArgs) Handles Button10.Click
        SharedRibbonButtons.Button_New_Project_Group()
    End Sub



    Private Sub Button13_Click(sender As Object, e As RibbonControlEventArgs) Handles Button13.Click
        MsgBox("Under Development", MsgBoxStyle.Information, SettingsHelper.App_Name)

    End Sub

    Private Sub Button15_Click(sender As Object, e As RibbonControlEventArgs) Handles Button15.Click
        MsgBox("Under Development", MsgBoxStyle.Information, SettingsHelper.App_Name)
    End Sub

    Private Sub Button16_Click(sender As Object, e As RibbonControlEventArgs) Handles Button16.Click
        MsgBox("Under Development", MsgBoxStyle.Information, SettingsHelper.App_Name)
    End Sub

    Private Sub Button8_Click(sender As Object, e As RibbonControlEventArgs) Handles Button8.Click
        MsgBox("Under Development", MsgBoxStyle.Information, SettingsHelper.App_Name)
    End Sub

    Private Sub Button18_Click(sender As Object, e As RibbonControlEventArgs) Handles Button18.Click
        SharedRibbonButtons.Button_Manage_Drawings()
    End Sub
End Class
