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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tboSrc = New System.Windows.Forms.TextBox()
        Me.tboDst = New System.Windows.Forms.TextBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.tboKey1 = New System.Windows.Forms.TextBox()
        Me.tboKey2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudLength = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboFrom = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Result Text"
        '
        'tboSrc
        '
        Me.tboSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboSrc.Location = New System.Drawing.Point(101, 13)
        Me.tboSrc.Name = "tboSrc"
        Me.tboSrc.Size = New System.Drawing.Size(443, 24)
        Me.tboSrc.TabIndex = 2
        '
        'tboDst
        '
        Me.tboDst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboDst.Location = New System.Drawing.Point(101, 103)
        Me.tboDst.Name = "tboDst"
        Me.tboDst.Size = New System.Drawing.Size(362, 24)
        Me.tboDst.TabIndex = 3
        '
        'btnProcess
        '
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcess.Location = New System.Drawing.Point(469, 100)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 27)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'tboKey1
        '
        Me.tboKey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboKey1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboKey1.Location = New System.Drawing.Point(101, 43)
        Me.tboKey1.Name = "tboKey1"
        Me.tboKey1.Size = New System.Drawing.Size(161, 24)
        Me.tboKey1.TabIndex = 7
        '
        'tboKey2
        '
        Me.tboKey2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboKey2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboKey2.Location = New System.Drawing.Point(366, 43)
        Me.tboKey2.Name = "tboKey2"
        Me.tboKey2.Size = New System.Drawing.Size(161, 24)
        Me.tboKey2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Key1 Text"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(289, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Key2 Text"
        '
        'nudLength
        '
        Me.nudLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudLength.Location = New System.Drawing.Point(101, 73)
        Me.nudLength.Name = "nudLength"
        Me.nudLength.Size = New System.Drawing.Size(83, 24)
        Me.nudLength.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Max Length"
        '
        'cboFrom
        '
        Me.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboFrom.FormattingEnabled = True
        Me.cboFrom.Items.AddRange(New Object() {"Front", "Behind"})
        Me.cboFrom.Location = New System.Drawing.Point(366, 73)
        Me.cboFrom.Name = "cboFrom"
        Me.cboFrom.Size = New System.Drawing.Size(121, 24)
        Me.cboFrom.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Substring From"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(556, 142)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboFrom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudLength)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tboKey2)
        Me.Controls.Add(Me.tboKey1)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.tboDst)
        Me.Controls.Add(Me.tboSrc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dizProductGenerator"
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tboSrc As System.Windows.Forms.TextBox
    Friend WithEvents tboDst As System.Windows.Forms.TextBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents tboKey1 As System.Windows.Forms.TextBox
    Friend WithEvents tboKey2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
