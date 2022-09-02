Public Class Factorials
    Public Function Factorial(ByRef n As Integer) As Integer
        'n = Val(txtFact.Text)

        If n <= 1 Then
            Factorial = 1
            lblFact.Text = n & "! = " & Factorial
            Exit Function
        Else
            Factorial = n * Factorial(n - 1)
            lblFact.Text = n & "! = " & Factorial
        End If

    End Function
    

    Private Sub txtFact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFact.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            Factorial(4)
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtFact.Clear()
        lblFact.Text = 0
        txtFact.Focus()

    End Sub

    Private Sub Factorials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6

    End Sub
End Class