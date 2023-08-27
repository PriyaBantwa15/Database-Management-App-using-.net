Public Class Form1
    Private Sub Form2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form2ToolStripMenuItem.Click
        Me.IsMdiContainer = True
        Form2.MdiParent = Me
        Form2.Show()
    End Sub
    Private Sub Form3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form3ToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub
    Private Sub Form4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form4ToolStripMenuItem.Click
        Form4.MdiParent = Me
        Form4.Show()
    End Sub
End Class
