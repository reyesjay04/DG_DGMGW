<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DG_DGMW
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpReportingDate = New System.Windows.Forms.DateTimePicker()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.btnHourly = New System.Windows.Forms.Button()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpBDEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpBDStart = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(383, 297)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dtpReportingDate)
        Me.TabPage1.Controls.Add(Me.btnDiscount)
        Me.TabPage1.Controls.Add(Me.btnHourly)
        Me.TabPage1.Controls.Add(Me.btnDaily)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TabPage1.Size = New System.Drawing.Size(375, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SELECT TYPE OF REPORT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SELECT REPORTING DATE"
        '
        'dtpReportingDate
        '
        Me.dtpReportingDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dtpReportingDate.CustomFormat = ""
        Me.dtpReportingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpReportingDate.Location = New System.Drawing.Point(30, 50)
        Me.dtpReportingDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpReportingDate.Name = "dtpReportingDate"
        Me.dtpReportingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpReportingDate.Size = New System.Drawing.Size(310, 21)
        Me.dtpReportingDate.TabIndex = 1
        '
        'btnDiscount
        '
        Me.btnDiscount.Location = New System.Drawing.Point(30, 212)
        Me.btnDiscount.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(310, 36)
        Me.btnDiscount.TabIndex = 0
        Me.btnDiscount.Text = "Generate Discount Report"
        Me.btnDiscount.UseVisualStyleBackColor = True
        '
        'btnHourly
        '
        Me.btnHourly.Location = New System.Drawing.Point(30, 170)
        Me.btnHourly.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnHourly.Name = "btnHourly"
        Me.btnHourly.Size = New System.Drawing.Size(310, 36)
        Me.btnHourly.TabIndex = 0
        Me.btnHourly.Text = "Generate Hourly Sales"
        Me.btnHourly.UseVisualStyleBackColor = True
        '
        'btnDaily
        '
        Me.btnDaily.Location = New System.Drawing.Point(30, 127)
        Me.btnDaily.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(310, 36)
        Me.btnDaily.TabIndex = 0
        Me.btnDaily.Text = "Generate Daily Sales"
        Me.btnDaily.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.dtpBDEnd)
        Me.TabPage2.Controls.Add(Me.dtpBDStart)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TabPage2.Size = New System.Drawing.Size(375, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(32, 66)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(310, 36)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(229, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Business Hours"
        '
        'dtpBDEnd
        '
        Me.dtpBDEnd.CalendarFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBDEnd.CustomFormat = "hh:mm tt"
        Me.dtpBDEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBDEnd.Location = New System.Drawing.Point(259, 26)
        Me.dtpBDEnd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpBDEnd.Name = "dtpBDEnd"
        Me.dtpBDEnd.ShowUpDown = True
        Me.dtpBDEnd.Size = New System.Drawing.Size(80, 21)
        Me.dtpBDEnd.TabIndex = 0
        '
        'dtpBDStart
        '
        Me.dtpBDStart.CalendarFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBDStart.CustomFormat = "hh:mm tt"
        Me.dtpBDStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBDStart.Location = New System.Drawing.Point(140, 26)
        Me.dtpBDStart.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpBDStart.Name = "dtpBDStart"
        Me.dtpBDStart.ShowUpDown = True
        Me.dtpBDStart.Size = New System.Drawing.Size(80, 21)
        Me.dtpBDStart.TabIndex = 0
        '
        'DG_DGMW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 297)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DG_DGMW"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Megawolrd Reporting Module"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dtpReportingDate As DateTimePicker
    Friend WithEvents btnDiscount As Button
    Friend WithEvents btnHourly As Button
    Friend WithEvents btnDaily As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpBDEnd As DateTimePicker
    Friend WithEvents dtpBDStart As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
