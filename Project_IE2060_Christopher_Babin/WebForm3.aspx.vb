Imports System.Data.OleDb
Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        String connString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\Users\\KevinDW\\Desktop\\dotNET\\Week 5\\Prak1\\demo1.accdb";

        OleDbConnection conn = New OleDbConnection(connString);

        conn.Open();

        String sqlCmd = "SELECT CursusNaam FROM tblCursus";

        OleDbCommand cmd = New OleDbCommand(sqlCmd, conn);

        Using (OleDBDataReader reader = cmd.ExecuteReader())
        {
            ListBox1.Items.Add(reader);
        }

        conn.Close();
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class