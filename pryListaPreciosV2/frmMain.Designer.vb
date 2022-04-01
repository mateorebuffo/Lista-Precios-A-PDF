<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCrearDocumento = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblGrilla = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.gpbBusquedaDatos = New System.Windows.Forms.GroupBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.lblProducto = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBusquedaDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCrearDocumento
        '
        Me.btnCrearDocumento.Location = New System.Drawing.Point(351, 465)
        Me.btnCrearDocumento.Name = "btnCrearDocumento"
        Me.btnCrearDocumento.Size = New System.Drawing.Size(75, 36)
        Me.btnCrearDocumento.TabIndex = 19
        Me.btnCrearDocumento.Text = "Exportar"
        Me.btnCrearDocumento.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(14, 465)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 36)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'lblGrilla
        '
        Me.lblGrilla.AutoSize = True
        Me.lblGrilla.Location = New System.Drawing.Point(11, 97)
        Me.lblGrilla.Name = "lblGrilla"
        Me.lblGrilla.Size = New System.Drawing.Size(30, 13)
        Me.lblGrilla.TabIndex = 17
        Me.lblGrilla.Text = "Grilla"
        '
        'dgvLista
        '
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Location = New System.Drawing.Point(12, 113)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(414, 346)
        Me.dgvLista.TabIndex = 16
        '
        'gpbBusquedaDatos
        '
        Me.gpbBusquedaDatos.Controls.Add(Me.cmbProductos)
        Me.gpbBusquedaDatos.Controls.Add(Me.btn)
        Me.gpbBusquedaDatos.Controls.Add(Me.lblProducto)
        Me.gpbBusquedaDatos.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.gpbBusquedaDatos.Location = New System.Drawing.Point(12, 12)
        Me.gpbBusquedaDatos.Name = "gpbBusquedaDatos"
        Me.gpbBusquedaDatos.Size = New System.Drawing.Size(414, 82)
        Me.gpbBusquedaDatos.TabIndex = 15
        Me.gpbBusquedaDatos.TabStop = False
        Me.gpbBusquedaDatos.Text = "Busqueda"
        '
        'cmbProductos
        '
        Me.cmbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(72, 19)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(327, 21)
        Me.cmbProductos.TabIndex = 4
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(326, 46)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(73, 23)
        Me.btn.TabIndex = 2
        Me.btn.Text = "Buscar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(15, 24)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 508)
        Me.Controls.Add(Me.btnCrearDocumento)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.lblGrilla)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.gpbBusquedaDatos)
        Me.Name = "frmMain"
        Me.Text = "Lista de precios"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBusquedaDatos.ResumeLayout(False)
        Me.gpbBusquedaDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCrearDocumento As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblGrilla As Label
    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents gpbBusquedaDatos As GroupBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents btn As Button
    Friend WithEvents lblProducto As Label
End Class
