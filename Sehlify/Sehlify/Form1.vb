Public Class Form1
    Dim appabrir As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        appabrir = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
        Shell(appabrir)
    End Sub

    Private Sub Browser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Browser.DocumentCompleted

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Browser.Navigate("https://google.com")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Browser.Navigate("https://google.com")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Browser.Navigate("https://startpage.com")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Browser.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("C:\Program Files (x86)\Microsoft Office\OFFICE11\WINWORD.exe")
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBox2.Text = "nada por aquí a " + MonthCalendar1.SelectionRange.End
    End Sub
End Class
