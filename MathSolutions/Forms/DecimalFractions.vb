Public Class DecimalFractions
    Dim d As Double

    Private Sub txtDecimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDecimal.KeyPress

        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then

            Dim ans As String = GetFraction()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Public Function GetFraction() As String
        Dim d As Double

        d = Val(txtDecimal.Text)

        ' Get the initial denominator: 1 * (10 ^ decimal portion length)

        Dim Denom As Int32 = CInt(1 * (10 ^ d.ToString.Split("."c)(1).Length))

        ' Get the initial numerator: integer portion of the number
        Dim Numer As Int32 = CInt(d.ToString.Split("."c)(1))

        ' Use the Euclidean algorithm to find the gcd
        Dim a As Int32 = Numer
        Dim b As Int32 = Denom
        Dim t As Int32 = 0 ' t is a value holder

        ' Euclidean algorithm
        While b <> 0
            t = b
            b = a Mod b
            a = t
        End While

        'Get whole part of the number
        Dim Whole As String = d.ToString.Split("."c)(0)

        ' Return our answer
        Dim ans As String = Whole & " " & (Numer / a) & "/" & (Denom / a)

        txtFraction.Text = CStr(ans)

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtDecimal.Clear()
        txtFraction.Clear()
        txtDecimal.Focus()

    End Sub



    Private Sub Fractions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6

    End Sub
End Class