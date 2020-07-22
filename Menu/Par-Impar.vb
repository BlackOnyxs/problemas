Public Class Par_Impar
    Dim f, c, matrz(0, 0) As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menu As New Form1()
        Me.Hide()
        menu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p, im As Integer
        f -= 1
        c -= 1
        ReDim matrz(f, c)

        For i = 0 To c
            For j = 0 To f
                matrz(j, i) = DataGridView1.Item(i, j).Value
            Next
        Next

        For i = 0 To c
            For j = 0 To f
                If matrz(j, i) Mod 2 <> 0 Then
                    im += 1
                Else
                    p += 1
                End If
            Next

        Next

        MsgBox("Valores pares: " & p & ". Valores impares: " & im)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        f = TextBox1.Text
        c = TextBox2.Text
        For i = 0 To c - 1
            DataGridView1.Columns.Add(i, "")
        Next
        DataGridView1.Rows.Add(f)


    End Sub
End Class