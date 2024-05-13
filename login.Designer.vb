<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        closebox = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        logincontrolpanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label1 = New Label()
        panelspace = New Panel()
        logincontrolpanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox2.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2ControlBox2.IconColor = Color.White
        Guna2ControlBox2.Location = New Point(1276, 0)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox2.Size = New Size(77, 48)
        Guna2ControlBox2.TabIndex = 16
        ' 
        ' closebox
        ' 
        closebox.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        closebox.CustomizableEdges = CustomizableEdges3
        closebox.FillColor = Color.DarkRed
        closebox.IconColor = Color.White
        closebox.Location = New Point(1355, 0)
        closebox.Name = "closebox"
        closebox.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        closebox.Size = New Size(77, 48)
        closebox.TabIndex = 15
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = logincontrolpanel
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' logincontrolpanel
        ' 
        logincontrolpanel.Controls.Add(Label1)
        logincontrolpanel.Controls.Add(Guna2ControlBox2)
        logincontrolpanel.Controls.Add(closebox)
        logincontrolpanel.CustomizableEdges = CustomizableEdges5
        logincontrolpanel.Dock = DockStyle.Top
        logincontrolpanel.FillColor2 = Color.DodgerBlue
        logincontrolpanel.FillColor3 = Color.SlateBlue
        logincontrolpanel.FillColor4 = Color.DarkGreen
        logincontrolpanel.Location = New Point(0, 0)
        logincontrolpanel.Name = "logincontrolpanel"
        logincontrolpanel.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        logincontrolpanel.Size = New Size(1435, 48)
        logincontrolpanel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 32)
        Label1.TabIndex = 0
        Label1.Text = "login"
        ' 
        ' panelspace
        ' 
        panelspace.BackColor = Color.Transparent
        panelspace.Dock = DockStyle.Fill
        panelspace.Location = New Point(0, 48)
        panelspace.Name = "panelspace"
        panelspace.Size = New Size(1435, 934)
        panelspace.TabIndex = 2
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1435, 982)
        Controls.Add(panelspace)
        Controls.Add(logincontrolpanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        Text = "login"
        logincontrolpanel.ResumeLayout(False)
        logincontrolpanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents closebox As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents logincontrolpanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents panelspace As Panel
    Friend WithEvents Label1 As Label
End Class
