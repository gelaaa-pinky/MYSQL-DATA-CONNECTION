Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.1;userid=root;password='';database=test"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.1;userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM test.edata WHERE username = '" & input_username.Text & "' and password = '" & input_password.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicate")

            Else
                MessageBox.Show("Username and Password are incorrect")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class