Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Public Sub CargarGrid()
        Dim da As New OleDb.OleDbDataAdapter("select * from clientes", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class