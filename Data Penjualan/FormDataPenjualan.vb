Public Class FormDataPenjualan

    Private Sub tombolHitung_Click(sender As Object, e As EventArgs) Handles tombolHitung.Click
        'menciptakan array untuk memuat nilai-nilai penjualan
        Const intSUBRKRIPT_MAKS As Integer = 4
        Dim decPenjualan(intSUBRKRIPT_MAKS) As Decimal

        'variabel-variabel lokal lain
        Dim decPenjualanTotal As Decimal        'menampung penjualan total
        Dim decPenjualanRerata As Decimal       'menampung penjualan rerata
        Dim decPenjualanTertinggi As Decimal    'menampung penjualan tertinggi
        Dim decPenjualanTerendah As Decimal     'menampung penjualan terendah

        'membaca nilai-nilai penjualan dari user
        BacaDataPenjualan(decPenjualan)

        'menghitung penjualan total, penjualan rerata, penjualan tertinggi
        'dan penjualan terendah
        decPenjualanTotal = TotalArray(decPenjualan)
        decPenjualanRerata = RerataArray(decPenjualan)
        decPenjualanTertinggi = Tertinggi(decPenjualan)
        decPenjualanTerendah = Terendah(decPenjualan)

        'menampilkan hasil
        labelTotal.Text = "Rp. " & decPenjualanTotal.ToString()
        labelRerata.Text = "Rp. " & decPenjualanRerata.ToString()
        labelTertinggi.Text = "Rp. " & decPenjualanTertinggi.ToString()
        labelTerendah.Text = "Rp. " & decPenjualanTerendah.ToString()
    End Sub

    'prosedur BacaDataPenjualan menerima sebuah argumen array Decimal
    'Ia mengisi array dengan nilai-nilai penjualan yang dimasukkan oleh user.

    Sub BacaDataPenjualan(ByRef decPenjualan() As Decimal)
        Dim intHitung As Integer = 0 'kounter loop, ditetapkan 0

        'mengisi array decPenjualan dengan nilai-nilai dimasukkan user.
        Do While intHitung < decPenjualan.Length
            Try
                'membaca nilai penjualan sehari
                decPenjualan(intHitung) =
                 CDec(InputBox("Masukkan nilai penjualan untuk hari " &
                (intHitung + 1).ToString()))
                'menginkremen intHitung
                intHitung += 1
            Catch
                'menampilkan pesan error untuk masukan tak valid
                MessageBox.Show("Enter a valid numeric value.")
            End Try
        Loop
    End Sub

    'fungsi TotalArray menerima sebuah array Decimal sebagai argumennya
    'dan menghasilkan nilai total dari elemen-elemen array

    Function TotalArray(ByVal decNilai() As Decimal) As Decimal
        Dim decTotal As Decimal = 0     'akumulator
        Dim intHitung As Integer        'pencacah loop

        'menghitung total dari elemen-elemen array
        For intHitung = 0 To (decNilai.Length - 1)
            decTotal += decNilai(intHitung)
        Next

        'menghasilkan total
        Return decTotal
    End Function

    'fungsi RerataArray menerima sebuah array Decimal sebagai argumennya
    'dan menghasilkan rerata dari elemen-elemennya

    Function RerataArray(ByVal decNilai() As Decimal) As Decimal
        Return TotalArray(decNilai) / decNilai.Length
    End Function

    'fungsi Tertinggi menerima sebuah array Decimal sebagai argumennya
    'dan menghasilkan nilai tertinggi yang dimuatnya

    Function Tertinggi(ByVal decNilai() As Decimal) As Decimal
        Dim intHitung As Integer        'pencacah loop
        Dim decTertinggi As Decimal     'memuat nilai tertinggi

        'membaca nilai pertama di dalam array
        decTertinggi = decNilai(0)

        'mencari nilai tertinggi
        For intHitung = 1 To (decNilai.Length - 1)
            If decNilai(intHitung) > decTertinggi Then
                decTertinggi = decNilai(intHitung)
            End If
        Next

        'menghasilkan nilai tertinggi
        Return decTertinggi
    End Function

    'fungsi Terendah menerima sebuah array Decimal sebagai argumennya
    'dan menghasilkan nilai terendah yang dimuatnya

    Function Terendah(ByVal decNilai() As Decimal) As Decimal
        Dim intHitung As Integer        'pencacah loop
        Dim decTerendah As Decimal      'memuat nilai terendah

        'membaca nilai pertama di dalam array
        decTerendah = decNilai(0)

        'mencari nilai terendah
        For intHitung = 1 To (decNilai.Length - 1)
            If decNilai(intHitung) < decTerendah Then
                decTerendah = decNilai(intHitung)
            End If
        Next

        'menghasilkan nilai terendah
        Return decTerendah
    End Function

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup Form
        Me.Close()
    End Sub
End Class
