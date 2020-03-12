<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBitacora
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgEmpresas = New System.Windows.Forms.DataGridView()
        Me.idempresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomempresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lServicio = New System.Windows.Forms.Label()
        Me.dgServiciosMen = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiposer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.febg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.febe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mare = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mayg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maye = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.june = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.julg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agoe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sepg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sepe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.octg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.octE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.novg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nove = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dicg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbejercicio = New System.Windows.Forms.ComboBox()
        Me.dgentregado = New System.Windows.Forms.DataGridView()
        Me.ecodigoservicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eperiodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eejercicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enombrearchivog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enombrearchivoe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.efechacorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.efechaentregado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lEnt = New System.Windows.Forms.Label()
        Me.pbEnt = New System.Windows.Forms.ProgressBar()
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgServiciosMen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgentregado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgEmpresas
        '
        Me.dgEmpresas.AllowUserToAddRows = False
        Me.dgEmpresas.AllowUserToDeleteRows = False
        Me.dgEmpresas.AllowUserToResizeColumns = False
        Me.dgEmpresas.AllowUserToResizeRows = False
        Me.dgEmpresas.BackgroundColor = System.Drawing.Color.White
        Me.dgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idempresa, Me.nomempresa})
        Me.dgEmpresas.Location = New System.Drawing.Point(12, 25)
        Me.dgEmpresas.Name = "dgEmpresas"
        Me.dgEmpresas.ReadOnly = True
        Me.dgEmpresas.RowHeadersVisible = False
        Me.dgEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmpresas.Size = New System.Drawing.Size(446, 149)
        Me.dgEmpresas.TabIndex = 0
        '
        'idempresa
        '
        Me.idempresa.HeaderText = "id empresa"
        Me.idempresa.Name = "idempresa"
        Me.idempresa.ReadOnly = True
        Me.idempresa.Visible = False
        '
        'nomempresa
        '
        Me.nomempresa.HeaderText = "Nombre Empresa"
        Me.nomempresa.Name = "nomempresa"
        Me.nomempresa.ReadOnly = True
        Me.nomempresa.Width = 440
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empresas"
        '
        'lServicio
        '
        Me.lServicio.AutoSize = True
        Me.lServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lServicio.Location = New System.Drawing.Point(9, 197)
        Me.lServicio.Name = "lServicio"
        Me.lServicio.Size = New System.Drawing.Size(123, 13)
        Me.lServicio.TabIndex = 2
        Me.lServicio.Text = "Servicios Mensuales"
        '
        'dgServiciosMen
        '
        Me.dgServiciosMen.AllowUserToAddRows = False
        Me.dgServiciosMen.AllowUserToDeleteRows = False
        Me.dgServiciosMen.AllowUserToResizeColumns = False
        Me.dgServiciosMen.AllowUserToResizeRows = False
        Me.dgServiciosMen.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgServiciosMen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgServiciosMen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServiciosMen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.nombreser, Me.tiposer, Me.Actd, Me.estadoser, Me.descriser, Me.Enero, Me.enee, Me.febg, Me.febe, Me.marg, Me.mare, Me.abrg, Me.abre, Me.mayg, Me.maye, Me.jung, Me.june, Me.julg, Me.jule, Me.agog, Me.agoe, Me.sepg, Me.sepe, Me.octg, Me.octE, Me.novg, Me.nove, Me.dicg, Me.dice})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgServiciosMen.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgServiciosMen.EnableHeadersVisualStyles = False
        Me.dgServiciosMen.Location = New System.Drawing.Point(12, 213)
        Me.dgServiciosMen.Name = "dgServiciosMen"
        Me.dgServiciosMen.ReadOnly = True
        Me.dgServiciosMen.RowHeadersVisible = False
        Me.dgServiciosMen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgServiciosMen.Size = New System.Drawing.Size(1155, 211)
        Me.dgServiciosMen.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "idservicio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 20
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'nombreser
        '
        Me.nombreser.HeaderText = "Nombre Servicio"
        Me.nombreser.Name = "nombreser"
        Me.nombreser.ReadOnly = True
        Me.nombreser.Width = 120
        '
        'tiposer
        '
        Me.tiposer.HeaderText = "Fisico"
        Me.tiposer.Name = "tiposer"
        Me.tiposer.ReadOnly = True
        Me.tiposer.ToolTipText = "Documento Fisio"
        Me.tiposer.Width = 60
        '
        'Actd
        '
        Me.Actd.HeaderText = "Actualizable"
        Me.Actd.Name = "Actd"
        Me.Actd.ReadOnly = True
        Me.Actd.ToolTipText = "Documento Actualizable"
        Me.Actd.Width = 75
        '
        'estadoser
        '
        Me.estadoser.HeaderText = "Estado"
        Me.estadoser.Name = "estadoser"
        Me.estadoser.ReadOnly = True
        Me.estadoser.Width = 50
        '
        'descriser
        '
        Me.descriser.HeaderText = "Descripción"
        Me.descriser.Name = "descriser"
        Me.descriser.ReadOnly = True
        Me.descriser.Visible = False
        Me.descriser.Width = 150
        '
        'Enero
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Enero.DefaultCellStyle = DataGridViewCellStyle2
        Me.Enero.HeaderText = "Ene. G"
        Me.Enero.Name = "Enero"
        Me.Enero.ReadOnly = True
        Me.Enero.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Enero.ToolTipText = "Enero Generado"
        Me.Enero.Width = 35
        '
        'enee
        '
        Me.enee.HeaderText = "Ene. E"
        Me.enee.Name = "enee"
        Me.enee.ReadOnly = True
        Me.enee.ToolTipText = "Enero Entregado"
        Me.enee.Width = 35
        '
        'febg
        '
        Me.febg.HeaderText = "Feb. G"
        Me.febg.Name = "febg"
        Me.febg.ReadOnly = True
        Me.febg.ToolTipText = "Febrero Generado"
        Me.febg.Width = 35
        '
        'febe
        '
        Me.febe.HeaderText = "Feb. E"
        Me.febe.Name = "febe"
        Me.febe.ReadOnly = True
        Me.febe.ToolTipText = "Febrero Entregado"
        Me.febe.Width = 35
        '
        'marg
        '
        Me.marg.HeaderText = "Mar. G"
        Me.marg.Name = "marg"
        Me.marg.ReadOnly = True
        Me.marg.ToolTipText = "Marzo Generado"
        Me.marg.Width = 35
        '
        'mare
        '
        Me.mare.HeaderText = "Mar. E"
        Me.mare.Name = "mare"
        Me.mare.ReadOnly = True
        Me.mare.ToolTipText = "Marzo Entregado"
        Me.mare.Width = 35
        '
        'abrg
        '
        Me.abrg.HeaderText = "Abr.  G"
        Me.abrg.Name = "abrg"
        Me.abrg.ReadOnly = True
        Me.abrg.ToolTipText = "Abril Generado"
        Me.abrg.Width = 35
        '
        'abre
        '
        Me.abre.HeaderText = "Abr.  E"
        Me.abre.Name = "abre"
        Me.abre.ReadOnly = True
        Me.abre.ToolTipText = "Abril Entregado"
        Me.abre.Width = 35
        '
        'mayg
        '
        Me.mayg.HeaderText = "May. G"
        Me.mayg.Name = "mayg"
        Me.mayg.ReadOnly = True
        Me.mayg.ToolTipText = "Mayo Generado"
        Me.mayg.Width = 35
        '
        'maye
        '
        Me.maye.HeaderText = "May. E"
        Me.maye.Name = "maye"
        Me.maye.ReadOnly = True
        Me.maye.ToolTipText = "Mayo Entregado"
        Me.maye.Width = 35
        '
        'jung
        '
        Me.jung.HeaderText = "Jun. G"
        Me.jung.Name = "jung"
        Me.jung.ReadOnly = True
        Me.jung.ToolTipText = "Junio Generado"
        Me.jung.Width = 35
        '
        'june
        '
        Me.june.HeaderText = "Jun. E"
        Me.june.Name = "june"
        Me.june.ReadOnly = True
        Me.june.ToolTipText = "Junio Entregado"
        Me.june.Width = 35
        '
        'julg
        '
        Me.julg.HeaderText = "Jul. G"
        Me.julg.Name = "julg"
        Me.julg.ReadOnly = True
        Me.julg.ToolTipText = "Julio Generado"
        Me.julg.Width = 35
        '
        'jule
        '
        Me.jule.HeaderText = "Jul. E"
        Me.jule.Name = "jule"
        Me.jule.ReadOnly = True
        Me.jule.ToolTipText = "Julio Entregado"
        Me.jule.Width = 40
        '
        'agog
        '
        Me.agog.HeaderText = "Ago. G"
        Me.agog.Name = "agog"
        Me.agog.ReadOnly = True
        Me.agog.ToolTipText = "Agosto Generado"
        Me.agog.Width = 35
        '
        'agoe
        '
        Me.agoe.HeaderText = "Ago. E"
        Me.agoe.Name = "agoe"
        Me.agoe.ReadOnly = True
        Me.agoe.ToolTipText = "Agosto Entregado"
        Me.agoe.Width = 35
        '
        'sepg
        '
        Me.sepg.HeaderText = "Sep. G"
        Me.sepg.Name = "sepg"
        Me.sepg.ReadOnly = True
        Me.sepg.ToolTipText = "Septiembre Generado"
        Me.sepg.Width = 35
        '
        'sepe
        '
        Me.sepe.HeaderText = "Sep. E"
        Me.sepe.Name = "sepe"
        Me.sepe.ReadOnly = True
        Me.sepe.ToolTipText = "Septiembre Entregado"
        Me.sepe.Width = 35
        '
        'octg
        '
        Me.octg.HeaderText = "Oct. G"
        Me.octg.Name = "octg"
        Me.octg.ReadOnly = True
        Me.octg.ToolTipText = "Octubre Generado"
        Me.octg.Width = 35
        '
        'octE
        '
        Me.octE.HeaderText = "Oct. E"
        Me.octE.Name = "octE"
        Me.octE.ReadOnly = True
        Me.octE.ToolTipText = "Octubre Entregado"
        Me.octE.Width = 35
        '
        'novg
        '
        Me.novg.HeaderText = "Nov. G"
        Me.novg.Name = "novg"
        Me.novg.ReadOnly = True
        Me.novg.ToolTipText = "Noviembre Generado"
        Me.novg.Width = 35
        '
        'nove
        '
        Me.nove.HeaderText = "Nov. E"
        Me.nove.Name = "nove"
        Me.nove.ReadOnly = True
        Me.nove.ToolTipText = "Noviembre Entregado"
        Me.nove.Width = 35
        '
        'dicg
        '
        Me.dicg.HeaderText = "Dic. G"
        Me.dicg.Name = "dicg"
        Me.dicg.ReadOnly = True
        Me.dicg.ToolTipText = "Diciembre Generado"
        Me.dicg.Width = 35
        '
        'dice
        '
        Me.dice.HeaderText = "Dic. E"
        Me.dice.Name = "dice"
        Me.dice.ReadOnly = True
        Me.dice.ToolTipText = "Diciembre Entregado"
        Me.dice.Width = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Servicios Anuales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filtro para el Año"
        '
        'cbejercicio
        '
        Me.cbejercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbejercicio.FormattingEnabled = True
        Me.cbejercicio.Location = New System.Drawing.Point(337, 189)
        Me.cbejercicio.Name = "cbejercicio"
        Me.cbejercicio.Size = New System.Drawing.Size(121, 21)
        Me.cbejercicio.TabIndex = 7
        '
        'dgentregado
        '
        Me.dgentregado.AllowUserToAddRows = False
        Me.dgentregado.AllowUserToDeleteRows = False
        Me.dgentregado.AllowUserToResizeColumns = False
        Me.dgentregado.AllowUserToResizeRows = False
        Me.dgentregado.BackgroundColor = System.Drawing.Color.White
        Me.dgentregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgentregado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ecodigoservicio, Me.eperiodo, Me.eejercicio, Me.enombrearchivog, Me.enombrearchivoe, Me.efechacorte, Me.efechaentregado})
        Me.dgentregado.Location = New System.Drawing.Point(538, 27)
        Me.dgentregado.Name = "dgentregado"
        Me.dgentregado.ReadOnly = True
        Me.dgentregado.RowHeadersVisible = False
        Me.dgentregado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgentregado.Size = New System.Drawing.Size(539, 147)
        Me.dgentregado.TabIndex = 8
        '
        'ecodigoservicio
        '
        Me.ecodigoservicio.HeaderText = "Cod. Servicio"
        Me.ecodigoservicio.Name = "ecodigoservicio"
        Me.ecodigoservicio.ReadOnly = True
        '
        'eperiodo
        '
        Me.eperiodo.HeaderText = "Periodo"
        Me.eperiodo.Name = "eperiodo"
        Me.eperiodo.ReadOnly = True
        Me.eperiodo.Width = 70
        '
        'eejercicio
        '
        Me.eejercicio.HeaderText = "Ejercicio"
        Me.eejercicio.Name = "eejercicio"
        Me.eejercicio.ReadOnly = True
        Me.eejercicio.Width = 70
        '
        'enombrearchivog
        '
        Me.enombrearchivog.HeaderText = "Nom. Archivo Generado"
        Me.enombrearchivog.Name = "enombrearchivog"
        Me.enombrearchivog.ReadOnly = True
        Me.enombrearchivog.Width = 190
        '
        'enombrearchivoe
        '
        Me.enombrearchivoe.HeaderText = "Nombre Archivo E"
        Me.enombrearchivoe.Name = "enombrearchivoe"
        Me.enombrearchivoe.ReadOnly = True
        Me.enombrearchivoe.Visible = False
        '
        'efechacorte
        '
        Me.efechacorte.HeaderText = "Fecha Corte"
        Me.efechacorte.Name = "efechacorte"
        Me.efechacorte.ReadOnly = True
        '
        'efechaentregado
        '
        Me.efechaentregado.HeaderText = "Fecha entregado"
        Me.efechaentregado.Name = "efechaentregado"
        Me.efechaentregado.ReadOnly = True
        Me.efechaentregado.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(535, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Serviciós para entregar"
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(1083, 27)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(75, 31)
        Me.btnEntregar.TabIndex = 10
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1083, 76)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 31)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lEnt
        '
        Me.lEnt.AutoSize = True
        Me.lEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEnt.Location = New System.Drawing.Point(779, 189)
        Me.lEnt.Name = "lEnt"
        Me.lEnt.Size = New System.Drawing.Size(88, 13)
        Me.lEnt.TabIndex = 12
        Me.lEnt.Text = "Entregando ..."
        Me.lEnt.Visible = False
        '
        'pbEnt
        '
        Me.pbEnt.Location = New System.Drawing.Point(873, 184)
        Me.pbEnt.Name = "pbEnt"
        Me.pbEnt.Size = New System.Drawing.Size(204, 23)
        Me.pbEnt.Step = 1
        Me.pbEnt.TabIndex = 13
        Me.pbEnt.Visible = False
        '
        'frmBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1170, 596)
        Me.Controls.Add(Me.pbEnt)
        Me.Controls.Add(Me.lEnt)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEntregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgentregado)
        Me.Controls.Add(Me.cbejercicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgServiciosMen)
        Me.Controls.Add(Me.lServicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgEmpresas)
        Me.MaximizeBox = False
        Me.Name = "frmBitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bitacora"
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgServiciosMen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgentregado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgEmpresas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lServicio As Label
    Friend WithEvents dgServiciosMen As DataGridView
    Friend WithEvents idempresa As DataGridViewTextBoxColumn
    Friend WithEvents nomempresa As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents nombreser As DataGridViewTextBoxColumn
    Friend WithEvents tiposer As DataGridViewTextBoxColumn
    Friend WithEvents Actd As DataGridViewTextBoxColumn
    Friend WithEvents estadoser As DataGridViewTextBoxColumn
    Friend WithEvents descriser As DataGridViewTextBoxColumn
    Friend WithEvents Enero As DataGridViewTextBoxColumn
    Friend WithEvents enee As DataGridViewTextBoxColumn
    Friend WithEvents febg As DataGridViewTextBoxColumn
    Friend WithEvents febe As DataGridViewTextBoxColumn
    Friend WithEvents marg As DataGridViewTextBoxColumn
    Friend WithEvents mare As DataGridViewTextBoxColumn
    Friend WithEvents abrg As DataGridViewTextBoxColumn
    Friend WithEvents abre As DataGridViewTextBoxColumn
    Friend WithEvents mayg As DataGridViewTextBoxColumn
    Friend WithEvents maye As DataGridViewTextBoxColumn
    Friend WithEvents jung As DataGridViewTextBoxColumn
    Friend WithEvents june As DataGridViewTextBoxColumn
    Friend WithEvents julg As DataGridViewTextBoxColumn
    Friend WithEvents jule As DataGridViewTextBoxColumn
    Friend WithEvents agog As DataGridViewTextBoxColumn
    Friend WithEvents agoe As DataGridViewTextBoxColumn
    Friend WithEvents sepg As DataGridViewTextBoxColumn
    Friend WithEvents sepe As DataGridViewTextBoxColumn
    Friend WithEvents octg As DataGridViewTextBoxColumn
    Friend WithEvents octE As DataGridViewTextBoxColumn
    Friend WithEvents novg As DataGridViewTextBoxColumn
    Friend WithEvents nove As DataGridViewTextBoxColumn
    Friend WithEvents dicg As DataGridViewTextBoxColumn
    Friend WithEvents dice As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents cbejercicio As ComboBox
    Friend WithEvents dgentregado As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEntregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lEnt As Label
    Friend WithEvents pbEnt As ProgressBar
    Friend WithEvents ecodigoservicio As DataGridViewTextBoxColumn
    Friend WithEvents eperiodo As DataGridViewTextBoxColumn
    Friend WithEvents eejercicio As DataGridViewTextBoxColumn
    Friend WithEvents enombrearchivog As DataGridViewTextBoxColumn
    Friend WithEvents enombrearchivoe As DataGridViewTextBoxColumn
    Friend WithEvents efechacorte As DataGridViewTextBoxColumn
    Friend WithEvents efechaentregado As DataGridViewTextBoxColumn
End Class
