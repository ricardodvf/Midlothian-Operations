Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True, True)
        Dim SwiftPlotDiagram1 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView1 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView2 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem42 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem43 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem44 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem45 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem46 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem47 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem48 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem49 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem50 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem51 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem52 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem53 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem54 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem55 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem56 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem57 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem58 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem59 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem60 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem61 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem62 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem63 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem64 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem65 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem66 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem67 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem68 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem69 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem70 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem71 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem72 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem73 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem74 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem75 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem76 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem77 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem78 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem79 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem80 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem81 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem82 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem83 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem84 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem85 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem86 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem87 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem88 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem89 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem90 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem91 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem92 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem93 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem94 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem95 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem96 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem97 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem98 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem99 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem100 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem101 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem102 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem103 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem104 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem105 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem106 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem107 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem108 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem109 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem110 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem111 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem112 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem113 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem114 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem115 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem116 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem117 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem118 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem119 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem120 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem121 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem122 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem123 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem124 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem125 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem126 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem127 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem128 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem129 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem130 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem131 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem132 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem133 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem134 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem135 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem136 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem137 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem138 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem139 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem140 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem141 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem142 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem143 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem144 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem145 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem146 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem147 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem148 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem149 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem150 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem151 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem152 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem153 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem154 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem155 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem156 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem157 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem158 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem159 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem160 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem161 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem162 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem163 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem164 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem165 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem166 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem167 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem168 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem169 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem170 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem171 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem172 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem173 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem174 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem175 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem176 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem177 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem178 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem179 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem180 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem181 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItemGroup40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem182 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem183 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem184 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem185 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem186 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SwiftPlotDiagram2 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView3 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotDiagram3 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim SwiftPlotDiagramSecondaryAxisY1 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY2 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY3 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY4 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView4 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView5 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView6 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView7 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView8 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView9 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram4 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim SwiftPlotDiagramSecondaryAxisY5 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY6 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY7 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY8 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY9 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY10 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY11 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY12 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim Series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView10 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series9 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView11 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series10 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView12 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series11 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView13 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series12 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView14 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series13 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView15 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series14 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView16 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series15 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView17 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series16 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView18 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView19 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram5 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim SwiftPlotDiagramSecondaryAxisY13 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY14 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY15 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY16 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY17 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY18 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY19 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY20 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY21 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim SwiftPlotDiagramSecondaryAxisY22 As DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY = New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY()
        Dim Series17 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView20 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series18 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView21 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series19 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView22 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series20 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView23 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series21 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView24 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series22 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView25 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series23 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView26 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series24 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView27 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series25 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView28 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series26 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView29 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series27 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView30 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView31 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram6 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series28 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView32 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView33 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram7 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series29 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView34 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView35 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram8 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series30 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView36 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView37 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram9 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series31 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView38 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView39 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram10 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series32 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView40 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView41 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle9 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram11 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series33 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView42 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView43 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle10 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim SwiftPlotDiagram12 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series34 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView44 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView45 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim ChartTitle11 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.DateTimeChartRangeControlClient1 = New DevExpress.XtraEditors.DateTimeChartRangeControlClient()
        Me.ChartHistorian = New DevExpress.XtraCharts.ChartControl()
        Me.LDMS7_MIDDataSet = New Midlothian_Operations.LDMS7_MIDDataSet()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.mailGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.inboxItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.draftsItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.trashItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.organizerGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.calendarItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.tasksItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.DTPFrom = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.DTPTo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem3 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem4 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem5 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem6 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem7 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem8 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem9 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem10 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem11 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem12 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem5 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPageSkins = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
        Me.RepositoryItemSpreadsheetFontSizeEdit1 = New DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit()
        Me.RepositoryItemPopupGalleryEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.CommandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown9 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown10 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown11 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown12 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown13 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown14 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown15 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown16 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown17 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown18 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown19 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown20 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown21 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown22 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown23 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown24 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.LiveDataSet = New Midlothian_Operations.LiveDataSet()
        Me.AnalogLiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnalogLiveTableAdapter = New Midlothian_Operations.LiveDataSetTableAdapters.AnalogLiveTableAdapter()
        Me.DigitalGauge2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalGauge3 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalGauge4 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalGauge5 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalGauge6 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalGauge7 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent8 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalGauge8 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent9 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalGauge9 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent10 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.FM6Chart2 = New DevExpress.XtraCharts.ChartControl()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FM6Chart = New DevExpress.XtraCharts.ChartControl()
        Me.GaugeControl14 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge22 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent29 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.GaugeControl13 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge21 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent28 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.GaugeControl11 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge19 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent26 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.GaugeControl9 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge17 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent24 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.GaugeControl7 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge15 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent22 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.GaugeControl5 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge13 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent20 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.GaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge11 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent18 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent16 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent11 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent13 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent12 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent15 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent14 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.CCh = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.VRMChart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.KilnChart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage4 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TabNavigationPage5 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PHTChart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage6 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.CoolerChart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage7 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.FM1Chart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage8 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.FM2Chart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage9 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.FM3Chart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage10 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.FM4Chart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage11 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.FM5Chart = New DevExpress.XtraCharts.ChartControl()
        Me.TabNavigationPage12 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tmrUpdateRealTime = New System.Windows.Forms.Timer(Me.components)
        Me.HistoryDataSet = New Midlothian_Operations.HistoryDataSet()
        Me.AnalogHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnalogHistoryTableAdapter = New Midlothian_Operations.HistoryDataSetTableAdapters.AnalogHistoryTableAdapter()
        Me.AnalogHistoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tmrUpdateChart = New System.Windows.Forms.Timer(Me.components)
        Me.BGW1 = New System.ComponentModel.BackgroundWorker()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
        Me.BGW2 = New System.ComponentModel.BackgroundWorker()
        Me.BGW3 = New System.ComponentModel.BackgroundWorker()
        Me.BGW4 = New System.ComponentModel.BackgroundWorker()
        Me.BGW5 = New System.ComponentModel.BackgroundWorker()
        Me.BGW6 = New System.ComponentModel.BackgroundWorker()
        Me.BGW7 = New System.ComponentModel.BackgroundWorker()
        Me.BGW8 = New System.ComponentModel.BackgroundWorker()
        Me.BGW9 = New System.ComponentModel.BackgroundWorker()
        Me.BGW10 = New System.ComponentModel.BackgroundWorker()
        Me.BGW11 = New System.ComponentModel.BackgroundWorker()
        Me.BGW12 = New System.ComponentModel.BackgroundWorker()
        Me.BarCheckItem13 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem14 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem15 = New DevExpress.XtraBars.BarCheckItem()
        Me.tmrError = New System.Windows.Forms.Timer(Me.components)
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem4 = New DevExpress.XtraBars.BarEditItem()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.bgwUpdateHistorian = New System.ComponentModel.BackgroundWorker()
        CType(Me.DateTimeChartRangeControlClient1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartHistorian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LDMS7_MIDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnalogLiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.FM6Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FM6Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CCh.SuspendLayout()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VRMChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KilnChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagramSecondaryAxisY22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHTChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView33, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoolerChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView35, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage7.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FM1Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView37, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage8.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FM2Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView39, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage9.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FM3Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView41, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage10.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FM4Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView43, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage11.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FM5Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnalogHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnalogHistoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'ChartHistorian
        '
        Me.ChartHistorian.AppearanceNameSerializable = "Dark"
        Me.ChartHistorian.CacheToMemory = True
        Me.ChartHistorian.CrosshairOptions.ShowArgumentLabels = True
        Me.ChartHistorian.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram1.AxisX.CrosshairAxisLabelOptions.Pattern = "{A:dddd, MMMM d, yyyy H:mm:ss}"
        SwiftPlotDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
        SwiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram1.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram1.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.ChartHistorian.Diagram = SwiftPlotDiagram1
        Me.ChartHistorian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartHistorian.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.ChartHistorian.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.ChartHistorian.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.ChartHistorian.Location = New System.Drawing.Point(0, 0)
        Me.ChartHistorian.Name = "ChartHistorian"
        Me.ChartHistorian.PaletteBaseColorNumber = 2
        Me.ChartHistorian.PaletteName = "Default"
        Me.ChartHistorian.RefreshDataOnRepaint = False
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series1.Name = "SeriesHistorian"
        Series1.View = SwiftPlotSeriesView1
        Me.ChartHistorian.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartHistorian.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Me.ChartHistorian.SeriesTemplate.View = SwiftPlotSeriesView2
        Me.ChartHistorian.Size = New System.Drawing.Size(1912, 880)
        Me.ChartHistorian.TabIndex = 0
        ChartTitle1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Historian Trend"
        Me.ChartHistorian.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'LDMS7_MIDDataSet
        '
        Me.LDMS7_MIDDataSet.DataSetName = "LDMS7_MIDDataSet"
        Me.LDMS7_MIDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'mailGroup
        '
        Me.mailGroup.Caption = "Mail"
        Me.mailGroup.Expanded = True
        Me.mailGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.inboxItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.draftsItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.trashItem)})
        Me.mailGroup.LargeImageIndex = 0
        Me.mailGroup.Name = "mailGroup"
        '
        'inboxItem
        '
        Me.inboxItem.Caption = "Inbox"
        Me.inboxItem.Name = "inboxItem"
        Me.inboxItem.SmallImageIndex = 0
        '
        'draftsItem
        '
        Me.draftsItem.Caption = "Drafts"
        Me.draftsItem.Name = "draftsItem"
        Me.draftsItem.SmallImageIndex = 2
        '
        'trashItem
        '
        Me.trashItem.Caption = "Trash"
        Me.trashItem.Name = "trashItem"
        Me.trashItem.SmallImageIndex = 3
        '
        'organizerGroup
        '
        Me.organizerGroup.Caption = "Organizer"
        Me.organizerGroup.Expanded = True
        Me.organizerGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.calendarItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.tasksItem)})
        Me.organizerGroup.LargeImageIndex = 1
        Me.organizerGroup.Name = "organizerGroup"
        '
        'calendarItem
        '
        Me.calendarItem.Caption = "Calendar"
        Me.calendarItem.Name = "calendarItem"
        Me.calendarItem.SmallImageIndex = 4
        '
        'tasksItem
        '
        Me.tasksItem.Caption = "Tasks"
        Me.tasksItem.Name = "tasksItem"
        Me.tasksItem.SmallImageIndex = 5
        '
        'navbarImageCollectionLarge
        '
        Me.navbarImageCollectionLarge.ImageStream = CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
        '
        'navbarImageCollection
        '
        Me.navbarImageCollection.ImageStream = CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ApplicationIcon = Global.Midlothian_Operations.My.Resources.Resources._3d_bar_chart
        Me.ribbonControl.Controller = Me.BarAndDockingController1
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iExit, Me.iHelp, Me.iAbout, Me.siStatus, Me.siInfo, Me.rgbiSkins, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarHeaderItem1, Me.DTPFrom, Me.DTPTo, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarCheckItem1, Me.BarCheckItem2, Me.BarCheckItem3, Me.BarCheckItem4, Me.BarCheckItem5, Me.BarCheckItem6, Me.BarCheckItem7, Me.BarCheckItem8, Me.BarCheckItem9, Me.BarCheckItem10, Me.BarCheckItem11, Me.BarCheckItem12, Me.BarButtonItem8, Me.BarEditItem5})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 406
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.iAbout)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPageSkins, Me.RibbonPage1})
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemFontEdit1, Me.RepositoryItemSpreadsheetFontSizeEdit1, Me.RepositoryItemPopupGalleryEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(1930, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        '
        'appMenu
        '
        Me.appMenu.ItemLinks.Add(Me.iExit)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.ShowRightPane = True
        '
        'iExit
        '
        Me.iExit.Caption = "Exit"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageIndex = 6
        Me.iExit.LargeImageIndex = 6
        Me.iExit.Name = "iExit"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'iHelp
        '
        Me.iHelp.Caption = "Help"
        Me.iHelp.Description = "Start the program help system."
        Me.iHelp.Hint = "Start the program help system"
        Me.iHelp.Id = 22
        Me.iHelp.ImageIndex = 7
        Me.iHelp.LargeImageIndex = 7
        Me.iHelp.Name = "iHelp"
        '
        'iAbout
        '
        Me.iAbout.Caption = "About"
        Me.iAbout.Description = "Displays general program information."
        Me.iAbout.Hint = "Displays general program information"
        Me.iAbout.Id = 24
        Me.iAbout.ImageIndex = 8
        Me.iAbout.LargeImageIndex = 8
        Me.iAbout.Name = "iAbout"
        '
        'siStatus
        '
        Me.siStatus.Caption = "Process Trends"
        Me.siStatus.Id = 31
        Me.siStatus.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siStatus.ItemAppearance.Normal.Options.UseFont = True
        Me.siStatus.Name = "siStatus"
        Me.siStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'siInfo
        '
        Me.siInfo.Caption = "Midlothian Cement"
        Me.siInfo.Id = 32
        Me.siInfo.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siInfo.ItemAppearance.Normal.Options.UseFont = True
        Me.siInfo.Name = "siInfo"
        Me.siInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Edit Trends"
        Me.BarButtonItem1.Id = 380
        Me.BarButtonItem1.LargeGlyph = Global.Midlothian_Operations.My.Resources.Resources._3d_bar_chart
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Server Configuration"
        Me.BarButtonItem2.Id = 381
        Me.BarButtonItem2.LargeGlyph = Global.Midlothian_Operations.My.Resources.Resources._0011
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Historian Configuration"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 382
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Remove Point"
        Me.BarButtonItem4.Id = 383
        Me.BarButtonItem4.LargeGlyph = Global.Midlothian_Operations.My.Resources.Resources.Delete
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Add LDMS Point"
        Me.BarButtonItem5.Id = 384
        Me.BarButtonItem5.LargeGlyph = Global.Midlothian_Operations.My.Resources.Resources._006
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "From:"
        Me.BarHeaderItem1.Id = 385
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        Me.BarHeaderItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'DTPFrom
        '
        Me.DTPFrom.Caption = "From:"
        Me.DTPFrom.Edit = Me.RepositoryItemDateEdit1
        Me.DTPFrom.EditHeight = 30
        Me.DTPFrom.EditValue = New Date(2018, 4, 15, 22, 49, 28, 135)
        Me.DTPFrom.EditWidth = 150
        Me.DTPFrom.Id = 386
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.RepositoryItemDateEdit1.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatString = "G"
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatString = "G"
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "G"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "G"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'DTPTo
        '
        Me.DTPTo.Caption = "    To:"
        Me.DTPTo.Edit = Me.RepositoryItemDateEdit2
        Me.DTPTo.EditHeight = 30
        Me.DTPTo.EditValue = "4/15/2018 10:49:28 PM"
        Me.DTPTo.EditWidth = 150
        Me.DTPTo.Id = 387
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.RepositoryItemDateEdit2.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.DisplayFormat.FormatString = "G"
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.EditFormat.FormatString = "G"
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatString = "G"
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.EditFormat.FormatString = "G"
        Me.RepositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Start Real Time"
        Me.BarButtonItem6.Id = 388
        Me.BarButtonItem6.LargeGlyph = Global.Midlothian_Operations.My.Resources.Resources._033
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Close Program"
        Me.BarButtonItem7.Glyph = CType(resources.GetObject("BarButtonItem7.Glyph"), System.Drawing.Image)
        Me.BarButtonItem7.Id = 389
        Me.BarButtonItem7.LargeGlyph = CType(resources.GetObject("BarButtonItem7.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "Finish Mill # 6 -1"
        Me.BarCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem1.Id = 390
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarCheckItem2
        '
        Me.BarCheckItem2.Caption = "Finish Mill # 6 - 2"
        Me.BarCheckItem2.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem2.Id = 391
        Me.BarCheckItem2.Name = "BarCheckItem2"
        '
        'BarCheckItem3
        '
        Me.BarCheckItem3.Caption = "Raw Mill"
        Me.BarCheckItem3.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem3.Id = 392
        Me.BarCheckItem3.Name = "BarCheckItem3"
        '
        'BarCheckItem4
        '
        Me.BarCheckItem4.Caption = "Kiln"
        Me.BarCheckItem4.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem4.Id = 393
        Me.BarCheckItem4.Name = "BarCheckItem4"
        '
        'BarCheckItem5
        '
        Me.BarCheckItem5.Caption = "PHT"
        Me.BarCheckItem5.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem5.Id = 394
        Me.BarCheckItem5.Name = "BarCheckItem5"
        '
        'BarCheckItem6
        '
        Me.BarCheckItem6.Caption = "Cooler"
        Me.BarCheckItem6.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem6.Id = 395
        Me.BarCheckItem6.Name = "BarCheckItem6"
        '
        'BarCheckItem7
        '
        Me.BarCheckItem7.Caption = "Finish Mill # 1"
        Me.BarCheckItem7.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem7.Id = 396
        Me.BarCheckItem7.Name = "BarCheckItem7"
        '
        'BarCheckItem8
        '
        Me.BarCheckItem8.Caption = "Finish Mill # 2"
        Me.BarCheckItem8.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem8.Id = 397
        Me.BarCheckItem8.Name = "BarCheckItem8"
        '
        'BarCheckItem9
        '
        Me.BarCheckItem9.Caption = "Finish Mill # 3"
        Me.BarCheckItem9.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem9.Id = 398
        Me.BarCheckItem9.Name = "BarCheckItem9"
        '
        'BarCheckItem10
        '
        Me.BarCheckItem10.Caption = "Finish Mill # 4"
        Me.BarCheckItem10.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem10.Id = 399
        Me.BarCheckItem10.Name = "BarCheckItem10"
        Me.BarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarCheckItem11
        '
        Me.BarCheckItem11.Caption = "Finish Mill # 5"
        Me.BarCheckItem11.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem11.Id = 400
        Me.BarCheckItem11.Name = "BarCheckItem11"
        '
        'BarCheckItem12
        '
        Me.BarCheckItem12.Caption = "Quality"
        Me.BarCheckItem12.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BarCheckItem12.Id = 401
        Me.BarCheckItem12.Name = "BarCheckItem12"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Historian Refresh"
        Me.BarButtonItem8.Glyph = CType(resources.GetObject("BarButtonItem8.Glyph"), System.Drawing.Image)
        Me.BarButtonItem8.Id = 402
        Me.BarButtonItem8.LargeGlyph = CType(resources.GetObject("BarButtonItem8.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        Me.BarButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarEditItem5
        '
        Me.BarEditItem5.Caption = "Resolution"
        Me.BarEditItem5.Edit = Me.RepositoryItemComboBox1
        Me.BarEditItem5.EditHeight = 40
        Me.BarEditItem5.EditValue = "Seconds"
        Me.BarEditItem5.EditWidth = 100
        Me.BarEditItem5.Id = 405
        Me.BarEditItem5.Name = "BarEditItem5"
        Me.BarEditItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Seconds", "Minutes", "Hours", "Days", "Months"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPageSkins
        '
        Me.RibbonPageSkins.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPageSkins.Name = "RibbonPageSkins"
        Me.RibbonPageSkins.Text = "File"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Chart Options"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.DTPFrom)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.DTPTo)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarEditItem5)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Historian"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Close"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Active Trends"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem1)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem2)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem3)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem4)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem5)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem6)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem7)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem8)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem9)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem10)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem11)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarCheckItem12)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Active Trends for Real Time Update"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemFontEdit1
        '
        Me.RepositoryItemFontEdit1.AutoHeight = False
        Me.RepositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemFontEdit1.Name = "RepositoryItemFontEdit1"
        '
        'RepositoryItemSpreadsheetFontSizeEdit1
        '
        Me.RepositoryItemSpreadsheetFontSizeEdit1.AutoHeight = False
        Me.RepositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpreadsheetFontSizeEdit1.Control = Nothing
        Me.RepositoryItemSpreadsheetFontSizeEdit1.Name = "RepositoryItemSpreadsheetFontSizeEdit1"
        '
        'RepositoryItemPopupGalleryEdit1
        '
        Me.RepositoryItemPopupGalleryEdit1.AutoHeight = False
        Me.RepositoryItemPopupGalleryEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        '
        '
        '
        Me.RepositoryItemPopupGalleryEdit1.Gallery.AllowFilter = False
        Me.RepositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = False
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1
        Me.RepositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = False
        SpreadsheetCommandGalleryItem1.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem1.Caption = "General"
        SpreadsheetCommandGalleryItem1.CaptionAsValue = True
        SpreadsheetCommandGalleryItem1.CommandName = "FormatNumberGeneral"
        SpreadsheetCommandGalleryItem1.IsEmptyHint = True
        SpreadsheetCommandGalleryItem1.Value = "General"
        SpreadsheetCommandGalleryItem2.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem2.Caption = "Number"
        SpreadsheetCommandGalleryItem2.CaptionAsValue = True
        SpreadsheetCommandGalleryItem2.CommandName = "FormatNumberDecimal"
        SpreadsheetCommandGalleryItem2.IsEmptyHint = True
        SpreadsheetCommandGalleryItem2.Value = "Number"
        SpreadsheetCommandGalleryItem3.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem3.Caption = "Currency"
        SpreadsheetCommandGalleryItem3.CaptionAsValue = True
        SpreadsheetCommandGalleryItem3.CommandName = "FormatNumberAccountingCurrency"
        SpreadsheetCommandGalleryItem3.IsEmptyHint = True
        SpreadsheetCommandGalleryItem3.Value = "Currency"
        SpreadsheetCommandGalleryItem4.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem4.Caption = "Accounting"
        SpreadsheetCommandGalleryItem4.CaptionAsValue = True
        SpreadsheetCommandGalleryItem4.CommandName = "FormatNumberAccountingRegular"
        SpreadsheetCommandGalleryItem4.IsEmptyHint = True
        SpreadsheetCommandGalleryItem4.Value = "Accounting"
        SpreadsheetCommandGalleryItem5.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem5.Caption = "Short Date"
        SpreadsheetCommandGalleryItem5.CaptionAsValue = True
        SpreadsheetCommandGalleryItem5.CommandName = "FormatNumberShortDate"
        SpreadsheetCommandGalleryItem5.IsEmptyHint = True
        SpreadsheetCommandGalleryItem5.Value = "Short Date"
        SpreadsheetCommandGalleryItem6.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem6.Caption = "Long Date"
        SpreadsheetCommandGalleryItem6.CaptionAsValue = True
        SpreadsheetCommandGalleryItem6.CommandName = "FormatNumberLongDate"
        SpreadsheetCommandGalleryItem6.IsEmptyHint = True
        SpreadsheetCommandGalleryItem6.Value = "Long Date"
        SpreadsheetCommandGalleryItem7.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem7.Caption = "Time"
        SpreadsheetCommandGalleryItem7.CaptionAsValue = True
        SpreadsheetCommandGalleryItem7.CommandName = "FormatNumberTime"
        SpreadsheetCommandGalleryItem7.IsEmptyHint = True
        SpreadsheetCommandGalleryItem7.Value = "Time"
        SpreadsheetCommandGalleryItem8.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem8.Caption = "Percentage"
        SpreadsheetCommandGalleryItem8.CaptionAsValue = True
        SpreadsheetCommandGalleryItem8.CommandName = "FormatNumberPercentage"
        SpreadsheetCommandGalleryItem8.IsEmptyHint = True
        SpreadsheetCommandGalleryItem8.Value = "Percentage"
        SpreadsheetCommandGalleryItem9.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem9.Caption = "Fraction"
        SpreadsheetCommandGalleryItem9.CaptionAsValue = True
        SpreadsheetCommandGalleryItem9.CommandName = "FormatNumberFraction"
        SpreadsheetCommandGalleryItem9.IsEmptyHint = True
        SpreadsheetCommandGalleryItem9.Value = "Fraction"
        SpreadsheetCommandGalleryItem10.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem10.Caption = "Scientific"
        SpreadsheetCommandGalleryItem10.CaptionAsValue = True
        SpreadsheetCommandGalleryItem10.CommandName = "FormatNumberScientific"
        SpreadsheetCommandGalleryItem10.IsEmptyHint = True
        SpreadsheetCommandGalleryItem10.Value = "Scientific"
        SpreadsheetCommandGalleryItem11.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem11.Caption = "Text"
        SpreadsheetCommandGalleryItem11.CaptionAsValue = True
        SpreadsheetCommandGalleryItem11.CommandName = "FormatNumberText"
        SpreadsheetCommandGalleryItem11.IsEmptyHint = True
        SpreadsheetCommandGalleryItem11.Value = "Text"
        GalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem1, SpreadsheetCommandGalleryItem2, SpreadsheetCommandGalleryItem3, SpreadsheetCommandGalleryItem4, SpreadsheetCommandGalleryItem5, SpreadsheetCommandGalleryItem6, SpreadsheetCommandGalleryItem7, SpreadsheetCommandGalleryItem8, SpreadsheetCommandGalleryItem9, SpreadsheetCommandGalleryItem10, SpreadsheetCommandGalleryItem11})
        Me.RepositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.RepositoryItemPopupGalleryEdit1.Gallery.RowCount = 11
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = False
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ShowItemText = True
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
        Me.RepositoryItemPopupGalleryEdit1.Gallery.StretchItems = True
        Me.RepositoryItemPopupGalleryEdit1.Name = "RepositoryItemPopupGalleryEdit1"
        Me.RepositoryItemPopupGalleryEdit1.ShowButtons = False
        Me.RepositoryItemPopupGalleryEdit1.ShowPopupCloseButton = False
        Me.RepositoryItemPopupGalleryEdit1.ShowSizeGrip = False
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
        Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 1068)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1930, 31)
        '
        'CommandBarGalleryDropDown1
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown1.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown1.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup1.Caption = "Primary Horizontal Axis"
        SpreadsheetCommandGalleryItemGroup1.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
        SpreadsheetCommandGalleryItem12.Caption = "None"
        SpreadsheetCommandGalleryItem12.CommandName = "ChartHidePrimaryHorizontalAxis"
        SpreadsheetCommandGalleryItem12.Description = "Do not display axis."
        SpreadsheetCommandGalleryItem12.Hint = "Do not display axis."
        SpreadsheetCommandGalleryItem13.Caption = "Show Left to Right Axis"
        SpreadsheetCommandGalleryItem13.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
        SpreadsheetCommandGalleryItem13.Description = "Display Axis Left to Right with Labels"
        SpreadsheetCommandGalleryItem13.Hint = "Display Axis Left to Right with Labels"
        SpreadsheetCommandGalleryItem14.Caption = "Show Axis without Labeling"
        SpreadsheetCommandGalleryItem14.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
        SpreadsheetCommandGalleryItem14.Description = "Display Axis without labels or tick marks"
        SpreadsheetCommandGalleryItem14.Hint = "Display Axis without labels or tick marks"
        SpreadsheetCommandGalleryItem15.Caption = "Show Right to Left Axis"
        SpreadsheetCommandGalleryItem15.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
        SpreadsheetCommandGalleryItem15.Description = "Display Axis Right to Left with Labels"
        SpreadsheetCommandGalleryItem15.Hint = "Display Axis Right to Left with Labels"
        SpreadsheetCommandGalleryItem16.Caption = "Show Default Axis"
        SpreadsheetCommandGalleryItem16.CommandName = "ChartPrimaryHorizontalAxisDefault"
        SpreadsheetCommandGalleryItem16.Description = "Display Axis with default order and labels"
        SpreadsheetCommandGalleryItem16.Hint = "Display Axis with default order and labels"
        SpreadsheetCommandGalleryItem17.Caption = "Show Axis in Thousands"
        SpreadsheetCommandGalleryItem17.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
        SpreadsheetCommandGalleryItem17.Description = "Display Axis with numbers represented in Thousands"
        SpreadsheetCommandGalleryItem17.Hint = "Display Axis with numbers represented in Thousands"
        SpreadsheetCommandGalleryItem18.Caption = "Show Axis in Millions"
        SpreadsheetCommandGalleryItem18.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
        SpreadsheetCommandGalleryItem18.Description = "Display Axis with numbers represented in Millions"
        SpreadsheetCommandGalleryItem18.Hint = "Display Axis with numbers represented in Millions"
        SpreadsheetCommandGalleryItem19.Caption = "Show Axis in Billions"
        SpreadsheetCommandGalleryItem19.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
        SpreadsheetCommandGalleryItem19.Description = "Display Axis with numbers represented in Billions"
        SpreadsheetCommandGalleryItem19.Hint = "Display Axis with numbers represented in Billions"
        SpreadsheetCommandGalleryItem20.Caption = "Show Axis in Log Scale"
        SpreadsheetCommandGalleryItem20.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
        SpreadsheetCommandGalleryItem20.Description = "Display Axis using a log 10 base scale"
        SpreadsheetCommandGalleryItem20.Hint = "Display Axis using a log 10 base scale"
        SpreadsheetCommandGalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem12, SpreadsheetCommandGalleryItem13, SpreadsheetCommandGalleryItem14, SpreadsheetCommandGalleryItem15, SpreadsheetCommandGalleryItem16, SpreadsheetCommandGalleryItem17, SpreadsheetCommandGalleryItem18, SpreadsheetCommandGalleryItem19, SpreadsheetCommandGalleryItem20})
        Me.CommandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup1})
        Me.CommandBarGalleryDropDown1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown1.Gallery.RowCount = 9
        Me.CommandBarGalleryDropDown1.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown1.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown1.Name = "CommandBarGalleryDropDown1"
        Me.CommandBarGalleryDropDown1.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown2
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown2.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown2.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup2.Caption = "Primary Vertical Axis"
        SpreadsheetCommandGalleryItemGroup2.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
        SpreadsheetCommandGalleryItem21.Caption = "None"
        SpreadsheetCommandGalleryItem21.CommandName = "ChartHidePrimaryVerticalAxis"
        SpreadsheetCommandGalleryItem21.Description = "Do not display axis."
        SpreadsheetCommandGalleryItem21.Hint = "Do not display axis."
        SpreadsheetCommandGalleryItem22.Caption = "Show Left to Right Axis"
        SpreadsheetCommandGalleryItem22.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
        SpreadsheetCommandGalleryItem22.Description = "Display Axis Left to Right with Labels"
        SpreadsheetCommandGalleryItem22.Hint = "Display Axis Left to Right with Labels"
        SpreadsheetCommandGalleryItem23.Caption = "Show Axis without Labeling"
        SpreadsheetCommandGalleryItem23.CommandName = "ChartPrimaryVerticalAxisHideLabels"
        SpreadsheetCommandGalleryItem23.Description = "Display Axis without labels or tick marks"
        SpreadsheetCommandGalleryItem23.Hint = "Display Axis without labels or tick marks"
        SpreadsheetCommandGalleryItem24.Caption = "Show Right to Left Axis"
        SpreadsheetCommandGalleryItem24.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
        SpreadsheetCommandGalleryItem24.Description = "Display Axis Right to Left with Labels"
        SpreadsheetCommandGalleryItem24.Hint = "Display Axis Right to Left with Labels"
        SpreadsheetCommandGalleryItem25.Caption = "Show Default Axis"
        SpreadsheetCommandGalleryItem25.CommandName = "ChartPrimaryVerticalAxisDefault"
        SpreadsheetCommandGalleryItem25.Description = "Display Axis with default order and labels"
        SpreadsheetCommandGalleryItem25.Hint = "Display Axis with default order and labels"
        SpreadsheetCommandGalleryItem26.Caption = "Show Axis in Thousands"
        SpreadsheetCommandGalleryItem26.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
        SpreadsheetCommandGalleryItem26.Description = "Display Axis with numbers represented in Thousands"
        SpreadsheetCommandGalleryItem26.Hint = "Display Axis with numbers represented in Thousands"
        SpreadsheetCommandGalleryItem27.Caption = "Show Axis in Millions"
        SpreadsheetCommandGalleryItem27.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
        SpreadsheetCommandGalleryItem27.Description = "Display Axis with numbers represented in Millions"
        SpreadsheetCommandGalleryItem27.Hint = "Display Axis with numbers represented in Millions"
        SpreadsheetCommandGalleryItem28.Caption = "Show Axis in Billions"
        SpreadsheetCommandGalleryItem28.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
        SpreadsheetCommandGalleryItem28.Description = "Display Axis with numbers represented in Billions"
        SpreadsheetCommandGalleryItem28.Hint = "Display Axis with numbers represented in Billions"
        SpreadsheetCommandGalleryItem29.Caption = "Show Axis in Log Scale"
        SpreadsheetCommandGalleryItem29.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
        SpreadsheetCommandGalleryItem29.Description = "Display Axis using a log 10 base scale"
        SpreadsheetCommandGalleryItem29.Hint = "Display Axis using a log 10 base scale"
        SpreadsheetCommandGalleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem21, SpreadsheetCommandGalleryItem22, SpreadsheetCommandGalleryItem23, SpreadsheetCommandGalleryItem24, SpreadsheetCommandGalleryItem25, SpreadsheetCommandGalleryItem26, SpreadsheetCommandGalleryItem27, SpreadsheetCommandGalleryItem28, SpreadsheetCommandGalleryItem29})
        Me.CommandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup2})
        Me.CommandBarGalleryDropDown2.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown2.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown2.Gallery.RowCount = 9
        Me.CommandBarGalleryDropDown2.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown2.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown2.Name = "CommandBarGalleryDropDown2"
        Me.CommandBarGalleryDropDown2.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown3
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown3.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown3.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup3.Caption = "Primary Horizontal Gridlines"
        SpreadsheetCommandGalleryItemGroup3.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
        SpreadsheetCommandGalleryItem30.Caption = "None"
        SpreadsheetCommandGalleryItem30.CommandName = "ChartPrimaryHorizontalGridlinesNone"
        SpreadsheetCommandGalleryItem30.Description = "Do not display Horizontal Gridlines"
        SpreadsheetCommandGalleryItem30.Hint = "Do not display Horizontal Gridlines"
        SpreadsheetCommandGalleryItem31.Caption = "Major Gridlines"
        SpreadsheetCommandGalleryItem31.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
        SpreadsheetCommandGalleryItem31.Description = "Display Horizontal Gridlines for Major units"
        SpreadsheetCommandGalleryItem31.Hint = "Display Horizontal Gridlines for Major units"
        SpreadsheetCommandGalleryItem32.Caption = "Minor Gridlines"
        SpreadsheetCommandGalleryItem32.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
        SpreadsheetCommandGalleryItem32.Description = "Display Horizontal Gridlines for Minor units"
        SpreadsheetCommandGalleryItem32.Hint = "Display Horizontal Gridlines for Minor units"
        SpreadsheetCommandGalleryItem33.Caption = "Major & Minor Gridlines"
        SpreadsheetCommandGalleryItem33.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
        SpreadsheetCommandGalleryItem33.Description = "Display Horizontal Gridlines for Major and Minor units"
        SpreadsheetCommandGalleryItem33.Hint = "Display Horizontal Gridlines for Major and Minor units"
        SpreadsheetCommandGalleryItemGroup3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem30, SpreadsheetCommandGalleryItem31, SpreadsheetCommandGalleryItem32, SpreadsheetCommandGalleryItem33})
        Me.CommandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup3})
        Me.CommandBarGalleryDropDown3.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown3.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown3.Gallery.RowCount = 4
        Me.CommandBarGalleryDropDown3.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown3.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown3.Name = "CommandBarGalleryDropDown3"
        Me.CommandBarGalleryDropDown3.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown4
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown4.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown4.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup4.Caption = "Primary Vertical Gridlines"
        SpreadsheetCommandGalleryItemGroup4.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
        SpreadsheetCommandGalleryItem34.Caption = "None"
        SpreadsheetCommandGalleryItem34.CommandName = "ChartPrimaryVerticalGridlinesNone"
        SpreadsheetCommandGalleryItem34.Description = "Do not display Vertical Gridlines"
        SpreadsheetCommandGalleryItem34.Hint = "Do not display Vertical Gridlines"
        SpreadsheetCommandGalleryItem35.Caption = "Major Gridlines"
        SpreadsheetCommandGalleryItem35.CommandName = "ChartPrimaryVerticalGridlinesMajor"
        SpreadsheetCommandGalleryItem35.Description = "Display Vertical Gridlines for Major units"
        SpreadsheetCommandGalleryItem35.Hint = "Display Vertical Gridlines for Major units"
        SpreadsheetCommandGalleryItem36.Caption = "Minor Gridlines"
        SpreadsheetCommandGalleryItem36.CommandName = "ChartPrimaryVerticalGridlinesMinor"
        SpreadsheetCommandGalleryItem36.Description = "Display Vertical Gridlines for Minor units"
        SpreadsheetCommandGalleryItem36.Hint = "Display Vertical Gridlines for Minor units"
        SpreadsheetCommandGalleryItem37.Caption = "Major & Minor Gridlines"
        SpreadsheetCommandGalleryItem37.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
        SpreadsheetCommandGalleryItem37.Description = "Display Vertical Gridlines for Major and Minor units"
        SpreadsheetCommandGalleryItem37.Hint = "Display Vertical Gridlines for Major and Minor units"
        SpreadsheetCommandGalleryItemGroup4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem34, SpreadsheetCommandGalleryItem35, SpreadsheetCommandGalleryItem36, SpreadsheetCommandGalleryItem37})
        Me.CommandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup4})
        Me.CommandBarGalleryDropDown4.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown4.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown4.Gallery.RowCount = 4
        Me.CommandBarGalleryDropDown4.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown4.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown4.Name = "CommandBarGalleryDropDown4"
        Me.CommandBarGalleryDropDown4.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown5
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown5.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown5.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup5.Caption = "Chart Title"
        SpreadsheetCommandGalleryItemGroup5.CommandName = "ChartTitleCommandGroup"
        SpreadsheetCommandGalleryItem38.Caption = "None"
        SpreadsheetCommandGalleryItem38.CommandName = "ChartTitleNone"
        SpreadsheetCommandGalleryItem38.Description = "Do not display a chart Title"
        SpreadsheetCommandGalleryItem38.Hint = "Do not display a chart Title"
        SpreadsheetCommandGalleryItem39.Caption = "Centered Overlay Title"
        SpreadsheetCommandGalleryItem39.CommandName = "ChartTitleCenteredOverlay"
        SpreadsheetCommandGalleryItem39.Description = "Overlay centered Title on chart without resizing chart"
        SpreadsheetCommandGalleryItem39.Hint = "Overlay centered Title on chart without resizing chart"
        SpreadsheetCommandGalleryItem40.Caption = "Above Chart"
        SpreadsheetCommandGalleryItem40.CommandName = "ChartTitleAbove"
        SpreadsheetCommandGalleryItem40.Description = "Display Title at top of chart area and resize chart"
        SpreadsheetCommandGalleryItem40.Hint = "Display Title at top of chart area and resize chart"
        SpreadsheetCommandGalleryItemGroup5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem38, SpreadsheetCommandGalleryItem39, SpreadsheetCommandGalleryItem40})
        Me.CommandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup5})
        Me.CommandBarGalleryDropDown5.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown5.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown5.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown5.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown5.Name = "CommandBarGalleryDropDown5"
        Me.CommandBarGalleryDropDown5.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown6
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown6.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown6.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup6.Caption = "Primary Horizontal Axis Title"
        SpreadsheetCommandGalleryItemGroup6.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
        SpreadsheetCommandGalleryItem41.Caption = "None"
        SpreadsheetCommandGalleryItem41.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
        SpreadsheetCommandGalleryItem41.Description = "Do not display an Axis Title"
        SpreadsheetCommandGalleryItem41.Hint = "Do not display an Axis Title"
        SpreadsheetCommandGalleryItem42.Caption = "Title Below Axis"
        SpreadsheetCommandGalleryItem42.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
        SpreadsheetCommandGalleryItem42.Description = "Display Title below Horizontal Axis and resize chart"
        SpreadsheetCommandGalleryItem42.Hint = "Display Title below Horizontal Axis and resize chart"
        SpreadsheetCommandGalleryItemGroup6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem41, SpreadsheetCommandGalleryItem42})
        Me.CommandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup6})
        Me.CommandBarGalleryDropDown6.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown6.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown6.Gallery.RowCount = 2
        Me.CommandBarGalleryDropDown6.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown6.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown6.Name = "CommandBarGalleryDropDown6"
        Me.CommandBarGalleryDropDown6.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown7
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown7.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown7.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup7.Caption = "Primary Vertical Axis Title"
        SpreadsheetCommandGalleryItemGroup7.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
        SpreadsheetCommandGalleryItem43.Caption = "None"
        SpreadsheetCommandGalleryItem43.CommandName = "ChartPrimaryVerticalAxisTitleNone"
        SpreadsheetCommandGalleryItem43.Description = "Do not display an Axis Title"
        SpreadsheetCommandGalleryItem43.Hint = "Do not display an Axis Title"
        SpreadsheetCommandGalleryItem44.Caption = "Rotated Title"
        SpreadsheetCommandGalleryItem44.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
        SpreadsheetCommandGalleryItem44.Description = "Display Rotated Axis Title and resize chart"
        SpreadsheetCommandGalleryItem44.Hint = "Display Rotated Axis Title and resize chart"
        SpreadsheetCommandGalleryItem45.Caption = "Vertical Title"
        SpreadsheetCommandGalleryItem45.CommandName = "ChartPrimaryVerticalAxisTitleVertical"
        SpreadsheetCommandGalleryItem45.Description = "Display Axis Title with vertical text and resize chart"
        SpreadsheetCommandGalleryItem45.Hint = "Display Axis Title with vertical text and resize chart"
        SpreadsheetCommandGalleryItem46.Caption = "Horizontal Title"
        SpreadsheetCommandGalleryItem46.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal"
        SpreadsheetCommandGalleryItem46.Description = "Display Axis Title horizontally and resize chart"
        SpreadsheetCommandGalleryItem46.Hint = "Display Axis Title horizontally and resize chart"
        SpreadsheetCommandGalleryItemGroup7.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem43, SpreadsheetCommandGalleryItem44, SpreadsheetCommandGalleryItem45, SpreadsheetCommandGalleryItem46})
        Me.CommandBarGalleryDropDown7.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup7})
        Me.CommandBarGalleryDropDown7.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown7.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown7.Gallery.RowCount = 4
        Me.CommandBarGalleryDropDown7.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown7.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown7.Name = "CommandBarGalleryDropDown7"
        Me.CommandBarGalleryDropDown7.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown8
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown8.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown8.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup8.Caption = "Legend"
        SpreadsheetCommandGalleryItemGroup8.CommandName = "ChartLegendCommandGroup"
        SpreadsheetCommandGalleryItem47.Caption = "None"
        SpreadsheetCommandGalleryItem47.CommandName = "ChartLegendNone"
        SpreadsheetCommandGalleryItem47.Description = "Turn off Legend"
        SpreadsheetCommandGalleryItem47.Hint = "Turn off Legend"
        SpreadsheetCommandGalleryItem48.Caption = "Show Legend at Right"
        SpreadsheetCommandGalleryItem48.CommandName = "ChartLegendAtRight"
        SpreadsheetCommandGalleryItem48.Description = "Show Legend and align right"
        SpreadsheetCommandGalleryItem48.Hint = "Show Legend and align right"
        SpreadsheetCommandGalleryItem49.Caption = "Show Legend at Top"
        SpreadsheetCommandGalleryItem49.CommandName = "ChartLegendAtTop"
        SpreadsheetCommandGalleryItem49.Description = "Show Legend and align top"
        SpreadsheetCommandGalleryItem49.Hint = "Show Legend and align top"
        SpreadsheetCommandGalleryItem50.Caption = "Show Legend at Left"
        SpreadsheetCommandGalleryItem50.CommandName = "ChartLegendAtLeft"
        SpreadsheetCommandGalleryItem50.Description = "Show Legend and align left"
        SpreadsheetCommandGalleryItem50.Hint = "Show Legend and align left"
        SpreadsheetCommandGalleryItem51.Caption = "Show Legend at Bottom"
        SpreadsheetCommandGalleryItem51.CommandName = "ChartLegendAtBottom"
        SpreadsheetCommandGalleryItem51.Description = "Show Legend and align bottom"
        SpreadsheetCommandGalleryItem51.Hint = "Show Legend and align bottom"
        SpreadsheetCommandGalleryItem52.Caption = "Overlay Legend at Right"
        SpreadsheetCommandGalleryItem52.CommandName = "ChartLegendOverlayAtRight"
        SpreadsheetCommandGalleryItem52.Description = "Show Legend at right of the chart without resizing"
        SpreadsheetCommandGalleryItem52.Hint = "Show Legend at right of the chart without resizing"
        SpreadsheetCommandGalleryItem53.Caption = "Overlay Legend at Left"
        SpreadsheetCommandGalleryItem53.CommandName = "ChartLegendOverlayAtLeft"
        SpreadsheetCommandGalleryItem53.Description = "Show Legend at left of the chart without resizing"
        SpreadsheetCommandGalleryItem53.Hint = "Show Legend at left of the chart without resizing"
        SpreadsheetCommandGalleryItemGroup8.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem47, SpreadsheetCommandGalleryItem48, SpreadsheetCommandGalleryItem49, SpreadsheetCommandGalleryItem50, SpreadsheetCommandGalleryItem51, SpreadsheetCommandGalleryItem52, SpreadsheetCommandGalleryItem53})
        Me.CommandBarGalleryDropDown8.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup8})
        Me.CommandBarGalleryDropDown8.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown8.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown8.Gallery.RowCount = 7
        Me.CommandBarGalleryDropDown8.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown8.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown8.Name = "CommandBarGalleryDropDown8"
        Me.CommandBarGalleryDropDown8.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown9
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown9.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown9.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup9.Caption = "Data Labels"
        SpreadsheetCommandGalleryItemGroup9.CommandName = "ChartDataLabelsCommandGroup"
        SpreadsheetCommandGalleryItem54.Caption = "None"
        SpreadsheetCommandGalleryItem54.CommandName = "ChartDataLabelsNone"
        SpreadsheetCommandGalleryItem54.Description = "Turn off Data Labels for selection"
        SpreadsheetCommandGalleryItem54.Hint = "Turn off Data Labels for selection"
        SpreadsheetCommandGalleryItem55.Caption = "Show"
        SpreadsheetCommandGalleryItem55.CommandName = "ChartDataLabelsDefault"
        SpreadsheetCommandGalleryItem55.Description = "Turn on Data Labels for selection"
        SpreadsheetCommandGalleryItem55.Hint = "Turn on Data Labels for selection"
        SpreadsheetCommandGalleryItem56.Caption = "Center"
        SpreadsheetCommandGalleryItem56.CommandName = "ChartDataLabelsCenter"
        SpreadsheetCommandGalleryItem56.Description = "Display Data Labels and position centered on the data point(s)"
        SpreadsheetCommandGalleryItem56.Hint = "Display Data Labels and position centered on the data point(s)"
        SpreadsheetCommandGalleryItem57.Caption = "Inside End"
        SpreadsheetCommandGalleryItem57.CommandName = "ChartDataLabelsInsideEnd"
        SpreadsheetCommandGalleryItem57.Description = "Display Data Labels and position inside the end of data point(s)"
        SpreadsheetCommandGalleryItem57.Hint = "Display Data Labels and position inside the end of data point(s)"
        SpreadsheetCommandGalleryItem58.Caption = "Inside Base"
        SpreadsheetCommandGalleryItem58.CommandName = "ChartDataLabelsInsideBase"
        SpreadsheetCommandGalleryItem58.Description = "Display Data Labels and position inside the base of data point(s)"
        SpreadsheetCommandGalleryItem58.Hint = "Display Data Labels and position inside the base of data point(s)"
        SpreadsheetCommandGalleryItem59.Caption = "Outside End"
        SpreadsheetCommandGalleryItem59.CommandName = "ChartDataLabelsOutsideEnd"
        SpreadsheetCommandGalleryItem59.Description = "Display Data Labels and position outside the end of data point(s)"
        SpreadsheetCommandGalleryItem59.Hint = "Display Data Labels and position outside the end of data point(s)"
        SpreadsheetCommandGalleryItem60.Caption = "Best Fit"
        SpreadsheetCommandGalleryItem60.CommandName = "ChartDataLabelsBestFit"
        SpreadsheetCommandGalleryItem60.Description = "Display Data Labels and position with Best Fit"
        SpreadsheetCommandGalleryItem60.Hint = "Display Data Labels and position with Best Fit"
        SpreadsheetCommandGalleryItem61.Caption = "Left"
        SpreadsheetCommandGalleryItem61.CommandName = "ChartDataLabelsLeft"
        SpreadsheetCommandGalleryItem61.Description = "Display Data Labels and position left of the data point(s)"
        SpreadsheetCommandGalleryItem61.Hint = "Display Data Labels and position left of the data point(s)"
        SpreadsheetCommandGalleryItem62.Caption = "Right"
        SpreadsheetCommandGalleryItem62.CommandName = "ChartDataLabelsRight"
        SpreadsheetCommandGalleryItem62.Description = "Display Data Labels and position right of the data point(s)"
        SpreadsheetCommandGalleryItem62.Hint = "Display Data Labels and position right of the data point(s)"
        SpreadsheetCommandGalleryItem63.Caption = "Above"
        SpreadsheetCommandGalleryItem63.CommandName = "ChartDataLabelsAbove"
        SpreadsheetCommandGalleryItem63.Description = "Display Data Labels and position above data point(s)"
        SpreadsheetCommandGalleryItem63.Hint = "Display Data Labels and position above data point(s)"
        SpreadsheetCommandGalleryItem64.Caption = "Below"
        SpreadsheetCommandGalleryItem64.CommandName = "ChartDataLabelsBelow"
        SpreadsheetCommandGalleryItem64.Description = "Display Data Labels and position below data point(s)"
        SpreadsheetCommandGalleryItem64.Hint = "Display Data Labels and position below data point(s)"
        SpreadsheetCommandGalleryItemGroup9.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem54, SpreadsheetCommandGalleryItem55, SpreadsheetCommandGalleryItem56, SpreadsheetCommandGalleryItem57, SpreadsheetCommandGalleryItem58, SpreadsheetCommandGalleryItem59, SpreadsheetCommandGalleryItem60, SpreadsheetCommandGalleryItem61, SpreadsheetCommandGalleryItem62, SpreadsheetCommandGalleryItem63, SpreadsheetCommandGalleryItem64})
        Me.CommandBarGalleryDropDown9.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup9})
        Me.CommandBarGalleryDropDown9.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown9.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown9.Gallery.RowCount = 11
        Me.CommandBarGalleryDropDown9.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown9.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown9.Name = "CommandBarGalleryDropDown9"
        Me.CommandBarGalleryDropDown9.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown10
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown10.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown10.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup10.Caption = "Lines"
        SpreadsheetCommandGalleryItemGroup10.CommandName = "ChartLinesCommandGroup"
        SpreadsheetCommandGalleryItem65.Caption = "None"
        SpreadsheetCommandGalleryItem65.CommandName = "ChartLinesNone"
        SpreadsheetCommandGalleryItem65.Description = "Do not show Drop Lines, High-Low Lines or Series Lines"
        SpreadsheetCommandGalleryItem65.Hint = "Do not show Drop Lines, High-Low Lines or Series Lines"
        SpreadsheetCommandGalleryItem66.Caption = "Drop Lines"
        SpreadsheetCommandGalleryItem66.CommandName = "ChartShowDropLines"
        SpreadsheetCommandGalleryItem66.Description = "Show Drop Lines on an Area or Line Chart"
        SpreadsheetCommandGalleryItem66.Hint = "Show Drop Lines on an Area or Line Chart"
        SpreadsheetCommandGalleryItem67.Caption = "High-Low Lines"
        SpreadsheetCommandGalleryItem67.CommandName = "ChartShowHighLowLines"
        SpreadsheetCommandGalleryItem67.Description = "Show High-Low Lines on a 2D Line Chart"
        SpreadsheetCommandGalleryItem67.Hint = "Show High-Low Lines on a 2D Line Chart"
        SpreadsheetCommandGalleryItem68.Caption = "Drop and High-Low Lines"
        SpreadsheetCommandGalleryItem68.CommandName = "ChartShowDropLinesAndHighLowLines"
        SpreadsheetCommandGalleryItem68.Description = "Show Drop Lines and High-Low Lines on a 2D Line Chart"
        SpreadsheetCommandGalleryItem68.Hint = "Show Drop Lines and High-Low Lines on a 2D Line Chart"
        SpreadsheetCommandGalleryItem69.Caption = "Series Lines"
        SpreadsheetCommandGalleryItem69.CommandName = "ChartShowSeriesLines"
        SpreadsheetCommandGalleryItem69.Description = "Show Series Lines on a 2D stacked Bar/Column Pie or Pie or Bar of Pie Chart"
        SpreadsheetCommandGalleryItem69.Hint = "Show Series Lines on a 2D stacked Bar/Column Pie or Pie or Bar of Pie Chart"
        SpreadsheetCommandGalleryItemGroup10.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem65, SpreadsheetCommandGalleryItem66, SpreadsheetCommandGalleryItem67, SpreadsheetCommandGalleryItem68, SpreadsheetCommandGalleryItem69})
        Me.CommandBarGalleryDropDown10.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup10})
        Me.CommandBarGalleryDropDown10.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown10.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown10.Gallery.RowCount = 5
        Me.CommandBarGalleryDropDown10.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown10.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown10.Name = "CommandBarGalleryDropDown10"
        Me.CommandBarGalleryDropDown10.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown11
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown11.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown11.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup11.Caption = "Up/Down Bars"
        SpreadsheetCommandGalleryItemGroup11.CommandName = "ChartUpDownBarsCommandGroup"
        SpreadsheetCommandGalleryItem70.Caption = "None"
        SpreadsheetCommandGalleryItem70.CommandName = "ChartHideUpDownBars"
        SpreadsheetCommandGalleryItem70.Description = "Do not show Up/Down Bars"
        SpreadsheetCommandGalleryItem70.Hint = "Do not show Up/Down Bars"
        SpreadsheetCommandGalleryItem71.Caption = "Up/Down Bars"
        SpreadsheetCommandGalleryItem71.CommandName = "ChartShowUpDownBars"
        SpreadsheetCommandGalleryItem71.Description = "Show Up/Down Bars on a Line Chart"
        SpreadsheetCommandGalleryItem71.Hint = "Show Up/Down Bars on a Line Chart"
        SpreadsheetCommandGalleryItemGroup11.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem70, SpreadsheetCommandGalleryItem71})
        Me.CommandBarGalleryDropDown11.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup11})
        Me.CommandBarGalleryDropDown11.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown11.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown11.Gallery.RowCount = 2
        Me.CommandBarGalleryDropDown11.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown11.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown11.Name = "CommandBarGalleryDropDown11"
        Me.CommandBarGalleryDropDown11.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown12
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown12.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
        Me.CommandBarGalleryDropDown12.Gallery.ColumnCount = 1
        SpreadsheetCommandGalleryItemGroup12.Caption = "Error Bars"
        SpreadsheetCommandGalleryItemGroup12.CommandName = "ChartErrorBarsCommandGroup"
        SpreadsheetCommandGalleryItem72.Caption = "None"
        SpreadsheetCommandGalleryItem72.CommandName = "ChartErrorBarsNone"
        SpreadsheetCommandGalleryItem72.Description = "Removes the Error Bars for the selected series or all Error Bars if none are sele" &
    "cted"
        SpreadsheetCommandGalleryItem72.Hint = "Removes the Error Bars for the selected series or all Error Bars if none are sele" &
    "cted"
        SpreadsheetCommandGalleryItem73.Caption = "Error Bars with Standard Error"
        SpreadsheetCommandGalleryItem73.CommandName = "ChartErrorBarsStandardError"
        SpreadsheetCommandGalleryItem73.Description = "Displays Error Bars for the selected chart series using Standard Error"
        SpreadsheetCommandGalleryItem73.Hint = "Displays Error Bars for the selected chart series using Standard Error"
        SpreadsheetCommandGalleryItem74.Caption = "Error Bars with Percentage"
        SpreadsheetCommandGalleryItem74.CommandName = "ChartErrorBarsPercentage"
        SpreadsheetCommandGalleryItem74.Description = "Displays Error Bars for the selected chart series with 5% value"
        SpreadsheetCommandGalleryItem74.Hint = "Displays Error Bars for the selected chart series with 5% value"
        SpreadsheetCommandGalleryItem75.Caption = "Error Bars with Standard Deviation"
        SpreadsheetCommandGalleryItem75.CommandName = "ChartErrorBarsStandardDeviation"
        SpreadsheetCommandGalleryItem75.Description = "Displays Error Bars for the selected chart series with 1 standard deviation"
        SpreadsheetCommandGalleryItem75.Hint = "Displays Error Bars for the selected chart series with 1 standard deviation"
        SpreadsheetCommandGalleryItemGroup12.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem72, SpreadsheetCommandGalleryItem73, SpreadsheetCommandGalleryItem74, SpreadsheetCommandGalleryItem75})
        Me.CommandBarGalleryDropDown12.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup12})
        Me.CommandBarGalleryDropDown12.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown12.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.CommandBarGalleryDropDown12.Gallery.RowCount = 4
        Me.CommandBarGalleryDropDown12.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown12.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown12.Name = "CommandBarGalleryDropDown12"
        Me.CommandBarGalleryDropDown12.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown13
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown13.Gallery.ColumnCount = 4
        SpreadsheetCommandGalleryItemGroup13.Caption = "2-D Column"
        SpreadsheetCommandGalleryItemGroup13.CommandName = "InsertChartColumn2DCommandGroup"
        SpreadsheetCommandGalleryItem76.Caption = "Clustered Column"
        SpreadsheetCommandGalleryItem76.CommandName = "InsertChartColumnClustered2D"
        SpreadsheetCommandGalleryItem76.Description = "Compare values across categories by using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the" &
    " order of categories is not important or for displaying item counts such as a hi" &
    "stogram."
        SpreadsheetCommandGalleryItem76.Hint = "Compare values across categories by using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the" &
    " order of categories is not important or for displaying item counts such as a hi" &
    "stogram."
        SpreadsheetCommandGalleryItem77.Caption = "Stacked Column"
        SpreadsheetCommandGalleryItem77.CommandName = "InsertChartColumnStacked2D"
        SpreadsheetCommandGalleryItem77.Description = "Compare the contribution of each value to a total across categories by using vert" &
    "ical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the total across series for one category" &
    "."
        SpreadsheetCommandGalleryItem77.Hint = "Compare the contribution of each value to a total across categories by using vert" &
    "ical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the total across series for one category" &
    "."
        SpreadsheetCommandGalleryItem78.Caption = "100% Stacked Column"
        SpreadsheetCommandGalleryItem78.CommandName = "InsertChartColumnPercentStacked2D"
        SpreadsheetCommandGalleryItem78.Description = "Compare the percentage that each value contributes to a total across categories b" &
    "y using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is to emphasize the proportion of each data " &
    "series."
        SpreadsheetCommandGalleryItem78.Hint = "Compare the percentage that each value contributes to a total across categories b" &
    "y using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is to emphasize the proportion of each data " &
    "series."
        SpreadsheetCommandGalleryItemGroup13.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem76, SpreadsheetCommandGalleryItem77, SpreadsheetCommandGalleryItem78})
        SpreadsheetCommandGalleryItemGroup14.Caption = "3-D Column"
        SpreadsheetCommandGalleryItemGroup14.CommandName = "InsertChartColumn3DCommandGroup"
        SpreadsheetCommandGalleryItem79.Caption = "3-D Clustered Column"
        SpreadsheetCommandGalleryItem79.CommandName = "InsertChartColumnClustered3D"
        SpreadsheetCommandGalleryItem79.Description = "Compare values across categories and display clustered columns in 3-D format."
        SpreadsheetCommandGalleryItem79.Hint = "Compare values across categories and display clustered columns in 3-D format."
        SpreadsheetCommandGalleryItem80.Caption = "Stacked Column in 3-D"
        SpreadsheetCommandGalleryItem80.CommandName = "InsertChartColumnStacked3D"
        SpreadsheetCommandGalleryItem80.Description = "Compare the contribution of each value to a total across categories and display s" &
    "tacked columns in 3-D format."
        SpreadsheetCommandGalleryItem80.Hint = "Compare the contribution of each value to a total across categories and display s" &
    "tacked columns in 3-D format."
        SpreadsheetCommandGalleryItem81.Caption = "100% Stacked Column in 3-D"
        SpreadsheetCommandGalleryItem81.CommandName = "InsertChartColumnPercentStacked3D"
        SpreadsheetCommandGalleryItem81.Description = "Compare the percentage that each value contributes to a total across categories a" &
    "nd display 100% stacked columns in 3-D format."
        SpreadsheetCommandGalleryItem81.Hint = "Compare the percentage that each value contributes to a total across categories a" &
    "nd display 100% stacked columns in 3-D format."
        SpreadsheetCommandGalleryItem82.Caption = "3-D Column"
        SpreadsheetCommandGalleryItem82.CommandName = "InsertChartColumn3D"
        SpreadsheetCommandGalleryItem82.Description = "Compare values across categories and across series on three axes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when " &
    "the categories and series are equally important."
        SpreadsheetCommandGalleryItem82.Hint = "Compare values across categories and across series on three axes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when " &
    "the categories and series are equally important."
        SpreadsheetCommandGalleryItemGroup14.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem79, SpreadsheetCommandGalleryItem80, SpreadsheetCommandGalleryItem81, SpreadsheetCommandGalleryItem82})
        SpreadsheetCommandGalleryItemGroup15.Caption = "Cylinder"
        SpreadsheetCommandGalleryItemGroup15.CommandName = "InsertChartCylinderCommandGroup"
        SpreadsheetCommandGalleryItem83.Caption = "Clustered Cylinder"
        SpreadsheetCommandGalleryItem83.CommandName = "InsertChartCylinderClustered"
        SpreadsheetCommandGalleryItem83.Description = "Compare values across categories."
        SpreadsheetCommandGalleryItem83.Hint = "Compare values across categories."
        SpreadsheetCommandGalleryItem84.Caption = "Stacked Cylinder"
        SpreadsheetCommandGalleryItem84.CommandName = "InsertChartCylinderStacked"
        SpreadsheetCommandGalleryItem84.Description = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem84.Hint = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem85.Caption = "100% Stacked Cylinder"
        SpreadsheetCommandGalleryItem85.CommandName = "InsertChartCylinderPercentStacked"
        SpreadsheetCommandGalleryItem85.Description = "Compare the percentage that each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem85.Hint = "Compare the percentage that each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem86.Caption = "3-D Cylinder"
        SpreadsheetCommandGalleryItem86.CommandName = "InsertChartCylinder"
        SpreadsheetCommandGalleryItem86.Description = "Compare values across categories and across series and display a cylinder chart o" &
    "n three axes."
        SpreadsheetCommandGalleryItem86.Hint = "Compare values across categories and across series and display a cylinder chart o" &
    "n three axes."
        SpreadsheetCommandGalleryItemGroup15.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem83, SpreadsheetCommandGalleryItem84, SpreadsheetCommandGalleryItem85, SpreadsheetCommandGalleryItem86})
        SpreadsheetCommandGalleryItemGroup16.Caption = "Cone"
        SpreadsheetCommandGalleryItemGroup16.CommandName = "InsertChartConeCommandGroup"
        SpreadsheetCommandGalleryItem87.Caption = "Clustered Cone"
        SpreadsheetCommandGalleryItem87.CommandName = "InsertChartConeClustered"
        SpreadsheetCommandGalleryItem87.Description = "Compare values across categories."
        SpreadsheetCommandGalleryItem87.Hint = "Compare values across categories."
        SpreadsheetCommandGalleryItem88.Caption = "Stacked Cone"
        SpreadsheetCommandGalleryItem88.CommandName = "InsertChartConeStacked"
        SpreadsheetCommandGalleryItem88.Description = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem88.Hint = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem89.Caption = "100% Stacked Cone"
        SpreadsheetCommandGalleryItem89.CommandName = "InsertChartConePercentStacked"
        SpreadsheetCommandGalleryItem89.Description = "Compare the percentage that each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem89.Hint = "Compare the percentage that each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem90.Caption = "3-D Cone"
        SpreadsheetCommandGalleryItem90.CommandName = "InsertChartCone"
        SpreadsheetCommandGalleryItem90.Description = "Compare values across categories and across series and display a cone chart on th" &
    "ree axes."
        SpreadsheetCommandGalleryItem90.Hint = "Compare values across categories and across series and display a cone chart on th" &
    "ree axes."
        SpreadsheetCommandGalleryItemGroup16.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem87, SpreadsheetCommandGalleryItem88, SpreadsheetCommandGalleryItem89, SpreadsheetCommandGalleryItem90})
        SpreadsheetCommandGalleryItemGroup17.Caption = "Pyramid"
        SpreadsheetCommandGalleryItemGroup17.CommandName = "InsertChartPyramidCommandGroup"
        SpreadsheetCommandGalleryItem91.Caption = "Clustered Pyramid"
        SpreadsheetCommandGalleryItem91.CommandName = "InsertChartPyramidClustered"
        SpreadsheetCommandGalleryItem91.Description = "Compare values across categories."
        SpreadsheetCommandGalleryItem91.Hint = "Compare values across categories."
        SpreadsheetCommandGalleryItem92.Caption = "Stacked Pyramid"
        SpreadsheetCommandGalleryItem92.CommandName = "InsertChartPyramidStacked"
        SpreadsheetCommandGalleryItem92.Description = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem92.Hint = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem93.Caption = "100% Stacked Pyramid"
        SpreadsheetCommandGalleryItem93.CommandName = "InsertChartPyramidPercentStacked"
        SpreadsheetCommandGalleryItem93.Description = "Compare the percentage that each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem93.Hint = "Compare the percentage that each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem94.Caption = "3-D Pyramid"
        SpreadsheetCommandGalleryItem94.CommandName = "InsertChartPyramid"
        SpreadsheetCommandGalleryItem94.Description = "Compare values across categories and across series and display a pyramid chart on" &
    " three axes."
        SpreadsheetCommandGalleryItem94.Hint = "Compare values across categories and across series and display a pyramid chart on" &
    " three axes."
        SpreadsheetCommandGalleryItemGroup17.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem91, SpreadsheetCommandGalleryItem92, SpreadsheetCommandGalleryItem93, SpreadsheetCommandGalleryItem94})
        Me.CommandBarGalleryDropDown13.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup13, SpreadsheetCommandGalleryItemGroup14, SpreadsheetCommandGalleryItemGroup15, SpreadsheetCommandGalleryItemGroup16, SpreadsheetCommandGalleryItemGroup17})
        Me.CommandBarGalleryDropDown13.Gallery.RowCount = 5
        Me.CommandBarGalleryDropDown13.Name = "CommandBarGalleryDropDown13"
        Me.CommandBarGalleryDropDown13.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown14
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown14.Gallery.ColumnCount = 3
        SpreadsheetCommandGalleryItemGroup18.Caption = "2-D Line"
        SpreadsheetCommandGalleryItemGroup18.CommandName = "InsertChartLine2DCommandGroup"
        SpreadsheetCommandGalleryItem95.Caption = "Line"
        SpreadsheetCommandGalleryItem95.CommandName = "InsertChartLine"
        SpreadsheetCommandGalleryItem95.Description = "Display trend over time (dates, years) or ordered categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Useful when ther" &
    "e are many data points and the order is important."
        SpreadsheetCommandGalleryItem95.Hint = "Display trend over time (dates, years) or ordered categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Useful when ther" &
    "e are many data points and the order is important."
        SpreadsheetCommandGalleryItem96.Caption = "Stacked Line"
        SpreadsheetCommandGalleryItem96.CommandName = "InsertChartStackedLine"
        SpreadsheetCommandGalleryItem96.Description = "Display the trend of the contribution of each value over time or ordered categori" &
    "es." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using a stacked area chart instead."
        SpreadsheetCommandGalleryItem96.Hint = "Display the trend of the contribution of each value over time or ordered categori" &
    "es." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using a stacked area chart instead."
        SpreadsheetCommandGalleryItem97.Caption = "100% Stacked line"
        SpreadsheetCommandGalleryItem97.CommandName = "InsertChartPercentStackedLine"
        SpreadsheetCommandGalleryItem97.Description = "Display the trend of the percentage each value contributes over time or ordered c" &
    "ategories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using 100% stacked area chart instead."
        SpreadsheetCommandGalleryItem97.Hint = "Display the trend of the percentage each value contributes over time or ordered c" &
    "ategories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using 100% stacked area chart instead."
        SpreadsheetCommandGalleryItem98.Caption = "Line with Markers"
        SpreadsheetCommandGalleryItem98.CommandName = "InsertChartLineWithMarkers"
        SpreadsheetCommandGalleryItem98.Description = "Display trend over time (dates, years) or ordered categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Useful when ther" &
    "e are only a few data points."
        SpreadsheetCommandGalleryItem98.Hint = "Display trend over time (dates, years) or ordered categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Useful when ther" &
    "e are only a few data points."
        SpreadsheetCommandGalleryItem99.Caption = "Stacked Line with Markers"
        SpreadsheetCommandGalleryItem99.CommandName = "InsertChartStackedLineWithMarkers"
        SpreadsheetCommandGalleryItem99.Description = "Display the trend of the contribution of each value over time or ordered categori" &
    "es." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using a stacked area chart instead."
        SpreadsheetCommandGalleryItem99.Hint = "Display the trend of the contribution of each value over time or ordered categori" &
    "es." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using a stacked area chart instead."
        SpreadsheetCommandGalleryItem100.Caption = "100% Stacked Line with Markers"
        SpreadsheetCommandGalleryItem100.CommandName = "InsertChartPercentStackedLineWithMarkers"
        SpreadsheetCommandGalleryItem100.Description = "Display the trend of the percentage each value contributes over time or ordered c" &
    "ategories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using 100% stacked area chart instead."
        SpreadsheetCommandGalleryItem100.Hint = "Display the trend of the percentage each value contributes over time or ordered c" &
    "ategories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using 100% stacked area chart instead."
        SpreadsheetCommandGalleryItemGroup18.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem95, SpreadsheetCommandGalleryItem96, SpreadsheetCommandGalleryItem97, SpreadsheetCommandGalleryItem98, SpreadsheetCommandGalleryItem99, SpreadsheetCommandGalleryItem100})
        SpreadsheetCommandGalleryItemGroup19.Caption = "3-D Line"
        SpreadsheetCommandGalleryItemGroup19.CommandName = "InsertChartLine3DCommandGroup"
        SpreadsheetCommandGalleryItem101.Caption = "3-D Line"
        SpreadsheetCommandGalleryItem101.CommandName = "InsertChartLine3D"
        SpreadsheetCommandGalleryItem101.Description = "Display each row or column of data as a 3-D ribbon on three axes."
        SpreadsheetCommandGalleryItem101.Hint = "Display each row or column of data as a 3-D ribbon on three axes."
        SpreadsheetCommandGalleryItemGroup19.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem101})
        Me.CommandBarGalleryDropDown14.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup18, SpreadsheetCommandGalleryItemGroup19})
        Me.CommandBarGalleryDropDown14.Name = "CommandBarGalleryDropDown14"
        Me.CommandBarGalleryDropDown14.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown15
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown15.Gallery.ColumnCount = 2
        SpreadsheetCommandGalleryItemGroup20.Caption = "2-D Pie"
        SpreadsheetCommandGalleryItemGroup20.CommandName = "InsertChartPie2DCommandGroup"
        SpreadsheetCommandGalleryItem102.Caption = "Pie"
        SpreadsheetCommandGalleryItem102.CommandName = "InsertChartPie2D"
        SpreadsheetCommandGalleryItem102.Description = "Display the contribution of each value to a total." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the values can " &
    "be added together or when you have only one data series and all values are posit" &
    "ive."
        SpreadsheetCommandGalleryItem102.Hint = "Display the contribution of each value to a total." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the values can " &
    "be added together or when you have only one data series and all values are posit" &
    "ive."
        SpreadsheetCommandGalleryItem103.Caption = "Exploded Pie"
        SpreadsheetCommandGalleryItem103.CommandName = "InsertChartPieExploded2D"
        SpreadsheetCommandGalleryItem103.Description = "Display the contribution of each value to a total while emphasizing individual va" &
    "lues." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using a pie chart, and explode individual values instead."
        SpreadsheetCommandGalleryItem103.Hint = "Display the contribution of each value to a total while emphasizing individual va" &
    "lues." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using a pie chart, and explode individual values instead."
        SpreadsheetCommandGalleryItemGroup20.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem102, SpreadsheetCommandGalleryItem103})
        SpreadsheetCommandGalleryItemGroup21.Caption = "3-D Pie"
        SpreadsheetCommandGalleryItemGroup21.CommandName = "InsertChartPie3DCommandGroup"
        SpreadsheetCommandGalleryItem104.Caption = "Pie in 3-D"
        SpreadsheetCommandGalleryItem104.CommandName = "InsertChartPie3D"
        SpreadsheetCommandGalleryItem104.Description = "Display the contribution of each value to a total."
        SpreadsheetCommandGalleryItem104.Hint = "Display the contribution of each value to a total."
        SpreadsheetCommandGalleryItem105.Caption = "Exploded pie in 3-D"
        SpreadsheetCommandGalleryItem105.CommandName = "InsertChartPieExploded3D"
        SpreadsheetCommandGalleryItem105.Description = "Display the contribution of each value to a total while emphasizing individual va" &
    "lues." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using a 3-D pie chart, and explode individual values instead."
        SpreadsheetCommandGalleryItem105.Hint = "Display the contribution of each value to a total while emphasizing individual va" &
    "lues." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consider using a 3-D pie chart, and explode individual values instead."
        SpreadsheetCommandGalleryItemGroup21.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem104, SpreadsheetCommandGalleryItem105})
        SpreadsheetCommandGalleryItemGroup22.Caption = "Doughnut"
        SpreadsheetCommandGalleryItemGroup22.CommandName = "InsertChartDoughnut2DCommandGroup"
        SpreadsheetCommandGalleryItem106.Caption = "Doughnut"
        SpreadsheetCommandGalleryItem106.CommandName = "InsertChartDoughnut2D"
        SpreadsheetCommandGalleryItem106.Description = "Display the contribution of each value to a total like a pie chart, but it can co" &
    "ntain multiple series."
        SpreadsheetCommandGalleryItem106.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" &
    "ntain multiple series."
        SpreadsheetCommandGalleryItem107.Caption = "Exploded Doughnut"
        SpreadsheetCommandGalleryItem107.CommandName = "InsertChartDoughnutExploded2D"
        SpreadsheetCommandGalleryItem107.Description = "Display the contribution of each value to a total while emphasizing individual va" &
    "lues like an exploded pie chart, but it can contain multiple series."
        SpreadsheetCommandGalleryItem107.Hint = "Display the contribution of each value to a total while emphasizing individual va" &
    "lues like an exploded pie chart, but it can contain multiple series."
        SpreadsheetCommandGalleryItemGroup22.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem106, SpreadsheetCommandGalleryItem107})
        Me.CommandBarGalleryDropDown15.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup20, SpreadsheetCommandGalleryItemGroup21, SpreadsheetCommandGalleryItemGroup22})
        Me.CommandBarGalleryDropDown15.Name = "CommandBarGalleryDropDown15"
        Me.CommandBarGalleryDropDown15.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown16
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown16.Gallery.ColumnCount = 3
        SpreadsheetCommandGalleryItemGroup23.Caption = "2-D Bar"
        SpreadsheetCommandGalleryItemGroup23.CommandName = "InsertChartBar2DCommandGroup"
        SpreadsheetCommandGalleryItem108.Caption = "Clustered Bar"
        SpreadsheetCommandGalleryItem108.CommandName = "InsertChartBarClustered2D"
        SpreadsheetCommandGalleryItem108.Description = "Compare values across categories using horizontal rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the " &
    "values on the chart represent durations or when the category text is very long."
        SpreadsheetCommandGalleryItem108.Hint = "Compare values across categories using horizontal rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the " &
    "values on the chart represent durations or when the category text is very long."
        SpreadsheetCommandGalleryItem109.Caption = "Stacked Bar"
        SpreadsheetCommandGalleryItem109.CommandName = "InsertChartBarStacked2D"
        SpreadsheetCommandGalleryItem109.Description = "Compare the contribution of each value to a total across categories by using hori" &
    "zontal rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the values on the chart represent durations or" &
    " when the category text is very long."
        SpreadsheetCommandGalleryItem109.Hint = "Compare the contribution of each value to a total across categories by using hori" &
    "zontal rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the values on the chart represent durations or" &
    " when the category text is very long."
        SpreadsheetCommandGalleryItem110.Caption = "100% Stacked Bar"
        SpreadsheetCommandGalleryItem110.CommandName = "InsertChartBarPercentStacked2D"
        SpreadsheetCommandGalleryItemGroup23.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem108, SpreadsheetCommandGalleryItem109, SpreadsheetCommandGalleryItem110})
        SpreadsheetCommandGalleryItemGroup24.Caption = "3-D Bar"
        SpreadsheetCommandGalleryItemGroup24.CommandName = "InsertChartBar3DCommandGroup"
        SpreadsheetCommandGalleryItem111.Caption = "Clustered Bar in 3-D"
        SpreadsheetCommandGalleryItem111.CommandName = "InsertChartBarClustered3D"
        SpreadsheetCommandGalleryItem111.Description = "Compare values across categories and display clustered bars in 3-D format."
        SpreadsheetCommandGalleryItem111.Hint = "Compare values across categories and display clustered bars in 3-D format."
        SpreadsheetCommandGalleryItem112.Caption = "Stacked Bar in 3-D"
        SpreadsheetCommandGalleryItem112.CommandName = "InsertChartBarStacked3D"
        SpreadsheetCommandGalleryItem112.Description = "Compare the contribution of each value to a total across categories and display s" &
    "tacked bars in 3-D format."
        SpreadsheetCommandGalleryItem112.Hint = "Compare the contribution of each value to a total across categories and display s" &
    "tacked bars in 3-D format."
        SpreadsheetCommandGalleryItem113.Caption = "100% Stacked Bar in 3-D"
        SpreadsheetCommandGalleryItem113.CommandName = "InsertChartBarPercentStacked3D"
        SpreadsheetCommandGalleryItem113.Description = "Compare the percentange each value contributes to a total across categories and d" &
    "isplay 100% stacked bars in 3-D format."
        SpreadsheetCommandGalleryItem113.Hint = "Compare the percentange each value contributes to a total across categories and d" &
    "isplay 100% stacked bars in 3-D format."
        SpreadsheetCommandGalleryItemGroup24.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem111, SpreadsheetCommandGalleryItem112, SpreadsheetCommandGalleryItem113})
        SpreadsheetCommandGalleryItemGroup25.Caption = "Cylinder"
        SpreadsheetCommandGalleryItemGroup25.CommandName = "InsertChartHorizontalCylinderCommandGroup"
        SpreadsheetCommandGalleryItem114.Caption = "Clustered Horizontal Cylinder"
        SpreadsheetCommandGalleryItem114.CommandName = "InsertChartHorizontalCylinderClustered"
        SpreadsheetCommandGalleryItem114.Description = "Compare values across categories."
        SpreadsheetCommandGalleryItem114.Hint = "Compare values across categories."
        SpreadsheetCommandGalleryItem115.Caption = "Stacked Horizontal Cylinder"
        SpreadsheetCommandGalleryItem115.CommandName = "InsertChartHorizontalCylinderStacked"
        SpreadsheetCommandGalleryItem115.Description = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem115.Hint = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem116.Caption = "100% Stacked Horizontal Cylinder"
        SpreadsheetCommandGalleryItem116.CommandName = "InsertChartHorizontalCylinderPercentStacked"
        SpreadsheetCommandGalleryItem116.Description = "Compare the percentange each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem116.Hint = "Compare the percentange each value contributes to a total across categories."
        SpreadsheetCommandGalleryItemGroup25.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem114, SpreadsheetCommandGalleryItem115, SpreadsheetCommandGalleryItem116})
        SpreadsheetCommandGalleryItemGroup26.Caption = "Cone"
        SpreadsheetCommandGalleryItemGroup26.CommandName = "InsertChartHorizontalConeCommandGroup"
        SpreadsheetCommandGalleryItem117.Caption = "Clustered Horizontal Cone"
        SpreadsheetCommandGalleryItem117.CommandName = "InsertChartHorizontalConeClustered"
        SpreadsheetCommandGalleryItem117.Description = "Compare values across categories."
        SpreadsheetCommandGalleryItem117.Hint = "Compare values across categories."
        SpreadsheetCommandGalleryItem118.Caption = "Stacked Horizontal Cone"
        SpreadsheetCommandGalleryItem118.CommandName = "InsertChartHorizontalConeStacked"
        SpreadsheetCommandGalleryItem118.Description = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem118.Hint = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem119.Caption = "100% Stacked Horizontal Cone"
        SpreadsheetCommandGalleryItem119.CommandName = "InsertChartHorizontalConePercentStacked"
        SpreadsheetCommandGalleryItem119.Description = "Compare the percentange each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem119.Hint = "Compare the percentange each value contributes to a total across categories."
        SpreadsheetCommandGalleryItemGroup26.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem117, SpreadsheetCommandGalleryItem118, SpreadsheetCommandGalleryItem119})
        SpreadsheetCommandGalleryItemGroup27.Caption = "Pyramid"
        SpreadsheetCommandGalleryItemGroup27.CommandName = "InsertChartHorizontalPyramidCommandGroup"
        SpreadsheetCommandGalleryItem120.Caption = "Clustered Horizontal Pyramid"
        SpreadsheetCommandGalleryItem120.CommandName = "InsertChartHorizontalPyramidClustered"
        SpreadsheetCommandGalleryItem120.Description = "Compare values across categories."
        SpreadsheetCommandGalleryItem120.Hint = "Compare values across categories."
        SpreadsheetCommandGalleryItem121.Caption = "Stacked Horizontal Pyramid"
        SpreadsheetCommandGalleryItem121.CommandName = "InsertChartHorizontalPyramidStacked"
        SpreadsheetCommandGalleryItem121.Description = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem121.Hint = "Compare the contribution of each value to a total across categories."
        SpreadsheetCommandGalleryItem122.Caption = "100% Stacked Horizontal Pyramid"
        SpreadsheetCommandGalleryItem122.CommandName = "InsertChartHorizontalPyramidPercentStacked"
        SpreadsheetCommandGalleryItem122.Description = "Compare the percentange each value contributes to a total across categories."
        SpreadsheetCommandGalleryItem122.Hint = "Compare the percentange each value contributes to a total across categories."
        SpreadsheetCommandGalleryItemGroup27.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem120, SpreadsheetCommandGalleryItem121, SpreadsheetCommandGalleryItem122})
        Me.CommandBarGalleryDropDown16.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup23, SpreadsheetCommandGalleryItemGroup24, SpreadsheetCommandGalleryItemGroup25, SpreadsheetCommandGalleryItemGroup26, SpreadsheetCommandGalleryItemGroup27})
        Me.CommandBarGalleryDropDown16.Gallery.RowCount = 5
        Me.CommandBarGalleryDropDown16.Name = "CommandBarGalleryDropDown16"
        Me.CommandBarGalleryDropDown16.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown17
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown17.Gallery.ColumnCount = 3
        SpreadsheetCommandGalleryItemGroup28.Caption = "2-D Area"
        SpreadsheetCommandGalleryItemGroup28.CommandName = "InsertChartArea2DCommandGroup"
        SpreadsheetCommandGalleryItem123.Caption = "Area"
        SpreadsheetCommandGalleryItem123.CommandName = "InsertChartArea"
        SpreadsheetCommandGalleryItem123.Description = "Display the trend of values over time or categories."
        SpreadsheetCommandGalleryItem123.Hint = "Display the trend of values over time or categories."
        SpreadsheetCommandGalleryItem124.Caption = "Stacked Area"
        SpreadsheetCommandGalleryItem124.CommandName = "InsertChartStackedArea"
        SpreadsheetCommandGalleryItem124.Description = "Display the trend of the contribution of each value over time or categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "U" &
    "se it to emphasize the trend in the total across series for one category."
        SpreadsheetCommandGalleryItem124.Hint = "Display the trend of the contribution of each value over time or categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "U" &
    "se it to emphasize the trend in the total across series for one category."
        SpreadsheetCommandGalleryItem125.Caption = "100% Stacked Area"
        SpreadsheetCommandGalleryItem125.CommandName = "InsertChartPercentStackedArea"
        SpreadsheetCommandGalleryItem125.Description = "Display the trend of the percentage each value contibutes over time or categories" &
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the trend in the proportion of each series."
        SpreadsheetCommandGalleryItem125.Hint = "Display the trend of the percentage each value contibutes over time or categories" &
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the trend in the proportion of each series."
        SpreadsheetCommandGalleryItemGroup28.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem123, SpreadsheetCommandGalleryItem124, SpreadsheetCommandGalleryItem125})
        SpreadsheetCommandGalleryItemGroup29.Caption = "3-D Area"
        SpreadsheetCommandGalleryItemGroup29.CommandName = "InsertChartArea3DCommandGroup"
        SpreadsheetCommandGalleryItem126.Caption = "3-D Area"
        SpreadsheetCommandGalleryItem126.CommandName = "InsertChartArea3D"
        SpreadsheetCommandGalleryItem126.Description = "Display the trend of values over time or categories using areas on three axes."
        SpreadsheetCommandGalleryItem126.Hint = "Display the trend of values over time or categories using areas on three axes."
        SpreadsheetCommandGalleryItem127.Caption = "Stacked Area in 3-D"
        SpreadsheetCommandGalleryItem127.CommandName = "InsertChartStackedArea3D"
        SpreadsheetCommandGalleryItem127.Description = "Display the trend of the contribution of each value over time or categories by us" &
    "ing stacked areas in a 3-D format."
        SpreadsheetCommandGalleryItem127.Hint = "Display the trend of the contribution of each value over time or categories by us" &
    "ing stacked areas in a 3-D format."
        SpreadsheetCommandGalleryItem128.Caption = "100% Stacked Area in 3-D"
        SpreadsheetCommandGalleryItem128.CommandName = "InsertChartPercentStackedArea3D"
        SpreadsheetCommandGalleryItem128.Description = "Display the trend of the percentage each value contributes over time or categorie" &
    "s by using 100% stacked areas in 3-D format."
        SpreadsheetCommandGalleryItem128.Hint = "Display the trend of the percentage each value contributes over time or categorie" &
    "s by using 100% stacked areas in 3-D format."
        SpreadsheetCommandGalleryItemGroup29.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem126, SpreadsheetCommandGalleryItem127, SpreadsheetCommandGalleryItem128})
        Me.CommandBarGalleryDropDown17.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup28, SpreadsheetCommandGalleryItemGroup29})
        Me.CommandBarGalleryDropDown17.Gallery.RowCount = 2
        Me.CommandBarGalleryDropDown17.Name = "CommandBarGalleryDropDown17"
        Me.CommandBarGalleryDropDown17.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown18
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown18.Gallery.ColumnCount = 2
        SpreadsheetCommandGalleryItemGroup30.Caption = "Scatter"
        SpreadsheetCommandGalleryItemGroup30.CommandName = "InsertChartScatterCommandGroup"
        SpreadsheetCommandGalleryItem129.Caption = "Scatter with only Markers"
        SpreadsheetCommandGalleryItem129.CommandName = "InsertChartScatterMarkers"
        SpreadsheetCommandGalleryItem129.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when the values are not in X-axis order or whe" &
    "n they represent separate measurements."
        SpreadsheetCommandGalleryItem129.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when the values are not in X-axis order or whe" &
    "n they represent separate measurements."
        SpreadsheetCommandGalleryItem130.Caption = "Scatter with Smooth Lines and Markers"
        SpreadsheetCommandGalleryItem130.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
        SpreadsheetCommandGalleryItem130.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when there are a few data points in X-axis ord" &
    "er and the data represents a function."
        SpreadsheetCommandGalleryItem130.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when there are a few data points in X-axis ord" &
    "er and the data represents a function."
        SpreadsheetCommandGalleryItem131.Caption = "Scatter with Smooth Lines"
        SpreadsheetCommandGalleryItem131.CommandName = "InsertChartScatterSmoothLines"
        SpreadsheetCommandGalleryItem131.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when there are many data points in X-axis orde" &
    "r and the data represents a function."
        SpreadsheetCommandGalleryItem131.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when there are many data points in X-axis orde" &
    "r and the data represents a function."
        SpreadsheetCommandGalleryItem132.Caption = "Scatter with Straight Lines and Markers"
        SpreadsheetCommandGalleryItem132.CommandName = "InsertChartScatterLinesAndMarkers"
        SpreadsheetCommandGalleryItem132.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when there are a few data points in X-axis ord" &
    "er and the data represents separate samples."
        SpreadsheetCommandGalleryItem132.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when there are a few data points in X-axis ord" &
    "er and the data represents separate samples."
        SpreadsheetCommandGalleryItem133.Caption = "Scatter with Straight Lines"
        SpreadsheetCommandGalleryItem133.CommandName = "InsertChartScatterLines"
        SpreadsheetCommandGalleryItem133.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when there are many data points in X-axis orde" &
    "r and the data represents separate samples."
        SpreadsheetCommandGalleryItem133.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use is when there are many data points in X-axis orde" &
    "r and the data represents separate samples."
        SpreadsheetCommandGalleryItemGroup30.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem129, SpreadsheetCommandGalleryItem130, SpreadsheetCommandGalleryItem131, SpreadsheetCommandGalleryItem132, SpreadsheetCommandGalleryItem133})
        SpreadsheetCommandGalleryItemGroup31.Caption = "Bubble"
        SpreadsheetCommandGalleryItemGroup31.CommandName = "InsertChartBubbleCommandGroup"
        SpreadsheetCommandGalleryItem134.Caption = "Bubble"
        SpreadsheetCommandGalleryItem134.CommandName = "InsertChartBubble"
        SpreadsheetCommandGalleryItem134.Description = "Resembles a scatter chart, but compares sets of three values instead of two. The " &
    "third value determines the size of the bubble marker."
        SpreadsheetCommandGalleryItem134.Hint = "Resembles a scatter chart, but compares sets of three values instead of two. The " &
    "third value determines the size of the bubble marker."
        SpreadsheetCommandGalleryItem135.Caption = "Bubble with a 3-D effect"
        SpreadsheetCommandGalleryItem135.CommandName = "InsertChartBubble3D"
        SpreadsheetCommandGalleryItem135.Description = "Resembles a scatter chart, but compares sets of three values instead of two. The " &
    "third value determines the size of the bubble marker, which is displayed with a " &
    "3-D effect."
        SpreadsheetCommandGalleryItem135.Hint = "Resembles a scatter chart, but compares sets of three values instead of two. The " &
    "third value determines the size of the bubble marker, which is displayed with a " &
    "3-D effect."
        SpreadsheetCommandGalleryItemGroup31.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem134, SpreadsheetCommandGalleryItem135})
        Me.CommandBarGalleryDropDown18.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup30, SpreadsheetCommandGalleryItemGroup31})
        Me.CommandBarGalleryDropDown18.Gallery.RowCount = 4
        Me.CommandBarGalleryDropDown18.Name = "CommandBarGalleryDropDown18"
        Me.CommandBarGalleryDropDown18.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown19
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown19.Gallery.ColumnCount = 4
        SpreadsheetCommandGalleryItemGroup32.Caption = "Stock"
        SpreadsheetCommandGalleryItemGroup32.CommandName = "InsertChartStockCommandGroup"
        SpreadsheetCommandGalleryItem136.Caption = "High-Low-Close"
        SpreadsheetCommandGalleryItem136.CommandName = "InsertChartStockHighLowClose"
        SpreadsheetCommandGalleryItem136.Description = "Requires three series of values in order High, Low and Close."
        SpreadsheetCommandGalleryItem136.Hint = "Requires three series of values in order High, Low and Close."
        SpreadsheetCommandGalleryItem137.Caption = "Open-High-Low-Close"
        SpreadsheetCommandGalleryItem137.CommandName = "InsertChartStockOpenHighLowClose"
        SpreadsheetCommandGalleryItem137.Description = "Requires four series of values in order Open, High, Low and Close."
        SpreadsheetCommandGalleryItem137.Hint = "Requires four series of values in order Open, High, Low and Close."
        SpreadsheetCommandGalleryItem138.Caption = "Volume-High-Low-Close"
        SpreadsheetCommandGalleryItem138.CommandName = "InsertChartStockVolumeHighLowClose"
        SpreadsheetCommandGalleryItem138.Description = "Requires four series of values in order Volume, High, Low and Close."
        SpreadsheetCommandGalleryItem138.Hint = "Requires four series of values in order Volume, High, Low and Close."
        SpreadsheetCommandGalleryItem139.Caption = "Volume-Open-High-Low-Close"
        SpreadsheetCommandGalleryItem139.CommandName = "InsertChartStockVolumeOpenHighLowClose"
        SpreadsheetCommandGalleryItem139.Description = "Requires five series of values in order Volume, Open, High, Low and Close."
        SpreadsheetCommandGalleryItem139.Hint = "Requires five series of values in order Volume, Open, High, Low and Close."
        SpreadsheetCommandGalleryItemGroup32.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem136, SpreadsheetCommandGalleryItem137, SpreadsheetCommandGalleryItem138, SpreadsheetCommandGalleryItem139})
        SpreadsheetCommandGalleryItemGroup33.Caption = "Radar"
        SpreadsheetCommandGalleryItemGroup33.CommandName = "InsertChartRadarCommandGroup"
        SpreadsheetCommandGalleryItem140.Caption = "Radar"
        SpreadsheetCommandGalleryItem140.CommandName = "InsertChartRadar"
        SpreadsheetCommandGalleryItem140.Description = "Display values relative to a center point." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the categories are not " &
    "directly comparable."
        SpreadsheetCommandGalleryItem140.Hint = "Display values relative to a center point." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the categories are not " &
    "directly comparable."
        SpreadsheetCommandGalleryItem141.Caption = "Radar with Markers"
        SpreadsheetCommandGalleryItem141.CommandName = "InsertChartRadarWithMarkers"
        SpreadsheetCommandGalleryItem141.Description = "Display values relative to a center point." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the categories are not " &
    "directly comparable."
        SpreadsheetCommandGalleryItem141.Hint = "Display values relative to a center point." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the categories are not " &
    "directly comparable."
        SpreadsheetCommandGalleryItem142.Caption = "Filled Radar"
        SpreadsheetCommandGalleryItem142.CommandName = "InsertChartRadarFilled"
        SpreadsheetCommandGalleryItem142.Description = "Display values relative to a center point." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the categories are not " &
    "directly comparable and there is only one series."
        SpreadsheetCommandGalleryItem142.Hint = "Display values relative to a center point." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the categories are not " &
    "directly comparable and there is only one series."
        SpreadsheetCommandGalleryItemGroup33.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem140, SpreadsheetCommandGalleryItem141, SpreadsheetCommandGalleryItem142})
        Me.CommandBarGalleryDropDown19.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup32, SpreadsheetCommandGalleryItemGroup33})
        Me.CommandBarGalleryDropDown19.Gallery.RowCount = 2
        Me.CommandBarGalleryDropDown19.Name = "CommandBarGalleryDropDown19"
        Me.CommandBarGalleryDropDown19.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown20
        '
        Me.CommandBarGalleryDropDown20.Name = "CommandBarGalleryDropDown20"
        Me.CommandBarGalleryDropDown20.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown21
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown21.Gallery.ColumnCount = 3
        SpreadsheetCommandGalleryItemGroup34.Caption = "Gradient Fill"
        SpreadsheetCommandGalleryItemGroup34.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
        SpreadsheetCommandGalleryItem143.Caption = "Blue Data Bar (Gradient)"
        SpreadsheetCommandGalleryItem143.CommandName = "ConditionalFormattingDataBarGradientBlue"
        SpreadsheetCommandGalleryItem143.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem143.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem144.Caption = "Green Data Bar (Gradient)"
        SpreadsheetCommandGalleryItem144.CommandName = "ConditionalFormattingDataBarGradientGreen"
        SpreadsheetCommandGalleryItem144.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem144.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem145.Caption = "Red Data Bar (Gradient)"
        SpreadsheetCommandGalleryItem145.CommandName = "ConditionalFormattingDataBarGradientRed"
        SpreadsheetCommandGalleryItem145.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem145.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem146.Caption = "Orange Data Bar (Gradient)"
        SpreadsheetCommandGalleryItem146.CommandName = "ConditionalFormattingDataBarGradientOrange"
        SpreadsheetCommandGalleryItem146.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem146.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem147.Caption = "Light Blue Data Bar (Gradient)"
        SpreadsheetCommandGalleryItem147.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
        SpreadsheetCommandGalleryItem147.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem147.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem148.Caption = "Purple Data Bar (Gradient)"
        SpreadsheetCommandGalleryItem148.CommandName = "ConditionalFormattingDataBarGradientPurple"
        SpreadsheetCommandGalleryItem148.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem148.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItemGroup34.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem143, SpreadsheetCommandGalleryItem144, SpreadsheetCommandGalleryItem145, SpreadsheetCommandGalleryItem146, SpreadsheetCommandGalleryItem147, SpreadsheetCommandGalleryItem148})
        SpreadsheetCommandGalleryItemGroup35.Caption = "Solid Fill"
        SpreadsheetCommandGalleryItemGroup35.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
        SpreadsheetCommandGalleryItem149.Caption = "Blue Data Bar (Solid)"
        SpreadsheetCommandGalleryItem149.CommandName = "ConditionalFormattingDataBarSolidBlue"
        SpreadsheetCommandGalleryItem149.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem149.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem150.Caption = "Green Data Bar (Solid)"
        SpreadsheetCommandGalleryItem150.CommandName = "ConditionalFormattingDataBarSolidGreen"
        SpreadsheetCommandGalleryItem150.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem150.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem151.Caption = "Red Data Bar (Solid)"
        SpreadsheetCommandGalleryItem151.CommandName = "ConditionalFormattingDataBarSolidRed"
        SpreadsheetCommandGalleryItem151.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem151.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem152.Caption = "Orange Data Bar (Solid)"
        SpreadsheetCommandGalleryItem152.CommandName = "ConditionalFormattingDataBarSolidOrange"
        SpreadsheetCommandGalleryItem152.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem152.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem153.Caption = "Light Blue Data Bar (Solid)"
        SpreadsheetCommandGalleryItem153.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
        SpreadsheetCommandGalleryItem153.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem153.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem154.Caption = "Purple Data Bar (Solid)"
        SpreadsheetCommandGalleryItem154.CommandName = "ConditionalFormattingDataBarSolidPurple"
        SpreadsheetCommandGalleryItem154.Description = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItem154.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" &
    "lue in the cell. A longer bar represents a higher value."
        SpreadsheetCommandGalleryItemGroup35.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem149, SpreadsheetCommandGalleryItem150, SpreadsheetCommandGalleryItem151, SpreadsheetCommandGalleryItem152, SpreadsheetCommandGalleryItem153, SpreadsheetCommandGalleryItem154})
        Me.CommandBarGalleryDropDown21.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup34, SpreadsheetCommandGalleryItemGroup35})
        Me.CommandBarGalleryDropDown21.Gallery.RowCount = 4
        Me.CommandBarGalleryDropDown21.Name = "CommandBarGalleryDropDown21"
        Me.CommandBarGalleryDropDown21.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown22
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown22.Gallery.ColumnCount = 4
        SpreadsheetCommandGalleryItemGroup36.Caption = "Color Scales"
        SpreadsheetCommandGalleryItemGroup36.CommandName = "ConditionalFormattingColorScalesCommandGroup"
        SpreadsheetCommandGalleryItem155.Caption = "Green - Yellow - Red Color Scale"
        SpreadsheetCommandGalleryItem155.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
        SpreadsheetCommandGalleryItem155.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem155.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem156.Caption = "Red - Yellow - Green Color Scale"
        SpreadsheetCommandGalleryItem156.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
        SpreadsheetCommandGalleryItem156.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem156.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem157.Caption = "Green - White - Red Color Scale"
        SpreadsheetCommandGalleryItem157.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
        SpreadsheetCommandGalleryItem157.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem157.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem158.Caption = "Red - White - Green Color Scale"
        SpreadsheetCommandGalleryItem158.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
        SpreadsheetCommandGalleryItem158.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem158.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem159.Caption = "Blue - White - Red Color Scale"
        SpreadsheetCommandGalleryItem159.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
        SpreadsheetCommandGalleryItem159.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem159.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem160.Caption = "Red - White - Blue Color Scale"
        SpreadsheetCommandGalleryItem160.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
        SpreadsheetCommandGalleryItem160.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem160.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem161.Caption = "White - Red Color Scale"
        SpreadsheetCommandGalleryItem161.CommandName = "ConditionalFormattingColorScaleWhiteRed"
        SpreadsheetCommandGalleryItem161.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem161.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem162.Caption = "Red - White Color Scale"
        SpreadsheetCommandGalleryItem162.CommandName = "ConditionalFormattingColorScaleRedWhite"
        SpreadsheetCommandGalleryItem162.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem162.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem163.Caption = "Green - White Color Scale"
        SpreadsheetCommandGalleryItem163.CommandName = "ConditionalFormattingColorScaleGreenWhite"
        SpreadsheetCommandGalleryItem163.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem163.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem164.Caption = "White - Green Color Scale"
        SpreadsheetCommandGalleryItem164.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
        SpreadsheetCommandGalleryItem164.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem164.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem165.Caption = "Green - Yellow Color Scale"
        SpreadsheetCommandGalleryItem165.CommandName = "ConditionalFormattingColorScaleGreenYellow"
        SpreadsheetCommandGalleryItem165.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem165.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem166.Caption = "Yellow - Green Color Scale"
        SpreadsheetCommandGalleryItem166.CommandName = "ConditionalFormattingColorScaleYellowGreen"
        SpreadsheetCommandGalleryItem166.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItem166.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" &
    "r represents the value in the cell."
        SpreadsheetCommandGalleryItemGroup36.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem155, SpreadsheetCommandGalleryItem156, SpreadsheetCommandGalleryItem157, SpreadsheetCommandGalleryItem158, SpreadsheetCommandGalleryItem159, SpreadsheetCommandGalleryItem160, SpreadsheetCommandGalleryItem161, SpreadsheetCommandGalleryItem162, SpreadsheetCommandGalleryItem163, SpreadsheetCommandGalleryItem164, SpreadsheetCommandGalleryItem165, SpreadsheetCommandGalleryItem166})
        Me.CommandBarGalleryDropDown22.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup36})
        Me.CommandBarGalleryDropDown22.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown22.Name = "CommandBarGalleryDropDown22"
        Me.CommandBarGalleryDropDown22.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown23
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown23.Gallery.ColumnCount = 4
        SpreadsheetCommandGalleryItemGroup37.Caption = "Directional"
        SpreadsheetCommandGalleryItemGroup37.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
        SpreadsheetCommandGalleryItem167.Caption = "3 Arrows (Colored)"
        SpreadsheetCommandGalleryItem167.CommandName = "ConditionalFormattingIconSetArrows3Colored"
        SpreadsheetCommandGalleryItem167.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem167.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem168.Caption = "3 Arrows (Gray)"
        SpreadsheetCommandGalleryItem168.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
        SpreadsheetCommandGalleryItem168.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem168.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem169.Caption = "4 Arrows (Colored)"
        SpreadsheetCommandGalleryItem169.CommandName = "ConditionalFormattingIconSetArrows4Colored"
        SpreadsheetCommandGalleryItem169.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem169.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem170.Caption = "4 Arrows (Gray)"
        SpreadsheetCommandGalleryItem170.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
        SpreadsheetCommandGalleryItem170.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem170.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem171.Caption = "5 Arrows (Colored)"
        SpreadsheetCommandGalleryItem171.CommandName = "ConditionalFormattingIconSetArrows5Colored"
        SpreadsheetCommandGalleryItem171.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem171.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem172.Caption = "5 Arrows (Gray)"
        SpreadsheetCommandGalleryItem172.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
        SpreadsheetCommandGalleryItem172.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem172.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem173.Caption = "3 Triangles"
        SpreadsheetCommandGalleryItem173.CommandName = "ConditionalFormattingIconSetTriangles3"
        SpreadsheetCommandGalleryItem173.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem173.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItemGroup37.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem167, SpreadsheetCommandGalleryItem168, SpreadsheetCommandGalleryItem169, SpreadsheetCommandGalleryItem170, SpreadsheetCommandGalleryItem171, SpreadsheetCommandGalleryItem172, SpreadsheetCommandGalleryItem173})
        SpreadsheetCommandGalleryItemGroup38.Caption = "Shapes"
        SpreadsheetCommandGalleryItemGroup38.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
        SpreadsheetCommandGalleryItem174.Caption = "3 Traffic Lights ()"
        SpreadsheetCommandGalleryItem174.CommandName = "ConditionalFormattingIconSetTrafficLights3"
        SpreadsheetCommandGalleryItem174.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem174.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem175.Caption = "3 Traffic Lights (Rimmed)"
        SpreadsheetCommandGalleryItem175.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
        SpreadsheetCommandGalleryItem175.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem175.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem176.Caption = "4 Traffic Lights"
        SpreadsheetCommandGalleryItem176.CommandName = "ConditionalFormattingIconSetTrafficLights4"
        SpreadsheetCommandGalleryItem176.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem176.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem177.Caption = "3 Signs"
        SpreadsheetCommandGalleryItem177.CommandName = "ConditionalFormattingIconSetSigns3"
        SpreadsheetCommandGalleryItem177.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem177.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem178.Caption = "Red To Black"
        SpreadsheetCommandGalleryItem178.CommandName = "ConditionalFormattingIconSetRedToBlack"
        SpreadsheetCommandGalleryItem178.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem178.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItemGroup38.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem174, SpreadsheetCommandGalleryItem175, SpreadsheetCommandGalleryItem176, SpreadsheetCommandGalleryItem177, SpreadsheetCommandGalleryItem178})
        SpreadsheetCommandGalleryItemGroup39.Caption = "Indicators"
        SpreadsheetCommandGalleryItemGroup39.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
        SpreadsheetCommandGalleryItem179.Caption = "3 Symbols (Circled)"
        SpreadsheetCommandGalleryItem179.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
        SpreadsheetCommandGalleryItem179.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem179.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem180.Caption = "3 Symbols (Uncircled)"
        SpreadsheetCommandGalleryItem180.CommandName = "ConditionalFormattingIconSetSymbols3"
        SpreadsheetCommandGalleryItem180.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem180.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem181.Caption = "3 Flags"
        SpreadsheetCommandGalleryItem181.CommandName = "ConditionalFormattingIconSetFlags3"
        SpreadsheetCommandGalleryItem181.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem181.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItemGroup39.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem179, SpreadsheetCommandGalleryItem180, SpreadsheetCommandGalleryItem181})
        SpreadsheetCommandGalleryItemGroup40.Caption = "Ratings"
        SpreadsheetCommandGalleryItemGroup40.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
        SpreadsheetCommandGalleryItem182.Caption = "3 Stars"
        SpreadsheetCommandGalleryItem182.CommandName = "ConditionalFormattingIconSetStars3"
        SpreadsheetCommandGalleryItem182.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem182.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem183.Caption = "4 Ratings"
        SpreadsheetCommandGalleryItem183.CommandName = "ConditionalFormattingIconSetRatings4"
        SpreadsheetCommandGalleryItem183.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem183.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem184.Caption = "5 Ratings"
        SpreadsheetCommandGalleryItem184.CommandName = "ConditionalFormattingIconSetRatings5"
        SpreadsheetCommandGalleryItem184.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem184.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem185.Caption = "5 Quarters"
        SpreadsheetCommandGalleryItem185.CommandName = "ConditionalFormattingIconSetQuarters5"
        SpreadsheetCommandGalleryItem185.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem185.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem186.Caption = "5 Boxes"
        SpreadsheetCommandGalleryItem186.CommandName = "ConditionalFormattingIconSetBoxes5"
        SpreadsheetCommandGalleryItem186.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItem186.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" &
    "e in the cell."
        SpreadsheetCommandGalleryItemGroup40.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem182, SpreadsheetCommandGalleryItem183, SpreadsheetCommandGalleryItem184, SpreadsheetCommandGalleryItem185, SpreadsheetCommandGalleryItem186})
        Me.CommandBarGalleryDropDown23.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {SpreadsheetCommandGalleryItemGroup37, SpreadsheetCommandGalleryItemGroup38, SpreadsheetCommandGalleryItemGroup39, SpreadsheetCommandGalleryItemGroup40})
        Me.CommandBarGalleryDropDown23.Gallery.RowCount = 7
        Me.CommandBarGalleryDropDown23.Name = "CommandBarGalleryDropDown23"
        Me.CommandBarGalleryDropDown23.Ribbon = Me.ribbonControl
        '
        'CommandBarGalleryDropDown24
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown24.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown24.Gallery.ColumnCount = 7
        Me.CommandBarGalleryDropDown24.Gallery.DrawImageBackground = False
        Me.CommandBarGalleryDropDown24.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
        Me.CommandBarGalleryDropDown24.Gallery.ItemSize = New System.Drawing.Size(73, 58)
        Me.CommandBarGalleryDropDown24.Gallery.RowCount = 10
        Me.CommandBarGalleryDropDown24.Name = "CommandBarGalleryDropDown24"
        Me.CommandBarGalleryDropDown24.Ribbon = Me.ribbonControl
        '
        'LiveDataSet
        '
        Me.LiveDataSet.DataSetName = "LiveDataSet"
        Me.LiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnalogLiveBindingSource
        '
        Me.AnalogLiveBindingSource.DataMember = "AnalogLive"
        Me.AnalogLiveBindingSource.DataSource = Me.LiveDataSet
        '
        'AnalogLiveTableAdapter
        '
        Me.AnalogLiveTableAdapter.ClearBeforeFill = True
        '
        'DigitalGauge2
        '
        Me.DigitalGauge2.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FD4F2FF")
        Me.DigitalGauge2.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D4F2FF")
        Me.DigitalGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 213, 75)
        Me.DigitalGauge2.DigitCount = 5
        Me.DigitalGauge2.Name = "DigitalGauge2"
        Me.DigitalGauge2.Text = "00,000"
        '
        'DigitalGauge3
        '
        Me.DigitalGauge3.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge3.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent2})
        Me.DigitalGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 202, 84)
        Me.DigitalGauge3.DigitCount = 5
        Me.DigitalGauge3.Name = "DigitalGauge3"
        Me.DigitalGauge3.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge3.Text = "00.000"
        '
        'DigitalBackgroundLayerComponent2
        '
        Me.DigitalBackgroundLayerComponent2.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent2.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent2.ZOrder = 1000
        '
        'DigitalGauge4
        '
        Me.DigitalGauge4.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge4.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent3})
        Me.DigitalGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 202, 84)
        Me.DigitalGauge4.DigitCount = 5
        Me.DigitalGauge4.Name = "DigitalGauge4"
        Me.DigitalGauge4.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge4.Text = "00.000"
        '
        'DigitalBackgroundLayerComponent3
        '
        Me.DigitalBackgroundLayerComponent3.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent3.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent3.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent3.ZOrder = 1000
        '
        'DigitalGauge5
        '
        Me.DigitalGauge5.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge5.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent4})
        Me.DigitalGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 202, 84)
        Me.DigitalGauge5.DigitCount = 5
        Me.DigitalGauge5.Name = "DigitalGauge5"
        Me.DigitalGauge5.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge5.Text = "00.000"
        '
        'DigitalBackgroundLayerComponent4
        '
        Me.DigitalBackgroundLayerComponent4.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent4.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent4.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent4.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent5
        '
        Me.DigitalBackgroundLayerComponent5.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent5.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent5.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent5.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent6
        '
        Me.DigitalBackgroundLayerComponent6.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent6.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent6.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent6.ZOrder = 1000
        '
        'DigitalGauge6
        '
        Me.DigitalGauge6.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge6.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge6.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent7})
        Me.DigitalGauge6.Bounds = New System.Drawing.Rectangle(10, 8, 187, 77)
        Me.DigitalGauge6.DigitCount = 5
        Me.DigitalGauge6.Name = "DigitalGauge6"
        Me.DigitalGauge6.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge6.Text = "00.000"
        '
        'DigitalBackgroundLayerComponent7
        '
        Me.DigitalBackgroundLayerComponent7.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent7.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent7.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent7.ZOrder = 1000
        '
        'DigitalGauge7
        '
        Me.DigitalGauge7.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge7.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge7.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent8})
        Me.DigitalGauge7.Bounds = New System.Drawing.Rectangle(10, 8, 187, 77)
        Me.DigitalGauge7.DigitCount = 5
        Me.DigitalGauge7.Name = "DigitalGauge7"
        Me.DigitalGauge7.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge7.Text = "00.000"
        '
        'DigitalBackgroundLayerComponent8
        '
        Me.DigitalBackgroundLayerComponent8.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent8.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent8.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent8.ZOrder = 1000
        '
        'DigitalGauge8
        '
        Me.DigitalGauge8.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge8.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge8.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent9})
        Me.DigitalGauge8.Bounds = New System.Drawing.Rectangle(2, 4, 187, 77)
        Me.DigitalGauge8.DigitCount = 5
        Me.DigitalGauge8.Name = "DigitalGauge8"
        Me.DigitalGauge8.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge8.Text = "00.000"
        '
        'DigitalBackgroundLayerComponent9
        '
        Me.DigitalBackgroundLayerComponent9.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent9.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent9.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent9.ZOrder = 1000
        '
        'DigitalGauge9
        '
        Me.DigitalGauge9.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge9.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge9.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent10})
        Me.DigitalGauge9.Bounds = New System.Drawing.Rectangle(2, 4, 187, 77)
        Me.DigitalGauge9.DigitCount = 5
        Me.DigitalGauge9.Name = "DigitalGauge9"
        Me.DigitalGauge9.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge9.Text = "00.000"
        '
        'DigitalBackgroundLayerComponent10
        '
        Me.DigitalBackgroundLayerComponent10.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent10.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent10.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent10.ZOrder = 1000
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "FM6 Summary"
        Me.TabNavigationPage1.Controls.Add(Me.FM6Chart2)
        Me.TabNavigationPage1.Controls.Add(Me.Label27)
        Me.TabNavigationPage1.Controls.Add(Me.Label22)
        Me.TabNavigationPage1.Controls.Add(Me.Label23)
        Me.TabNavigationPage1.Controls.Add(Me.Label24)
        Me.TabNavigationPage1.Controls.Add(Me.Label25)
        Me.TabNavigationPage1.Controls.Add(Me.Label26)
        Me.TabNavigationPage1.Controls.Add(Me.Label21)
        Me.TabNavigationPage1.Controls.Add(Me.Label20)
        Me.TabNavigationPage1.Controls.Add(Me.Label19)
        Me.TabNavigationPage1.Controls.Add(Me.Label18)
        Me.TabNavigationPage1.Controls.Add(Me.Label17)
        Me.TabNavigationPage1.Controls.Add(Me.Label16)
        Me.TabNavigationPage1.Controls.Add(Me.Label15)
        Me.TabNavigationPage1.Controls.Add(Me.Label14)
        Me.TabNavigationPage1.Controls.Add(Me.Label13)
        Me.TabNavigationPage1.Controls.Add(Me.Label12)
        Me.TabNavigationPage1.Controls.Add(Me.Label11)
        Me.TabNavigationPage1.Controls.Add(Me.PictureBox1)
        Me.TabNavigationPage1.Controls.Add(Me.FM6Chart)
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl14)
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl13)
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl11)
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl9)
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl7)
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl5)
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl3)
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl1)
        Me.TabNavigationPage1.Controls.Add(Me.Label9)
        Me.TabNavigationPage1.Controls.Add(Me.Label8)
        Me.TabNavigationPage1.Controls.Add(Me.Label7)
        Me.TabNavigationPage1.Controls.Add(Me.Label6)
        Me.TabNavigationPage1.Controls.Add(Me.Label5)
        Me.TabNavigationPage1.Controls.Add(Me.Label4)
        Me.TabNavigationPage1.Controls.Add(Me.Label3)
        Me.TabNavigationPage1.Controls.Add(Me.Label2)
        Me.TabNavigationPage1.Controls.Add(Me.Label1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1912, 880)
        '
        'FM6Chart2
        '
        Me.FM6Chart2.AppearanceNameSerializable = "Dark"
        Me.FM6Chart2.CacheToMemory = True
        Me.FM6Chart2.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram2.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram2.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.FM6Chart2.Diagram = SwiftPlotDiagram2
        Me.FM6Chart2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.FM6Chart2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.FM6Chart2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.FM6Chart2.Location = New System.Drawing.Point(564, 379)
        Me.FM6Chart2.Name = "FM6Chart2"
        Me.FM6Chart2.PaletteName = "Default"
        Me.FM6Chart2.RefreshDataOnRepaint = False
        Series2.Name = "Chart1FM6Series"
        Series2.View = SwiftPlotSeriesView3
        Me.FM6Chart2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.FM6Chart2.Size = New System.Drawing.Size(1325, 288)
        Me.FM6Chart2.TabIndex = 47
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Black
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(29, 51)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(545, 31)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "MIdlothian Cement Plant Operation Summary"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Black
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.IndianRed
        Me.Label22.Location = New System.Drawing.Point(945, 803)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(134, 23)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Date and Time"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Black
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.IndianRed
        Me.Label23.Location = New System.Drawing.Point(945, 774)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(134, 23)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Date and Time"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Black
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.IndianRed
        Me.Label24.Location = New System.Drawing.Point(945, 746)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(134, 23)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Date and Time"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Black
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.IndianRed
        Me.Label25.Location = New System.Drawing.Point(945, 717)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(134, 23)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Date and Time"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Black
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(930, 673)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(172, 29)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Sub-Equipment"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Black
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.IndianRed
        Me.Label21.Location = New System.Drawing.Point(1142, 803)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 23)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Date and Time"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Black
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.IndianRed
        Me.Label20.Location = New System.Drawing.Point(725, 803)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 23)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Date and Time"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Black
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.IndianRed
        Me.Label19.Location = New System.Drawing.Point(1142, 774)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(134, 23)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Date and Time"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Black
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.IndianRed
        Me.Label18.Location = New System.Drawing.Point(725, 774)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 23)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Date and Time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.IndianRed
        Me.Label17.Location = New System.Drawing.Point(1142, 746)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 23)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Date and Time"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.IndianRed
        Me.Label16.Location = New System.Drawing.Point(725, 746)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 23)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Date and Time"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.IndianRed
        Me.Label15.Location = New System.Drawing.Point(1142, 717)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 23)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Date and Time"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.IndianRed
        Me.Label14.Location = New System.Drawing.Point(725, 717)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 23)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Date and Time"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1141, 672)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(267, 29)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Reason and Root Cause"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(724, 672)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 29)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Date and Time"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(724, 643)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(312, 29)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Latest Finish Mill # 6 STOPS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox1.Location = New System.Drawing.Point(1720, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FM6Chart
        '
        Me.FM6Chart.AppearanceNameSerializable = "Dark"
        Me.FM6Chart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FM6Chart.CacheToMemory = True
        Me.FM6Chart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram3.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram3.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram3.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram3.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram3.AxisY.Title.Text = "FM 6TPH"
        SwiftPlotDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram3.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram3.AxisY.VisualRange.AutoSideMargins = False
        SwiftPlotDiagram3.AxisY.VisualRange.MaxValueSerializable = "175"
        SwiftPlotDiagram3.AxisY.VisualRange.MinValueSerializable = "145"
        SwiftPlotDiagram3.AxisY.VisualRange.SideMarginsValue = 0R
        SwiftPlotDiagram3.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram3.AxisY.WholeRange.AutoSideMargins = False
        SwiftPlotDiagram3.AxisY.WholeRange.MaxValueSerializable = "175"
        SwiftPlotDiagram3.AxisY.WholeRange.MinValueSerializable = "145"
        SwiftPlotDiagram3.AxisY.WholeRange.SideMarginsValue = 0R
        SwiftPlotDiagram3.DefaultPane.BackColor = System.Drawing.Color.Black
        SwiftPlotDiagramSecondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY1.AxisID = 0
        SwiftPlotDiagramSecondaryAxisY1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        SwiftPlotDiagramSecondaryAxisY1.Name = "Secondary AxisY 1"
        SwiftPlotDiagramSecondaryAxisY1.Title.Text = "Mill KW"
        SwiftPlotDiagramSecondaryAxisY1.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY1.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY1.VisualRange.MaxValueSerializable = "6500"
        SwiftPlotDiagramSecondaryAxisY1.VisualRange.MinValueSerializable = "5000"
        SwiftPlotDiagramSecondaryAxisY1.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY1.WholeRange.MaxValueSerializable = "6500"
        SwiftPlotDiagramSecondaryAxisY1.WholeRange.MinValueSerializable = "5000"
        SwiftPlotDiagramSecondaryAxisY2.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY2.AxisID = 1
        SwiftPlotDiagramSecondaryAxisY2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        SwiftPlotDiagramSecondaryAxisY2.Name = "Secondary AxisY 2"
        SwiftPlotDiagramSecondaryAxisY2.Title.Text = "Grinding Aid"
        SwiftPlotDiagramSecondaryAxisY2.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        SwiftPlotDiagramSecondaryAxisY2.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY2.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY2.VisualRange.MaxValueSerializable = "200"
        SwiftPlotDiagramSecondaryAxisY2.VisualRange.MinValueSerializable = "150"
        SwiftPlotDiagramSecondaryAxisY2.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY2.WholeRange.MaxValueSerializable = "200"
        SwiftPlotDiagramSecondaryAxisY2.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY3.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY3.AxisID = 2
        SwiftPlotDiagramSecondaryAxisY3.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        SwiftPlotDiagramSecondaryAxisY3.Name = "Secondary AxisY 3"
        SwiftPlotDiagramSecondaryAxisY3.Title.Text = "Bucket Elevator KW"
        SwiftPlotDiagramSecondaryAxisY3.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY3.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY3.VisualRange.MaxValueSerializable = "75"
        SwiftPlotDiagramSecondaryAxisY3.VisualRange.MinValueSerializable = "30"
        SwiftPlotDiagramSecondaryAxisY3.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY3.WholeRange.MaxValueSerializable = "80"
        SwiftPlotDiagramSecondaryAxisY3.WholeRange.MinValueSerializable = "30"
        SwiftPlotDiagramSecondaryAxisY4.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY4.AxisID = 3
        SwiftPlotDiagramSecondaryAxisY4.DateTimeScaleOptions.AutoGrid = False
        SwiftPlotDiagramSecondaryAxisY4.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Second
        SwiftPlotDiagramSecondaryAxisY4.DateTimeScaleOptions.GridSpacing = 2.0R
        SwiftPlotDiagramSecondaryAxisY4.Name = "Secondary AxisY 4"
        SwiftPlotDiagramSecondaryAxisY4.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram3.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY() {SwiftPlotDiagramSecondaryAxisY1, SwiftPlotDiagramSecondaryAxisY2, SwiftPlotDiagramSecondaryAxisY3, SwiftPlotDiagramSecondaryAxisY4})
        Me.FM6Chart.Diagram = SwiftPlotDiagram3
        Me.FM6Chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.FM6Chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.FM6Chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.FM6Chart.Location = New System.Drawing.Point(564, 41)
        Me.FM6Chart.Name = "FM6Chart"
        Me.FM6Chart.PaletteBaseColorNumber = 3
        Me.FM6Chart.PaletteName = "Default"
        Me.FM6Chart.RefreshDataOnRepaint = False
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series3.Name = "FM6 TPH"
        SwiftPlotSeriesView4.LineStyle.Thickness = 2
        Series3.View = SwiftPlotSeriesView4
        Series4.Name = "Mill KW"
        SwiftPlotSeriesView5.AxisYName = "Secondary AxisY 1"
        SwiftPlotSeriesView5.LineStyle.Thickness = 2
        Series4.View = SwiftPlotSeriesView5
        Series5.Name = "Slide Shoe Brg 10"
        SwiftPlotSeriesView6.AxisYName = "Secondary AxisY 2"
        SwiftPlotSeriesView6.LineStyle.Thickness = 2
        Series5.View = SwiftPlotSeriesView6
        Series6.Name = "Bucket Elevator KW"
        SwiftPlotSeriesView7.AxisYName = "Secondary AxisY 3"
        SwiftPlotSeriesView7.LineStyle.Thickness = 2
        Series6.View = SwiftPlotSeriesView7
        Series7.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series7.Name = "Separator Speed"
        SwiftPlotSeriesView8.AxisYName = "Secondary AxisY 4"
        SwiftPlotSeriesView8.LineStyle.Thickness = 2
        Series7.View = SwiftPlotSeriesView8
        Me.FM6Chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3, Series4, Series5, Series6, Series7}
        Me.FM6Chart.SeriesTemplate.View = SwiftPlotSeriesView9
        Me.FM6Chart.Size = New System.Drawing.Size(1325, 348)
        Me.FM6Chart.TabIndex = 29
        ChartTitle2.Text = "Finish Mill # 6 Operation"
        Me.FM6Chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'GaugeControl14
        '
        Me.GaugeControl14.BackColor = System.Drawing.Color.Black
        Me.GaugeControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl14.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge22})
        Me.GaugeControl14.Location = New System.Drawing.Point(218, 747)
        Me.GaugeControl14.Name = "GaugeControl14"
        Me.GaugeControl14.Size = New System.Drawing.Size(185, 68)
        Me.GaugeControl14.TabIndex = 22
        '
        'DigitalGauge22
        '
        Me.DigitalGauge22.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E3E4E7")
        Me.DigitalGauge22.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#555B67")
        Me.DigitalGauge22.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent29})
        Me.DigitalGauge22.Bounds = New System.Drawing.Rectangle(6, 6, 173, 56)
        Me.DigitalGauge22.DigitCount = 5
        Me.DigitalGauge22.Name = "DigitalGauge22"
        Me.DigitalGauge22.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent29
        '
        Me.DigitalBackgroundLayerComponent29.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent29.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent29.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style26
        Me.DigitalBackgroundLayerComponent29.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent29.ZOrder = 1000
        '
        'GaugeControl13
        '
        Me.GaugeControl13.BackColor = System.Drawing.Color.Black
        Me.GaugeControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl13.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge21})
        Me.GaugeControl13.Location = New System.Drawing.Point(218, 662)
        Me.GaugeControl13.Name = "GaugeControl13"
        Me.GaugeControl13.Size = New System.Drawing.Size(185, 68)
        Me.GaugeControl13.TabIndex = 21
        '
        'DigitalGauge21
        '
        Me.DigitalGauge21.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F3B030")
        Me.DigitalGauge21.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#343A49")
        Me.DigitalGauge21.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent28})
        Me.DigitalGauge21.Bounds = New System.Drawing.Rectangle(6, 6, 173, 56)
        Me.DigitalGauge21.DigitCount = 5
        Me.DigitalGauge21.Name = "DigitalGauge21"
        Me.DigitalGauge21.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent28
        '
        Me.DigitalBackgroundLayerComponent28.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent28.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent28.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style24
        Me.DigitalBackgroundLayerComponent28.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent28.ZOrder = 1000
        '
        'GaugeControl11
        '
        Me.GaugeControl11.BackColor = System.Drawing.Color.Black
        Me.GaugeControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl11.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge19})
        Me.GaugeControl11.Location = New System.Drawing.Point(218, 572)
        Me.GaugeControl11.Name = "GaugeControl11"
        Me.GaugeControl11.Size = New System.Drawing.Size(185, 68)
        Me.GaugeControl11.TabIndex = 19
        '
        'DigitalGauge19
        '
        Me.DigitalGauge19.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#34000000")
        Me.DigitalGauge19.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.DigitalGauge19.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent26})
        Me.DigitalGauge19.Bounds = New System.Drawing.Rectangle(6, 6, 173, 56)
        Me.DigitalGauge19.DigitCount = 5
        Me.DigitalGauge19.Name = "DigitalGauge19"
        Me.DigitalGauge19.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent26
        '
        Me.DigitalBackgroundLayerComponent26.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent26.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent26.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style4
        Me.DigitalBackgroundLayerComponent26.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent26.ZOrder = 1000
        '
        'GaugeControl9
        '
        Me.GaugeControl9.BackColor = System.Drawing.Color.Black
        Me.GaugeControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl9.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge17})
        Me.GaugeControl9.Location = New System.Drawing.Point(218, 484)
        Me.GaugeControl9.Name = "GaugeControl9"
        Me.GaugeControl9.Size = New System.Drawing.Size(185, 68)
        Me.GaugeControl9.TabIndex = 17
        '
        'DigitalGauge17
        '
        Me.DigitalGauge17.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FC0C0C0")
        Me.DigitalGauge17.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.DigitalGauge17.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent24})
        Me.DigitalGauge17.Bounds = New System.Drawing.Rectangle(6, 6, 173, 56)
        Me.DigitalGauge17.DigitCount = 5
        Me.DigitalGauge17.Name = "DigitalGauge17"
        Me.DigitalGauge17.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent24
        '
        Me.DigitalBackgroundLayerComponent24.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent24.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent24.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style5
        Me.DigitalBackgroundLayerComponent24.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent24.ZOrder = 1000
        '
        'GaugeControl7
        '
        Me.GaugeControl7.BackColor = System.Drawing.Color.Black
        Me.GaugeControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl7.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge15})
        Me.GaugeControl7.Location = New System.Drawing.Point(218, 400)
        Me.GaugeControl7.Name = "GaugeControl7"
        Me.GaugeControl7.Size = New System.Drawing.Size(185, 68)
        Me.GaugeControl7.TabIndex = 15
        '
        'DigitalGauge15
        '
        Me.DigitalGauge15.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E9EFF3")
        Me.DigitalGauge15.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0F89B8")
        Me.DigitalGauge15.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent22})
        Me.DigitalGauge15.Bounds = New System.Drawing.Rectangle(6, 6, 173, 56)
        Me.DigitalGauge15.DigitCount = 5
        Me.DigitalGauge15.Name = "DigitalGauge15"
        Me.DigitalGauge15.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent22
        '
        Me.DigitalBackgroundLayerComponent22.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent22.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent22.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style22
        Me.DigitalBackgroundLayerComponent22.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent22.ZOrder = 1000
        '
        'GaugeControl5
        '
        Me.GaugeControl5.BackColor = System.Drawing.Color.Black
        Me.GaugeControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl5.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge13})
        Me.GaugeControl5.Location = New System.Drawing.Point(218, 309)
        Me.GaugeControl5.Name = "GaugeControl5"
        Me.GaugeControl5.Size = New System.Drawing.Size(185, 68)
        Me.GaugeControl5.TabIndex = 13
        '
        'DigitalGauge13
        '
        Me.DigitalGauge13.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0D8097")
        Me.DigitalGauge13.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#02F0F7")
        Me.DigitalGauge13.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent20})
        Me.DigitalGauge13.Bounds = New System.Drawing.Rectangle(6, 6, 173, 56)
        Me.DigitalGauge13.DigitCount = 5
        Me.DigitalGauge13.Name = "DigitalGauge13"
        Me.DigitalGauge13.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent20
        '
        Me.DigitalBackgroundLayerComponent20.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent20.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent20.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style17
        Me.DigitalBackgroundLayerComponent20.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent20.ZOrder = 1000
        '
        'GaugeControl3
        '
        Me.GaugeControl3.BackColor = System.Drawing.Color.Black
        Me.GaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge11})
        Me.GaugeControl3.Location = New System.Drawing.Point(218, 224)
        Me.GaugeControl3.Name = "GaugeControl3"
        Me.GaugeControl3.Size = New System.Drawing.Size(185, 68)
        Me.GaugeControl3.TabIndex = 11
        '
        'DigitalGauge11
        '
        Me.DigitalGauge11.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#34000000")
        Me.DigitalGauge11.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#7F93C6")
        Me.DigitalGauge11.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent18})
        Me.DigitalGauge11.Bounds = New System.Drawing.Rectangle(6, 6, 173, 56)
        Me.DigitalGauge11.DigitCount = 5
        Me.DigitalGauge11.Name = "DigitalGauge11"
        Me.DigitalGauge11.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent18
        '
        Me.DigitalBackgroundLayerComponent18.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent18.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style25
        Me.DigitalBackgroundLayerComponent18.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent18.ZOrder = 1000
        '
        'GaugeControl1
        '
        Me.GaugeControl1.BackColor = System.Drawing.Color.Black
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(218, 139)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(185, 68)
        Me.GaugeControl1.TabIndex = 9
        '
        'DigitalGauge1
        '
        Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent16})
        Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 173, 56)
        Me.DigitalGauge1.DigitCount = 5
        Me.DigitalGauge1.Name = "DigitalGauge1"
        Me.DigitalGauge1.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent16
        '
        Me.DigitalBackgroundLayerComponent16.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent16.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent16.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent16.ZOrder = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(287, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "TPH"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(107, 762)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "FM # 6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(107, 676)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "FM # 5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(107, 590)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "FM # 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(107, 504)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "FM # 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(107, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FM # 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(107, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FM # 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(107, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Raw Mill"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(107, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kiln # 5"
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent11
        '
        Me.DigitalBackgroundLayerComponent11.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent11.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent11.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent11.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent13
        '
        Me.DigitalBackgroundLayerComponent13.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent13.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style25
        Me.DigitalBackgroundLayerComponent13.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent13.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent12
        '
        Me.DigitalBackgroundLayerComponent12.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent12.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style25
        Me.DigitalBackgroundLayerComponent12.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent12.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent15
        '
        Me.DigitalBackgroundLayerComponent15.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent15.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style5
        Me.DigitalBackgroundLayerComponent15.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent15.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent14
        '
        Me.DigitalBackgroundLayerComponent14.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent14.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style5
        Me.DigitalBackgroundLayerComponent14.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent14.ZOrder = 1000
        '
        'CCh
        '
        Me.CCh.Controls.Add(Me.TabNavigationPage1)
        Me.CCh.Controls.Add(Me.TabNavigationPage2)
        Me.CCh.Controls.Add(Me.TabNavigationPage3)
        Me.CCh.Controls.Add(Me.TabNavigationPage4)
        Me.CCh.Controls.Add(Me.TabNavigationPage5)
        Me.CCh.Controls.Add(Me.TabNavigationPage6)
        Me.CCh.Controls.Add(Me.TabNavigationPage7)
        Me.CCh.Controls.Add(Me.TabNavigationPage8)
        Me.CCh.Controls.Add(Me.TabNavigationPage9)
        Me.CCh.Controls.Add(Me.TabNavigationPage10)
        Me.CCh.Controls.Add(Me.TabNavigationPage11)
        Me.CCh.Controls.Add(Me.TabNavigationPage12)
        Me.CCh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CCh.Location = New System.Drawing.Point(0, 143)
        Me.CCh.Name = "CCh"
        Me.CCh.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2, Me.TabNavigationPage3, Me.TabNavigationPage5, Me.TabNavigationPage6, Me.TabNavigationPage7, Me.TabNavigationPage8, Me.TabNavigationPage9, Me.TabNavigationPage10, Me.TabNavigationPage11, Me.TabNavigationPage12, Me.TabNavigationPage4})
        Me.CCh.RegularSize = New System.Drawing.Size(1930, 925)
        Me.CCh.SelectedPage = Me.TabNavigationPage1
        Me.CCh.Size = New System.Drawing.Size(1930, 925)
        Me.CCh.TabIndex = 7
        Me.CCh.Text = "TabPane1"
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "Raw Mill"
        Me.TabNavigationPage2.Controls.Add(Me.PictureBox2)
        Me.TabNavigationPage2.Controls.Add(Me.VRMChart)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox2.Location = New System.Drawing.Point(1711, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'VRMChart
        '
        Me.VRMChart.AppearanceNameSerializable = "Dark Flat"
        Me.VRMChart.BackColor = System.Drawing.Color.Black
        Me.VRMChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.VRMChart.CacheToMemory = True
        Me.VRMChart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram4.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram4.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram4.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram4.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram4.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram4.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram4.DefaultPane.BackColor = System.Drawing.Color.Black
        SwiftPlotDiagramSecondaryAxisY5.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY5.AxisID = 0
        SwiftPlotDiagramSecondaryAxisY5.Color = System.Drawing.Color.Blue
        SwiftPlotDiagramSecondaryAxisY5.Name = "Secondary AxisY 1"
        SwiftPlotDiagramSecondaryAxisY5.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY5.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY5.VisualRange.MaxValueSerializable = "300"
        SwiftPlotDiagramSecondaryAxisY5.VisualRange.MinValueSerializable = "120"
        SwiftPlotDiagramSecondaryAxisY5.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY5.WholeRange.MaxValueSerializable = "300"
        SwiftPlotDiagramSecondaryAxisY5.WholeRange.MinValueSerializable = "120"
        SwiftPlotDiagramSecondaryAxisY6.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY6.AxisID = 1
        SwiftPlotDiagramSecondaryAxisY6.Color = System.Drawing.Color.Green
        SwiftPlotDiagramSecondaryAxisY6.Name = "Secondary AxisY 2"
        SwiftPlotDiagramSecondaryAxisY6.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY6.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY6.VisualRange.MaxValueSerializable = "900"
        SwiftPlotDiagramSecondaryAxisY6.VisualRange.MinValueSerializable = "400"
        SwiftPlotDiagramSecondaryAxisY6.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY6.WholeRange.MaxValueSerializable = "900"
        SwiftPlotDiagramSecondaryAxisY6.WholeRange.MinValueSerializable = "250"
        SwiftPlotDiagramSecondaryAxisY7.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY7.AxisID = 2
        SwiftPlotDiagramSecondaryAxisY7.Color = System.Drawing.Color.Purple
        SwiftPlotDiagramSecondaryAxisY7.Name = "Secondary AxisY 3"
        SwiftPlotDiagramSecondaryAxisY7.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY7.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY7.VisualRange.MaxValueSerializable = "3"
        SwiftPlotDiagramSecondaryAxisY7.VisualRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY7.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY7.WholeRange.MaxValueSerializable = "3"
        SwiftPlotDiagramSecondaryAxisY7.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY8.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY8.AxisID = 3
        SwiftPlotDiagramSecondaryAxisY8.Color = System.Drawing.Color.Yellow
        SwiftPlotDiagramSecondaryAxisY8.Name = "Secondary AxisY 4"
        SwiftPlotDiagramSecondaryAxisY8.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY8.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY8.VisualRange.MaxValueSerializable = "100"
        SwiftPlotDiagramSecondaryAxisY8.VisualRange.MinValueSerializable = "50"
        SwiftPlotDiagramSecondaryAxisY8.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY8.WholeRange.MaxValueSerializable = "100"
        SwiftPlotDiagramSecondaryAxisY8.WholeRange.MinValueSerializable = "50"
        SwiftPlotDiagramSecondaryAxisY9.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY9.AxisID = 4
        SwiftPlotDiagramSecondaryAxisY9.Color = System.Drawing.Color.RoyalBlue
        SwiftPlotDiagramSecondaryAxisY9.Name = "Secondary AxisY 5"
        SwiftPlotDiagramSecondaryAxisY9.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY9.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY9.VisualRange.MaxValueSerializable = "8000"
        SwiftPlotDiagramSecondaryAxisY9.VisualRange.MinValueSerializable = "3000"
        SwiftPlotDiagramSecondaryAxisY9.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY9.WholeRange.MaxValueSerializable = "8000"
        SwiftPlotDiagramSecondaryAxisY9.WholeRange.MinValueSerializable = "3000"
        SwiftPlotDiagramSecondaryAxisY10.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY10.AxisID = 5
        SwiftPlotDiagramSecondaryAxisY10.Color = System.Drawing.Color.SlateGray
        SwiftPlotDiagramSecondaryAxisY10.Name = "Secondary AxisY 6"
        SwiftPlotDiagramSecondaryAxisY10.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY10.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY10.VisualRange.MaxValueSerializable = "100"
        SwiftPlotDiagramSecondaryAxisY10.VisualRange.MinValueSerializable = "10"
        SwiftPlotDiagramSecondaryAxisY10.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY10.WholeRange.MaxValueSerializable = "100"
        SwiftPlotDiagramSecondaryAxisY10.WholeRange.MinValueSerializable = "10"
        SwiftPlotDiagramSecondaryAxisY11.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY11.AxisID = 6
        SwiftPlotDiagramSecondaryAxisY11.Color = System.Drawing.Color.Orange
        SwiftPlotDiagramSecondaryAxisY11.Name = "Secondary AxisY 7"
        SwiftPlotDiagramSecondaryAxisY11.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY11.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY11.VisualRange.MaxValueSerializable = "10"
        SwiftPlotDiagramSecondaryAxisY11.VisualRange.MinValueSerializable = "1"
        SwiftPlotDiagramSecondaryAxisY11.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY11.WholeRange.MaxValueSerializable = "10"
        SwiftPlotDiagramSecondaryAxisY11.WholeRange.MinValueSerializable = "1"
        SwiftPlotDiagramSecondaryAxisY12.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY12.AxisID = 7
        SwiftPlotDiagramSecondaryAxisY12.Color = System.Drawing.Color.SkyBlue
        SwiftPlotDiagramSecondaryAxisY12.Name = "Secondary AxisY 8"
        SwiftPlotDiagramSecondaryAxisY12.Title.Alignment = System.Drawing.StringAlignment.Far
        SwiftPlotDiagramSecondaryAxisY12.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY12.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY12.VisualRange.MaxValueSerializable = "130"
        SwiftPlotDiagramSecondaryAxisY12.VisualRange.MinValueSerializable = "70"
        SwiftPlotDiagramSecondaryAxisY12.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY12.WholeRange.MaxValueSerializable = "130"
        SwiftPlotDiagramSecondaryAxisY12.WholeRange.MinValueSerializable = "70"
        SwiftPlotDiagram4.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY() {SwiftPlotDiagramSecondaryAxisY5, SwiftPlotDiagramSecondaryAxisY6, SwiftPlotDiagramSecondaryAxisY7, SwiftPlotDiagramSecondaryAxisY8, SwiftPlotDiagramSecondaryAxisY9, SwiftPlotDiagramSecondaryAxisY10, SwiftPlotDiagramSecondaryAxisY11, SwiftPlotDiagramSecondaryAxisY12})
        Me.VRMChart.Diagram = SwiftPlotDiagram4
        Me.VRMChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VRMChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.VRMChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.VRMChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.VRMChart.Location = New System.Drawing.Point(0, 0)
        Me.VRMChart.Name = "VRMChart"
        Me.VRMChart.PaletteBaseColorNumber = 4
        Me.VRMChart.PaletteName = "Chameleon"
        Me.VRMChart.RefreshDataOnRepaint = False
        Series8.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series8.Name = "Feed (AF speed)"
        SwiftPlotSeriesView10.Color = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        SwiftPlotSeriesView10.LineStyle.Thickness = 2
        Series8.View = SwiftPlotSeriesView10
        Series9.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series9.Name = "Outlet Temperature"
        SwiftPlotSeriesView11.LineStyle.Thickness = 2
        Series9.View = SwiftPlotSeriesView11
        Series10.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series10.Name = "Inlet Temperature"
        SwiftPlotSeriesView12.LineStyle.Thickness = 2
        Series10.View = SwiftPlotSeriesView12
        Series11.Name = "RM Vibration"
        SwiftPlotSeriesView13.LineStyle.Thickness = 2
        Series11.View = SwiftPlotSeriesView13
        Series12.Name = "Separator Speed"
        SwiftPlotSeriesView14.LineStyle.Thickness = 2
        Series12.View = SwiftPlotSeriesView14
        Series13.Name = "RM Fan KW"
        SwiftPlotSeriesView15.LineStyle.Thickness = 2
        Series13.View = SwiftPlotSeriesView15
        Series14.Name = "RM Fan Damper"
        SwiftPlotSeriesView16.LineStyle.Thickness = 2
        Series14.View = SwiftPlotSeriesView16
        Series15.Name = "Inlet Pressure"
        SwiftPlotSeriesView17.LineStyle.Thickness = 2
        Series15.View = SwiftPlotSeriesView17
        Series16.Name = "Gamma C3S"
        SwiftPlotSeriesView18.LineStyle.Thickness = 2
        Series16.View = SwiftPlotSeriesView18
        Me.VRMChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series8, Series9, Series10, Series11, Series12, Series13, Series14, Series15, Series16}
        Me.VRMChart.SeriesTemplate.View = SwiftPlotSeriesView19
        Me.VRMChart.Size = New System.Drawing.Size(1912, 880)
        Me.VRMChart.TabIndex = 15
        ChartTitle3.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Raw Mill Operations"
        Me.VRMChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'TabNavigationPage3
        '
        Me.TabNavigationPage3.Caption = "Kiln Trend"
        Me.TabNavigationPage3.Controls.Add(Me.PictureBox3)
        Me.TabNavigationPage3.Controls.Add(Me.KilnChart)
        Me.TabNavigationPage3.Name = "TabNavigationPage3"
        Me.TabNavigationPage3.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox3.Location = New System.Drawing.Point(1701, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'KilnChart
        '
        Me.KilnChart.AppearanceNameSerializable = "Dark"
        Me.KilnChart.CacheToMemory = True
        Me.KilnChart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram5.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram5.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram5.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram5.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram5.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram5.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram5.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram5.AxisY.VisualRange.MaxValueSerializable = "520"
        SwiftPlotDiagram5.AxisY.VisualRange.MinValueSerializable = "350"
        SwiftPlotDiagram5.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram5.AxisY.WholeRange.MaxValueSerializable = "550"
        SwiftPlotDiagram5.AxisY.WholeRange.MinValueSerializable = "350"
        SwiftPlotDiagram5.DefaultPane.BackColor = System.Drawing.Color.Black
        SwiftPlotDiagramSecondaryAxisY13.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY13.AxisID = 0
        SwiftPlotDiagramSecondaryAxisY13.Color = System.Drawing.Color.Blue
        SwiftPlotDiagramSecondaryAxisY13.Name = "Secondary AxisY 1"
        SwiftPlotDiagramSecondaryAxisY13.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY13.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY13.VisualRange.MaxValueSerializable = "120"
        SwiftPlotDiagramSecondaryAxisY13.VisualRange.MinValueSerializable = "30"
        SwiftPlotDiagramSecondaryAxisY13.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY13.WholeRange.MaxValueSerializable = "200"
        SwiftPlotDiagramSecondaryAxisY13.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY14.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY14.AxisID = 1
        SwiftPlotDiagramSecondaryAxisY14.Color = System.Drawing.Color.Lime
        SwiftPlotDiagramSecondaryAxisY14.Name = "Secondary AxisY 2"
        SwiftPlotDiagramSecondaryAxisY14.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY14.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY14.VisualRange.MaxValueSerializable = "100"
        SwiftPlotDiagramSecondaryAxisY14.VisualRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY14.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY14.WholeRange.MaxValueSerializable = "100"
        SwiftPlotDiagramSecondaryAxisY14.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY15.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY15.AxisID = 2
        SwiftPlotDiagramSecondaryAxisY15.Name = "Secondary AxisY 3"
        SwiftPlotDiagramSecondaryAxisY15.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY15.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY15.VisualRange.MaxValueSerializable = "100"
        SwiftPlotDiagramSecondaryAxisY15.VisualRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY15.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY15.WholeRange.MaxValueSerializable = "100"
        SwiftPlotDiagramSecondaryAxisY15.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY16.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY16.AxisID = 3
        SwiftPlotDiagramSecondaryAxisY16.Color = System.Drawing.Color.Purple
        SwiftPlotDiagramSecondaryAxisY16.Name = "Secondary AxisY 4"
        SwiftPlotDiagramSecondaryAxisY16.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY16.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY16.VisualRange.MaxValueSerializable = "900"
        SwiftPlotDiagramSecondaryAxisY16.VisualRange.MinValueSerializable = "300"
        SwiftPlotDiagramSecondaryAxisY16.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY16.WholeRange.MaxValueSerializable = "900"
        SwiftPlotDiagramSecondaryAxisY16.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY17.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY17.AxisID = 4
        SwiftPlotDiagramSecondaryAxisY17.Color = System.Drawing.Color.Yellow
        SwiftPlotDiagramSecondaryAxisY17.Name = "Secondary AxisY 5"
        SwiftPlotDiagramSecondaryAxisY17.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY17.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY17.VisualRange.MaxValueSerializable = "2000"
        SwiftPlotDiagramSecondaryAxisY17.VisualRange.MinValueSerializable = "500"
        SwiftPlotDiagramSecondaryAxisY17.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY17.WholeRange.MaxValueSerializable = "2000"
        SwiftPlotDiagramSecondaryAxisY17.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY18.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY18.AxisID = 5
        SwiftPlotDiagramSecondaryAxisY18.Name = "Secondary AxisY 6"
        SwiftPlotDiagramSecondaryAxisY18.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY18.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY18.VisualRange.MaxValueSerializable = "20"
        SwiftPlotDiagramSecondaryAxisY18.VisualRange.MinValueSerializable = "2"
        SwiftPlotDiagramSecondaryAxisY18.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY18.WholeRange.MaxValueSerializable = "20"
        SwiftPlotDiagramSecondaryAxisY18.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY19.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY19.AxisID = 6
        SwiftPlotDiagramSecondaryAxisY19.Name = "Secondary AxisY 7"
        SwiftPlotDiagramSecondaryAxisY19.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY19.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY19.VisualRange.MaxValueSerializable = "20"
        SwiftPlotDiagramSecondaryAxisY19.VisualRange.MinValueSerializable = "2"
        SwiftPlotDiagramSecondaryAxisY19.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY19.WholeRange.MaxValueSerializable = "20"
        SwiftPlotDiagramSecondaryAxisY19.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY20.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY20.AxisID = 7
        SwiftPlotDiagramSecondaryAxisY20.Name = "Secondary AxisY 8"
        SwiftPlotDiagramSecondaryAxisY20.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY20.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY20.VisualRange.MaxValueSerializable = "20"
        SwiftPlotDiagramSecondaryAxisY20.VisualRange.MinValueSerializable = "2"
        SwiftPlotDiagramSecondaryAxisY20.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY20.WholeRange.MaxValueSerializable = "20"
        SwiftPlotDiagramSecondaryAxisY20.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY21.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY21.AxisID = 8
        SwiftPlotDiagramSecondaryAxisY21.Name = "Secondary AxisY 9"
        SwiftPlotDiagramSecondaryAxisY21.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY21.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY21.VisualRange.MaxValueSerializable = "600000"
        SwiftPlotDiagramSecondaryAxisY21.VisualRange.MinValueSerializable = "50000"
        SwiftPlotDiagramSecondaryAxisY21.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY21.WholeRange.MaxValueSerializable = "600000"
        SwiftPlotDiagramSecondaryAxisY21.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagramSecondaryAxisY22.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SwiftPlotDiagramSecondaryAxisY22.AxisID = 9
        SwiftPlotDiagramSecondaryAxisY22.Name = "Secondary AxisY 10"
        SwiftPlotDiagramSecondaryAxisY22.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagramSecondaryAxisY22.VisualRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY22.VisualRange.MaxValueSerializable = "600000"
        SwiftPlotDiagramSecondaryAxisY22.VisualRange.MinValueSerializable = "50000"
        SwiftPlotDiagramSecondaryAxisY22.WholeRange.Auto = False
        SwiftPlotDiagramSecondaryAxisY22.WholeRange.MaxValueSerializable = "600000"
        SwiftPlotDiagramSecondaryAxisY22.WholeRange.MinValueSerializable = "0"
        SwiftPlotDiagram5.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SwiftPlotDiagramSecondaryAxisY() {SwiftPlotDiagramSecondaryAxisY13, SwiftPlotDiagramSecondaryAxisY14, SwiftPlotDiagramSecondaryAxisY15, SwiftPlotDiagramSecondaryAxisY16, SwiftPlotDiagramSecondaryAxisY17, SwiftPlotDiagramSecondaryAxisY18, SwiftPlotDiagramSecondaryAxisY19, SwiftPlotDiagramSecondaryAxisY20, SwiftPlotDiagramSecondaryAxisY21, SwiftPlotDiagramSecondaryAxisY22})
        Me.KilnChart.Diagram = SwiftPlotDiagram5
        Me.KilnChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KilnChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.KilnChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.KilnChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.KilnChart.Location = New System.Drawing.Point(0, 0)
        Me.KilnChart.Name = "KilnChart"
        Me.KilnChart.PaletteName = "Default"
        Me.KilnChart.RefreshDataOnRepaint = False
        Series17.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series17.Name = "Feed (TPH)"
        SwiftPlotSeriesView20.LineStyle.Thickness = 2
        Series17.View = SwiftPlotSeriesView20
        Series18.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series18.Name = "Amps"
        SwiftPlotSeriesView21.LineStyle.Thickness = 2
        Series18.View = SwiftPlotSeriesView21
        Series19.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series19.Name = "ID Fan # 1 Speed"
        SwiftPlotSeriesView22.LineStyle.Thickness = 2
        Series19.View = SwiftPlotSeriesView22
        Series20.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series20.Name = "ID Fan # 2 Speed"
        SwiftPlotSeriesView23.LineStyle.Thickness = 2
        Series20.View = SwiftPlotSeriesView23
        Series21.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series21.Name = "1st Stage Temp"
        SwiftPlotSeriesView24.LineStyle.Thickness = 2
        Series21.View = SwiftPlotSeriesView24
        Series22.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series22.Name = "4th stage Temp"
        SwiftPlotSeriesView25.LineStyle.Thickness = 2
        Series22.View = SwiftPlotSeriesView25
        Series23.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series23.Name = "PW1 TPH"
        SwiftPlotSeriesView26.LineStyle.Thickness = 2
        Series23.View = SwiftPlotSeriesView26
        Series24.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series24.Name = "PW2 TPH"
        SwiftPlotSeriesView27.LineStyle.Thickness = 2
        Series24.View = SwiftPlotSeriesView27
        Series25.Name = "PW3 TPH"
        SwiftPlotSeriesView28.LineStyle.Thickness = 2
        Series25.View = SwiftPlotSeriesView28
        Series26.Name = "Gas Kiln"
        SwiftPlotSeriesView29.LineStyle.Thickness = 2
        Series26.View = SwiftPlotSeriesView29
        Series27.Name = "Gas Calciner"
        SwiftPlotSeriesView30.LineStyle.Thickness = 2
        Series27.View = SwiftPlotSeriesView30
        Me.KilnChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series17, Series18, Series19, Series20, Series21, Series22, Series23, Series24, Series25, Series26, Series27}
        Me.KilnChart.SeriesTemplate.View = SwiftPlotSeriesView31
        Me.KilnChart.Size = New System.Drawing.Size(1912, 880)
        Me.KilnChart.TabIndex = 0
        ChartTitle4.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kiln Operation"
        Me.KilnChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
        '
        'TabNavigationPage4
        '
        Me.TabNavigationPage4.Caption = "Historian"
        Me.TabNavigationPage4.Controls.Add(Me.ProgressPanel1)
        Me.TabNavigationPage4.Controls.Add(Me.PictureBox4)
        Me.TabNavigationPage4.Controls.Add(Me.ChartHistorian)
        Me.TabNavigationPage4.Name = "TabNavigationPage4"
        Me.TabNavigationPage4.Size = New System.Drawing.Size(1912, 880)
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.Location = New System.Drawing.Point(884, 394)
        Me.ProgressPanel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.ProgressPanel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgressPanel1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.ProgressPanel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.ProgressPanel1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(170, 63)
        Me.ProgressPanel1.TabIndex = 17
        Me.ProgressPanel1.Text = "ProgressPanel1"
        Me.ProgressPanel1.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox4.Location = New System.Drawing.Point(1712, 15)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'TabNavigationPage5
        '
        Me.TabNavigationPage5.Caption = "PHT"
        Me.TabNavigationPage5.Controls.Add(Me.PictureBox5)
        Me.TabNavigationPage5.Controls.Add(Me.PHTChart)
        Me.TabNavigationPage5.Name = "TabNavigationPage5"
        Me.TabNavigationPage5.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox5.Location = New System.Drawing.Point(1705, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PHTChart
        '
        Me.PHTChart.AppearanceNameSerializable = "Dark"
        Me.PHTChart.CacheToMemory = True
        Me.PHTChart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram6.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram6.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram6.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram6.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram6.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram6.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram6.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram6.AxisY.VisualRange.MaxValueSerializable = "520"
        SwiftPlotDiagram6.AxisY.VisualRange.MinValueSerializable = "350"
        SwiftPlotDiagram6.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram6.AxisY.WholeRange.MaxValueSerializable = "550"
        SwiftPlotDiagram6.AxisY.WholeRange.MinValueSerializable = "350"
        SwiftPlotDiagram6.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.PHTChart.Diagram = SwiftPlotDiagram6
        Me.PHTChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PHTChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.PHTChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.PHTChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.PHTChart.Location = New System.Drawing.Point(0, 0)
        Me.PHTChart.Name = "PHTChart"
        Me.PHTChart.PaletteName = "Default"
        Me.PHTChart.RefreshDataOnRepaint = False
        Series28.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series28.Name = "Feed (TPH)"
        SwiftPlotSeriesView32.LineStyle.Thickness = 2
        Series28.View = SwiftPlotSeriesView32
        Me.PHTChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series28}
        Me.PHTChart.SeriesTemplate.View = SwiftPlotSeriesView33
        Me.PHTChart.Size = New System.Drawing.Size(1912, 880)
        Me.PHTChart.TabIndex = 1
        ChartTitle5.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle5.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pre-Heat Tower Operation"
        Me.PHTChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle5})
        '
        'TabNavigationPage6
        '
        Me.TabNavigationPage6.Caption = "Cooler"
        Me.TabNavigationPage6.Controls.Add(Me.PictureBox6)
        Me.TabNavigationPage6.Controls.Add(Me.CoolerChart)
        Me.TabNavigationPage6.Name = "TabNavigationPage6"
        Me.TabNavigationPage6.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox6.Location = New System.Drawing.Point(1705, 16)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'CoolerChart
        '
        Me.CoolerChart.AppearanceNameSerializable = "Dark"
        Me.CoolerChart.CacheToMemory = True
        Me.CoolerChart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram7.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram7.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram7.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram7.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram7.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram7.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram7.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram7.AxisY.VisualRange.MaxValueSerializable = "520"
        SwiftPlotDiagram7.AxisY.VisualRange.MinValueSerializable = "350"
        SwiftPlotDiagram7.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram7.AxisY.WholeRange.MaxValueSerializable = "550"
        SwiftPlotDiagram7.AxisY.WholeRange.MinValueSerializable = "350"
        SwiftPlotDiagram7.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.CoolerChart.Diagram = SwiftPlotDiagram7
        Me.CoolerChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoolerChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.CoolerChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.CoolerChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.CoolerChart.Location = New System.Drawing.Point(0, 0)
        Me.CoolerChart.Name = "CoolerChart"
        Me.CoolerChart.PaletteName = "Default"
        Me.CoolerChart.RefreshDataOnRepaint = False
        Series29.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series29.Name = "Feed (TPH)"
        SwiftPlotSeriesView34.LineStyle.Thickness = 2
        Series29.View = SwiftPlotSeriesView34
        Me.CoolerChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series29}
        Me.CoolerChart.SeriesTemplate.View = SwiftPlotSeriesView35
        Me.CoolerChart.Size = New System.Drawing.Size(1912, 880)
        Me.CoolerChart.TabIndex = 17
        ChartTitle6.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle6.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cooler Operation"
        Me.CoolerChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle6})
        '
        'TabNavigationPage7
        '
        Me.TabNavigationPage7.Caption = "Finish Mill # 1"
        Me.TabNavigationPage7.Controls.Add(Me.PictureBox7)
        Me.TabNavigationPage7.Controls.Add(Me.FM1Chart)
        Me.TabNavigationPage7.Name = "TabNavigationPage7"
        Me.TabNavigationPage7.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox7.Location = New System.Drawing.Point(1705, 16)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'FM1Chart
        '
        Me.FM1Chart.AppearanceNameSerializable = "Dark"
        Me.FM1Chart.CacheToMemory = True
        Me.FM1Chart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram8.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram8.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram8.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram8.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram8.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram8.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram8.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram8.AxisY.VisualRange.MaxValueSerializable = "520"
        SwiftPlotDiagram8.AxisY.VisualRange.MinValueSerializable = "350"
        SwiftPlotDiagram8.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram8.AxisY.WholeRange.MaxValueSerializable = "550"
        SwiftPlotDiagram8.AxisY.WholeRange.MinValueSerializable = "350"
        SwiftPlotDiagram8.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.FM1Chart.Diagram = SwiftPlotDiagram8
        Me.FM1Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FM1Chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.FM1Chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.FM1Chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.FM1Chart.Location = New System.Drawing.Point(0, 0)
        Me.FM1Chart.Name = "FM1Chart"
        Me.FM1Chart.PaletteName = "Default"
        Me.FM1Chart.RefreshDataOnRepaint = False
        Series30.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series30.Name = "Feed (TPH)"
        SwiftPlotSeriesView36.LineStyle.Thickness = 2
        Series30.View = SwiftPlotSeriesView36
        Me.FM1Chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series30}
        Me.FM1Chart.SeriesTemplate.View = SwiftPlotSeriesView37
        Me.FM1Chart.Size = New System.Drawing.Size(1912, 880)
        Me.FM1Chart.TabIndex = 17
        ChartTitle7.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle7.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finish Mill # 1 Operation"
        Me.FM1Chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle7})
        '
        'TabNavigationPage8
        '
        Me.TabNavigationPage8.Caption = "Finish Mill # 2"
        Me.TabNavigationPage8.Controls.Add(Me.PictureBox8)
        Me.TabNavigationPage8.Controls.Add(Me.FM2Chart)
        Me.TabNavigationPage8.Name = "TabNavigationPage8"
        Me.TabNavigationPage8.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox8.Location = New System.Drawing.Point(1705, 16)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 20
        Me.PictureBox8.TabStop = False
        '
        'FM2Chart
        '
        Me.FM2Chart.AppearanceNameSerializable = "Dark"
        Me.FM2Chart.CacheToMemory = True
        Me.FM2Chart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram9.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram9.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram9.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram9.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram9.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram9.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram9.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram9.AxisY.VisualRange.MaxValueSerializable = "520"
        SwiftPlotDiagram9.AxisY.VisualRange.MinValueSerializable = "350"
        SwiftPlotDiagram9.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram9.AxisY.WholeRange.MaxValueSerializable = "550"
        SwiftPlotDiagram9.AxisY.WholeRange.MinValueSerializable = "350"
        SwiftPlotDiagram9.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.FM2Chart.Diagram = SwiftPlotDiagram9
        Me.FM2Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FM2Chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.FM2Chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.FM2Chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.FM2Chart.Location = New System.Drawing.Point(0, 0)
        Me.FM2Chart.Name = "FM2Chart"
        Me.FM2Chart.PaletteName = "Default"
        Me.FM2Chart.RefreshDataOnRepaint = False
        Series31.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series31.Name = "Feed (TPH)"
        SwiftPlotSeriesView38.LineStyle.Thickness = 2
        Series31.View = SwiftPlotSeriesView38
        Me.FM2Chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series31}
        Me.FM2Chart.SeriesTemplate.View = SwiftPlotSeriesView39
        Me.FM2Chart.Size = New System.Drawing.Size(1912, 880)
        Me.FM2Chart.TabIndex = 19
        ChartTitle8.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle8.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finish Mill # 2 Operation"
        Me.FM2Chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle8})
        '
        'TabNavigationPage9
        '
        Me.TabNavigationPage9.Caption = "Finish Mill # 3"
        Me.TabNavigationPage9.Controls.Add(Me.PictureBox9)
        Me.TabNavigationPage9.Controls.Add(Me.FM3Chart)
        Me.TabNavigationPage9.Name = "TabNavigationPage9"
        Me.TabNavigationPage9.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox9.Location = New System.Drawing.Point(1705, 16)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 20
        Me.PictureBox9.TabStop = False
        '
        'FM3Chart
        '
        Me.FM3Chart.AppearanceNameSerializable = "Dark"
        Me.FM3Chart.CacheToMemory = True
        Me.FM3Chart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram10.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram10.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram10.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram10.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram10.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram10.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram10.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram10.AxisY.VisualRange.MaxValueSerializable = "520"
        SwiftPlotDiagram10.AxisY.VisualRange.MinValueSerializable = "350"
        SwiftPlotDiagram10.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram10.AxisY.WholeRange.MaxValueSerializable = "550"
        SwiftPlotDiagram10.AxisY.WholeRange.MinValueSerializable = "350"
        SwiftPlotDiagram10.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.FM3Chart.Diagram = SwiftPlotDiagram10
        Me.FM3Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FM3Chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.FM3Chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.FM3Chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.FM3Chart.Location = New System.Drawing.Point(0, 0)
        Me.FM3Chart.Name = "FM3Chart"
        Me.FM3Chart.PaletteName = "Default"
        Me.FM3Chart.RefreshDataOnRepaint = False
        Series32.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series32.Name = "Feed (TPH)"
        SwiftPlotSeriesView40.LineStyle.Thickness = 2
        Series32.View = SwiftPlotSeriesView40
        Me.FM3Chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series32}
        Me.FM3Chart.SeriesTemplate.View = SwiftPlotSeriesView41
        Me.FM3Chart.Size = New System.Drawing.Size(1912, 880)
        Me.FM3Chart.TabIndex = 19
        ChartTitle9.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle9.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finish Mill # 3 Operation"
        Me.FM3Chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle9})
        '
        'TabNavigationPage10
        '
        Me.TabNavigationPage10.Caption = "Finish Mill # 4"
        Me.TabNavigationPage10.Controls.Add(Me.PictureBox10)
        Me.TabNavigationPage10.Controls.Add(Me.FM4Chart)
        Me.TabNavigationPage10.Name = "TabNavigationPage10"
        Me.TabNavigationPage10.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox10.Location = New System.Drawing.Point(1705, 16)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 20
        Me.PictureBox10.TabStop = False
        '
        'FM4Chart
        '
        Me.FM4Chart.AppearanceNameSerializable = "Dark"
        Me.FM4Chart.CacheToMemory = True
        Me.FM4Chart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram11.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram11.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram11.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram11.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram11.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram11.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram11.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram11.AxisY.VisualRange.MaxValueSerializable = "520"
        SwiftPlotDiagram11.AxisY.VisualRange.MinValueSerializable = "350"
        SwiftPlotDiagram11.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram11.AxisY.WholeRange.MaxValueSerializable = "550"
        SwiftPlotDiagram11.AxisY.WholeRange.MinValueSerializable = "350"
        SwiftPlotDiagram11.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.FM4Chart.Diagram = SwiftPlotDiagram11
        Me.FM4Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FM4Chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.FM4Chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.FM4Chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.FM4Chart.Location = New System.Drawing.Point(0, 0)
        Me.FM4Chart.Name = "FM4Chart"
        Me.FM4Chart.PaletteName = "Default"
        Me.FM4Chart.RefreshDataOnRepaint = False
        Series33.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series33.Name = "Feed (TPH)"
        SwiftPlotSeriesView42.LineStyle.Thickness = 2
        Series33.View = SwiftPlotSeriesView42
        Me.FM4Chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series33}
        Me.FM4Chart.SeriesTemplate.View = SwiftPlotSeriesView43
        Me.FM4Chart.Size = New System.Drawing.Size(1912, 880)
        Me.FM4Chart.TabIndex = 19
        ChartTitle10.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle10.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finish Mill # 4 Operation"
        Me.FM4Chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle10})
        '
        'TabNavigationPage11
        '
        Me.TabNavigationPage11.Caption = "Finish Mill # 5"
        Me.TabNavigationPage11.Controls.Add(Me.PictureBox11)
        Me.TabNavigationPage11.Controls.Add(Me.FM5Chart)
        Me.TabNavigationPage11.Name = "TabNavigationPage11"
        Me.TabNavigationPage11.Size = New System.Drawing.Size(1912, 880)
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.Midlothian_Operations.My.Resources.Resources.martinmarietta
        Me.PictureBox11.Location = New System.Drawing.Point(1705, 16)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 20
        Me.PictureBox11.TabStop = False
        '
        'FM5Chart
        '
        Me.FM5Chart.AppearanceNameSerializable = "Dark"
        Me.FM5Chart.CacheToMemory = True
        Me.FM5Chart.DataSource = Me.LDMS7_MIDDataSet.LabData_FinishMill
        SwiftPlotDiagram12.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second
        SwiftPlotDiagram12.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
        SwiftPlotDiagram12.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram12.AxisY.Color = System.Drawing.Color.Red
        SwiftPlotDiagram12.AxisY.GridLines.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dot
        SwiftPlotDiagram12.AxisY.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram12.AxisY.VisualRange.Auto = False
        SwiftPlotDiagram12.AxisY.VisualRange.MaxValueSerializable = "520"
        SwiftPlotDiagram12.AxisY.VisualRange.MinValueSerializable = "350"
        SwiftPlotDiagram12.AxisY.WholeRange.Auto = False
        SwiftPlotDiagram12.AxisY.WholeRange.MaxValueSerializable = "550"
        SwiftPlotDiagram12.AxisY.WholeRange.MinValueSerializable = "350"
        SwiftPlotDiagram12.DefaultPane.BackColor = System.Drawing.Color.Black
        Me.FM5Chart.Diagram = SwiftPlotDiagram12
        Me.FM5Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FM5Chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.FM5Chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.FM5Chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.FM5Chart.Location = New System.Drawing.Point(0, 0)
        Me.FM5Chart.Name = "FM5Chart"
        Me.FM5Chart.PaletteName = "Default"
        Me.FM5Chart.RefreshDataOnRepaint = False
        Series34.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series34.Name = "Feed (TPH)"
        SwiftPlotSeriesView44.LineStyle.Thickness = 2
        Series34.View = SwiftPlotSeriesView44
        Me.FM5Chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series34}
        Me.FM5Chart.SeriesTemplate.View = SwiftPlotSeriesView45
        Me.FM5Chart.Size = New System.Drawing.Size(1912, 880)
        Me.FM5Chart.TabIndex = 19
        ChartTitle11.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle11.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finish Mill # 5 Operation"
        Me.FM5Chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle11})
        '
        'TabNavigationPage12
        '
        Me.TabNavigationPage12.Caption = "Quality"
        Me.TabNavigationPage12.Name = "TabNavigationPage12"
        Me.TabNavigationPage12.Size = New System.Drawing.Size(1912, 880)
        '
        'tmrUpdateRealTime
        '
        Me.tmrUpdateRealTime.Interval = 5000
        '
        'HistoryDataSet
        '
        Me.HistoryDataSet.DataSetName = "HistoryDataSet"
        Me.HistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnalogHistoryBindingSource
        '
        Me.AnalogHistoryBindingSource.DataMember = "AnalogHistory"
        Me.AnalogHistoryBindingSource.DataSource = Me.HistoryDataSet
        '
        'AnalogHistoryTableAdapter
        '
        Me.AnalogHistoryTableAdapter.ClearBeforeFill = True
        '
        'AnalogHistoryBindingSource1
        '
        Me.AnalogHistoryBindingSource1.DataMember = "AnalogHistory"
        Me.AnalogHistoryBindingSource1.DataSource = Me.HistoryDataSet
        '
        'tmrUpdateChart
        '
        Me.tmrUpdateChart.Interval = 60000
        '
        'BGW1
        '
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "From:"
        Me.BarEditItem1.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem1.EditHeight = 30
        Me.BarEditItem1.EditValue = New Date(2018, 4, 15, 22, 49, 28, 135)
        Me.BarEditItem1.EditWidth = 150
        Me.BarEditItem1.Id = 386
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "From:"
        Me.BarEditItem2.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem2.EditHeight = 30
        Me.BarEditItem2.EditValue = New Date(2018, 4, 15, 22, 49, 28, 135)
        Me.BarEditItem2.EditWidth = 150
        Me.BarEditItem2.Id = 386
        Me.BarEditItem2.Name = "BarEditItem2"
        Me.BarEditItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'OFD1
        '
        Me.OFD1.FileName = "OpenFileDialog1"
        '
        'BGW2
        '
        '
        'BGW3
        '
        '
        'BGW4
        '
        '
        'BGW5
        '
        '
        'BGW6
        '
        '
        'BGW7
        '
        '
        'BGW8
        '
        '
        'BGW9
        '
        '
        'BGW10
        '
        '
        'BGW11
        '
        '
        'BGW12
        '
        '
        'BarCheckItem13
        '
        Me.BarCheckItem13.Caption = "BarCheckItem7"
        Me.BarCheckItem13.Id = 396
        Me.BarCheckItem13.Name = "BarCheckItem13"
        '
        'BarCheckItem14
        '
        Me.BarCheckItem14.Caption = "BarCheckItem7"
        Me.BarCheckItem14.Id = 396
        Me.BarCheckItem14.Name = "BarCheckItem14"
        '
        'BarCheckItem15
        '
        Me.BarCheckItem15.Caption = "BarCheckItem8"
        Me.BarCheckItem15.Id = 397
        Me.BarCheckItem15.Name = "BarCheckItem15"
        '
        'tmrError
        '
        Me.tmrError.Interval = 30000
        '
        'BarEditItem3
        '
        Me.BarEditItem3.Caption = "From:"
        Me.BarEditItem3.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem3.EditHeight = 30
        Me.BarEditItem3.EditValue = New Date(2018, 4, 15, 22, 49, 28, 135)
        Me.BarEditItem3.EditWidth = 150
        Me.BarEditItem3.Id = 386
        Me.BarEditItem3.Name = "BarEditItem3"
        '
        'BarEditItem4
        '
        Me.BarEditItem4.Caption = "From:"
        Me.BarEditItem4.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem4.EditHeight = 30
        Me.BarEditItem4.EditValue = New Date(2018, 4, 15, 22, 49, 28, 135)
        Me.BarEditItem4.EditWidth = 150
        Me.BarEditItem4.Id = 386
        Me.BarEditItem4.Name = "BarEditItem4"
        '
        'bgwUpdateHistorian
        '
        Me.bgwUpdateHistorian.WorkerReportsProgress = True
        Me.bgwUpdateHistorian.WorkerSupportsCancellation = True
        '
        'MainPage
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.Appearance.BackColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1930, 1099)
        Me.Controls.Add(Me.CCh)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "MainPage"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Midlothian - Plant Operations"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DateTimeChartRangeControlClient1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartHistorian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LDMS7_MIDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnalogLiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage1.PerformLayout()
        CType(SwiftPlotDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FM6Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FM6Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CCh.ResumeLayout(False)
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VRMChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagramSecondaryAxisY22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KilnChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage5.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHTChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage6.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoolerChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage7.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FM1Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage8.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FM2Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage9.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FM3Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage10.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FM4Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage11.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FM5Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnalogHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnalogHistoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Private WithEvents siInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents iHelp As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents mailGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents organizerGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents inboxItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents draftsItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents trashItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents calendarItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents tasksItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents navbarImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
    Friend WithEvents RepositoryItemSpreadsheetFontSizeEdit1 As DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit
    Friend WithEvents RepositoryItemPopupGalleryEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit
    Friend WithEvents CommandBarGalleryDropDown1 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown2 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown3 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown4 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown5 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown6 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown7 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown8 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown9 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown10 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown11 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown12 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown13 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown14 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown15 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown16 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown17 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown18 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown19 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown20 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown21 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown22 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown23 As Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown24 As Commands.CommandBarGalleryDropDown
    Private WithEvents RibbonPageSkins As RibbonPage
    Friend WithEvents LiveDataSet As LiveDataSet
    Friend WithEvents AnalogLiveBindingSource As BindingSource
    Friend WithEvents AnalogLiveTableAdapter As LiveDataSetTableAdapters.AnalogLiveTableAdapter
    Friend WithEvents DigitalGauge2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Friend WithEvents DigitalGauge3 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents DigitalGauge4 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents DigitalGauge5 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents DigitalGauge6 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent7 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents DigitalGauge7 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent8 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents DigitalGauge8 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent9 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents DigitalGauge9 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent10 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents TabNavigationPage1 As Navigation.TabNavigationPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent11 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent13 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent12 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent15 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent14 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents CCh As Navigation.TabPane
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GaugeControl14 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge22 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent29 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GaugeControl13 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge21 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent28 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GaugeControl11 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge19 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent26 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GaugeControl9 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge17 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent24 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GaugeControl7 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge15 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent22 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GaugeControl5 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge13 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent20 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GaugeControl3 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge11 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent18 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent16 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents BarAndDockingController1 As BarAndDockingController
    Friend WithEvents tmrUpdateRealTime As Timer
    Friend WithEvents AnalogHistoryTableAdapter As HistoryDataSetTableAdapters.AnalogHistoryTableAdapter
    Friend WithEvents HistoryDataSet As HistoryDataSet
    Friend WithEvents AnalogHistoryBindingSource As BindingSource
    Friend WithEvents AnalogHistoryBindingSource1 As BindingSource
    Friend WithEvents FM6Chart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents tmrUpdateChart As Timer
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TabNavigationPage2 As Navigation.TabNavigationPage
    Friend WithEvents VRMChart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabNavigationPage3 As Navigation.TabNavigationPage
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents KilnChart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents BarButtonItem1 As BarButtonItem
    Friend WithEvents RibbonPageGroup1 As RibbonPageGroup
    Friend WithEvents BarButtonItem2 As BarButtonItem
    Friend WithEvents BGW1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabNavigationPage4 As Navigation.TabNavigationPage
    Friend WithEvents BarButtonItem3 As BarButtonItem
    Friend WithEvents RibbonPageGroup2 As RibbonPageGroup
    Friend WithEvents BarButtonItem4 As BarButtonItem
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ChartHistorian As DevExpress.XtraCharts.ChartControl
    Friend WithEvents BarButtonItem5 As BarButtonItem
    Friend WithEvents BarHeaderItem1 As BarHeaderItem
    Friend WithEvents DTPFrom As BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents DTPTo As BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem1 As BarEditItem
    Friend WithEvents BarEditItem2 As BarEditItem
    Friend WithEvents FM6Chart2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents OFD1 As OpenFileDialog
    Friend WithEvents SFD1 As SaveFileDialog
    Friend WithEvents BarButtonItem6 As BarButtonItem
    Friend WithEvents BarButtonItem7 As BarButtonItem
    Friend WithEvents RibbonPageGroup3 As RibbonPageGroup
    Friend WithEvents BGW2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW6 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabNavigationPage5 As Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage6 As Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage7 As Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage8 As Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage9 As Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage10 As Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage11 As Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage12 As Navigation.TabNavigationPage
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PHTChart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents CoolerChart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents FM1Chart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents FM2Chart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents FM3Chart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents FM4Chart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents FM5Chart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents BGW7 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW8 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW9 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW10 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW11 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW12 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LDMS7_MIDDataSet As LDMS7_MIDDataSet
    Friend WithEvents RibbonPage1 As RibbonPage
    Friend WithEvents RibbonPageGroup4 As RibbonPageGroup
    Friend WithEvents BarCheckItem1 As BarCheckItem
    Friend WithEvents BarCheckItem2 As BarCheckItem
    Friend WithEvents BarCheckItem3 As BarCheckItem
    Friend WithEvents BarCheckItem4 As BarCheckItem
    Friend WithEvents BarCheckItem5 As BarCheckItem
    Friend WithEvents BarCheckItem6 As BarCheckItem
    Friend WithEvents BarCheckItem7 As BarCheckItem
    Friend WithEvents BarCheckItem8 As BarCheckItem
    Friend WithEvents BarCheckItem9 As BarCheckItem
    Friend WithEvents BarCheckItem10 As BarCheckItem
    Friend WithEvents BarCheckItem11 As BarCheckItem
    Friend WithEvents BarCheckItem12 As BarCheckItem
    Friend WithEvents BarCheckItem13 As BarCheckItem
    Friend WithEvents BarCheckItem14 As BarCheckItem
    Friend WithEvents BarCheckItem15 As BarCheckItem
    Friend WithEvents BarButtonItem8 As BarButtonItem
    Friend WithEvents tmrError As Timer
    Friend WithEvents BarEditItem3 As BarEditItem
    Friend WithEvents BarEditItem4 As BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DateTimeChartRangeControlClient1 As DevExpress.XtraEditors.DateTimeChartRangeControlClient
    Friend WithEvents BarEditItem5 As BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    Friend WithEvents bgwUpdateHistorian As System.ComponentModel.BackgroundWorker
    'Friend WithEvents bgwHistorian As System.ComponentModel.BackgroundWorker
End Class
