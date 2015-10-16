Public Class Form3

    Dim Nilai1() As Integer
    Dim Nilai2() As Integer
    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim angka1, angka2 As Integer
        Dim hasil As String
        Dim i As Integer

        For i = 1 To 10

        Next

        angka1 = Convert.ToInt64(TextBox1.Text)
        angka2 = Convert.ToInt64(TextBox2.Text)
        If ComboBox1.Text = "Tambah" Then
            hasil = angka1 + angka2
        Else
            hasil = angka1 - angka2
        End If
        TextBoxhasil.Text = hasil
    End Sub
End Class