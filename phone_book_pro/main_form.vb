Public Class main_form
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        My.Forms.reg_data.MdiParent = Me
        My.Forms.reg_data.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim fm As New Search_form
        fm.MdiParent = Me
        fm.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        My.Forms.About_us.MdiParent = Me
        My.Forms.About_us.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        'Me.Close()
        MessageBox.Show("Have a nice day!")
        Application.Exit()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\calc.exe"
        Me.Process1.Start()
    End Sub

    Private Sub main_form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            ToolStripButton1_Click(sender, e)
        End If
        If (e.KeyCode = Keys.F3) Then
            ToolStripButton2_Click(sender, e)
        End If
        If (e.KeyCode = Keys.F4) Then
            ToolStripButton3_Click(sender, e)
        End If
        If (e.KeyCode = Keys.F5) Then
            ToolStripButton4_Click(sender, e)
        End If
        If (e.KeyCode = Keys.Escape) Then
            ToolStripButton5_Click(sender, e)
        End If
    End Sub
End Class