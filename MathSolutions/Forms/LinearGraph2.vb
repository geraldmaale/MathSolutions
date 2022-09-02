Public Class LinearGraph2
    Dim y As Single : Dim a As Single : Dim b As Single : Dim c As Single : Dim d As Single
    Dim x As Single
    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        'selecting Gradient of a line
        If cboSelect.Text = "Gradient of a Line (points)" Then
            txtX1.Clear() : txtX2.Clear() : txtY1.Clear() : txtY2.Clear()
            pnlAnsLength.Visible = False : txtX1.Focus()

            cmdReset.Visible = False
            pnlAnsLength.Visible = False
            pointA.Visible = True
            pointB.Visible = True
            txtX1.Focus()
            Label3.Visible = True
            lblFormula.Visible = True
            lblFormulaLabel.Visible = True
            lblFormula.Text = "m=(y2-y1)/(x2-x1)= Δy/Δx"
            'selecting Length of a Line
        ElseIf cboSelect.Text = "Length of a Line (points)" Then
            txtX1.Clear() : txtX2.Clear() : txtY1.Clear() : txtY2.Clear()
            pnlAnsLength.Visible = False : txtX1.Focus()

            cmdReset.Visible = False
            pointA.Visible = True
            pointB.Visible = True
            pnlAnsLength.Visible = False
            txtX1.Focus()
            lblFormula.Visible = True
            lblFormulaLabel.Visible = True
            Label3.Visible = True
            lblFormula.Text = "|AB|=√((x2-x1)²+(y2-y1)²)"

        End If
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        txtX1.Clear() : txtX2.Clear() : txtY1.Clear() : txtY2.Clear()
        pnlAnsLength.Visible = False : txtX1.Focus()

    End Sub

    Private Sub txtY1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtY1.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            b = Val(txtY1.Text)
            txtX2.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub

    Private Sub txtY2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtY2.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            d = Val(txtY2.Text)
            If cboSelect.Text = "Length of a Line (points)" Then
                LengthLine()
            ElseIf cboSelect.Text = "Gradient of a Line (points)" Then
                GradientLine()
            End If
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub
    Private Sub txtX1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtX1.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            a = Val(txtX1.Text)
            txtY1.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub

    Private Sub txtX2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtX2.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(45) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            c = Val(txtX2.Text)
            txtY2.Focus()
        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub

    Private Function LengthLine() As Single
        Dim AB As Single
        Dim XL As Single : Dim YL As Single
        XL = Math.Pow((c - a), 2)
        YL = Math.Pow((d - b), 2)
        AB = Math.Sqrt(XL + YL)
        pnlAnsLength.Visible = True
        cmdReset.Visible = True
        lblFormulaLabel.Text = "Length of Line:"
        lblAnsEquation.Text = Math.Round(AB, 2) & " Units"
    End Function

    Private Function GradientLine() As Single
        Dim AB As Single
        Dim XL As Single : Dim YL As Single
        XL = (c - a)
        YL = (d - b)
        AB = (YL / XL)
        pnlAnsLength.Visible = True
        cmdReset.Visible = True
        lblFormulaLabel.Text = "Gradient of Line:"
        lblAnsEquation.Text = CSng(AB)
    End Function

    Private Sub LinearGraph2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.gms6
        cboSelect.Items.Add("Length of a Line (points)")
        cboSelect.Items.Add("Gradient of a Line (points)")

    End Sub

End Class