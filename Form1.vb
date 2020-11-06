Imports System.Net
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.IO.StreamReader
Imports System.Security
Partial Class Form1
    Dim x, y As Integer
    Dim NewPoint As New Point
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= x
            NewPoint.Y -= y
            Me.Location = NewPoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= x
            NewPoint.Y -= y
            Me.Location = NewPoint
            Application.DoEvents()
        End If
    End Sub
    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= x
            NewPoint.Y -= y
            Me.Location = NewPoint
            Application.DoEvents()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'IP do Servidor de Fivem.
        If UBound(Diagnostics.Process.GetProcessesByName("Steam")) < 0 Then
            MsgBox("Você não iniciou o Steam !!", MsgBoxStyle.Exclamation, "Erro")
        Else
            Process.Start("fivem://connect/185.113.141.31:29715")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'IP do Servidor de Discord.
        Process.Start("https://discord.gg/PyzrdSE")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.facebook.com/claudio.bebiano")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'IP do Servidor de TS3.
        'Process.Start("ts3server://ts.seyfert.pt")
        MsgBox("Brevemente !!", MsgBoxStyle.Exclamation, "Info")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Facebook do Servidor.
        MsgBox("Brevemente !!", MsgBoxStyle.Exclamation, "Info")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BorderStyle = BorderStyle.None
    End Sub
    Private Sub PictureBox4_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseHover
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Hosting.
        Process.Start("https://hlc.ovh")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Download do tokovoip.
        Process.Start("http://github.com/Itokoyamato/TokoVOIP_TS3/releases/download/v1.2.5-v1.3.5/tokovoip_1_2_5.ts3_plugin")
        MsgBox("Download Completo, pode instalar o plugin!!", MsgBoxStyle.Information, "Info")

    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BorderStyle = BorderStyle.None
    End Sub
End Class