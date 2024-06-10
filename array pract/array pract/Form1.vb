
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sum = {2, 3, 4, 45, 5, 4}
        Dim tot As Integer
        For i = 1 To Sum.Length - 1
            tot = tot + Sum(i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name = {"Jasmine", "Malik", "Sophia", "Xavier", "Olivia", "Ethan", "Ava", "Noah", "Isabella", "Liam", "Mia", "Lucas", "Amelia", "Logan", "Harper", "Aiden", "Emma", "Mason", "Evelyn", "Jayden"}
        For i = 0 To name.Length - 1
            ListBox1.Items.Add(name(i))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim name() As String = {"Jasmine", "Malik", "Sophia", "Xavier", "Olivia", "Ethan", "Ava", "Noah", "Isabella", "Liam", "Mia", "Lucas", "Amelia", "Logan", "Harper", "Aiden", "Emma", "Mason", "Evelyn", "Jayden"}
        For i = name.Length - 1 To 0 Step -1
            ListBox1.Items.Add(name(i))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim matrix = {{1, 2}, {3, 4}}
        Dim sum As Integer

        For i = 0 To matrix.GetLength(0) - 1
            For j = 0 To matrix.GetLength(1) - 1
                sum = sum + matrix(i, j)
            Next
        Next
        ListBox2.Items.Add(sum)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim name() As String = {"Jasmine", "Malik", "Sophia", "Xavier", "Olivia", "Ethan", "Ava", "Noah", "Isabella", "Liam", "Mia", "Lucas", "Amelia", "Logan", "Harper", "Aiden", "Emma", "Mason", "Evelyn", "Jayden"}
        Dim search As String
        search = txtName.Text
        For i As Integer = 0 To name.Length - 1
            If (search.ToUpper = name(i).ToUpper) Then
                MessageBox.Show(search + " the name has been found")
            End If
            If (search.ToUpper IsNot name(i).ToUpper) Then
                MessageBox.Show(search + " the name has been found")
            End If

        Next

    End Sub
End Class
