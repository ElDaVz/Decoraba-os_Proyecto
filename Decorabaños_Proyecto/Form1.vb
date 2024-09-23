Imports FontAwesome.Sharp
Public Class Form1
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    'Constructor
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        Panel3.Controls.Add(leftBorderBtn)
    End Sub

    'methods
    Private Sub activatebutton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            'button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(61, 62, 63)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'left border
            With leftBorderBtn
                .BackColor = customcolor
                .Location = New Point(0, currentBtn.Location.Y)
                .Visible = True
                .BringToFront()
            End With
            'current form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customcolor
        End If
    End Sub

    Private Sub disablebutton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(61, 62, 63)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    'events
    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        activatebutton(sender, Color.FromArgb(247, 211, 59))
    End Sub

    Private Sub btnGestionar_Click(sender As Object, e As EventArgs) Handles btnGestionar.Click
        activatebutton(sender, Color.FromArgb(247, 211, 59))
    End Sub

    Private Sub btnUbicacion_Click(sender As Object, e As EventArgs) Handles btnUbicacion.Click
        activatebutton(sender, Color.FromArgb(247, 211, 59))
    End Sub
End Class
