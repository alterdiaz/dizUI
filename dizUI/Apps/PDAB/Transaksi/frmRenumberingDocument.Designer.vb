<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenumberingDocument
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
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel
        Me.lblNumber = New System.Windows.Forms.Label
        Me.tlpForm.SuspendLayout()
        Me.tlpField.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkGreen
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpForm.Controls.Add(Me.lblTitle, 1, 0)
        Me.tlpForm.Controls.Add(Me.tlpField, 1, 1)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpForm.Size = New System.Drawing.Size(411, 104)
        Me.tlpForm.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(5, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(401, 24)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Renumbering Documents"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.Color.DarkKhaki
        Me.tlpField.ColumnCount = 3
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Controls.Add(Me.lblNumber, 1, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpField.Location = New System.Drawing.Point(5, 24)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 3
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(401, 75)
        Me.tlpField.TabIndex = 7
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(53, 13)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(294, 48)
        Me.lblNumber.TabIndex = 10
        Me.lblNumber.Text = "Calculating Documents for : "
        Me.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRenumberingDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(411, 104)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRenumberingDocument"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih Karyawan"
        Me.tlpForm.ResumeLayout(False)
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblNumber As System.Windows.Forms.Label
End Class
