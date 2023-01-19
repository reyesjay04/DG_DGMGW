Imports System.IO
Imports MySql.Data.MySqlClient
Module ModDGMW
    Property SalesFileName As New SalesFileTypeCls
    Property RetailPartnerCode As String = "DGPOS1234" 'Default Value
    Property TerminalNumber As String = "00" 'Default Value
    Property BatchNumber As String = "2"
    Property RetailPartnerCodeLength As Integer = 4 'Default Value
    Property ConnectionString As String

    Public Function GenerateDailySales() As List(Of String)
        Dim dlSales As New List(Of String)
        Dim mConn As New MySqlConnection
        mConn.ConnectionString = ModDGMW.ConnectionString
        Try
            mConn.Open()

            Using mCmd = New MySqlCommand("", mConn)
                mCmd.Parameters.Clear()
                mCmd.CommandText = ""

                Using mReader = mCmd.ExecuteReader
                    While mReader.Read
                        dlSales.Add(FieldTypeConstructor("RetailPartnerCode", mReader("RetailPartnerCode")))


                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mConn.Close()
        Return dlSales
    End Function

    Private Function FieldTypeConstructor(ByVal _fieldName As String, ByVal _fieldVal As Object) As String

        Dim dailySales As New FieldTypeCls With {
            .FieldName = _fieldName,
            .FieldValue = _fieldVal,
            .FieldNumber = FieldTypeCls.FieldType.RETAILCODE, 'PENDING
            .SetFieldValueType = .GetFieldDataType(_fieldName) 'TO TEST
        }
        Return dailySales.GenLineData
    End Function

    Public Sub WriteToTextFile()
        Using addInfo = File.CreateText("c:\directory\textfile.txt")
            addInfo.WriteLine("first line of text")
            addInfo.WriteLine("") ' blank line of text
            addInfo.WriteLine("3rd line of some text")
            addInfo.WriteLine("4th line of some text")
            addInfo.WriteLine("5th line of some text")
        End Using
    End Sub
End Module
