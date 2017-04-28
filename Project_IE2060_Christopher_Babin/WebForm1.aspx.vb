Imports System.Data.OleDb
Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\The Meme Master\Documents\GitHub\Project\Users.accdb" 'CHRIS: Replace what is double quoted with: "C:\Users\cbabi13\Documents\GitHub\Project\Users.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [table1] WHERE [Username] = '" & TextBox1.Text & "' AND [Password] = '" & TextBox2.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Dim userFound As Boolean = False

        While dr.Read
            userFound = True
        End While

        If userFound = True Then
            Server.Transfer("WebForm3.aspx", True)
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        End If
    End Sub


    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Server.Transfer("WebForm2.aspx", True)
    End Sub
End Class