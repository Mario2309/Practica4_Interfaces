Imports Microsoft.VisualBasic.FileIO

Module Module1

    Dim contadorPeliculas As Integer = 1
    Public Generos As String = Application.StartupPath & "\GENEROS.txt"
    Public Peliculas As String = Application.StartupPath & "\PELICULAS.txt"
    Public Datos As String = Application.StartupPath & "\GenerosNuevos.txt"
    Public ListaPeliculas As String = Application.StartupPath & "\PELICULAS.txt"



    Public Async Sub MostrarMensajeAcercaDe()
        MessageBox.Show("Software desarrollado por: Mario Álvarez" + vbNewLine + "Alumno de: 2ºDAM")
        Await Task.Delay(3000)
        SendKeys.Send("{ESC}")
    End Sub

    Public Async Sub MostrarMensaje()
        MessageBox.Show("No puedes crear con campos incompletos")
        Await Task.Delay(3000)
        SendKeys.Send("{ESC}")
    End Sub

    Public Sub AgregarPelicula()
        If String.IsNullOrEmpty(Form1.TextBoxTitulo.Text) Or
       Form1.ComboBoxCalificaciones.Text = "--" Or
       String.IsNullOrEmpty(Form1.TextBoxAutor.Text) Or
       String.IsNullOrEmpty(Form1.TextBoxAnio.Text) Or
       Form1.ComboBoxGenero.Text = "--" Then

            MostrarMensaje()

        Else
            Dim existe As Boolean = False

            ' Verificar si el título ya existe
            For Each item As ListViewItem In Form3.ListaPelis.Items
                If item.SubItems(1).Text.Equals(Form1.TextBoxTitulo.Text, StringComparison.OrdinalIgnoreCase) Then
                    ' Si existe, actualizar los valores
                    item.SubItems(2).Text = Form1.ComboBoxCalificaciones.Text
                    item.SubItems(3).Text = Form1.TextBoxAutor.Text
                    item.SubItems(4).Text = Form1.TextBoxAnio.Text
                    item.SubItems(5).Text = Form1.ComboBoxGenero.Text
                    existe = True
                    Exit For
                End If
            Next

            ' Verificar si el contador ya existe
            If Not existe Then
                Dim numeroContador As Integer = Form3.ListaPelis.Items.Count + 1
                Dim texto As New ListViewItem(numeroContador.ToString())
                texto.SubItems.Add(Form1.TextBoxTitulo.Text)
                texto.SubItems.Add(Form1.ComboBoxCalificaciones.Text)
                texto.SubItems.Add(Form1.TextBoxAutor.Text)
                texto.SubItems.Add(Form1.TextBoxAnio.Text)
                texto.SubItems.Add(Form1.ComboBoxGenero.Text)

                Form3.ListaPelis.Items.Add(texto)
                contadorPeliculas = Form3.ListaPelis.Items.Count ' Sincronizar contador con elementos reales
                Form1.contadorPelis.Text = contadorPeliculas.ToString()
            End If

            limpiarFormPelis()
        End If
    End Sub

    Public Sub limpiarFormPelis()
        Form1.TextBoxTitulo.Clear()
        Form1.ComboBoxCalificaciones.SelectedIndex = 0
        Form1.TextBoxAutor.Clear()
        Form1.TextBoxAnio.Clear()
        Form1.ComboBoxGenero.SelectedIndex = 0
    End Sub

    Public Sub AgregarDatosGeneros()
        If My.Computer.FileSystem.FileExists(Generos) Then
            Dim Fichero_leer As String = Generos
            Dim Campos As String()

            Dim Delimitador As String = "#"
            Using Analizador_sintactico As New TextFieldParser(Fichero_leer)

                Analizador_sintactico.SetDelimiters(Delimitador)
                While Not Analizador_sintactico.EndOfData
                    Campos = Analizador_sintactico.ReadFields()

                    If Not Form1.ComboBoxGenero.Items.Contains(Campos(0)) Then
                        Form1.ComboBoxGenero.Items.Add(Campos(0))
                    End If
                End While
            End Using

            My.Computer.FileSystem.DeleteFile(Generos)
        End If
    End Sub

    Public Sub EliminarPelicula()
        If Form3.ListaPelis.SelectedItems.Count > 0 Then
            ' Recorrer y eliminar cada elemento seleccionado
            For Each item As ListViewItem In Form3.ListaPelis.SelectedItems
                Form3.ListaPelis.Items.Remove(item)
            Next

            ' Renumerar los elementos restantes
            For i As Integer = 0 To Form3.ListaPelis.Items.Count - 1
                Form3.ListaPelis.Items(i).Text = (i + 1).ToString()
            Next

            ' Ajustar el contador total
            contadorPeliculas = Form3.ListaPelis.Items.Count
            Form1.contadorPelis.Text = contadorPeliculas.ToString()

            MessageBox.Show("Elemento(s) eliminado(s) correctamente y lista renumerada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub AgregarGeneroNuevo()
        If My.Computer.FileSystem.FileExists(Datos) Then
            Dim Fichero_Leer As String = Datos
            Dim Campos As String()

            Dim Delimitador As String = "#"
            Using Analizador_Sintactico As New TextFieldParser(Fichero_Leer)
                Analizador_Sintactico.SetDelimiters(Delimitador)
                While Not Analizador_Sintactico.EndOfData
                    Campos = Analizador_Sintactico.ReadFields
                    Form1.ComboBoxGenero.Items.Add(Campos(0).ToString())
                End While
            End Using
            My.Computer.FileSystem.DeleteFile(Datos)
        End If
    End Sub

    Private Sub GuardarGeneros()
        Dim Contador As Integer
        For Contador = 0 To Form1.ComboBoxGenero.Items.Count - 1
            My.Computer.FileSystem.WriteAllText(Generos, Form1.ComboBoxGenero.Items(Contador) & "#" & vbCrLf, True)
        Next
    End Sub

    Public Sub GrabarDatosFichero(textBoxNombreGen As TextBox)
        Dim contador As Integer
        For contador = 0 To Form1.ComboBoxGenero.Items.Count - 1
            My.Computer.FileSystem.WriteAllText(Datos, textBoxNombreGen.Text & "#", True)
        Next
    End Sub

    Public Sub CargarPeliculas()
        If My.Computer.FileSystem.FileExists(ListaPeliculas) Then
            Dim fichero As String = ListaPeliculas
            Dim campos As String()
            Dim indice As Integer
            Dim delimitador As String = "#"
            Form3.ListaPelis.Items.Clear()

            Using Analizador_sintactico As New TextFieldParser(ListaPeliculas)
                Analizador_sintactico.SetDelimiters(delimitador)
                While Not Analizador_sintactico.EndOfData
                    campos = Analizador_sintactico.ReadFields()

                    If campos.Length >= 6 Then
                        Dim item As New ListViewItem(campos(0))
                        item.SubItems.Add(campos(1))
                        item.SubItems.Add(campos(2))
                        item.SubItems.Add(campos(3))
                        item.SubItems.Add(campos(4))
                        item.SubItems.Add(campos(5))

                        Form3.ListaPelis.Items.Add(item)
                    End If
                End While
            End Using
            My.Computer.FileSystem.DeleteFile(ListaPeliculas)
        End If
    End Sub

    Public Sub GuardarPeliculas()
        For Each contenido As ListViewItem In Form3.ListaPelis.Items
            Dim linea As String = String.Join("#",
                                                contenido.SubItems(0).Text,
                                                contenido.SubItems(1).Text,
                                                contenido.SubItems(2).Text,
                                                contenido.SubItems(3).Text,
                                                contenido.SubItems(4).Text,
                                                contenido.SubItems(5).Text
                                            )
            My.Computer.FileSystem.WriteAllText(ListaPeliculas, linea & vbCrLf, True)
        Next
    End Sub

    Public Sub AgregarSocio()
        If String.IsNullOrEmpty(Form2.TextBoxNombre.Text) Or
       String.IsNullOrEmpty(Form2.TextBoxApellido.Text) Or
       String.IsNullOrEmpty(Form2.TextBoxTelefono.Text) Or
       String.IsNullOrEmpty(Form2.TextBoxDNI.Text) Or
       String.IsNullOrEmpty(Form2.TextBoxPoblacion.Text) Or
       Form2.ComboBoxMayorEdad.Text = "--" Then

            MostrarMensaje()

        Else
            Dim existe As Boolean = False

            ' Verificar si el título ya existe
            For Each item As ListViewItem In Form4.ListViewSocios.Items
                If item.SubItems(1).Text.Equals(Form2.TextBoxNombre.Text, StringComparison.OrdinalIgnoreCase) Then
                    ' Si existe, actualizar los valores
                    item.SubItems(2).Text = Form2.TextBoxApellido.Text
                    item.SubItems(3).Text = Form2.TextBoxTelefono.Text
                    item.SubItems(4).Text = Form2.TextBoxDNI.Text
                    item.SubItems(5).Text = Form2.TextBoxPoblacion.Text
                    item.SubItems(6).Text = Form2.ComboBoxMayorEdad.SelectedText
                    existe = True
                    Exit For
                End If
            Next

            limpiarFormSocios()

        End If
    End Sub

    Public Sub limpiarFormSocios()
        Form2.TextBoxNombre.Clear()
        Form2.TextBoxApellido.Clear()
        Form2.TextBoxTelefono.Clear()
        Form2.TextBoxDNI.Clear()
        Form2.TextBoxPoblacion.Clear()
        Form2.ComboBoxMayorEdad.SelectedIndex = 0
    End Sub

End Module
