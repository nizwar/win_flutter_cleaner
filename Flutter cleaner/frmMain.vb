Imports System.IO
Public Class FrmUtama
    Private Sub btnPick_Click(sender As Object, e As EventArgs) Handles btnPick.Click
        fldBrowser.ShowDialog(Me)
        If fldBrowser.SelectedPath = "" Then Return
        txtPath.Text = fldBrowser.SelectedPath
        openPath(fldBrowser.SelectedPath)
    End Sub

    Private Sub FrmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub lstFolders_DoubleClick(sender As Object, e As EventArgs) Handles lstFolders.DoubleClick
        Dim dirPath As String = lstFolders.Items.Item(lstFolders.SelectedIndex)
        Dim cmdCommand As String = "cmd /k " + dirPath.Substring(0, 2) + " & cd " + """" + dirPath + """" + " & flutter clean & exit"

        lblInfo.Text = "Run flutter clean on " + dirPath
        Shell(cmdCommand, AppWinStyle.Hide, True)
        lblInfo.Text = "Flutter clean finished!"
        MsgBox("Flutter clean success!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub openPath(path As String)
        lstFolders.Items.Clear()
        Try
            For Each dir As String In Directory.GetDirectories(path)
                lstFolders.Items.Add(dir)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCleanAll_Click(sender As Object, e As EventArgs) Handles btnCleanAll.Click
        Dim i As Integer = 0
        pbLoading.Maximum = lstFolders.Items.Count
        For Each dirPath As String In lstFolders.Items
            Dim cmdCommand As String = "cmd /k " + dirPath.Substring(0, 2) + " & cd " + """" + dirPath + """" + " & flutter clean & exit"
            Console.WriteLine(cmdCommand)
            lblInfo.Text = "Run flutter clean on " + dirPath
            Application.DoEvents()
            Shell(cmdCommand, AppWinStyle.Hide, True)
            pbLoading.Value = i
            Application.DoEvents()
            i = i + 1
        Next
        lblInfo.Text = "Flutter clean finished!"
        pbLoading.Value = lstFolders.Items.Count
    End Sub

End Class
