<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstFlavor = New System.Windows.Forms.ListBox()
        Me.picFlavor = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picFlavor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstFlavor
        '
        Me.lstFlavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFlavor.FormattingEnabled = True
        Me.lstFlavor.ItemHeight = 24
        Me.lstFlavor.Items.AddRange(New Object() {"Cookies n Cream", "Mint", "Butter Peacon", "Banana", "Strawberry"})
        Me.lstFlavor.Location = New System.Drawing.Point(12, 12)
        Me.lstFlavor.Name = "lstFlavor"
        Me.lstFlavor.Size = New System.Drawing.Size(158, 124)
        Me.lstFlavor.TabIndex = 0
        '
        'picFlavor
        '
        Me.picFlavor.Location = New System.Drawing.Point(26, 165)
        Me.picFlavor.Name = "picFlavor"
        Me.picFlavor.Size = New System.Drawing.Size(223, 181)
        Me.picFlavor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlavor.TabIndex = 1
        Me.picFlavor.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(207, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 55)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picFlavor)
        Me.Controls.Add(Me.lstFlavor)
        Me.Name = "frmMain"
        Me.Text = "Ice Cream Flavors"
        CType(Me.picFlavor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFlavor As ListBox
    Friend WithEvents picFlavor As PictureBox
    Friend WithEvents btnExit As Button
End Class
