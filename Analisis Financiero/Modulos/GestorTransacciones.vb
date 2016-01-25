Module GestorTransacciones
    Public Function CargarAño(ByVal Año As Integer, ByRef ListaTransaccionProyecto As List(Of Transaccion)) As List(Of Transaccion)
        Dim ListaTransaccion As New List(Of Transaccion)
        For Each TransaccionProyecto As Transaccion In ListaTransaccionProyecto
            If TransaccionProyecto.Año = Año Then ListaTransaccion.Add(TransaccionProyecto)
        Next
        Return ListaTransaccion
    End Function
    Public Function ExisteAño(ByVal Año As Integer, ByRef ListaTransaccion As List(Of Transaccion)) As Boolean
        For Each TransaccionEnLista As Transaccion In ListaTransaccion
            If TransaccionEnLista.Año = Año Then Return True
        Next
        Return False
    End Function
    Public Function EliminarAño(ByVal Año As Integer, ByRef ListaTransaccion As List(Of Transaccion)) As Integer
        For Each TransaccionEnLista As Transaccion In ListaTransaccion
            If TransaccionEnLista.Año = Año Then
                ListaTransaccion.Remove(TransaccionEnLista)
                Return 1
            End If
        Next
        Return 0
    End Function
End Module
