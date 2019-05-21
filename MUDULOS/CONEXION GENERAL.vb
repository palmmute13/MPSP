Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Net

Module connexion



    'Public conn As New SqlConnection("Server=192.168.0.10;Database=logdb; Uid=cliente;Pwd=3829777;")


    Public str1 As String = "Data Source=DESKTOP-EUM2MGK;Initial Catalog=logdb;Integrated Security=True"
    Public str2 As String = "Data Source=DELL_E6420;Initial Catalog=logdb;Integrated Security=True"

    Public conn As New SqlConnection(str1)








    'Public conn As New SqlConnection("Server=192.168.0.10;Database=logdb; Uid=cliente;Pwd=3829777;")

    Public Function getIp() As String

        Dim valorIp As String

        valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()

        Return valorIp

    End Function
End Module
