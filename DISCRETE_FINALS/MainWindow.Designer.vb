<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MembersButton = New Guna.UI2.WinForms.Guna2TileButton()
        Me.TopicsButton = New Guna.UI2.WinForms.Guna2TileButton()
        Me.AboutButton = New Guna.UI2.WinForms.Guna2TileButton()
        Me.ExitButton = New Guna.UI2.WinForms.Guna2TileButton()
        Me.SuspendLayout()
        '
        'MembersButton
        '
        Me.MembersButton.BorderThickness = 2
        Me.MembersButton.CustomBorderColor = System.Drawing.Color.Black
        Me.MembersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.MembersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.MembersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.MembersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.MembersButton.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembersButton.ForeColor = System.Drawing.Color.White
        Me.MembersButton.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.MembersButton.HoverState.FillColor = System.Drawing.Color.Black
        Me.MembersButton.HoverState.ForeColor = System.Drawing.Color.White
        Me.MembersButton.Location = New System.Drawing.Point(156, 133)
        Me.MembersButton.Name = "MembersButton"
        Me.MembersButton.Size = New System.Drawing.Size(308, 63)
        Me.MembersButton.TabIndex = 1
        Me.MembersButton.Text = "MEMBERS"
        '
        'TopicsButton
        '
        Me.TopicsButton.BorderThickness = 2
        Me.TopicsButton.CustomBorderColor = System.Drawing.Color.Black
        Me.TopicsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.TopicsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.TopicsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.TopicsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TopicsButton.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopicsButton.ForeColor = System.Drawing.Color.White
        Me.TopicsButton.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TopicsButton.HoverState.FillColor = System.Drawing.Color.Black
        Me.TopicsButton.HoverState.ForeColor = System.Drawing.Color.White
        Me.TopicsButton.Location = New System.Drawing.Point(156, 45)
        Me.TopicsButton.Name = "TopicsButton"
        Me.TopicsButton.Size = New System.Drawing.Size(308, 63)
        Me.TopicsButton.TabIndex = 2
        Me.TopicsButton.Text = "TOPICS"
        '
        'AboutButton
        '
        Me.AboutButton.BorderThickness = 2
        Me.AboutButton.CustomBorderColor = System.Drawing.Color.Black
        Me.AboutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AboutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AboutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AboutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AboutButton.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.ForeColor = System.Drawing.Color.White
        Me.AboutButton.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.AboutButton.HoverState.FillColor = System.Drawing.Color.Black
        Me.AboutButton.HoverState.ForeColor = System.Drawing.Color.White
        Me.AboutButton.Location = New System.Drawing.Point(156, 222)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(308, 63)
        Me.AboutButton.TabIndex = 3
        Me.AboutButton.Text = "ABOUT"
        '
        'ExitButton
        '
        Me.ExitButton.BorderThickness = 2
        Me.ExitButton.CustomBorderColor = System.Drawing.Color.Black
        Me.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.ExitButton.HoverState.FillColor = System.Drawing.Color.Black
        Me.ExitButton.HoverState.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(156, 308)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(308, 63)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "EXIT"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.TopicsButton)
        Me.Controls.Add(Me.MembersButton)
        Me.Name = "MainWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DISCRETE FINALS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MembersButton As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents TopicsButton As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents AboutButton As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents ExitButton As Guna.UI2.WinForms.Guna2TileButton
End Class
