<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startloadingform
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startloadingform))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        loadingmainpanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        loadlabel = New Label()
        progressbar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Label1 = New Label()
        Timer = New Timer(components)
        Label3 = New Label()
        Label4 = New Label()
        loadingmainpanel.SuspendLayout()
        progressbar.SuspendLayout()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' loadingmainpanel
        ' 
        loadingmainpanel.Controls.Add(Label4)
        loadingmainpanel.Controls.Add(Label3)
        loadingmainpanel.Controls.Add(loadlabel)
        loadingmainpanel.Controls.Add(progressbar)
        loadingmainpanel.Controls.Add(Label1)
        loadingmainpanel.CustomizableEdges = CustomizableEdges3
        loadingmainpanel.Dock = DockStyle.Fill
        loadingmainpanel.FillColor = Color.CornflowerBlue
        loadingmainpanel.FillColor2 = Color.WhiteSmoke
        loadingmainpanel.FillColor3 = Color.DarkOliveGreen
        loadingmainpanel.FillColor4 = Color.Turquoise
        loadingmainpanel.Location = New Point(0, 0)
        loadingmainpanel.Name = "loadingmainpanel"
        loadingmainpanel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        loadingmainpanel.Size = New Size(1430, 923)
        loadingmainpanel.TabIndex = 0
        ' 
        ' loadlabel
        ' 
        loadlabel.AutoSize = True
        loadlabel.BackColor = Color.Transparent
        loadlabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loadlabel.Location = New Point(535, 693)
        loadlabel.Name = "loadlabel"
        loadlabel.Size = New Size(161, 45)
        loadlabel.TabIndex = 4
        loadlabel.Text = "loading..."
        ' 
        ' progressbar
        ' 
        progressbar.BackColor = Color.Transparent
        progressbar.Controls.Add(Guna2CirclePictureBox1)
        progressbar.FillColor = Color.DarkGray
        progressbar.Font = New Font("Segoe UI", 12F)
        progressbar.ForeColor = Color.White
        progressbar.Location = New Point(433, 134)
        progressbar.Minimum = 0
        progressbar.Name = "progressbar"
        progressbar.ProgressColor = Color.Fuchsia
        progressbar.ProgressColor2 = Color.DodgerBlue
        progressbar.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        progressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        progressbar.ShowText = True
        progressbar.Size = New Size(475, 475)
        progressbar.TabIndex = 2
        progressbar.Text = "Guna2CircleProgressBar1"
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), Image)
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(19, 23)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(436, 427)
        Guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox1.TabIndex = 0
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 22.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.GhostWhite
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1287, 74)
        Label1.TabIndex = 1
        Label1.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Timer
        ' 
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(709, 830)
        Label3.Name = "Label3"
        Label3.Size = New Size(239, 50)
        Label3.TabIndex = 5
        Label3.Text = "Powered By "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(931, 831)
        Label4.Name = "Label4"
        Label4.Size = New Size(356, 50)
        Label4.TabIndex = 7
        Label4.Text = "Saraswati Software"
        ' 
        ' startloadingform
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1430, 923)
        Controls.Add(loadingmainpanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "startloadingform"
        Text = "startloadingform"
        loadingmainpanel.ResumeLayout(False)
        loadingmainpanel.PerformLayout()
        progressbar.ResumeLayout(False)
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents loadingmainpanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents progressbar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timer As Timer
    Friend WithEvents loadlabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
