Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
'Imports System.Data.SqlClient

Public Class PersonalInfo
    Public ds As New DataSet
    Dim strSQL As String
    Public dr As MySqlDataReader

    Public dsFBackground As New DataSet
    Public strSQLFBackground As String
    Public drFBackground As MySqlDataReader

    Public dsChild As New DataSet
    Public strSQLChild As String
    Public drChild As MySqlDataReader
    Public cmdChild As New MySqlCommand

    Public dsEduc As New DataSet
    Public strSQLEduc As String
    Public drEduc As MySqlDataReader
    Public cmdEduc As MySqlCommand

    Public dsCivil As New DataSet
    Public strSQLCivil As String
    Public drCivil As MySqlDataReader
    Public cmdCivil As New MySqlCommand

    Public dsWork As New DataSet
    Public strSQLWork As String
    Public drWork As MySqlDataReader
    Public cmdWork As New MySqlCommand

    Public dsTraining As New DataSet
    Public strSQLTraining As String
    Public drTraining As MySqlDataReader
    Public cmdTraining As New MySqlCommand

    Public dsVoluntary As New DataSet
    Public strSQLVoluntary As String
    Public drVoluntary As MySqlDataReader
    Public cmdVoluntary As New MySqlCommand

    Public dsRef As New DataSet
    Public strSQLRef As String
    Public drRef As MySqlDataReader
    Public cmdRef As New MySqlCommand


    Public dsOthers As New DataSet
    Public strSQLOthers As String
    Public drOthers As MySqlDataReader
    Public cmdOthers As New MySqlCommand

    Public dsPos As New DataSet
    Public strSQLPos As String
    Public drPos As MySqlDataReader
    Public cmdPos As New MySqlCommand

    Public dsQuestion As New DataSet
    Public strSQLQuestion As String
    Public drQuestion As MySqlDataReader
    Public cmdQuestion As New MySqlCommand

    Public dv As DataView

    Public pNav As Integer
    Public MaxRow As Integer
    Public temp As Integer

    Public FamilyBGCount As Integer
    Public QSave As Integer
    Public Permanent As String

    Private Sub cmdNewSave_Click(sender As Object, e As EventArgs) Handles cmdNewSave.Click
        On Error Resume Next

        Dim sql As String
        Dim strSQL As String
        Dim sex As String
        Dim stat As String

        If txtEmpNo.Text = "" Then
            MsgBox("Employee Number is empty.")
            txtEmpNo.Focus()
            Exit Sub
        End If

        If IsNumeric(txtAllowance.Text) = False Then
            MsgBox("Invalid input")
            txtAllowance.Focus()
            Exit Sub
        End If

        If txtSurname.Text = "" Then
            MsgBox("Surname is empty.")
            txtSurname.Focus()
            Exit Sub
        End If
        If txtFirstName.Text = "" Then
            MsgBox("First Name is empty.")
            txtFirstName.Focus()
            Exit Sub
        End If
        If txtMiddleName.Text = "" Then
            MsgBox("Middle Name is empty.")
            txtMiddleName.Focus()
            Exit Sub
        End If
        CONNECTION.Open()

        If cmdNewSave.Text = "New Record" Then
            grpPersonal.Enabled = True
            grpPersonal2.Enabled = True
            grTop.Enabled = True
            cmdNewSave.Text = "Save Record"
            cmdUpdateCancel.Text = "Cancel"
            TabPage2.Enabled = False
            TabPage3.Enabled = False
            TabPage4.Enabled = False
            TabPage5.Enabled = False
            TabPage6.Enabled = False
            TabPage7.Enabled = False
            btnAction = 2
            ClearText()

        ElseIf cmdNewSave.Text = "Save Record" Then
            '

            If optMale.Checked = True Then
                sex = "Male"
            Else
                sex = "Female"
            End If
            If chkStatus.Checked = True Then
                stat = 1
            Else
                stat = 0
            End If

            Dim check1, check2, opt1 As String
            If cbFilipino.Checked = True Then
                check1 = "1"
            Else
                check1 = "0"
            End If

            If cbDual.Checked = True Then
                check2 = "1"
            Else
                check2 = "0"
            End If

            If rbByBirth.Checked = True Then
                opt1 = "ByBirth"
            ElseIf rbByNaturalization.Checked = True Then
                opt1 = "ByNaturalization"
            End If

            Dim Retired As String
            If cbRetired.Checked = True Then
                Retired = dtpRetired.Text
            Else
                Retired = ""
            End If

            Dim Citizen As String = check1 & "," & check2 & "," & opt1 & "," & txtCitizen.Text

            Dim Residential As String = txtRAddress.Text & ", " & txtRStreet.Text & _
                ", " & txtRSubdivision.Text & ", " & txtRBarangay.Text & _
                ", " & txtRCity.Text & ", " & txtRProvince.Text

            Dim Permanents As String = txtPAddress.Text & ", " & txtPStreet.Text & _
                ", " & txtPSubdivision.Text & ", " & txtPBarangay.Text & _
                ", " & txtPCity.Text & ", " & txtPProvince.Text

            If btnAction = 1 Then
                sql = "UPDATE tbl_employees SET empno ='" & txtEmpNo.Text & "', BioID='" & TextBox1.Text & "', surname='" & txtSurname.Text & _
                    "', firstname='" & txtFirstName.Text & _
                    "', mi='" & txtMiddleName.Text & _
                    "', nextension='" & txtExtension.Text & _
                    "', birthdate='" & dtDOB.Text & _
                    "', datehired='" & dtHired.Text & _
                    "', pofbirth='" & txtPOB.Text & _
                    "', gender='" & sex & _
                    "', civilstatus='" & cbCivilStatus.Text & _
                    "', citizenship='" & Citizen & _
                    "', height='" & txtHeight.Text & _
                    "', weight='" & txtWeight.Text & _
                    "', bloodtype='" & txtBlood.Text & _
                    "', raddress='" & Residential & _
                    "', zipcode='" & txtRZIPCode.Text & _
                    "', telephone='" & txtRTel.Text & _
                    "', paddress='" & Permanents & _
                    "', zipcode2='" & txtPZIPCode.Text & _
                    "', telephone2='" & txtPTel.Text & _
                    "', gsisno = '" & txtGSIS.Text & _
                    "', pagibigno = '" & txtPagibig.Text & _
                    "', philhealthno = '" & txtPhilhealth.Text & _
                    "', sssno = '" & txtSSS.Text & _
                    "', email = '" & txtEmail.Text & _
                    "', cellphone='" & txtCP.Text & _
                    "', tin='" & txtTINNo.Text & _
                    "', poscode ='" & cbDesignation.Text & _
                    "', permanent = '" & Permanent & _
                    "', Status = '" & stat & _
                    "', DateResigned = '" & Retired & _
                    "', AMIN = '" & mtxtAMIN.Text & _
                    "', AMOUT = '" & mtxtAMOUT.Text & _
                    "', PMIN = '" & mtxtPMIN.Text & _
                    "', PMOUT = '" & mtxtPMOUT.Text & _
                    "', TIMEALLOWANCE = '" & txtAllowance.Text & _
                    "', Pic= @image_data " & _
                    " WHERE empno = '" & txtHEmpNo.Text & "'"
            ElseIf btnAction = 2 Then
                strSQL = "Select * from tbl_employees where empno like '%" & txtEmpNo.Text.ToString & "%'"
                Dim recDA As New MySqlDataAdapter(strSQL, CONNECTION)
                Dim recDS As New DataSet
                Dim rec As Integer
                recDA.Fill(recDS, "Search")
                rec = recDS.Tables("Search").Rows.Count

                If rec <> 0 Then
                    MsgBox("ID No. : " & txtEmpNo.Text & ". Already exist!!!")
                    txtEmpNo.Focus()
                    CONNECTION.Close()
                    Exit Sub
                Else
                    sql = "INSERT INTO tbl_employees SET empno='" & txtEmpNo.Text & _
                        "', BioID='" & TextBox1.Text & "', surname='" & txtSurname.Text & _
                        "', firstname='" & txtFirstName.Text & _
                        "', mi='" & txtMiddleName.Text & _
                        "', nextension='" & txtExtension.Text & _
                        "', datehired='" & dtHired.Text & _
                        "', birthdate='" & dtDOB.Text & _
                        "', pofbirth='" & txtPOB.Text & _
                        "', gender='" & sex & _
                        "', civilstatus='" & cbCivilStatus.Text & _
                        "', citizenship='" & Citizen & _
                        "', height='" & txtHeight.Text & _
                        "', weight='" & txtWeight.Text & _
                        "', bloodtype='" & txtBlood.Text & _
                        "', raddress='" & Residential & _
                        "', zipcode='" & txtRZIPCode.Text & _
                        "', telephone='" & txtRTel.Text & _
                        "', paddress='" & Permanents & _
                        "', zipcode2='" & txtPZIPCode.Text & _
                        "', telephone2='" & txtPTel.Text & _
                        "', gsisno = '" & txtGSIS.Text & _
                        "', pagibigno = '" & txtPagibig.Text & _
                        "', philhealthno = '" & txtPhilhealth.Text & _
                        "', sssno = '" & txtSSS.Text & _
                        "', email = '" & txtEmail.Text & _
                        "', cellphone='" & txtCP.Text & _
                        "', poscode ='" & cbDesignation.Text & _
                        "', permanent = '" & Permanent & _
                        "', tin='" & txtTINNo.Text & _
                        "', Status = '" & stat & _
                        "', DateResigned = '" & Retired & _
                        "', AMIN = '" & mtxtAMIN.Text & _
                        "', AMOUT = '" & mtxtAMOUT.Text & _
                        "', PMIN = '" & mtxtPMIN.Text & _
                        "', PMOUT = '" & mtxtPMOUT.Text & _
                    "', TIMEALLOWANCE = '" & txtAllowance.Text & _
                        "', Pic= @image_data"
                End If
            End If
            Dim mstream As New System.IO.MemoryStream()
            empPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()

            Dim SqlCommand As New MySqlCommand
            Dim Count As Integer
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql
            SqlCommand.Parameters.AddWithValue("@image_data", arrImage)


            Count = SqlCommand.ExecuteNonQuery()

            If Count = 0 Then
                MsgBox("no record found")
                CONNECTION.Close()
                Exit Sub
            Else
                MsgBox(Count & " records updated")
                'Button9_Click()
            End If
            'CONNECTION.Close()

            grpPersonal.Enabled = False
            grpPersonal2.Enabled = False
            grTop.Enabled = False
            TabPage2.Enabled = True
            TabPage3.Enabled = True
            TabPage4.Enabled = True
            TabPage5.Enabled = True
            TabPage6.Enabled = True
            TabPage7.Enabled = True
            cmdNewSave.Text = "New Record"
            cmdUpdateCancel.Text = "Update Record"
            btnAction = 0
            End If
            CONNECTION.Close()
    End Sub
    'Enable Update in Personal Info
    Private Sub cmdUpdateCancel_Click(sender As Object, e As EventArgs) Handles cmdUpdateCancel.Click
        If cmdUpdateCancel.Text = "Update Record" Then
            callPersonalInfo()
            TabPage2.Enabled = False
            TabPage3.Enabled = False
            TabPage4.Enabled = False
            TabPage5.Enabled = False
            TabPage6.Enabled = False
            TabPage7.Enabled = False
            grpPersonal.Enabled = True
            grpPersonal2.Enabled = True
            grTop.Enabled = True

            If cbDual.Checked = True Then
                rbByBirth.Enabled = True
                rbByNaturalization.Enabled = True
                txtCitizen.Enabled = True
            Else
                rbByBirth.Enabled = False
                rbByNaturalization.Enabled = False
                txtCitizen.Enabled = False

                rbByBirth.Checked = False
                rbByNaturalization.Checked = False
                txtCitizen.Text = ""
            End If

            cmdNewSave.Text = "Save Record"
            cmdUpdateCancel.Text = "Cancel"
            btnAction = 1
        ElseIf cmdUpdateCancel.Text = "Cancel" Then
            TabPage2.Enabled = True
            TabPage3.Enabled = True
            TabPage4.Enabled = True
            TabPage5.Enabled = True
            TabPage6.Enabled = True
            TabPage7.Enabled = True

            'txtEmpNo.Enabled = False
            grpPersonal.Enabled = False
            grpPersonal2.Enabled = False
            grTop.Enabled = False
            cmdNewSave.Text = "New Record"
            cmdUpdateCancel.Text = "Update Record"
            If btnAction = 2 Then
                strSQL = "Select * from tbl_employees order by empno"
                callPersonalInfo()
                txtTotNum.Text = pNav + 1 & " of " & MaxRow
            End If
            btnAction = 0
        End If
    End Sub
    'End
    Private Sub ClearText()
        Me.optYes.Select()
        Me.cbDesignation.Text = ""
        Me.txtTINNo.Text = ""
        Me.txtCP.Text = "N/A"
        Me.txtEmail.Text = ""
        Me.txtPTel.Text = "N/A"
        Me.txtPZIPCode.Text = ""
        'Me.txtPAddress.Text = ""
        'Me.txtRTel.Text = "N/A"
        Me.txtRZIPCode.Text = ""
        'Me.txtRAddress.Text = ""
        Me.txtBlood.Text = ""
        Me.txtWeight.Text = ""
        Me.txtHeight.Text = ""
        Me.txtCitizen.Text = ""
        Me.cbCivilStatus.Text = ""
        Me.optMale.Select()
        Me.txtPOB.Text = ""
        Me.dtDOB.Text = Now
        Me.txtExtension.Text = "N/A"
        Me.txtMiddleName.Text = ""
        Me.txtFirstName.Text = ""
        Me.txtSurname.Text = ""
        txtPAddress.Text = ""
        txtPStreet.Text = ""
        txtPSubdivision.Text = ""
        txtPBarangay.Text = ""
        txtPCity.Text = ""
        txtPProvince.Text = ""
        txtRAddress.Text = ""
        txtRStreet.Text = ""
        txtRSubdivision.Text = ""
        txtRBarangay.Text = ""
        txtRCity.Text = ""
        txtRProvince.Text = ""
        'Me.txtEmpNo.Text = ""
        Me.txtGSIS.Text = "N/A"
        Me.txtPagibig.Text = "N/A"
        Me.txtPhilhealth.Text = "N/A"
        Me.txtSSS.Text = "N/A"
        Me.TextBox1.Text = ""
        Me.chkStatus.Checked = True
        cbFilipino.Checked = True
        txtEmpNo.Enabled = True

        rbByBirth.Enabled = False
        rbByNaturalization.Enabled = False
        txtCitizen.Enabled = False

        rbByBirth.Checked = False
        rbByNaturalization.Checked = False



        'cbDesignation.Enabled = True
    End Sub



    Private Sub FillData()
        'On Error Resume Next
        Dim arrImage() As Byte

        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
        da.Fill(ds, "PersonalInfo")
        On Error Resume Next
        With ds.Tables("PersonalInfo").Rows(pNav)
            Me.txtTINNo.Text = IIf(Not IsDBNull(.Item("tin")), .Item("tin"), "")
            Me.txtCP.Text = IIf(Not IsDBNull(.Item("cellphone")), .Item("cellphone"), "")
            Me.txtEmail.Text = IIf(Not IsDBNull(.Item("email")), .Item("email"), "")
            Me.txtGSIS.Text = IIf(Not IsDBNull(.Item("gsisno")), .Item("gsisno"), "")
            Me.txtPagibig.Text = IIf(Not IsDBNull(.Item("pagibigno")), .Item("pagibigno"), "")
            Me.txtPhilhealth.Text = IIf(Not IsDBNull(.Item("philhealthno")), .Item("philhealthno"), "")
            Me.txtSSS.Text = IIf(Not IsDBNull(.Item("sssno")), .Item("sssno"), "")
            Me.txtPTel.Text = IIf(Not IsDBNull(.Item("telephone2")), .Item("telephone2"), "")
            Me.txtPZIPCode.Text = IIf(Not IsDBNull(.Item("zipcode2")), .Item("zipcode2"), "")

            ' Split the Permanent Address
            Dim sPermanent As String
            sPermanent = IIf(Not IsDBNull(.Item("paddress")), .Item("paddress"), "")
            If sPermanent <> "" Then
                Dim fieldsPermanent() As String

                fieldsPermanent = Split(sPermanent, ",")
                txtPAddress.Text = IIf(Trim$(fieldsPermanent(0)) <> "", Trim$(fieldsPermanent(0)), "")
                txtPStreet.Text = IIf(Trim$(fieldsPermanent(1)) <> "", Trim$(fieldsPermanent(1)), "")
                txtPSubdivision.Text = IIf(Trim$(fieldsPermanent(2)) <> "", Trim$(fieldsPermanent(2)), "")
                txtPBarangay.Text = IIf(Trim$(fieldsPermanent(3)) <> "", Trim$(fieldsPermanent(3)), "")
                txtPCity.Text = IIf(Trim$(fieldsPermanent(4)) <> "", Trim$(fieldsPermanent(4)), "")
                txtPProvince.Text = IIf(Trim$(fieldsPermanent(5)) = "", "", Trim$(fieldsPermanent(5)))
                'end split
            Else
                txtPAddress.Text = ""
                txtPStreet.Text = ""
                txtPSubdivision.Text = ""
                txtPBarangay.Text = ""
                txtPCity.Text = ""
                txtPProvince.Text = ""
            End If
            'Me.txtPAddress.Text = IIf(Not IsDBNull(.Item("paddress")), .Item("paddress"), "")
            'Me.txtRTel.Text = IIf(Not IsDBNull(.Item("telephone")), .Item("telephone"), "")
            Me.txtRZIPCode.Text = IIf(Not IsDBNull(.Item("zipcode")), .Item("zipcode"), "")


            ' Split the Residential Address
            Dim sResidential As String
            sResidential = IIf(Not IsDBNull(.Item("raddress")), .Item("raddress"), "")
            If sResidential <> "" Then
                Dim fieldsResidentials() As String

                fieldsResidentials = Split(sResidential, ",")
                txtRAddress.Text = IIf(Trim$(fieldsResidentials(0)) <> "", Trim$(fieldsResidentials(0)), "")
                txtRStreet.Text = IIf(Trim$(fieldsResidentials(1)) <> "", Trim$(fieldsResidentials(1)), "")
                txtRSubdivision.Text = IIf(Trim$(fieldsResidentials(2)) <> "", Trim$(fieldsResidentials(2)), "")
                txtRBarangay.Text = IIf(Trim$(fieldsResidentials(3)) <> "", Trim$(fieldsResidentials(3)), "")
                txtRCity.Text = IIf(Trim$(fieldsResidentials(4)) <> "", Trim$(fieldsResidentials(4)), "")
                txtRProvince.Text = IIf(Trim$(fieldsResidentials(5)) <> "", Trim$(fieldsResidentials(5)), "")
                'end split
            Else
                txtRAddress.Text = ""
                txtRStreet.Text = ""
                txtRSubdivision.Text = ""
                txtRBarangay.Text = ""
                txtRCity.Text = ""
                txtRProvince.Text = ""
            End If

            Me.txtBlood.Text = IIf(Not IsDBNull(.Item("bloodtype")), .Item("bloodtype"), "")
            Me.txtWeight.Text = IIf(Not IsDBNull(.Item("weight")), .Item("weight"), "")
            Me.txtHeight.Text = IIf(Not IsDBNull(.Item("height")), .Item("height"), "")

            'split Citizen
            Dim sCitizen As String
            sCitizen = IIf(Not IsDBNull(.Item("citizenship")), .Item("citizenship"), "")

            Dim fieldsCitizen() As String

            fieldsCitizen = Split(sCitizen, ",")
            If Trim$(fieldsCitizen(0)) = "1" Then
                cbFilipino.Checked = True
            End If
            If Trim$(fieldsCitizen(1)) = "1" Then
                cbDual.Checked = True
                If Trim$(fieldsCitizen(2)) = "ByBirth" Then
                    rbByBirth.Checked = True
                ElseIf Trim$(fieldsCitizen(2)) = "ByNaturalization" Then
                    rbByNaturalization.Checked = True
                End If
                txtCitizen.Text = Trim$(fieldsCitizen(3))
            Else
                cbDual.Checked = False
                rbByBirth.Checked = False
                rbByNaturalization.Checked = False
                txtCitizen.Text = ""
            End If
            'end split

            'Me.txtCitizen.Text = IIf(Not IsDBNull(.Item("citizenship")), .Item("citizenship"), "")
            Me.cbCivilStatus.Text = IIf(Not IsDBNull(.Item("civilstatus")), .Item("civilstatus"), "")
            Me.cbDesignation.Text = IIf(Not IsDBNull(.Item("poscode")), .Item("poscode"), "")

            If .Item("gender") = "Male" Then
                Me.optMale.Select()
            Else
                Me.optFemale.Select()
            End If
            If .Item("permanent") = "Yes" Then
                Me.optYes.Select()
            Else
                Me.optNo.Select()
            End If

            If .Item("Status") = 1 Then
                Me.chkStatus.Checked = True
            Else
                Me.chkStatus.Checked = False
            End If

            arrImage = .Item("Pic")
            If arrImage.Length = 0 Then
                Me.empPic.ImageLocation = "D:\BFAR Automated System\BFARAutomatedSystem\Picture\blank.jpeg"
            Else
                Dim mstream As New System.IO.MemoryStream(arrImage)
                empPic.Image = Image.FromStream(mstream)
            End If

            Me.txtPOB.Text = IIf(Not IsDBNull(.Item("pofbirth")), .Item("pofbirth"), "")
            Me.dtDOB.Text = IIf(Not IsDBNull(.Item("birthdate")), .Item("birthdate"), "")
            Me.dtHired.Text = IIf(Not IsDBNull(.Item("datehired")), .Item("datehired"), "")
            Me.txtExtension.Text = IIf(Not IsDBNull(.Item("nextension")), .Item("nextension"), "")
            Me.txtMiddleName.Text = IIf(Not IsDBNull(.Item("mi")), .Item("mi"), "")
            Me.txtFirstName.Text = IIf(Not IsDBNull(.Item("firstname")), .Item("firstname"), "")
            Me.txtSurname.Text = IIf(Not IsDBNull(.Item("surname")), .Item("surname"), "")
            Me.txtEmpNo.Text = IIf(Not IsDBNull(.Item("empno")), .Item("empno"), "")
            Me.TextBox1.Text = IIf(Not IsDBNull(.Item("BioID")), .Item("BioID"), "")
            Me.txtHEmpNo.Text = IIf(Not IsDBNull(.Item("empno")), .Item("empno"), "")
            Me.mtxtAMIN.Text = IIf(Not IsDBNull(.Item("AMIN")), .Item("AMIN"), "")
            Me.mtxtAMOUT.Text = IIf(Not IsDBNull(.Item("AMOUT")), .Item("AMOUT"), "")
            Me.mtxtPMIN.Text = IIf(Not IsDBNull(.Item("PMIN")), .Item("PMIN"), "")
            Me.mtxtPMOUT.Text = IIf(Not IsDBNull(.Item("PMOUT")), .Item("PMOUT"), "")
            Me.txtAllowance.Text = IIf(Not IsDBNull(.Item("TIMEALLOWANCE")), .Item("TIMEALLOWANCE"), "")

            If IIf(Not IsDBNull(.Item("DateResigned")), .Item("DateResigned"), "") = "" Then
                cbRetired.Checked = False
            Else
                cbRetired.Checked = True
                dtpRetired.Text = IIf(Not IsDBNull(.Item("DateResigned")), .Item("DateResigned"), "")
            End If

        End With
        MaxRow = ds.Tables("personalInfo").Rows.Count
        da.Dispose()
        ds.Clear()
        txtTotNum.Text = pNav + 1 & " of " & MaxRow
        'CONNECTION.Close()
    End Sub

    Public Sub callPersonalInfo()
        CONNECTION.Open()
        FillData()
        callFBackground()
        callChild()
        callEducation()
        callCivilService()
        callWorkExperience()
        callTainings()
        callVoluntary()
        callOthers()
        callQuestion()
        callReference()
        CONNECTION.Close()
        TabPage2.Enabled = True
        TabPage3.Enabled = True
        TabPage4.Enabled = True
        TabPage5.Enabled = True
        TabPage6.Enabled = True
        TabPage1.Enabled = True

        If MaxRow > 1 Then
            cmdRefresh.Visible = False
        Else
            cmdRefresh.Visible = True
        End If

    End Sub

    'Display Employee  Information in a FORM
    '-------------------------------------------------
    Private Sub callFBackground()
        On Error Resume Next
        strSQLFBackground = "SELECT * from tbl_emp_fbackground where empno='" & txtEmpNo.Text & "' order by empno"
        'CONNECTION.Open()
        Dim daFBackground As New MySqlDataAdapter(strSQLFBackground, CONNECTION)

        daFBackground.Fill(dsFBackground, "FBackground")
        FamilyBGCount = dsFBackground.Tables("FBackground").Rows.Count
        If FamilyBGCount = 0 Then
            txtSSurname.Text = "N/A"
            txtSFirstName.Text = "N/A"
            txtSMiddleName.Text = "N/A"
            txtSExtension.Text = "N/A"
            txtSOccupation.Text = "N/A"
            txtSEmployer.Text = "N/A"
            txtSEmpAddress.Text = "N/A"
            txtSTelNo.Text = "N/A"
            txtFSurname.Text = "N/A"
            txtFFirstName.Text = "N/A"
            txtFMiddleName.Text = "N/A"
            txtFExtension.Text = "N/A"
            txtMMaiden.Text = "N/A"
            txtMSurname.Text = "N/A"
            txtMFirstName.Text = "N/A"
            txtMMiddleName.Text = "N/A"
        Else
            With dsFBackground.Tables("FBackground").Rows(0)
                txtSSurname.Text = .Item("ssname")
                txtSFirstName.Text = .Item("sfirstname")
                txtSMiddleName.Text = .Item("smi")
                txtSExtension.Text = .Item("sextension")
                txtSOccupation.Text = .Item("soccupation")
                txtSEmployer.Text = .Item("sbname")
                txtSEmpAddress.Text = .Item("sbaddress")
                txtSTelNo.Text = .Item("stelephone")
                txtFSurname.Text = .Item("fsname")
                txtFFirstName.Text = .Item("ffirstname")
                txtFMiddleName.Text = .Item("fmi")
                txtFExtension.Text = .Item("fextension")
                txtMMaiden.Text = .Item("mmname")
                txtMSurname.Text = .Item("msname")
                txtMFirstName.Text = .Item("mmfirstname")
                txtMMiddleName.Text = .Item("mmi")
            End With
        End If
        daFBackground.Dispose()
        dsFBackground.Reset()
        'CONNECTION.Close()
    End Sub
    Private Sub callChild()
        'On Error Resume Next
        Dim i As Integer
        strSQLChild = "SELECT * from tbl_child where empno = '" & txtEmpNo.Text & "'order by DateOfBirth"
        'CONNECTION.Open()
        cmdChild = New MySqlCommand(strSQLChild, CONNECTION)
        drChild = cmdChild.ExecuteReader()

        lvChild.Items.Clear()
        Do While drChild.Read()
            Dim lv As ListViewItem = lvChild.Items.Add(drChild.Item(0))
            lv.SubItems.Add(drChild.Item(1))
            lv.SubItems.Add(drChild.Item(2))
            lv.SubItems.Add(drChild.Item(3))

        Loop

        txtChildTotal.Text = lvChild.Items.Count
        If lvChild.Items.Count = 0 Then
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            Button3.Enabled = True
            Button4.Enabled = True
        End If
        drChild.Close()
        cmdChild.Dispose()
        'CONNECTION.Close()
    End Sub
    Private Sub callEducation()
        'On Error Resume Next

        strSQLEduc = "SELECT * from tbl_educational where empno = '" & txtEmpNo.Text & "'order by ctrno"
        'CONNECTION.Open()
        cmdEduc = New MySqlCommand(strSQLEduc, CONNECTION)
        drEduc = cmdEduc.ExecuteReader()

        lvEducation.Items.Clear()
        Do While drEduc.Read()
            Dim lv As ListViewItem = lvEducation.Items.Add(drEduc.Item(1)) 'Emp No
            lv.SubItems.Add(drEduc.Item(2)) 'Level
            lv.SubItems.Add(drEduc.Item(3)) 'Name of School
            lv.SubItems.Add(drEduc.Item(4)) 'Degree
            lv.SubItems.Add(drEduc.Item(5)) 'Year Graduate
            lv.SubItems.Add(drEduc.Item(9)) 'Highest Grade
            lv.SubItems.Add(drEduc.Item(6)) 'From
            lv.SubItems.Add(drEduc.Item(7)) 'To
            lv.SubItems.Add(drEduc.Item(8)) 'Awards
            lv.SubItems.Add(drEduc.Item(0)) 'Awards
        Loop
        drEduc.Close()
        cmdEduc.Dispose()
        'CONNECTION.Close()
        If lvEducation.Items.Count = 0 Then
            Button18.Enabled = False
            cmdEducUpdateCancel.Enabled = False
        Else
            Button18.Enabled = True
            cmdEducUpdateCancel.Enabled = True
        End If
    End Sub
    Private Sub callCivilService()
        'On Error Resume Next
        Dim i As Integer
        strSQLCivil = "SELECT * from tbl_eligibility where empno = '" & txtEmpNo.Text & "'order by ctrno"
        'CONNECTION.Open()
        cmdCivil = New MySqlCommand(strSQLCivil, CONNECTION)
        drCivil = cmdCivil.ExecuteReader()

        lvCivilService.Items.Clear()
        Do While drCivil.Read()
            Dim lv As ListViewItem = lvCivilService.Items.Add(drCivil.Item(0))
            lv.SubItems.Add(drCivil.Item(1))
            lv.SubItems.Add(drCivil.Item(2))
            lv.SubItems.Add(drCivil.Item(3))
            lv.SubItems.Add(drCivil.Item(4))
            lv.SubItems.Add(drCivil.Item(5))
            lv.SubItems.Add(drCivil.Item(6))
            lv.SubItems.Add(drCivil.Item(7))

        Loop
        drCivil.Close()
        cmdCivil.Dispose()
        'CONNECTION.Close()

        If lvCivilService.Items.Count = 0 Then
            Button19.Enabled = False
            cmdCivilUpdateCancel.Enabled = False
        Else
            Button19.Enabled = True
            cmdCivilUpdateCancel.Enabled = True
        End If
    End Sub
    Private Sub callWorkExperience()
        'On Error Resume Next
        Dim i As Integer
        strSQLWork = "SELECT * from tbl_emp_experience where empno = '" & txtEmpNo.Text & "' order by date('InclusiveFrom')"
        'CONNECTION.Open()
        cmdWork = New MySqlCommand(strSQLWork, CONNECTION)
        drWork = cmdWork.ExecuteReader()

        lvWorkExp.Items.Clear()
        Do While drWork.Read()
            Dim lv As ListViewItem = lvWorkExp.Items.Add(drWork.Item(1))
            lv.SubItems.Add(drWork.Item(2))
            lv.SubItems.Add(drWork.Item(3))
            lv.SubItems.Add(drWork.Item(4))
            lv.SubItems.Add(drWork.Item(5))
            lv.SubItems.Add(drWork.Item(6))
            lv.SubItems.Add(drWork.Item(7))
            lv.SubItems.Add(drWork.Item(8))
            lv.SubItems.Add(drWork.Item(9))
            lv.SubItems.Add(drWork.Item(0))

        Loop
        drWork.Close()
        cmdWork.Dispose()
        'CONNECTION.Close()
        If lvWorkExp.Items.Count = 0 Then
            cmdWorkUpdateCancel.Enabled = False
            Button16.Enabled = False
        Else
            cmdWorkUpdateCancel.Enabled = True
            Button16.Enabled = True
        End If
    End Sub
    Public Sub callTainings()
        On Error Resume Next
        Dim i As Integer
        strSQLTraining = "SELECT * from tbl_trainings where empno = '" & txtEmpNo.Text & "' order by DATE('InclusiveDatesFrom') Desc"
        'CONNECTION.Open()
        cmdTraining = New MySqlCommand(strSQLTraining, CONNECTION)
        drTraining = cmdTraining.ExecuteReader()

        lvTrainings.Items.Clear()
        Do While drTraining.Read()
            Dim lv As ListViewItem = lvTrainings.Items.Add(drTraining.Item(0))
            lv.SubItems.Add(drTraining.Item(1))
            lv.SubItems.Add(drTraining.Item(2))
            lv.SubItems.Add(drTraining.Item(3))
            lv.SubItems.Add(drTraining.Item(4))
            lv.SubItems.Add(drTraining.Item(5))
            lv.SubItems.Add(drTraining.Item(6))
            lv.SubItems.Add(drTraining.Item(7))


        Loop
        drTraining.Close()
        cmdTraining.Dispose()
        'CONNECTION.Close()
        If lvTrainings.Items.Count = 0 Then
            cmdTrainingUpdate.Enabled = False
            cmdTrainingDelete.Enabled = False
        Else
            cmdTrainingUpdate.Enabled = True
            cmdTrainingDelete.Enabled = True
        End If
    End Sub
    Private Sub callVoluntary()
        'On Error Resume Next
        Dim i As Integer
        strSQLVoluntary = "SELECT * from tbl_voluntarywork where empno = '" & txtEmpNo.Text & "'order by ctrno"
        'CONNECTION.Open()
        cmdVoluntary = New MySqlCommand(strSQLVoluntary, CONNECTION)
        drVoluntary = cmdVoluntary.ExecuteReader()

        lvVoluntary.Items.Clear()
        Do While drVoluntary.Read()
            Dim lv As ListViewItem = lvVoluntary.Items.Add(drVoluntary.Item(6))
            lv.SubItems.Add(drVoluntary.Item(1))
            lv.SubItems.Add(drVoluntary.Item(2))
            lv.SubItems.Add(drVoluntary.Item(3))
            lv.SubItems.Add(drVoluntary.Item(4))
            lv.SubItems.Add(drVoluntary.Item(5))
            lv.SubItems.Add(drVoluntary.Item(0))

        Loop
        drVoluntary.Close()
        cmdVoluntary.Dispose()
        'CONNECTION.Close()
        If lvVoluntary.Items.Count = 0 Then
            cmdVolUpdateCancel.Enabled = False
            cmdVWDelete.Enabled = False
        Else
            cmdVolUpdateCancel.Enabled = True
            cmdVWDelete.Enabled = True
        End If
    End Sub
    Private Sub callReference()
        'On Error Resume Next
        Dim i As Integer
        strSQLRef = "SELECT * from tbl_reference where empno = '" & txtEmpNo.Text & "'order by ctrno"
        'CONNECTION.Open()
        cmdRef = New MySqlCommand(strSQLRef, CONNECTION)
        drRef = cmdRef.ExecuteReader()

        lvRef.Items.Clear()
        Do While drRef.Read()
            Dim lv As ListViewItem = lvRef.Items.Add(drRef.Item(0))
            lv.SubItems.Add(drRef.Item(1))
            lv.SubItems.Add(drRef.Item(2))
            lv.SubItems.Add(drRef.Item(3))
            lv.SubItems.Add(drRef.Item(4))

        Loop
        drRef.Close()
        cmdRef.Dispose()
        'CONNECTION.Close()
        If lvRef.Items.Count = 0 Then
            Button5.Enabled = False
            Button17.Enabled = False
        Else
            Button5.Enabled = True
            Button17.Enabled = True
        End If
    End Sub
    Private Sub callOthers()
        'On Error Resume Next
        Dim i As Integer
        strSQLOthers = "SELECT * from tbl_otherinfo where empno = '" & txtEmpNo.Text & "'order by ctrno"
        'CONNECTION.Open()
        cmdOthers = New MySqlCommand(strSQLOthers, CONNECTION)
        drOthers = cmdOthers.ExecuteReader()

        lv33.Items.Clear()
        lv34.Items.Clear()
        lv35.Items.Clear()
        Do While drOthers.Read()
            If drOthers.Item(1) = "33" Then
                Dim lv As ListViewItem = lv33.Items.Add(drOthers.Item(0))
                lv.SubItems.Add(drOthers.Item(2))
                lv.SubItems.Add(drOthers.Item(3))
            ElseIf drOthers.Item(1) = "34" Then
                Dim lv As ListViewItem = lv34.Items.Add(drOthers.Item(0))
                lv.SubItems.Add(drOthers.Item(2))
                lv.SubItems.Add(drOthers.Item(3))
            ElseIf drOthers.Item(1) = "35" Then
                Dim lv As ListViewItem = lv35.Items.Add(drOthers.Item(0))
                lv.SubItems.Add(drOthers.Item(2))
                lv.SubItems.Add(drOthers.Item(3))
            End If
        Loop
        drOthers.Close()
        cmdOthers.Dispose()
        'CONNECTION.Close()

    End Sub
    Private Sub callQuestion()
        On Error Resume Next
        Dim i As Integer
        strSQLQuestion = "SELECT * from tbl_question where empno = '" & txtEmpNo.Text & "'"
        'CONNECTION.Open()
        Dim da As New MySqlDataAdapter(strSQLQuestion, CONNECTION)
        ' cmdQuestion = New MySqlCommand(strSQLQuestion, CONNECTION)
        'drQuestion = cmdQuestion.ExecuteReader()
        da.Fill(dsQuestion, "Question")
        If dsQuestion.Tables("Question").Rows.Count <> 0 Then
            With dsQuestion.Tables("Question").Rows(0)
                If .Item(1) = "Yes" Then
                    Me.optYes34A.Select()
                ElseIf .Item(1) = "No" Then
                    Me.optNo34A.Select()
                End If
                txtYesNo34A.Text = .Item(1).ToString
                txt34A.Text = .Item(2).ToString

                If .Item(3) = "Yes" Then
                    optYes34B.Select()
                Else
                    optNo34B.Select()
                End If
                txtYesNo34B.Text = .Item(3)
                txt34B.Text = .Item(4)

                If .Item(5) = "Yes" Then
                    optYes35A.Select()
                Else
                    optNo35A.Select()
                End If
                txtYesNo35A.Text = .Item(5)
                txt35A.Text = .Item(6)

                If .Item(7) = "Yes" Then
                    optYes35B.Select()
                Else
                    optNo35B.Select()
                End If
                txtYesNo35B.Text = .Item(7)
                txt35B.Text = .Item(8)

                If .Item(9) = "Yes" Then
                    optYes36.Select()
                Else
                    optNo36.Select()
                End If
                txtYesNo36.Text = .Item(9)
                txt36.Text = .Item(10)

                If .Item(11) = "Yes" Then
                    optYes37.Select()
                Else
                    optNo37.Select()
                End If
                txtYesNo37.Text = .Item(11)
                txt37.Text = .Item(12)

                If .Item(13) = "Yes" Then
                    optYes38A.Select()
                Else
                    optNo38A.Select()
                End If
                txtYesNo38A.Text = .Item(13)
                txt38A.Text = .Item(14)

                If .Item(15) = "Yes" Then
                    optYes38B.Select()
                Else
                    optNo38B.Select()
                End If
                txtYesNo38B.Text = .Item(13)
                txt38B.Text = .Item(16)

                If .Item(17) = "Yes" Then
                    optYes39.Select()
                Else
                    optNo39.Select()
                End If
                txtYesNo39.Text = .Item(17)
                txt39.Text = .Item(18)

                If .Item(19) = "Yes" Then
                    optYes40A.Select()
                Else
                    optNo40A.Select()
                End If
                txtYesNo40A.Text = .Item(19)
                txt40A.Text = .Item(20)

                If .Item(21) = "Yes" Then
                    optYes40B.Select()
                Else
                    optNo40B.Select()
                End If
                txtYesNo40B.Text = .Item(21)
                txt40B.Text = .Item(22)

                If .Item(23) = "Yes" Then
                    optYes40C.Select()
                Else
                    optNo40C.Select()
                End If
                txtYesNo40C.Text = .Item(23)
                txt40C.Text = .Item(24)
            End With
        Else
            optNo34A.Select()
            optNo34B.Select()
            optNo35A.Select()
            optNo35B.Select()
            optNo36.Select()
            optNo37.Select()
            optNo38A.Select()
            optNo38B.Select()
            optNo39.Select()
            optNo40A.Select()
            optNo40B.Select()
            optNo40C.Select()
        End If
        dsQuestion.Reset()

        'CONNECTION.Close()
    End Sub
    Private Sub callPosition()
        On Error Resume Next
        Dim i As Integer
        strSQLPos = "SELECT * from tbl_positioncode"
        CONNECTION.Open()
        cmdPos = New MySqlCommand(strSQLPos, CONNECTION)
        drPos = cmdPos.ExecuteReader()
        cbDesignation.Items.Clear()
        '.Items.Clear()
        Do While drPos.Read()
            cbDesignation.Items.Add(drPos.Item(2))
        Loop
        'txtChildTotal.Text = lvChild.Items.Count
        drPos.Close()
        cmdPos.Dispose()
        CONNECTION.Close()
    End Sub

    '-------------------------------------------------
    'End of Display 

    Public Sub PersonalInfo_Load() Handles MyBase.Load
        txtSSurname.ReadOnly = True
        txtSFirstName.ReadOnly = True
        txtSMiddleName.ReadOnly = True
        txtSEmployer.ReadOnly = True
        txtSEmpAddress.ReadOnly = True
        txtSTelNo.ReadOnly = True
        txtSOccupation.ReadOnly = True
        txtFSurname.ReadOnly = True
        txtFFirstName.ReadOnly = True
        txtFMiddleName.ReadOnly = True
        txtMSurname.ReadOnly = True
        txtMFirstName.ReadOnly = True
        txtMMiddleName.ReadOnly = True
        'cbDesignation.Enabled = False
        callPosition()
        strSQL = "Select * from tbl_employees order by empno"
        callPersonalInfo()
        txtTotNum.Text = pNav + 1 & " of " & MaxRow
        QSave = 0
        TabPage1.ForeColor = Color.White
    End Sub

    'Navigation buttons
    '-----------------------------------------
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click

        If pNav = MaxRow - 1 Then
            MsgBox("End of Record", vbInformation)
            pNav = MaxRow - 1
            callPersonalInfo()
        Else
            pNav = pNav + 1
            callPersonalInfo()
        End If
        'CONNECTION.Close()
    End Sub
    Private Sub cmdPrev_Click(sender As Object, e As EventArgs) Handles cmdPrev.Click
        If pNav = 0 Then
            MsgBox("Beginning of Record", vbInformation)
            pNav = 0
            callPersonalInfo()
        Else
            pNav = pNav - 1
            callPersonalInfo()
        End If
        ' CONNECTION.Close()
    End Sub
    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        pNav = MaxRow - 1
        callPersonalInfo()
        MsgBox("End of Record", vbInformation)
        'CONNECTION.Close()
    End Sub
    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        pNav = 0
        callPersonalInfo()
        MsgBox("Beginning of Record", vbInformation)
        'CONNECTION.Close()
    End Sub
    '-----------------------------------------
    'End of navigaton

    'Code for Search
    '-----------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSearchPersonalInfo.ShowDialog()
    End Sub

    Private Sub txtTempEmpno_TextChanged(sender As Object, e As EventArgs) Handles txtTempEmpno.TextChanged
        'Dim strSQL As String
        If txtTempEmpno.Text = "" Then
            Exit Sub
        End If
        strSQL = "Select * from tbl_employees where empno = '" & txtTempEmpno.Text & "'"
        callPersonalInfo()
        txtTotNum.Text = pNav + 1 & " of " & MaxRow
    End Sub
    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        strSQL = "Select * from tbl_employees order by empno"
        callPersonalInfo()
        txtTotNum.Text = pNav + 1 & " of " & MaxRow
    End Sub
    '-----------------------------------------
    'End of Search

    Private Sub cmdPrintPDS_Click(sender As Object, e As EventArgs) Handles cmdPrintPDS.Click
        On Error Resume Next
        'Seperate names of each letter
        Dim xl As New Excel.Application
        Dim wkb As Excel.Workbook
        Dim wks, wks2, wks3, wks4, wks5, wks6, wks7, wks8 As Excel.Worksheet
        Dim rng As Excel.Range
        Dim D As String
        Dim DoNotSaveChanges As Boolean = False


        Dim countSN, i, j, k, countFN, countMI As Integer
        Dim Surname, FN, MI As String

        countSN = Len(txtSurname.Text)
        countFN = Len(txtFirstName.Text)
        countMI = Len(txtMiddleName.Text)



        xl.Visible = True
        wkb = xl.Workbooks.Open("" & Application.StartupPath & "\pds.xlsx")
        wks = wkb.Sheets.Item("C1")
        wks2 = wkb.Sheets.Item("C2")
        wks3 = wkb.Sheets.Item("C3")
        wks4 = wkb.Sheets.Item("C4")
        wks5 = wkb.Sheets.Item("V")
        wks6 = wkb.Sheets.Item("VII")
        wks7 = wkb.Sheets.Item("V-2")
        wks8 = wkb.Sheets.Item("VII-2")
        '
        'Load some Data
        'Surname = "   "
        'FN = "   "
        'MI = "   "
        'i = 1
        'j = 1
        'k = 1
        'While i <= 24
        '    If i <= countSN Then
        '        Surname = Surname + Mid(txtSurname.Text, i, 1) + "  |   "
        '    Else
        '        Surname = Surname + "  " + "  |   "
        '    End If
        '    i = i + 1
        'End While

        'While j <= 24
        '    If j <= countFN Then
        '        FN = FN + Mid(txtFirstName.Text, j, 1) + "  |   "
        '    Else
        '        FN = FN + "  " + "  |   "
        '    End If
        '    j = j + 1
        'End While

        'While k <= 24
        '    If k <= countMI Then
        '        MI = MI + Mid(txtMiddleName.Text, k, 1) + "  |   "
        '    Else
        '        MI = MI + "  " + "  |   "
        '    End If
        '    k = k + 1
        'End While
        'MsgBox(Surname)
        wks.Cells(10, 4) = UCase(txtSurname.Text)
        wks.Cells(11, 4) = UCase(txtFirstName.Text)
        wks.Cells(12, 4) = UCase(txtMiddleName.Text)
        wks.Cells(11, 14) = txtExtension.Text
        wks.Cells(13, 4) = dtDOB.Text
        wks.Cells(15, 4) = txtPOB.Text
        'Adding Check image in sheet 1

        If cbFilipino.Checked = True Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 21"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If

        If cbDual.Checked = True Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 222"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If

        If rbByBirth.Checked = True Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 39"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If rbByNaturalization.Checked = True Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 40"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If


        If optMale.Checked = True Then
            'If boxvalue = -1 Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 25"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            'End If

            '  wks.Shapes("Check Box 25").ControlFormat.Value = True  'Uncheck
            'wks.Shapes("Check box 1").ControlFormat.Value = 0  'Check
        End If
        If optFemale.Checked = True Then
            'wks.Shapes("Check Box 26").ControlFormat.Value = True  'Uncheck
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 26"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If

        If cbCivilStatus.Text = "Single" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 34"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If

        If cbCivilStatus.Text = "Married" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 35"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        'If cbCivilStatus.Text = "Annuled" Then
        '    Dim cb As Microsoft.Office.Interop.Excel.CheckBox
        '    cb = CType(wks.CheckBoxes("Check Box 36"), Microsoft.Office.Interop.Excel.CheckBox)
        '    cb.Value = True
        'End If
        If cbCivilStatus.Text = "Widowed" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 36"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If cbCivilStatus.Text = "Seperated" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 38"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If cbCivilStatus.Text = "Others" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks.CheckBoxes("Check Box 37"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If

        'wks.Cells(16, 3) = cbCivilStatus.Text
        wks.Cells(22, 4) = txtHeight.Text
        wks.Cells(24, 4) = txtWeight.Text
        wks.Cells(25, 4) = txtBlood.Text

        wks.Cells(17, 9) = txtRAddress.Text
        wks.Cells(17, 12) = txtRStreet.Text
        wks.Cells(19, 9) = txtRSubdivision.Text
        wks.Cells(19, 12) = txtRBarangay.Text
        wks.Cells(22, 9) = txtRCity.Text
        wks.Cells(22, 12) = txtRProvince.Text
        wks.Cells(24, 9) = txtRZIPCode.Text

        'wks.Cells(14, 9) = txtRTel.Text
        wks.Cells(25, 9) = txtPAddress.Text
        wks.Cells(25, 12) = txtPStreet.Text
        wks.Cells(27, 9) = txtPSubdivision.Text
        wks.Cells(27, 12) = txtPBarangay.Text
        wks.Cells(29, 9) = txtPCity.Text
        wks.Cells(29, 12) = txtPProvince.Text
        wks.Cells(31, 9) = txtPZIPCode.Text


        wks.Cells(32, 9) = txtPTel.Text
        wks.Cells(34, 9) = txtEmail.Text
        wks.Cells(33, 9) = txtCP.Text

        wks.Cells(34, 4) = txtEmpNo.Text
        wks.Cells(33, 4) = txtTINNo.Text
        wks.Cells(27, 4) = txtGSIS.Text
        wks.Cells(29, 4) = txtPagibig.Text
        wks.Cells(31, 4) = txtPhilhealth.Text
        wks.Cells(32, 4) = txtSSS.Text

        'Family Background
        wks.Cells(36, 4) = txtSSurname.Text
        wks.Cells(37, 4) = txtSFirstName.Text
        wks.Cells(38, 4) = txtSMiddleName.Text
        wks.Cells(39, 4) = txtSOccupation.Text
        wks.Cells(40, 4) = txtSEmployer.Text
        wks.Cells(41, 4) = txtSEmpAddress.Text
        wks.Cells(42, 4) = txtSTelNo.Text

        wks.Cells(43, 4) = txtFSurname.Text
        wks.Cells(44, 4) = txtFFirstName.Text
        wks.Cells(45, 4) = txtFMiddleName.Text
        wks.Cells(47, 4) = txtMSurname.Text
        wks.Cells(48, 4) = txtMFirstName.Text
        wks.Cells(49, 4) = txtMMiddleName.Text
        'Export Child Information
        Dim ic As Integer
        ic = 0
        For Each itm In lvChild.Items
            wks.Cells(37 + ic, 9) = itm.SubItems(1).text
            wks.Cells(37 + ic, 13) = itm.SubItems(2).text
            ic = ic + 1
        Next
        'Export Educational Background
        For Each itm In lvEducation.Items
            '.Fields(1).Value = Val(itm.Text)
            If itm.SubItems(1).text = "Elementary" Then
                wks.Cells(54, 4) = itm.SubItems(2).text
                wks.Cells(54, 7) = itm.SubItems(3).text
                wks.Cells(54, 10) = itm.SubItems(6).text
                wks.Cells(54, 11) = itm.SubItems(7).text
                wks.Cells(54, 12) = itm.SubItems(5).text
                wks.Cells(54, 13) = itm.SubItems(4).text
                wks.Cells(54, 14) = itm.SubItems(8).text
            ElseIf itm.SubItems(1).text = "Secondary" Then
                wks.Cells(55, 4) = itm.SubItems(2).text
                wks.Cells(55, 7) = itm.SubItems(3).text
                wks.Cells(55, 10) = itm.SubItems(6).text
                wks.Cells(55, 11) = itm.SubItems(7).text
                wks.Cells(55, 12) = itm.SubItems(5).text
                wks.Cells(55, 13) = itm.SubItems(4).text
                wks.Cells(55, 14) = itm.SubItems(8).text
            ElseIf itm.SubItems(1).text = "Vocational/Trade Course" Then
                wks.Cells(56, 4) = itm.SubItems(2).text
                wks.Cells(56, 7) = itm.SubItems(3).text
                wks.Cells(56, 10) = itm.SubItems(6).text
                wks.Cells(56, 11) = itm.SubItems(7).text
                wks.Cells(56, 12) = itm.SubItems(5).text
                wks.Cells(56, 13) = itm.SubItems(4).text
                wks.Cells(56, 14) = itm.SubItems(8).text
            ElseIf itm.SubItems(1).text = "College" Then
                wks.Cells(57, 4) = itm.SubItems(2).text
                wks.Cells(57, 7) = itm.SubItems(3).text
                wks.Cells(57, 10) = itm.SubItems(6).text
                wks.Cells(57, 11) = itm.SubItems(7).text
                wks.Cells(57, 12) = itm.SubItems(5).text
                wks.Cells(57, 13) = itm.SubItems(4).text
                wks.Cells(57, 14) = itm.SubItems(8).text
            ElseIf itm.SubItems(1).text = "Graduate Studies" Then
                wks.Cells(58, 4) = itm.SubItems(2).text
                wks.Cells(58, 7) = itm.SubItems(3).text
                wks.Cells(58, 10) = itm.SubItems(6).text
                wks.Cells(58, 11) = itm.SubItems(7).text
                wks.Cells(58, 12) = itm.SubItems(5).text
                wks.Cells(58, 13) = itm.SubItems(4).text
                wks.Cells(58, 14) = itm.SubItems(8).text
            End If
            '  .MoveNext - placed it in comment for the meantime
        Next
        'Educational Background

        'Export Civil Service Eligibilitty
        Dim iCS As Integer
        iCS = 0
        For Each itm In lvCivilService.Items
            wks2.Cells(5 + iCS, 1) = itm.SubItems(1).text
            wks2.Cells(5 + iCS, 6) = itm.SubItems(2).text & "%"
            wks2.Cells(5 + iCS, 7) = itm.SubItems(3).text
            wks2.Cells(5 + iCS, 9) = itm.SubItems(4).text
            wks2.Cells(5 + iCS, 12) = itm.SubItems(5).text
            wks2.Cells(5 + iCS, 13) = itm.SubItems(6).text
            iCS = iCS + 1
        Next
        'End Export Civil Service Eligibility
        'Export Reference
        Dim iRef As Integer
        iRef = 0
        For Each itm In lvRef.Items
            If iRef < 3 Then
                wks4.Cells(41 + iRef, 1) = itm.SubItems(1).text
                wks4.Cells(41 + iRef, 4) = itm.SubItems(2).text
                wks4.Cells(41 + iRef, 5) = itm.SubItems(3).text
            End If
            iRef = iRef + 1
        Next
        'End Export Civil Service Eligibility
        'Export OtherInfo
        Dim i33 As Integer
        i33 = 0
        For Each itm In lv33.Items
            wks3.Cells(40 + i33, 1) = itm.SubItems(1).text
            i33 = i33 + 1
        Next

        Dim i34 As Integer
        i33 = 0
        For Each itm In lv34.Items
            wks3.Cells(40 + i34, 3) = itm.SubItems(1).text
            i34 = i34 + 1
        Next
        Dim i35 As Integer
        i33 = 0
        For Each itm In lv35.Items
            wks3.Cells(40 + i35, 8) = itm.SubItems(1).text
            i35 = i35 + 1
        Next
        'End Export Civil Service Eligibility
        'Start Export Work Experience
        Dim iWE As Integer
        iWE = 0
        For Each itm In lvWorkExp.Items
            If iWE < 28 Then
                wks2.Cells(18 + iWE, 1) = itm.SubItems(1).text
                wks2.Cells(18 + iWE, 3) = itm.SubItems(2).text
                wks2.Cells(18 + iWE, 4) = itm.SubItems(3).text
                wks2.Cells(18 + iWE, 7) = itm.SubItems(4).text
                wks2.Cells(18 + iWE, 10) = itm.SubItems(5).text
                wks2.Cells(18 + iWE, 11) = itm.SubItems(6).text
                wks2.Cells(18 + iWE, 12) = itm.SubItems(7).text
                wks2.Cells(18 + iWE, 13) = itm.SubItems(8).text
            ElseIf iWE >= 67 Then
                wks5.Cells(6 + (iWE - 67), 1) = itm.SubItems(1).text
                wks5.Cells(6 + (iWE - 67), 3) = itm.SubItems(2).text
                wks5.Cells(6 + (iWE - 67), 4) = itm.SubItems(3).text
                wks5.Cells(6 + (iWE - 67), 7) = itm.SubItems(4).text
                wks5.Cells(6 + (iWE - 67), 10) = itm.SubItems(5).text
                wks5.Cells(6 + (iWE - 67), 11) = itm.SubItems(6).text
                wks5.Cells(6 + (iWE - 67), 12) = itm.SubItems(7).text
                wks5.Cells(6 + (iWE - 67), 13) = itm.SubItems(8).text
            Else
                wks5.Cells(6 + (iWE - 28), 1) = itm.SubItems(1).text
                wks5.Cells(6 + (iWE - 28), 3) = itm.SubItems(2).text
                wks5.Cells(6 + (iWE - 28), 4) = itm.SubItems(3).text
                wks5.Cells(6 + (iWE - 28), 7) = itm.SubItems(4).text
                wks5.Cells(6 + (iWE - 28), 10) = itm.SubItems(5).text
                wks5.Cells(6 + (iWE - 28), 11) = itm.SubItems(6).text
                wks5.Cells(6 + (iWE - 28), 12) = itm.SubItems(7).text
                wks5.Cells(6 + (iWE - 28), 13) = itm.SubItems(8).text
            End If
            iWE = iWE + 1
        Next
        'End Export Work Experience
        'Export Voluntary Work
        Dim iVW As Integer
        iVW = 0
        For Each itm In lvVoluntary.Items
            wks3.Cells(6 + iVW, 1) = itm.SubItems(1).text
            wks3.Cells(6 + iVW, 5) = itm.SubItems(2).text
            wks3.Cells(6 + iVW, 6) = itm.SubItems(3).text
            wks3.Cells(6 + iVW, 7) = itm.SubItems(4).text
            wks3.Cells(6 + iVW, 8) = itm.SubItems(5).text
            iVW = iVW + 1
        Next
        'End Export Voluntary Work

        'Start Export Work Experience
        Dim iTP As Integer
        iTP = 0
        For Each itm In lvTrainings.Items
            If iTP < 21 Then
                wks3.Cells(19 + iTP, 1) = itm.SubItems(1).text
                wks3.Cells(19 + iTP, 5) = itm.SubItems(2).text
                wks3.Cells(19 + iTP, 6) = itm.SubItems(3).text
                wks3.Cells(19 + iTP, 7) = itm.SubItems(4).text
                wks3.Cells(19 + iTP, 8) = itm.SubItems(7).text
                wks3.Cells(19 + iTP, 9) = itm.SubItems(5).text
            ElseIf iTP >= 62 Then
                wks8.Cells(7 + (iTP - 62), 1) = itm.SubItems(1).text
                wks8.Cells(7 + (iTP - 62), 5) = itm.SubItems(2).text
                wks8.Cells(7 + (iTP - 62), 6) = itm.SubItems(3).text
                wks8.Cells(7 + (iTP - 62), 7) = itm.SubItems(4).text
                wks8.Cells(7 + (iTP - 62), 8) = itm.SubItems(7).text
                wks8.Cells(7 + (iTP - 62), 9) = itm.SubItems(5).text
            Else
                wks6.Cells(7 + (iTP - 21), 1) = itm.SubItems(1).text
                wks6.Cells(7 + (iTP - 21), 5) = itm.SubItems(2).text
                wks6.Cells(7 + (iTP - 21), 6) = itm.SubItems(3).text
                wks6.Cells(7 + (iTP - 21), 7) = itm.SubItems(4).text
                wks6.Cells(7 + (iTP - 21), 8) = itm.SubItems(7).text
                wks6.Cells(7 + (iTP - 21), 9) = itm.SubItems(5).text
            End If
            iTP = iTP + 1
        Next
        'End Export Work Experience

        If txtYesNo34A.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 1"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True

            wks4.Cells(11, 8) = txt34A.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 2"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo34B.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 3"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            'wks4.Cells(15, 8) = txt34B.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 4"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo35A.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 5"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True

            wks4.Cells(15, 8) = "If YES, give details:                             " & txt35A.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 6"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo35B.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 7"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            wks4.Cells(20, 11) = txt35B.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 8"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo36.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 9"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            wks4.Cells(25, 8) = txt36.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 10"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo37.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 11"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            wks4.Cells(29, 8) = txt37.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 12"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo38A.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 26"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            wks4.Cells(32, 11) = txt38A.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 27"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo38B.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 28"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            wks4.Cells(35, 11) = txt38B.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 29"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If

        If txtYesNo39.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 13"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            wks4.Cells(39, 8) = txt39.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 14"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If

        If txtYesNo40A.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 15"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            wks4.Cells(44, 12) = txt40A.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 18"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo40B.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 16"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True

            wks4.Cells(46, 12) = txt40B.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 19"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If
        If txtYesNo40C.Text = "Yes" Then
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 17"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
            wks4.Cells(48, 12) = txt40B.Text
        Else
            Dim cb As Microsoft.Office.Interop.Excel.CheckBox
            cb = CType(wks4.CheckBoxes("Check Box 20"), Microsoft.Office.Interop.Excel.CheckBox)
            cb.Value = True
        End If

        wkb.SaveAs(txtEmpNo.Text & ".xlsx")
        wkb.Protect()
        'wkb.Close() ' prompt to save, pauses program to allow viewing of worksheet
        wkb.Close(DoNotSaveChanges) ' Close imeadiately and do not prompt user

        'xl.Quit()
        xl.Workbooks.Open(txtEmpNo.Text & ".xlsx")
        wks = Nothing
        wks4 = Nothing
        wkb = Nothing
        xl = Nothing
        GC.Collect()
    End Sub
    'Check the Civil Status
    Private Sub cbCivilStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCivilStatus.SelectedIndexChanged
        If cbCivilStatus.Text = "Single" Then
            txtSSurname.Enabled = False
            txtSFirstName.Enabled = False
            txtSMiddleName.Enabled = False
            txtSEmployer.Enabled = False
            txtSEmpAddress.Enabled = False
            txtSOccupation.Enabled = False
            txtSTelNo.Enabled = False
        Else
            txtSSurname.Enabled = True
            txtSFirstName.Enabled = True
            txtSMiddleName.Enabled = True
            txtSEmployer.Enabled = True
            txtSEmpAddress.Enabled = True
            txtSOccupation.Enabled = True
            txtSTelNo.Enabled = True
        End If
    End Sub

    Private Sub cmdChildUpdateCancel_Click(sender As Object, e As EventArgs) Handles cmdChildUpdateCancel.Click
        If cmdChildUpdateCancel.Text = "UPDATE" Then
            cmdChildUpdateCancel.Text = "CANCEL"
            cmdChildSave.Visible = True

            If cbCivilStatus.Text <> "Single" Then
                txtSSurname.ReadOnly = False
                txtSFirstName.ReadOnly = False
                txtSMiddleName.ReadOnly = False
                txtSEmployer.ReadOnly = False
                txtSEmpAddress.ReadOnly = False
                txtSTelNo.ReadOnly = False
                txtSOccupation.ReadOnly = False
            End If

            txtFSurname.ReadOnly = False
            txtFFirstName.ReadOnly = False
            txtFMiddleName.ReadOnly = False
            txtMSurname.ReadOnly = False
            txtMFirstName.ReadOnly = False
            txtMMiddleName.ReadOnly = False

            If FamilyBGCount <> 0 Then
                btnAction = 1
            Else
                btnAction = 2
            End If

        ElseIf cmdChildUpdateCancel.Text = "CANCEL" Then
            cmdChildUpdateCancel.Text = "UPDATE"
            txtSSurname.ReadOnly = True
            txtSFirstName.ReadOnly = True
            txtSMiddleName.ReadOnly = True
            txtSEmployer.ReadOnly = True
            txtSEmpAddress.ReadOnly = True
            txtSTelNo.ReadOnly = True
            txtSOccupation.ReadOnly = True
            txtFSurname.ReadOnly = True
            txtFFirstName.ReadOnly = True
            txtFMiddleName.ReadOnly = True
            txtMSurname.ReadOnly = True
            txtMFirstName.ReadOnly = True
            txtMMiddleName.ReadOnly = True

            cmdChildSave.Visible = False
            btnAction = 0
        End If
    End Sub

    Private Sub cmdChildSave_Click(sender As Object, e As EventArgs) Handles cmdChildSave.Click
        On Error Resume Next
        Dim sql As String
        CONNECTION.Open()
        If btnAction = 1 Then
            sql = "UPDATE tbl_emp_fbackground SET ssname= '" & txtSSurname.Text & _
            "', sfirstname='" & txtSFirstName.Text & _
            "', smi='" & txtSMiddleName.Text & _
            "', sextension='" & txtSExtension.Text & _
            "', soccupation='" & txtSOccupation.Text & _
            "', sbname='" & txtSEmployer.Text & _
            "', sbaddress='" & txtSEmpAddress.Text & _
            "', stelephone='" & txtSTelNo.Text & _
            "', fsname='" & txtFSurname.Text & _
            "', ffirstname='" & txtFFirstName.Text & _
            "', fmi='" & txtFMiddleName.Text & _
            "', fextension='" & txtFExtension.Text & _
            "', mmname='" & txtMMaiden.Text & _
            "', msname='" & txtMSurname.Text & _
            "', mmfirstname='" & txtMFirstName.Text & _
            "', mmi='" & txtMMiddleName.Text & "' WHERE empno = '" & txtEmpNo.Text & "'"

        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_emp_fbackground SET empno='" & txtEmpNo.Text & _
                 "', ssname='" & txtSSurname.Text & _
                 "', sfirstname='" & txtSFirstName.Text & _
                 "', smi='" & txtSMiddleName.Text & _
                 "', sextension='" & txtSExtension.Text & _
                "', soccupation='" & txtSOccupation.Text & _
                "', sbname='" & txtSEmployer.Text & _
                "', sbaddress='" & txtSEmpAddress.Text & _
                "', stelephone='" & txtSTelNo.Text & _
                "', fsname='" & txtFSurname.Text & _
                "', ffirstname='" & txtFFirstName.Text & _
                "', fmi='" & txtFMiddleName.Text & _
                "', fextension='" & txtFExtension.Text & _
                "', mmname='" & txtMMaiden.Text & _
                "', msname='" & txtMSurname.Text & _
                "', mmfirstname='" & txtMFirstName.Text & _
                "', mmi='" & txtMMiddleName.Text & "'"
        End If

        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = sql

        Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            MsgBox("No record found")
            'Exit Sub
        Else
            MsgBox("Records updated")
            txtSSurname.ReadOnly = True
            txtSFirstName.ReadOnly = True
            txtSMiddleName.ReadOnly = True
            txtSEmployer.ReadOnly = True
            txtSEmpAddress.ReadOnly = True
            txtSTelNo.ReadOnly = True
            txtSOccupation.ReadOnly = True
            txtFSurname.ReadOnly = True
            txtFFirstName.ReadOnly = True
            txtFMiddleName.ReadOnly = True
            txtMSurname.ReadOnly = True
            txtMFirstName.ReadOnly = True
            txtMMiddleName.ReadOnly = True
            cmdChildUpdateCancel.Text = "UPDATE"
            cmdChildSave.Visible = False
            CONNECTION.Close()

        End If
        CONNECTION.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmAEChild.txtEmpNo.Text = txtEmpNo.Text
        btnAction = 2
        frmAEChild.txtName.Text = ""
        frmAEChild.txtName.Focus()
        frmAEChild.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lvChild.SelectedItems.Count <> 0 Then
            frmAEChild.txtEmpNo.Text = lvChild.SelectedItems(0).Text
            frmAEChild.txtName.Text = lvChild.SelectedItems(0).SubItems(1).Text
            frmAEChild.dtDOB.Text = lvChild.SelectedItems(0).SubItems(2).Text
            frmAEChild.txtCTRL.Text = lvChild.SelectedItems(0).SubItems(3).Text
            frmAEChild.txtHold.Text = lvChild.SelectedItems(0).SubItems(1).Text
            btnAction = 1
            frmAEChild.ShowDialog()

        Else
            MsgBox("Please select child to be edit!!!", vbInformation)
        End If
    End Sub

    Private Sub cmdCivilAddSave_Click(sender As Object, e As EventArgs) Handles cmdCivilAddSave.Click
        frmAEEligibility.txtEmpNo.Text = txtEmpNo.Text
        btnAction = 2
        frmAEEligibility.ShowDialog()
    End Sub

    Private Sub cmdCivilUpdateCancel_Click(sender As Object, e As EventArgs) Handles cmdCivilUpdateCancel.Click
        On Error Resume Next
        If lvCivilService.SelectedItems.Count <> 0 Then
            frmAEEligibility.txtEmpNo.Text = lvCivilService.SelectedItems(0).Text
            frmAEEligibility.txtCareer.Text = lvCivilService.SelectedItems(0).SubItems(1).Text
            frmAEEligibility.txtRating.Text = lvCivilService.SelectedItems(0).SubItems(2).Text
            frmAEEligibility.dtExamDate.Text = lvCivilService.SelectedItems(0).SubItems(3).Text
            frmAEEligibility.txtExamPlace.Text = lvCivilService.SelectedItems(0).SubItems(4).Text
            frmAEEligibility.txtLicense.Text = lvCivilService.SelectedItems(0).SubItems(5).Text
            frmAEEligibility.dtLicenseDate.Text = lvCivilService.SelectedItems(0).SubItems(6).Text
            frmAEEligibility.txtCTRL.Text = lvCivilService.SelectedItems(0).SubItems(7).Text
            btnAction = 1
            frmAEEligibility.ShowDialog()
        Else
            MsgBox("Please select Career Service to be edit!!!", vbInformation)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        fra1to6.Visible = True
        fra7to10.Visible = False
        Button7.Enabled = False
        Button8.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        fra1to6.Visible = False
        fra7to10.Visible = True
        Button8.Enabled = False
        Button7.Enabled = True
    End Sub

    Private Sub cmdEducAddSave_Click(sender As Object, e As EventArgs) Handles cmdEducAddSave.Click
        fmrAEEducBack.txtEmpNo.Text = txtEmpNo.Text
        btnAction = 2
        Dim sql, sql2 As String

        fmrAEEducBack.cbLevel.Items.Clear()
        CONNECTION.Open()


        sql = "SELECT Level FROM tbl_educational where empno='" & txtEmpNo.Text & "' AND Level='Elementary'"
        Dim recDA As New MySqlDataAdapter(sql, CONNECTION)
        Dim recDS As New DataSet
        Dim rec, i As Integer
        recDA.Fill(recDS, "Search")
        rec = recDS.Tables("Search").Rows.Count

        i = 0
        If rec <> 0 Then
            sql2 = "SELECT Level FROM tbl_educational where empno='" & txtEmpNo.Text & "' AND Level='Secondary'"
            Dim recDA2 As New MySqlDataAdapter(sql2, CONNECTION)
            Dim recDS2 As New DataSet
            Dim rec2 As Integer
            recDA2.Fill(recDS2, "Search")
            rec2 = recDS2.Tables("Search").Rows.Count
            If rec2 <> 0 Then
                fmrAEEducBack.cbLevel.Items.Add("Vocational/Trade Course")
                fmrAEEducBack.cbLevel.Items.Add("College")
                fmrAEEducBack.cbLevel.Items.Add("Graduate Studies")
                fmrAEEducBack.txtCourse.Text = ""
                fmrAEEducBack.txtCourse.ReadOnly = False
            Else
                fmrAEEducBack.cbLevel.Items.Add("Secondary")
                fmrAEEducBack.cbLevel.Text = "Secondary"
                fmrAEEducBack.txtUnitEarned.Text = "N/A"
                fmrAEEducBack.txtFrom.Text = "N/A"
                fmrAEEducBack.txtTo.Text = "N/A"
                fmrAEEducBack.txtCourse.Text = "N/A"

            End If
        Else
            fmrAEEducBack.cbLevel.Items.Add("Elementary")
            fmrAEEducBack.cbLevel.Text = "Elementary"
            fmrAEEducBack.txtUnitEarned.Text = "N/A"
            fmrAEEducBack.txtFrom.Text = "N/A"
            fmrAEEducBack.txtTo.Text = "N/A"
            fmrAEEducBack.txtCourse.Text = "N/A"
        End If
        recDS.Reset()
        CONNECTION.Close()
        fmrAEEducBack.txtSchool.Text = ""
        fmrAEEducBack.txtHonor.Text = "-"
        fmrAEEducBack.ShowDialog()

    End Sub


    Private Sub cmdEducUpdateCancel_Click(sender As Object, e As EventArgs) Handles cmdEducUpdateCancel.Click
        On Error Resume Next
        If lvEducation.SelectedItems.Count <> 0 Then
            fmrAEEducBack.txtEmpNo.Text = lvEducation.SelectedItems(0).Text
            fmrAEEducBack.cbLevel.Text = lvEducation.SelectedItems(0).SubItems(1).Text
            fmrAEEducBack.txtSchool.Text = lvEducation.SelectedItems(0).SubItems(2).Text
            fmrAEEducBack.txtCourse.Text = lvEducation.SelectedItems(0).SubItems(3).Text
            fmrAEEducBack.txtYearGraduate.Text = lvEducation.SelectedItems(0).SubItems(4).Text
            fmrAEEducBack.txtUnitEarned.Text = lvEducation.SelectedItems(0).SubItems(5).Text
            fmrAEEducBack.txtFrom.Text = lvEducation.SelectedItems(0).SubItems(6).Text
            fmrAEEducBack.txtTo.Text = lvEducation.SelectedItems(0).SubItems(7).Text
            fmrAEEducBack.txtHonor.Text = lvEducation.SelectedItems(0).SubItems(8).Text
            fmrAEEducBack.txtCTRL.Text = lvEducation.SelectedItems(0).SubItems(9).Text
            btnAction = 1
            fmrAEEducBack.ShowDialog()
        Else
            MsgBox("Please select Career Service to be edit!!!", vbInformation)
        End If
    End Sub

    Private Sub cmdWorkAddSave_Click(sender As Object, e As EventArgs) Handles cmdWorkAddSave.Click
        frmAEWorkExp.txtEmpNo.Text = txtEmpNo.Text
        frmAEWorkExp.cmdSave.Enabled = True
        btnAction = 2
        frmAEWorkExp.ShowDialog()
    End Sub

    Private Sub cmdWorkUpdateCancel_Click(sender As Object, e As EventArgs) Handles cmdWorkUpdateCancel.Click
        On Error Resume Next

        If lvWorkExp.SelectedItems.Count <> 0 Then
            frmAEWorkExp.txtCTRL.Text = lvWorkExp.SelectedItems(0).SubItems(9).Text

            frmAEWorkExp.txtEmpNo.Text = lvWorkExp.SelectedItems(0).Text
            frmAEWorkExp.dtFrom.Text = lvWorkExp.SelectedItems(0).SubItems(1).Text

            If lvWorkExp.SelectedItems(0).SubItems(2).Text = "Present" Then
                frmAEWorkExp.ckbPresent.Checked = True
                frmAEWorkExp.dtTo.Enabled = False
            Else
                frmAEWorkExp.ckbPresent.Checked = False
                frmAEWorkExp.dtTo.Text = lvWorkExp.SelectedItems(0).SubItems(2).Text
            End If

            frmAEWorkExp.txtPosition.Text = lvWorkExp.SelectedItems(0).SubItems(3).Text
            frmAEWorkExp.txtDepartment.Text = lvWorkExp.SelectedItems(0).SubItems(4).Text
            frmAEWorkExp.txtSalary.Text = lvWorkExp.SelectedItems(0).SubItems(5).Text
            frmAEWorkExp.txtSalaryGrade.Text = lvWorkExp.SelectedItems(0).SubItems(6).Text
            frmAEWorkExp.cbStatus.Text = lvWorkExp.SelectedItems(0).SubItems(7).Text

            If lvWorkExp.SelectedItems(0).SubItems(8).Text = "Yes" Then
                frmAEWorkExp.optYes.Select()
                frmAEWorkExp.txtService.Text = "Yes"
            Else
                frmAEWorkExp.optNo.Select()
                frmAEWorkExp.txtService.Text = "No"
            End If
            frmAEWorkExp.cmdSave.Enabled = False
            btnAction = 1
            frmAEWorkExp.ShowDialog()
        Else
            MsgBox("Please select Career Service to be edit!!!", vbInformation)
        End If
    End Sub
    Private Sub cmdTrainingAdd_Click(sender As Object, e As EventArgs) Handles cmdTrainingAdd.Click
        frmAETraining.txtEmpNo.Text = txtEmpNo.Text
        frmAETraining.cmdSave.Enabled = True
        btnAction = 2
        frmAETraining.ShowDialog()
    End Sub
    Private Sub cmdTrainingUpdate_Click(sender As Object, e As EventArgs) Handles cmdTrainingUpdate.Click
        On Error Resume Next
        If lvTrainings.SelectedItems.Count <> 0 Then
            frmAETraining.txtEmpNo.Text = lvTrainings.SelectedItems(0).Text
            frmAETraining.txtTitle.Text = lvTrainings.SelectedItems(0).SubItems(1).Text
            frmAETraining.dtFrom.Text = lvTrainings.SelectedItems(0).SubItems(2).Text
            frmAETraining.dtTo.Text = lvTrainings.SelectedItems(0).SubItems(3).Text
            frmAETraining.txtHours.Text = lvTrainings.SelectedItems(0).SubItems(4).Text
            frmAETraining.txtConduct.Text = lvTrainings.SelectedItems(0).SubItems(5).Text
            frmAETraining.txtSearchTitle.Text = lvTrainings.SelectedItems(0).SubItems(1).Text
            frmAETraining.txtCTRL.Text = lvTrainings.SelectedItems(0).SubItems(6).Text
            frmAETraining.cbType.Text = lvTrainings.SelectedItems(0).SubItems(7).Text
            frmAETraining.cmdSave.Enabled = False
            btnAction = 1
            frmAETraining.ShowDialog()
        Else
            MsgBox("Please select Career Service to be edit!!!", vbInformation)
        End If
    End Sub

    Private Sub cmdVolAddSave_Click(sender As Object, e As EventArgs) Handles cmdVolAddSave.Click

        Dim frm As New frmAEVoluntary()
        frmAEVoluntary.txtEmpNo.Text = txtEmpNo.Text
        btnAction = 2

        frmAEVoluntary.ShowDialog()
    End Sub

    Private Sub cmdVolUpdateCancel_Click(sender As Object, e As EventArgs) Handles cmdVolUpdateCancel.Click
        On Error Resume Next
        If lvVoluntary.SelectedItems.Count <> 0 Then
            frmAEVoluntary.txtEmpNo.Text = lvVoluntary.SelectedItems(0).Text
            frmAEVoluntary.txtName.Text = lvVoluntary.SelectedItems(0).SubItems(1).Text
            frmAEVoluntary.dtFrom.Text = lvVoluntary.SelectedItems(0).SubItems(2).Text
            If lvVoluntary.SelectedItems(0).SubItems(3).Text = "Present" Then
                frmAEVoluntary.ckbPresent.Checked = True
            Else
                frmAEVoluntary.dtTo.Text = lvVoluntary.SelectedItems(0).SubItems(3).Text
            End If

            frmAEVoluntary.txtHours.Text = lvVoluntary.SelectedItems(0).SubItems(4).Text
            frmAEVoluntary.txtPosition.Text = lvVoluntary.SelectedItems(0).SubItems(5).Text
            frmAEVoluntary.txtCTRL.Text = lvVoluntary.SelectedItems(0).SubItems(6).Text
            btnAction = 1
            frmAEVoluntary.ShowDialog()
        Else
            MsgBox("Please select Career Service to be edit!!!", vbInformation)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmAEReferencec.txEmpNo.Text = txtEmpNo.Text
        btnAction = 2
        frmAEReferencec.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error Resume Next
        If lvRef.SelectedItems.Count <> 0 Then
            frmAEReferencec.txEmpNo.Text = lvRef.SelectedItems(0).Text
            frmAEReferencec.txtName.Text = lvRef.SelectedItems(0).SubItems(1).Text
            frmAEReferencec.txtAddres.Text = lvRef.SelectedItems(0).SubItems(2).Text
            frmAEReferencec.txtTel.Text = lvRef.SelectedItems(0).SubItems(3).Text
            frmAEReferencec.txtCTRL.Text = lvRef.SelectedItems(0).SubItems(4).Text
            btnAction = 1
            frmAEReferencec.ShowDialog()
        Else
            MsgBox("Please select record to be edit!!!", vbInformation)
        End If
    End Sub


    Private Sub optYes36A_Click(sender As Object, e As EventArgs) Handles optYes34A.Click
        txtYesNo34A.Text = "Yes"
        txt34A.Enabled = True
        txt34A.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo36A_Click(sender As Object, e As EventArgs) Handles optNo34A.Click
        txtYesNo34A.Text = "No"
        txt34A.Enabled = False
        txt34A.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes36B_Click(sender As Object, e As EventArgs) Handles optYes34B.Click
        txtYesNo34B.Text = "Yes"
        txt34B.Enabled = True
        txt34B.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo36B_Click(sender As Object, e As EventArgs) Handles optNo34B.Click
        txtYesNo34B.Text = "No"
        txt34B.Enabled = False
        txt34B.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes37A_Click(sender As Object, e As EventArgs) Handles optYes35A.Click
        txtYesNo35A.Text = "Yes"
        txt35A.Enabled = True
        txt35A.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo37A_Click(sender As Object, e As EventArgs) Handles optNo35A.Click
        txtYesNo35A.Text = "No"
        txt35A.Enabled = False
        txt35A.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes37B_Click(sender As Object, e As EventArgs) Handles optYes35B.Click
        txtYesNo35B.Text = "Yes"
        txt35B.Enabled = True
        txt35B.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo37B_Click(sender As Object, e As EventArgs) Handles optNo35B.Click
        txtYesNo35B.Text = "No"
        txt35B.Enabled = False
        txt35B.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes38_Click(sender As Object, e As EventArgs) Handles optYes36.Click
        txtYesNo36.Text = "Yes"
        txt36.Enabled = True
        txt36.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo38_Click(sender As Object, e As EventArgs) Handles optNo36.Click
        txtYesNo36.Text = "No"
        txt36.Enabled = False
        txt36.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes39_Click(sender As Object, e As EventArgs) Handles optYes37.Click
        txtYesNo37.Text = "Yes"
        txt37.Enabled = True
        txt37.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo39_Click(sender As Object, e As EventArgs) Handles optNo37.Click
        txtYesNo37.Text = "No"
        txt37.Enabled = False
        txt37.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes40_Click(sender As Object, e As EventArgs) Handles optYes38A.Click, optYes39.Click, optYes38B.Click
        txtYesNo38A.Text = "Yes"
        txt38A.Enabled = True
        txt38A.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo40_Click(sender As Object, e As EventArgs) Handles optNo38A.Click, optNo39.Click, optNo38B.Click
        txtYesNo38A.Text = "No"
        txt38A.Enabled = False
        txt38A.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes41A_Click(sender As Object, e As EventArgs) Handles optYes40A.Click
        txtYesNo40A.Text = "Yes"
        txt40A.Enabled = True
        txt40A.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo41A_Click(sender As Object, e As EventArgs) Handles optNo40A.Click
        txtYesNo40A.Text = "No"
        txt40A.Enabled = False
        txt40A.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes41B_Click(sender As Object, e As EventArgs) Handles optYes40B.Click
        txtYesNo40B.Text = "Yes"
        txt40B.Enabled = True
        txt40B.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo41B_Click(sender As Object, e As EventArgs) Handles optNo40B.Click
        txtYesNo40B.Text = "No"
        txt40B.Enabled = False
        txt40B.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optYes41C_Click(sender As Object, e As EventArgs) Handles optYes40C.Click
        txtYesNo40C.Text = "Yes"
        txt40C.Enabled = True
        txt40C.Focus()
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub
    Private Sub optNo41C_Click(sender As Object, e As EventArgs) Handles optNo40C.Click, optNo40A.Click
        txtYesNo40C.Text = "No"
        txt40C.Enabled = False
        txt40C.Text = ""
        QSave = 1
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
        TabPage6.Enabled = False
        TabPage1.Enabled = False
    End Sub

    Private Sub Button9_Click() Handles Button9.Click ' Save Question
        If txtYesNo34A.Text = "Yes" And txt34A.Text = "" Then
            MsgBox("You answered YES in question, please give details")
            txt34A.Focus()
            Exit Sub
        End If
        If txtYesNo34B.Text = "Yes" And txt34B.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt34B.Focus()
            Exit Sub
        End If
        If txtYesNo35A.Text = "Yes" And txt35A.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt35A.Focus()
            Exit Sub
        End If
        If txtYesNo35B.Text = "Yes" And txt35B.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt35B.Focus()
            Exit Sub
        End If
        If txtYesNo36.Text = "Yes" And txt36.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt36.Focus()
            Exit Sub
        End If
        If txtYesNo37.Text = "Yes" And txt37.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt37.Focus()
            Exit Sub
        End If
        If txtYesNo38A.Text = "Yes" And txt38A.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt38A.Focus()
            Exit Sub
        End If
        If txtYesNo38B.Text = "Yes" And txt38B.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt38B.Focus()
            Exit Sub
        End If
        If txtYesNo39.Text = "Yes" And txt39.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt39.Focus()
            Exit Sub
        End If
        If txtYesNo40A.Text = "Yes" And txt40A.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt40A.Focus()
            Exit Sub
        End If
        If txtYesNo40B.Text = "Yes" And txt40B.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt40B.Focus()
            Exit Sub
        End If
        If txtYesNo40C.Text = "Yes" And txt40C.Text = "" Then
            MsgBox("You answered YES in a question, please give details")
            txt40C.Focus()
            Exit Sub
        End If
        On Error Resume Next

        Dim sql As String
        CONNECTION.Open()
        Dim strSQL As String = "Select * from tbl_question where empno = '" & txtEmpNo.Text.ToString & "' "
        Dim recDA As New MySqlDataAdapter(strSQL, CONNECTION)
        Dim recDS As New DataSet
        Dim rec As Integer
        recDA.Fill(recDS, "Search")
        rec = recDS.Tables("Search").Rows.Count

        If rec <> 0 Then
            sql = "UPDATE tbl_question SET empno= '" & txtEmpNo.Text & _
            "', q34A='" & txtYesNo34A.Text & _
            "', r34A='" & txt34A.Text & _
            "', q34B='" & txtYesNo34B.Text & _
            "', r34B='" & txt34B.Text & _
            "', q35A='" & txtYesNo35A.Text & _
            "', r35A='" & txt35A.Text & _
            "', q35B='" & txtYesNo35B.Text & _
            "', r35B='" & txt35B.Text & _
            "', q36='" & txtYesNo36.Text & _
            "', r36='" & txt36.Text & _
            "', q37='" & txtYesNo37.Text & _
            "', r37='" & txt37.Text & _
            "', q38A='" & txtYesNo38A.Text & _
            "', r38A='" & txt38A.Text & _
            "', q38B='" & txtYesNo38B.Text & _
            "', r38B='" & txt38B.Text & _
            "', q39='" & txtYesNo39.Text & _
            "', r39='" & txt39.Text & _
            "', q40A='" & txtYesNo40A.Text & _
            "', r40A='" & txt40A.Text & _
            "', q40B='" & txtYesNo40B.Text & _
            "', r40B='" & txt40B.Text & _
            "', q40C='" & txtYesNo40C.Text & _
            "', r40C='" & txt40C.Text & "' WHERE empno = '" & txtEmpNo.Text & "'"
        Else
            sql = "INSERT INTO tbl_question SET empno= '" & txtEmpNo.Text & _
            "', q34A='" & txtYesNo34A.Text & _
            "', r34A='" & txt34A.Text & _
            "', q34B='" & txtYesNo34B.Text & _
            "', r34B='" & txt34B.Text & _
            "', q35A='" & txtYesNo35A.Text & _
            "', r35A='" & txt35A.Text & _
            "', q35B='" & txtYesNo35B.Text & _
            "', r35B='" & txt35B.Text & _
            "', q36='" & txtYesNo36.Text & _
            "', r36='" & txt36.Text & _
            "', q37='" & txtYesNo37.Text & _
            "', r37='" & txt37.Text & _
            "', q38A='" & txtYesNo38A.Text & _
            "', r38A='" & txt38A.Text & _
            "', q38B='" & txtYesNo38B.Text & _
            "', r38B='" & txt38B.Text & _
            "', q39='" & txtYesNo39.Text & _
            "', r39='" & txt39.Text & _
            "', q40A='" & txtYesNo40A.Text & _
            "', r40A='" & txt40A.Text & _
            "', q40B='" & txtYesNo40B.Text & _
            "', r40B='" & txt40B.Text & _
            "', q40C='" & txtYesNo40C.Text & _
            "', r40C='" & txt40C.Text & "'"
        End If
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = sql

        Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            MsgBox("No record found")
            'Exit Sub
        Else
            MsgBox("Records updated")

        End If

        CONNECTION.Close()
        callPersonalInfo()
        btnAction = 0
        TabPage2.Enabled = True
        TabPage3.Enabled = True
        TabPage4.Enabled = True
        TabPage5.Enabled = True
        TabPage6.Enabled = True
        TabPage1.Enabled = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TOAction = "Single"
        frmTravelOrder.txtEmpNo.Text = txtEmpNo.Text
        frmTravelOrder.txtName.Text = txtFirstName.Text + " " + Mid(txtMiddleName.Text, 1, 1) + ". " + txtSurname.Text
        frmTravelOrder.txtDesignation.Text = cbDesignation.Text
        frmTravelOrder.ShowDialog()
    End Sub
    Private Sub optYes_CheckedChanged(sender As Object, e As EventArgs) Handles optYes.CheckedChanged
        Permanent = "Yes"
    End Sub
    Private Sub optNo_CheckedChanged(sender As Object, e As EventArgs) Handles optNo.CheckedChanged
        Permanent = "No"
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        If MsgBox("Your about to close the application, click Yes to close, click No to cancel.", vbYesNo, vbInformation) = vbYes Then
            frmMain.UnlockMenu()
            Me.Dispose()
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmdTrainingDelete_Click(sender As Object, e As EventArgs) Handles cmdTrainingDelete.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_trainings where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lvTrainings.SelectedItems(0).SubItems(6).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If
        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub

    Private Sub cmdVWDelete_Click(sender As Object, e As EventArgs) Handles cmdVWDelete.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_voluntarywork where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lvVoluntary.SelectedItems(0).SubItems(6).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If
        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub


    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        If lvEducation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        CONNECTION.Open()

        sql = "DELETE FROM tbl_educational where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lvEducation.SelectedItems(0).SubItems(9).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If
        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_eligibility where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lvCivilService.SelectedItems(0).SubItems(7).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If
        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_emp_experience where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lvWorkExp.SelectedItems(0).SubItems(9).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If
        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_child where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lvChild.SelectedItems(0).SubItems(3).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If

        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub

    Private Sub cmdOtherAddSave_Click(sender As Object, e As EventArgs) Handles cmdOtherAddSave.Click
        frmAEOtherInfo.txtEmpNo.Text = txtEmpNo.Text
        btnAction = 2
        frmAEOtherInfo.ShowDialog()
    End Sub

    Private Sub lv33_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv33.MouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenu1.Show(lv33, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub lv34_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv34.MouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenu2.Show(lv34, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub lv35_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv35.MouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenu3.Show(lv35, New Point(e.X, e.Y))
        End If
    End Sub


    Private Sub tsmLV33Edit_Click(sender As Object, e As EventArgs) Handles tsmLV33Edit.Click
        frmAEOtherInfo.txtEmpNo.Text = txtEmpNo.Text
        frmAEOtherInfo.RadioButton1.Select()
        frmAEOtherInfo.txtOptDesc.Text = lv33.SelectedItems(0).SubItems(1).Text
        frmAEOtherInfo.txtCTRL.Text = lv33.SelectedItems(0).SubItems(2).Text
        btnAction = 1
        frmAEOtherInfo.RadioButton1.Enabled = False
        frmAEOtherInfo.RadioButton2.Enabled = False
        frmAEOtherInfo.RadioButton3.Enabled = False
        frmAEOtherInfo.ShowDialog()
    End Sub

    Private Sub tsmLV33Delete_Click(sender As Object, e As EventArgs) Handles tsmLV33Delete.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_otherinfo where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lv33.SelectedItems(0).SubItems(2).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If
        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub
    Private Sub tsmLV34Edit_Click(sender As Object, e As EventArgs) Handles tsmLV34Edit.Click
        frmAEOtherInfo.txtEmpNo.Text = txtEmpNo.Text
        frmAEOtherInfo.RadioButton2.Select()
        frmAEOtherInfo.txtOptDesc.Text = lv34.SelectedItems(0).SubItems(1).Text
        frmAEOtherInfo.txtCTRL.Text = lv34.SelectedItems(0).SubItems(2).Text
        btnAction = 1
        frmAEOtherInfo.RadioButton1.Enabled = False
        frmAEOtherInfo.RadioButton2.Enabled = False
        frmAEOtherInfo.RadioButton3.Enabled = False
        frmAEOtherInfo.ShowDialog()
    End Sub

    Private Sub tsmLV34Delete_Click(sender As Object, e As EventArgs) Handles tsmLV34Delete.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_otherinfo where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lv34.SelectedItems(0).SubItems(2).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If
        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub
    Private Sub tsmLV35Edit_Click(sender As Object, e As EventArgs) Handles tsmLV35Edit.Click
        frmAEOtherInfo.txtEmpNo.Text = txtEmpNo.Text
        frmAEOtherInfo.RadioButton3.Select()
        frmAEOtherInfo.txtOptDesc.Text = lv35.SelectedItems(0).SubItems(1).Text
        frmAEOtherInfo.txtCTRL.Text = lv35.SelectedItems(0).SubItems(2).Text
        btnAction = 1
        frmAEOtherInfo.RadioButton1.Enabled = False
        frmAEOtherInfo.RadioButton2.Enabled = False
        frmAEOtherInfo.RadioButton3.Enabled = False
        frmAEOtherInfo.ShowDialog()
    End Sub

    Private Sub tsmLV35Delete_Click(sender As Object, e As EventArgs) Handles tsmLV35Delete.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_otherinfo where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lv35.SelectedItems(0).SubItems(2).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If

        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub


    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim sql As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        CONNECTION.Open()
        sql = "DELETE FROM tbl_reference where empno= '" & txtEmpNo.Text & "' and ctrno = '" & lvRef.SelectedItems(0).SubItems(4).Text & "'"
        If MsgBox("Are you sure, you want to delete the record?", vbYesNo, vbInformation) = vbYes Then
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("No record found")
                CONNECTION.Close()
                Exit Sub
            Else
                MsgBox("Records updated")
            End If
        End If
        SqlCommand.Dispose()

        CONNECTION.Close()
        callPersonalInfo()
    End Sub


    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        With openPic 'Executes a series of statements making repeated reference to a single object or structure.
            .Title = "Please Select a Image" 'title
            .InitialDirectory = "C:\" 'browse start directory
            .Filter = "JPEG(*.jpg;*.jpeg;*.jpe.*.jfif)|*.jpg; *.jpeg; *.jpe; *.jpe" 'only possible to select this extensions
            .FilterIndex = 0 'index number filter
            .FileName = "" 'empty
            Dim answ = .ShowDialog
            If answ = DialogResult.OK Then 'if answer not cancel, etc..
                empPic.ImageLocation = .FileName 'picterebox imagelocation = dlg_openfile.filename
                'If cmdUpdateCancel.Text = "Update Record" Then
                cmdNewSave.Text = "Save Record"
                cmdUpdateCancel.Text = "Cancel"
                btnAction = 1
            End If
        End With
    End Sub


    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        pNav = 0
        strSQL = "Select * from tbl_employees where empno = '" & frmSearchPersonalInfo.lvEmployees.SelectedItems(0).Text & "'"
        callPersonalInfo()
        'txtTotNum.Text = pNav + 1 & " of " & MaxRow
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TOAction = "Single"
        frmLeave.txtEmpNo.Text = txtEmpNo.Text
        frmLeave.txtName.Text = txtFirstName.Text + " " + Mid(txtMiddleName.Text, 1, 1) + ". " + txtSurname.Text
        frmLeave.ShowDialog()
    End Sub

    'Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
    '    If CheckBox3.Checked = True Then
    '        txtPAddress.Text = txtRAddress.Text
    '        txtPStreet.Text = txtRAddress.Text
    '        txtPSubdivision.Text = txtRSubdivision.Text
    '        txtPBarangay.Text = txtRBarangay.Text
    '        txtPCity.Text = txtRCity.Text
    '        txtPProvince.Text = txtRProvince.Text
    '    Else
    '        txtPAddress.Text = ""
    '        txtPStreet.Text = ""
    '        txtPSubdivision.Text = ""
    '        txtPBarangay.Text = ""
    '        txtPCity.Text = ""
    '        txtPProvince.Text = ""
    '    End If
    'End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtPAddress.Text = txtRAddress.Text
        txtPStreet.Text = txtRStreet.Text
        txtPSubdivision.Text = txtRSubdivision.Text
        txtPBarangay.Text = txtRBarangay.Text
        txtPCity.Text = txtRCity.Text
        txtPProvince.Text = txtRProvince.Text
        txtPZIPCode.Text = txtRZIPCode.Text
    End Sub

    Private Sub cbDual_CheckedChanged(sender As Object, e As EventArgs) Handles cbDual.CheckedChanged
        If cbDual.Checked = True Then
            rbByBirth.Enabled = True
            rbByNaturalization.Enabled = True
            txtCitizen.Enabled = True

            rbByBirth.Checked = True

        Else
            rbByBirth.Enabled = False
            rbByNaturalization.Enabled = False
            txtCitizen.Enabled = False

            rbByBirth.Checked = False
            rbByNaturalization.Checked = False
            txtCitizen.Text = ""
        End If
    End Sub

    Private Sub cbRetired_CheckedChanged(sender As Object, e As EventArgs) Handles cbRetired.CheckedChanged
        If cbRetired.Checked = True Then
            dtpRetired.Enabled = True
        Else
            dtpRetired.Enabled = False
        End If
    End Sub
End Class