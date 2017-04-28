Imports System.Data.OleDb
Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim provider As String
    Dim dataFile As String
    Dim conn As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 'Not finished
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\The Meme Master\Documents\GitHub\Project\Users.accdb" 'CHRIS: Replace what is double quoted with: "C:\Users\cbabi13\Documents\GitHub\Project\Users.accdb"
        conn = provider & dataFile
        myConnection.ConnectionString = conn
        myConnection.Open()


        'Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [table3]", myConnection)
        'Dim dr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)



        ' Do While dr.Read
        'ListBox1.Items.Add(dr.GetValue(1).ToString())
        'Loop


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Move to checkout page
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Protected Sub DataList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataList1.SelectedIndexChanged

    End Sub
End Class