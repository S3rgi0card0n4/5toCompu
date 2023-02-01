Imports System.Data.SqlClient
Public Class Form2
    Dim conexion As New SqlConnection("Data Source=DESKTOP-1ICJ3LH\SQLEXPRESS;Initial Catalog=tarea2;Integrated Security=True")
    Dim sentencia, mensaje As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mostrar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sentencia = "insert into alumnos values('" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtclave.Text + "','" + txtfecha.Text + "','" + txtgrado.Text + "','" + txtseccion.Text + "')"
        mensaje = "datos insertados"
        ejecutarsql(sentencia, mensaje)
    End Sub

    Sub mostrar()
        Dim da As New SqlDataAdapter("select *from alumnos", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sentencia = "update alumnos set nombre='" + txtnombre.Text + "',apellido='" + txtapellido.Text + "',fecha='" + txtfecha.Text + "',grado='" + txtgrado.Text + "',seccion='" + txtseccion.Text + "' where clave='" + txtclave.Text + "'"
        mensaje = "datos Actualizados correctamente"
        ejecutarsql(sentencia, mensaje)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sentencia = "delete from alumnos where clave='" + txtclave.Text + "'"
        mensaje = "datos eliminados correctamente"
        ejecutarsql(sentencia, mensaje)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Hide()

    End Sub

    Sub ejecutarsql(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class