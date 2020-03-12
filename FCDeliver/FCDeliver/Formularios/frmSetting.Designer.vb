<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.btnrut = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnrut
        '
        Me.btnrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrut.Location = New System.Drawing.Point(289, 24)
        Me.btnrut.Name = "btnrut"
        Me.btnrut.Size = New System.Drawing.Size(28, 20)
        Me.btnrut.TabIndex = 21
        Me.btnrut.Text = "..."
        Me.btnrut.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Ruta local General de los Archivos"
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(6, 25)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(277, 20)
        Me.txtruta.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(353, 10)
        Me.Label7.TabIndex = 22
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(364, 64)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnrut)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtruta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración Ruta local"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnrut As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtruta As TextBox
    Friend WithEvents Label7 As Label
End Class
