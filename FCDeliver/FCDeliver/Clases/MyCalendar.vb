Public Class MyCalendar
    Inherits MonthCalendar

    Private m_LastClickPosition As Point
    Private m_LastClickTime As Long
    Private m_LastClickRaisedDoubleClick As Boolean

    Public Shadows Event DoubleClick(
        ByVal sender As Object,
        ByVal e As EventArgs
    )

    Protected Overrides Sub OnDoubleClick(ByVal e As EventArgs)
        RaiseEvent DoubleClick(Me, e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            If _
                Not m_LastClickRaisedDoubleClick AndAlso
                Now.Ticks - m_LastClickTime <=
                SystemInformation.DoubleClickTime * 10000 AndAlso
                IsInDoubleClickArea(m_LastClickPosition, Cursor.Position) _
            Then
                OnDoubleClick(EventArgs.Empty)
                m_LastClickRaisedDoubleClick = True
            Else
                m_LastClickRaisedDoubleClick = False
            End If
            m_LastClickPosition = Cursor.Position
            m_LastClickTime = Now.Ticks
        End If
        MyBase.OnMouseDown(e)
    End Sub

    Private Function IsInDoubleClickArea(
        ByVal Point1 As Point,
        ByVal Point2 As Point
    ) As Boolean
        Return _
            Math.Abs(Point1.X - Point2.X) <= SystemInformation.DoubleClickSize.Width AndAlso
            Math.Abs(Point1.Y - Point2.Y) <= SystemInformation.DoubleClickSize.Height
    End Function
End Class
