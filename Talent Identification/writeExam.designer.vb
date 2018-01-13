<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class writeExam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(writeExam))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.LabelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
        Me.ArcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.ArcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.e0 = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.e5 = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.e4 = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.e3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.e2 = New System.Windows.Forms.TextBox()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.e6 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.e1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(33, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(670, 324)
        Me.DataGridView1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 54)
        Me.Panel2.TabIndex = 318
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 26)
        Me.Label1.TabIndex = 323
        Me.Label1.Text = "WRITE EXAM"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1332, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 54)
        Me.SimpleButton1.TabIndex = 309
        Me.SimpleButton1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 353
        Me.Label2.Text = "TIME"
        '
        'GaugeControl2
        '
        Me.GaugeControl2.ColorScheme.TargetElements = CType((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar Or DevExpress.XtraGauges.Core.Base.TargetElement.Label), DevExpress.XtraGauges.Core.Base.TargetElement)
        Me.GaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
        Me.GaugeControl2.Location = New System.Drawing.Point(13, 93)
        Me.GaugeControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.GaugeControl2.Name = "GaugeControl2"
        Me.GaugeControl2.Size = New System.Drawing.Size(164, 133)
        Me.GaugeControl2.TabIndex = 352
        '
        'circularGauge1
        '
        Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 152, 121)
        Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.LabelComponent1})
        Me.circularGauge1.Name = "circularGauge1"
        Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.ArcScaleRangeBarComponent1})
        Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent2})
        '
        'LabelComponent1
        '
        Me.LabelComponent1.AppearanceText.Font = New System.Drawing.Font("Segoe UI", 27.75!)
        Me.LabelComponent1.Name = "circularGauge1_Label1"
        Me.LabelComponent1.Size = New System.Drawing.SizeF(140.0!, 60.0!)
        Me.LabelComponent1.Text = "0"
        Me.LabelComponent1.ZOrder = -1001
        '
        'ArcScaleRangeBarComponent1
        '
        Me.ArcScaleRangeBarComponent1.ArcScale = Me.ArcScaleComponent2
        Me.ArcScaleRangeBarComponent1.Name = "circularGauge1_RangeBar2"
        Me.ArcScaleRangeBarComponent1.RoundedCaps = True
        Me.ArcScaleRangeBarComponent1.ShowBackground = True
        Me.ArcScaleRangeBarComponent1.StartOffset = 80.0!
        Me.ArcScaleRangeBarComponent1.ZOrder = -10
        '
        'ArcScaleComponent2
        '
        Me.ArcScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.ArcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
        Me.ArcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.ArcScaleComponent2.EndAngle = 90.0!
        Me.ArcScaleComponent2.MajorTickCount = 0
        Me.ArcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent2.MajorTickmark.ShapeOffset = -14.0!
        Me.ArcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
        Me.ArcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent2.MaxValue = 100.0!
        Me.ArcScaleComponent2.MinorTickCount = 0
        Me.ArcScaleComponent2.MinorTickmark.ShapeOffset = -7.0!
        Me.ArcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
        Me.ArcScaleComponent2.Name = "scale1"
        Me.ArcScaleComponent2.StartAngle = -270.0!
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 26)
        Me.Label3.TabIndex = 356
        Me.Label3.Text = "PENDING QUESTIONS"
        '
        'e0
        '
        Me.e0.Enabled = False
        Me.e0.Location = New System.Drawing.Point(960, 39)
        Me.e0.Name = "e0"
        Me.e0.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.e0.Properties.Appearance.Options.UseBackColor = True
        Me.e0.Properties.Mask.BeepOnError = True
        Me.e0.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.e0.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.e0.Size = New System.Drawing.Size(61, 20)
        Me.e0.TabIndex = 368
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(957, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 369
        Me.Label6.Text = "Question ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(709, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 367
        Me.Label5.Text = "My Answer"
        '
        'e5
        '
        Me.e5.Enabled = False
        Me.e5.Location = New System.Drawing.Point(780, 182)
        Me.e5.Name = "e5"
        Me.e5.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.e5.Properties.Appearance.Options.UseBackColor = True
        Me.e5.Properties.Mask.BeepOnError = True
        Me.e5.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.e5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.e5.Size = New System.Drawing.Size(279, 20)
        Me.e5.TabIndex = 365
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(709, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Option 3"
        '
        'e4
        '
        Me.e4.Enabled = False
        Me.e4.Location = New System.Drawing.Point(780, 156)
        Me.e4.Name = "e4"
        Me.e4.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.e4.Properties.Appearance.Options.UseBackColor = True
        Me.e4.Properties.Mask.BeepOnError = True
        Me.e4.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.e4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.e4.Size = New System.Drawing.Size(279, 20)
        Me.e4.TabIndex = 363
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(709, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 364
        Me.Label7.Text = "Option 2"
        '
        'e3
        '
        Me.e3.Enabled = False
        Me.e3.Location = New System.Drawing.Point(780, 130)
        Me.e3.Name = "e3"
        Me.e3.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.e3.Properties.Appearance.Options.UseBackColor = True
        Me.e3.Properties.Mask.BeepOnError = True
        Me.e3.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.e3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.e3.Size = New System.Drawing.Size(279, 20)
        Me.e3.TabIndex = 361
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(709, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 362
        Me.Label8.Text = "Option 1"
        '
        'e2
        '
        Me.e2.Enabled = False
        Me.e2.Location = New System.Drawing.Point(780, 65)
        Me.e2.Multiline = True
        Me.e2.Name = "e2"
        Me.e2.Size = New System.Drawing.Size(279, 59)
        Me.e2.TabIndex = 360
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.Options.UseBackColor = True
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(973, 234)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(86, 29)
        Me.SimpleButton7.TabIndex = 358
        Me.SimpleButton7.TabStop = False
        Me.SimpleButton7.Text = "&SAVE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(709, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 357
        Me.Label15.Text = "Question"
        '
        'e6
        '
        Me.e6.Location = New System.Drawing.Point(780, 208)
        Me.e6.Name = "e6"
        Me.e6.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.e6.Properties.Appearance.Options.UseBackColor = True
        Me.e6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.e6.Properties.Items.AddRange(New Object() {"ADMIN", "NON ALIGNED", "SCOUT", "TEST SETTER"})
        Me.e6.Properties.Sorted = True
        Me.e6.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.e6.Size = New System.Drawing.Size(279, 20)
        Me.e6.TabIndex = 370
        '
        'e1
        '
        Me.e1.Enabled = False
        Me.e1.Location = New System.Drawing.Point(780, 39)
        Me.e1.Name = "e1"
        Me.e1.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.e1.Properties.Appearance.Options.UseBackColor = True
        Me.e1.Properties.Mask.BeepOnError = True
        Me.e1.Size = New System.Drawing.Size(165, 20)
        Me.e1.TabIndex = 371
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Enabled = False
        Me.Label17.Location = New System.Drawing.Point(777, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 372
        Me.Label17.Text = "Exam ID"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.e1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.e6)
        Me.Panel1.Controls.Add(Me.SimpleButton7)
        Me.Panel1.Controls.Add(Me.e0)
        Me.Panel1.Controls.Add(Me.e2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.e3)
        Me.Panel1.Controls.Add(Me.e5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.e4)
        Me.Panel1.Location = New System.Drawing.Point(203, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1139, 453)
        Me.Panel1.TabIndex = 373
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'writeExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 526)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GaugeControl2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "writeExam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Talent Identification"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents LabelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Private WithEvents ArcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private WithEvents ArcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Friend WithEvents Label3 As Label
    Friend WithEvents e0 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label6 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents e5 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label4 As Label
    Friend WithEvents e4 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label7 As Label
    Friend WithEvents e3 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As Label
    Friend WithEvents e2 As TextBox
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label15 As Label
    Friend WithEvents e6 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents e1 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
