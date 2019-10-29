<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumbers
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.btnEnterNumbers = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many numbers do you wish to enter?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Must be less than 10)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mtbQuantity
        '
        Me.mtbQuantity.Location = New System.Drawing.Point(353, 26)
        Me.mtbQuantity.Mask = "0"
        Me.mtbQuantity.Name = "mtbQuantity"
        Me.mtbQuantity.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbQuantity.Size = New System.Drawing.Size(62, 20)
        Me.mtbQuantity.TabIndex = 1
        '
        'btnEnterNumbers
        '
        Me.btnEnterNumbers.Location = New System.Drawing.Point(197, 71)
        Me.btnEnterNumbers.Name = "btnEnterNumbers"
        Me.btnEnterNumbers.Size = New System.Drawing.Size(111, 55)
        Me.btnEnterNumbers.TabIndex = 2
        Me.btnEnterNumbers.Text = "Enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Numbers"
        Me.btnEnterNumbers.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(12, 152)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(490, 173)
        Me.lstOutput.TabIndex = 3
        '
        'frmNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 337)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnEnterNumbers)
        Me.Controls.Add(Me.mtbQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNumbers"
        Me.Text = "Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mtbQuantity As MaskedTextBox
    Friend WithEvents btnEnterNumbers As Button
    Friend WithEvents lstOutput As ListBox
End Class
