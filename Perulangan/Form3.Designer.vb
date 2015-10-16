<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.hitung = New System.Windows.Forms.Button()
        Me.TextBoxhasil = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.hasillabel = New System.Windows.Forms.Label()
        Me.matriks2 = New System.Windows.Forms.Label()
        Me.operasi = New System.Windows.Forms.Label()
        Me.matriks1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(354, 359)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(75, 23)
        Me.hitung.TabIndex = 17
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'TextBoxhasil
        '
        Me.TextBoxhasil.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBoxhasil.Location = New System.Drawing.Point(68, 228)
        Me.TextBoxhasil.Multiline = True
        Me.TextBoxhasil.Name = "TextBoxhasil"
        Me.TextBoxhasil.Size = New System.Drawing.Size(361, 125)
        Me.TextBoxhasil.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(68, 140)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(361, 77)
        Me.TextBox2.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.ComboBox1.Location = New System.Drawing.Point(68, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(361, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 21)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(361, 77)
        Me.TextBox1.TabIndex = 13
        '
        'hasillabel
        '
        Me.hasillabel.AutoSize = True
        Me.hasillabel.Location = New System.Drawing.Point(13, 232)
        Me.hasillabel.Name = "hasillabel"
        Me.hasillabel.Size = New System.Drawing.Size(30, 13)
        Me.hasillabel.TabIndex = 12
        Me.hasillabel.Text = "Hasil"
        '
        'matriks2
        '
        Me.matriks2.AutoSize = True
        Me.matriks2.Location = New System.Drawing.Point(12, 140)
        Me.matriks2.Name = "matriks2"
        Me.matriks2.Size = New System.Drawing.Size(50, 13)
        Me.matriks2.TabIndex = 11
        Me.matriks2.Text = "Matriks 2"
        '
        'operasi
        '
        Me.operasi.AutoSize = True
        Me.operasi.Location = New System.Drawing.Point(12, 108)
        Me.operasi.Name = "operasi"
        Me.operasi.Size = New System.Drawing.Size(43, 13)
        Me.operasi.TabIndex = 10
        Me.operasi.Text = "Operasi"
        '
        'matriks1
        '
        Me.matriks1.AutoSize = True
        Me.matriks1.Location = New System.Drawing.Point(12, 21)
        Me.matriks1.Name = "matriks1"
        Me.matriks1.Size = New System.Drawing.Size(50, 13)
        Me.matriks1.TabIndex = 9
        Me.matriks1.Text = "Matriks 1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.TextBoxhasil)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.hasillabel)
        Me.Controls.Add(Me.matriks2)
        Me.Controls.Add(Me.operasi)
        Me.Controls.Add(Me.matriks1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents TextBoxhasil As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents hasillabel As System.Windows.Forms.Label
    Friend WithEvents matriks2 As System.Windows.Forms.Label
    Friend WithEvents operasi As System.Windows.Forms.Label
    Friend WithEvents matriks1 As System.Windows.Forms.Label
End Class
