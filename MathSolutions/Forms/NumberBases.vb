Public Class NumberBases

    Private Sub Number_Bases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboBase.Items.Add("10")
        cboBase.Items.Add("9")
        cboBase.Items.Add("8")
        cboBase.Items.Add("7")
        cboBase.Items.Add("6")
        cboBase.Items.Add("5")
        cboBase.Items.Add("4")
        cboBase.Items.Add("3")
        cboBase.Items.Add("2")

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        pnlBaseNum.Visible = True

    End Sub

    Private Sub txtBaseConvert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Check for number only input 
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'txtBaseConvert.Focus()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub cboBase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBase.SelectedIndexChanged
        If cboBase.Text = "2" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = True
            opt9.Enabled = True
            opt8.Enabled = True
            opt7.Enabled = True
            opt6.Enabled = True
            opt5.Enabled = True
            opt4.Enabled = True
            opt3.Enabled = True
            opt2.Enabled = False

        ElseIf cboBase.Text = "3" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = True
            opt9.Enabled = True
            opt8.Enabled = True
            opt7.Enabled = True
            opt6.Enabled = True
            opt5.Enabled = True
            opt4.Enabled = True
            opt3.Enabled = False
            opt2.Enabled = True

            Dim Base3Ans As Double
            Base3Ans = FuncBase103()

        ElseIf cboBase.Text = "4" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = True
            opt9.Enabled = True
            opt8.Enabled = True
            opt7.Enabled = True
            opt6.Enabled = True
            opt5.Enabled = True
            opt4.Enabled = False
            opt3.Enabled = False
            opt2.Enabled = True

        ElseIf cboBase.Text = "5" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = True
            opt9.Enabled = True
            opt8.Enabled = True
            opt7.Enabled = True
            opt6.Enabled = True
            opt5.Enabled = False
            opt4.Enabled = True
            opt3.Enabled = True
            opt2.Enabled = True

        ElseIf cboBase.Text = "6" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = True
            opt9.Enabled = True
            opt8.Enabled = True
            opt7.Enabled = True
            opt6.Enabled = False
            opt5.Enabled = True
            opt4.Enabled = True
            opt3.Enabled = True
            opt2.Enabled = True

        ElseIf cboBase.Text = "7" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = True
            opt9.Enabled = True
            opt8.Enabled = True
            opt7.Enabled = False
            opt6.Enabled = True
            opt5.Enabled = True
            opt4.Enabled = True
            opt3.Enabled = True
            opt2.Enabled = True

        ElseIf cboBase.Text = "8" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = True
            opt9.Enabled = True
            opt8.Enabled = False
            opt7.Enabled = True
            opt6.Enabled = True
            opt5.Enabled = True
            opt4.Enabled = True
            opt3.Enabled = True
            opt2.Enabled = True

        ElseIf cboBase.Text = "9" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = True
            opt9.Enabled = False
            opt8.Enabled = True
            opt7.Enabled = True
            opt6.Enabled = True
            opt5.Enabled = True
            opt4.Enabled = True
            opt3.Enabled = True
            opt2.Enabled = True

        ElseIf cboBase.Text = "10" Then
            grpNum.Visible = True
            txtBaseNum.Focus()
            grpBases.Visible = True
            opt10.Enabled = False
            opt9.Enabled = True
            opt8.Enabled = True
            opt7.Enabled = True
            opt6.Enabled = True
            opt5.Enabled = True
            opt4.Enabled = True
            opt3.Enabled = True
            opt2.Enabled = True
            txtBaseNum.Focus()

        End If
    End Sub

    Function FuncBase102() As Double
        'building base10 to base2 
        Dim Base102 As Double
        Base102 = Val(txtBaseNum.Text)

        Select Case Base102
            Case 1 : Base102 = 1
            Case 2 : Base102 = 10
            Case 3 : Base102 = 11
            Case 4 : Base102 = 100
            Case 5 : Base102 = 101
            Case 6 : Base102 = 110
            Case 7 : Base102 = 111
            Case 8 : Base102 = 1000
            Case 9 : Base102 = 1001
            Case 10 : Base102 = 1010

            Case Else

        End Select

        cmdResetBase.Visible = True
        'lblAns.Visible = True
        txtBaseNum.Text = Base102

        'lblBaseAns.Visible = True
        'lblBaseAns.Text = Base102

    End Function

    Function FuncBase103() As Double
        'building base10 to base3
        Dim Base103 As Double
        Base103 = Val(txtBaseNum.Text)

        Select Case Base103
            Case 1 : Base103 = 1
            Case 2 : Base103 = 10
            Case 3 : Base103 = 11
            Case 4 : Base103 = 100
            Case 5 : Base103 = 101
            Case 6 : Base103 = 110
            Case 7 : Base103 = 111
            Case 8 : Base103 = 1000
            Case 9 : Base103 = 1001
            Case 10 : Base103 = 1010

            Case Else

        End Select

    End Function

    Private Sub txtBase10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBaseNum.KeyPress
        'validating textbox for base10
        If cboBase.Text = "10" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If

            'validating textbox for base9
        ElseIf cboBase.Text = "9" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(56) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If

            'validating textbox for base8
        ElseIf cboBase.Text = "8" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(55) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If


            'validating textbox for base7
        ElseIf cboBase.Text = "7" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(54) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If

            'validating textbox for base6
        ElseIf cboBase.Text = "6" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(53) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If

            'validating textbox for base5
        ElseIf cboBase.Text = "5" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(52) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If

            'validating textbox for base4
        ElseIf cboBase.Text = "4" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(51) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If

            'validating textbox for base3
        ElseIf cboBase.Text = "3" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(50) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If

            'validating textbox for base2
        ElseIf cboBase.Text = "2" Then
            If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(49) Or e.KeyChar = ChrW(8) Then
                Exit Sub
            ElseIf (e.KeyChar = ChrW(13)) Then
                Dim Base2Ans As Double
                Base2Ans = FuncBase102()

            Else
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt5.CheckedChanged

    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt6.CheckedChanged

    End Sub
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt7.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt2.CheckedChanged
        Dim Base2Ans As Double
        Base2Ans = FuncBase102()
        'grpNum.Text = "Base 2"
    End Sub

    Private Sub cmdResetBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetBase.Click

        txtBaseNum.Text = ""
        txtBaseNum.Focus()
        grpBases.Visible = False
        opt10.Checked = False
        opt9.Checked = False
        opt8.Checked = False
        opt7.Checked = False
        opt6.Checked = False
        opt5.Checked = False
        opt4.Checked = False
        opt3.Checked = False
        opt2.Checked = False
    End Sub
End Class