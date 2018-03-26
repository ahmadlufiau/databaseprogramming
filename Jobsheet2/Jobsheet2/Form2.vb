Imports System.Text.RegularExpressions
Public Class Form2

    Dim EmailVal As Boolean

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEmail.Focus()
    End Sub
    Private Function ValidEmail(ByVal value As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        If Regex.Match(value, pattern).Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TxtEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtEmail.Validating
        If ValidEmail(TxtEmail.Text) = False Then
            MsgBox("Email tidak valid", MsgBoxStyle.Exclamation, "Peringatan")
            TxtEmail.Text = ""
        End If
    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
        If ValidEmail(TxtEmail.Text) = True Then
            MsgBox("Email yang anda masukkan valid")
        Else
            MsgBox("Maaf email yang anda masukkan tidak valid")
            TxtEmail.Focus()
        End If
    End Sub

    Private Sub btnUrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUrl.Click
        If ValidURL(TxtUrl.Text) = True Then
            MsgBox("URL yang anda masukkan valid")
        Else
            MsgBox("Maaf URL yang anda masukkan tidak valid ")
            TxtUrl.Focus()
        End If
    End Sub

    Private Function ValidURL(ByVal value As String) As Boolean
        Dim pattern As String = "^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$"
        If Regex.Match(value, pattern).Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtURL_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtUrl.Validating
        If ValidURL(TxtUrl.Text) = False Then
            MsgBox("Website tidak valid", MsgBoxStyle.Exclamation, "Peringatan")
            TxtUrl.Text = ""
        End If
    End Sub
End Class