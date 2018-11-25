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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(26, 26)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(78, 117)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 1
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(12, 117)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(60, 13)
        Me.lblSentence.TabIndex = 2
        Me.lblSentence.Text = "Factorial is:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(114, 23)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(36, 20)
        Me.txtInput.TabIndex = 3
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(156, 21)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(116, 23)
        Me.btnCompute.TabIndex = 4
        Me.btnCompute.Text = "Compute Factorial"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 165)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblSentence)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Factorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblSentence As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button

End Class
