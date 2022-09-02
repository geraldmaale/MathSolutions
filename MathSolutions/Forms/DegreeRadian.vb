Public Class DegreeRadian
    Dim deg, rad As Double
    Dim ans, sin, cos, tan As Double

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeg.Click

        rad = Val(txtRad.Text)
        deg = ((deg * Math.PI) * 180) / Math.PI
        txtDeg.Text = deg

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRad.Click
        deg = Val(txtDeg.Text)
        rad = (deg * Math.PI) / 180
        txtRad.Text = rad
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrig.SelectedIndexChanged
        txtNum.Focus()
    End Sub

    Private Sub DegreeRadian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboTrig.Items.Add("Sine")
        cboTrig.Items.Add("Cosine")
        cboTrig.Items.Add("Tangent")

    End Sub

    Private Sub txtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum.KeyPress

        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            If cboTrig.Text = "Sine" Then
                SinNum()
            ElseIf cboTrig.Text = "Cosine" Then
                CosNum()
            ElseIf cboTrig.Text = "Tangent" Then
                TanNum()
            End If

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Public Function SinNum() As Double
        ans = Val(txtNum.Text)
        ans = ans * (Math.PI / 180)
        sin = Math.Sin(ans)
        txtAns.Text = sin
    End Function

    Public Function CosNum() As Double
        Dim num As Double
        num = Val(txtNum.Text)
        ans = num * (Math.PI / 180)
        cos = Math.Cos(ans)
        txtAns.Text = cos

    End Function

    Public Function TanNum() As Double
        ans = Val(txtNum.Text)
        ans = ans * (Math.PI / 180)
        tan = Math.Tan(ans)
        txtAns.Text = tan
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNum.Clear()
        txtAns.Clear()
        txtDeg.Clear()
        txtRad.Clear()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        If cboTrig.Text = "Sine" Then
            SinNum()
        ElseIf cboTrig.Text = "Cosine" Then
            CosNum()
        ElseIf cboTrig.Text = "Tangent" Then
            TanNum()
        End If

    End Sub

    Private Sub txtDeg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            deg = Val(txtDeg.Text)
            rad = (deg * Math.PI) / 180
            txtRad.Text = rad

        Else
            e.KeyChar = ChrW(0)
        End If

    End Sub

    Private Sub txtRad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRad.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Then
            Exit Sub

        ElseIf e.KeyChar = ChrW(13) Then
            rad = Val(txtRad.Text)
            deg = (rad * 180 / Math.PI)
            txtDeg.Text = deg
        Else
            e.KeyChar = ChrW(0)

        End If

    End Sub

    
End Class