<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SISTEMA
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LIMPIARLISTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ck_refri = New System.Windows.Forms.CheckBox()
        Me.ck_laptop = New System.Windows.Forms.CheckBox()
        Me.ck_telefono = New System.Windows.Forms.CheckBox()
        Me.ck_tv = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_plazo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cui = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LIMPIARMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(16, 231)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 144)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(131, 48)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 26)
        Me.txt_nombre.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARLISTASToolStripMenuItem, Me.LIMPIARMATRIZToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1232, 33)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LIMPIARLISTASToolStripMenuItem
        '
        Me.LIMPIARLISTASToolStripMenuItem.Name = "LIMPIARLISTASToolStripMenuItem"
        Me.LIMPIARLISTASToolStripMenuItem.Size = New System.Drawing.Size(153, 29)
        Me.LIMPIARLISTASToolStripMenuItem.Text = "LIMPIAR LISTAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global._201800934_EMPEÑO.My.Resources.Resources.fondo
        Me.GroupBox1.Controls.Add(Me.ListBox9)
        Me.GroupBox1.Controls.Add(Me.ListBox8)
        Me.GroupBox1.Controls.Add(Me.ListBox7)
        Me.GroupBox1.Controls.Add(Me.ListBox6)
        Me.GroupBox1.Controls.Add(Me.ListBox5)
        Me.GroupBox1.Controls.Add(Me.ListBox4)
        Me.GroupBox1.Controls.Add(Me.ListBox3)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cui)
        Me.GroupBox1.Controls.Add(Me.btn_calcular)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1207, 447)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS:"
        '
        'ListBox9
        '
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 20
        Me.ListBox9.Location = New System.Drawing.Point(1024, 231)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(120, 144)
        Me.ListBox9.TabIndex = 19
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 20
        Me.ListBox8.Location = New System.Drawing.Point(898, 231)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(120, 144)
        Me.ListBox8.TabIndex = 18
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 20
        Me.ListBox7.Location = New System.Drawing.Point(772, 231)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(120, 144)
        Me.ListBox7.TabIndex = 17
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 20
        Me.ListBox6.Location = New System.Drawing.Point(646, 231)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(120, 144)
        Me.ListBox6.TabIndex = 16
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(520, 231)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 144)
        Me.ListBox5.TabIndex = 15
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(394, 231)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 144)
        Me.ListBox4.TabIndex = 14
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(268, 231)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 144)
        Me.ListBox3.TabIndex = 13
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(142, 231)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 144)
        Me.ListBox2.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ck_refri)
        Me.GroupBox3.Controls.Add(Me.ck_laptop)
        Me.GroupBox3.Controls.Add(Me.ck_telefono)
        Me.GroupBox3.Controls.Add(Me.ck_tv)
        Me.GroupBox3.Location = New System.Drawing.Point(644, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(327, 141)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "APARATOS:"
        '
        'ck_refri
        '
        Me.ck_refri.AutoSize = True
        Me.ck_refri.Location = New System.Drawing.Point(162, 84)
        Me.ck_refri.Name = "ck_refri"
        Me.ck_refri.Size = New System.Drawing.Size(133, 24)
        Me.ck_refri.TabIndex = 3
        Me.ck_refri.Text = "Refrigeradora"
        Me.ck_refri.UseVisualStyleBackColor = True
        '
        'ck_laptop
        '
        Me.ck_laptop.AutoSize = True
        Me.ck_laptop.Location = New System.Drawing.Point(162, 39)
        Me.ck_laptop.Name = "ck_laptop"
        Me.ck_laptop.Size = New System.Drawing.Size(85, 24)
        Me.ck_laptop.TabIndex = 2
        Me.ck_laptop.Text = "Laptop"
        Me.ck_laptop.UseVisualStyleBackColor = True
        '
        'ck_telefono
        '
        Me.ck_telefono.AutoSize = True
        Me.ck_telefono.Location = New System.Drawing.Point(30, 84)
        Me.ck_telefono.Name = "ck_telefono"
        Me.ck_telefono.Size = New System.Drawing.Size(97, 24)
        Me.ck_telefono.TabIndex = 1
        Me.ck_telefono.Text = "Telefono"
        Me.ck_telefono.UseVisualStyleBackColor = True
        '
        'ck_tv
        '
        Me.ck_tv.AutoSize = True
        Me.ck_tv.Location = New System.Drawing.Point(30, 39)
        Me.ck_tv.Name = "ck_tv"
        Me.ck_tv.Size = New System.Drawing.Size(51, 24)
        Me.ck_tv.TabIndex = 0
        Me.ck_tv.Text = "Tv"
        Me.ck_tv.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_plazo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(271, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 141)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMPEÑO:"
        '
        'cb_plazo
        '
        Me.cb_plazo.FormattingEnabled = True
        Me.cb_plazo.Items.AddRange(New Object() {"Corto", "Largo"})
        Me.cb_plazo.Location = New System.Drawing.Point(169, 78)
        Me.cb_plazo.Name = "cb_plazo"
        Me.cb_plazo.Size = New System.Drawing.Size(121, 28)
        Me.cb_plazo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo plazo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Direccion:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(131, 169)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(100, 26)
        Me.txt_direccion.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CUI:"
        '
        'txt_cui
        '
        Me.txt_cui.Location = New System.Drawing.Point(131, 106)
        Me.txt_cui.Name = "txt_cui"
        Me.txt_cui.Size = New System.Drawing.Size(100, 26)
        Me.txt_cui.TabIndex = 5
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_calcular.Location = New System.Drawing.Point(836, 392)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(135, 49)
        Me.btn_calcular.TabIndex = 3
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'LIMPIARMATRIZToolStripMenuItem
        '
        Me.LIMPIARMATRIZToolStripMenuItem.Name = "LIMPIARMATRIZToolStripMenuItem"
        Me.LIMPIARMATRIZToolStripMenuItem.Size = New System.Drawing.Size(162, 29)
        Me.LIMPIARMATRIZToolStripMenuItem.Text = "LIMPIAR MATRIZ"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(189, 29)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'SISTEMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1232, 510)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SISTEMA"
        Me.Text = "SISTEMA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LIMPIARLISTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cui As TextBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ck_refri As CheckBox
    Friend WithEvents ck_laptop As CheckBox
    Friend WithEvents ck_telefono As CheckBox
    Friend WithEvents ck_tv As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_plazo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents LIMPIARMATRIZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
End Class
