Imports System.Data.OleDb
Imports System.Windows.Navigation
Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim getInfo As System.IO.FileInfo
        getInfo = My.Computer.FileSystem.GetFileInfo("C:\Users\The Meme Master\Documents\GitHub\Project\Users.accdb") 'CHRIS: Replace what is double quoted with: "C:\Users\cbabi13\Documents\GitHub\Project\Users.accdb"
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = getInfo.FullName
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        Dim employee As String = ""

        If (CheckBox1.Checked) Then
            employee = "yes"
        Else
            employee = "no"
        End If
        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO [table1] VALUES (" & TextBox1.Text & ", " & TextBox2.Text & ", " & employee & ")", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        'change site to webform3
    End Sub


End Class