Public Class Form1
    Dim a(20) As Integer
    Dim random As New Random
    Dim i As Integer
    Dim cadena As String
    Dim encontrado As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        For i = 0 To 19
            a(i) = random.Next(9, 39)
            cadena = cadena & " " & a(i)
        Next

        cadena = cadena & vbNewLine & vbNewLine & "Mayores de 30 son = "

        For i = 0 To 19

            If a(i) > 30 Then
                encontrado = True
                cadena = cadena & " " & a(i)
            End If




        Next

        If Not encontrado Then
            TextBox1.Text = "NO HAY NUEROS MAYORES A 30"

        Else
            TextBox1.Text = cadena
        End If


    End Sub


End Class
