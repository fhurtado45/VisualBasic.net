Imports clientes
Imports ClientesEntidades



Public Class ClientesF1
    Public ClienteBL As New clientes.BLL.ClientesBL
    Private Sub ClientesF1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarFormatoClientes()
        limpiarFormatoActualizacion()
        btnAceptarMod.Enabled = False
        CreaColumnasDGV()
    End Sub
    Private Sub LimpiarFormatoClientes()
        inclNombre.Text = String.Empty
        inclRamo.Text = String.Empty
        inclPassword.Text = String.Empty
        inclLogin.Text = String.Empty
        inclNroID.Text = String.Empty
        inclFechaInclusion.Text = String.Empty
        inclMensaje.Text = String.Empty
        inclLabelID.Visible = False
    End Sub

    Private Sub limpiarFormatoActualizacion()
        modIdCliente.Text = String.Empty
        modNombre.Text = String.Empty
        modRamo.Text = String.Empty
        modFecha.Text = String.Empty
        modLogin.Text = String.Empty
        modRamo.Text = String.Empty
        modPassword.Text = String.Empty
        modMensaje.Text = String.Empty

    End Sub

    Private Sub btnAceptarIncl_Click(sender As Object, e As EventArgs) Handles btnAceptarIncl.Click
        Dim Id As Integer
        Dim cli As Cliente = IncluirClientes()
        Id = ClienteBL.insertarClientes(cli)
        inclMensaje.Text = "Cliente incluido"
        inclNroID.Text = Id
        inclLabelID.Visible = True
    End Sub

    Private Function IncluirClientes() As Cliente

        Dim x As New Cliente
        Dim dt As DateTime
        Date.TryParse(inclFechaInclusion.Text, dt)
        x.Nombre = inclNombre.Text
        x.Ramo = inclRamo.Text
        x.FechaRegistro = dt
        x.Login = inclLogin.Text
        x.PassWord = inclPassword.Text

        Return x
    End Function
    Private Sub CreaColumnasDGV()


    End Sub

    Private Sub consBtnRefrescar_Click(sender As Object, e As EventArgs) Handles consBtnRefrescar.Click
        dgvClientes.DataSource = ""
        Try
            Dim dt As DataTable
            dt = ClienteBL.consultarClientes
            dgvClientes.DataSource = dt
            dgvClientes.AutoResizeColumns()
        Catch ex As Exception
            MsgBox("No se pudo completar la consulta" & ex.Message)
        End Try



    End Sub

    Private Sub inclNombre_TextChanged(sender As Object, e As EventArgs) Handles inclNombre.TextChanged

    End Sub

    Private Sub inclNombre_GotFocus(sender As Object, e As EventArgs) Handles inclNombre.GotFocus
        LimpiarFormatoClientes()
    End Sub

    Private Sub btnAceptarMod_Click(sender As Object, e As EventArgs) Handles btnAceptarMod.Click
        Dim x As New Cliente
        Dim listaClientes As New List(Of Cliente)

        x.ID = modIdCliente.Text
        x.Nombre = modNombre.Text
        x.Ramo = modRamo.Text
        x.FechaRegistro = modFecha.Text
        x.Login = modLogin.Text
        x.PassWord = modPassword.Text
        listaClientes.Add(x)

        Try
            ClienteBL.actualizarClientes(listaClientes)
            modMensaje.Text = "Cliente actualizado"
            btnAceptarMod.Enabled = False
        Catch ex As Exception
            modMensaje.Text = "No se pudo actualizar el cliente"
        End Try

    End Sub

    Private Sub modIdCliente_TextChanged(sender As Object, e As EventArgs) Handles modIdCliente.TextChanged

    End Sub

    Private Sub modIdCliente_LostFocus(sender As Object, e As EventArgs) Handles modIdCliente.LostFocus

        Dim Lista As New List(Of Cliente)
        Dim Id As Integer = modIdCliente.Text
        btnAceptarMod.Enabled = True
        Try
            Lista = ClienteBL.obtenerListadoClientesPorId(Id)
            Dim contador As Integer = 0
            For Each x As Cliente In Lista
                contador += 1
                modNombre.Text = x.Nombre.ToString
                modRamo.Text = x.Ramo.ToString
                modFecha.Text = Format(CDate(x.FechaRegistro.ToString), "dd/MM/yyyy")
                modLogin.Text = x.Login.ToString
                modPassword.Text = x.PassWord.ToString
            Next
            modMensaje.Text = "Desea modificar este cliente? " & contador
        Catch ex As Exception
            modMensaje.Text = "Numero de ID no registrado: " & Id
        End Try

    End Sub

    Private Sub btnCancelarMod_Click(sender As Object, e As EventArgs) Handles btnCancelarMod.Click
        limpiarFormatoActualizacion()
        btnAceptarMod.Enabled = False
    End Sub

    Private Sub btnCancelarIncl_Click(sender As Object, e As EventArgs) Handles btnCancelarIncl.Click
        LimpiarFormatoClientes()
    End Sub

    Private Sub conBtnLimpiar_Click(sender As Object, e As EventArgs) Handles conBtnLimpiar.Click
        dgvClientes.DataSource = ""
    End Sub
End Class
