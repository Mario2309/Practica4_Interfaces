Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        btn.Text = "Agregar"
        Me.Text = "Agregar peliculas"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn.Text = "Agregar"
        Me.Text = "Agregar peliculas"
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        btn.Text = "Eliminar"
        Me.Text = "Eliminar peliculas"
    End Sub

    Private Sub NuevoSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoSocioToolStripMenuItem.Click
        Form2.Text = "Nuevo Socio"
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Module1.MostrarMensajeAcercaDe()
    End Sub


End Class
