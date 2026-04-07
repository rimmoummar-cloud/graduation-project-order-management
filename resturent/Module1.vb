Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public iddelete As Integer
    Public sqlobj As New Class1
    Public da As New SqlDataAdapter
    Public dst As DataSet
    Public con As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
    'Data Source = DESKTOP - P6D2UFD \ MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True
    Public categno As Integer
    Public posnumber As Integer
    Public offid As Integer
    Public suppno As Integer
    Public offerper As Integer
    Public offerpersent As Integer
    Public idstaff As Integer

End Module
