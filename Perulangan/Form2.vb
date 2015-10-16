Public Class Form2

    Dim lapisanBawah, lapisanAtas, kolom, inputKolom, inputbaris As Integer
    Dim jmlbaris As Integer = 1
    Dim hasil As String

  
    Private Sub okbintang_Click(sender As Object, e As EventArgs) Handles okbintang.Click
        hasil = ""
        inputbaris = Convert.ToInt64(TextBox1.Text)
        inputKolom = (inputbaris * 2) - 1

        If ComboBox1.Text = "Piramyd" Then
            lapisanAtas = inputbaris + 1
            lapisanBawah = inputbaris - 1

            For jmlhbaris As Integer = 1 To inputbaris
                kolom = 1
                For kolom As Integer = 1 To inputKolom
                    If kolom > lapisanBawah And kolom < lapisanAtas Then
                        hasil &= "*"
                    Else
                        hasil &= " "
                    End If
                Next
                lapisanBawah -= 1
                lapisanAtas += 1

                hasil &= vbCrLf

            Next

        ElseIf ComboBox1.Text = "Hollow Piramyd" Then
            lapisanAtas = inputbaris
            lapisanBawah = inputbaris

            For baris As Integer = 1 To inputbaris
                kolom = 1
                If baris = inputbaris Then

                    For kolom As Integer = 1 To inputKolom
                        hasil &= "*"
                    Next
                Else
                    For kolom As Integer = 1 To inputKolom
                        If kolom = lapisanBawah Or kolom = lapisanAtas Then
                            hasil &= "*"
                        Else
                            hasil &= " "
                        End If

                    Next
                End If
                lapisanBawah -= 1
                lapisanAtas += 1

                hasil &= vbCrLf

            Next


        ElseIf ComboBox1.Text = "Inverted Piramyd" Then
            lapisanAtas = inputKolom
            lapisanBawah = 1

            For jmlbaris As Integer = 1 To inputbaris
                kolom = 1
                For kolom As Integer = 1 To inputKolom
                    If kolom >= lapisanBawah And kolom <= lapisanAtas Then
                        hasil &= "*"
                    Else
                        hasil &= " "
                    End If
                Next
                lapisanBawah += 1
                lapisanAtas -= 1

                hasil &= vbCrLf

            Next

        ElseIf ComboBox1.Text = "Hollow Inverted Piramyd" Then
            lapisanAtas = inputKolom
            lapisanBawah = 1

            For jmlbaris As Integer = 1 To inputbaris
                kolom = 1
                If jmlbaris = 1 Then
                    For kolom As Integer = 1 To inputKolom
                        hasil &= "*"
                    Next
                Else
                    For kolom As Integer = 1 To inputKolom
                        If kolom = lapisanBawah Or kolom = lapisanAtas Then
                            hasil &= "*"
                        Else
                            hasil &= " "
                        End If

                    Next
                End If
                lapisanBawah += 1
                lapisanAtas -= 1

                hasil &= vbCrLf
            Next

        Else
            MessageBox.Show(" Pilih Pola ! ")

        End If

        Me.hasilbintang.Text = hasil

    End Sub
End Class