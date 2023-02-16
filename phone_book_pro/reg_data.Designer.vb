<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reg_data
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reg_data))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.new_butt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.save_butt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.info_groupbox = New System.Windows.Forms.GroupBox()
        Me.comment_TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.address_TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.email_TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cell_TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tel_TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ln_TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fn_TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.info_groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.new_butt, Me.ToolStripSeparator2, Me.save_butt, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(556, 67)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'new_butt
        '
        Me.new_butt.Image = CType(resources.GetObject("new_butt.Image"), System.Drawing.Image)
        Me.new_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.new_butt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.new_butt.Name = "new_butt"
        Me.new_butt.Size = New System.Drawing.Size(126, 64)
        Me.new_butt.Text = "New Record"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 67)
        '
        'save_butt
        '
        Me.save_butt.Image = CType(resources.GetObject("save_butt.Image"), System.Drawing.Image)
        Me.save_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.save_butt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.save_butt.Name = "save_butt"
        Me.save_butt.Size = New System.Drawing.Size(124, 64)
        Me.save_butt.Text = "Save Button"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 67)
        '
        'info_groupbox
        '
        Me.info_groupbox.Controls.Add(Me.comment_TextBox8)
        Me.info_groupbox.Controls.Add(Me.Label8)
        Me.info_groupbox.Controls.Add(Me.address_TextBox7)
        Me.info_groupbox.Controls.Add(Me.Label7)
        Me.info_groupbox.Controls.Add(Me.email_TextBox6)
        Me.info_groupbox.Controls.Add(Me.Label6)
        Me.info_groupbox.Controls.Add(Me.cell_TextBox5)
        Me.info_groupbox.Controls.Add(Me.Label5)
        Me.info_groupbox.Controls.Add(Me.tel_TextBox4)
        Me.info_groupbox.Controls.Add(Me.Label4)
        Me.info_groupbox.Controls.Add(Me.ln_TextBox3)
        Me.info_groupbox.Controls.Add(Me.Label3)
        Me.info_groupbox.Controls.Add(Me.fn_TextBox2)
        Me.info_groupbox.Controls.Add(Me.Label2)
        Me.info_groupbox.Controls.Add(Me.id_TextBox1)
        Me.info_groupbox.Controls.Add(Me.Label1)
        Me.info_groupbox.Location = New System.Drawing.Point(37, 90)
        Me.info_groupbox.Name = "info_groupbox"
        Me.info_groupbox.Size = New System.Drawing.Size(457, 457)
        Me.info_groupbox.TabIndex = 1
        Me.info_groupbox.TabStop = False
        Me.info_groupbox.Text = "Information"
        '
        'comment_TextBox8
        '
        Me.comment_TextBox8.Location = New System.Drawing.Point(131, 313)
        Me.comment_TextBox8.Multiline = True
        Me.comment_TextBox8.Name = "comment_TextBox8"
        Me.comment_TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.comment_TextBox8.Size = New System.Drawing.Size(209, 82)
        Me.comment_TextBox8.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Comment:"
        '
        'address_TextBox7
        '
        Me.address_TextBox7.Location = New System.Drawing.Point(131, 276)
        Me.address_TextBox7.Name = "address_TextBox7"
        Me.address_TextBox7.Size = New System.Drawing.Size(209, 22)
        Me.address_TextBox7.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address:"
        '
        'email_TextBox6
        '
        Me.email_TextBox6.Location = New System.Drawing.Point(131, 242)
        Me.email_TextBox6.Name = "email_TextBox6"
        Me.email_TextBox6.Size = New System.Drawing.Size(209, 22)
        Me.email_TextBox6.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email:"
        '
        'cell_TextBox5
        '
        Me.cell_TextBox5.Location = New System.Drawing.Point(131, 205)
        Me.cell_TextBox5.Name = "cell_TextBox5"
        Me.cell_TextBox5.Size = New System.Drawing.Size(209, 22)
        Me.cell_TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cell:"
        '
        'tel_TextBox4
        '
        Me.tel_TextBox4.Location = New System.Drawing.Point(131, 165)
        Me.tel_TextBox4.Name = "tel_TextBox4"
        Me.tel_TextBox4.Size = New System.Drawing.Size(209, 22)
        Me.tel_TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tel:"
        '
        'ln_TextBox3
        '
        Me.ln_TextBox3.Location = New System.Drawing.Point(131, 126)
        Me.ln_TextBox3.Name = "ln_TextBox3"
        Me.ln_TextBox3.Size = New System.Drawing.Size(209, 22)
        Me.ln_TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'fn_TextBox2
        '
        Me.fn_TextBox2.AcceptsReturn = True
        Me.fn_TextBox2.Location = New System.Drawing.Point(131, 90)
        Me.fn_TextBox2.Name = "fn_TextBox2"
        Me.fn_TextBox2.Size = New System.Drawing.Size(209, 22)
        Me.fn_TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'id_TextBox1
        '
        Me.id_TextBox1.Location = New System.Drawing.Point(131, 57)
        Me.id_TextBox1.Name = "id_TextBox1"
        Me.id_TextBox1.Size = New System.Drawing.Size(209, 22)
        Me.id_TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'reg_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 553)
        Me.Controls.Add(Me.info_groupbox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "reg_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Data"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.info_groupbox.ResumeLayout(False)
        Me.info_groupbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents new_butt As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents save_butt As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents info_groupbox As GroupBox
    Friend WithEvents comment_TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents address_TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents email_TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cell_TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tel_TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ln_TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fn_TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents id_TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
