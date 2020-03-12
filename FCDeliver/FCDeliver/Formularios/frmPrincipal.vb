Public Class frmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserForm(Me, "Inicio")
        If My.Settings.rutalocal = "" Then
            frmSetting.ShowDialog()
            If My.Settings.rutalocal = "" Then
                MsgBox("No ha seleccionado ninguna ruta." & vbCrLf & "El sistema se cerrara", vbInformation, "Validación")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click
        Dim frm As New frmBitacora
        If fOnline() = False Then
            MsgBox("Imposible abrir el formulario" &
                   vbCrLf & "Sin conexión a internet", vbExclamation, "Validación")
        Else
            frm.ShowDialog()
        End If
        frm = Nothing
    End Sub
End Class