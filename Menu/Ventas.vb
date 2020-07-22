Public Class Ventas

    Dim c, v, index As Integer
    Dim names() As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = TextBox1.Text
        ReDim names(c)
        TextBox1.Enabled = False
        Button1.Enabled = False
        TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        v = TextBox2.Text
        TextBox2.Enabled = False
        Button2.Enabled = False
        TextBox3.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim matriz(v, c), mayor, menor, pma, pme As Integer

        For i = 0 To c - 1
            For j = 0 To v - 1
                matriz(j, i) = DataGridView1.Item(i, j).Value
                Console.WriteLine(matriz(j, i))
            Next

        Next


        mayor = matriz(0, 0)
        menor = matriz(0, 0)
        For i = 0 To c
            For j = 1 To v
                If mayor < matriz(j, i) Then
                    mayor = matriz(j, i)
                    pma = i
                End If
                If menor > matriz(j, i) Then
                    menor = matriz(j, i)
                    pme = i
                End If
            Next
        Next

        Label7.Text = "Vendedor Con mayor Venta" & vbCrLf & names(pma) & " Posición: " & pma
        Label9.Text = "Vendedor Con menor Venta" & vbCrLf & names(pme) & " Posición: " & pme
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim menu As New Form1()
        Me.Hide()
        menu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim name As String

        name = TextBox3.Text
        names(index) = name
        DataGridView1.Columns.Add(index, name)
        If index < 1 Then
            For i = 1 To v
                DataGridView1.Rows.Add()
            Next
        End If
        TextBox3.Enabled = False
        Button3.Enabled = False
        Label5.Show()
        Label5.Text = name
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If index + 1 < c Then
            Button3.Enabled = True
            TextBox3.Enabled = True
            TextBox3.Clear()
            TextBox3.Focus()
            index += 1
        Else
            Button4.Enabled = False
        End If

    End Sub

End Class