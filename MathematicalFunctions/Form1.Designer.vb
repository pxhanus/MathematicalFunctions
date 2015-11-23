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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.btnAbsValue = New System.Windows.Forms.Button()
        Me.btnSqRt = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 19)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(100, 16)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(62, 20)
        Me.txtNum.TabIndex = 1
        '
        'lblAns
        '
        Me.lblAns.Location = New System.Drawing.Point(12, 46)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(176, 66)
        Me.lblAns.TabIndex = 2
        Me.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAbsValue
        '
        Me.btnAbsValue.Location = New System.Drawing.Point(194, 10)
        Me.btnAbsValue.Name = "btnAbsValue"
        Me.btnAbsValue.Size = New System.Drawing.Size(90, 30)
        Me.btnAbsValue.TabIndex = 3
        Me.btnAbsValue.Text = "Absolute Value"
        Me.btnAbsValue.UseVisualStyleBackColor = True
        '
        'btnSqRt
        '
        Me.btnSqRt.Location = New System.Drawing.Point(194, 46)
        Me.btnSqRt.Name = "btnSqRt"
        Me.btnSqRt.Size = New System.Drawing.Size(90, 30)
        Me.btnSqRt.TabIndex = 4
        Me.btnSqRt.Text = "Square Root"
        Me.btnSqRt.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(194, 82)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(90, 30)
        Me.btnSign.TabIndex = 5
        Me.btnSign.Text = "Sign"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 123)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnSqRt)
        Me.Controls.Add(Me.btnAbsValue)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Mathematical Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lblAns As System.Windows.Forms.Label
    Friend WithEvents btnAbsValue As System.Windows.Forms.Button
    Friend WithEvents btnSqRt As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button

End Class
