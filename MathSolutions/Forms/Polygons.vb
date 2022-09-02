Public Class Polygons
    Dim sides, polygon, ans As Single

    Private Sub Polygons_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.gms6
        cboAngle.Items.Add("Interior Angle")
        cboAngle.Items.Add("Sum of Interior Angle")
        cboAngle.Items.Add("Exterior Angle")
        Label3.Text = "A polygon is a plane figure closed with straight lines.  A regular polygon has equal interior angles and sides."
        ' Label3.Text &= "Note: The number of sides of a regular polygon is the same as the line of symmetry."


    End Sub

    Public Function SumInteriorA() As Integer
        If txtSides.Text = "" Then
            'findng number of sides of polygon
            polygon = Val(txtPoly.Text)
            sides = (360 + polygon) / 180
            txtSides.Text = sides : txtSides.ForeColor = Color.Blue

        ElseIf txtPoly.Text = "" Then
            'finding the sum of interior angle
            sides = Val(txtSides.Text)
            polygon = (sides - 2) * 180
            txtPoly.Text = polygon & " °" : txtPoly.ForeColor = Color.Blue

        End If
    End Function

    Public Function InteriorA() As Integer
        If txtSides.Text = "" Then
            'findng number of sides of polygon
            polygon = Val(txtPoly.Text)
            sides = 360 / (180 - polygon)
            txtSides.Text = sides : txtSides.ForeColor = Color.Blue

        ElseIf txtPoly.Text = "" Then
            'finding the interior angle
            sides = Val(txtSides.Text)
            polygon = ((sides - 2) * 180) / sides
            txtPoly.Text = polygon & " °" : txtPoly.ForeColor = Color.Blue

        End If
    End Function

    Public Function ExteriorA() As Integer
        If txtSides.Text = "" Then
            'findng number of sides of polygon
            polygon = Val(txtPoly.Text)
            sides = 360 / polygon
            txtSides.Text = sides : txtSides.ForeColor = Color.Blue

        ElseIf txtPoly.Text = "" Then
            'finding the exterior angle
            sides = Val(txtSides.Text)
            polygon = 360 / sides
            txtPoly.Text = polygon & " °" : txtPoly.ForeColor = Color.Blue

        End If
    End Function


    Private Sub btnSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click
        If cboAngle.Text = "Interior Angle" Then
            Label3.Text = "All interior angle of a regular polygon are equal.  ((n – 2) * 180° / n), where n is the number of sides."
            InteriorA()
        ElseIf cboAngle.Text = "Sum of Interior Angle" Then
            Label3.Text = "The sum of the interior angles of a regular polygon is given by (n – 2) * 180°, where n is the number of sides."
            SumInteriorA()
        ElseIf cboAngle.Text = "Exterior Angle" Then
            Label3.Text = "All exterior angle of a regular polygon are equal. 360 /n, where n is the number of sides."
            ExteriorA()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPoly.Clear() : txtPoly.ForeColor = Color.Black
        txtSides.Clear() : txtSides.ForeColor = Color.Black
        txtSides.Focus() : Me.Size = New Point(300, 340)

    End Sub

    Private Sub cboAngle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAngle.SelectedIndexChanged
        txtPoly.Clear() : txtPoly.ForeColor = Color.Black
        txtSides.Clear() : txtSides.ForeColor = Color.Black
        txtSides.Focus() : Me.Size = New Point(300, 340)

        If cboAngle.Text = "Interior Angle" Then
            Label3.Text = "All interior angle of a regular polygon are equal and is given by ((n – 2) * 180° / n), where n is the number of sides."
        ElseIf cboAngle.Text = "Sum of Interior Angle" Then
            Label3.Text = "The sum of the interior angles of a regular polygon is given by (n – 2) * 180°, where n is the number of sides."
        ElseIf cboAngle.Text = "Exterior Angle" Then
            Label3.Text = "All exterior angle of a regular polygon are equal and is given by 360° /n, where n is the number of sides."
        End If
    End Sub

    Private Sub btnProof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProof.Click
        Me.Size = New Point(500, 340)

    End Sub
End Class