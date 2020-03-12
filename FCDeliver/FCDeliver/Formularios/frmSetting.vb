Public Class frmSetting
    Private Sub Btnrut_Click(sender As Object, e As EventArgs) Handles btnrut.Click
        Dim folder As New FolderBrowserDialog
        Dim ruta As String = String.Empty

        If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = folder.SelectedPath
            txtruta.Text = ruta
            My.Settings.rutalocal = ruta
            gRut = ruta
            My.Settings.Save()
        End If
    End Sub
End Class