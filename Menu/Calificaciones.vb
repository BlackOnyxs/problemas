Public Class Calificaciones
    Dim c, notes() As Integer

    Private Sub Calificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        c = InputBox("Ingrese la cantidad de notas")
        Me.Label2.Hide()
        Me.Label3.Hide()

        ReDim notes(c)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim menu As New Form1()
        Me.Hide()
        menu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim note, promedio, suma, counter As Integer



        note = TextBox1.Text

        If Me.ListView1.Items.Count < c Then
            Me.ListView1.Items.Add(note)

            TextBox1.Clear()
            If Me.ListView1.Items.Count + 1 > c Then
                TextBox1.Enabled = False
                Button1.Enabled = False

                For i As Integer = 0 To Me.ListView1.Items.Count - 1
                    suma += Me.ListView1.Items(i).Text
                Next

                promedio = suma / Me.ListView1.Items.Count - 1

                For i As Integer = 0 To Me.ListView1.Items.Count - 1
                    If Me.ListView1.Items(i).Text > promedio Then
                        counter += 1
                    End If
                Next
                Me.Label2.Show()
                Me.Label3.Show()

                Me.Label2.Text = "La Califiación promedio es: " & promedio
                Me.Label3.Text = "cantidad de estudiantes que tuvieron calificación arriba del promedio: " & counter
            Else
                TextBox1.Focus()
            End If

        End If





    End Sub
End Class