Module ModuleMenu
    Public Sub AgregarPeli()
        Form1.Show()
        Form1.btn.Text = "Agregar"
        Form1.Text = "Agregar peliculas"
        Form1.ComboBoxTitulo.Hide()
        Form1.TextBoxTitulo.Show()
        Form1.ComboBoxCalificaciones.Enabled = True
        Form1.ComboBoxGenero.Enabled = True
        Form1.TextBoxAnio.Enabled = True
        Form1.TextBoxAutor.Enabled = True
    End Sub

    Public Sub CargarForm1()
        Static datosCargados As Boolean = False ' Variable estática para controlar la primera ejecución

        Form1.btn.Text = "Agregar"
        Form1.Text = "Agregar peliculas"
        Form1.ComboBoxTitulo.Hide()

        If Not datosCargados Then
            Module1.AgregarDatosGeneros()
            Module1.CargarPeliculas()
            Module1.CargarSocios()
            datosCargados = True ' Marcar como cargado después de la primera ejecución
        End If

        Form1.ComboBoxCalificaciones.SelectedIndex = 0
        Form1.ComboBoxGenero.SelectedIndex = 0
    End Sub

    Public Sub EliminarPelis()
        Form1.Show()
        Form1.btn.Text = "Eliminar"
        Form1.Text = "Eliminar peliculas"
        Form1.ComboBoxTitulo.Show()
        Form1.TextBoxTitulo.Hide()
        Form1.btn.Text = "Eliminar"
        Module1.cargarTitulosEnCombobox(Form3.ListaPelis, Form1.ComboBoxTitulo)

        Form1.ComboBoxCalificaciones.Enabled = False
        Form1.ComboBoxGenero.Enabled = False
        Form1.TextBoxAnio.Enabled = False
        Form1.TextBoxAutor.Enabled = False
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
        Module1.cargarNombresSocios(Form4.ListViewSocios, Form5.ComboBoxSocio)
        Module1.cargarTitulosEnCombobox(Form3.ListaPelis, Form5.ComboBoxLibro)
        Form5.ComboBoxPrestados.Hide()
        Form5.ComboBoxLibro.Show()
        Form5.ComboBoxLibro.Enabled = True
        Form5.ComboBoxSocio.Enabled = True

    End Sub

    Public Sub EliminarPrestamo()
        Form5.Text = "Eliminar prestamo"
        Form5.Show()
        Form5.ComboBoxSocio.Enabled = False
        Form5.ComboBoxLibro.Hide()
        Form5.ComboBoxPrestados.Show()
        Form5.ComboBoxPrestados.SelectedIndex = 0
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
        Form7.ComboBoxElegirGenero.Show()
    End Sub

    Public Sub salir()
        Module1.GuardarPeliculas()
        Module1.GuardarGeneros()
        Module1.GuardarSocios()
    End Sub

End Module
