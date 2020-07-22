Public Class Diagonal
    Dim f, arrF(0, 0), arrS(0, 0) As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menu As New Form1()
        Me.Hide()
        menu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f = TextBox1.Text
        f -= 1
        ReDim arrF(f, f), arrS(f, f)
        For i = 0 To f
            DataGridView1.Columns.Add(i, "")
            DataGridView1.Rows.Add()
            DataGridView2.Columns.Add(i, "")
            DataGridView2.Rows.Add()
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim diagF(f), diagS(f) As Integer
        Dim equals As Boolean
        equals = True

        For i = 0 To f
            For j = 0 To f
                arrF(i, j) = DataGridView1.Item(i, j).Value
            Next
        Next

        For i = 0 To f
            For j = 0 To f
                arrS(i, j) = DataGridView2.Item(i, j).Value
            Next
        Next

        For i = 0 To f
            For j = 0 To f
                If i + j = f - 1 + 1 Then
                    diagF(i) = arrF(i, j)
                End If
            Next
        Next

        For i = 0 To f
            For j = 0 To f
                If i + j = f - 1 + 1 Then
                    diagS(i) = arrS(i, j)
                End If
            Next
        Next

        For i = 0 To f
            Console.WriteLine(diagF(i) & "==" & diagS(i))
            If diagF(i) <> diagS(i) Then
                equals = False
            End If
        Next

        If equals Then
            MsgBox("Las diagonales secundarias son iguales")
        Else
            MsgBox("Las diagonales secundarias son diferentes")
        End If
    End Sub
End Class