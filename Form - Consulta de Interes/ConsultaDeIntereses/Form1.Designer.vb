<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaIntereses
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.chkViajes = New System.Windows.Forms.CheckBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.chkDeportes = New System.Windows.Forms.CheckBox()
        Me.chkCine = New System.Windows.Forms.CheckBox()
        Me.chkInformatica = New System.Windows.Forms.CheckBox()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.cboCiudad = New System.Windows.Forms.ComboBox()
        Me.gbxListaIntereses = New System.Windows.Forms.GroupBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.gbxSexo = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxListaIntereses.SuspendLayout()
        Me.gbxSexo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(124, 41)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 20)
        Me.txtNombre.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(315, 216)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'chkViajes
        '
        Me.chkViajes.AutoSize = True
        Me.chkViajes.Location = New System.Drawing.Point(10, 22)
        Me.chkViajes.Name = "chkViajes"
        Me.chkViajes.Size = New System.Drawing.Size(54, 17)
        Me.chkViajes.TabIndex = 3
        Me.chkViajes.Text = "Viajes"
        Me.chkViajes.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(36, 44)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre:"
        '
        'chkDeportes
        '
        Me.chkDeportes.AutoSize = True
        Me.chkDeportes.Location = New System.Drawing.Point(10, 45)
        Me.chkDeportes.Name = "chkDeportes"
        Me.chkDeportes.Size = New System.Drawing.Size(69, 17)
        Me.chkDeportes.TabIndex = 5
        Me.chkDeportes.Text = "Deportes"
        Me.chkDeportes.UseVisualStyleBackColor = True
        '
        'chkCine
        '
        Me.chkCine.AutoSize = True
        Me.chkCine.Location = New System.Drawing.Point(10, 68)
        Me.chkCine.Name = "chkCine"
        Me.chkCine.Size = New System.Drawing.Size(47, 17)
        Me.chkCine.TabIndex = 6
        Me.chkCine.Text = "Cine"
        Me.chkCine.UseVisualStyleBackColor = True
        '
        'chkInformatica
        '
        Me.chkInformatica.AutoSize = True
        Me.chkInformatica.Location = New System.Drawing.Point(10, 91)
        Me.chkInformatica.Name = "chkInformatica"
        Me.chkInformatica.Size = New System.Drawing.Size(78, 17)
        Me.chkInformatica.TabIndex = 7
        Me.chkInformatica.Text = "Informática"
        Me.chkInformatica.UseVisualStyleBackColor = True
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.Location = New System.Drawing.Point(80, 15)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rdbFemenino.TabIndex = 4
        Me.rdbFemenino.Text = "Femenino"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Checked = True
        Me.rdbMasculino.Location = New System.Drawing.Point(6, 15)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdbMasculino.TabIndex = 3
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(36, 84)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(124, 81)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtEmail.TabIndex = 10
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(36, 120)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(43, 13)
        Me.lblCiudad.TabIndex = 12
        Me.lblCiudad.Text = "Ciudad:"
        '
        'cboCiudad
        '
        Me.cboCiudad.FormattingEnabled = True
        Me.cboCiudad.ItemHeight = 13
        Me.cboCiudad.Items.AddRange(New Object() {"ASUNCION", "CAPIATE", "SAN LORENZO"})
        Me.cboCiudad.Location = New System.Drawing.Point(124, 117)
        Me.cboCiudad.Name = "cboCiudad"
        Me.cboCiudad.Size = New System.Drawing.Size(150, 21)
        Me.cboCiudad.TabIndex = 13
        '
        'gbxListaIntereses
        '
        Me.gbxListaIntereses.Controls.Add(Me.chkInformatica)
        Me.gbxListaIntereses.Controls.Add(Me.chkCine)
        Me.gbxListaIntereses.Controls.Add(Me.chkDeportes)
        Me.gbxListaIntereses.Controls.Add(Me.chkViajes)
        Me.gbxListaIntereses.Location = New System.Drawing.Point(349, 41)
        Me.gbxListaIntereses.Name = "gbxListaIntereses"
        Me.gbxListaIntereses.Size = New System.Drawing.Size(125, 124)
        Me.gbxListaIntereses.TabIndex = 15
        Me.gbxListaIntereses.TabStop = False
        Me.gbxListaIntereses.Text = "Lista de Intereses"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(36, 161)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 16
        Me.lblSexo.Text = "Sexo:"
        '
        'gbxSexo
        '
        Me.gbxSexo.Controls.Add(Me.rdbFemenino)
        Me.gbxSexo.Controls.Add(Me.rdbMasculino)
        Me.gbxSexo.Location = New System.Drawing.Point(117, 144)
        Me.gbxSexo.Name = "gbxSexo"
        Me.gbxSexo.Size = New System.Drawing.Size(157, 40)
        Me.gbxSexo.TabIndex = 3
        Me.gbxSexo.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(399, 216)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmConsultaIntereses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 251)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxSexo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.gbxListaIntereses)
        Me.Controls.Add(Me.cboCiudad)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "frmConsultaIntereses"
        Me.Text = "Consulta de Intereses"
        Me.gbxListaIntereses.ResumeLayout(False)
        Me.gbxListaIntereses.PerformLayout()
        Me.gbxSexo.ResumeLayout(False)
        Me.gbxSexo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents chkViajes As System.Windows.Forms.CheckBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents chkDeportes As System.Windows.Forms.CheckBox
    Friend WithEvents chkCine As System.Windows.Forms.CheckBox
    Friend WithEvents chkInformatica As System.Windows.Forms.CheckBox
    Friend WithEvents rdbFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents cboCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents gbxListaIntereses As System.Windows.Forms.GroupBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents gbxSexo As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
