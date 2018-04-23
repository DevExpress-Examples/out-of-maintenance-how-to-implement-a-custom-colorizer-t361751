Imports DevExpress.XtraTreeMap
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace CustomColorizerSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ConfigureTreeMapDataAdapter()
            ConfigureTreeMapColorizer()
        End Sub

        Private Sub ConfigureTreeMapDataAdapter()
            Dim adapter As TreeMapFlatDataAdapter = New TreeMapFlatDataAdapter With {.DataSource = CreateBillionaireInfos(), .LabelDataMember = "Name", .ValueDataMember = "NetWorth"}
            adapter.GroupDataMembers.Add("Residence")
            treeMap.DataAdapter = adapter
        End Sub

        #Region "#CustomColorizer"
        Private Sub ConfigureTreeMapColorizer()
            Dim colorizer = New CustomColorizer With {.Palette = Palette.Office2013Palette}
            treeMap.Colorizer = colorizer
        End Sub
        #End Region ' #CustomColorizer


        Private Function CreateBillionaireInfos() As List(Of BillionaireInfo)
            Dim infos As New List(Of BillionaireInfo)() From { _
                New BillionaireInfo With {.Name = "Bill Gates", .NetWorth = 79.2, .Age = 60, .Residence = "United States", .Source = "Microsoft"}, _
                New BillionaireInfo With {.Name = "Carlos Slim Helu", .NetWorth = 77.1, .Age = 75, .Residence = "Mexico", .Source = "telecom"}, _
                New BillionaireInfo With {.Name = "Warren Buffett", .NetWorth = 72.7, .Age = 85, .Residence = "United States", .Source = "Berkshire Hathaway"}, _
                New BillionaireInfo With {.Name = "Amancio Ortega", .NetWorth = 64.5, .Age = 79, .Residence = "Spain", .Source = "Zara"}, _
                New BillionaireInfo With {.Name = "Larry Ellison", .NetWorth = 54.3, .Age = 71, .Residence = "United States", .Source = "Oracle"}, _
                New BillionaireInfo With {.Name = "Charles Koch", .NetWorth = 42.9, .Age = 79, .Residence = "United States", .Source = "diversified"}, _
                New BillionaireInfo With {.Name = "David Koch", .NetWorth = 42.9, .Age = 75, .Residence = "United States", .Source = "diversified"}, _
                New BillionaireInfo With {.Name = "Christy Walton", .NetWorth = 41.7, .Age = 60, .Residence = "United States", .Source = "Wal-Mart"}, _
                New BillionaireInfo With {.Name = "Jim Walton", .NetWorth = 40.6, .Age = 67, .Residence = "United States", .Source = "Wal-Mart"}, _
                New BillionaireInfo With {.Name = "Liliane Bettencourt", .NetWorth = 40.1, .Age = 93, .Residence = "France", .Source = "L'Oreal"} _
            }
            Return infos
        End Function
    End Class
End Namespace
