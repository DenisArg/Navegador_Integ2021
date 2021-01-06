<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panBrowser = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdEnvioDatos = New System.Windows.Forms.Button()
        Me.TxT_URL = New System.Windows.Forms.TextBox()
        Me.cmbSalir = New System.Windows.Forms.Button()
        Me.txtcuit = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panBrowser
        '
        Me.panBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panBrowser.Location = New System.Drawing.Point(862, 211)
        Me.panBrowser.Name = "panBrowser"
        Me.panBrowser.Size = New System.Drawing.Size(1282, 124)
        Me.panBrowser.TabIndex = 5
        Me.panBrowser.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1318, 529)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1310, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Notarinteg - .Net"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmdEnvioDatos
        '
        Me.cmdEnvioDatos.Location = New System.Drawing.Point(16, 12)
        Me.cmdEnvioDatos.Name = "cmdEnvioDatos"
        Me.cmdEnvioDatos.Size = New System.Drawing.Size(488, 23)
        Me.cmdEnvioDatos.TabIndex = 0
        Me.cmdEnvioDatos.Text = "Click para Enviar Datos a la Pagina"
        Me.cmdEnvioDatos.UseVisualStyleBackColor = True
        '
        'TxT_URL
        '
        Me.TxT_URL.Location = New System.Drawing.Point(845, 15)
        Me.TxT_URL.Name = "TxT_URL"
        Me.TxT_URL.Size = New System.Drawing.Size(100, 20)
        Me.TxT_URL.TabIndex = 12
        Me.TxT_URL.Visible = False
        '
        'cmbSalir
        '
        Me.cmbSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSalir.Location = New System.Drawing.Point(1051, 12)
        Me.cmbSalir.Name = "cmbSalir"
        Me.cmbSalir.Size = New System.Drawing.Size(275, 23)
        Me.cmbSalir.TabIndex = 2
        Me.cmbSalir.Text = "Volver"
        Me.cmbSalir.UseVisualStyleBackColor = True
        '
        'txtcuit
        '
        Me.txtcuit.Location = New System.Drawing.Point(493, 12)
        Me.txtcuit.Name = "txtcuit"
        Me.txtcuit.Size = New System.Drawing.Size(100, 20)
        Me.txtcuit.TabIndex = 50
        Me.txtcuit.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 582)
        Me.Controls.Add(Me.txtcuit)
        Me.Controls.Add(Me.cmbSalir)
        Me.Controls.Add(Me.TxT_URL)
        Me.Controls.Add(Me.cmdEnvioDatos)
        Me.Controls.Add(Me.panBrowser)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notarinteg - .Net"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panBrowser As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cmdEnvioDatos As Button
    Friend WithEvents TxT_URL As TextBox
    Friend WithEvents cmbSalir As Button
    Friend WithEvents txtcuit As TextBox
End Class
