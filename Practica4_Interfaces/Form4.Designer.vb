﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.ListViewSocios = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
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
        'ListViewSocios
        '
        Me.ListViewSocios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListViewSocios.GridLines = True
        Me.ListViewSocios.HideSelection = False
        Me.ListViewSocios.Location = New System.Drawing.Point(12, 76)
        Me.ListViewSocios.Name = "ListViewSocios"
        Me.ListViewSocios.Size = New System.Drawing.Size(525, 236)
        Me.ListViewSocios.TabIndex = 5
        Me.ListViewSocios.UseCompatibleStateImageBehavior = False
        Me.ListViewSocios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Apellidos"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 87
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Telefono"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 71
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DNI / NIE"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 72
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Poblacion"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 101
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "¿Mayor de edad?"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Listado de Socios"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeliculasToolStripMenuItem, Me.SociosToolStripMenuItem, Me.PrestamosToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 24)
        Me.MenuStrip1.TabIndex = 8
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 324)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewSocios)
        Me.IsMdiContainer = True
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewSocios As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label1 As Label
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
