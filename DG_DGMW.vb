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
    Public Sub New(ByVal _rtpCode As String, ByVal _tmNumber As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ModDGMW.RetailPartnerCode = _rtpCode
        ModDGMW.TerminalNumber = _tmNumber
    End Sub

    Property FileNameGenerated As String
    Private Sub DG_DGMW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With SalesFileName
            .SalesFileType = SalesFileTypeCls.SalesFormat.DailySales
            .RetailPartnerCode = ModDGMW.RetailPartnerCode
            .RetailPartnerCodeLength = ModDGMW.RetailPartnerCodeLength
            .TerminalNumber = ModDGMW.TerminalNumber
            .BatchNumber = ModDGMW.BatchNumber
        End With

        FileNameGenerated = SalesFileName.GenerateFileName

        Console.WriteLine(FileNameGenerated)

    End Sub
End Class
