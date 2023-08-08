Imports System.Text

Public Class Form1
    Dim list As New List(Of String
        )
    Dim number As Int16
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        'list.Add("First item")
        'list.Add("Second item")


        'For Each item In list
        '    MsgBox(item)
        '    Exit For
        'Next


    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbl_Principal.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Result As Decimal


        Dim BigString As String = ""
        Dim final As Integer = Integer.Parse(TextBox3.Text) * 12
        Dim value As Decimal = TextBox1.Text

        Dim countModule As Integer
        Dim percent As Decimal = TextBox2.Text
        For i = 1 To final
            countModule = countModule Mod 12
            countModule += 1


            If countModule + 1 = 12 Then
                percent = (percent + (percent + (TextBox4.Text / 100)))

            End If
            Result = value + (value * (percent / 100))

            BigString += Result.ToString() + "" + Environment.NewLine

            value = Result

        Next

        'While final > 0
        '    Result = value + (value * (TextBox2.Text / 100))
        '    BigString += Result.ToString() + "" + Environment.NewLine

        '    value = Result

        '    final -= 1
        'End While

        MsgBox(BigString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New OtherProject.Form1

        f.ShowDialog()
    End Sub
End Class
