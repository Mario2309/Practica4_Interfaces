﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contadorPelis = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxTitulo = New System.Windows.Forms.TextBox()
        Me.ComboBoxCalificaciones = New System.Windows.Forms.ComboBox()
        Me.TextBoxAutor = New System.Windows.Forms.TextBox()
        Me.TextBoxAnio = New System.Windows.Forms.TextBox()
        Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.ComboBoxTitulo = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeliculasToolStripMenuItem, Me.SociosToolStripMenuItem, Me.PrestamosToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(581, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Identificador"
        '
        'contadorPelis
        '
        Me.contadorPelis.AutoSize = True
        Me.contadorPelis.Location = New System.Drawing.Point(117, 60)
        Me.contadorPelis.Name = "contadorPelis"
        Me.contadorPelis.Size = New System.Drawing.Size(16, 13)
        Me.contadorPelis.TabIndex = 4
        Me.contadorPelis.Text = " - "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Titulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Calificacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Autor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Publicado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(292, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Genero"
        '
        'TextBoxTitulo
        '
        Me.TextBoxTitulo.Location = New System.Drawing.Point(347, 58)
        Me.TextBoxTitulo.Name = "TextBoxTitulo"
        Me.TextBoxTitulo.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxTitulo.TabIndex = 10
        '
        'ComboBoxCalificaciones
        '
        Me.ComboBoxCalificaciones.FormattingEnabled = True
        Me.ComboBoxCalificaciones.Items.AddRange(New Object() {"--", "*", "**", "***", "****", "*****"})
        Me.ComboBoxCalificaciones.Location = New System.Drawing.Point(120, 116)
        Me.ComboBoxCalificaciones.Name = "ComboBoxCalificaciones"
        Me.ComboBoxCalificaciones.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCalificaciones.TabIndex = 11
        '
        'TextBoxAutor
        '
        Me.TextBoxAutor.Location = New System.Drawing.Point(347, 119)
        Me.TextBoxAutor.Name = "TextBoxAutor"
        Me.TextBoxAutor.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxAutor.TabIndex = 12
        '
        'TextBoxAnio
        '
        Me.TextBoxAnio.Location = New System.Drawing.Point(120, 186)
        Me.TextBoxAnio.Name = "TextBoxAnio"
        Me.TextBoxAnio.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxAnio.TabIndex = 13
        '
        'ComboBoxGenero
        '
        Me.ComboBoxGenero.FormattingEnabled = True
        Me.ComboBoxGenero.Items.AddRange(New Object() {"--"})
        Me.ComboBoxGenero.Location = New System.Drawing.Point(347, 184)
        Me.ComboBoxGenero.Name = "ComboBoxGenero"
        Me.ComboBoxGenero.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxGenero.TabIndex = 14
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(219, 254)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(128, 30)
        Me.btn.TabIndex = 15
        Me.btn.Text = "Agregar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'ComboBoxTitulo
        '
        Me.ComboBoxTitulo.FormattingEnabled = True
        Me.ComboBoxTitulo.Items.AddRange(New Object() {"--"})
        Me.ComboBoxTitulo.Location = New System.Drawing.Point(347, 58)
        Me.ComboBoxTitulo.Name = "ComboBoxTitulo"
        Me.ComboBoxTitulo.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxTitulo.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 307)
        Me.Controls.Add(Me.ComboBoxTitulo)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.ComboBoxGenero)
        Me.Controls.Add(Me.TextBoxAnio)
        Me.Controls.Add(Me.TextBoxAutor)
        Me.Controls.Add(Me.ComboBoxCalificaciones)
        Me.Controls.Add(Me.TextBoxTitulo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.contadorPelis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorCalificaionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoSocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents contadorPelis As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxTitulo As TextBox
    Friend WithEvents ComboBoxCalificaciones As ComboBox
    Friend WithEvents TextBoxAutor As TextBox
    Friend WithEvents TextBoxAnio As TextBox
    Friend WithEvents ComboBoxGenero As ComboBox
    Friend WithEvents btn As Button
    Friend WithEvents ComboBoxTitulo As ComboBox
    Friend WithEvents GenerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarGeneroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarGeneroToolStripMenuItem As ToolStripMenuItem
End Class
