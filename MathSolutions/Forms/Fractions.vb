Public Class Fractions
    Dim d As Double

    Private Sub txtDecimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDecimal.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            Button1.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    
End Class