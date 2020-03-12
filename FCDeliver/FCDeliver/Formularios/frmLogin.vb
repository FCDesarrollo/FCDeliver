Public Class frmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBUser.Text = "miconsultormx@gmail.com"
        TBPass.Text = "jfranco@2019"
        If fOnline() = False Then
            MsgBox("Imposible abrir el sistema" &
                   vbCrLf & "Sin conexión a internet", vbExclamation, "Validación")
            Me.Close()
        End If
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If TBUser.Text <> "" And TBPass.Text <> "" Then
            If IsValidEmail(LCase(TBUser.Text)) = False Then
                MsgBox("Correo no valido.", vbInformation, "Validación")
                TBUser.Select()
            Else
                Login()
                If Not IsNothing(gUsuario) Then
                    frmPrincipal.Show()
                    Me.Close()
                End If
            End If
        Else
            MsgBox("Campos Incompletos.", vbInformation, "Validación")
        End If
    End Sub

    Private Sub Login()
        aMetodo = "datosadmin"

        aDatos = "{ " & Chr(34) & "correo" & Chr(34) & ": " & Chr(34) & TBUser.Text & Chr(34) & "," &
                    Chr(34) & "contra" & Chr(34) & ": " & Chr(34) & TBPass.Text & Chr(34) & "
                    }"

        aRespuesta = ConsumeAPI()
        If aRespuesta <> "" And ApimsjError() = False Then
            aJsonRespuesta = Newtonsoft.Json.Linq.JObject.Parse(aRespuesta)
            For Each Row In aJsonRespuesta("usuario")
                gUsuario = New cUsuario
                With gUsuario
                    .Idusuario = Row("idusuario")
                    .Nombre = Row("nombre")
                    .Apellidop = Row("apellidop")
                    .Apellidom = Row("apellidom")
                    .Cel = Row("cel")
                    .Correo = Row("correo")
                    .Password = TBPass.Text
                    .Status = Row("status")
                    .Tipo = Row("tipo")
                End With
            Next
        End If
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class