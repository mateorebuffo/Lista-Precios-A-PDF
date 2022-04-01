Imports System.Data.OleDb
Public Class Productos
    Dim conector As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BaseDeDatos.accdb")
    Dim comando As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter(comando)
    Dim tabla As New DataTable

    Public Sub New()

        Try
            comando.Connection = conector
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Productos"
            adaptador.Fill(tabla)

            Dim VEC(0) As DataColumn
            VEC(0) = tabla.Columns("codigo")
            tabla.PrimaryKey = VEC
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Function getTabla() As DataTable
        Return tabla
    End Function

    Public Sub Listar(Combo As ComboBox)
        Combo.ValueMember = "nombre"
        Combo.DataSource = tabla
    End Sub

    Public Sub Actualizar()
        'Creo el driver para que despues pueda tirar el update bien sin errores, lo que hace es como de intermediario entre lenguaje prog y lenguaje bd'
        Dim driverBD As New OleDbCommandBuilder(adaptador)
        adaptador.Update(tabla)
    End Sub
End Class
