Public Class Form4
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.AgregarPeli()
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.EliminarPelis()
    End Sub

    Private Sub NuevoSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoSocioToolStripMenuItem.Click
        ModuleMenu.NuevoSocio()
        Me.Hide()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Module1.MostrarMensajeAcercaDe()
    End Sub

    Private Sub ConsultarSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarSociosToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.ConsultarSocios()
    End Sub

    Private Sub NuevoPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPrestamoToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.NuevoPrestamo()
    End Sub

    Private Sub DevolverPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverPrestamoToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.EliminarPrestamo()
    End Sub

    Private Sub ConsultarPrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPrestamosToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.ConsultarPrestamos()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.ConsultaGeneral()

    End Sub

    Private Sub PorTituloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorTituloToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.ConsultaTitulo()
    End Sub

    Private Sub PorAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorAutorToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.ConsultaAutor()
    End Sub

    Private Sub PorGeneroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorGeneroToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.ConsultaGenero()
    End Sub

    Private Sub PorCalificaionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCalificaionToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.ConsultaCalificacion()
    End Sub

    Private Sub PorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorFechaToolStripMenuItem.Click
        Me.Hide()
        ModuleMenu.ConsultaFecha()
    End Sub
End Class