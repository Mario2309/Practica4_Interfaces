Module Module1
    Public Async Sub MostrarMensajeAcercaDe()
        MessageBox.Show("No puedes crear contactos incompletos")
        Await Task.Delay(3000)
        SendKeys.Send("{ESC}")
    End Sub
End Module
