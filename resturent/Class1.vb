Imports System.Data
Imports System.Data.SqlClient
Public Class Class1
    Public Sub fillListbox(lst As ListBox, qry As String, dstname As String, columnname As String)
        da.SelectCommand = New SqlCommand
        da.SelectCommand.CommandText = qry
        da.SelectCommand.Connection = con

        dst = New DataSet
        da.Fill(dst, dstname)

        For i = 0 To dst.Tables(dstname).Rows.Count - 1
            lst.Items.Add(dst.Tables(dstname).Rows(i).Item(columnname))
        Next

    End Sub

    Public Sub fillCombobox(cmb As ComboBox, qry As String, dstname As String, columnname As String)
        da.SelectCommand = New SqlCommand
        da.SelectCommand.CommandText = qry
        da.SelectCommand.Connection = con

        dst = New DataSet
        da.Fill(dst, dstname)

        For i = 0 To dst.Tables(dstname).Rows.Count - 1
            cmb.Items.Add(dst.Tables(dstname).Rows(i).Item(columnname))
        Next

    End Sub

    Public Sub FillDGV(dgv As DataGridView, qry As String, dstname As String)
        da.SelectCommand = New SqlCommand
        da.SelectCommand.CommandText = qry
        da.SelectCommand.Connection = con

        dst = New DataSet
        da.Fill(dst, dstname)

        dgv.DataSource = dst.Tables(dstname)
    End Sub


    Public Sub selectstatement(qry As String)
        da.InsertCommand = New SqlCommand
        da.InsertCommand.CommandText = qry
        da.InsertCommand.Connection = con

        con.Open()
        da.InsertCommand.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Sub InsertStatement(qry As String)
        da.InsertCommand = New SqlCommand
        da.InsertCommand.CommandText = qry
        da.InsertCommand.Connection = con

        con.Open()
        da.InsertCommand.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Sub DeleteStatement(qry As String)
        da.DeleteCommand = New SqlCommand
        da.DeleteCommand.CommandText = qry
        da.DeleteCommand.Connection = con

        con.Open()
        da.DeleteCommand.ExecuteNonQuery()
        con.Close()
    End Sub


    Public Sub UpdateStatement(qry As String)
        da.UpdateCommand = New SqlCommand
        da.UpdateCommand.CommandText = qry
        da.UpdateCommand.Connection = con

        con.Open()
        da.UpdateCommand.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Function getnames(qry As String, dstname As String, columnname As String)
        da.SelectCommand = New SqlCommand
        da.SelectCommand.CommandText = qry
        da.SelectCommand.Connection = con
        dst = New DataSet
        da.Fill(dst, dstname)
        Dim result = dst.Tables(dstname).Rows(0).Item(columnname)
        Return result

    End Function
    Public Function getnumber(qry As String, dstname As String, columnname As String)
        da.SelectCommand = New SqlCommand
        da.SelectCommand.CommandText = qry
        da.SelectCommand.Connection = con
        dst = New DataSet
        da.Fill(dst, dstname)
        Dim result As Integer = dst.Tables(dstname).Rows(0).Item(columnname)
        Return result

    End Function


    'Validate Name(Only letters And spaces)
    Public Shared Function IsValidName(name As String) As Boolean
        If String.IsNullOrWhiteSpace(name) Then Return False
        For Each ch As Char In name
            If Not Char.IsLetter(ch) AndAlso Not Char.IsWhiteSpace(ch) Then
                Return False
            End If
        Next
        Return True
    End Function

    'Validate Phone Number (Exactly 8 digits)
    Public Shared Function IsValidPhoneNumber(phone As String) As Boolean
        If String.IsNullOrWhiteSpace(phone) Then Return False
        If phone.Length <> 8 Then Return False ' Ensures exactly 8 characters

        ' Ensure all characters are digits
        For Each ch As Char In phone
            If Not Char.IsDigit(ch) Then
                Return False
            End If
        Next

        Return True
    End Function


    'Validate Email(Basic Check for '@' and '.')
    Public Shared Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) OrElse Not (email.Contains("@") AndAlso email.Contains("gmail.com")) Then
            Return False
        End If
        Return True
    End Function


    Public Shared Function IsNumericOnly(value As String) As Boolean
        Return value.All(Function(c) Char.IsDigit(c))
    End Function













End Class
