Public Class Form1

    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub form1_mousedown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        TextBox_Segundos.Focus()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mover = True
            x = e.X
            y = e.Y
            Me.Cursor = Cursors.NoMove2D

        End If
    End Sub
    Private Sub form1_mousemove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mover Then
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))

        End If
    End Sub
    Private Sub form1_mouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mover = False
        Me.Cursor = Cursors.Default

    End Sub
    'Button Close
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        'Funcion Cerrar
        Me.Close()
    End Sub
    'Button Minimizar
    Private Sub Button_Minimizar_Click(sender As Object, e As EventArgs) Handles Button_Minimizar.Click
        'Funcion Minimizar
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Button_Apagar
    Private Sub Button_Apagar_Click(sender As Object, e As EventArgs) Handles Button_Apagar.Click
        TextBox_Segundos.Focus()
        If TextBox_Segundos.Text = "" Then

            Dim Mensaje As String
            Dim Titulo As String
            Dim Estilo As New MsgBoxStyle
            Dim Resultado As New MsgBoxResult
            Mensaje = "Ingrese por fabor los Segundos"
            Titulo = "Segundos"
            Estilo = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly
            Resultado = MsgBox(Mensaje, Estilo, Titulo)


        Else

            Dim Tiempo As Integer
            Tiempo = Convert.ToInt32(TextBox_Segundos.Text)

            Shell("shutdown -s -t " & Tiempo)


            Timer1.Start()
            Label_Tiempo.Text = TextBox_Segundos.Text
            ' 
        End If
    End Sub
    'Button_Cancelar
    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        Shell("shutdown -a")
        Timer1.Stop()
        Label_Tiempo.Text = "0"
        TextBox_Segundos.Clear()
    End Sub
    'ComboBox_Opciones
    Private Sub ComboBox_Opciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Opciones.SelectedIndexChanged
        '5 min
        If ComboBox_Opciones.Text = "5 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "300"
        End If
        '10 min
        If ComboBox_Opciones.Text = "10 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "600"
        End If
        '15 min
        If ComboBox_Opciones.Text = "15 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "900"
        End If
        '20 min
        If ComboBox_Opciones.Text = "20 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "1200"
        End If
        '25 min
        If ComboBox_Opciones.Text = "25 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "1500"
        End If
        '30 min
        If ComboBox_Opciones.Text = "30 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "1800"
        End If
        '35 min
        If ComboBox_Opciones.Text = "35 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "2100"
        End If
        '40 min
        If ComboBox_Opciones.Text = "40 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "2400"
        End If
        '45 min
        If ComboBox_Opciones.Text = "45 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "2700"
        End If
        '50 min
        If ComboBox_Opciones.Text = "50 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "3000"
        End If
        '55 min
        If ComboBox_Opciones.Text = "55 Minutos".ToString Then
            TextBox_Segundos.SelectedText = "3300"
        End If
        '1 Hora
        If ComboBox_Opciones.Text = "1 Hora".ToString Then
            TextBox_Segundos.SelectedText = "3600"
        End If
        '2 Horas
        If ComboBox_Opciones.Text = "2 Horas".ToString Then
            TextBox_Segundos.SelectedText = "7200"
        End If
        '3 Horas
        If ComboBox_Opciones.Text = "3 Horas".ToString Then
            TextBox_Segundos.SelectedText = "10800"
        End If
        '4 Horas
        If ComboBox_Opciones.Text = "4 Horas".ToString Then
            TextBox_Segundos.SelectedText = "14400"
        End If
        '5 Horas
        If ComboBox_Opciones.Text = "5 Horas".ToString Then
            TextBox_Segundos.SelectedText = "18000"
        End If
    End Sub
    'Timer1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Label_Tiempo.Text = (Convert.ToInt32(Label_Tiempo.Text) - 1).ToString
        Catch
        End Try
    End Sub

    Private Sub Button_Reiniciar_Click(sender As Object, e As EventArgs) Handles Button_Reiniciar.Click
        TextBox_Segundos.Focus()
        If TextBox_Segundos.Text = "" Then

            Dim Mensaje As String
            Dim Titulo As String
            Dim Estilo As New MsgBoxStyle
            Dim Resultado As New MsgBoxResult
            Mensaje = "Ingrese por fabor los Segundos"
            Titulo = "Segundos"
            Estilo = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly
            Resultado = MsgBox(Mensaje, Estilo, Titulo)


        Else

            Dim Tiempo As Integer
            Tiempo = Convert.ToInt32(TextBox_Segundos.Text)

            Shell("shutdown -r -t " & Tiempo)


            Timer1.Start()
            Label_Tiempo.Text = TextBox_Segundos.Text
            ' 
        End If
    End Sub
    'Funcion mover le Formulario
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        TextBox_Segundos.Focus()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mover = True
            x = e.X
            y = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        If mover Then
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))

        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
End Class
