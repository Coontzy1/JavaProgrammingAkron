<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblWeek1 = New System.Windows.Forms.Label()
        Me.lblWeek2 = New System.Windows.Forms.Label()
        Me.lblWeek3 = New System.Windows.Forms.Label()
        Me.lblWeek4 = New System.Windows.Forms.Label()
        Me.lblWeek5 = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtWeek1 = New System.Windows.Forms.TextBox()
        Me.txtWeek2 = New System.Windows.Forms.TextBox()
        Me.txtWeek3 = New System.Windows.Forms.TextBox()
        Me.txtWeek4 = New System.Windows.Forms.TextBox()
        Me.txtWeek5 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalc.Location = New System.Drawing.Point(12, 370)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(150, 68)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate Average"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(199, 370)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 68)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.Location = New System.Drawing.Point(386, 370)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 68)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblWeek1
        '
        Me.lblWeek1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWeek1.Location = New System.Drawing.Point(103, 33)
        Me.lblWeek1.Name = "lblWeek1"
        Me.lblWeek1.Size = New System.Drawing.Size(139, 40)
        Me.lblWeek1.TabIndex = 1
        Me.lblWeek1.Text = "Week 1:"
        '
        'lblWeek2
        '
        Me.lblWeek2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWeek2.Location = New System.Drawing.Point(103, 89)
        Me.lblWeek2.Name = "lblWeek2"
        Me.lblWeek2.Size = New System.Drawing.Size(139, 40)
        Me.lblWeek2.TabIndex = 1
        Me.lblWeek2.Text = "Week 2:"
        '
        'lblWeek3
        '
        Me.lblWeek3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWeek3.Location = New System.Drawing.Point(103, 145)
        Me.lblWeek3.Name = "lblWeek3"
        Me.lblWeek3.Size = New System.Drawing.Size(139, 40)
        Me.lblWeek3.TabIndex = 1
        Me.lblWeek3.Text = "Week 3:"
        '
        'lblWeek4
        '
        Me.lblWeek4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWeek4.Location = New System.Drawing.Point(103, 201)
        Me.lblWeek4.Name = "lblWeek4"
        Me.lblWeek4.Size = New System.Drawing.Size(139, 40)
        Me.lblWeek4.TabIndex = 1
        Me.lblWeek4.Text = "Week 4:"
        '
        'lblWeek5
        '
        Me.lblWeek5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWeek5.Location = New System.Drawing.Point(103, 257)
        Me.lblWeek5.Name = "lblWeek5"
        Me.lblWeek5.Size = New System.Drawing.Size(139, 40)
        Me.lblWeek5.TabIndex = 1
        Me.lblWeek5.Text = "Week 5:"
        '
        'lblAvg
        '
        Me.lblAvg.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAvg.Location = New System.Drawing.Point(103, 313)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(139, 40)
        Me.lblAvg.TabIndex = 1
        Me.lblAvg.Text = "Average:"
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAnswer.Location = New System.Drawing.Point(299, 313)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(139, 32)
        Me.lblAnswer.TabIndex = 1
        '
        'txtWeek1
        '
        Me.txtWeek1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWeek1.Location = New System.Drawing.Point(299, 34)
        Me.txtWeek1.Name = "txtWeek1"
        Me.txtWeek1.Size = New System.Drawing.Size(139, 31)
        Me.txtWeek1.TabIndex = 2
        '
        'txtWeek2
        '
        Me.txtWeek2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWeek2.Location = New System.Drawing.Point(299, 90)
        Me.txtWeek2.Name = "txtWeek2"
        Me.txtWeek2.Size = New System.Drawing.Size(139, 31)
        Me.txtWeek2.TabIndex = 2
        '
        'txtWeek3
        '
        Me.txtWeek3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWeek3.Location = New System.Drawing.Point(299, 146)
        Me.txtWeek3.Name = "txtWeek3"
        Me.txtWeek3.Size = New System.Drawing.Size(139, 31)
        Me.txtWeek3.TabIndex = 2
        '
        'txtWeek4
        '
        Me.txtWeek4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWeek4.Location = New System.Drawing.Point(299, 202)
        Me.txtWeek4.Name = "txtWeek4"
        Me.txtWeek4.Size = New System.Drawing.Size(139, 31)
        Me.txtWeek4.TabIndex = 2
        '
        'txtWeek5
        '
        Me.txtWeek5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWeek5.Location = New System.Drawing.Point(299, 258)
        Me.txtWeek5.Name = "txtWeek5"
        Me.txtWeek5.Size = New System.Drawing.Size(139, 31)
        Me.txtWeek5.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 445)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(548, 22)
        Me.StatusStrip1.TabIndex = 3
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 467)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtWeek5)
        Me.Controls.Add(Me.txtWeek4)
        Me.Controls.Add(Me.txtWeek3)
        Me.Controls.Add(Me.txtWeek2)
        Me.Controls.Add(Me.txtWeek1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblWeek5)
        Me.Controls.Add(Me.lblWeek4)
        Me.Controls.Add(Me.lblWeek3)
        Me.Controls.Add(Me.lblWeek2)
        Me.Controls.Add(Me.lblWeek1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Form1"
        Me.Text = "Weekly Temp (Validated)"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblWeek1 As Label
    Friend WithEvents lblWeek2 As Label
    Friend WithEvents lblWeek3 As Label
    Friend WithEvents lblWeek4 As Label
    Friend WithEvents lblWeek5 As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtWeek1 As TextBox
    Friend WithEvents txtWeek2 As TextBox
    Friend WithEvents txtWeek3 As TextBox
    Friend WithEvents txtWeek4 As TextBox
    Friend WithEvents txtWeek5 As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
