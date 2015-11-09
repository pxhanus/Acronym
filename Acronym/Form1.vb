'Patricia Hanus
'151028
'Acronym
'_______________________________________________________________
Public Class Form1

    Private Sub btnAcronym_Click(sender As Object, e As EventArgs) Handles btnAcronym.Click
        Dim wordNum As String
        Dim acronym As String = Nothing
        Dim words As String

        wordNum = Val(InputBox("How many words will make up the acronym?"))
        

        For i As Integer = 1 To wordNum
            words = InputBox("Enter a word in an acronym.")
            acronym = acronym + words.Substring(0, 1)
        Next
        Me.lblAcronym.Text = acronym.ToUpper
    End Sub
End Class
