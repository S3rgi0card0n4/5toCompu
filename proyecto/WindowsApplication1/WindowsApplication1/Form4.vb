Imports System.Data.SqlClient
Public Class Form4
    Dim conexion As New SqlConnection("Data Source=DESKTOP-1ICJ3LH\SQLEXPRESS;Initial Catalog=tarea2;Integrated Security=True")
    Dim sentencia, mensaje As String
    Sub mostrar()
        Dim da As New SqlDataAdapter("select *from alumnos", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        conexion.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mostrar()
    End Sub
End Class