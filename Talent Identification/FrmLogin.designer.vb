<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.MaskedTextBox()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(3, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 311
        Me.Label7.Text = "Label6"
        '
        'Timer2
        '
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 43)
        Me.Panel2.TabIndex = 327
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(167, 213)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 330
        Me.Label1.Text = "I Forgot My Password"
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Location = New System.Drawing.Point(346, 6)
        Me.ProgressPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(184, 54)
        Me.ProgressPanel1.TabIndex = 331
        Me.ProgressPanel1.Text = "ProgressPanel1"
        Me.ProgressPanel1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Controls.Add(Me.SimpleButton2)
        Me.Panel4.Controls.Add(Me.ProgressPanel1)
        Me.Panel4.Controls.Add(Me.SimpleButton1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(541, 64)
        Me.Panel4.TabIndex = 326
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtpwd)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.lblerror)
        Me.Panel1.Location = New System.Drawing.Point(25, 124)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 87)
        Me.Panel1.TabIndex = 325
        '
        'txtpwd
        '
        Me.txtpwd.BackColor = System.Drawing.Color.White
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.ForeColor = System.Drawing.Color.Black
        Me.txtpwd.Location = New System.Drawing.Point(116, 59)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(175, 20)
        Me.txtpwd.TabIndex = 303
        Me.txtpwd.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.BeepOnError = True
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Location = New System.Drawing.Point(117, 33)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(175, 20)
        Me.txtusername.TabIndex = 302
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.White
        Me.lblerror.Font = New System.Drawing.Font("Corbel", 9.75!)
        Me.lblerror.ForeColor = System.Drawing.Color.Gray
        Me.lblerror.Location = New System.Drawing.Point(117, 13)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(174, 15)
        Me.lblerror.TabIndex = 301
        Me.lblerror.Text = "Login Details not yet verified !! "
        Me.lblerror.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 304
        Me.Label2.Text = "UserName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 304
        Me.Label3.Text = "Password"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.BackColor2 = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.BorderColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseBorderColor = True
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.LightGray
        Me.SimpleButton2.AppearanceHovered.Options.UseBackColor = True
        Me.SimpleButton2.AppearancePressed.BackColor = System.Drawing.Color.White
        Me.SimpleButton2.AppearancePressed.BackColor2 = System.Drawing.Color.White
        Me.SimpleButton2.AppearancePressed.BorderColor = System.Drawing.Color.RoyalBlue
        Me.SimpleButton2.AppearancePressed.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.AppearancePressed.Options.UseBackColor = True
        Me.SimpleButton2.AppearancePressed.Options.UseBorderColor = True
        Me.SimpleButton2.AppearancePressed.Options.UseForeColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(181, 20)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(83, 30)
        Me.SimpleButton2.TabIndex = 332
        Me.SimpleButton2.Text = "Register"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.LightGray
        Me.SimpleButton1.AppearanceHovered.Options.UseBackColor = True
        Me.SimpleButton1.AppearancePressed.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.White
        Me.SimpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.RoyalBlue
        Me.SimpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.AppearancePressed.Options.UseBackColor = True
        Me.SimpleButton1.AppearancePressed.Options.UseBorderColor = True
        Me.SimpleButton1.AppearancePressed.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(6, 20)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(56, 30)
        Me.SimpleButton1.TabIndex = 323
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Talent_Identification.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(181, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 280)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 331
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(541, 390)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Talent Identification"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents lblerror As Label
    Friend WithEvents txtusername As MaskedTextBox
    Friend WithEvents txtpwd As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
