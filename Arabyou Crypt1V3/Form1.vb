Imports System.IO
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing

Imports System.IO.Compression
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1998_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1998.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Text35_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text35.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Button1.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
        Me.Button3.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
        Me.TextBox1.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
        Me.Label1998.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
        Me.TextBox2.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
        Me.Text35.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
        Me.Button18.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
        Me.Button22.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
        Me.Button2.ForeColor = ColorTranslator.FromOle(Information.RGB(CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 255.0!)))), CInt(Math.Round(CDbl((VBMath.Rnd * 500.0!))))))
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog
        Dim dialog2 As OpenFileDialog = dialog
        dialog2.Title = "Select EXE File"
        dialog2.Filter = "(*.exe)|*.exe"
        dialog2.ShowDialog()
        dialog2 = Nothing
        Me.TextBox1.Text = dialog.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TextBox2.Text = Convert.ToBase64String(File.ReadAllBytes(Me.TextBox1.Text))
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Me.TextBox2.Text = Me.TextBox2.Text.Replace(Me.Text34.Text, Me.Text35.Text)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim dialog2 As New FolderBrowserDialog
        If (dialog2.ShowDialog = DialogResult.OK) Then
            Dim str As String = Conversions.ToString(Me.NumericUpDown1.Value)
            Dim text As String = Me.TextBox2.Text
            Dim str4 As String = Conversions.ToString(CDbl((Conversions.ToDouble(Conversions.ToString([text].Length)) / Conversions.ToDouble(str))))
            Dim str5 As String = Conversions.ToString(1)
            Dim num2 As Integer = Conversions.ToInteger(str)
            Dim i As Integer = 0
            Do While (i <= num2)
                Dim contents As String = Strings.Mid([text], Conversions.ToInteger(str5), Conversions.ToInteger(str4))
                File.WriteAllText((dialog2.SelectedPath & "\P" & Conversions.ToString(i) & ".txt"), contents)
                str5 = Conversions.ToString(CDbl((Conversions.ToDouble(str5) + Conversions.ToInteger(str4))))
                i += 1
            Loop
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox2.Text = My.Resources.OMAR313
    End Sub
End Class
