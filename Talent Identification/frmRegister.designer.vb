<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtforename = New DevExpress.XtraEditors.TextEdit()
        Me.txtsurname = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.Email_addressTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.txtphonenumber = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.groupBox1.SuspendLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtforename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsurname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Email_addressTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtphonenumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.TextEdit1)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.ComboBoxEdit1)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.TextBox1)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.SimpleButton3)
        Me.groupBox1.Controls.Add(Me.SimpleButton1)
        Me.groupBox1.Controls.Add(Me.txtforename)
        Me.groupBox1.Controls.Add(Me.txtsurname)
        Me.groupBox1.Controls.Add(Me.txtUsername)
        Me.groupBox1.Controls.Add(Me.Email_addressTextBox)
        Me.groupBox1.Controls.Add(Me.txtphonenumber)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.txtPassword)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.PictureBox2)
        Me.groupBox1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(0, 60)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(728, 381)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "CANDIDATE REGISTRATION"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "CANDIDATE"
        Me.ComboBoxEdit1.Enabled = False
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(124, 18)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.Mask.BeepOnError = True
        Me.ComboBoxEdit1.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.ComboBoxEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(222, 20)
        Me.ComboBoxEdit1.TabIndex = 144
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 14)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Candidate Group"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightGray
        Me.TextBox1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(124, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(222, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 14)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Confirm Password"
        '
        'txtforename
        '
        Me.txtforename.Location = New System.Drawing.Point(477, 97)
        Me.txtforename.Name = "txtforename"
        Me.txtforename.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtforename.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtforename.Properties.Appearance.Options.UseBackColor = True
        Me.txtforename.Properties.Appearance.Options.UseFont = True
        Me.txtforename.Properties.Mask.BeepOnError = True
        Me.txtforename.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.txtforename.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtforename.Properties.Mask.ShowPlaceHolders = False
        Me.txtforename.Size = New System.Drawing.Size(222, 20)
        Me.txtforename.TabIndex = 5
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(477, 71)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtsurname.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsurname.Properties.Appearance.Options.UseBackColor = True
        Me.txtsurname.Properties.Appearance.Options.UseFont = True
        Me.txtsurname.Properties.Mask.BeepOnError = True
        Me.txtsurname.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.txtsurname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtsurname.Properties.Mask.ShowPlaceHolders = False
        Me.txtsurname.Size = New System.Drawing.Size(222, 20)
        Me.txtsurname.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(124, 45)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.txtUsername.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Properties.Appearance.Options.UseBackColor = True
        Me.txtUsername.Properties.Appearance.Options.UseFont = True
        Me.txtUsername.Properties.Mask.BeepOnError = True
        Me.txtUsername.Properties.Mask.EditMask = "\d\d\d\d\d\d\d\d\d"
        Me.txtUsername.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtUsername.Size = New System.Drawing.Size(222, 20)
        Me.txtUsername.TabIndex = 0
        '
        'Email_addressTextBox
        '
        Me.Email_addressTextBox.Location = New System.Drawing.Point(477, 45)
        Me.Email_addressTextBox.Name = "Email_addressTextBox"
        Me.Email_addressTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Email_addressTextBox.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_addressTextBox.Properties.Appearance.Options.UseBackColor = True
        Me.Email_addressTextBox.Properties.Appearance.Options.UseFont = True
        Me.Email_addressTextBox.Properties.Mask.BeepOnError = True
        Me.Email_addressTextBox.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"
        Me.Email_addressTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.Email_addressTextBox.Size = New System.Drawing.Size(222, 20)
        Me.Email_addressTextBox.TabIndex = 3
        '
        'txtphonenumber
        '
        Me.txtphonenumber.Location = New System.Drawing.Point(477, 123)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.txtphonenumber.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphonenumber.Properties.Appearance.Options.UseBackColor = True
        Me.txtphonenumber.Properties.Appearance.Options.UseFont = True
        Me.txtphonenumber.Properties.Mask.BeepOnError = True
        Me.txtphonenumber.Properties.Mask.EditMask = "+263700000000"
        Me.txtphonenumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtphonenumber.Size = New System.Drawing.Size(222, 20)
        Me.txtphonenumber.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 14)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "Cell Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 14)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "First Name(s)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 14)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Email"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.LightGray
        Me.txtPassword.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(124, 71)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(222, 22)
        Me.txtPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Account Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Candidate Username"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.SimpleButton2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(731, 54)
        Me.Panel3.TabIndex = 325
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 14)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Candidate Industry"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(477, 19)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextEdit1.Properties.Items.AddRange(New Object() {"BUSINESS", "GOVERNMENT", "HEALTH"})
        Me.TextEdit1.Properties.Sorted = True
        Me.TextEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TextEdit1.Size = New System.Drawing.Size(222, 20)
        Me.TextEdit1.TabIndex = 328
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(615, 149)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(84, 33)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "&Clear"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(503, 149)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 33)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "&Register"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Talent_Identification.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(69, 125)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(391, 238)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 327
        Me.PictureBox2.TabStop = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.Silver
        Me.SimpleButton2.Appearance.BackColor2 = System.Drawing.Color.Silver
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
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(56, 30)
        Me.SimpleButton2.TabIndex = 324
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 435)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Talent Identification"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtforename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsurname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Email_addressTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtphonenumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents Label2 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label6 As Label
    Friend WithEvents Email_addressTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtphonenumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtforename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtsurname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label1 As Label
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label3 As Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.ComboBoxEdit
End Class
