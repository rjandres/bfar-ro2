Imports MySql.Data.MySqlClient

Module dbConnect
    Public btnAction As Integer
    Public tempEmpNo As String
    Public TOAction As String
    Public SearchAction As String

    Public ConnString As String = "server=192.168.20.203;user id=bfar02;password=abc123;database=db_bfar;port=3306;characterset=utf8;"
    Public CONNECTION As New MySqlConnection(ConnString)
    Public Builder As New MySql.Data.MySqlClient.MySqlConnectionStringBuilder(ConnString)

    Public VSLEM(60) As Double
End Module