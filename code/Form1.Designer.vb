<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBand
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
        Dim radBand3 As System.Windows.Forms.RadioButton
        Me.grpBand = New System.Windows.Forms.GroupBox()
        Me.radBand5 = New System.Windows.Forms.RadioButton()
        Me.radBand4 = New System.Windows.Forms.RadioButton()
        Me.radBand2 = New System.Windows.Forms.RadioButton()
        Me.radBand1 = New System.Windows.Forms.RadioButton()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.radClear = New System.Windows.Forms.RadioButton()
        radBand3 = New System.Windows.Forms.RadioButton()
        Me.grpBand.SuspendLayout()
        Me.SuspendLayout()
        '
        'radBand3
        '
        radBand3.AutoSize = True
        radBand3.Location = New System.Drawing.Point(20, 111)
        radBand3.Name = "radBand3"
        radBand3.Size = New System.Drawing.Size(76, 17)
        radBand3.TabIndex = 2
        radBand3.Text = "Green Day"
        radBand3.UseVisualStyleBackColor = True
        AddHandler radBand3.CheckedChanged, AddressOf Me.radBand3_CheckedChanged
        '
        'grpBand
        '
        Me.grpBand.Controls.Add(Me.radBand5)
        Me.grpBand.Controls.Add(Me.radBand4)
        Me.grpBand.Controls.Add(radBand3)
        Me.grpBand.Controls.Add(Me.radBand2)
        Me.grpBand.Controls.Add(Me.radBand1)
        Me.grpBand.Location = New System.Drawing.Point(12, 12)
        Me.grpBand.Name = "grpBand"
        Me.grpBand.Size = New System.Drawing.Size(200, 240)
        Me.grpBand.TabIndex = 0
        Me.grpBand.TabStop = False
        Me.grpBand.Text = "Bands"
        '
        'radBand5
        '
        Me.radBand5.AutoSize = True
        Me.radBand5.Location = New System.Drawing.Point(20, 200)
        Me.radBand5.Name = "radBand5"
        Me.radBand5.Size = New System.Drawing.Size(47, 17)
        Me.radBand5.TabIndex = 4
        Me.radBand5.Text = "EXO"
        Me.radBand5.UseVisualStyleBackColor = True
        '
        'radBand4
        '
        Me.radBand4.AutoSize = True
        Me.radBand4.Location = New System.Drawing.Point(20, 154)
        Me.radBand4.Name = "radBand4"
        Me.radBand4.Size = New System.Drawing.Size(82, 17)
        Me.radBand4.TabIndex = 3
        Me.radBand4.Text = "Fall Out Boy"
        Me.radBand4.UseVisualStyleBackColor = True
        '
        'radBand2
        '
        Me.radBand2.AutoSize = True
        Me.radBand2.Location = New System.Drawing.Point(20, 67)
        Me.radBand2.Name = "radBand2"
        Me.radBand2.Size = New System.Drawing.Size(139, 17)
        Me.radBand2.TabIndex = 1
        Me.radBand2.Text = "TWENTY ØNE PILØTS"
        Me.radBand2.UseVisualStyleBackColor = True
        '
        'radBand1
        '
        Me.radBand1.AutoSize = True
        Me.radBand1.Location = New System.Drawing.Point(20, 30)
        Me.radBand1.Name = "radBand1"
        Me.radBand1.Size = New System.Drawing.Size(46, 17)
        Me.radBand1.TabIndex = 0
        Me.radBand1.Text = "BTS"
        Me.radBand1.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Font = New System.Drawing.Font("Orator Std", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponse.Location = New System.Drawing.Point(257, 30)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(0, 32)
        Me.lblResponse.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Sitka Subheading", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(486, 369)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(145, 35)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Chalumuri™"
        '
        'radClear
        '
        Me.radClear.AutoSize = True
        Me.radClear.Location = New System.Drawing.Point(32, 270)
        Me.radClear.Name = "radClear"
        Me.radClear.Size = New System.Drawing.Size(49, 17)
        Me.radClear.TabIndex = 3
        Me.radClear.Text = "Clear"
        Me.radClear.UseVisualStyleBackColor = True
        '
        'frmBand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(633, 413)
        Me.Controls.Add(Me.radClear)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.grpBand)
        Me.Name = "frmBand"
        Me.Text = "Music Bands"
        Me.grpBand.ResumeLayout(False)
        Me.grpBand.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBand As System.Windows.Forms.GroupBox
    Friend WithEvents radBand5 As System.Windows.Forms.RadioButton
    Friend WithEvents radBand4 As System.Windows.Forms.RadioButton
    Friend WithEvents radBand2 As System.Windows.Forms.RadioButton
    Friend WithEvents radBand1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblResponse As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents radClear As System.Windows.Forms.RadioButton

End Class
