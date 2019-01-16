Public Class MyRenderer
    Inherits ToolStripProfessionalRenderer
    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        e.Graphics.CompositingMode = Drawing2D.CompositingMode.SourceOver
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed

        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
        Dim c As Color = IIf(e.Item.Selected, Color.Black, Color.Transparent)
        Dim b As Color = IIf(e.Item.Selected, Color.Black, Color.Black)
        Using brush As New SolidBrush(c)
            'e.Graphics.FillRectangle(brush, rc)
            e.ToolStrip.ForeColor = b
        End Using
    End Sub

End Class