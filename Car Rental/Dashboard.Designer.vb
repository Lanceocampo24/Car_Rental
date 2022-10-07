<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.PLButton = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoPL = New System.Windows.Forms.Panel()
        Me.PLButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'PLButton
        '
        Me.PLButton.BackColor = System.Drawing.Color.Firebrick
        Me.PLButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PLButton.Controls.Add(Me.Button3)
        Me.PLButton.Controls.Add(Me.Button6)
        Me.PLButton.Controls.Add(Me.Button5)
        Me.PLButton.Controls.Add(Me.Button2)
        Me.PLButton.Controls.Add(Me.Button1)
        Me.PLButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PLButton.Location = New System.Drawing.Point(0, 0)
        Me.PLButton.Name = "PLButton"
        Me.PLButton.Size = New System.Drawing.Size(159, 608)
        Me.PLButton.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 46)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Dashboard"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(0, 200)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(160, 46)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Add Car"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(0, 59)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 46)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Rent"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 46)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Payments Section"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Car Rented"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(159, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1211, 608)
        Me.Panel1.TabIndex = 0
        '
        'LogoPL
        '
        Me.LogoPL.AutoScroll = True
        Me.LogoPL.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LogoPL.BackgroundImage = CType(resources.GetObject("LogoPL.BackgroundImage"), System.Drawing.Image)
        Me.LogoPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LogoPL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogoPL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPL.Location = New System.Drawing.Point(159, 0)
        Me.LogoPL.Name = "LogoPL"
        Me.LogoPL.Size = New System.Drawing.Size(1211, 608)
        Me.LogoPL.TabIndex = 3
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 608)
        Me.Controls.Add(Me.LogoPL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PLButton)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.PLButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PLButton As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoPL As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
