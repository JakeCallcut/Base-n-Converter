<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class basenconverter
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
        Me.Labeltitle = New System.Windows.Forms.Label()
        Me.lblout = New System.Windows.Forms.Label()
        Me.lblin = New System.Windows.Forms.Label()
        Me.txtin = New System.Windows.Forms.TextBox()
        Me.rhtxtout = New System.Windows.Forms.RichTextBox()
        Me.cmbxout = New System.Windows.Forms.ComboBox()
        Me.cmbxin = New System.Windows.Forms.ComboBox()
        Me.btnconvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Labeltitle
        '
        Me.Labeltitle.AutoSize = True
        Me.Labeltitle.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltitle.Location = New System.Drawing.Point(229, 9)
        Me.Labeltitle.Name = "Labeltitle"
        Me.Labeltitle.Size = New System.Drawing.Size(356, 55)
        Me.Labeltitle.TabIndex = 0
        Me.Labeltitle.Text = "Base-n Converter"
        '
        'lblout
        '
        Me.lblout.AutoSize = True
        Me.lblout.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblout.Location = New System.Drawing.Point(175, 209)
        Me.lblout.Name = "lblout"
        Me.lblout.Size = New System.Drawing.Size(101, 33)
        Me.lblout.TabIndex = 2
        Me.lblout.Text = "Output:"
        '
        'lblin
        '
        Me.lblin.AutoSize = True
        Me.lblin.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblin.Location = New System.Drawing.Point(195, 126)
        Me.lblin.Name = "lblin"
        Me.lblin.Size = New System.Drawing.Size(81, 33)
        Me.lblin.TabIndex = 3
        Me.lblin.Text = "Input:"
        '
        'txtin
        '
        Me.txtin.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtin.Location = New System.Drawing.Point(277, 133)
        Me.txtin.Name = "txtin"
        Me.txtin.Size = New System.Drawing.Size(169, 26)
        Me.txtin.TabIndex = 4
        '
        'rhtxtout
        '
        Me.rhtxtout.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rhtxtout.Location = New System.Drawing.Point(277, 216)
        Me.rhtxtout.Name = "rhtxtout"
        Me.rhtxtout.Size = New System.Drawing.Size(169, 111)
        Me.rhtxtout.TabIndex = 5
        Me.rhtxtout.Text = ""
        '
        'cmbxout
        '
        Me.cmbxout.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxout.FormattingEnabled = True
        Me.cmbxout.Items.AddRange(New Object() {"Decimal", "Hexadecimal", "Binary"})
        Me.cmbxout.Location = New System.Drawing.Point(464, 216)
        Me.cmbxout.Name = "cmbxout"
        Me.cmbxout.Size = New System.Drawing.Size(148, 27)
        Me.cmbxout.TabIndex = 6
        '
        'cmbxin
        '
        Me.cmbxin.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxin.FormattingEnabled = True
        Me.cmbxin.Items.AddRange(New Object() {"Decimal", "Hexadecimal", "Binary"})
        Me.cmbxin.Location = New System.Drawing.Point(464, 133)
        Me.cmbxin.Name = "cmbxin"
        Me.cmbxin.Size = New System.Drawing.Size(148, 27)
        Me.cmbxin.TabIndex = 7
        '
        'btnconvert
        '
        Me.btnconvert.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvert.Location = New System.Drawing.Point(309, 357)
        Me.btnconvert.Name = "btnconvert"
        Me.btnconvert.Size = New System.Drawing.Size(163, 81)
        Me.btnconvert.TabIndex = 8
        Me.btnconvert.Text = "Convert"
        Me.btnconvert.UseVisualStyleBackColor = True
        '
        'basenconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnconvert)
        Me.Controls.Add(Me.cmbxin)
        Me.Controls.Add(Me.cmbxout)
        Me.Controls.Add(Me.rhtxtout)
        Me.Controls.Add(Me.txtin)
        Me.Controls.Add(Me.lblin)
        Me.Controls.Add(Me.lblout)
        Me.Controls.Add(Me.Labeltitle)
        Me.Name = "basenconverter"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labeltitle As Label
    Friend WithEvents lblout As Label
    Friend WithEvents lblin As Label
    Friend WithEvents txtin As TextBox
    Friend WithEvents rhtxtout As RichTextBox
    Friend WithEvents cmbxout As ComboBox
    Friend WithEvents cmbxin As ComboBox
    Friend WithEvents btnconvert As Button
End Class
