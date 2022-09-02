Public Class AreasVolumes
    Dim Length As Single
    Dim Breadth As Single
    Dim HeightObj As Single
    Dim Base As Single
    Dim CurvedArea As Single
    Dim TotalArea As Single
    Dim Volumes As Single
    Dim TFaces As Single
    Dim Radius As Single
    Dim Angle As Single
    Dim A As Single, B As Single, C As Single, D As Single
    Const pi = 22 / 7
    Private Sub AreasVolumes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.gms6
        cboSolidFigures.Items.Add("Cone")
        cboSolidFigures.Items.Add("Cube")
        cboSolidFigures.Items.Add("Cuboid")
        cboSolidFigures.Items.Add("Cylinder")
        cboSolidFigures.Items.Add("Prism")
        cboSolidFigures.Items.Add("Pyramid")
        cboSolidFigures.Items.Add("Sphere")

        'Disabling other controls
        cboVolumeArea.Visible = False
        lblVolumesAreas.Visible = False
        Panel2.Visible = False

    End Sub

    Private Sub cboSolidFigures_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSolidFigures.SelectedIndexChanged
        Me.Size = New Point(370, 424)

        If cboSolidFigures.Text = "Cone" Then

            'Clearing
            cboVolumeArea.Items.Clear() : lblBreadth.Visible = False : txtBreadth.Visible = False : lblBreadth.Visible = False : txtBreadth.Visible = False
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            formula.Visible = False
            btnProof.Visible = False
            btnReset.Visible = False
            btnSolve.Visible = False


            'Selection for cone
            cboVolumeArea.Items.Add("Curved S. Area - Cone")
            cboVolumeArea.Items.Add("Total S. Area - Cone (Solid)")
            cboVolumeArea.Items.Add("Total S. Area - Cone (Hallow)")
            cboVolumeArea.Items.Add("Volume - Cone")

            cboVolumeArea.Visible = True
            lblVolumesAreas.Visible = True
            Panel2.Visible = True
            cboVolumeArea.Focus()

        ElseIf cboSolidFigures.Text = "Cube" Then

            'Clearing
            cboVolumeArea.Items.Clear() : lblBreadth.Visible = False : txtBreadth.Visible = False
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            formula.Visible = False
            btnProof.Visible = False
            btnReset.Visible = False
            btnSolve.Visible = False

            'Selection for cube
            cboVolumeArea.Items.Add("Total S. Area - Cube")
            cboVolumeArea.Items.Add("Volume - Cube")

            cboVolumeArea.Visible = True
            lblVolumesAreas.Visible = True
            Panel2.Visible = True
            cboVolumeArea.Focus()

        ElseIf cboSolidFigures.Text = "Cuboid" Then

            'Clearing
            cboVolumeArea.Items.Clear() : lblBreadth.Visible = False : txtBreadth.Visible = False
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            formula.Visible = False
            btnProof.Visible = False
            btnReset.Visible = False
            btnSolve.Visible = False

            'Selection for cuboid
            cboVolumeArea.Items.Add("Total S. Area - Cuboid")
            cboVolumeArea.Items.Add("Volume - Cuboid")

            cboVolumeArea.Visible = True
            lblVolumesAreas.Visible = True
            Panel2.Visible = True
            cboVolumeArea.Focus()

        ElseIf cboSolidFigures.Text = "Cylinder" Then

            'Clearing
            cboVolumeArea.Items.Clear() : lblBreadth.Visible = False : txtBreadth.Visible = False
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            formula.Visible = False
            btnProof.Visible = False
            btnReset.Visible = False
            btnSolve.Visible = False

            'Selection for cylinder
            cboVolumeArea.Items.Add("Curved S. Area - Cylinder")
            cboVolumeArea.Items.Add("Total S. Area - Cylinder (Closed)")
            cboVolumeArea.Items.Add("Total S. Area - Cylinder (One Open)")
            cboVolumeArea.Items.Add("Total S. Area - Cylinder (Both Open)")
            cboVolumeArea.Items.Add("Volume - Cylinder")

            cboVolumeArea.Visible = True
            lblVolumesAreas.Visible = True
            Panel2.Visible = True
            cboVolumeArea.Focus()

        ElseIf cboSolidFigures.Text = "Prism" Then

            'Clearing
            cboVolumeArea.Items.Clear() : lblBreadth.Visible = False : txtBreadth.Visible = False
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            formula.Visible = False
            btnProof.Visible = False
            btnReset.Visible = False
            btnSolve.Visible = False

            'Selection for prism
            'cboVolumeArea.Items.Add("Surface Area - Prism")
            cboVolumeArea.Items.Add("Volume - Prism")

            cboVolumeArea.Visible = True
            lblVolumesAreas.Visible = True
            Panel2.Visible = True
            cboVolumeArea.Focus()

        ElseIf cboSolidFigures.Text = "Pyramid" Then

            'Clearing
            cboVolumeArea.Items.Clear() : lblBreadth.Visible = False : txtBreadth.Visible = False
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            formula.Visible = False
            btnProof.Visible = False
            btnReset.Visible = False
            btnSolve.Visible = False

            'Selection for pyramid
            cboVolumeArea.Items.Add("Total S. Area - Pyramid")
            cboVolumeArea.Items.Add("Volume - Pyramid")

            cboVolumeArea.Visible = True
            lblVolumesAreas.Visible = True
            Panel2.Visible = True
            cboVolumeArea.Focus()

        ElseIf cboSolidFigures.Text = "Sphere" Then

            'Clearing
            cboVolumeArea.Items.Clear() : lblBreadth.Visible = False : txtBreadth.Visible = False
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            formula.Visible = False
            btnProof.Visible = False
            btnReset.Visible = False
            btnSolve.Visible = False

            'Selection for sphere
            cboVolumeArea.Items.Add("Surface Area - Sphere")
            cboVolumeArea.Items.Add("Volume - Sphere")
            cboVolumeArea.Items.Add("Curved S. Area - Hemisphere")
            cboVolumeArea.Items.Add("Surface Area - Solid Hemisphere")
            cboVolumeArea.Items.Add("Volume - Hemisphere")

            cboVolumeArea.Visible = True
            lblVolumesAreas.Visible = True
            Panel2.Visible = True
            cboVolumeArea.Focus()
        End If

    End Sub

    Private Sub cboVolumeArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVolumeArea.SelectedIndexChanged

        'Choices for cone selection
        If cboVolumeArea.Text = "Curved S. Area - Cone" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True

            'setting defaults for curved surface area
            lblRadius.Visible = True
            lblLength.Visible = True
            lblCurvedArea.Visible = True
            txtCurvedArea.Visible = True
            txtLength.Visible = True
            txtRadius.Visible = True

        ElseIf cboVolumeArea.Text = "Total S. Area - Cone (Solid)" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True

            'selecting defaults for total surface area(solid)
            lblRadius.Visible = True
            lblLength.Visible = True
            lblTotalArea.Visible = True
            txtTotalArea.Visible = True
            txtLength.Visible = True
            txtRadius.Visible = True

            'selecting defaults for total surface area(hallow)
        ElseIf cboVolumeArea.Text = "Total S. Area - Cone (Hallow)" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True

            lblRadius.Visible = True
            lblLength.Visible = True
            lblTotalArea.Visible = True
            txtTotalArea.Visible = True
            txtLength.Visible = True
            txtRadius.Visible = True

            'selecting defaults for volume
        ElseIf cboVolumeArea.Text = "Volume - Cone" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblHeight.Visible = True
            lblVolume.Visible = True
            txtVolumes.Visible = True
            txtHeight.Visible = True
            txtRadius.Visible = True
            lblHeight.Location = New Point(64, 173)
            txtHeight.Location = New Point(204, 167)
        End If

        'Choices for cube selection
        If cboVolumeArea.Text = "Total S. Area - Cube" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblLength.Visible = True
            lblTotalArea.Visible = True
            txtLength.Visible = True
            txtTotalArea.Visible = True
            lblLength.Location = New Point(64, 142)
            txtLength.Location = New Point(204, 136)


            'selecting defaults for volume
        ElseIf cboVolumeArea.Text = "Volume - Cube" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblLength.Visible = True
            lblVolume.Visible = True
            txtLength.Visible = True
            txtVolumes.Visible = True
            lblLength.Location = New Point(64, 142)
            txtLength.Location = New Point(204, 136)
        End If


        'Choices for Cuboid selection
        If cboVolumeArea.Text = "Total S. Area - Cuboid" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblLength.Visible = True
            lblHeight.Visible = True
            lblbreadth.visible = True
            lblTotalArea.Visible = True
            txtLength.Visible = True
            txtHeight.Visible = True
            txtbreadth.visible = True
            txtTotalArea.Visible = True
            lblLength.Refresh() : lblLength.Text = "Length :"
            lblHeight.Refresh()
            lblBreadth.Refresh()
            lblLength.Location = New Point(64, 142)
            txtLength.Location = New Point(204, 136)
            lblTotalArea.Location = New Point(64, 229)
            txtTotalArea.Location = New Point(204, 223)
            lblHeight.Location = New Point(64, 201)
            txtHeight.Location = New Point(204, 195)

        ElseIf cboVolumeArea.Text = "Volume - Cuboid" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblLength.Visible = True
            lblHeight.Visible = True
            lblBreadth.Visible = True
            lblVolume.Visible = True
            txtLength.Visible = True
            txtHeight.Visible = True
            txtBreadth.Visible = True
            txtVolumes.Visible = True
            lblLength.Refresh() : lblLength.Text = "Length :"
            lblHeight.Refresh()
            lblBreadth.Refresh()
            lblLength.Location = New Point(64, 142)
            txtLength.Location = New Point(204, 136)
            lblVolume.Location = New Point(64, 229)
            txtVolumes.Location = New Point(204, 223)
            lblHeight.Location = New Point(64, 201)
            txtHeight.Location = New Point(204, 195)

        End If


        'Choices for cylinder selection
        If cboVolumeArea.Text = "Curved S. Area - Cylinder" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblHeight.Visible = True
            lblCurvedArea.Visible = True
            txtRadius.Visible = True
            txtHeight.Visible = True
            txtCurvedArea.Visible = True
            lblHeight.Location = New Point(64, 173)
            txtHeight.Location = New Point(204, 167)
            lblCurvedArea.Location = New Point(64, 229)
            txtCurvedArea.Location = New Point(204, 223)

        ElseIf cboVolumeArea.Text = "Total S. Area - Cylinder (Closed)" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblHeight.Visible = True
            lblTotalArea.Visible = True
            txtRadius.Visible = True
            txtHeight.Visible = True
            txtTotalArea.Visible = True
            lblHeight.Location = New Point(64, 173)
            txtHeight.Location = New Point(204, 167)
            lblTotalArea.Location = New Point(64, 229)
            txtTotalArea.Location = New Point(204, 223)

        ElseIf cboVolumeArea.Text = "Total S. Area - Cylinder (One Open)" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblHeight.Visible = True
            lblTotalArea.Visible = True
            txtRadius.Visible = True
            txtHeight.Visible = True
            txtTotalArea.Visible = True
            lblHeight.Location = New Point(64, 173)
            txtHeight.Location = New Point(204, 167)
            lblTotalArea.Location = New Point(64, 229)
            txtTotalArea.Location = New Point(204, 223)

        ElseIf cboVolumeArea.Text = "Total S. Area - Cylinder (Both Open)" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblHeight.Visible = True
            lblTotalArea.Visible = True
            txtRadius.Visible = True
            txtHeight.Visible = True
            txtTotalArea.Visible = True
            lblHeight.Location = New Point(64, 173)
            txtHeight.Location = New Point(204, 167)
            lblTotalArea.Location = New Point(64, 229)
            txtTotalArea.Location = New Point(204, 223)

        ElseIf cboVolumeArea.Text = "Volume - Cylinder" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblHeight.Visible = True
            lblVolume.Visible = True
            txtRadius.Visible = True
            txtHeight.Visible = True
            txtVolumes.Visible = True
            lblHeight.Location = New Point(64, 173)
            txtHeight.Location = New Point(204, 167)
            lblVolume.Location = New Point(64, 229)
            txtVolumes.Location = New Point(204, 223)

        End If


        'Choices for prism selection
        If cboVolumeArea.Text = "Volume - Prism" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting volume
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblBase.Visible = True 'Base Area used for Cross Section Area
            lblBase.Text = "Area of Cross Section: "
            lblBase.SendToBack()
            lblLength.Visible = True
            lblVolume.Visible = True
            txtBase.Visible = True 'Based Area used for Cross Section Area
            txtLength.Visible = True
            txtVolumes.Visible = True
            lblBase.Location = New Point(64, 142)
            txtBase.Location = New Point(204, 136)
            'lblLength.Location = New Point(49, 153)
            'txtLength.Location = New Point(189, 147)
            lblVolume.Location = New Point(64, 229)
            txtVolumes.Location = New Point(204, 223)


        End If


        'Choices for pyramid selection
        If cboVolumeArea.Text = "Total S. Area - Pyramid" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            lblTotalArea.Text = "Total S. Area :"
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting 
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblBase.Visible = True
            lblLength.Visible = True 'Length used for Triangular faces
            lblLength.Text = "Area of T. Faces :"
            lblTotalArea.Visible = True
            txtBase.Visible = True
            txtLength.Visible = True 'Length used for Triangular faces
            txtTotalArea.Visible = True
            lblBase.Location = New Point(64, 142)
            txtBase.Location = New Point(204, 136)
            lblTotalArea.Location = New Point(64, 229)
            txtTotalArea.Location = New Point(204, 223)


        ElseIf cboVolumeArea.Text = "Volume - Pyramid" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting 
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblBase.Visible = True
            lblHeight.Visible = True
            lblVolume.Visible = True
            txtBase.Visible = True
            txtHeight.Visible = True
            txtVolumes.Visible = True
            lblBase.Location = New Point(64, 142)
            txtBase.Location = New Point(204, 136)
            lblHeight.Location = New Point(64, 173)
            txtHeight.Location = New Point(204, 167)
            lblVolume.Location = New Point(64, 229)
            txtVolumes.Location = New Point(204, 223)

        End If


        'Choices for sphere selection
        If cboVolumeArea.Text = "Surface Area - Sphere" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblTotalArea.Visible = True
            txtRadius.Visible = True
            txtTotalArea.Visible = True
            lblTotalArea.Location = New Point(64, 229)
            txtTotalArea.Location = New Point(204, 223)

        ElseIf cboVolumeArea.Text = "Volume - Sphere" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblVolume.Visible = True
            txtRadius.Visible = True
            txtVolumes.Visible = True
            lblVolume.Location = New Point(64, 229)
            txtVolumes.Location = New Point(204, 223)

        ElseIf cboVolumeArea.Text = "Curved S. Area - Hemisphere" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblCurvedArea.Visible = True
            txtRadius.Visible = True
            txtCurvedArea.Visible = True
            lblCurvedArea.Location = New Point(64, 229)
            txtCurvedArea.Location = New Point(204, 223)


        ElseIf cboVolumeArea.Text = "Surface Area - Solid Hemisphere" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblTotalArea.Visible = True
            txtRadius.Visible = True
            txtTotalArea.Visible = True
            lblTotalArea.Location = New Point(64, 229)
            txtTotalArea.Location = New Point(204, 223)

        ElseIf cboVolumeArea.Text = "Volume - Hemisphere" Then
            'Clearing 
            lblBase.Visible = False : txtBase.Visible = False
            lblCurvedArea.Visible = False : txtCurvedArea.Visible = False
            lblHeight.Visible = False : txtHeight.Visible = False
            lblLength.Visible = False : txtLength.Visible = False
            lblRadius.Visible = False : txtRadius.Visible = False
            lblTotalArea.Visible = False : txtTotalArea.Visible = False
            lblVolume.Visible = False : txtVolumes.Visible = False
            txtTotalArea.Clear()
            txtBase.Clear()
            txtVolumes.Clear()
            txtCurvedArea.Clear()
            txtHeight.Clear()
            txtLength.Clear()
            txtBreadth.Clear()
            txtRadius.Clear()
            formula.Visible = False
            formula.Clear()

            'Setting
            btnProof.Visible = True
            btnReset.Visible = True
            btnSolve.Visible = True
            lblRadius.Visible = True
            lblVolume.Visible = True
            txtRadius.Visible = True
            txtVolumes.Visible = True
            lblVolume.Location = New Point(64, 229)
            txtVolumes.Location = New Point(204, 223)


        End If
    End Sub


    Private Sub btnSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click

        'selection for cone calculation
        'curved surface area 
        If cboVolumeArea.Text = "Curved S. Area - Cone" Then
            If txtLength.Text = "" Then
                'length empty
                Radius = Val(txtRadius.Text)
                CurvedArea = Val(txtCurvedArea.Text)
                Length = CurvedArea / pi * Radius
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Curved Surface Area= π r l, where r is radius and l is length"
            ElseIf txtRadius.Text = "" Then
                'Radius empty
                Length = Val(txtLength.Text)
                CurvedArea = Val(txtCurvedArea.Text)
                Radius = CurvedArea / pi * Length
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Curved Surface Area= π r l, where r is radius and l is length"

            ElseIf txtCurvedArea.Text = "" Then
                'curved area empty
                Length = Val(txtLength.Text)
                Radius = Val(txtRadius.Text)
                CurvedArea = pi * Length * Radius
                txtCurvedArea.Text = CurvedArea
                txtCurvedArea.ForeColor = Color.Blue : lblCurvedArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Curved Surface Area= π r l, where r is radius and l is length"

            End If

            'Total surface area (solid)
        ElseIf cboVolumeArea.Text = "Total S. Area - Cone (Solid)" Then
            If txtLength.Text = "" Then
                'length empty
                Radius = Val(txtRadius.Text)
                TotalArea = Val(txtTotalArea.Text)
                Length = (TotalArea - pi * (Radius ^ 2)) / pi * Radius
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Solid Cone = π r l + π r ², where r is radius and l is length"

            ElseIf txtRadius.Text = "" Then
                'radius empty
                MsgBox("Enter value for radius, cannot be null", MsgBoxStyle.Critical, "Radius Required")
                txtRadius.Focus()

            ElseIf txtTotalArea.Text = "" Then
                'total surface area empty
                Length = Val(txtLength.Text)
                Radius = Val(txtRadius.Text)
                TotalArea = (pi * Radius * Radius) + (pi * Length * Radius)
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Solid Cone = π r l + π r ², where r is radius and l is length"

            End If

            'Total surface area (hallow)
        ElseIf cboVolumeArea.Text = "Total S. Area - Cone (Hallow)" Then
            If txtLength.Text = "" Then
                'length empty
                Radius = Val(txtRadius.Text)
                TotalArea = Val(txtTotalArea.Text)
                Length = TotalArea / pi * Radius
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Hallow Cone = π r l, where r is radius and l is length"

            ElseIf txtRadius.Text = "" Then
                'Radius empty
                Length = Val(txtLength.Text)
                TotalArea = Val(txtTotalArea.Text)
                Radius = TotalArea / pi * Length
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Hallow Cone = π r l, where r is radius and l is length"

            ElseIf txtTotalArea.Text = "" Then
                'curved area empty
                Length = Val(txtLength.Text)
                Radius = Val(txtRadius.Text)
                TotalArea = pi * Length * Radius
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Hallow Cone = π r l, where r is radius and l is length"
            End If

            'Volume of cone
        ElseIf cboVolumeArea.Text = "Volume - Cone" Then
            If txtHeight.Text = "" Then
                'height empty
                Radius = Val(txtRadius.Text)
                Volumes = Val(txtVolumes.Text)
                HeightObj = 3 * Volumes / (pi * Radius * Radius)
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Cone = 1/3 π r ² h, where r is radius and h is height"
            ElseIf txtRadius.Text = "" Then
                'radius empty
                HeightObj = Val(txtHeight.Text)
                Volumes = Val(txtVolumes.Text)
                Radius = Math.Sqrt(3 * Volumes / pi * HeightObj)
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Cone = 1/3 π r ² h, where r is radius and h is height"

            ElseIf txtVolumes.Text = "" Then
                'volume empty
                HeightObj = Val(txtHeight.Text)
                Radius = Val(txtRadius.Text)
                Volumes = (1 / 3) * pi * HeightObj * Radius * Radius
                txtVolumes.Text = Volumes
                txtVolumes.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Cone = 1/3 π r ² h, where r is radius and h is height"

            End If


            'Selection for cube calculation
            'Total surface area 
        ElseIf cboVolumeArea.Text = "Total S. Area - Cube" Then
            If txtLength.Text = "" Then
                'length empty
                TotalArea = Val(txtTotalArea.Text)
                Length = Math.Sqrt(TotalArea / 6)
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Length (Total surface area) = √(A/6), where A is Total surface area"


            ElseIf txtTotalArea.Text = "" Then
                'total surface area empty
                Length = Val(txtLength.Text)
                TotalArea = 6 * Length * Length
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Cube = 6 L ², where L is length"
            End If

            'Volume of cube
        ElseIf cboVolumeArea.Text = "Volume - Cube" Then
            If txtLength.Text = "" Then
                'length empty
                Volumes = Val(txtVolumes.Text)
                Length = Volumes ^ (1 / 3)
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Length (volume) = ³√ V, where V is volume"

            ElseIf txtVolumes.Text = "" Then
                'volume empty
                Length = Val(txtLength.Text)
                Volumes = (Length ^ 3)
                txtVolumes.Text = Volumes
                txtVolumes.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Cube = L ³, where L is length"

            End If


            'Selection for cuboid calculation
            'Total surface area 
        ElseIf cboVolumeArea.Text = "Total S. Area - Cuboid" Then
            If txtLength.Text = "" Then
                'length empty
                Breadth = Val(txtBreadth.Text)
                HeightObj = Val(txtHeight.Text)
                TotalArea = Val(txtTotalArea.Text)
                Length = (TotalArea - 2 * Breadth * HeightObj) / (2 * HeightObj + 2 * Breadth)
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Cuboid = 2 (LB + BH + LH)"

            ElseIf txtHeight.Text = "" Then
                'height empty
                Length = Val(txtLength.Text)
                TotalArea = Val(txtTotalArea.Text)
                Breadth = Val(txtBreadth.Text)
                HeightObj = (TotalArea - 2 * Breadth * Length) / (2 * Length + 2 * Breadth)
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Cuboid = 2 (LB + BH + LH)"

            ElseIf txtBreadth.Text = "" Then
                'breadth empty
                Length = Val(txtLength.Text)
                HeightObj = Val(txtHeight.Text)
                TotalArea = Val(txtTotalArea.Text)
                Breadth = (TotalArea - 2 * Length * HeightObj) / (2 * HeightObj + 2 * Length)
                txtBreadth.Text = Breadth
                txtBreadth.ForeColor = Color.Blue : lblBreadth.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Cuboid = 2 (LB + BH + LH)"

            ElseIf txtTotalArea.Text = "" Then
                'total surface area empty
                Length = Val(txtLength.Text)
                Breadth = Val(txtBreadth.Text)
                HeightObj = Val(txtHeight.Text)
                TotalArea = 2 * ((Length * HeightObj) + (Length * Breadth) + (Breadth * HeightObj))
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Cuboid = 2 (LB + BH + LH)"
            End If

            'Volume of cuboid
        ElseIf cboVolumeArea.Text = "Volume - Cuboid" Then
            If txtLength.Text = "" Then
                'length empty
                Breadth = Val(txtBreadth.Text)
                HeightObj = Val(txtHeight.Text)
                Volumes = Val(txtVolumes.Text)
                Length = Volumes / (HeightObj * Breadth)
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume = L × B × H"

            ElseIf txtHeight.Text = "" Then
                'height empty
                Length = Val(txtLength.Text)
                Volumes = Val(txtVolumes.Text)
                Breadth = Val(txtBreadth.Text)
                HeightObj = Volumes / (Length * Breadth)
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume = L × B × H"

            ElseIf txtBreadth.Text = "" Then
                'breadth empty
                Length = Val(txtLength.Text)
                HeightObj = Val(txtHeight.Text)
                Volumes = Val(txtVolumes.Text)
                Breadth = Volumes / (HeightObj * Length)
                txtBreadth.Text = Breadth
                txtBreadth.ForeColor = Color.Blue : lblBreadth.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume = L × B × H"

            ElseIf txtVolumes.Text = "" Then
                'volume empty
                Length = Val(txtLength.Text)
                Breadth = Val(txtBreadth.Text)
                HeightObj = Val(txtHeight.Text)
                Volumes = Length * HeightObj * Breadth
                txtVolumes.Text = Volumes
                txtVolumes.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume = L × B × H"
            End If


            'Selection for cylinder calculation
            'Curved surface area
        ElseIf cboVolumeArea.Text = "Curved S. Area - Cylinder" Then
            If txtHeight.Text = "" Then
                'height empty
                Radius = Val(txtRadius.Text)
                CurvedArea = Val(txtCurvedArea.Text)
                HeightObj = CurvedArea / 2 * pi * Radius
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Curved Surface Area= π r l, where r is radius and l is height"
            ElseIf txtRadius.Text = "" Then
                'Radius empty
                HeightObj = Val(txtHeight.Text)
                CurvedArea = Val(txtCurvedArea.Text)
                Radius = CurvedArea / 2 * pi * HeightObj
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Curved Surface Area= π r l, where r is radius and l is height"

            ElseIf txtCurvedArea.Text = "" Then
                'curved area empty
                HeightObj = Val(txtHeight.Text)
                Radius = Val(txtRadius.Text)
                CurvedArea = 2 * pi * HeightObj * Radius
                txtCurvedArea.Text = CurvedArea
                txtCurvedArea.ForeColor = Color.Blue : lblCurvedArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Curved Surface Area= 2 π r h, where r is radius and l is height"

            End If

            'Total surface area (cylinder-closed)
        ElseIf cboVolumeArea.Text = "Total S. Area - Cylinder (Closed)" Then
            If txtHeight.Text = "" Then
                'height empty
                Radius = Val(txtRadius.Text)
                TotalArea = Val(txtTotalArea.Text)
                HeightObj = (TotalArea - 2 * pi * (Radius ^ 2)) / 2 * pi * Radius
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Closed Cylinder = 2 π r ² + 2 π r h , where r is radius and h is height"

            ElseIf txtRadius.Text = "" Then
                'radius empty
                MsgBox("Enter value for radius, cannot be null", MsgBoxStyle.Critical, "Radius Required")
                txtRadius.Focus()

            ElseIf txtTotalArea.Text = "" Then
                'total surface area empty
                HeightObj = Val(txtHeight.Text)
                Radius = Val(txtRadius.Text)
                TotalArea = (pi * Radius * Radius) + (pi * HeightObj * Radius)
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Closed Cylinder = 2 π r ² + 2 π r h , where r is radius and h is height"
            End If

            'Total surface area (closed)
        ElseIf cboVolumeArea.Text = "Total S. Area - Cylinder (Closed)" Then
            If txtHeight.Text = "" Then
                'height empty
                Radius = Val(txtRadius.Text)
                TotalArea = Val(txtTotalArea.Text)
                HeightObj = (TotalArea - pi * (Radius ^ 2)) / pi * Radius
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Closed Cylinder = 2 π r ² + 2 π r h , where r is radius and h is height"

            ElseIf txtRadius.Text = "" Then
                'radius empty
                MsgBox("Enter value for radius, cannot be null", MsgBoxStyle.Critical, "Radius Required")
                txtRadius.Focus()

            ElseIf txtTotalArea.Text = "" Then
                'total surface area empty
                HeightObj = Val(txtHeight.Text)
                Radius = Val(txtRadius.Text)
                TotalArea = (pi * Radius * Radius) + (pi * HeightObj * Radius)
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Closed Cylinder = 2 π r ² + 2 π r h , where r is radius and h is height"
            End If

            'Total surface area (hallow one open)
        ElseIf cboVolumeArea.Text = "Total S. Area - Cylinder (One Open)" Then
            If txtHeight.Text = "" Then
                'height empty
                Radius = Val(txtRadius.Text)
                TotalArea = Val(txtTotalArea.Text)
                HeightObj = (TotalArea - pi * (Radius ^ 2)) / 2 * pi * Radius
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Hallow Cylinder = π r ² + 2 π r h , where r is radius and h is height"

            ElseIf txtRadius.Text = "" Then
                'radius empty
                MsgBox("Enter value for radius, cannot be null", MsgBoxStyle.Critical, "Radius Required")
                txtRadius.Focus()

            ElseIf txtTotalArea.Text = "" Then
                'total surface area empty
                HeightObj = Val(txtHeight.Text)
                Radius = Val(txtRadius.Text)
                TotalArea = (pi * Radius * Radius) + (2 * pi * HeightObj * Radius)
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Hallow Cylinder =  π r ² + 2 π r h , where r is radius and h is height"
            End If

            'Total surface area (hallow both open)
        ElseIf cboVolumeArea.Text = "Total S. Area - Cylinder (Both Open)" Then
            If txtHeight.Text = "" Then
                'height empty
                Radius = Val(txtRadius.Text)
                TotalArea = Val(txtTotalArea.Text)
                HeightObj = TotalArea / (2 * pi * Radius)
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Hallow Cylinder = 2 π r h, where r is radius and h is height"

            ElseIf txtRadius.Text = "" Then
                'radius empty
                MsgBox("Enter value for radius, cannot be null", MsgBoxStyle.Critical, "Radius Required")
                txtRadius.Focus()

            ElseIf txtTotalArea.Text = "" Then
                'total surface area empty
                HeightObj = Val(txtHeight.Text)
                Radius = Val(txtRadius.Text)
                TotalArea = (2 * pi * Radius * HeightObj)
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area of Hallow Cylinder = 2 π r h, where r is radius and h is height"

            End If

            'Volume cylinder
        ElseIf cboVolumeArea.Text = "Volume - Cylinder" Then
            If txtHeight.Text = "" Then
                'height empty
                Radius = Val(txtRadius.Text)
                Volumes = Val(txtVolumes.Text)
                HeightObj = Volumes / (pi * Radius ^ 2)
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Cylinder = π r ² h, where r is radius and h is height"

            ElseIf txtRadius.Text = "" Then
                'radius empty
                HeightObj = Val(txtHeight.Text)
                Volumes = Val(txtVolumes.Text)
                Radius = Math.Sqrt(Volumes / (pi * HeightObj))
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Cylinder = π r ² h, where r is radius and h is height"

            ElseIf txtVolumes.Text = "" Then
                'volume empty
                HeightObj = Val(txtHeight.Text)
                Radius = Val(txtRadius.Text)
                Volumes = (pi * Radius ^ 2 * HeightObj)
                txtVolumes.Text = Volumes
                txtVolumes.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Cylinder = π r ² h, where r is radius and h is height"

            End If


            'Selection for prism calculation
            'Volume prism
        ElseIf cboVolumeArea.Text = "Volume - Prism" Then
            If txtLength.Text = "" Then
                'length empty
                Base = Val(txtBase.Text)
                Volumes = Val(txtVolumes.Text)
                Length = Volumes / Base
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Prism = Area of Cross Section × Length"

            ElseIf txtBase.Text = "" Then
                'base empty
                Length = Val(txtLength.Text)
                Volumes = Val(txtVolumes.Text)
                Base = Volumes / Length
                txtBase.Text = Base
                txtBase.ForeColor = Color.Blue : lblBase.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Prism = Area of Cross Section × Length"

            ElseIf txtVolumes.Text = "" Then
                'volume empty
                Length = Val(txtLength.Text)
                Base = Val(txtBase.Text)
                Volumes = Base * Length
                txtVolumes.Text = Volumes
                txtVolumes.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Prism = Area of Cross Section × Length"

            End If


            'Selection for pyramid calculation
            'total surface area pyramid
        ElseIf cboVolumeArea.Text = "Total S. Area - Pyramid" Then
            If txtLength.Text = "" Then
                'Triangular faces empty
                Base = Val(txtBase.Text)
                TotalArea = Val(txtTotalArea.Text)
                Length = TotalArea - Base
                txtLength.Text = Length
                txtLength.ForeColor = Color.Blue : lblLength.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area = Area of Polygon base + Area of Triangular faces"

            ElseIf txtBase.Text = "" Then
                'base empty
                Length = Val(txtLength.Text)
                TotalArea = Val(txtTotalArea.Text)
                Base = TotalArea - Length
                txtBase.Text = Base
                txtBase.ForeColor = Color.Blue : lblBase.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area = Area of Polygon base + Area of Triangular faces"

            ElseIf txtTotalArea.Text = "" Then
                'total surface area empty
                Length = Val(txtLength.Text)
                Base = Val(txtBase.Text)
                TotalArea = Base + Length
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Total Surface Area = Area of Polygon base + Area of Triangular faces"

            End If

            'Volume pyramid
        ElseIf cboVolumeArea.Text = "Volume - Pyramid" Then
            If txtHeight.Text = "" Then
                'height empty
                Base = Val(txtBase.Text)
                Volumes = Val(txtVolumes.Text)
                HeightObj = 3 * Volumes / Base
                txtHeight.Text = HeightObj
                txtHeight.ForeColor = Color.Blue : lblHeight.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Pyramid = 1/3 × Area of Base × height"

            ElseIf txtBase.Text = "" Then
                'base empty
                HeightObj = Val(txtHeight.Text)
                Volumes = Val(txtVolumes.Text)
                Base = 3 * Volumes / HeightObj
                txtBase.Text = Base
                txtBase.ForeColor = Color.Blue : lblBase.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Pyramid = 1/3 × Area of Base × height"

            ElseIf txtVolumes.Text = "" Then
                'volume empty
                HeightObj = Val(txtHeight.Text)
                Base = Val(txtBase.Text)
                Volumes = (1 / 3) * Base * HeightObj
                txtVolumes.Text = Volumes
                txtVolumes.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Pyramid = 1/3 × Area of Base × height"

            End If


            'Selection for sphere calculation
            'surface area of sphere
        ElseIf cboVolumeArea.Text = "Surface Area - Sphere" Then

            If txtRadius.Text = "" Then
                'radius empty
                TotalArea = Val(txtTotalArea.Text)
                Radius = Math.Sqrt(TotalArea / (4 * pi))
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Surface Area of Sphere = 4 π r ², where r is radius"

            ElseIf txtTotalArea.Text = "" Then
                'surface area empty
                Radius = Val(txtRadius.Text)
                TotalArea = (4 * pi * Radius ^ 2)
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Surface Area of Sphere = 4 π r ², where r is radius"

            End If

            'volume of sphere
        ElseIf cboVolumeArea.Text = "Volume - Sphere" Then

            If txtRadius.Text = "" Then
                'radius empty
                Volumes = Val(txtVolumes.Text)
                Radius = (3 * Volumes / (4 * pi)) ^ (1 / 3)
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Sphere = 4/3 π r ³, where r is radius"

            ElseIf txtVolumes.Text = "" Then
                'volume empty
                Radius = Val(txtRadius.Text)
                Volumes = (4 / 3 * pi * (Radius ^ 3))
                txtVolumes.Text = Volumes
                txtVolumes.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Sphere = 4/3 π r ³, where r is radius"

            End If

            'volume of hemisphere
        ElseIf cboVolumeArea.Text = "Volume - Hemisphere" Then

            If txtRadius.Text = "" Then
                'radius empty
                Volumes = Val(txtVolumes.Text)
                Radius = (3 * Volumes / (2 * pi)) ^ (1 / 3)
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Hemisphere = 2/3 π r ³, where r is radius"

            ElseIf txtVolumes.Text = "" Then
                'volume empty
                Radius = Val(txtRadius.Text)
                Volumes = (2 / 3 * pi * (Radius ^ 3))
                txtVolumes.Text = Volumes
                txtVolumes.ForeColor = Color.Blue : lblVolume.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Volume of Hemisphere = 2/3 π r ³, where r is radius"

            End If

            'curved surface area of hemisphere
        ElseIf cboVolumeArea.Text = "Curved S. Area - Hemisphere" Then

            If txtRadius.Text = "" Then
                'radius empty
                CurvedArea = Val(txtCurvedArea.Text)
                Radius = Math.Sqrt(CurvedArea / (2 * pi))
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Curved Surface Area of Hemisphere = 2 π r ², where r is radius"

            ElseIf txtCurvedArea.Text = "" Then
                'curved surface area empty
                Radius = Val(txtRadius.Text)
                CurvedArea = (2 * pi * (Radius ^ 2))
                txtCurvedArea.Text = CurvedArea
                txtCurvedArea.ForeColor = Color.Blue : lblCurvedArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Curved Surface Area of Hemisphere = 2 π r ², where r is radius"

            End If
            'Surface area of solid hemisphere
        ElseIf cboVolumeArea.Text = "Surface Area - Solid Hemisphere" Then

            If txtRadius.Text = "" Then
                'radius empty
                TotalArea = Val(txtTotalArea.Text)
                Radius = Math.Sqrt(TotalArea / (3 * pi))
                txtRadius.Text = Radius
                txtRadius.ForeColor = Color.Blue : lblRadius.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Surface Area of Solid Hemisphere = 3 π r ², where r is radius"

            ElseIf txtTotalArea.Text = "" Then
                'Surface area empty
                Radius = Val(txtRadius.Text)
                TotalArea = (3 * pi * (Radius ^ 2))
                txtTotalArea.Text = TotalArea
                txtTotalArea.ForeColor = Color.Blue : lblTotalArea.ForeColor = Color.Blue
                formula.Visible = True
                formula.Text = "Surface Area of Solid Hemisphere = 3 π r ², where r is radius"

            End If
        End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblCurvedArea.ForeColor = Color.Black
        lblBase.ForeColor = Color.Black
        lblBreadth.ForeColor = Color.Black
        lblTotalArea.ForeColor = Color.Black
        lblHeight.ForeColor = Color.Black
        lblLength.ForeColor = Color.Black
        lblRadius.ForeColor = Color.Black
        lblVolume.ForeColor = Color.Black

        txtCurvedArea.ForeColor = Color.Black
        txtBase.ForeColor = Color.Black
        txtBreadth.ForeColor = Color.Black
        txtTotalArea.ForeColor = Color.Black
        txtHeight.ForeColor = Color.Black
        txtLength.ForeColor = Color.Black
        txtRadius.ForeColor = Color.Black
        txtVolumes.ForeColor = Color.Black

        txtTotalArea.Clear()
        txtBase.Clear()
        txtVolumes.Clear()
        txtCurvedArea.Clear()
        txtHeight.Clear()
        txtLength.Clear()
        txtBreadth.Clear()
        txtRadius.Clear()

        formula.Clear()
        formula.Visible = False
        'Me.Size = New Size(306, 380)


    End Sub
End Class