<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PeliculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorTituloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorAutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorGeneroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorCalificaionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoSocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaPelis = New System.Windows.Forms.ListView()
        Me.Contador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Titulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Calificacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Autor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AnioLanzamiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Genero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeliculasToolStripMenuItem, Me.SociosToolStripMenuItem, Me.PrestamosToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PeliculasToolStripMenuItem
        '
        Me.PeliculasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.PeliculasToolStripMenuItem.Name = "PeliculasToolStripMenuItem"
        Me.PeliculasToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PeliculasToolStripMenuItem.Text = "Peliculas"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorTituloToolStripMenuItem, Me.PorAutorToolStripMenuItem, Me.PorGeneroToolStripMenuItem, Me.PorCalificaionToolStripMenuItem, Me.PorFechaToolStripMenuItem})
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'PorTituloToolStripMenuItem
        '
        Me.PorTituloToolStripMenuItem.Name = "PorTituloToolStripMenuItem"
        Me.PorTituloToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PorTituloToolStripMenuItem.Text = "Por titulo"
        '
        'PorAutorToolStripMenuItem
        '
        Me.PorAutorToolStripMenuItem.Name = "PorAutorToolStripMenuItem"
        Me.PorAutorToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PorAutorToolStripMenuItem.Text = "Por autor"
        '
        'PorGeneroToolStripMenuItem
        '
        Me.PorGeneroToolStripMenuItem.Name = "PorGeneroToolStripMenuItem"
        Me.PorGeneroToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PorGeneroToolStripMenuItem.Text = "Por genero"
        '
        'PorCalificaionToolStripMenuItem
        '
        Me.PorCalificaionToolStripMenuItem.Name = "PorCalificaionToolStripMenuItem"
        Me.PorCalificaionToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PorCalificaionToolStripMenuItem.Text = "Por calificaion"
        '
        'PorFechaToolStripMenuItem
        '
        Me.PorFechaToolStripMenuItem.Name = "PorFechaToolStripMenuItem"
        Me.PorFechaToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PorFechaToolStripMenuItem.Text = "Por fecha"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoSocioToolStripMenuItem, Me.ConsultarSociosToolStripMenuItem})
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        Me.SociosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SociosToolStripMenuItem.Text = "Socios"
        '
        'NuevoSocioToolStripMenuItem
        '
        Me.NuevoSocioToolStripMenuItem.Name = "NuevoSocioToolStripMenuItem"
        Me.NuevoSocioToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NuevoSocioToolStripMenuItem.Text = "Nuevo socio"
        '
        'ConsultarSociosToolStripMenuItem
        '
        Me.ConsultarSociosToolStripMenuItem.Name = "ConsultarSociosToolStripMenuItem"
        Me.ConsultarSociosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ConsultarSociosToolStripMenuItem.Text = "Consultar socios"
        '
        'PrestamosToolStripMenuItem
        '
        Me.PrestamosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPrestamoToolStripMenuItem, Me.ConsultarPrestamosToolStripMenuItem, Me.DevolverPrestamoToolStripMenuItem})
        Me.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem"
        Me.PrestamosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.PrestamosToolStripMenuItem.Text = "Prestamos"
        '
        'NuevoPrestamoToolStripMenuItem
        '
        Me.NuevoPrestamoToolStripMenuItem.Name = "NuevoPrestamoToolStripMenuItem"
        Me.NuevoPrestamoToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.NuevoPrestamoToolStripMenuItem.Text = "Nuevo prestamo"
        '
        'ConsultarPrestamosToolStripMenuItem
        '
        Me.ConsultarPrestamosToolStripMenuItem.Name = "ConsultarPrestamosToolStripMenuItem"
        Me.ConsultarPrestamosToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ConsultarPrestamosToolStripMenuItem.Text = "Consultar Prestamos"
        '
        'DevolverPrestamoToolStripMenuItem
        '
        Me.DevolverPrestamoToolStripMenuItem.Name = "DevolverPrestamoToolStripMenuItem"
        Me.DevolverPrestamoToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DevolverPrestamoToolStripMenuItem.Text = "Devolver prestamo"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListaPelis
        '
        Me.ListaPelis.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Contador, Me.Titulo, Me.Calificacion, Me.Autor, Me.AnioLanzamiento, Me.Genero})
        Me.ListaPelis.GridLines = True
        Me.ListaPelis.HideSelection = False
        Me.ListaPelis.Location = New System.Drawing.Point(12, 96)
        Me.ListaPelis.Name = "ListaPelis"
        Me.ListaPelis.Size = New System.Drawing.Size(525, 216)
        Me.ListaPelis.TabIndex = 9
        Me.ListaPelis.UseCompatibleStateImageBehavior = False
        Me.ListaPelis.View = System.Windows.Forms.View.Details
        '
        'Contador
        '
        Me.Contador.Text = "Contador"
        '
        'Titulo
        '
        Me.Titulo.Text = "Titulo"
        Me.Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Titulo.Width = 98
        '
        'Calificacion
        '
        Me.Calificacion.Text = "Calificacion"
        Me.Calificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Calificacion.Width = 99
        '
        'Autor
        '
        Me.Autor.Text = "Autor"
        Me.Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Autor.Width = 87
        '
        'AnioLanzamiento
        '
        Me.AnioLanzamiento.Text = "Lanzamiento"
        Me.AnioLanzamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnioLanzamiento.Width = 95
        '
        'Genero
        '
        Me.Genero.Text = "Genero"
        Me.Genero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Genero.Width = 82
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 324)
        Me.Controls.Add(Me.ListaPelis)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PeliculasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorTituloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorAutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorGeneroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorCalificaionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoSocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaPelis As ListView
    Friend WithEvents Contador As ColumnHeader
    Friend WithEvents Titulo As ColumnHeader
    Friend WithEvents Calificacion As ColumnHeader
    Friend WithEvents Autor As ColumnHeader
    Friend WithEvents AnioLanzamiento As ColumnHeader
    Friend WithEvents Genero As ColumnHeader
End Class
