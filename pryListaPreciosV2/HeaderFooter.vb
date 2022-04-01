Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class HeaderFooter
    Inherits PdfPageEventHelper


    Private Sub PrintLine(grosor As Double, x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, writer As PdfWriter)
        Dim line As PdfContentByte 'Declara la linea'
        line = writer.DirectContent 'Codigo para pasarle coordenadas'
        line.SetLineWidth(grosor) 'Configura el ancho de la linea'
        line.MoveTo(x1, y1) 'MoveTo indica el punto de inicio de la linea'
        line.LineTo(x2, y2) 'indica hacia donde se dibuja la linea'
        line.Stroke() 'Traza la linea actual'
    End Sub

    Public Overrides Sub OnStartPage(writer As PdfWriter, pdfDoc As Document)
        Dim font10p As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
        Dim font10pBold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
        Dim font12p As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL))
        Dim contFilas As Integer = 0
        Dim cVacio As PdfPCell = New PdfPCell(New Phrase("")) 'celda vacia
        Dim espacio As New Paragraph


        espacio.Add(New Phrase(" ")) 'Lo uso para dejar un espacio o para bajar algo al renglon de abajo'
        cVacio.Border = 0

        'Creamos una tabla de 2 columnas y creamos las columnas'
        Dim tabla1 As PdfPTable = New PdfPTable(2) 'Se pasa el numero de columnas literal
        Dim colum1 As PdfPCell
        Dim colum2 As PdfPCell
        Dim colum3 As PdfPCell
        tabla1.WidthPercentage = 95 'Se define el ancho de la tabla para que no quede sobre los bordes'


        Dim widths As Single() = New Single() {4.0F, 7.0F} 'Esto crea la anchura de cada columna'
        tabla1.SetWidths(widths)



        'cargo la imagen del logo de la empresa y le doy tamaños y posicion
        Dim rutaImagen As String = Application.StartupPath & "\logomediano300.png" 'esta es la ruta de la imagen, uso esto para tomarlo desde la carpeta debug
        Dim imagenEncabezado As iTextSharp.text.Image
        imagenEncabezado = iTextSharp.text.Image.GetInstance(rutaImagen)
        imagenEncabezado.ScaleToFit(160.0F, 210.0F)
        imagenEncabezado.SpacingBefore = 20.0F
        imagenEncabezado.SpacingAfter = 10.0F
        imagenEncabezado.SetAbsolutePosition(40, 760)

        'Agrego el encabezado al pdf y dejo un espacio vacio
        pdfDoc.Add(imagenEncabezado)

        tabla1.AddCell(cVacio)

        'Creo la tabla con los datos de la empresa
        colum2 = New PdfPCell(New Phrase("VOIP EXPERTS SRL", font12p))
        colum2.Border = 0
        tabla1.AddCell(colum2)
        tabla1.AddCell(cVacio)

        colum2 = New PdfPCell(New Phrase("Mayoristas en insumos para mineria de criptomonedas", font10p))
        colum2.Border = 0
        tabla1.AddCell(colum2)
        tabla1.AddCell(cVacio)

        colum2 = New PdfPCell(New Phrase("Direccion: Juan de avila y zarate 2034 1A - Cerro de las rosas - Cordoba", font10p))
        colum2.Border = 0
        tabla1.AddCell(colum2)
        tabla1.AddCell(cVacio)

        colum2 = New PdfPCell(New Phrase("Telefono: 3515682878", font10p))
        colum2.Border = 0
        tabla1.AddCell(colum2)
        tabla1.AddCell(cVacio)

        colum2 = New PdfPCell(New Phrase("Whatsapp: 1166952204", font10p))
        colum2.Border = 0
        tabla1.AddCell(colum2)
        tabla1.AddCell(cVacio)

        pdfDoc.Add(tabla1)


        'Dibujo una linea y un espacio para separar
        PrintLine(0.5, 30, 733, 530, 733, writer)

        pdfDoc.Add(espacio)

        'Creo la tabla donde especifico el dia en el que se exporto el pdf
        Dim tabla2 As PdfPTable = New PdfPTable(1)
        Dim widths2 As Single() = New Single() {2.0F}
        tabla2.WidthPercentage = 95
        tabla2.SetWidths(widths2)


        colum1 = New PdfPCell(New Phrase("LISTADO DE PRECIOS. DIA:" + Now.Date(), font10pBold))
        colum1.Border = 0
        tabla2.AddCell(colum1)

        pdfDoc.Add(tabla2)



        'Dibujo una linea y un espacio para separar y deje dos espacios porque me parece que quedaba mejor
        PrintLine(0.5, 30, 700, 530, 700, writer)
        pdfDoc.Add(espacio)
        pdfDoc.Add(espacio)


        'Esta tabla3 es para los encabezados de la lista de precios
        Dim tabla3 As PdfPTable = New PdfPTable(3)
        Dim widths3 As Single() = New Single() {1.0F, 8.0F, 2.0F}
        tabla3.WidthPercentage = 95
        tabla3.SetWidths(widths3)

        colum1 = New PdfPCell(New Phrase("CODIGO", font10pBold))
        colum1.Border = 0
        tabla3.AddCell(colum1)

        colum2 = New PdfPCell(New Phrase("PRODUCTO", font10pBold))
        colum2.Border = 0
        tabla3.AddCell(colum2)

        colum3 = New PdfPCell(New Phrase("PRECIO", font10pBold))
        colum3.Border = 0
        tabla3.AddCell(colum3)

        pdfDoc.Add(tabla3)

        'Dibujo una linea y un espacio para separar y un espacio
        PrintLine(0.5, 30, 660, 530, 660, writer)
        pdfDoc.Add(espacio)
    End Sub
End Class
