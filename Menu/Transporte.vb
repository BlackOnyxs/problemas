Public Class Transporte
    Private Sub Transporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 5
            Me.DataGridView1.Rows.Add()
        Next
        Label3.Hide()
        Label2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sal(4), matriz(5, 2), total, m, index As Integer
        Dim names(4) As String
        For j = 0 To 4
            For i = 1 To 2
                matriz(j, i) = DataGridView1.Item(i, j).Value
            Next
            names(j) = DataGridView1.Item(0, j).Value
        Next
        m = matriz(0, 0)
        For i = 0 To 4
            For j = 1 To 1
                sal(i) = matriz(i, j) * matriz(i, j + 1)
                If m < matriz(i, j) Then
                    m = matriz(i, j)
                    index = i
                End If
            Next
        Next

        For j = 1 To 4
            total += sal(j)
        Next


        For i = 0 To 4

            DataGridView1.Item(3, i).Value = sal(i)

        Next

        Label3.Show()
        Label2.Show()
        Label2.Text = "Total a pagar por la empresa $ " & total
        Label3.Text = "El empleado con más horas tebajadas es: " & names(index)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menu As New Form1()
        Me.Hide()
        menu.Show()
    End Sub
End Class