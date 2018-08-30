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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tb_Spring = New System.Windows.Forms.TextBox()
        Me.tb_Summer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Autumn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Winter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Year = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(185, 149)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(84, 29)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Spring"
        '
        'tb_Spring
        '
        Me.tb_Spring.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Spring.Location = New System.Drawing.Point(272, 146)
        Me.tb_Spring.Name = "tb_Spring"
        Me.tb_Spring.Size = New System.Drawing.Size(347, 35)
        Me.tb_Spring.TabIndex = 1
        '
        'tb_Summer
        '
        Me.tb_Summer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Summer.Location = New System.Drawing.Point(272, 203)
        Me.tb_Summer.Name = "tb_Summer"
        Me.tb_Summer.Size = New System.Drawing.Size(347, 35)
        Me.tb_Summer.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Summer"
        '
        'tb_Autumn
        '
        Me.tb_Autumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Autumn.Location = New System.Drawing.Point(272, 262)
        Me.tb_Autumn.Name = "tb_Autumn"
        Me.tb_Autumn.Size = New System.Drawing.Size(347, 35)
        Me.tb_Autumn.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Autumn"
        '
        'tb_Winter
        '
        Me.tb_Winter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Winter.Location = New System.Drawing.Point(272, 322)
        Me.tb_Winter.Name = "tb_Winter"
        Me.tb_Winter.Size = New System.Drawing.Size(347, 35)
        Me.tb_Winter.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Winter"
        '
        'tb_Year
        '
        Me.tb_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Year.Location = New System.Drawing.Point(272, 86)
        Me.tb_Year.Name = "tb_Year"
        Me.tb_Year.Size = New System.Drawing.Size(85, 35)
        Me.tb_Year.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Year"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tb_Year)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Winter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_Autumn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_Summer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Spring)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "Form1"
        Me.Text = "Seasons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents tb_Spring As System.Windows.Forms.TextBox
    Friend WithEvents tb_Summer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_Autumn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_Winter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_Year As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
