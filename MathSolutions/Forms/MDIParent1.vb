Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlgebra.Click

        pnlSelect.Visible = True
        cboSubSelect.Visible = False
        lblSubSelect.Visible = False
        lblChoose.Visible = False
        cboChoose.Visible = False

        lblSelect.Text = "Algebra Selections"
        cboSelect.Items.Clear()
        ' cboSelect.Items.Add("Factorials")
        cboSelect.Items.Add("Graphs of Relations")
        cboSelect.Items.Add("Decimal Fractions")
        'cboSelect.Items.Add("Significant Figures")
        cboSelect.Items.Add("Decimal Places")
        'cboSelect.Items.Add("Standard Form")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquations.Click

        pnlSelect.Visible = True
        cboSelect.Items.Clear()
        cboSubSelect.Visible = False
        lblSubSelect.Visible = False
        lblChoose.Visible = False
        cboChoose.Visible = False
        lblSelect.Text = "Equation Selections"
        cboSelect.Items.Add("Quadratic Equations")
        cboSelect.Items.Add("Cubic Equations")
        cboSelect.Items.Add("Simultaneous Equations")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeometry.Click

        pnlSelect.Visible = True
        cboSelect.Items.Clear()
        cboSubSelect.Visible = False
        lblSubSelect.Visible = False
        lblChoose.Visible = False
        cboChoose.Visible = False
        lblSelect.Text = "Geometry Selections"
        cboSelect.Items.Add("Plane Geometry")
        cboSelect.Items.Add("Solid Geometry")

    End Sub

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        If cboSelect.Text = "Plane Geometry" Then
            cboSubSelect.Visible = True
            lblSubSelect.Visible = True
            lblSubSelect.Text = "Select Plane Geometry"
            cboSubSelect.Items.Clear()
            'cboSubSelect.Items.Add("Angles")
            cboSubSelect.Items.Add("Areas")
            cboSubSelect.Items.Add("Perimeters")
            cboSubSelect.Items.Add("Trigonometry")
            cboSubSelect.Items.Add("Pythagoras' Theorem")
            cboSubSelect.Items.Add("Coordinate Geometry")
            cboSubSelect.Items.Add("Transformations")
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Solid Geometry" Then
            cboSubSelect.Visible = True
            lblSubSelect.Visible = True
            lblSubSelect.Text = "Select Solid Geometry"
            cboSubSelect.Items.Clear()
            cboSubSelect.Items.Add("Cone")
            cboSubSelect.Items.Add("Cube")
            cboSubSelect.Items.Add("Cuboid")
            cboSubSelect.Items.Add("Cylinder")
            cboSubSelect.Items.Add("Prism")
            cboSubSelect.Items.Add("Pyramid")
            cboSubSelect.Items.Add("Sphere")
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Roots" Then
            cboSubSelect.Visible = True
            lblSubSelect.Visible = True
            lblSubSelect.Text = "Select Root"
            cboSubSelect.Items.Clear()
            cboSubSelect.Items.Add("Square Root")
            cboSubSelect.Items.Add("Cubic Root")
            cboSubSelect.Items.Add("nth Root")
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Powers" Then
            cboSubSelect.Visible = True
            lblSubSelect.Visible = True
            lblSubSelect.Text = "Select Power"
            cboSubSelect.Items.Clear()
            cboSubSelect.Items.Add("Squares")
            cboSubSelect.Items.Add("Cubes")
            cboSubSelect.Items.Add("nth Power")
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Brain Box" Then
            BrainBox.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Quadratic Equations" Then
            Equations.Show()
            My.Forms.Equations.ComboBox1.Text = "Quadratic Equations"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Cubic Equations" Then
            Equations.Show()
            My.Forms.Equations.ComboBox1.Text = "Cubic Equations"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Simultaneous Equations" Then
            SimultaneousEquations.Show()
            My.Forms.SimultaneousEquations.cboDim.Text = "2"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Graphs of Relations" Then
            cboSubSelect.Visible = True
            lblSubSelect.Visible = True
            cboSubSelect.Items.Clear()
            lblSubSelect.Text = "Select Graphs of Relations"
            cboSubSelect.Items.Add("Linear Relations")
            cboSubSelect.Items.Add("Quadratic Relations")
            cboSubSelect.Items.Add("Cubic Relations")
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Decimal Fractions" Then
            cboSubSelect.Visible = False
            lblSubSelect.Visible = False
            DecimalFractions.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Factorials" Then
            cboSubSelect.Visible = False
            lblSubSelect.Visible = False
            Factorials.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Decimal Places" Then
            cboSubSelect.Visible = False
            lblSubSelect.Visible = False
            Approximations.Show()
            Approximations.cboSelect.Text = "Decimal Places"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Standard Deviation" Then
            cboSubSelect.Visible = False
            lblSubSelect.Visible = False
            StandardDeviation.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSelect.Text = "Pie Chart" Then
            lblChoose.Visible = False
            cboChoose.Visible = False
            cboSubSelect.Visible = False
            lblSubSelect.Visible = False
            PieChart.Show()

        ElseIf cboSelect.Text = "Units Conversions" Then
            lblChoose.Visible = False
            cboChoose.Visible = False
            cboSubSelect.Visible = False
            lblSubSelect.Visible = False

        End If
    End Sub

    Private Sub cboSubSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubSelect.SelectedIndexChanged
        If cboSubSelect.Text = "Areas" Then
            lblChoose.Visible = False
            cboChoose.Visible = False
            AreasPerimeters.Show()
            My.Forms.AreasPerimeters.cboAreaPerimeters.Text = "Areas"

        ElseIf cboSubSelect.Text = "Perimeters" Then
            lblChoose.Visible = False
            cboChoose.Visible = False
            AreasPerimeters.Show()
            My.Forms.AreasPerimeters.cboAreaPerimeters.Text = "Perimeters"

        ElseIf cboSubSelect.Text = "Cone" Then
            lblChoose.Visible = False
            cboChoose.Visible = False
            AreasVolumes.Show()
            My.Forms.AreasVolumes.cboSolidFigures.Text = "Cone"

        ElseIf cboSubSelect.Text = "Cube" Then
            AreasVolumes.Show()
            My.Forms.AreasVolumes.cboSolidFigures.Text = "Cube"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Cuboid" Then
            AreasVolumes.Show()
            My.Forms.AreasVolumes.cboSolidFigures.Text = "Cuboid"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Cylinder" Then
            AreasVolumes.Show()
            My.Forms.AreasVolumes.cboSolidFigures.Text = "Cylinder"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Prism" Then
            AreasVolumes.Show()
            My.Forms.AreasVolumes.cboSolidFigures.Text = "Prism"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Pyramid" Then
            AreasVolumes.Show()
            My.Forms.AreasVolumes.cboSolidFigures.Text = "Pyramid"

        ElseIf cboSubSelect.Text = "Sphere" Then
            AreasVolumes.Show()
            My.Forms.AreasVolumes.cboSolidFigures.Text = "Sphere"
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Linear Relations" Then
            LinearRelation.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Quadratic Relations" Then
            QuadraticRelations.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Cubic Relations" Then
            CubicRelations.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Trigonometry" Then
            lblChoose.Visible = True
            cboChoose.Visible = True
            lblChoose.Text = "Select Trigonometry"
            cboChoose.Items.Add("Trigonometric Functions")
            cboChoose.Items.Add("Conversion of Angles")

        ElseIf cboSubSelect.Text = "Angles" Then
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Pythagoras' Theorem" Then
            Pythagoras.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Coordinate Geometry" Then
            CoordinateGeometry.Show()
            lblChoose.Visible = False
            cboChoose.Visible = False

        ElseIf cboSubSelect.Text = "Transformations" Then
            lblChoose.Visible = False
            cboChoose.Visible = False
            Transformation.Show()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumbers.Click

        pnlSelect.Visible = False
        Numbers.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatistics.Click

        pnlSelect.Visible = True
        cboSelect.Items.Clear()
        cboSubSelect.Visible = False
        lblSubSelect.Visible = False
        lblChoose.Visible = False
        cboChoose.Visible = False
        lblSelect.Text = "Statistics"
        cboSelect.Items.Add("Standard Deviation")
        'cboSelect.Items.Add("Cumulative Frequency")
        'cboSelect.Items.Add("Pie Chart")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        pnlSelect.Visible = True
        cboSelect.Items.Clear()
        cboSubSelect.Visible = False
        lblSubSelect.Visible = False
        lblChoose.Visible = False
        cboChoose.Visible = False
        lblSelect.Text = "Misc."
        cboSelect.Items.Add("Brain Box")
        cboSelect.Items.Add("Pie Chart")
        cboSelect.Items.Add("Units Conversions")
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
    '    Me.LayoutMdi(MdiLayout.Cascade)
    'End Sub

    'Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
    '    Me.LayoutMdi(MdiLayout.TileVertical)
    'End Sub

    'Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
    '    Me.LayoutMdi(MdiLayout.TileHorizontal)
    'End Sub

    'Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
    '    Me.LayoutMdi(MdiLayout.ArrangeIcons)
    'End Sub

    'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
    '    ' Close all child forms of the parent.
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    'End Sub

    Private Sub MDIParent1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.gms6
        StatusLabel2.Text = My.Computer.Name
        StatusLabel2.Text &= "  -   " & Application.ProductName

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' About.MdiParent = Me
        My.Forms.About.Show()

    End Sub


    Private Sub LinearRelationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinearRelationsToolStripMenuItem.Click
        'LinearRelation.MdiParent = Me
        LinearRelation.Show()
    End Sub

    Private Sub QuafraticRelationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuafraticRelationsToolStripMenuItem.Click
        'QuadraticRelations.MdiParent = Me
        QuadraticRelations.Show()
    End Sub

    Private Sub CubicRelationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CubicRelationsToolStripMenuItem.Click
        'CubicRelations.MdiParent = Me
        CubicRelations.Show()
    End Sub

    Private Sub DcimalFractionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DcimalFractionsToolStripMenuItem.Click
        ' DecimalFractions.MdiParent = Me
        DecimalFractions.Show()
    End Sub

    Private Sub DecimalPlacesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecimalPlacesToolStripMenuItem.Click
        ' Approximations.MdiParent = Me
        Approximations.Show()
    End Sub

    Private Sub QuadraticEquationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuadraticEquationToolStripMenuItem.Click
        'Equations.MdiParent = Me
        Equations.Show()
        Equations.ComboBox1.Text = "Quadratic Equations"
    End Sub

    Private Sub CubicEquationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CubicEquationToolStripMenuItem.Click
        ' Equations.MdiParent = Me
        Equations.Show()
        Equations.ComboBox1.Text = "Cubic Equations"
    End Sub

    Private Sub SimultaneousEquationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimultaneousEquationToolStripMenuItem.Click
        'SimultaneousEquations.MdiParent = Me
        SimultaneousEquations.Show()
    End Sub

    Private Sub AreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreasToolStripMenuItem.Click
        ' AreasPerimeters.MdiParent = Me
        AreasPerimeters.Show()
    End Sub

    Private Sub TrigFunctionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrigFunctionsToolStripMenuItem.Click
        'Trigonometry.MdiParent = Me
        Trigonometry.Show()
    End Sub

    Private Sub ConversionOfAnglesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConversionOfAnglesToolStripMenuItem.Click
        'DegreeRadian.MdiParent = Me
        DegreeRadian.Show()
    End Sub

    Private Sub PythagorasTheoremToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PythagorasTheoremToolStripMenuItem.Click
        'Pythagoras.MdiParent = Me
        Pythagoras.Show()
    End Sub

    Private Sub CoordinateGeometryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoordinateGeometryToolStripMenuItem.Click
        'CoordinateGeometry.MdiParent = Me
        CoordinateGeometry.Show()
    End Sub

    Private Sub VolumesSurfaceAreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumesSurfaceAreasToolStripMenuItem.Click
        'AreasVolumes.MdiParent = Me
        AreasVolumes.Show()
    End Sub

    Private Sub MeanDeviationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeanDeviationToolStripMenuItem.Click
        'StandardDeviation.MdiParent = Me
        StandardDeviation.Show()
    End Sub

    Private Sub BrainBoxToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrainBoxToolStripMenuItem.Click
        'BrainBox.MdiParent = Me
        BrainBox.Show()
    End Sub

    Private Sub PolygonsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PolygonsToolStripMenuItem.Click
        'Polygons.MdiParent = Me
        Polygons.Show()
    End Sub

    Private Sub FactorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactorsToolStripMenuItem.Click
        ' Numbers.MdiParent = Me
        Numbers.Show()
        Numbers.ComboBox1.Text = "Factors"
    End Sub

    Private Sub MultiplesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiplesToolStripMenuItem.Click
        ' Numbers.MdiParent = Me
        Numbers.Show()
        Numbers.ComboBox1.Text = "Multiples"
    End Sub

    Private Sub HCFLCMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HCFLCMToolStripMenuItem.Click
        'Numbers.MdiParent = Me
        Numbers.Show()
        Numbers.ComboBox1.Text = "HCF & LCM"

    End Sub

    Private Sub PrimeNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimeNumberToolStripMenuItem.Click
        'Numbers.MdiParent = Me
        Numbers.Show()
        Numbers.ComboBox1.Text = "Prime Number"

    End Sub

    Private Sub EvenNumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvenNumbersToolStripMenuItem.Click
        'NaturalNumbers.MdiParent = Me
        NaturalNumbers.Show()
        NaturalNumbers.cboSelect.Text = "Even Numbers"
    End Sub

    Private Sub OddNumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OddNumbersToolStripMenuItem.Click
        ' NaturalNumbers.MdiParent = Me
        NaturalNumbers.Show()
        NaturalNumbers.cboSelect.Text = "Odd Numbers"

    End Sub

    Private Sub RootsPowersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RootsPowersToolStripMenuItem.Click
        'NaturalNumbers.MdiParent = Me
        NaturalNumbers.Show()
        NaturalNumbers.cboSelect.Text = "Roots & Powers"

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
