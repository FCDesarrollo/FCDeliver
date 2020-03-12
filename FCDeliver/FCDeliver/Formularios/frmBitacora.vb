Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frmBitacora
    Private bBandLoad As Boolean
    Private RFCempresa As String
    Private Sub FrmBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserForm(Me, "Bitacora")
        Application.EnableVisualStyles()
        bBandLoad = True
        Carga_Servicios()
        Carga_Empresas()
        'cbejercicio.SelectedIndex = 0
        bBandLoad = False
    End Sub

    Private Sub Carga_Empresas()
        Dim bEmpresa As cEmpresa
        gUsuario.Empresas_Usuarios()
        For Each bEmpresa In gUsuario.Empresas
            dgEmpresas.Rows.Add(bEmpresa.Idempresa, bEmpresa.Nombreempresa)
        Next bEmpresa
        dgEmpresas.ClearSelection()
    End Sub



    Private Sub dgEmpresas_SelectionChanged(sender As Object, e As EventArgs) Handles dgEmpresas.SelectionChanged
        Dim fil As Integer
        If bBandLoad = True Then Exit Sub
        If dgEmpresas.SelectedRows.Count > 0 Then
            fil = dgEmpresas.CurrentRow.Index
            dgServiciosMen.Rows.Clear()
            Carga_Ejercicios(CInt(dgEmpresas.Item(0, fil).Value))
            'Carga_serviciosEmpresa(CInt(dgEmpresas.Item(0, fil).Value))
            'gUsuario.Servicios_Empresa(CInt(dgEmpresas.Item(0, fil).Value))
        End If
    End Sub

    Private Sub Carga_Ejercicios(ByVal eIDemp As Integer)
        cbejercicio.Items.Clear()
        aMetodo = "listaejercicios"

        aDatos = "{ " & Chr(34) & "correo" & Chr(34) & ": " & Chr(34) & gUsuario.Correo & Chr(34) & "," &
            Chr(34) & "contra" & Chr(34) & ": " & Chr(34) & gUsuario.Password & Chr(34) & "," &
            Chr(34) & "idempresa" & Chr(34) & ": " & Chr(34) & eIDemp & Chr(34) & "
                    }"
        aRespuesta = ConsumeAPI()
        If aRespuesta <> "" And ApimsjError() = False Then
            aJsonRespuesta = Newtonsoft.Json.Linq.JObject.Parse(aRespuesta)
            For Each Row In aJsonRespuesta("ejercicios")
                cbejercicio.Items.Add(Row("ejercicio"))
            Next
            If cbejercicio.Items.Count > 0 Then
                cbejercicio.SelectedIndex = 0
            Else
                cbejercicio.Items.Add(Year(Now))
                cbejercicio.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Carga_serviciosEmpresa(ByVal bIdEmpresa As Integer)
        Dim bempresa As cEmpresa, bServicio As cServicio, bBitacora As cBitacora
        Dim bfila As Integer, bColumG As Integer, bColumE As Integer
        dgServiciosMen.Rows.Clear()

        For Each bempresa In gUsuario.Empresas
            If bempresa.Idempresa = bIdEmpresa Then
                RFCempresa = bempresa.Rfc

                For Each bServicio In bempresa.ServiciosMen

                    If bServicio.Codigoservicio = "COMPROBANTES" Then

                    End If
                    bServicio.Bitacora_servicio(cbejercicio.Text, bIdEmpresa)
                    dgServiciosMen.Rows.Add(bServicio.Id,
                                         bServicio.Codigoservicio, bServicio.Nombreservicio,
                                        fGetTipo_Servicio(bServicio.Tipo), fGetTipo_Servicio(bServicio.Actualizable), bServicio.Estado)
                    bfila = dgServiciosMen.Rows.Count - 1
                    'dgServiciosMen.Item(bColum, bfila).Value = 2

                    For Each bBitacora In bServicio.SBitacora
                        If bServicio.Codigoservicio = bBitacora.Tipodocumento Then
                            bColumG = bBitacora.Periodo + 6 + (bBitacora.Periodo - 1)
                            bColumE = bColumG + 1
                            dgServiciosMen.Item(bColumG, bfila).Value = bBitacora.Fechamodifiacion.Day
                            dgServiciosMen.Item(bColumG, bfila).ToolTipText = bBitacora.Fechamodifiacion
                            dgServiciosMen.Item(bColumG, bfila).Tag = bBitacora.NombrearchivoG
                            If bBitacora.Status = 1 Then
                                dgServiciosMen.Item(bColumE, bfila).Value = bBitacora.Fechacorte.Day
                                dgServiciosMen.Item(bColumE, bfila).ToolTipText = bBitacora.Fechacorte
                                dgServiciosMen.Item(bColumE, bfila).Tag = bBitacora.NombrearchivoG
                            End If
                        End If
                    Next bBitacora
                Next bServicio
                dgServiciosMen.ClearSelection()
                Exit For
            End If
        Next bempresa
    End Sub

    Private Sub frmBitacora_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(gUsuario.Empresas) Then
            gUsuario.Empresas.Clear()
        End If
    End Sub

    Private Sub DgServiciosMen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgServiciosMen.CellContentClick
        Dim fil As Integer, fcol As Integer
        If dgServiciosMen.CurrentCell.ColumnIndex > 5 Then
            fil = dgServiciosMen.CurrentRow.Index
            fcol = dgServiciosMen.CurrentCell.ColumnIndex
            addServicioEntrega(fil, fcol)
        End If
        dgServiciosMen.ClearSelection()
    End Sub

    Private Sub Remove_Registro(ByVal rCol As Integer, ByVal rFil As Integer)
        Dim dPeriodo As Integer, dEjercicio As Integer, sDesmarco As Boolean
        If Not rCol Mod 2 = 0 Then Exit Sub
        If dgServiciosMen.Item(rCol, rFil).Value.ToString = "" Then Exit Sub
        dPeriodo = ((rCol) / 2) - 3
        dEjercicio = cbejercicio.Text
        If dgServiciosMen.Item(rCol, rFil).Style.BackColor = Color.GreenYellow Then
            sDesmarco = deleServicioEntrega(dgServiciosMen.Item(1, rFil).Value, dPeriodo, dEjercicio)
        Else
            sDesmarco = Desmarca_bitacora(dgServiciosMen.Item(1, rFil).Value, dPeriodo, dEjercicio)
            If sDesmarco = True Then dgServiciosMen.Item(rCol, rFil).ToolTipText = ""
        End If

        If sDesmarco = True Then
            dgServiciosMen.Item(rCol, rFil).Style.BackColor = Color.White
            dgServiciosMen.Item(rCol, rFil).Value = ""
            If dgServiciosMen.Item(rCol, rFil).ToolTipText <> "" Then
                dgServiciosMen.Item(rCol, rFil).Value = CDate(dgServiciosMen.Item(rCol, rFil).ToolTipText).Day
            End If
        End If

        dgServiciosMen.ClearSelection()
    End Sub

    Private Function deleServicioEntrega(ByVal dCodSer As String, dPeriodo As Integer, dEjercicio As Integer) As Boolean
        deleServicioEntrega = False
        If dgentregado.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgentregado.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells(0).Value = dCodSer And
                        Fila.Cells(1).Value = dPeriodo And
                        Fila.Cells(2).Value = dEjercicio Then
                        dgentregado.Rows.Remove(Fila)
                        deleServicioEntrega = True
                        Exit For
                    End If
                End If
            Next
        End If
    End Function

    Private Sub addServicioEntrega(ByVal aFil As Integer, ByVal aCol As Integer)
        Dim acodSer As String, aperiodo As Integer, aejercicio As Integer
        Dim nomArchivoG As String, nomArchivoE As String
        Dim afechaentre As Date, afechacorte As Date, fPeriodo As String
        Dim frm As New frmFecha

        If dgServiciosMen.Item(aCol, aFil).Value.ToString = "" Then Exit Sub
        If aCol Mod 2 = 0 Then Exit Sub
        frm.MFechaMin = Date.MinValue
        If Not IsNothing(dgServiciosMen.Item(aCol + 1, aFil).Value) Then
            If dgServiciosMen.Item(aCol + 1, aFil).ToolTipText <> "" Then
                frm.MFechaMin = dgServiciosMen.Item(aCol + 1, aFil).ToolTipText
            End If
            'frm.MFecha.MinDate = Primer_Dia_Mes(MFecha)
            If dgServiciosMen.Item(aCol + 1, aFil).Value.ToString <> "" Then
                If dgServiciosMen.Item(aCol + 1, aFil).Value >= dgServiciosMen.Item(aCol, aFil).Value Then
                    Exit Sub
                End If
            End If
        End If



        acodSer = dgServiciosMen.Item(1, aFil).Value.ToString
        aperiodo = ((aCol + 1) / 2) - 3
        aejercicio = cbejercicio.Text
        nomArchivoG = dgServiciosMen.Item(aCol, aFil).Tag
        nomArchivoE = ""
        afechacorte = CDate(dgServiciosMen.Item(aCol, aFil).ToolTipText)
        'afechacorte = Date.MinValue.Date
        If acodSer = "COMPROBANTES" Or acodSer = "POLIZAS" Then

            frm.MFecha = afechacorte.Date
            frm.ShowDialog()
            If frm.MFecha = Date.MinValue.Date Then
                MsgBox("No se agrego la fecha de corte al servicio para entregar.", vbInformation,
                                "Información")
                Exit Sub
            Else
                afechacorte = frm.MFecha
            End If

        End If

        fPeriodo = Strings.Format(aperiodo, "00")
        nomArchivoE = RFCempresa & "_" & Strings.Right(CStr(aejercicio), 2) & fPeriodo & "_" & Mid(acodSer, 1, 3) & "_ENT"
        afechaentre = Date.Now

        If ExisteEntregado(acodSer, aperiodo, aejercicio) = False Then
            dgServiciosMen.Item(aCol + 1, aFil).Style.BackColor = Color.GreenYellow
            dgServiciosMen.Item(aCol + 1, aFil).Value = afechacorte.Day
            dgentregado.Rows.Add(acodSer, aperiodo, aejercicio,
                                 nomArchivoG, nomArchivoE,
                                 IIf(afechacorte = Date.MinValue, "", afechacorte),
                                 afechaentre)
        End If
    End Sub

    Private Function ExisteEntregado(ByVal eCodSer As String, ByVal ePeriodo As Integer, ByVal eEjercicio As Integer) As Boolean
        ExisteEntregado = False
        If dgentregado.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgentregado.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells(0).Value = eCodSer And
                        Fila.Cells(1).Value = ePeriodo And
                        Fila.Cells(2).Value = eEjercicio Then
                        ExisteEntregado = True
                        Exit For
                    End If
                End If
            Next
        End If
    End Function

    Private Function Marca_Documento(ByVal dEjercicio As Integer,
                                      ByVal dPeriodo As Integer,
                                      ByVal dcodser As String,
                                      ByVal dnomAr As String, dfechacorte As Date) As Boolean
        Dim cNewEntrega As cEntrega
        Marca_Documento = False

        cNewEntrega = New cEntrega
        Try
            cNewEntrega.Correo = gUsuario.Correo
            cNewEntrega.Contra = gUsuario.Password
            cNewEntrega.Rfc = RFCempresa
            cNewEntrega.Tipodocumento = dcodser
            cNewEntrega.Periodo = dPeriodo
            cNewEntrega.Ejercicio = dEjercicio
            cNewEntrega.Status = 1
            cNewEntrega.IdusuarioE = gUsuario.Idusuario
            cNewEntrega.Fechaentregado = Date.Now 'dfechacorte
            cNewEntrega.FechaCorte = dfechacorte

            Marcar_Disponible(cNewEntrega, "MarcaBitacora")
        Catch ex As Exception
            Marca_Documento = False
        End Try

    End Function
    Private Function CrearDocumento(ByVal dEjercicio As Integer, ByVal dPeriodo As Integer, ByVal dcodser As String, ByVal dfechacorte As Date) As String
        Dim appExcel As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim wbExcel As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim wsExcel As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Dim rutaG As String, rutalibro As String
        Dim nombref As String, x As Integer, col As Integer
        CrearDocumento = ""
        appExcel = New Microsoft.Office.Interop.Excel.Application
        appExcel.Visible = False
        appExcel.DisplayAlerts = False

        Dim cNewReporte As cReporte, cNewDatos As cDatos
        Dim cNewEntrega As cEntrega, rRes As Collection

        nombref = RFCempresa & "_" & Strings.Right(CStr(dEjercicio), 2) & Strings.Format(dPeriodo, "00") & "_" & Mid(dcodser, 1, 3)
        CrearDocumento = nombref & ".pdf"

        rutaG = gRut & "\" & RFCempresa & "\" & gRuComple & "\" & UCase(Mid(dcodser, 1, 3)) & "\" &
            Strings.Right(CStr(dEjercicio), 2) & "\" & Format(dPeriodo, "00") &
            "\pdfs\relacion\"

        rutalibro = rutaG & RFCempresa & "_" & Strings.Right(CStr(dEjercicio), 2) & Strings.Format(dPeriodo, "00") & ".xlsx"

        Try

            cNewReporte = New cReporte
            cNewEntrega = New cEntrega

            cNewEntrega.Correo = gUsuario.Correo
            cNewEntrega.Contra = gUsuario.Password
            cNewEntrega.Rfc = RFCempresa
            cNewEntrega.Tipodocumento = dcodser
            cNewEntrega.Periodo = dPeriodo
            cNewEntrega.Ejercicio = dEjercicio
            cNewEntrega.Status = 1
            cNewEntrega.IdusuarioE = gUsuario.Idusuario
            cNewEntrega.Fechaentregado = Date.Now 'dfechacorte
            cNewEntrega.Fechacorte = dfechacorte

            wbExcel = appExcel.Workbooks.Open(rutalibro)
            wsExcel = wbExcel.ActiveSheet

            With wsExcel
                cNewReporte.Nomempresa = .Cells(1, 1).value.ToString
                cNewReporte.Titulo = "Relación de " & dcodser
                cNewReporte.Complemento = UCase(MonthName(dPeriodo)) & " del " & dEjercicio
                cNewReporte.ColA = .Cells(3, 1).value.ToString
                cNewReporte.ColB = .Cells(3, 2).value.ToString
                cNewReporte.ColC = .Cells(3, 3).value.ToString
                cNewReporte.ColD = .Cells(3, 4).value.ToString
                cNewReporte.ColE = .Cells(3, 5).value.ToString
                cNewReporte.ColF = .Cells(3, 6).value.ToString
                'cNewReporte.ColG = .Cells(3, 7).value.ToString


                .Columns("A:I").Sort(key1:= .Range("A4"),
      order1:=Excel.XlSortOrder.xlDescending, header:=Excel.XlYesNoGuess.xlYes)
                x = 4
                col = IIf(dcodser = "COMPROBANTES", 10, 2)
                Do While .Cells(x, 1).value <> ""
                    If .Cells(x, 1).value > dfechacorte Then
                        .Rows(x).Delete()
                        x -= 1
                    Else
                        If Not cNewReporte.Tipos.ContainsKey(.Cells(x, col).value.ToString) Then
                            cNewReporte.Tipos.Add(.Cells(x, col).value.ToString, .Cells(x, col).value.ToString)
                        End If
                        cNewDatos = New cDatos
                        cNewDatos.DatoA = .Cells(x, 1).value
                        cNewDatos.DatoB = .Cells(x, 2).value
                        cNewDatos.DatoC = .Cells(x, 3).value
                        cNewDatos.DatoD = .Cells(x, 4).value
                        cNewDatos.DatoE = .Cells(x, 5).value
                        cNewDatos.DatoF = .Cells(x, 6).value
                        cNewDatos.DatoG = .Cells(x, 7).value

                        cNewDatos.Datocompara = .Cells(x, col).value


                        cNewReporte.Datos.Add(cNewDatos)
                    End If
                    x += 1
                Loop
                .PageSetup.Zoom = False
                .PageSetup.FitToPagesTall = False
                .PageSetup.FitToPagesWide = 1
                .PageSetup.RightMargin = 4
                .PageSetup.LeftMargin = 4
                .PageSetup.BottomMargin = 4
                .PageSetup.TopMargin = 9
                .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape

                '.Columns("A:G").AutoFit
            End With

            '    wbExcel.SaveAs(rutaG & nombref & ".xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, False, False,
            '0, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing)

            appExcel.ScreenUpdating = False
            appExcel.DisplayAlerts = False

            'wbExcel.ExportAsFixedFormat(Type:=Excel.XlFixedFormatType.xlTypePDF,
            '                             Filename:=rutaG & UCase(nombref),
            '                             Quality:=Excel.XlFixedFormatQuality.xlQualityStandard,
            '                             IncludeDocProperties:=True, IgnorePrintAreas:=False,
            '                             OpenAfterPublish:=False)


            wsExcel = Nothing
            wbExcel.Close()
            wbExcel = Nothing
            appExcel.Quit()
            rRes = New Collection
            rRes = Separar_Reporte(cNewReporte, rutaG & nombref, dfechacorte)
            If Not IsNothing(rRes) Then
                If rRes.Count > 0 Then
                    cNewEntrega.Documento = rRes
                    Marcar_Disponible(cNewEntrega, "updateBitacora")
                End If
            End If
        Catch ex As Exception
            CrearDocumento = ""
            MsgBox(ex.Message)
            'My.Computer.FileSystem.WriteAllText(FC_RutaModulos & "\" & aemp & "\COM\errores.log", Format(Now, "dd/MM/yyy HH:mm") & " - " & ex.Message & vbCrLf, True)
        Finally
            releaseObject(wsExcel)
            releaseObject(wbExcel)
            releaseObject(appExcel)
        End Try


    End Function

    Private Function Separar_Reporte(ByVal sReporte As cReporte, ByVal sRut As String, ByVal sCorte As Date) As Collection
        Dim appExcel As Excel.Application = Nothing
        Dim wbExcel As Excel.Workbook = Nothing
        Dim wsExcel As Excel.Worksheet = Nothing


        Dim rReg As New Collection, dDoc As cDocumento
        appExcel = New Excel.Application
        appExcel.Visible = False
        appExcel.DisplayAlerts = False

        Dim sTipo As String, x As Integer, d As cDatos

        Try
            For t = 0 To sReporte.Tipos.Count - 1
                sTipo = sReporte.Tipos.Keys(t)

                wbExcel = appExcel.Workbooks.Add
                wsExcel = wbExcel.ActiveSheet

                With wsExcel


                    .Cells(3, 1).value = sReporte.ColA
                    .Cells(3, 2).value = sReporte.ColB
                    .Cells(3, 3).value = sReporte.ColC
                    .Cells(3, 4).value = sReporte.ColD
                    .Cells(3, 5).value = sReporte.ColE
                    .Cells(3, 6).value = sReporte.ColF
                    '.Cells(3, 7).value = sReporte.ColG

                    .Range("A3:G3").Interior.ColorIndex = 16
                    .Range("A3:G3").Font.Bold = True

                    x = 4
                    For Each d In sReporte.Datos
                        If sTipo = d.Datocompara Then
                            .Cells(x, 1).value = "'" & d.DatoA
                            .Cells(x, 2).value = d.DatoB
                            .Cells(x, 3).value = d.DatoC
                            .Cells(x, 4).value = d.DatoD
                            .Cells(x, 5).value = CDbl(d.DatoE)

                            .Cells(x, 6).value = d.DatoF
                            .Hyperlinks.Add(Anchor:= .Range("F" & CStr(x)),
                                                        Address:=d.DatoG,
                                                        TextToDisplay:=d.DatoF)
                            '.Cells(x, 7).value = d.DatoG
                            x += 1
                        End If
                    Next
                    .Columns(5).NumberFormat = "#,##0.00"
                    .PageSetup.Zoom = False
                    .PageSetup.FitToPagesTall = False
                    .PageSetup.FitToPagesWide = 1
                    .PageSetup.RightMargin = 4
                    .PageSetup.LeftMargin = 4
                    .PageSetup.BottomMargin = 4
                    .PageSetup.TopMargin = 9
                    .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape

                    .Columns("A:G").AutoFit
                    .Cells(1, 1).value = sReporte.Nomempresa
                    .Cells(2, 1).value = sReporte.Titulo & " " & UCase(sTipo) & " de " & sReporte.Complemento

                    appExcel.ScreenUpdating = False
                    appExcel.DisplayAlerts = False

                    dDoc = New cDocumento
                    dDoc.NombreE = Path.GetFileName(sRut & "_" & UCase(sTipo)) & ".pdf"
                    dDoc.FechaCorte = sCorte
                    rReg.Add(dDoc)

                    wbExcel.ExportAsFixedFormat(Type:=Excel.XlFixedFormatType.xlTypePDF,
                                                 Filename:=sRut & "_" & UCase(sTipo),
                                                 Quality:=Excel.XlFixedFormatQuality.xlQualityStandard,
                                                 IncludeDocProperties:=True, IgnorePrintAreas:=False,
                                                 OpenAfterPublish:=False)
                    wsExcel = Nothing
                    wbExcel.Close()
                    wbExcel = Nothing
                End With
            Next t
            appExcel.Quit()
        Catch ex As Exception
            rReg.Clear()
            MsgBox("Error", vbExclamation, "Validación")
        Finally
            releaseObject(wsExcel)
            releaseObject(wbExcel)
            releaseObject(appExcel)
            Separar_Reporte = rReg
        End Try

    End Function

    Private Sub BtnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim fil As Integer
        If Valida_Entregas() Then
            pbEnt.Visible = True
            lEnt.Visible = True
            Envia_entregas()
            dgentregado.Rows.Clear()
            fil = dgEmpresas.CurrentRow.Index
            Carga_serviciosEmpresa(CInt(dgEmpresas.Item(0, fil).Value))
            pbEnt.Visible = False
            lEnt.Visible = False
        Else
            MsgBox("Existen entregas sin fecha de corte.", vbExclamation, "Validación")
        End If
    End Sub

    Private Sub Envia_entregas()
        Dim Cuenta As Integer = 1
        Dim nomE As String, sMarco As Boolean
        If dgentregado.Rows.Count > 0 Then
            pbEnt.Minimum = 0
            pbEnt.Maximum = dgentregado.Rows.Count + 1
            pbEnt.Value = 0
            pbEnt.Refresh()
            Application.DoEvents()
            For Each Fila As DataGridViewRow In dgentregado.Rows
                pbEnt.Value = Cuenta
                pbEnt.Refresh()
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
                If Not Fila Is Nothing Then
                    If Fila.Cells(0).Value = "COMPROBANTES" Or Fila.Cells(0).Value = "POLIZAS" Then
                        nomE = CrearDocumento(Fila.Cells(2).Value,
                                       Fila.Cells(1).Value, Fila.Cells(0).Value, Fila.Cells(5).Value)
                    Else
                        sMarco = Marca_Documento(Fila.Cells(2).Value,
                                       Fila.Cells(1).Value, Fila.Cells(0).Value, Fila.Cells(3).Value, Fila.Cells(5).Value)

                        'nomE = Path.GetFileName(nomE)
                    End If
                    'If nomE <> "" Then
                    '    Marcar_Disponible(Fila.Cells(0).Value,
                    '                      Fila.Cells(1).Value, Fila.Cells(2).Value,
                    '                      nomE, Fila.Cells(5).Value)
                    'End If
                End If
                Cuenta += 1
            Next
            pbEnt.Value = dgentregado.Rows.Count
            pbEnt.Refresh()
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
        End If
    End Sub
    Private Function Valida_Entregas() As Boolean
        Valida_Entregas = True
        If dgentregado.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgentregado.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells(5).Value = Date.MinValue Then
                        Valida_Entregas = False
                        Exit For
                    End If
                End If
            Next
        End If
    End Function

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.WaitForPendingFinalizers()
            GC.Collect()
        End Try
    End Sub

    Private Sub Marcar_Disponible(ByVal mTipo As cEntrega, ByVal mMetodo As String)
        Dim sTa As Integer = 1
        aMetodo = mMetodo


        aDatos = Newtonsoft.Json.JsonConvert.SerializeObject(mTipo)

        aRespuesta = ConsumeAPI()
        If aRespuesta <> "" And ApimsjError() = False Then
            If aRespuesta = "true" Then

            End If

        End If
    End Sub

    Private Sub Cbejercicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbejercicio.SelectedIndexChanged
        Dim fil As Integer
        If cbejercicio.Items.Count > 0 And cbejercicio.SelectedIndex >= 0 Then
            fil = dgEmpresas.CurrentRow.Index
            Carga_serviciosEmpresa(CInt(dgEmpresas.Item(0, fil).Value))
        End If
    End Sub

    Private Sub dgServiciosMen_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgServiciosMen.CellContentDoubleClick
        Dim fil As Integer, fcol As Integer
        If dgServiciosMen.CurrentCell.ColumnIndex > 5 Then
            fil = dgServiciosMen.CurrentRow.Index
            fcol = dgServiciosMen.CurrentCell.ColumnIndex
            Remove_Registro(fcol, fil)
        End If
    End Sub

    Private Function Desmarca_bitacora(mTipo As String, mPeriodo As Integer, mEjercicio As Integer) As Boolean
        Dim mClass As cEntrega
        Desmarca_bitacora = False
        Dim sTa As Integer = 0

        'If mElimina = True Then
        '    aMetodo = "updateBitacora"
        'Else
        aMetodo = "MarcaBitacora"
        'End If
        mClass = New cEntrega
        mClass.Correo = gUsuario.Correo
        mClass.Contra = gUsuario.Password
        mClass.Rfc = RFCempresa
        mClass.Tipodocumento = mTipo
        mClass.Periodo = mPeriodo
        mClass.Ejercicio = mEjercicio
        mClass.IdusuarioE = gUsuario.Idusuario
        mClass.Status = sTa
        mClass.Fechaentregado = Date.MinValue

        aDatos = Newtonsoft.Json.JsonConvert.SerializeObject(mClass)

        aRespuesta = ConsumeAPI()
        If aRespuesta <> "" And ApimsjError() = False Then
            If aRespuesta = "true" Then
                Desmarca_bitacora = True
            End If

        End If

        'aDatos = "{ " & Chr(34) & "correo" & Chr(34) & ": " & Chr(34) & gUsuario.Correo & Chr(34) & "," &
        '            Chr(34) & "contra" & Chr(34) & ": " & Chr(34) & gUsuario.Password & Chr(34) & "," &
        '            Chr(34) & "rfc" & Chr(34) & ": " & Chr(34) & RFCempresa & Chr(34) & "," &
        '            Chr(34) & "Tipodocumento" & Chr(34) & ": " & Chr(34) & mTipo & Chr(34) & "," &
        '            Chr(34) & "Periodo" & Chr(34) & ": " & Chr(34) & mPeriodo & Chr(34) & "," &
        '            Chr(34) & "Ejercicio" & Chr(34) & ": " & Chr(34) & mEjercicio & Chr(34) & "," &
        '            Chr(34) & "IdusuarioE" & Chr(34) & ": " & Chr(34) & gUsuario.Idusuario & Chr(34) & "," &
        '            Chr(34) & "Status" & Chr(34) & ": " & Chr(34) & sTa & Chr(34) & "
        '            }"

    End Function

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub DgEmpresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpresas.CellContentClick

    End Sub
End Class