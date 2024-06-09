Public Class Form1
    Dim dato1 As Integer
    Dim factorial As Integer = 1

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        If Integer.TryParse(txtIngresarDat.Text, dato1) Then
            For cuenta As Integer = 1 To dato1
                factorial *= cuenta

            Next
            lblMostrar.Text = "el factorial de" & dato1.ToString() & " es " & factorial.ToString()
        End If
    End Sub
End Class
