Public Class Approximations
    Dim a, c As Double
    Dim b As Integer

    Private Sub Approximations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboSelect.Items.Add("Decimal Places")
        ' cboSelect.Items.Add("Significant Figures")
        Me.Text = "Decimal Places"
        Dim j As Integer
        For j = 1 To 10
            cboApprox.Items.Add(j)
        Next

    End Sub

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        If cboSelect.Text = "Decimal Places" Then
            pnlApprox.Visible = True
            pnlNumber.Visible = False
            lblNote.Text = "Select Approximation"
            lblApprox.Text = "Decimal Places"
            btnApprox.Visible = False
            btnClear.Visible = False

        ElseIf cboSelect.Text = "Significant Figures" Then
            pnlApprox.Visible = True
            pnlNumber.Visible = False
            lblNote.Text = "Select Approximation"
            lblApprox.Text = "Significant Figures"
            btnApprox.Visible = False
            btnClear.Visible = False

        End If
    End Sub

    Private Sub cboApprox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboApprox.SelectedIndexChanged
        If cboApprox.Text = 1 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 1 & " decimal place")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 2 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 2 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 3 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 3 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 4 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 4 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 5 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 5 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 6 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 6 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 7 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 7 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 8 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 8 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 9 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 9 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        ElseIf cboApprox.Text = 10 Then
            cboSelect.Text = "Decimal Places"
            txtAns.Clear()
            lblNote.Visible = True
            lblNote.Text = ("Correct to " & 10 & " decimal places")
            pnlNumber.Visible = True
            txtNum.Focus()
            btnApprox.Visible = True
            btnClear.Visible = True
            'DecimalPlaces()

        End If
    End Sub

    Private Sub txtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            a = Val(txtNum.Text)
            DecimalPlaces()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Public Function DecimalPlaces() As Double
        a = Val(txtNum.Text)
        b = cboApprox.Text

        c = Math.Round(a, b)
        txtAns.Text = (c)

    End Function

    Private Sub btnApprox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprox.Click
        DecimalPlaces()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNum.Clear()
        txtAns.Clear()
        txtNum.Focus()
    End Sub

End Class