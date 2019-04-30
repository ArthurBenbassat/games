Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datum(11), spel As String
        Dim aantalVerkocht, index As Integer
        Dim einde As Boolean

        FileOpen(1, "C:\Users\Arthur\Downloads\games.txt", OpenMode.Input)

        Try
            Input(1, datum(index))
            Input(1, spel)
            Input(1, aantalVerkocht)

        Catch ex As Exception
            einde = True

        End Try

    End Sub
End Class
