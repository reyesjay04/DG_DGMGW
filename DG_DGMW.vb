Imports System.IO
Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class DG_DGMW

    'The value of dtp2 and dtp3 depends on the MALL BUSINESS HOURS -- DEFAULT VALUE "12:00 AM" to "02:00 AM" the NEXT DAY
    'Save the settings file in config.ini
    'Create a catch block if config.ini is not found in the file path generate a new config.ini with the DEFAULT VALUE "12:00 AM" to "02:00 AM" the NEXT DAY
    'Save generated report logs in Audit Trail everytime a report is generated using this module
    'Read the Megaworld PDF file for the pattern and reference.
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal _rtpCode As String, ByVal _tmNumber As String, ByVal _connStr As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ModDGMW.RetailPartnerCode = _rtpCode
        ModDGMW.TerminalNumber = _tmNumber
        ModDGMW.ConnectionString = _connStr
    End Sub

    Property FileNameGenerated As String
    Private Sub DG_DGMW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Console.WriteLine(FileNameGenerated)

        Try
            Dim a As New DailySalesCls
            Dim info() As PropertyInfo = a.GetType().GetProperties()
            Dim obj As New Object

            For Each b As PropertyInfo In info

                If b.Name = "OldAccumulatedTotal" Then
                    Console.WriteLine(b.PropertyType.Name)
                End If

                'Console.WriteLine(b.Name)
                'Console.WriteLine(b.GetValue(a, Nothing))
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        Try

            SalesFileName = New SalesFileTypeCls

            With SalesFileName
                .SalesFileType = SalesFileTypeCls.SalesFormat.DailySales
                Using addInfo = File.CreateText("c:\directory\textfile.txt" & .GenerateFileName)
                    For Each str As String In GenerateDailySales()
                        addInfo.WriteLine("5th line of some text")
                    Next
                End Using
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnHourly_Click(sender As Object, e As EventArgs) Handles btnHourly.Click
        Try
            With SalesFileName
                .SalesFileType = SalesFileTypeCls.SalesFormat.HourlySales
            End With

            FileNameGenerated = SalesFileName.GenerateFileName

            MsgBox(FileNameGenerated)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        Try
            With SalesFileName
                .SalesFileType = SalesFileTypeCls.SalesFormat.DiscountData
            End With

            FileNameGenerated = SalesFileName.GenerateFileName
            MsgBox(FileNameGenerated)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
