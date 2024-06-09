Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        ' Declarar variables para almacenar los números ingresados
        Dim numero1 As Integer
        Dim numero2 As Integer

        ' Intentar convertir los textos ingresados en números enteros
        If Integer.TryParse(txtIngresarDat.Text, numero1) AndAlso Integer.TryParse(txtIngresarDat2.Text, numero2) Then
            ' Verificar que los números sean diferentes
            If numero1 <> numero2 Then
                ' Determinar cuál número es mayor
                If numero1 > numero2 Then
                    lblDec.Text = "El número mayor es: " & numero1
                Else
                    lblDec.Text = "El número mayor es: " & numero2
                End If
            Else
                lblDec.Text = "Por favor, ingrese dos números diferentes."
            End If
        Else

        End If
    End Sub
End Class
