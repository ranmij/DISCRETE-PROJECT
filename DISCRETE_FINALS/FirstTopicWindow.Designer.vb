﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FirstTopicWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstTopicWindow))
        Me.TopicDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FirstTopicPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.FirstTopicPanel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TopicCode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BackButton = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.NextButton = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.FirstTopicPanel.SuspendLayout()
        Me.FirstTopicPanel2.SuspendLayout()
        CType(Me.TopicCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopicDescription
        '
        Me.TopicDescription.AutoSize = True
        Me.TopicDescription.BorderThickness = 0
        Me.TopicDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TopicDescription.DefaultText = resources.GetString("TopicDescription.DefaultText")
        Me.TopicDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TopicDescription.DisabledState.FillColor = System.Drawing.Color.White
        Me.TopicDescription.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.TopicDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TopicDescription.Enabled = False
        Me.TopicDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TopicDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TopicDescription.ForeColor = System.Drawing.Color.Black
        Me.TopicDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TopicDescription.Location = New System.Drawing.Point(24, 66)
        Me.TopicDescription.Margin = New System.Windows.Forms.Padding(1)
        Me.TopicDescription.Multiline = True
        Me.TopicDescription.Name = "TopicDescription"
        Me.TopicDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TopicDescription.PlaceholderText = ""
        Me.TopicDescription.SelectedText = ""
        Me.TopicDescription.Size = New System.Drawing.Size(585, 139)
        Me.TopicDescription.TabIndex = 2
        '
        'FirstTopicPanel
        '
        Me.FirstTopicPanel.AutoScroll = True
        Me.FirstTopicPanel.Controls.Add(Me.BackButton)
        Me.FirstTopicPanel.Controls.Add(Me.FirstTopicPanel2)
        Me.FirstTopicPanel.Controls.Add(Me.TopicCode)
        Me.FirstTopicPanel.Controls.Add(Me.TopicDescription)
        Me.FirstTopicPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirstTopicPanel.Location = New System.Drawing.Point(0, 0)
        Me.FirstTopicPanel.Name = "FirstTopicPanel"
        Me.FirstTopicPanel.Size = New System.Drawing.Size(642, 423)
        Me.FirstTopicPanel.TabIndex = 3
        '
        'FirstTopicPanel2
        '
        Me.FirstTopicPanel2.Controls.Add(Me.NextButton)
        Me.FirstTopicPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FirstTopicPanel2.Location = New System.Drawing.Point(0, 926)
        Me.FirstTopicPanel2.Name = "FirstTopicPanel2"
        Me.FirstTopicPanel2.Size = New System.Drawing.Size(625, 69)
        Me.FirstTopicPanel2.TabIndex = 4
        '
        'TopicCode
        '
        Me.TopicCode.Image = Global.DISCRETE_FINALS.My.Resources.Resources.Intersection
        Me.TopicCode.ImageRotate = 0!
        Me.TopicCode.Location = New System.Drawing.Point(24, 226)
        Me.TopicCode.Name = "TopicCode"
        Me.TopicCode.Size = New System.Drawing.Size(585, 700)
        Me.TopicCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TopicCode.TabIndex = 3
        Me.TopicCode.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.Image = Global.DISCRETE_FINALS.My.Resources.Resources.undo__1_
        Me.BackButton.ImageRotate = 0!
        Me.BackButton.Location = New System.Drawing.Point(24, 12)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BackButton.Size = New System.Drawing.Size(39, 39)
        Me.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackButton.TabIndex = 5
        Me.BackButton.TabStop = False
        '
        'NextButton
        '
        Me.NextButton.Image = Global.DISCRETE_FINALS.My.Resources.Resources.right_arrow
        Me.NextButton.ImageRotate = 0!
        Me.NextButton.Location = New System.Drawing.Point(570, 18)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.NextButton.Size = New System.Drawing.Size(39, 39)
        Me.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NextButton.TabIndex = 7
        Me.NextButton.TabStop = False
        '
        'FirstTopicWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.Add(Me.FirstTopicPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FirstTopicWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INTERSECTION OF SETS"
        Me.FirstTopicPanel.ResumeLayout(False)
        Me.FirstTopicPanel.PerformLayout()
        Me.FirstTopicPanel2.ResumeLayout(False)
        CType(Me.TopicCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopicDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FirstTopicPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TopicCode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents FirstTopicPanel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BackButton As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents NextButton As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
