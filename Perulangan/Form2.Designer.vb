<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.hasilbintang = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.okbintang = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.baris = New System.Windows.Forms.Label()
        Me.pola = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hasilbintang
        '
        Me.hasilbintang.BackColor = System.Drawing.SystemColors.MenuBar
        Me.hasilbintang.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasilbintang.Location = New System.Drawing.Point(21, 85)
        Me.hasilbintang.Multiline = True
        Me.hasilbintang.Name = "hasilbintang"
        Me.hasilbintang.Size = New System.Drawing.Size(423, 328)
        Me.hasilbintang.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(76, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(287, 26)
        Me.TextBox1.TabIndex = 12
        '
        'okbintang
        '
        Me.okbintang.Location = New System.Drawing.Point(369, 38)
        Me.okbintang.Name = "okbintang"
        Me.okbintang.Size = New System.Drawing.Size(75, 23)
        Me.okbintang.TabIndex = 11
        Me.okbintang.Text = "OK"
        Me.okbintang.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Piramyd", "Hollow Piramyd", "Inverted Piramyd", "Hollow Inverted Piramyd"})
        Me.ComboBox1.Location = New System.Drawing.Point(76, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(368, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'baris
        '
        Me.baris.AutoSize = True
        Me.baris.Location = New System.Drawing.Point(18, 48)
        Me.baris.Name = "baris"
        Me.baris.Size = New System.Drawing.Size(30, 13)
        Me.baris.TabIndex = 9
        Me.baris.Text = "Baris"
        '
        'pola
        '
        Me.pola.AutoSize = True
        Me.pola.Location = New System.Drawing.Point(18, 20)
        Me.pola.Name = "pola"
        Me.pola.Size = New System.Drawing.Size(28, 13)
        Me.pola.TabIndex = 8
        Me.pola.Text = "Pola"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.okbintang)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.baris)
        Me.Controls.Add(Me.pola)
        Me.Controls.Add(Me.hasilbintang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hasilbintang As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents okbintang As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents baris As System.Windows.Forms.Label
    Friend WithEvents pola As System.Windows.Forms.Label
End Class
