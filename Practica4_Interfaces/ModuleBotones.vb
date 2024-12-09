Module ModuleBotones
    Public Sub ClickBtnForm1()
        If Form1.btn.Text = "Agregar" Then
            Module1.AgregarPelicula()
        ElseIf Form1.btn.Text = "Eliminar" Then
            Module1.EliminarPelicula()
        End If
    End Sub

    Public Sub clickAgregarSocio()
        Module1.AgregarSocio()
    End Sub
End Module
