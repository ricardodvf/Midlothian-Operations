Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraCharts
Imports DevExpress.LookAndFeel
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices 'APIs For System Events
Imports DevExpress.XtraBars.Navigation
Imports System.Xml

Public Class MainPage

    Public Enum EXECUTION_STATE As UInteger ' Determine Monitor State
        ES_AWAYMODE_REQUIRED = &H40
        ES_CONTINUOUS = &H80000000UI
        ES_DISPLAY_REQUIRED = &H2
        ES_SYSTEM_REQUIRED = &H1
        ' Legacy flag, should not be used.
        ' ES_USER_PRESENT = 0x00000004
    End Enum

    'Enables an application to inform the system that it is in use, thereby preventing the system from entering sleep or turning off the display while the application is running.
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetThreadExecutionState(ByVal esFlags As EXECUTION_STATE) As EXECUTION_STATE
    End Function

    'This function queries or sets system-wide parameters, and updates the user profile during the process.
    <DllImport("user32", EntryPoint:="SystemParametersInfo", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SystemParametersInfo(ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    End Function

    Private Const SPI_SETSCREENSAVETIMEOUT As Int32 = 15

    Public Sub KeepMonitorActive()

        SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED + EXECUTION_STATE.ES_CONTINUOUS) 'Do not Go To Sleep

    End Sub

    Public Sub RestoreMonitorSettings()

        SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS) 'Restore Previous Settings, ie, Go To Sleep Again

    End Sub
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()

    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")

    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Private Sub tmrUpdateRealTime_Tick(sender As Object, e As EventArgs) Handles tmrUpdateRealTime.Tick
        Call UpdateRealTime()
        Dim ParamVRM As New BGWArguments() With {.Chart = VRMChart, .DaTable = DTBRawMill}
        Dim ParamFM6_2 As New BGWArguments() With {.Chart = FM6Chart2, .DaTable = DTBFM6_2}
        Dim ParamFM6_1 As New BGWArguments() With {.Chart = FM6Chart, .DaTable = DTBFM6_1}
        Dim ParamKiln As New BGWArguments() With {.Chart = KilnChart, .DaTable = DTBKiln}
        Dim ParamPHT As New BGWArguments() With {.Chart = PHTChart, .DaTable = DTBPHT}
        Dim ParamCooler As New BGWArguments() With {.Chart = CoolerChart, .DaTable = DTBCooler}
        Dim ParamFM1 As New BGWArguments() With {.Chart = FM1Chart, .DaTable = DTBFM1}
        Dim ParamFM2 As New BGWArguments() With {.Chart = FM2Chart, .DaTable = DTBFM2}
        Dim ParamFM3 As New BGWArguments() With {.Chart = FM3Chart, .DaTable = DTBFM3}
        Dim ParamFM4 As New BGWArguments() With {.Chart = FM4Chart, .DaTable = DTBFM4}
        Dim ParamFM5 As New BGWArguments() With {.Chart = FM5Chart, .DaTable = DTBFM5}

        If BGW1.IsBusy = False And My.Settings.RMTrendActive = True Then

            BGW1.RunWorkerAsync(ParamVRM)
        End If

        If BGW2.IsBusy = False And My.Settings.FM6_2TrendActive = True Then
            BGW2.RunWorkerAsync(ParamFM6_2)
        End If
        If BGW3.IsBusy = False And My.Settings.FM6_1TrendActive = True Then
            BGW3.RunWorkerAsync(ParamFM6_1)
        End If
        If BGW4.IsBusy = False And My.Settings.KilnTrendActive = True Then
            BGW4.RunWorkerAsync(ParamKiln)
        End If
        If BGW5.IsBusy = False And My.Settings.CoolerTrendActive Then
            BGW5.RunWorkerAsync(ParamCooler)
        End If
        If BGW6.IsBusy = False And My.Settings.PHTTrendActive = True Then
            BGW6.RunWorkerAsync(ParamPHT)
        End If
        If BGW7.IsBusy = False And My.Settings.FM1TrendActive = True Then
            BGW7.RunWorkerAsync(ParamFM1)
        End If
        If BGW8.IsBusy = False And My.Settings.FM2TrendActive = True Then
            BGW8.RunWorkerAsync(ParamFM2)
        End If
        If BGW9.IsBusy = False And My.Settings.FM3TrendActive = True Then
            BGW9.RunWorkerAsync(ParamFM3)
        End If
        If BGW10.IsBusy = False And My.Settings.FM4TrendActive = True Then
            BGW10.RunWorkerAsync(ParamFM4)
        End If
        If BGW12.IsBusy = False And My.Settings.FM5TrendActive = True Then
            BGW12.RunWorkerAsync(ParamFM5)
        End If
    End Sub

    Private Sub UpdateChart(Tags As DataTable, Charts As ChartControl)

        Dim DTBValues As DataTable = GetValuesfromServer(Tags)
        Dim X As Integer = 0
        For Each Value In DTBValues.Rows
            Call AddPointstoChart(Charts, X, Now(), Value(2))
            X = X + 1
        Next

    End Sub

    Public Class BGWArguments
        Public Chart As ChartControl
        Public DaTable As DataTable
    End Class
    Private Sub BGW1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW1.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW2.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub


    Private Sub BGW3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW3.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW4.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW5_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW5.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub
    Private Sub BGW6_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW6.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW7_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW7.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW8_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW8.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW9_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW9.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW10_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW10.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW12_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW12.DoWork
        Dim Parameters As BGWArguments = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters.DaTable)
        Parameters.DaTable = DTBValues

        e.Result = Parameters
    End Sub
    Private Sub BGW1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW1.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub
    Private Sub BGW2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW2.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub
    Private Sub BGW3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW3.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub
    Private Sub BGW4_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW4.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub

    Private Sub BGW5_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW5.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub

    Private Sub BGW6_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW6.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub

    Private Sub BGW7_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW7.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub

    Private Sub BGW8_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW8.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub

    Private Sub BGW9_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW9.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub

    Private Sub BGW10_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW10.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub

    Private Sub BGW12_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW12.RunWorkerCompleted
        Dim Parameters As BGWArguments = e.Result
        Dim X As Integer = 0
        For Each Value In Parameters.DaTable.Rows
            Call AddPointstoChart(Parameters.Chart, X, Now(), Value(2))
            X = X + 1
        Next
    End Sub
    Private Sub AddPointstoChart(PChart As ChartControl, PSeries As Integer, PTime As Date, PValue As Double)
        Try
            PChart.Series.BeginUpdate()
            If PChart.Series(PSeries).Points.Count >= 1440 Then
                PChart.Series(PSeries).Points.RemoveAt(0)

            End If
            PChart.Series(PSeries).Points.Add(New SeriesPoint(PTime, PValue))
            PChart.Series.EndUpdate()
        Catch ex As Exception
            Call LogErrorMessage(ex.Message, "AddPointstoChart()")
        End Try

    End Sub
    Private Sub AutoResize()
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        FM6Chart.Size = New Size(screenWidth - FM6Chart.Location.X - 20, FM6Chart.Height)
        FM6Chart2.Size = New Size(screenWidth - FM6Chart2.Location.X - 20, FM6Chart2.Height)

        PictureBox1.Location = New Point(screenWidth - PictureBox1.Width - 20, PictureBox1.Location.Y)
        PictureBox2.Location = New Point(screenWidth - PictureBox2.Width - 20, 0)
        PictureBox3.Location = New Point(screenWidth - PictureBox3.Width - 20, 0)
        PictureBox4.Location = New Point(screenWidth - PictureBox4.Width - 20, 0)
        PictureBox5.Location = New Point(screenWidth - PictureBox4.Width - 20, 0)
        PictureBox6.Location = New Point(screenWidth - PictureBox4.Width - 20, 0)
        PictureBox7.Location = New Point(screenWidth - PictureBox4.Width - 20, 0)
        PictureBox8.Location = New Point(screenWidth - PictureBox4.Width - 20, 0)
        PictureBox9.Location = New Point(screenWidth - PictureBox4.Width - 20, 0)
        PictureBox10.Location = New Point(screenWidth - PictureBox4.Width - 20, 0)
        PictureBox11.Location = New Point(screenWidth - PictureBox4.Width - 20, 0)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LDMS7_MIDDataSet.LabData_FinishMill' table. You can move, or remove it, as needed.
        BarCheckItem1.Checked = My.Settings.FM6_1TrendActive
        BarCheckItem2.Checked = My.Settings.FM6_2TrendActive
        BarCheckItem3.Checked = My.Settings.RMTrendActive
        BarCheckItem4.Checked = My.Settings.KilnTrendActive
        BarCheckItem5.Checked = My.Settings.PHTTrendActive
        BarCheckItem6.Checked = My.Settings.CoolerTrendActive
        BarCheckItem7.Checked = My.Settings.FM1TrendActive
        BarCheckItem8.Checked = My.Settings.FM2TrendActive
        BarCheckItem9.Checked = My.Settings.FM3TrendActive
        BarCheckItem10.Checked = My.Settings.FM4TrendActive
        BarCheckItem11.Checked = My.Settings.FM5TrendActive
        BarCheckItem12.Checked = My.Settings.QualityTrendActive




        Call KeepMonitorActive()
        Call AutoResize()
        RibbonPageGroup2.Visible = False
        ribbonControl.Minimized = True
        DTPFrom.EditValue = DateAdd(DateInterval.Day, -1, Now())
        DTPTo.EditValue = Now()

        Call LoadTrendsSettings()
        Call Regenerate_all_Charts()

    End Sub

    Dim ConfPerm As New My.MySettings
    Dim sqlConnection1 As New SqlConnection(String.Format("Data Source={0};Initial Catalog=Runtime;Persist Security Info=True;User ID={1}; password={2}", ConfPerm.TagServer, ConfPerm.TagServerUserName, DecryptHSA256(ConfPerm.TagServerPassword)))


    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader


    'Global declaration of DataTables for the different Charts
    Dim DTBHistorian As DataTable = ReadXMLtoDataTable("Historian.xml")
    Dim DTBRawMill As DataTable = ReadXMLtoDataTable("RawMill.xml")
    Dim DTBPHT As DataTable = ReadXMLtoDataTable("PHT.xml")
    Dim DTBKiln As DataTable = ReadXMLtoDataTable("Kiln.xml")
    Dim DTBCooler As DataTable = ReadXMLtoDataTable("Cooler.xml")
    Dim DTBFM1 As DataTable = ReadXMLtoDataTable("FM1.xml")
    Dim DTBFM2 As DataTable = ReadXMLtoDataTable("FM2.xml")
    Dim DTBFM3 As DataTable = ReadXMLtoDataTable("FM3.xml")
    Dim DTBFM4 As DataTable = ReadXMLtoDataTable("FM4.xml")
    Dim DTBFM5 As DataTable = ReadXMLtoDataTable("FM5.xml")
    Dim DTBFM6_1 As DataTable = ReadXMLtoDataTable("FM6-1.xml")
    Dim DTBFM6_2 As DataTable = ReadXMLtoDataTable("FM6-2.xml")
    Public Sub LoadTrendsSettings()
        Try
            DTBHistorian.Clear()
            DTBHistorian = ReadXMLtoDataTable("Historian.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBRawMill.Clear()
            DTBRawMill = ReadXMLtoDataTable("RawMill.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBPHT.Clear()
            DTBPHT = ReadXMLtoDataTable("PHT.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBKiln.Clear()
            DTBKiln = ReadXMLtoDataTable("Kiln.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBCooler.Clear()
            DTBCooler = ReadXMLtoDataTable("Cooler.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBFM1.Clear()
            DTBFM1 = ReadXMLtoDataTable("FM1.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBFM2.Clear()
            DTBFM2 = ReadXMLtoDataTable("FM2.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBFM3.Clear()
            DTBFM3 = ReadXMLtoDataTable("FM3.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBFM4.Clear()
            DTBFM4 = ReadXMLtoDataTable("FM4.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBFM5.Clear()
            DTBFM5 = ReadXMLtoDataTable("FM5.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBFM6_1.Clear()
            DTBFM6_1 = ReadXMLtoDataTable("FM6-1.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try
        Try
            DTBFM6_2.Clear()
            DTBFM6_2 = ReadXMLtoDataTable("FM6-2.xml")
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "Update from XML - " & ex.Message
        End Try



    End Sub
    Private Sub Regenerate_all_Charts()
        Call GenerateChartSeries(DTBRawMill, VRMChart)
        Call GenerateChartSeries(DTBPHT, PHTChart)
        Call GenerateChartSeries(DTBCooler, CoolerChart)
        Call GenerateChartSeries(DTBKiln, KilnChart)
        Call GenerateChartSeries(DTBFM1, FM1Chart)
        Call GenerateChartSeries(DTBFM2, FM2Chart)
        Call GenerateChartSeries(DTBFM3, FM3Chart)
        Call GenerateChartSeries(DTBFM4, FM4Chart)
        Call GenerateChartSeries(DTBFM5, FM5Chart)
        Call GenerateChartSeries(DTBFM6_1, FM6Chart)
        Call GenerateChartSeries(DTBFM6_2, FM6Chart2)
        Call GenerateChartSeries(DTBHistorian, ChartHistorian)

    End Sub
    Public Sub UpdateSingleSeries(Cchart As ChartControl, SNameNew As String, SNameOld As String, SMax As Double, SMin As Double, SColor As Color)
        Cchart.Series(SNameOld).ToString()
        CType(Cchart.Series(SNameOld).View, SwiftPlotSeriesView).AxisY.WholeRange.MaxValue = SMax
        CType(Cchart.Series(SNameOld).View, SwiftPlotSeriesView).AxisY.WholeRange.MinValue = SMin
        CType(Cchart.Series(SNameOld).View, SwiftPlotSeriesView).AxisY.VisualRange.MaxValue = SMax
        CType(Cchart.Series(SNameOld).View, SwiftPlotSeriesView).AxisY.VisualRange.MinValue = SMin
        CType(Cchart.Series(SNameOld).View, SwiftPlotSeriesView).AxisY.Color = SColor
        Cchart.Series(SNameOld).Name = SNameNew
        Cchart.Series(SNameNew).View.Color = SColor

    End Sub

    Public Sub DeleteSingleSeries(Cchart As ChartControl, SName As String)
        Cchart.Series.Remove(Cchart.Series(SName))
    End Sub

    Public Sub AddSingleSeries(Cchart As ChartControl, SName As String, SMax As Double, SMin As Double, SColor As Color)
        Dim NS As New Series(SName, ViewType.SwiftPlot)
        Dim diagram As SwiftPlotDiagram
        'Set the colors
        NS.Visible = True
        NS.View.Color = SColor
        Cchart.Series.Add(NS)
        If Cchart.Series.Count = 1 Then
            'Add the series and configure primary Y axis
            Cchart.Series(SName).View.Color = SColor
            diagram = Cchart.Diagram
            diagram.AxisY.VisualRange.Auto = False
            diagram.AxisY.Color = SColor
            diagram.AxisY.WholeRange.Auto = False
            diagram.AxisY.WholeRange.MaxValue = SMax
            diagram.AxisY.WholeRange.MinValue = SMin
            diagram.AxisY.VisualRange.MaxValue = SMax
            diagram.AxisY.VisualRange.MinValue = SMin
            diagram.AxisY.WholeRange.SideMarginsValue = 0
            diagram.AxisY.VisualRange.SideMarginsValue = 0
            diagram.Margins.Left = 0
            diagram.Margins.Right = 0


        Else
            'Create Secondary Y Axis and it's properties.
            Dim SAxis As New SwiftPlotDiagramSecondaryAxisY(SName)
            SAxis.Color = SColor
            SAxis.WholeRange.Auto = False
            SAxis.VisualRange.Auto = False
            SAxis.WholeRange.MaxValue = SMax
            SAxis.WholeRange.MinValue = SMin
            SAxis.VisualRange.MaxValue = SMax
            SAxis.VisualRange.MinValue = SMin
            SAxis.WholeRange.SideMarginsValue = 0
            SAxis.VisualRange.SideMarginsValue = 0
            SAxis.Alignment = AxisAlignment.Near
            'Set secondary axis for this series
            CType(Cchart.Diagram, SwiftPlotDiagram).SecondaryAxesY.Add(SAxis)
            'Add the series to the chart
            CType(Cchart.Series(SName).View, SwiftPlotSeriesView).AxisY = SAxis
        End If
        'Set the series properties
        Cchart.Series(SName).View.Color = SColor
        Cchart.Series(SName).ArgumentScaleType = ScaleType.DateTime
        Cchart.Series(SName).ArgumentDataMember = "Date"
        Cchart.Series(SName).ValueScaleType = ScaleType.Numerical
    End Sub
    Private Sub GenerateChartSeries(DaTable As DataTable, Cchart As ChartControl)
        'Erases all the series of a chartcontrol and then reads the datatable to populate the chart control with the new series.



        CType(Cchart.Diagram, SwiftPlotDiagram).SecondaryAxesY.Clear()
        Cchart.DataSource = vbNullString
        If Cchart.Series.Count > 0 Then
            Do
                Cchart.Series.Remove(Cchart.Series(0))

            Loop Until Cchart.Series.Count <= 0

        End If
        Dim X As Integer = 0
        Dim diagram As SwiftPlotDiagram

        For Each Row In DaTable.Rows
            'Adds a series to the  Chart after the data table has been created adding a new datatable
            'Declare the new series
            Dim NS As New Series(Row(2), ViewType.SwiftPlot)
            'Set the colors
            NS.Visible = True
            NS.View.Color = Color.FromArgb(CType(Row(3), Integer))
            Cchart.Series.Add(NS)
            If Cchart.Series.Count = 1 Then
                'Add the series and configure primary Y axis
                Cchart.Series(X).View.Color = Color.FromArgb(CType(Row(3), Integer))
                diagram = Cchart.Diagram
                diagram.AxisY.VisualRange.Auto = False
                diagram.AxisY.Color = Color.FromArgb(CType(Row(3), Integer))
                diagram.AxisY.WholeRange.Auto = False
                diagram.AxisY.WholeRange.MaxValue = CType(Row(4), Double)
                diagram.AxisY.WholeRange.MinValue = CType(Row(5), Double)
                diagram.AxisY.VisualRange.MaxValue = CType(Row(4), Double)
                diagram.AxisY.VisualRange.MinValue = CType(Row(5), Double)
                diagram.AxisY.WholeRange.SideMarginsValue = 0
                diagram.AxisY.VisualRange.SideMarginsValue = 0


            Else
                'Create Secondary Y Axis and it's properties.
                Dim SAxis As New SwiftPlotDiagramSecondaryAxisY(Row(2))
                SAxis.Color = Color.FromArgb(CType(Row(3), Integer))
                SAxis.WholeRange.Auto = False
                SAxis.VisualRange.Auto = False
                SAxis.WholeRange.MaxValue = CType(Row(4), Double)
                SAxis.VisualRange.MaxValue = CType(Row(4), Double)
                SAxis.WholeRange.MinValue = CType(Row(5), Double)
                SAxis.VisualRange.MinValue = CType(Row(5), Double)
                SAxis.Alignment = AxisAlignment.Near
                SAxis.WholeRange.SideMarginsValue = 0
                SAxis.VisualRange.SideMarginsValue = 0
                'Set secondary axis for this series
                CType(Cchart.Diagram, SwiftPlotDiagram).SecondaryAxesY.Add(SAxis)
                'Add the series to the chart
                CType(Cchart.Series(Row(2)).View, SwiftPlotSeriesView).AxisY = SAxis
            End If
            'Set the series properties
            Cchart.Series(Row(2)).View.Color = Color.FromArgb(CType(Row(3), Integer))
            Cchart.Series(Row(2)).ArgumentScaleType = ScaleType.DateTime
            Cchart.Series(Row(2)).ArgumentDataMember = "Date"
            Cchart.Series(Row(2)).ValueScaleType = ScaleType.Numerical
            ' Cchart.Series(Row(2)).ValueDataMembers.AddRange(New String() {Row(2)})

            X = X + 1
        Next
        Exit Sub
        Cchart.Series(0).View.Color = Color.Red

        'CType(NS.View, SwiftPlotSeriesView).AxisY = SAxis
        CType(Cchart.Diagram, XYDiagram).AxisY.Color = Color.Red
        CType(Cchart.Diagram, XYDiagram).SecondaryAxesY(0).Color = Color.Blue
    End Sub

    Private Function ReadXMLtoDataTable(FN As String) As DataTable
        'Dim xmlFile As XmlReader = XmlReader.Create(FN, New XmlReaderSettings())
        Dim DT As New DataTable
        Try
            DT.ReadXml(FN)
            'xmlFile.Close()
        Catch ex As Exception
            Call LogErrorMessage(ex.Message, "Main Page ReadXMLtoDataTable()")
        End Try
        Return DT
    End Function


    Private Sub BGW11_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW11.DoWork
        Dim Parameters As DataTable = e.Argument


        Dim DTBValues As DataTable = GetValuesfromServer(Parameters)
        Parameters = DTBValues

        e.Result = Parameters
    End Sub

    Private Sub BGW11_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW11.RunWorkerCompleted
        Dim Parameters As DataTable = e.Result
        Dim KilnFeed As Double = Parameters.Rows(0)(2)
        Dim VRMFeed As Double = Parameters.Rows(1)(2)
        Dim FM1Feed As Double = Parameters.Rows(2)(2)
        Dim FM2Feed As Double = Parameters.Rows(3)(2)
        Dim FM3Feed As Double = Parameters.Rows(4)(2)
        Dim FM4Feed As Double = Parameters.Rows(5)(2)
        Dim FM5Feed As Double = Parameters.Rows(6)(2)
        Dim FM6Feed As Double = Parameters.Rows(7)(2)


        DigitalGauge1.Text = KilnFeed
        DigitalGauge11.Text = VRMFeed
        DigitalGauge13.Text = FM1Feed
        DigitalGauge15.Text = FM2Feed
        DigitalGauge17.Text = FM3Feed
        DigitalGauge19.Text = FM4Feed
        DigitalGauge21.Text = FM5Feed
        DigitalGauge22.Text = FM6Feed

        If KilnFeed > 300 Then
            Label1.ForeColor = Color.Green
        Else
            Label1.ForeColor = Color.Red
        End If
        If VRMFeed > 300 Then
            Label2.ForeColor = Color.Green
        Else
            Label2.ForeColor = Color.Red
        End If

        If FM1Feed > 10 Then
            Label3.ForeColor = Color.Green
        Else
            Label3.ForeColor = Color.Red
        End If
        If FM2Feed > 10 Then
            Label4.ForeColor = Color.Green
        Else
            Label4.ForeColor = Color.Red
        End If
        If FM3Feed > 10 Then
            Label5.ForeColor = Color.Green
        Else
            Label5.ForeColor = Color.Red
        End If
        If FM4Feed > 10 Then
            Label6.ForeColor = Color.Green
        Else
            Label6.ForeColor = Color.Red
        End If
        If FM5Feed > 10 Then
            Label7.ForeColor = Color.Green
        Else
            Label7.ForeColor = Color.Red
        End If
        If FM6Feed > 10 Then
            Label8.ForeColor = Color.Green
        Else
            Label8.ForeColor = Color.Red
        End If
        Call UpdateDownTimes()
    End Sub
    Private Sub UpdateRealTime()


        Dim DaTable As New DataTable
        Dim RR As DataRow
        DaTable.Columns.Add(New DataColumn("TagName", Type.GetType("System.String")))
        DaTable.Columns.Add(New DataColumn("System", Type.GetType("System.String")))
        DaTable.Columns.Add(New DataColumn("Series_Name", Type.GetType("System.String")))




        RR = DaTable.NewRow()
        RR("TagName") = "A411SI1_FT01"
        RR("System") = "Wonderware"
        RR("Series_Name") = "NA"
        DaTable.Rows.Add(RR)
        RR = DaTable.NewRow()
        RR("TagName") = "A351AN1_FO01"
        RR("System") = "Wonderware"
        RR("Series_Name") = "NA"
        DaTable.Rows.Add(RR)
        RR = DaTable.NewRow()
        RR("TagName") = "FM1WFX_TOT"
        RR("System") = "Wonderware"
        RR("Series_Name") = "NA"
        DaTable.Rows.Add(RR)
        RR = DaTable.NewRow()
        RR("TagName") = "FM2WFX_TOT"
        RR("System") = "Wonderware"
        RR("Series_Name") = "NA"
        DaTable.Rows.Add(RR)
        RR = DaTable.NewRow()
        RR("TagName") = "FM3WFX_TOT"
        RR("System") = "Wonderware"
        RR("Series_Name") = "NA"
        DaTable.Rows.Add(RR)
        RR = DaTable.NewRow()
        RR("TagName") = "FM4WFX_TOT"
        RR("System") = "Wonderware"
        RR("Series_Name") = "NA"
        DaTable.Rows.Add(RR)
        RR = DaTable.NewRow()
        RR("TagName") = "FM5WF_TOTAL_FEED"
        RR("System") = "Wonderware"
        RR("Series_Name") = "NA"
        DaTable.Rows.Add(RR)
        RR = DaTable.NewRow()
        RR("TagName") = "FMFDTOTAL"
        RR("System") = "Wonderware"
        RR("Series_Name") = "NA"
        DaTable.Rows.Add(RR)


        If BGW11.IsBusy = False Then
            BGW11.RunWorkerAsync(DaTable)
        End If

    End Sub

    Private Function GetHistorianData(Tags As String) As DataTable

        Dim QDataSet As New DataTable
        Dim MyCommand As New SqlCommand
        Dim QString As String = String.Format("SELECT * FROM OPENQUERY(INSQL,'SELECT DateTime, A411SI1_FT01, A431FN1M01_SI01, A432RF6M01_HIK01, A481VT1_FI01, A461KL1M01_II01, A481PW1_FI01, A481PW2_FI01, A481PW3_FI01, A441VT1_FI01_CFH, A351AF3M01_SI01, A351AN1_FO01, A361HS1_VI01, A361RM1_PI01, A361SR1M01_SI01, A541BE1M01_JI01, A541BM1_TI01, A541BM1M01_JI01, A541GO1_LI01, A541SR1M01_SI01, A541WS1_FI01, FMFDTOTAL, A434AN1_AI03_LB_HR, A434AN1_AI02_LB_HR, A434AN1_THC_LB_TN_CKR_1MIN, A434AN1_CO_LB_TN_CKR_1MIN, wwRowCount, wwRetrievalMode, wwResolution, wwCycleCount FROM Runtime.dbo.WideHistory WHERE A481PW1_FI01 > -20 AND wwCycleCount = {2} AND DateTime >= dateadd(hour,-120,GetDate())')", "AVERAGE", # 10/1/2018 #, 120)


        Dim SQLADAPT As SqlDataAdapter = New SqlDataAdapter(QString, sqlConnection1)

        SQLADAPT.Fill(QDataSet)

        Return QDataSet

    End Function


    Private Function GetValuesfromServer(DTBInput As DataTable) As DataTable
        ' Create Connections
        Dim sqlConnectionBGW As New SqlConnection(String.Format("Data Source={0};Initial Catalog=Runtime;Persist Security Info=True;User ID={1}; password={2}", ConfPerm.TagServer, ConfPerm.TagServerUserName, DecryptHSA256(ConfPerm.TagServerPassword)))
        Dim sqlConnectionBGWLDMS As New SqlConnection(String.Format("Data Source={0};Initial Catalog='LDMS7 MID';Persist Security Info=True;User ID={2}; password={2}", ConfPerm.LDMSServer, ConfPerm.LDMSUserName, DecryptHSA256(ConfPerm.LDMSPassword)))
        Dim cmdBGW As New SqlCommand
        Dim cmdBGWLDMS As New SqlCommand

        'Create DataTable to pass results
        Dim Result As New DataTable
        Dim RR As DataRow
        Try
            cmdBGW.CommandType = CommandType.Text
            cmdBGW.Connection = sqlConnectionBGW
            sqlConnectionBGW.Open()

            cmdBGWLDMS.CommandType = CommandType.Text
            cmdBGWLDMS.Connection = sqlConnectionBGWLDMS
            sqlConnectionBGWLDMS.Open()

        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "FillDataTable - " & ex.Message
        End Try



        Result.Columns.Add(New DataColumn("TagName", Type.GetType("System.String")))
        Result.Columns.Add(New DataColumn("Series_Name", Type.GetType("System.String")))
        Result.Columns.Add(New DataColumn("Value", Type.GetType("System.Double")))

        Try
            For Each Row In DTBInput.Rows

                RR = Result.NewRow()
                RR("TagName") = Row(0).ToString
                RR("Series_Name") = Row(2).ToString
                If Row(1).ToString = "Wonderware" Then
                    RR("Value") = GetValuefromServer(Row(0).ToString, sqlConnectionBGW) 'Row(0) is the tagname
                Else
                    RR("Value") = GetValuefromLDMSServer(Row(0).ToString, sqlConnectionBGWLDMS) 'Row(0) is the tagname
                End If
                Result.Rows.Add(RR)

            Next
        Catch ex As Exception
            Call LogErrorMessage(ex.Message, "Rows Handling in GetValues from Server")
        End Try



        Try
            sqlConnectionBGW.Close()
            sqlConnectionBGWLDMS.Close()
        Catch ex As Exception
            Call LogErrorMessage(ex.Message, "sqlConnectionBGW.Close in GetValues from Server")
        End Try

        Return Result
    End Function
    Private Function GetValuefromServer(Tagname As String, sqlConnectionBGW As SqlConnection) As Double
        'Gets the most recent value for a single Tag in the wonderware system
        Dim readerBGW As SqlDataReader
        Dim cmdBGW As New SqlCommand
        Dim Result As Double = 0
        If sqlConnectionBGW.State = ConnectionState.Closed Then
            Return 0
        End If

        Try
            cmdBGW.CommandType = CommandType.Text
            cmdBGW.Connection = sqlConnectionBGW
            cmdBGW.CommandText = String.Format("SELECT DateTime, TagName, Value, Quality, wwRetrievalMode FROM AnalogLive WHERE (TagName = '{0}')", Tagname)
            readerBGW = cmdBGW.ExecuteReader()
            readerBGW.Read()
        Catch ex As Exception
            Return 0
        End Try
        Try
            Result = Math.Round(readerBGW.GetDouble(2), 2)
        Catch ex As Exception
            readerBGW.Close()
            Return 0
        End Try

        readerBGW.Close()
        Return Result
    End Function

    Private Function GetValuefromLDMSServer(Tagname As String, sqlConnectionBGWLDMS As SqlConnection) As Double
        'Gets the most recent value for a single Tag in the wonderware system
        Dim readerBGW As SqlDataReader
        Dim cmdBGWLDMS As New SqlCommand
        Dim Equip As String = ""  ' To determine the table to use
        Dim Source As String = "" ' To determine the source to use
        Dim ProductType As String = ""
        Dim Value As String = "" ' The value to be returned on the selected table and source
        Dim Result As Double = 0
        'If sqlConnectionBGWLDMS.State = ConnectionState.Closed Then
        '    Return 0
        'End If
        Dim ch As String
        Dim X As Integer = 1

        Do

            Equip = Equip & Mid(Tagname, X, 1)
            X = X + 1
        Loop Until Mid(Tagname, X, 1) = "\" Or Mid(Tagname, X, 1) = "-" Or X > Tagname.Length

        X = X + 1
        Do
            ch = Mid(Tagname, X, 1)
            Source = Source & ch
            X = X + 1
        Loop Until Mid(Tagname, X, 1) = "\" Or Mid(Tagname, X, 1) = "-" Or X > Tagname.Length
        X = X + 1
        Do
            ch = Mid(Tagname, X, 1)
            ProductType = ProductType & ch
            X = X + 1
        Loop Until Mid(Tagname, X, 1) = "\" Or Mid(Tagname, X, 1) = "-" Or X > Tagname.Length
        X = X + 1
        Do
            ch = Mid(Tagname, X, 1)
            Value = Value & ch
            X = X + 1
        Loop Until X > Tagname.Length

        Try
            cmdBGWLDMS.CommandType = CommandType.Text
            cmdBGWLDMS.Connection = sqlConnectionBGWLDMS

            Select Case Equip
                Case "FinishMill"
                    cmdBGWLDMS.CommandText = String.Format("Select      TOP (2) LabData_{0}.SampleId, LabData_{0}.Source, LabData_{0}.ProductType, LabData_{0}.SampleTime, {2} 
                                                                FROM        LabData_{0} INNER JOIN
                                                                InstData_XRay ON LabData_{0}.SampleId = InstData_XRay.SampleID
                                                    WHERE       (LabData_{0}.Source = N'{1}' AND LabData_{0}.ProductType = N'{3}')
                                                    ORDER BY    LabData_{0}.SampleTime DESC", Equip, Source, Value, ProductType)
                Case Else
                    cmdBGWLDMS.CommandText = String.Format("Select      TOP (2) LabData_{0}.SampleId, LabData_{0}.Source, LabData_{0}.ProductType, LabData_{0}.SampleTime, {1} 
                                                                FROM        LabData_{0} INNER JOIN
                                                                InstData_XRay ON LabData_{0}.SampleId = InstData_XRay.SampleID
                                                    ORDER BY    LabData_{0}.SampleTime DESC", Equip, Value)
            End Select

            readerBGW = cmdBGWLDMS.ExecuteReader()
            readerBGW.Read()
        Catch ex As Exception
            Return 0
        End Try

        Try
            Result = Math.Round(readerBGW.GetDouble(4), 2)

            If Result = 0 Then
                readerBGW.Read()
                Result = Math.Round(readerBGW.GetDouble(4), 2)
            End If
        Catch ex As Exception
            readerBGW.Close()
            Return 0
        End Try

        readerBGW.Close()
        Return Result
    End Function


    Private Sub tmrUpdateChart_Tick(sender As Object, e As EventArgs) Handles tmrUpdateChart.Tick
        Me.AnalogHistoryTableAdapter.Fill(Me.HistoryDataSet.AnalogHistory, "FMFDTOTAL")
        FM6Chart.Update()
    End Sub



    Private Sub UpdateDownTimes()
        Dim Conexion As New ADODB.Connection
        Dim Registros As New ADODB.Recordset
        Dim Config As New My.MySettings
        Try
            Conexion.Open(String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=True;Jet OLEDB:Database Password={1}", Config.DownTimeDatabase, DecryptHSA256(Config.DBPassword)))
        Catch ex As Exception
            Exit Sub
        End Try

        Try
            Registros.Open("Select TOP 4 * from DownTime where Equipment = 'FM6' ORDER BY DateSTOP Desc", Conexion, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Registros.MoveFirst()

            Label14.Text = Registros.Fields.Item("DateStop").Value
            Label15.Text = Registros.Fields.Item("Reason").Value
            Label25.Text = Registros.Fields.Item("SubEquipment").Value
            Registros.MoveNext()
            Label16.Text = Registros.Fields.Item("DateStop").Value
            Label17.Text = Registros.Fields.Item("Reason").Value
            Label24.Text = Registros.Fields.Item("SubEquipment").Value
            Registros.MoveNext()
            Label18.Text = Registros.Fields.Item("DateStop").Value
            Label19.Text = Registros.Fields.Item("Reason").Value
            Label23.Text = Registros.Fields.Item("SubEquipment").Value
            Registros.MoveNext()
            Label20.Text = Registros.Fields.Item("DateStop").Value
            Label21.Text = Registros.Fields.Item("Reason").Value
            Label22.Text = Registros.Fields.Item("SubEquipment").Value
            Registros.Close()
            Conexion.Close()
        Catch ex As Exception
            Try
                Registros.Close()

            Catch ex2 As Exception
                siStatus.Caption = "Error"
                siInfo.Caption = "Update Downtimes - " & ex2.Message
            End Try
            Try
                Conexion.Close()
            Catch ex3 As Exception
                siStatus.Caption = "Error"
                siInfo.Caption = "Update DownTimes - " & ex3.Message
            End Try
        End Try


    End Sub



    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Call RestoreMonitorSettings()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        'Server Configuration Button
        Dim A As New ServerOptions
        A.Show()
    End Sub


    Dim DTB As New DataTable
    Dim DTBLDMS As New DataTable


    Private Function FillDataTable(TagName As String) As DataTable
        Const strSql As String = "SELECT * FROM OpenQuery(INSQL,'SELECT DateTime, A411SI1_FT01, A481VT1_FI01,FMFDTOTAL,wwRetrievalMode, wwCycleCount FROM Runtime.dbo.WideHistory WHERE A481PW1_FI01 > -20 AND wwCycleCount = 120 AND DateTime >= DATEADD(hour,-120,GetDate())')"
        Dim dtb As New DataTable

        Try
            sqlConnection1.Open()
        Catch ex As Exception
            siStatus.Caption = "Error"
            siInfo.Caption = "FillDataTable - " & ex.Message
        End Try

        Using dad As New SqlDataAdapter(strSql, sqlConnection1)
            dad.Fill(dtb)
        End Using
        sqlConnection1.Close()

        Return dtb

    End Function




    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles CCh.SelectedPageChanged
        Select Case CCh.SelectedPage.Caption
            Case "Historian"
                RibbonPageGroup2.Visible = True
            Case Else
                RibbonPageGroup2.Visible = False
        End Select
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'Edit Trends Button
        Dim A As New ChartBuilder
        A.Show()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem6.ItemClick

        ' Start/Pause Real Time Button
        If BarButtonItem6.Caption = "Start Real Time" Then
            BarButtonItem6.LargeGlyph = Midlothian_Operations.My.Resources.Resources._036
            BarButtonItem6.Caption = "Pause Real Time"
            tmrUpdateRealTime.Enabled = True
        Else
            BarButtonItem6.LargeGlyph = Midlothian_Operations.My.Resources.Resources._033
            BarButtonItem6.Caption = "Start Real Time"
            tmrUpdateRealTime.Enabled = False
        End If


    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Me.Close()
    End Sub





    Private Sub BarCheckItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem1.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem2.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem3.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem4_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem4.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem5_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem5.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem6_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem6.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem7.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem8_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem8.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem9_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem9.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem10_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem10.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem11_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem11.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub BarCheckItem12_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCheckItem12.ItemClick
        Call SaveActiveChartsSettings()
    End Sub

    Private Sub SaveActiveChartsSettings()
        My.Settings.FM6_1TrendActive = BarCheckItem1.Checked
        My.Settings.FM6_2TrendActive = BarCheckItem2.Checked
        My.Settings.RMTrendActive = BarCheckItem3.Checked
        My.Settings.KilnTrendActive = BarCheckItem4.Checked
        My.Settings.PHTTrendActive = BarCheckItem5.Checked
        My.Settings.CoolerTrendActive = BarCheckItem6.Checked
        My.Settings.FM1TrendActive = BarCheckItem7.Checked
        My.Settings.FM2TrendActive = BarCheckItem8.Checked
        My.Settings.FM3TrendActive = BarCheckItem9.Checked
        My.Settings.FM4TrendActive = BarCheckItem10.Checked
        My.Settings.FM5TrendActive = BarCheckItem11.Checked
        My.Settings.QualityTrendActive = BarCheckItem12.Checked

    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Dim AST As new DataTable

        AST.Columns.Add(New DataColumn("DateTime", Type.GetType("System.DateTime")))
        AST.Columns.Add(New DataColumn("TAG1", Type.GetType("System.Double")))
        AST.Columns.Add(New DataColumn("TAG2", Type.GetType("System.Double")))
        AST.Columns.Add(New DataColumn("TAG3", Type.GetType("System.Double")))
        Dim X As Integer = -1
        Dim RandomNumb As New Random
        Do
            Dim dr As DataRow = AST.NewRow()
            dr("DateTime") = DateAdd(DateInterval.Minute, X, Now())
            dr("TAG1") = RandomNumb.NextDouble * 10000
            dr("TAG2") = RandomNumb.NextDouble * 1000
            dr("TAG3") = RandomNumb.NextDouble * 100

            AST.Rows.Add(dr)
            X = X - 1
        Loop Until X <= -120


        Call GenerateHistorianChart(AST, DTBHistorian)

    End Sub

    Private Sub GenerateHistorianChart(Source As DataTable, HistorianConfig As DataTable)

        Dim DD As SwiftPlotDiagram = ChartHistorian.Diagram
        DD.SecondaryAxesY.Clear()
        ChartHistorian.Series.Clear()

        ChartHistorian.DataSource = Nothing
        ChartHistorian.DataSource = Source
        For Each column As DataColumn In Source.Columns
            If column.ColumnName <> "DateTime" Then
                Dim FoundinHistorianRows() As Data.DataRow = HistorianConfig.Select(String.Format("TagName = '{0}'", column.ColumnName))
                Dim SName As String = FoundinHistorianRows(0).Item("Series_Name")
                Dim NS As New Series(SName, ViewType.SwiftPlot)
                Dim diagram As SwiftPlotDiagram
                Dim SColor As Color = Color.FromArgb(CType(FoundinHistorianRows(0).Item("Color"), Integer))
                Dim SMax As Integer = FoundinHistorianRows(0).Item("Max")
                Dim SMin As Integer = FoundinHistorianRows(0).Item("Min")

                If column.ColumnName <> FoundinHistorianRows(0).Item("TagName") Then
                    MsgBox("Shit.... something went wrong.... crap!...  :-( ", vbCritical, "Shit Happens!")
                    Exit Sub
                End If

                'Set the colors
                NS.Visible = True
                NS.View.Color = SColor
                ChartHistorian.Series.Add(NS)
                If ChartHistorian.Series.Count = 1 Then
                    'Add the series and configure primary Y axis

                    ChartHistorian.Series(SName).View.Color = SColor
                    diagram = ChartHistorian.Diagram
                    diagram.AxisY.VisualRange.Auto = False
                    diagram.AxisY.Color = SColor
                    diagram.AxisY.WholeRange.Auto = False
                    diagram.AxisY.WholeRange.MaxValue = SMax
                    diagram.AxisY.WholeRange.MinValue = SMin
                    diagram.AxisY.VisualRange.MaxValue = SMax
                    diagram.AxisY.VisualRange.MinValue = SMin
                    diagram.AxisY.WholeRange.SideMarginsValue = 0
                    diagram.AxisY.VisualRange.SideMarginsValue = 0
                    diagram.Margins.Left = 0
                    diagram.Margins.Right = 0


                Else
                    'Create Secondary Y Axis and it's properties.
                    Dim SAxis As New SwiftPlotDiagramSecondaryAxisY(SName)
                    SAxis.Color = SColor
                    SAxis.WholeRange.Auto = False
                    SAxis.VisualRange.Auto = False
                    SAxis.WholeRange.MaxValue = SMax
                    SAxis.WholeRange.MinValue = SMin
                    SAxis.VisualRange.MaxValue = SMax
                    SAxis.VisualRange.MinValue = SMin
                    SAxis.WholeRange.SideMarginsValue = 0
                    SAxis.VisualRange.SideMarginsValue = 0
                    SAxis.Alignment = AxisAlignment.Near
                    'Set secondary axis for this series
                    CType(ChartHistorian.Diagram, SwiftPlotDiagram).SecondaryAxesY.Add(SAxis)
                    'Add the series to the chart
                    CType(ChartHistorian.Series(SName).View, SwiftPlotSeriesView).AxisY = SAxis
                End If
                'Set the series properties
                ChartHistorian.Series(SName).ArgumentScaleType = ScaleType.DateTime
                ChartHistorian.Series(SName).ArgumentDataMember = "DateTime"
                ChartHistorian.Series(SName).ValueScaleType = ScaleType.Numerical
                ChartHistorian.Series(SName).ValueDataMembers.AddRange(New String() {column.ColumnName})
                ChartHistorian.Series(SName).View.Color = SColor




            End If
        Next

    End Sub
    Private Sub LogErrorMessage(Message As String, Location As String)
        Try
            siStatus.Caption = "Error"
            siInfo.Caption = Message
            tmrError.Enabled = False
            tmrError.Enabled = True
        Catch ex As Exception
            Exit Try
        End Try

        Try
            If System.IO.File.Exists("ErrorLog.txt") = False Then
                System.IO.File.Create("ErrorLog.txt")
            End If
        Catch ex As Exception
            Exit Try
        End Try


        Try
            Dim file As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("ErrorLog.txt", True)
            file.WriteLine(String.Format("{0} - {1} - {2}", Now(), Message, Location))
            file.Close()
        Catch ex As Exception
            Exit Try
        End Try


    End Sub

    Private Sub tmrError_Tick(sender As Object, e As EventArgs) Handles tmrError.Tick
        siInfo.Caption = ""
        siStatus.Caption = ""
        tmrError.Enabled = False
    End Sub
End Class

