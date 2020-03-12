Imports System.ComponentModel

Public Class frmFecha
    Private _mFecha As Date
    Private _mFechaMin As Date
    Public Property MFecha As Date
        Get
            Return _mFecha
        End Get
        Set(ByVal value As Date)
            _mFecha = value
        End Set
    End Property

    Public Property MFechaMin As Date
        Get
            Return _mFechaMin
        End Get
        Set(ByVal value As Date)
            _mFechaMin = value
        End Set
    End Property

    Private BanClosing As Boolean
    Public WithEvents meuCalendario As MyCalendar
    Private Sub FrmFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BanClosing = False
        meuCalendario = New MyCalendar()
        meuCalendario.Location = New System.Drawing.Point(0, 0)
        meuCalendario.Name = "mcFecha"
        AddHandler meuCalendario.DoubleClick, AddressOf MetodoASerExecutadoNoDoubleClick
        Me.Controls.Add(Me.meuCalendario)

        meuCalendario.MinDate = IIf(MFechaMin = Date.MinValue, Primer_Dia_Mes(MFecha), MFechaMin)
        meuCalendario.MaxDate = Ultimo_Dia_Mes(MFecha)
        meuCalendario.SelectionStart = MFecha
        meuCalendario.SelectionEnd = MFecha

    End Sub

    Sub MetodoASerExecutadoNoDoubleClick()
        ' Codigo que deverá ser executado no DoubleClick
        MFecha = meuCalendario.SelectionStart
        BanClosing = True
        Me.Close()
    End Sub

    Private Sub frmFecha_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If BanClosing = False Then
            If MessageBox.Show(
            "¿Desea cerrar el formulario sin asignar fecha?", "Cerrar el formulario",
            MessageBoxButtons.YesNo) = DialogResult.No Then

                ' Cancelamos el cierre del formulario
                e.Cancel = True
            Else
                _mFecha = Date.MinValue.Date
            End If
        End If
    End Sub

End Class