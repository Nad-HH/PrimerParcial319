Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim mayor, medio, menor As Integer
        Dim xAscendente, xDescendente As String
        a = Convert.ToInt32(numero1.Text)
        b = Convert.ToInt32(numero2.Text)
        c = Convert.ToInt32(numero3.Text)

        If (a >= b) And (a >= c) Then
            mayor = a
            GoTo mayor_A
        Else
            GoTo mayor_B_C
        End If
mayor_A:
        If (b >= c) Then
            medio = b
            menor = c
        Else
            medio = c
            menor = b
        End If
        GoTo fin
mayor_B_C:
        If (b >= a) And (b >= c) Then
            mayor = b
            GoTo mayor_B
        Else
            mayor = c
            GoTo mayor_C
        End If
mayor_B:
        If (a >= c) Then
            medio = a
            menor = c
        Else
            medio = c
            menor = a
        End If
        GoTo fin
mayor_C:
        If (a >= b) Then
            medio = a
            menor = b
        Else
            medio = b
            menor = a
        End If
fin:
        xAscendente = menor.ToString + ", " + medio.ToString + ", " + mayor.ToString
        xDescendente = mayor.ToString + ", " + medio.ToString + ", " + menor.ToString

        Ascendente.Text = xAscendente
        Descendente.Text = xDescendente

    End Sub
End Class
