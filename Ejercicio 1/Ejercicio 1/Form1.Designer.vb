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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.numero3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ascendente = New System.Windows.Forms.TextBox()
        Me.Descendente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1er número:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2do número:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3er número:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "INGRESAR NÚMEROS"
        '
        'numero1
        '
        Me.numero1.Location = New System.Drawing.Point(190, 74)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(107, 22)
        Me.numero1.TabIndex = 4
        '
        'numero2
        '
        Me.numero2.Location = New System.Drawing.Point(190, 120)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(107, 22)
        Me.numero2.TabIndex = 5
        '
        'numero3
        '
        Me.numero3.Location = New System.Drawing.Point(190, 169)
        Me.numero3.Name = "numero3"
        Me.numero3.Size = New System.Drawing.Size(107, 22)
        Me.numero3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ascendente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Descendente:"
        '
        'Ascendente
        '
        Me.Ascendente.Location = New System.Drawing.Point(199, 294)
        Me.Ascendente.Name = "Ascendente"
        Me.Ascendente.Size = New System.Drawing.Size(135, 22)
        Me.Ascendente.TabIndex = 9
        '
        'Descendente
        '
        Me.Descendente.Location = New System.Drawing.Point(199, 338)
        Me.Descendente.Name = "Descendente"
        Me.Descendente.Size = New System.Drawing.Size(135, 22)
        Me.Descendente.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ORDENAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 406)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Descendente)
        Me.Controls.Add(Me.Ascendente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numero3)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.numero1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numero1 As System.Windows.Forms.TextBox
    Friend WithEvents numero2 As System.Windows.Forms.TextBox
    Friend WithEvents numero3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ascendente As System.Windows.Forms.TextBox
    Friend WithEvents Descendente As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
