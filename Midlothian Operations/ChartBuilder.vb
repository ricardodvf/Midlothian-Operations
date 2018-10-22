Imports System.Xml
Public Class ChartBuilder
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Click AddPoint
        ErrorProvider1.Clear()
        If ListView1.Items.Count >= 13 Then
            MsgBox("Maximum 13 items", vbInformation, "Limit reached")

            Exit Sub
        End If
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Value Can NOT be Empty")
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Value Can NOT be Empty")
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Value Can NOT be Empty")
            Exit Sub
        End If
        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "Value Can NOT be Empty")
            Exit Sub
        End If


        If ListView1.Items.Count >= 13 Then
            MsgBox("Maximum 13 items", vbInformation, "Limit reached")

            Exit Sub
        End If
        If IsNumeric(TextBox3.Text) = False Then

            ErrorProvider1.SetError(TextBox3, "Value must be numeric")
            Exit Sub
        End If

        If IsNumeric(TextBox4.Text) = False Then

            ErrorProvider1.SetError(TextBox4, "Value must be numeric")
            Exit Sub
        End If

        Dim Arr As String() = New String(6) {}
        'Dim itm As ListViewItem
        'add items to ListView
        Dim CSystem As String
        If RadioButton1.Checked = True Then
            CSystem = "Wonderware"
        Else
            CSystem = "LDMS"
        End If

        Call AddItemtoListView(TextBox1.Text, CSystem, TextBox2.Text, ColorPickEdit1.Color.ToArgb.ToString, TextBox3.Text, TextBox4.Text)
        Call Save()
        Call MainPage.LoadTrendsSettings()

        Select Case RadioGroup1.SelectedIndex
            Case 0
                Call MainPage.AddSingleSeries(MainPage.ChartHistorian, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 1
                'RawMill
                Call MainPage.AddSingleSeries(MainPage.VRMChart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 2
                Call MainPage.AddSingleSeries(MainPage.PHTChart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 3
                Call MainPage.AddSingleSeries(MainPage.KilnChart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 4
                Call MainPage.AddSingleSeries(MainPage.CoolerChart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 5
                Call MainPage.AddSingleSeries(MainPage.FM1Chart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 6
                Call MainPage.AddSingleSeries(MainPage.FM2Chart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 7
                Call MainPage.AddSingleSeries(MainPage.FM3Chart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 8
                Call MainPage.AddSingleSeries(MainPage.FM4Chart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 9
                Call MainPage.AddSingleSeries(MainPage.FM5Chart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 10
                Call MainPage.AddSingleSeries(MainPage.FM6Chart, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            Case 11
                Call MainPage.AddSingleSeries(MainPage.FM6Chart2, TextBox2.Text, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
        End Select


    End Sub

    Private Sub AddItemtoListView(TagName As String, CSystem As String, SName As String, SColor As String, MaxRange As String, MinRange As String)
        Dim Arr As String() = New String(6) {}
        Dim itm As ListViewItem
        'add items to ListView
        Arr(0) = TagName
        Arr(1) = CSystem
        Arr(2) = SName
        Arr(3) = SColor
        Arr(4) = MaxRange
        Arr(5) = MinRange
        itm = New ListViewItem(Arr)
        itm.UseItemStyleForSubItems = False
        itm.SubItems(3).BackColor = Color.FromArgb(CType(SColor, Integer))
        itm.SubItems(3).ForeColor = Color.FromArgb(CType(SColor, Integer))

        ListView1.Items.Add(itm)
    End Sub


    Private Sub HistorianProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ColorPickEdit1.Color = Color.Red
        Call ReadXMLDataSet("Historian.xml")

    End Sub

    Public Sub EnterTag(A As String)
        TextBox1.Text = A
    End Sub



    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)
        'Cancel Button
        Close()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        'Click OK Button
        Call Save()

        Call MainPage.LoadTrendsSettings()

        Close()
    End Sub

    Private Sub Save()
        Try
            Select Case RadioGroup1.SelectedIndex
                Case 0
                    Call WriteXMLDataSet("Historian.xml")
                Case 1
                    Call WriteXMLDataSet("RawMill.xml")
                Case 2
                    Call WriteXMLDataSet("PHT.xml")
                Case 3
                    Call WriteXMLDataSet("Kiln.xml")
                Case 4
                    Call WriteXMLDataSet("Cooler.xml")
                Case 5
                    Call WriteXMLDataSet("FM1.xml")
                Case 6
                    Call WriteXMLDataSet("FM2.xml")
                Case 7
                    Call WriteXMLDataSet("FM3.xml")
                Case 8
                    Call WriteXMLDataSet("FM4.xml")
                Case 9
                    Call WriteXMLDataSet("FM5.xml")
                Case 10
                    Call WriteXMLDataSet("FM6-1.xml")
                Case 11
                    Call WriteXMLDataSet("FM6-2.xml")

            End Select
        Catch ex As Exception

        End Try

    End Sub

    Dim DTHistorian As New DataTable()
    Private Sub WriteXMLDataSet(FN As String)
        DTHistorian.Clear()
        DTHistorian.Columns.Clear()
        DTHistorian.TableName = FN
        Try
            DTHistorian.Columns.Add(New DataColumn("TagName", Type.GetType("System.String")))
            DTHistorian.Columns.Add(New DataColumn("System", Type.GetType("System.String")))
            DTHistorian.Columns.Add(New DataColumn("Series_Name", Type.GetType("System.String")))
            DTHistorian.Columns.Add(New DataColumn("Color", Type.GetType("System.String")))
            DTHistorian.Columns.Add(New DataColumn("Max", Type.GetType("System.String")))
            DTHistorian.Columns.Add(New DataColumn("Min", Type.GetType("System.String")))
        Catch ex As Exception
            ' siStatus.Caption = "Error"
            'siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Dim i As Integer = 0
        Do
            fillRows(ListView1.Items(i).SubItems(0).Text, ListView1.Items(i).SubItems(1).Text, ListView1.Items(i).SubItems(2).Text, ListView1.Items(i).SubItems(3).Text, ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(5).Text)
            i = i + 1
        Loop Until i >= ListView1.Items.Count

        Try
            DTHistorian.WriteXml(FN, XmlWriteMode.WriteSchema)

        Catch ex As Exception

            ' siStatus.Caption = "Error"
            'siInfo.Caption = "Update from XML - " & ex.Message
        End Try

        DTHistorian.Clear()
        DTHistorian.Columns.Clear()


    End Sub

    Private Sub fillRows(ByVal STagName As String, ByVal SSyst As String, ByVal SNAme As String, SColor As String, SMax As String, SMin As String)
        Dim dr As DataRow = DTHistorian.NewRow()
        dr("TagName") = STagName
        dr("System") = SSyst
        dr("Series_Name") = SNAme
        dr("Color") = SColor
        dr("Max") = SMax
        dr("Min") = SMin
        DTHistorian.Rows.Add(dr)
    End Sub
    Private Sub ReadXMLDataSet(FN As String)
        'Reads XML file with the chart configuration
        Dim xmlFile As XmlReader = XmlReader.Create(FN, New XmlReaderSettings())
        Dim ds As New DataSet
        Try
            ds.ReadXml(xmlFile)
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Call AddItemtoListView(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2), ds.Tables(0).Rows(i).Item(3), ds.Tables(0).Rows(i).Item(4), ds.Tables(0).Rows(i).Item(5))

            Next
        Catch ex As Exception

        End Try
        Try
            xmlFile.Close()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        'When user selects a different chart it loads the data
        ListView1.Items.Clear()
        Try
            Select Case RadioGroup1.SelectedIndex
                Case 0
                    ReadXMLDataSet("Historian.xml")

                Case 1
                    ReadXMLDataSet("RawMill.xml")

                Case 2
                    ReadXMLDataSet("PHT.xml")

                Case 3
                    ReadXMLDataSet("Kiln.xml")

                Case 4
                    ReadXMLDataSet("Cooler.xml")

                Case 5
                    ReadXMLDataSet("FM1.xml")

                Case 6
                    ReadXMLDataSet("FM2.xml")

                Case 7
                    ReadXMLDataSet("FM3.xml")

                Case 8
                    ReadXMLDataSet("FM4.xml")

                Case 9
                    ReadXMLDataSet("FM5.xml")

                Case 10
                    ReadXMLDataSet("FM6-1.xml")

                Case 11
                    ReadXMLDataSet("FM6-2.xml")

            End Select
        Catch ex As Exception
            ListView1.Items.Clear()
        End Try

    End Sub

    Private Sub RadioGroup1_Click(sender As Object, e As EventArgs) Handles RadioGroup1.Click
        Call Save()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'Populates all fields when user clicks on any item from the list
        If ListView1.SelectedItems.Count > 0 Then
            TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems.Item(0).SubItems(2).Text
            TextBox3.Text = ListView1.SelectedItems.Item(0).SubItems(4).Text
            TextBox4.Text = ListView1.SelectedItems.Item(0).SubItems(5).Text
            ColorPickEdit1.Color = Color.FromArgb(CType(ListView1.SelectedItems.Item(0).SubItems(3).Text, Integer))
            If ListView1.SelectedItems.Item(0).SubItems(1).Text = "Wonderware" Then
                RadioButton1.Checked = True
                RadioButton2.Checked = False
            Else
                RadioButton1.Checked = False
                RadioButton2.Checked = True
            End If

        End If
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'Click remove item button
        ErrorProvider1.Clear()

        If ListView1.SelectedItems.Count > 0 Then
            Dim SNameOld As String = ListView1.SelectedItems.Item(0).SubItems(2).Text
            Try

                Select Case RadioGroup1.SelectedIndex
                    Case 0
                        Call MainPage.DeleteSingleSeries(MainPage.ChartHistorian, SNameOld)
                    Case 1
                        'RawMill
                        Call MainPage.DeleteSingleSeries(MainPage.VRMChart, SNameOld)
                    Case 2
                        Call MainPage.DeleteSingleSeries(MainPage.PHTChart, SNameOld)
                    Case 3
                        Call MainPage.DeleteSingleSeries(MainPage.KilnChart, SNameOld)
                    Case 4
                        Call MainPage.DeleteSingleSeries(MainPage.CoolerChart, SNameOld)
                    Case 5
                        Call MainPage.DeleteSingleSeries(MainPage.FM1Chart, SNameOld)
                    Case 6
                        Call MainPage.DeleteSingleSeries(MainPage.FM2Chart, SNameOld)
                    Case 7
                        Call MainPage.DeleteSingleSeries(MainPage.FM3Chart, SNameOld)
                    Case 8
                        Call MainPage.DeleteSingleSeries(MainPage.FM4Chart, SNameOld)
                    Case 9
                        Call MainPage.DeleteSingleSeries(MainPage.FM5Chart, SNameOld)
                    Case 10
                        Call MainPage.DeleteSingleSeries(MainPage.FM6Chart, SNameOld)
                    Case 11
                        Call MainPage.DeleteSingleSeries(MainPage.FM6Chart2, SNameOld)
                End Select

                ListView1.Items.Remove(ListView1.SelectedItems(0))

                Call Save()
                Call MainPage.LoadTrendsSettings()




            Catch ex As Exception
                ErrorProvider1.SetError(SimpleButton3, "Nothing Selected")
            End Try
        End If
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'Click Modify Button

        If ListView1.SelectedItems.Count > 0 Then
            Dim SNameOld As String = ListView1.SelectedItems.Item(0).SubItems(2).Text
            ListView1.SelectedItems.Item(0).SubItems(0).Text = TextBox1.Text
            If RadioButton1.Checked = True Then
                ListView1.SelectedItems.Item(0).SubItems(1).Text = "Wonderware"
            Else
                ListView1.SelectedItems.Item(0).SubItems(1).Text = "LDMS"
            End If


            ListView1.SelectedItems.Item(0).SubItems(2).Text = TextBox2.Text
            ListView1.SelectedItems.Item(0).SubItems(4).Text = TextBox3.Text
            ListView1.SelectedItems.Item(0).SubItems(5).Text = TextBox4.Text
            ListView1.SelectedItems.Item(0).SubItems(3).Text = ColorPickEdit1.Color.ToArgb.ToString
            ListView1.SelectedItems.Item(0).SubItems(3).BackColor = ColorPickEdit1.Color
            ListView1.SelectedItems.Item(0).SubItems(3).ForeColor = ColorPickEdit1.Color
            Call Save()
            Call MainPage.LoadTrendsSettings()

            Select Case RadioGroup1.SelectedIndex
                Case 0
                    Call MainPage.UpdateSingleSeries(MainPage.ChartHistorian, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 1
                    'RawMill
                    Call MainPage.UpdateSingleSeries(MainPage.VRMChart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 2
                    Call MainPage.UpdateSingleSeries(MainPage.PHTChart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 3
                    Call MainPage.UpdateSingleSeries(MainPage.KilnChart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 4
                    Call MainPage.UpdateSingleSeries(MainPage.CoolerChart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 5
                    Call MainPage.UpdateSingleSeries(MainPage.FM1Chart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 6
                    Call MainPage.UpdateSingleSeries(MainPage.FM2Chart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 7
                    Call MainPage.UpdateSingleSeries(MainPage.FM3Chart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 8
                    Call MainPage.UpdateSingleSeries(MainPage.FM4Chart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 9
                    Call MainPage.UpdateSingleSeries(MainPage.FM5Chart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 10
                    Call MainPage.UpdateSingleSeries(MainPage.FM6Chart, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
                Case 11
                    Call MainPage.UpdateSingleSeries(MainPage.FM6Chart2, TextBox2.Text, SNameOld, TextBox3.Text, TextBox4.Text, ColorPickEdit1.Color)
            End Select
        End If
    End Sub

    Private Sub SimpleButton5_Click_1(sender As Object, e As EventArgs) Handles SimpleButton5.Click

        If RadioButton2.Checked = True Then
            Dim A As New LDMSTagSelector
            A.Show(Me)
        Else
            Dim A As New Wonderware_Tag_Selector
            A.Show(Me)
        End If


    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        'Save this chart button
        Try
            SaveFileDialog1.Filter = "Chart Configuration File (*.XML) | *.xml"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName <> "" Then
                Call WriteXMLDataSet(SaveFileDialog1.FileName)
            End If
        Catch ex As Exception


        End Try

    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        'Load a chart button
        Try
            ListView1.Items.Clear()
            OpenFileDialog1.Filter = "Chart Configuration File (*.XML) | *.xml"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" And OpenFileDialog1.CheckFileExists = True Then
                Call ReadXMLDataSet(OpenFileDialog1.FileName)
            End If
            'Call Save()
        Catch ex As Exception
        End Try
        Call Save()
        If RadioGroup1.SelectedIndex = 0 Then
            Call MainPage.RefreshHistorianChart()
        End If

    End Sub
End Class