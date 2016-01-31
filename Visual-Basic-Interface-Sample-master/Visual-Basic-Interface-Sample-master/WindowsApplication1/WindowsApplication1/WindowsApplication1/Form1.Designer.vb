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
        Me.PriceTxt = New System.Windows.Forms.TextBox()
        Me.CreditsTxt = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CostBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.fstNameTxt = New System.Windows.Forms.TextBox()
        Me.LastNameTxt = New System.Windows.Forms.TextBox()
        Me.ClassLbl = New System.Windows.Forms.Label()
        Me.LevelTxt = New System.Windows.Forms.TextBox()
        Me.DisplayTxt = New System.Windows.Forms.TextBox()
        Me.DisplayLbl = New System.Windows.Forms.Label()
        Me.DisplayBtn = New System.Windows.Forms.Button()
        Me.ClearBtn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PriceTxt
        '
        Me.PriceTxt.Location = New System.Drawing.Point(0, 43)
        Me.PriceTxt.Name = "PriceTxt"
        Me.PriceTxt.Size = New System.Drawing.Size(100, 20)
        Me.PriceTxt.TabIndex = 0
        Me.PriceTxt.Text = "Price"
        '
        'CreditsTxt
        '
        Me.CreditsTxt.Location = New System.Drawing.Point(0, 113)
        Me.CreditsTxt.Name = "CreditsTxt"
        Me.CreditsTxt.Size = New System.Drawing.Size(100, 20)
        Me.CreditsTxt.TabIndex = 1
        Me.CreditsTxt.Text = "# of Credits"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 426)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(286, 95)
        Me.ListBox1.TabIndex = 2
        '
        'CostBtn
        '
        Me.CostBtn.Location = New System.Drawing.Point(152, 12)
        Me.CostBtn.Name = "CostBtn"
        Me.CostBtn.Size = New System.Drawing.Size(106, 51)
        Me.CostBtn.TabIndex = 3
        Me.CostBtn.Text = "Calculate Cost"
        Me.CostBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(163, 95)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(79, 38)
        Me.ClearBtn.TabIndex = 4
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'fstNameTxt
        '
        Me.fstNameTxt.Location = New System.Drawing.Point(0, 190)
        Me.fstNameTxt.Name = "fstNameTxt"
        Me.fstNameTxt.Size = New System.Drawing.Size(100, 20)
        Me.fstNameTxt.TabIndex = 5
        Me.fstNameTxt.Text = "First Name"
        '
        'LastNameTxt
        '
        Me.LastNameTxt.Location = New System.Drawing.Point(158, 190)
        Me.LastNameTxt.Name = "LastNameTxt"
        Me.LastNameTxt.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTxt.TabIndex = 6
        Me.LastNameTxt.Text = "Last Name"
        '
        'ClassLbl
        '
        Me.ClassLbl.AutoSize = True
        Me.ClassLbl.Location = New System.Drawing.Point(12, 252)
        Me.ClassLbl.Name = "ClassLbl"
        Me.ClassLbl.Size = New System.Drawing.Size(61, 13)
        Me.ClassLbl.TabIndex = 7
        Me.ClassLbl.Text = "Class Level"
        '
        'LevelTxt
        '
        Me.LevelTxt.Location = New System.Drawing.Point(0, 280)
        Me.LevelTxt.Name = "LevelTxt"
        Me.LevelTxt.Size = New System.Drawing.Size(100, 20)
        Me.LevelTxt.TabIndex = 8
        Me.LevelTxt.Text = "Enter Level"
        '
        'DisplayTxt
        '
        Me.DisplayTxt.Location = New System.Drawing.Point(142, 280)
        Me.DisplayTxt.Name = "DisplayTxt"
        Me.DisplayTxt.Size = New System.Drawing.Size(116, 20)
        Me.DisplayTxt.TabIndex = 9
        '
        'DisplayLbl
        '
        Me.DisplayLbl.AutoSize = True
        Me.DisplayLbl.Location = New System.Drawing.Point(179, 252)
        Me.DisplayLbl.Name = "DisplayLbl"
        Me.DisplayLbl.Size = New System.Drawing.Size(41, 13)
        Me.DisplayLbl.TabIndex = 10
        Me.DisplayLbl.Text = "Display"
        '
        'DisplayBtn
        '
        Me.DisplayBtn.Location = New System.Drawing.Point(0, 339)
        Me.DisplayBtn.Name = "DisplayBtn"
        Me.DisplayBtn.Size = New System.Drawing.Size(100, 51)
        Me.DisplayBtn.TabIndex = 11
        Me.DisplayBtn.Text = "Display"
        Me.DisplayBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn1
        '
        Me.ClearBtn1.Location = New System.Drawing.Point(142, 339)
        Me.ClearBtn1.Name = "ClearBtn1"
        Me.ClearBtn1.Size = New System.Drawing.Size(100, 51)
        Me.ClearBtn1.TabIndex = 12
        Me.ClearBtn1.Text = "Clear Display"
        Me.ClearBtn1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 515)
        Me.Controls.Add(Me.ClearBtn1)
        Me.Controls.Add(Me.DisplayBtn)
        Me.Controls.Add(Me.DisplayLbl)
        Me.Controls.Add(Me.DisplayTxt)
        Me.Controls.Add(Me.LevelTxt)
        Me.Controls.Add(Me.ClassLbl)
        Me.Controls.Add(Me.LastNameTxt)
        Me.Controls.Add(Me.fstNameTxt)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CostBtn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CreditsTxt)
        Me.Controls.Add(Me.PriceTxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PriceTxt As System.Windows.Forms.TextBox
    Friend WithEvents CreditsTxt As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents CostBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents fstNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClassLbl As System.Windows.Forms.Label
    Friend WithEvents LevelTxt As System.Windows.Forms.TextBox
    Friend WithEvents DisplayTxt As System.Windows.Forms.TextBox
    Friend WithEvents DisplayLbl As System.Windows.Forms.Label
    Friend WithEvents DisplayBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBtn1 As System.Windows.Forms.Button

End Class
