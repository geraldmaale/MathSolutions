Public Class StandardDeviation
    Dim NumValues, value As Integer
    Dim SumX As Single
    Dim SumX2 As Single

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Dim Value As Single
        txtInput.Focus()
        NumValues = NumValues + 1
        txtNumber.Text = Str(NumValues)
        'Get number and sum number and number-squared
        Value = Val(txtInput.Text)
        SumX = SumX + Value
        SumX2 = SumX2 + Value ^ 2
        txtInput.Text = ""
        lblNumbers.Text &= Value & ", "

        Dim Mean As Single
        Dim StdDev As Single
        txtInput.Focus()

        'Make sure there are at least two values
        If NumValues < 2 Then
            Beep()
            Exit Sub
        End If

        'Compute mean
        Mean = SumX / NumValues
        txtMean.Text = Str(Mean)
        txtSum.Text = SumX

        'Compute standard deviation
        StdDev = Math.Sqrt((NumValues * SumX2 - SumX ^ 2) / (NumValues * (NumValues - 1)))
        txtStdDev.Text = Str(StdDev)

        'compute variance
        Dim varStats As Single = (NumValues * SumX2 - SumX ^ 2) / (NumValues * (NumValues - 1))
        txtVar.Text = varStats

    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim Mean As Single
        Dim StdDev As Single
        txtInput.Focus()
        'Make sure there are at least two values
        If NumValues < 2 Then
            Beep()
            Exit Sub
        End If
        'Compute mean
        Mean = SumX / NumValues
        txtMean.Text = Str(Mean)

        Label3.Visible = True : txtMean.Visible = True
        Label4.Visible = True : txtStdDev.Visible = True
        Me.Size = New Point(397, 364)

        'Compute standard deviation
        StdDev = Math.Sqrt((NumValues * SumX2 - SumX ^ 2) / (NumValues * (NumValues - 1)))
        txtStdDev.Text = Str(StdDev)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'Initialize all variables
        txtInput.Focus()
        NumValues = 0
        txtNumber.Text = ""
        txtInput.Text = ""
        txtMean.Text = ""
        txtStdDev.Text = ""
        lblNumbers.Text = ""
        txtSum.Text = ""
        txtVar.Text = ""
        SumX = 0
        SumX2 = 0
    End Sub

    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        'Only allow numbers, minus sign, decimal point, backspace, return keys
        If (e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(6D)) Then
            Exit Sub
        ElseIf e.KeyChar = ChrW(13) Then
            btnAccept.PerformClick()
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub StandardDeviation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.gms6

    End Sub
End Class