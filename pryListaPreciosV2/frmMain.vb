Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class frmMain

    Dim objProducto As New Productos
    Dim tabla As DataTable

    Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
    Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de Precios.pdf", FileMode.Create, FileAccess.Write, FileShare.ReadWrite))


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tabla = objProducto.getTabla()
            dgvLista.DataSource = tabla
            'Le pongo anchura a las columnas
            dgvLista.Columns(0).Width = 70
            dgvLista.Columns(1).Width = 230
            dgvLista.Columns(2).Width = 70
            objProducto.Listar(cmbProductos)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ExportarComoLista()
        Dim font10p As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
        Dim font10pBold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
        Dim font12p As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL))
        Dim cVacio As PdfPCell = New PdfPCell(New Phrase(""))


        'creo una nueva instancia de la clase HeaderFooter y se la asigno al writer.PageEvent, esto lo hago para que en cada evento OnStartPage ponga todo lo que programe en la clase HeaderFooter
        Dim header As New HeaderFooter()
        pdfWrite.PageEvent = header

        pdfDoc.Open()

#Region "Lista de precios"
        Dim tabla4 As PdfPTable = New PdfPTable(3)
        Dim colum1 As PdfPCell
        Dim colum2 As PdfPCell
        Dim colum3 As PdfPCell
        Dim widths4 As Single() = New Single() {1.0F, 8.0F, 2.0F}
        tabla4.WidthPercentage = 95
        tabla4.SetWidths(widths4)

        For i = 0 To dgvLista.Rows.Count - 2

            colum1 = New PdfPCell(New Phrase(dgvLista(0, i).Value.ToString(), font10p))
            colum1.Border = 0
            tabla4.AddCell(colum1)

            colum2 = New PdfPCell(New Phrase(dgvLista(1, i).Value.ToString(), font10p))
            colum2.Border = 0
            tabla4.AddCell(colum2)

            colum3 = New PdfPCell(New Phrase("$ " & dgvLista(2, i).Value.ToString(), font10p))
            colum3.Border = 0
            tabla4.AddCell(colum3)
        Next

        pdfDoc.Add(tabla4)
#End Region

        pdfDoc.Close()

        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de Precios.pdf")
    End Sub

    Private Sub btnCrearDocumento_Click(sender As Object, e As EventArgs) Handles btnCrearDocumento.Click
        Try
            ExportarComoLista()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            objProducto.Actualizar()
            MessageBox.Show("Lista actualizada con exito!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
