<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.VisorDeDatos = New System.Windows.Forms.DataGridView()
        Me.textID = New System.Windows.Forms.Label()
        Me.AgregarRegistro = New System.Windows.Forms.Button()
        Me.CampoId = New System.Windows.Forms.TextBox()
        Me.NombreMascotaCampo = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.Label()
        Me.RazaCampo = New System.Windows.Forms.TextBox()
        Me.TextRaza = New System.Windows.Forms.Label()
        Me.CampoColor = New System.Windows.Forms.TextBox()
        Me.TextColor = New System.Windows.Forms.Label()
        Me.EditarRegistro = New System.Windows.Forms.Button()
        Me.EliminarRegistro = New System.Windows.Forms.Button()
        CType(Me.VisorDeDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisorDeDatos
        '
        Me.VisorDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VisorDeDatos.Location = New System.Drawing.Point(262, 23)
        Me.VisorDeDatos.Name = "VisorDeDatos"
        Me.VisorDeDatos.Size = New System.Drawing.Size(526, 359)
        Me.VisorDeDatos.TabIndex = 0
        '
        'textID
        '
        Me.textID.AutoSize = True
        Me.textID.Location = New System.Drawing.Point(12, 30)
        Me.textID.Name = "textID"
        Me.textID.Size = New System.Drawing.Size(18, 13)
        Me.textID.TabIndex = 1
        Me.textID.Text = "ID"
        '
        'AgregarRegistro
        '
        Me.AgregarRegistro.Location = New System.Drawing.Point(15, 235)
        Me.AgregarRegistro.Name = "AgregarRegistro"
        Me.AgregarRegistro.Size = New System.Drawing.Size(241, 23)
        Me.AgregarRegistro.TabIndex = 2
        Me.AgregarRegistro.Text = "Agregar Registro"
        Me.AgregarRegistro.UseVisualStyleBackColor = True
        '
        'CampoId
        '
        Me.CampoId.Location = New System.Drawing.Point(81, 23)
        Me.CampoId.Name = "CampoId"
        Me.CampoId.Size = New System.Drawing.Size(175, 20)
        Me.CampoId.TabIndex = 3
        '
        'NombreMascotaCampo
        '
        Me.NombreMascotaCampo.Location = New System.Drawing.Point(81, 65)
        Me.NombreMascotaCampo.Name = "NombreMascotaCampo"
        Me.NombreMascotaCampo.Size = New System.Drawing.Size(175, 20)
        Me.NombreMascotaCampo.TabIndex = 5
        '
        'TextNombre
        '
        Me.TextNombre.AutoSize = True
        Me.TextNombre.Location = New System.Drawing.Point(12, 72)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(44, 13)
        Me.TextNombre.TabIndex = 4
        Me.TextNombre.Text = "Nombre"
        '
        'RazaCampo
        '
        Me.RazaCampo.Location = New System.Drawing.Point(81, 107)
        Me.RazaCampo.Name = "RazaCampo"
        Me.RazaCampo.Size = New System.Drawing.Size(175, 20)
        Me.RazaCampo.TabIndex = 7
        '
        'TextRaza
        '
        Me.TextRaza.AutoSize = True
        Me.TextRaza.Location = New System.Drawing.Point(12, 114)
        Me.TextRaza.Name = "TextRaza"
        Me.TextRaza.Size = New System.Drawing.Size(32, 13)
        Me.TextRaza.TabIndex = 6
        Me.TextRaza.Text = "Raza"
        '
        'CampoColor
        '
        Me.CampoColor.Location = New System.Drawing.Point(81, 149)
        Me.CampoColor.Name = "CampoColor"
        Me.CampoColor.Size = New System.Drawing.Size(175, 20)
        Me.CampoColor.TabIndex = 9
        '
        'TextColor
        '
        Me.TextColor.AutoSize = True
        Me.TextColor.Location = New System.Drawing.Point(12, 156)
        Me.TextColor.Name = "TextColor"
        Me.TextColor.Size = New System.Drawing.Size(31, 13)
        Me.TextColor.TabIndex = 8
        Me.TextColor.Text = "Color"
        '
        'EditarRegistro
        '
        Me.EditarRegistro.Location = New System.Drawing.Point(134, 264)
        Me.EditarRegistro.Name = "EditarRegistro"
        Me.EditarRegistro.Size = New System.Drawing.Size(122, 23)
        Me.EditarRegistro.TabIndex = 10
        Me.EditarRegistro.Text = "Editar"
        Me.EditarRegistro.UseVisualStyleBackColor = True
        '
        'EliminarRegistro
        '
        Me.EliminarRegistro.Location = New System.Drawing.Point(15, 264)
        Me.EliminarRegistro.Name = "EliminarRegistro"
        Me.EliminarRegistro.Size = New System.Drawing.Size(113, 23)
        Me.EliminarRegistro.TabIndex = 11
        Me.EliminarRegistro.Text = "Eliminar"
        Me.EliminarRegistro.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EliminarRegistro)
        Me.Controls.Add(Me.EditarRegistro)
        Me.Controls.Add(Me.CampoColor)
        Me.Controls.Add(Me.TextColor)
        Me.Controls.Add(Me.RazaCampo)
        Me.Controls.Add(Me.TextRaza)
        Me.Controls.Add(Me.NombreMascotaCampo)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.CampoId)
        Me.Controls.Add(Me.AgregarRegistro)
        Me.Controls.Add(Me.textID)
        Me.Controls.Add(Me.VisorDeDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.VisorDeDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VisorDeDatos As DataGridView
    Friend WithEvents textID As Label
    Friend WithEvents AgregarRegistro As Button
    Friend WithEvents CampoId As TextBox
    Friend WithEvents NombreMascotaCampo As TextBox
    Friend WithEvents TextNombre As Label
    Friend WithEvents RazaCampo As TextBox
    Friend WithEvents TextRaza As Label
    Friend WithEvents CampoColor As TextBox
    Friend WithEvents TextColor As Label
    Friend WithEvents EditarRegistro As Button
    Friend WithEvents EliminarRegistro As Button
End Class
