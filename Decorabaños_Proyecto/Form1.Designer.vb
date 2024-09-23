<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUbicacion = New FontAwesome.Sharp.IconButton()
        Me.btnGestionar = New FontAwesome.Sharp.IconButton()
        Me.btnStock = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCurrentform = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnUbicacion)
        Me.Panel1.Controls.Add(Me.btnGestionar)
        Me.Panel1.Controls.Add(Me.btnStock)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 571)
        Me.Panel1.TabIndex = 0
        '
        'btnUbicacion
        '
        Me.btnUbicacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUbicacion.FlatAppearance.BorderSize = 0
        Me.btnUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbicacion.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUbicacion.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btnUbicacion.IconColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnUbicacion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUbicacion.IconSize = 50
        Me.btnUbicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUbicacion.Location = New System.Drawing.Point(0, 296)
        Me.btnUbicacion.Name = "btnUbicacion"
        Me.btnUbicacion.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUbicacion.Size = New System.Drawing.Size(221, 60)
        Me.btnUbicacion.TabIndex = 4
        Me.btnUbicacion.Text = "UBICACION DE PRODUCTOS"
        Me.btnUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUbicacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUbicacion.UseVisualStyleBackColor = True
        '
        'btnGestionar
        '
        Me.btnGestionar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGestionar.FlatAppearance.BorderSize = 0
        Me.btnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGestionar.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.btnGestionar.IconColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnGestionar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGestionar.IconSize = 50
        Me.btnGestionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionar.Location = New System.Drawing.Point(0, 236)
        Me.btnGestionar.Name = "btnGestionar"
        Me.btnGestionar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnGestionar.Size = New System.Drawing.Size(221, 60)
        Me.btnGestionar.TabIndex = 3
        Me.btnGestionar.Text = "GESTIONAR PRODUCTOS"
        Me.btnGestionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGestionar.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStock.IconChar = FontAwesome.Sharp.IconChar.LayerGroup
        Me.btnStock.IconColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnStock.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStock.IconSize = 50
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.Location = New System.Drawing.Point(0, 176)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStock.Size = New System.Drawing.Size(221, 60)
        Me.btnStock.TabIndex = 1
        Me.btnStock.Text = "STOCK"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 176)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblCurrentform)
        Me.Panel3.Controls.Add(Me.IconCurrentForm)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(221, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(833, 110)
        Me.Panel3.TabIndex = 1
        '
        'lblCurrentform
        '
        Me.lblCurrentform.AutoSize = True
        Me.lblCurrentform.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCurrentform.Location = New System.Drawing.Point(86, 50)
        Me.lblCurrentform.Name = "lblCurrentform"
        Me.lblCurrentform.Size = New System.Drawing.Size(39, 13)
        Me.lblCurrentform.TabIndex = 1
        Me.lblCurrentform.Text = "INICIO"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 60
        Me.IconCurrentForm.Location = New System.Drawing.Point(20, 25)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(60, 60)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 571)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnStock As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUbicacion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGestionar As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCurrentform As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
End Class
