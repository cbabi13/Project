Imports System.Data.OleDb
Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 'Not finished
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\cbabi13\Documents\Users.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString


        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [table3]")

        OleDbCommand cmd = New OleDbCommand(sqlCmd, conn)

        Using (OleDbDataReader reader = cmd.ExecuteReader())
        {
            ListBox1.Items.Add(reader)
        }

        conn.Close()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class