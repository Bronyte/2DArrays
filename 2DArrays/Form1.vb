Public Class Form1

    'Declare 2D array
    Dim array(2, 3) As Integer '3 Rows, 4 Columns

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Insert values
        array(0, 0) = 1
        array(0, 1) = 2
        array(0, 2) = 3
        array(0, 3) = 4
        array(1, 0) = 5
        array(1, 1) = 6
        array(1, 2) = 7
        array(1, 3) = 8
        array(2, 0) = 9
        array(2, 1) = 10
        array(2, 2) = 11
        array(2, 3) = 12

        'Append data to ListBox
        For i As Integer = 0 To 2
            For j As Integer = 0 To 3
                ListBox1.Items.Add(array(i, j))
            Next
        Next
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        'Clear ListBox
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button_Array_Click(sender As Object, e As EventArgs) Handles Button_Array.Click
        'Repopulate ListBox
        For i As Integer = 0 To 2
            For j As Integer = 0 To 3
                ListBox1.Items.Add(array(i, j))
            Next
        Next
    End Sub
End Class
