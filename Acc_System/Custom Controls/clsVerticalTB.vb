Public Class clsVerticalTB
    Inherits System.Windows.Forms.Control

    Public Sub New()
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim g As Graphics = e.Graphics

        Using format As New StringFormat(StringFormatFlags.DirectionVertical)
            Using brush As New SolidBrush(ForeColor)
                g.DrawString(Text, Font, brush, 0, 0, format)
            End Using
        End Using
    End Sub

End Class
