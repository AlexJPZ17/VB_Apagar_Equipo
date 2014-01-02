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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_Opciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Segundos = New System.Windows.Forms.TextBox()
        Me.Button_Apagar = New System.Windows.Forms.Button()
        Me.Button_Cancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_Minimizar = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label_Tiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Reiniciar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Opciones Predefinidas"
        '
        'ComboBox_Opciones
        '
        Me.ComboBox_Opciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Opciones.FormattingEnabled = True
        Me.ComboBox_Opciones.Items.AddRange(New Object() {"5 Minutos", "10 Minutos", "15 Minutos", "20 Minutos", "25 Minutos", "30 Minutos", "35 Minutos", "40 Minutos", "45 Minutos", "50 Minutos", "55 Minutos", "1 Hora", "2 Horas", "3 Horas", "4 Horas", "5 Horas"})
        Me.ComboBox_Opciones.Location = New System.Drawing.Point(182, 115)
        Me.ComboBox_Opciones.Name = "ComboBox_Opciones"
        Me.ComboBox_Opciones.Size = New System.Drawing.Size(126, 24)
        Me.ComboBox_Opciones.TabIndex = 1
        Me.ComboBox_Opciones.Text = "Minutos y Horas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tiempo en(Segundos)"
        '
        'TextBox_Segundos
        '
        Me.TextBox_Segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Segundos.Location = New System.Drawing.Point(182, 67)
        Me.TextBox_Segundos.Name = "TextBox_Segundos"
        Me.TextBox_Segundos.Size = New System.Drawing.Size(100, 23)
        Me.TextBox_Segundos.TabIndex = 0
        '
        'Button_Apagar
        '
        Me.Button_Apagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Apagar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button_Apagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Apagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Apagar.ForeColor = System.Drawing.Color.White
        Me.Button_Apagar.Location = New System.Drawing.Point(40, 364)
        Me.Button_Apagar.Name = "Button_Apagar"
        Me.Button_Apagar.Size = New System.Drawing.Size(75, 33)
        Me.Button_Apagar.TabIndex = 2
        Me.Button_Apagar.Text = "Apagar"
        Me.Button_Apagar.UseVisualStyleBackColor = True
        '
        'Button_Cancelar
        '
        Me.Button_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Button_Cancelar.Location = New System.Drawing.Point(224, 364)
        Me.Button_Cancelar.Name = "Button_Cancelar"
        Me.Button_Cancelar.Size = New System.Drawing.Size(75, 33)
        Me.Button_Cancelar.TabIndex = 3
        Me.Button_Cancelar.Text = "Cancelar"
        Me.Button_Cancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(82, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Button_Minimizar
        '
        Me.Button_Minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimizar.ForeColor = System.Drawing.Color.White
        Me.Button_Minimizar.Location = New System.Drawing.Point(245, 0)
        Me.Button_Minimizar.Name = "Button_Minimizar"
        Me.Button_Minimizar.Size = New System.Drawing.Size(40, 23)
        Me.Button_Minimizar.TabIndex = 4
        Me.Button_Minimizar.Text = "-"
        Me.Button_Minimizar.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.White
        Me.Button_Close.Location = New System.Drawing.Point(287, 0)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(40, 24)
        Me.Button_Close.TabIndex = 5
        Me.Button_Close.Text = "X"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Label_Tiempo
        '
        Me.Label_Tiempo.AutoSize = True
        Me.Label_Tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.77391!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Tiempo.ForeColor = System.Drawing.Color.White
        Me.Label_Tiempo.Location = New System.Drawing.Point(186, 18)
        Me.Label_Tiempo.Name = "Label_Tiempo"
        Me.Label_Tiempo.Size = New System.Drawing.Size(24, 25)
        Me.Label_Tiempo.TabIndex = 14
        Me.Label_Tiempo.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tiempo Restantes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_Segundos)
        Me.GroupBox1.Controls.Add(Me.Label_Tiempo)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Opciones)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 197)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(321, 152)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button_Reiniciar
        '
        Me.Button_Reiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Reiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button_Reiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Reiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reiniciar.ForeColor = System.Drawing.Color.White
        Me.Button_Reiniciar.Location = New System.Drawing.Point(133, 365)
        Me.Button_Reiniciar.Name = "Button_Reiniciar"
        Me.Button_Reiniciar.Size = New System.Drawing.Size(75, 33)
        Me.Button_Reiniciar.TabIndex = 19
        Me.Button_Reiniciar.Text = "Reiniciar "
        Me.Button_Reiniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 410)
        Me.Controls.Add(Me.Button_Reiniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_Minimizar)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Apagar)
        Me.Controls.Add(Me.Button_Cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Opciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Segundos As System.Windows.Forms.TextBox
    Friend WithEvents Button_Apagar As System.Windows.Forms.Button
    Friend WithEvents Button_Cancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Minimizar As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Label_Tiempo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button_Reiniciar As System.Windows.Forms.Button

End Class
