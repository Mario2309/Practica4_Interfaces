Module ModuleMenu
    Public Sub AgregarPeli()
        Form1.Show()
        Form1.btn.Text = "Agregar"
        Form1.Text = "Agregar peliculas"
    End Sub

    Public Sub CargarForm1()
        Form1.btn.Text = "Agregar"
        Form1.Text = "Agregar peliculas"
        Form1.ComboBoxTitulo.Hide()
    End Sub

    Public Sub EliminarPelis()
        Form1.Show()
        Form1.btn.Text = "Eliminar"
        Form1.Text = "Eliminar peliculas"
        Form1.ComboBoxTitulo.Show()
        Form1.TextBoxTitulo.Hide()
        Form1.btn.Text = "Eliminar"
    End Sub

    Public Sub NuevoSocio()
        Form2.Text = "Nuevo Socio"
        Form2.Show()
    End Sub

    Public Sub ConsultarSocios()
        Form4.Text = "Consultar Socios"
        Form4.Show()
    End Sub

    Public Sub NuevoPrestamo()
        Form5.Text = "Nuevo prestamo"
        Form5.Show()
    End Sub

    Public Sub EliminarPrestamo()
        Form5.Text = "Eliminar prestamo"
        Form5.Show()
        Form5.ComboBoxSocio.Enabled = False
        Form5.ButtonForm.Text = "Devolver"
    End Sub

    Public Sub ConsultarPrestamos()
        Form6.Text = "Consultar prestamos"
        Form6.Show()
    End Sub

    Public Sub ConsultaGeneral()
        Form3.Show()
        Form3.NombreApartado.Hide()
        Form3.TextBoxCompletar.Hide()
        Form3.ComboBoxCalificacion.Hide()
        Form3.ComboBoxGeneros.Hide()
        Form3.Button1.Hide()
    End Sub

    Public Sub ConsultaTitulo()
        Form3.Show()
        Form3.NombreApartado.Text = "Determina el titulo: "
        Form3.ComboBoxCalificacion.Hide()
        Form3.ComboBoxGeneros.Hide()
        Form3.NombreApartado.Show()
        Form3.TextBoxCompletar.Show()
        Form3.Button1.Show()
    End Sub

    Public Sub ConsultaAutor()
        Form3.Show()
        Form3.NombreApartado.Text = "Determina el autor: "
        Form3.ComboBoxCalificacion.Hide()
        Form3.ComboBoxGeneros.Hide()
        Form3.NombreApartado.Show()
        Form3.TextBoxCompletar.Show()
        Form3.Button1.Show()
    End Sub

    Public Sub ConsultaGenero()
        Form3.Show()
        Form3.NombreApartado.Text = "Determina el genero: "
        Form3.ComboBoxCalificacion.Hide()
        Form3.TextBoxCompletar.Hide()
        Form3.NombreApartado.Show()
        Form3.ComboBoxGeneros.Show()
        Form3.Button1.Show()
    End Sub

    Public Sub ConsultaCalificacion()
        Form3.Show()
        Form3.NombreApartado.Text = "Determina la calificacion: "
        Form3.ComboBoxGeneros.Hide()
        Form3.TextBoxCompletar.Hide()
        Form3.NombreApartado.Show()
        Form3.ComboBoxCalificacion.Show()
        Form3.Button1.Show()
    End Sub

    Public Sub ConsultaFecha()
        Form3.Show()
        Form3.NombreApartado.Text = "Determina la fecha: "
        Form3.ComboBoxCalificacion.Hide()
        Form3.ComboBoxGeneros.Hide()
        Form3.NombreApartado.Show()
        Form3.TextBoxCompletar.Show()
        Form3.Button1.Show()
    End Sub

    Public Sub AgregarGenero()
        Form7.Text = "Agregar genero"
        Form7.Show()
        Form7.ComboBoxElegirGenero.Hide()
        Form7.Label1.Text = "Determina el nombre del genero: "
        Form7.Agregar.Text = "Agregar"
    End Sub

    Public Sub EliminarGenero()
        Form7.Text = "Eliminar genero"
        Form7.Show()
        Form7.TextBoxNombreGenero.Hide()
        Form7.Label1.Text = "Determina el genero a eliminar: "
        Form7.Agregar.Text = "Eliminar"
    End Sub
End Module
