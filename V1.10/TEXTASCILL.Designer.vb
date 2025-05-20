<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WINDOW
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TTOA = New System.Windows.Forms.Button()
        Me.ATOTE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TIN = New System.Windows.Forms.TextBox()
        Me.ASCI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TTOA
        '
        Me.TTOA.Location = New System.Drawing.Point(80, 232)
        Me.TTOA.Name = "TTOA"
        Me.TTOA.Size = New System.Drawing.Size(212, 47)
        Me.TTOA.TabIndex = 0
        Me.TTOA.Text = "TEXT TO ASCILL"
        Me.TTOA.UseVisualStyleBackColor = True
        '
        'ATOTE
        '
        Me.ATOTE.Location = New System.Drawing.Point(80, 291)
        Me.ATOTE.Name = "ATOTE"
        Me.ATOTE.Size = New System.Drawing.Size(212, 47)
        Me.ATOTE.TabIndex = 1
        Me.ATOTE.Text = "ASCILL TO TEXT"
        Me.ATOTE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TEXT"
        '
        'TIN
        '
        Me.TIN.Location = New System.Drawing.Point(60, 67)
        Me.TIN.Multiline = True
        Me.TIN.Name = "TIN"
        Me.TIN.Size = New System.Drawing.Size(250, 53)
        Me.TIN.TabIndex = 3
        '
        'ASCI
        '
        Me.ASCI.Location = New System.Drawing.Point(60, 156)
        Me.ASCI.Multiline = True
        Me.ASCI.Name = "ASCI"
        Me.ASCI.Size = New System.Drawing.Size(250, 53)
        Me.ASCI.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ASCILL"
        '
        'WINDOW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 350)
        Me.Controls.Add(Me.ASCI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TIN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ATOTE)
        Me.Controls.Add(Me.TTOA)
        Me.MaximizeBox = False
        Me.Name = "WINDOW"
        Me.Text = "TEXTASCILL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TTOA As System.Windows.Forms.Button
    Friend WithEvents ATOTE As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TIN As System.Windows.Forms.TextBox
    Friend WithEvents ASCI As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
