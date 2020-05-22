<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataPenjualan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelRerata = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelTertinggi = New System.Windows.Forms.Label()
        Me.labelTerendah = New System.Windows.Forms.Label()
        Me.tombolHitung = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelTerendah)
        Me.GroupBox1.Controls.Add(Me.labelTertinggi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.labelRerata)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.labelTotal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Penjualan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Penjualan Total"
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelTotal.Location = New System.Drawing.Point(124, 23)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(129, 23)
        Me.labelTotal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Penjualan Rerata"
        '
        'labelRerata
        '
        Me.labelRerata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelRerata.Location = New System.Drawing.Point(124, 61)
        Me.labelRerata.Name = "labelRerata"
        Me.labelRerata.Size = New System.Drawing.Size(129, 23)
        Me.labelRerata.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Penjualan Tertinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Penjualan Terendah"
        '
        'labelTertinggi
        '
        Me.labelTertinggi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelTertinggi.Location = New System.Drawing.Point(124, 93)
        Me.labelTertinggi.Name = "labelTertinggi"
        Me.labelTertinggi.Size = New System.Drawing.Size(129, 23)
        Me.labelTertinggi.TabIndex = 6
        '
        'labelTerendah
        '
        Me.labelTerendah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelTerendah.Location = New System.Drawing.Point(124, 125)
        Me.labelTerendah.Name = "labelTerendah"
        Me.labelTerendah.Size = New System.Drawing.Size(129, 23)
        Me.labelTerendah.TabIndex = 7
        '
        'tombolHitung
        '
        Me.tombolHitung.Location = New System.Drawing.Point(13, 193)
        Me.tombolHitung.Name = "tombolHitung"
        Me.tombolHitung.Size = New System.Drawing.Size(104, 45)
        Me.tombolHitung.TabIndex = 1
        Me.tombolHitung.Text = "Hitung Data Penjualan"
        Me.tombolHitung.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(168, 193)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(104, 45)
        Me.tombolKeluar.TabIndex = 2
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 247)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolHitung)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Data Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents labelTerendah As System.Windows.Forms.Label
    Friend WithEvents labelTertinggi As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labelRerata As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labelTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tombolHitung As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
