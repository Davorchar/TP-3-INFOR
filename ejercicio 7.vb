Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim rnd As New Random
        Dim num, posMayor As Integer
        Dim suma As Integer = 0
        Dim mayor As Integer = 0
        For cuenta = 1 To 20 Step 1
            num = rnd.Next(1, 51)
            If num Mod 2 = 0 Then
                suma = suma + 1
            End If
            If num > mayor Then
                mayor = num
                posMayor = cuenta
            End If
            ListBox1.Items.Add(num)
        Next
        lblMostrar.Text = suma & " son pares"
        lblMostrar2.Text = "el mayor es " & mayor
        lblMostrar3.Text = "en la posicion " & posMayor
    End Sub
End Class
