Public Class Form1

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim num, num2 As Integer
        Dim primo As Boolean = True
        If Integer.TryParse(txtIngresar.Text, num) Then
            Dim mitad As Integer = num / 2
            For num2 = 2 To mitad
                If num Mod num2 = 0 Then
                    primo = False
                    Exit For
                End If
            Next
            If primo And num > 1 Then
                lblMostrar.Text = num & "es primo"
            Else
                lblMostrar.Text = num & "no es primo"
            End If
        End If
    End Sub
End Class
