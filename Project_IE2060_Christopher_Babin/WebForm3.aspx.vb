Imports System.Data.OleDb
Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim provider As String
    Dim dataFile As String
    Dim conn As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim odr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 'Not finished
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\cbabi13\Documents\GitHub\Project\Users.accdb"
        conn = provider & dataFile
        myConnection.ConnectionString = conn
        myConnection.Open()


        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [table3]")
        odr = cmd.ExecuteReader(CommandBehavior.CloseConnection)



        Do While odr.Read
            ListBox1.Items.Add(odr.GetValue(0).ToString())
        Loop


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Move to checkout page
    End Sub
End Class