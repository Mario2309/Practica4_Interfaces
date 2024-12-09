Module ModuleBotones
    Public Sub ClickBtnForm1()
        If Form1.btn.Text = "Agregar" Then
            Module1.AgregarPelicula()
        ElseIf Form1.btn.Text = "Eliminar" Then
            Module1.EliminarPelicula(Form1.ComboBoxTitulo, Form3.ListaPelis, Form1.contadorPelis)
        End If
    End Sub

    Public Sub clickAgregarSocio()
        Module1.AgregarSocio()
    End Sub

    Public Sub clickGrabarGenero()
        If Form7.Agregar.Text = "Agregar" Then
            Module1.GrabarDatosFichero(Form7.TextBoxNombreGenero)
            Module1.AgregarGenero()
            Module1.AgregarGeneroNuevo()
        ElseIf Form7.Agregar.Text = "Eliminar" Then

        End If
    End Sub
End Module
