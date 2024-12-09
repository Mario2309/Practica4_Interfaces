<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombreGenero = New System.Windows.Forms.TextBox()
        Me.ComboBoxElegirGenero = New System.Windows.Forms.ComboBox()
        Me.Agregar = New System.Windows.Forms.Button()
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
        Me.GenerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarGeneroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarGeneroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoSocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Determina el nombre del genero"
        '
        'TextBoxNombreGenero
        '
        Me.TextBoxNombreGenero.Location = New System.Drawing.Point(200, 65)
        Me.TextBoxNombreGenero.Name = "TextBoxNombreGenero"
        Me.TextBoxNombreGenero.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxNombreGenero.TabIndex = 5
        '
        'ComboBoxElegirGenero
        '
        Me.ComboBoxElegirGenero.FormattingEnabled = True
        Me.ComboBoxElegirGenero.Location = New System.Drawing.Point(200, 65)
        Me.ComboBoxElegirGenero.Name = "ComboBoxElegirGenero"
        Me.ComboBoxElegirGenero.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxElegirGenero.TabIndex = 6
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(130, 129)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(130, 38)
        Me.Agregar.TabIndex = 7
        Me.Agregar.Text = "Button1"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeliculasToolStripMenuItem, Me.SociosToolStripMenuItem, Me.PrestamosToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(392, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PeliculasToolStripMenuItem
        '
        Me.PeliculasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.GenerosToolStripMenuItem})
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
        'GenerosToolStripMenuItem
        '
        Me.GenerosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarGeneroToolStripMenuItem, Me.EliminarGeneroToolStripMenuItem})
        Me.GenerosToolStripMenuItem.Name = "GenerosToolStripMenuItem"
        Me.GenerosToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.GenerosToolStripMenuItem.Text = "Generos"
        '
        'AgregarGeneroToolStripMenuItem
        '
        Me.AgregarGeneroToolStripMenuItem.Name = "AgregarGeneroToolStripMenuItem"
        Me.AgregarGeneroToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AgregarGeneroToolStripMenuItem.Text = "Agregar genero"
        '
        'EliminarGeneroToolStripMenuItem
        '
        Me.EliminarGeneroToolStripMenuItem.Name = "EliminarGeneroToolStripMenuItem"
        Me.EliminarGeneroToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EliminarGeneroToolStripMenuItem.Text = "Eliminar genero"
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
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 210)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.ComboBoxElegirGenero)
        Me.Controls.Add(Me.TextBoxNombreGenero)
        Me.Controls.Add(Me.Label1)
        Me.IsMdiContainer = True
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombreGenero As TextBox
    Friend WithEvents ComboBoxElegirGenero As ComboBox
    Friend WithEvents Agregar As Button
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
    Friend WithEvents GenerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarGeneroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarGeneroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoSocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
