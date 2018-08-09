Imports System.Security.Cryptography
Imports System.Text

Public Class ServerOptions
    Private Sub ServerOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Config As New My.MySettings


        TextEdit1.Text = Config.TagServer
        TextEdit2.Text = Config.TagServerUserName
        TextEdit5.Text = Config.DownTimeDatabase
        TextEdit8.Text = Config.LDMSServer
        TextEdit7.Text = Config.LDMSUserName

        Try
            TextEdit3.Text = DecryptHSA256(Config.TagServerPassword)
            TextEdit4.Text = DecryptHSA256(Config.DBPassword)
            TextEdit6.Text = DecryptHSA256(Config.LDMSPassword)
        Catch ex As Exception
            Label1.Visible = True
            Exit Sub
        End Try
        Label1.Visible = False
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Save Button
        Dim Config As New My.MySettings

        Config.TagServer = TextEdit1.Text
        Config.TagServerUserName = TextEdit2.Text
        Config.DownTimeDatabase = TextEdit5.Text
        Config.LDMSServer = TextEdit8.Text
        Config.LDMSUserName = TextEdit7.Text
        Config.Save()
        Try
            Config.TagServerPassword = HashSHA256(TextEdit3.Text)
            Config.Save()
            Config.DBPassword = HashSHA256(TextEdit4.Text)
            Config.Save()
            Config.LDMSPassword = HashSHA256(TextEdit6.Text)
            Config.Save()
        Catch ex As Exception
            Label1.Visible = True
            Config.Save()
            Exit Sub
        End Try

        Config.Save()
        Me.Close()


    End Sub


End Class