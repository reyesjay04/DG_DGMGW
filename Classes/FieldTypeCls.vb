Imports System.Reflection

Public Class FieldTypeCls
    Property FieldName As String
    Property FieldNumber As FieldType
    Property FieldValue As Object
    Property SetFieldValueType As FieldDataType
    Enum FieldDataType
        isString
        isDouble
        isInteger
    End Enum
    Enum FieldType
        RETAILCODE
        TERMINALNUMBER
        BASEDATE
        OLDACCTOTAL
        NEWACCTOTAL
        GROSSSALES
        NONTAXABLESALES
        OTHERDISCOUNTANDFREEITEMS
        REFUND
        TAXVAT
        SERVICECHARGE
        NETSALES
        CREDITDEBITSALES
        OTHERPAYMENTSALES
        VOIDAMOUNT
        CUSTOMERCOUNT
        NUMBEROFSALESTRANSACTION
        SALESTYPE
        NETSALESAMOUNT
    End Enum

    Public Function GetFieldType() As String
        Dim str As String = ""
        Select Case FieldNumber
            Case FieldType.RETAILCODE
                str = "01"
            Case FieldType.TERMINALNUMBER
                str = "02"
        End Select
        Return str
    End Function
    Public Function GetFieldDataType(ByVal _fieldName As String) As FieldDataType
        Dim fldDt As FieldDataType
        Try
            Dim a As New DailySalesCls
            Dim info() As PropertyInfo = a.GetType().GetProperties()

            Dim typeVal As String = ""

            For Each b As PropertyInfo In info
                If b.Name = _fieldName Then
                    typeVal = b.PropertyType.Name
                    Exit For
                End If
            Next

            Select Case typeVal
                Case "Double"
                    fldDt = FieldDataType.isDouble
                Case "Integer"
                    fldDt = FieldDataType.isInteger
                Case Else
                    fldDt = FieldDataType.isString
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return fldDt
    End Function
    Public Function ConvertToDatatype() As String
        Dim strFormat As String = ""
        Select Case SetFieldValueType
            Case FieldDataType.isDouble
                Me.FieldValue = CType(Me.FieldValue, Double)
                strFormat = Me.FieldValue.ToString.Replace(".", "")
            Case FieldDataType.isInteger
                Me.FieldValue = CType(Me.FieldValue, Integer)
                strFormat = Me.FieldValue.ToString
            Case Else
                Me.FieldValue = CType(Me.FieldValue, String)
                strFormat = Me.FieldValue
        End Select
        Return strFormat
    End Function
    Public Function GenLineData() As String
        Dim str As String = ""
        Try
            str = GetFieldType() & ConvertToDatatype()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return str
    End Function
End Class
