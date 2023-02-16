Public Class Search_form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fn As String
        Dim p As String
        Dim r As String
        fn = "C:\GitHubs\vbProjects\" + Me.id_search_TextBox1.Text
        '--------------first name-----------------------------
        p = fn + "_fn.txt"
        If (System.IO.File.Exists(p)) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.fn_TextBox2.Text = r
        Else
            Me.fn_TextBox2.Text = "Not Found"
        End If
        '--------------last name-----------------------------
        p = fn + "_ln.txt"
        If (System.IO.File.Exists(p)) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.ln_TextBox3.Text = r
        Else
            Me.ln_TextBox3.Text = "Not Found"
        End If
        '--------------tel ----------------------------------
        p = fn + "_tel.txt"
        If (System.IO.File.Exists(p)) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.tel_TextBox4.Text = r
        Else
            Me.tel_TextBox4.Text = "Not Found"
        End If
        '--------------cell -----------------------------
        p = fn + "_cell.txt"
        If (System.IO.File.Exists(p)) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.cell_TextBox5.Text = r
        Else
            Me.cell_TextBox5.Text = "Not Found"
        End If
        '--------------cell -----------------------------
        p = fn + "email.txt"
        If (System.IO.File.Exists(p)) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.email_TextBox6.Text = r
        Else
            Me.email_TextBox6.Text = "Not Found"
        End If
        '--------------cell -----------------------------
        p = fn + "email.txt"
        If (System.IO.File.Exists(p)) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.address_TextBox7.Text = r
        Else
            Me.address_TextBox7.Text = "Not Found"
        End If
        '--------------comment -----------------------------
        p = fn + "_comment.txt"
        If (System.IO.File.Exists(p)) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.comment_TextBox8.Text = r
        Else
            Me.comment_TextBox8.Text = "Not Found"
        End If

        Me.id_TextBox1.Text = Me.id_search_TextBox1.Text
    End Sub
        
End Class