<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.WeekOfMonthEdit1 = New DevExpress.XtraScheduler.UI.WeekOfMonthEdit()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekOfMonthEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.DataStorage = Me.SchedulerStorage1
        Me.SchedulerControl1.Location = New System.Drawing.Point(56, 12)
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(400, 200)
        Me.SchedulerControl1.Start = New Date(2018, 1, 6, 0, 0, 0, 0)
        Me.SchedulerControl1.TabIndex = 0
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.FullWeekView.Enabled = True
        Me.SchedulerControl1.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.SchedulerControl1.Views.WeekView.Enabled = False
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'WeekOfMonthEdit1
        '
        Me.WeekOfMonthEdit1.Location = New System.Drawing.Point(572, 116)
        Me.WeekOfMonthEdit1.Name = "WeekOfMonthEdit1"
        Me.WeekOfMonthEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeekOfMonthEdit1.Size = New System.Drawing.Size(100, 20)
        Me.WeekOfMonthEdit1.TabIndex = 1
        '
        'GaugeControl1
        '
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(492, 21)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(250, 250)
        Me.GaugeControl1.TabIndex = 2
        '
        'DigitalGauge1
        '
        Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent1})
        Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 238, 238)
        Me.DigitalGauge1.DigitCount = 5
        Me.DigitalGauge1.Name = "DigitalGauge1"
        Me.DigitalGauge1.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 301)
        Me.Controls.Add(Me.GaugeControl1)
        Me.Controls.Add(Me.WeekOfMonthEdit1)
        Me.Controls.Add(Me.SchedulerControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekOfMonthEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents WeekOfMonthEdit1 As DevExpress.XtraScheduler.UI.WeekOfMonthEdit
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
End Class
