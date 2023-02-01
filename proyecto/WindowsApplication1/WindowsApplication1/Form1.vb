Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario, password As String
        usuario = TextBox1.Text
        password = TextBox2.Text

        If (usuario = "Profesor") And (password = "123") Then
            Form2.Show()
            Hide()

        Else

            If (usuario = "secretaria") And (password = "123") Then
                Form3.Show()
                Hide()
            Else

                If (usuario = "usuario") And (password = "123") Then
                    Form4.Show()

                    Hide()
                Else
                    MsgBox("Datos no correctos,intentelo nuevamente")

                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
