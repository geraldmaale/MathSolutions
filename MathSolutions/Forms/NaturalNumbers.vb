Public Class NaturalNumbers
    Dim strRoot As String

    Private Sub txtNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumber.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            If cboSelect.Text = "Square Roots" Then
                Dim AnsSquare As Single
                AnsSquare = FuncSquareRoot()

            ElseIf cboSelect.Text = "Cubic Roots" Then
                Dim AnsCubic As Single
                AnsCubic = FuncCubicRoot()

            ElseIf cboSelect.Text = "nth Roots" Then
                Dim AnsnthRoot As Single = FuncRoot()

            ElseIf cboSelect.Text = "Powers of 2" Then
                Dim AnsPow2 As Integer
                AnsPow2 = FuncPowers2()

            ElseIf cboSelect.Text = "Powers of 3" Then
                Dim AnsPow3 As Integer
                AnsPow3 = FuncPowers3()

            ElseIf cboSelect.Text = "nth Powers" Then
                Dim AnsnthPow As Single = FuncPowers()

            End If
        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtRoot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoot.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer
            txtNumber.Focus()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub
    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        If cboSelect.Text = "Square Roots" Then
            pnlNum.Visible = True
            pnlRoot.Visible = False
            txtNumber.Focus()
            txtNumber.Text = ""
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "Cubic Roots" Then
            pnlNum.Visible = True
            pnlRoot.Visible = False
            txtNumber.Focus()
            txtNumber.Text = ""
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "nth Roots" Then
            pnlNum.Visible = True
            pnlRoot.Visible = True
            txtroot.Focus()
            txtNumber.Text = "" : txtRoot.Clear()
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "Powers of 2" Then
            pnlNum.Visible = True
            txtNumber.Focus()
            txtNumber.Text = ""
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "Powers of 3" Then
            pnlNum.Visible = True
            pnlRoot.Visible = False
            txtNumber.Focus()
            txtNumber.Text = ""
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "nth Powers" Then
            pnlNum.Visible = True
            pnlRoot.Visible = True
            txtRoot.Focus()
            txtNumber.Text = "" : txtRoot.Clear()
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "Common Factors" Then
            pnlNum.Visible = True
            pnlRoot.Visible = False
            txtNumber.Focus()
            txtNumber.Text = ""
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "H. C. F." Then
            pnlNum.Visible = True
            pnlRoot.Visible = False
            txtNumber.Focus()
            txtNumber.Text = ""
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "Common Multiples" Then
            pnlNum.Visible = True
            pnlRoot.Visible = False
            txtNumber.Focus()
            txtNumber.Text = ""
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        ElseIf cboSelect.Text = "L. C. M." Then
            pnlNum.Visible = True
            pnlRoot.Visible = False
            txtNumber.Focus()
            txtNumber.Text = ""
            lstNumbers.Items.Clear() : lstNumbers.Visible = False

        End If
    End Sub

    Function FuncSquareRoot() As Single
        'initializing square root calculation
        Dim NumSq As Integer
        Dim Square As Single

        NumSq = Val(txtNumber.Text)
        Square = Math.Sqrt(NumSq)
        lstNumbers.Visible = True
        lstNumbers.Items.Add("Square Root (" & NumSq & ")" & " = " & Square)
        lstNumbers.Items.Add("")
        lstNumbers.Items.Add("√" & NumSq & " = " & Square)
        cmdClear.Visible = True
        cmdClear.Enabled = True
    End Function

    Function FuncCubicRoot() As Single
        'initializing cubic root calculation
        lstNumbers.Items.Clear()
        Dim NumCube As Integer
        Dim Cubic As Single

        NumCube = Val(txtNumber.Text)
        Cubic = (NumCube) ^ (1 / 3)
        lstNumbers.Visible = True
        lstNumbers.Items.Add("cubic Root (" & NumCube & ") = " & Cubic)
        lstNumbers.Items.Add("")
        lstNumbers.Items.Add("3√(" & NumCube & ") = " & Cubic)
        cmdClear.Visible = True
        cmdClear.Enabled = True
    End Function

    Function FuncRoot() As Single
        'initializing nth root calculation
        lstNumbers.Items.Clear()
        Dim NumRoot As Integer
        Dim Rootpower As Integer
        Dim Root As Single


        NumRoot = Val(txtNumber.Text)
        Rootpower = Val(txtRoot.Text)
        Root = (NumRoot) ^ (1 / (Rootpower))
        lstNumbers.Visible = True

        Select Case Rootpower
            Case Is = 1
                strRoot = "st "
            Case 2
                strRoot = "nd "
            Case 3
                strRoot = "rd "
            Case Is >= 3
                strRoot = "th "
        End Select

        lstNumbers.Items.Add(Rootpower & strRoot & "Root of " & NumRoot & " is " & Root)
        lstNumbers.Items.Add("")
        lstNumbers.Items.Add(Rootpower & "√(" & NumRoot & ") = " & Root)
        cmdClear.Visible = True
        cmdClear.Enabled = True
    End Function

    Function FuncPowers2() As Single
        'powers of 2 calculation
        lstNumbers.Items.Clear()
        Dim Pow2 As Integer
        Dim Square As Single

        Pow2 = Val(txtNumber.Text)
        Square = (Pow2) ^ 2
        lstNumbers.Visible = True
        lstNumbers.Items.Add("Square of " & Pow2 & " is " & Square)
        lstNumbers.Items.Add("")
        lstNumbers.Items.Add(Pow2 & "^2 = " & Square)
        cmdClear.Visible = True
        cmdClear.Enabled = True

    End Function

    Function FuncPowers3() As Single
        'powers of 3 calculation
        lstNumbers.Items.Clear()
        Dim Pow3 As Integer
        Dim cube As Single

        Pow3 = Val(txtNumber.Text)
        cube = (Pow3) ^ 3
        lstNumbers.Visible = True
        lstNumbers.Items.Add("Cube of " & Pow3 & " is " & cube)
        lstNumbers.Items.Add("")
        lstNumbers.Items.Add(Pow3 & "^3 = " & cube)
        cmdClear.Visible = True
        cmdClear.Enabled = True

    End Function

    Function FuncPowers() As Single
        'nth powers calculation
        lstNumbers.Items.Clear()
        Dim PowNum As Integer
        Dim power As Integer
        Dim Ans As Single


        PowNum = Val(txtNumber.Text)
        power = Val(txtRoot.Text)
        Ans = (PowNum) ^ (power)
        lstNumbers.Visible = True

        lstNumbers.Items.Add(PowNum & " Power of " & power & " is " & Ans)
        lstNumbers.Items.Add("")
        lstNumbers.Items.Add(PowNum & "^" & power & " = " & Ans)
        cmdClear.Visible = True
        cmdClear.Enabled = True
    End Function

    Function FuncEven() As Integer
        'Even numbers generation code
        Dim FirstNum As Integer
        Dim LastNum As Integer
        Dim ForEven As Integer

        FirstNum = Val(txtFirst.Text)
        LastNum = Val(txtLast.Text)

        For ForEven = FirstNum To LastNum
            If ForEven / 2 = CInt(ForEven \ 2) Then
                lstNumbers.Visible = True
                lstNumbers.Items.Add(ForEven)
            End If

        Next
        cmdClear.Visible = True

    End Function

    Function FuncOdd() As Integer
        'Odd numbers generation code
        Dim FirstNum As Integer
        Dim LastNum As Integer
        Dim ForOdd As Integer

        FirstNum = Val(txtFirst.Text)
        LastNum = Val(txtLast.Text)

        For ForOdd = FirstNum To LastNum
            If ForOdd / 2 <> CInt(ForOdd / 2) Then
                lstNumbers.Visible = True
                lstNumbers.Items.Add(ForOdd)
            End If

        Next
        cmdClear.Visible = True
    End Function

    Function FuncPrime() As Integer
        'Prime numbers generation code

        Dim FirstNum As Integer
        Dim LastNum As Integer
        Dim ForPrime As Integer
        Dim PrimeCheck As Integer

        FirstNum = Val(txtFirst.Text)
        LastNum = Val(txtLast.Text)

        For ForPrime = FirstNum To LastNum
            If ForPrime / PrimeCheck <> 1 Then
                lstNumbers.Visible = True
                lstNumbers.Items.Add(ForPrime)
            End If
        Next
        cmdClear.Visible = True
    End Function

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtNumber.Text = ""
        txtRoot.Text = ""
        txtFirst.Text = ""
        txtLast.Text = ""
        txtFirst.Focus()
        txtNumber.Focus()
        lstNumbers.Items.Clear()
        lstNumbers.Visible = False
        txtNumber.Focus()
        'cmdClear.Enabled = False

    End Sub

    Private Sub txtFirst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirst.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub
        ElseIf (e.KeyChar = ChrW(13)) Then
            'Check answer

            txtLast.Focus()

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtLast_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLast.KeyPress
        'Check for number only input and for return key
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Or e.KeyChar = ChrW(8) Then
            Exit Sub

        Else
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub cmdOdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOdd.Click
        lstNumbers.Items.Clear()
        Dim AnsOdd As Integer
        AnsOdd = FuncOdd()
    End Sub


    Private Sub NaturalNumbers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.gms6
        ComboBox1.Items.Add("Even Numbers")
        ComboBox1.Items.Add("Odd Numbers")
        ComboBox1.Items.Add("Roots & Powers")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Even Numbers" Then
            Me.Size = New Size(593, 452)
            Me.StartPosition = FormStartPosition.CenterScreen
            cboSelect.Visible = False
            pnlNum.Visible = False
            pnlRoot.Visible = False
            GroupBox1.Visible = True
            txtFirst.Focus()
            cmdEven.Visible = True
            cmdOdd.Visible = False
            txtNotes.Visible = True
            cmdClear.Visible = False
            Label3.Text = "Even Numbers"
            txtNotes.Text = "An Even Number is a number that easily divided by 2 without any remainder. Eg. 2, 4, 6 are even numbers but 1,3,5 are not even numbers."

            txtFirst.Clear()
            txtLast.Clear()
            txtNumber.Clear()
            txtRoot.Clear()
            lstNumbers.Visible = False

        ElseIf ComboBox1.Text = "Odd Numbers" Then
            txtFirst.Clear()
            txtLast.Clear()
            txtNumber.Clear()
            txtRoot.Clear()
            lstNumbers.Visible = False
            cmdClear.Visible = False
            Me.Size = New Size(593, 452)
            cboSelect.Visible = False
            pnlNum.Visible = False
            GroupBox1.Visible = True
            txtFirst.Focus()
            cmdEven.Visible = False
            cmdOdd.Visible = True
            txtNotes.Visible = True
            Label3.Text = "Odd Numbers"
            txtNotes.Text = "An Odd Number is a number that when divided by 2 returns a remainder. Eg. 1, 3, 5 are odd numbers but 2, 4, 6 are not odd numbers."

            txtFirst.Clear()
            txtLast.Clear()
            txtNumber.Clear()
            txtRoot.Clear()
            lstNumbers.Visible = False

        ElseIf ComboBox1.Text = "Roots & Powers" Then
            Me.Size = New Size(407, 452)
            cboSelect.Visible = True
            pnlNum.Visible = False
            pnlRoot.Visible = False
            cmdEven.Visible = False
            cmdOdd.Visible = False
            GroupBox1.Visible = False
            txtNotes.Visible = False
            cmdClear.Visible = False
            cboSelect.Items.Clear()
            Label3.Text = "Roots && Powers"
            cboSelect.Items.Add("Square Roots")
            cboSelect.Items.Add("Cubic Roots")
            cboSelect.Items.Add("nth Roots")
            cboSelect.Items.Add("Powers of 2")
            cboSelect.Items.Add("Powers of 3")
            cboSelect.Items.Add("nth Powers")

        End If
    End Sub

    Private Sub cmdEven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEven.Click
        Dim ans As Long = FuncEven()
    End Sub

End Class