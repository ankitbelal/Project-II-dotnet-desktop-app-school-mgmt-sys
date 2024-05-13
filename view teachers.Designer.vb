<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_teachers
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_teachers))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        staffviewgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        searchstaffid = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        searchstaffname = New TextBox()
        clearbutton = New Guna.UI2.WinForms.Guna2Button()
        Panel1 = New Panel()
        searchstaffbtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Label12 = New Label()
        Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Label5 = New Label()
        CType(staffviewgrid, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Guna2ShadowPanel1.SuspendLayout()
        Guna2ShadowPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' staffviewgrid
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(247), CByte(216), CByte(189))
        staffviewgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        staffviewgrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        staffviewgrid.BackgroundColor = Color.Silver
        staffviewgrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        staffviewgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        staffviewgrid.ColumnHeadersHeight = 34
        staffviewgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(249), CByte(229), CByte(211))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(238), CByte(169), CByte(107))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        staffviewgrid.DefaultCellStyle = DataGridViewCellStyle3
        staffviewgrid.GridColor = Color.FromArgb(CByte(245), CByte(209), CByte(177))
        staffviewgrid.Location = New Point(0, 396)
        staffviewgrid.Name = "staffviewgrid"
        staffviewgrid.RowHeadersVisible = False
        staffviewgrid.RowHeadersWidth = 82
        staffviewgrid.Size = New Size(1544, 540)
        staffviewgrid.TabIndex = 1
        staffviewgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot
        staffviewgrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(247), CByte(216), CByte(189))
        staffviewgrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        staffviewgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        staffviewgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        staffviewgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        staffviewgrid.ThemeStyle.BackColor = Color.Silver
        staffviewgrid.ThemeStyle.GridColor = Color.FromArgb(CByte(245), CByte(209), CByte(177))
        staffviewgrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        staffviewgrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised
        staffviewgrid.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        staffviewgrid.ThemeStyle.HeaderStyle.ForeColor = Color.White
        staffviewgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        staffviewgrid.ThemeStyle.HeaderStyle.Height = 34
        staffviewgrid.ThemeStyle.ReadOnly = False
        staffviewgrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(249), CByte(229), CByte(211))
        staffviewgrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        staffviewgrid.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        staffviewgrid.ThemeStyle.RowsStyle.ForeColor = Color.Black
        staffviewgrid.ThemeStyle.RowsStyle.Height = 41
        staffviewgrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(238), CByte(169), CByte(107))
        staffviewgrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' searchstaffid
        ' 
        searchstaffid.Location = New Point(329, 146)
        searchstaffid.Name = "searchstaffid"
        searchstaffid.Size = New Size(200, 39)
        searchstaffid.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(251, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 32)
        Label2.TabIndex = 4
        Label2.Text = "ID :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(575, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 32)
        Label3.TabIndex = 5
        Label3.Text = "Name :"
        ' 
        ' searchstaffname
        ' 
        searchstaffname.Location = New Point(687, 145)
        searchstaffname.Name = "searchstaffname"
        searchstaffname.Size = New Size(200, 39)
        searchstaffname.TabIndex = 6
        ' 
        ' clearbutton
        ' 
        clearbutton.CustomizableEdges = CustomizableEdges1
        clearbutton.DisabledState.BorderColor = Color.DarkGray
        clearbutton.DisabledState.CustomBorderColor = Color.DarkGray
        clearbutton.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        clearbutton.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        clearbutton.FillColor = Color.SteelBlue
        clearbutton.Font = New Font("Segoe UI", 9F)
        clearbutton.ForeColor = Color.White
        clearbutton.Location = New Point(1067, 134)
        clearbutton.Name = "clearbutton"
        clearbutton.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        clearbutton.Size = New Size(174, 54)
        clearbutton.TabIndex = 71
        clearbutton.Text = "clear"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(searchstaffbtn)
        Panel1.Controls.Add(searchstaffid)
        Panel1.Controls.Add(Guna2ShadowPanel1)
        Panel1.Controls.Add(clearbutton)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(searchstaffname)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1520, 290)
        Panel1.TabIndex = 72
        ' 
        ' searchstaffbtn
        ' 
        searchstaffbtn.BackColor = Color.Transparent
        searchstaffbtn.CheckedState.ImageSize = New Size(64, 64)
        searchstaffbtn.HoverState.ImageSize = New Size(64, 64)
        searchstaffbtn.Image = CType(resources.GetObject("searchstaffbtn.Image"), Image)
        searchstaffbtn.ImageOffset = New Point(0, 0)
        searchstaffbtn.ImageRotate = 0F
        searchstaffbtn.Location = New Point(928, 134)
        searchstaffbtn.Name = "searchstaffbtn"
        searchstaffbtn.PressedState.ImageSize = New Size(64, 64)
        searchstaffbtn.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        searchstaffbtn.Size = New Size(80, 64)
        searchstaffbtn.TabIndex = 75
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(Label12)
        Guna2ShadowPanel1.FillColor = SystemColors.ButtonFace
        Guna2ShadowPanel1.Location = New Point(451, 12)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.Size = New Size(471, 68)
        Guna2ShadowPanel1.TabIndex = 74
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.DarkRed
        Label12.Location = New Point(122, 9)
        Label12.Name = "Label12"
        Label12.Size = New Size(228, 45)
        Label12.TabIndex = 70
        Label12.Text = "Filter / Search"
        ' 
        ' Guna2ShadowPanel2
        ' 
        Guna2ShadowPanel2.BackColor = Color.Transparent
        Guna2ShadowPanel2.Controls.Add(Label5)
        Guna2ShadowPanel2.FillColor = Color.WhiteSmoke
        Guna2ShadowPanel2.Location = New Point(12, 306)
        Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Guna2ShadowPanel2.ShadowColor = Color.Black
        Guna2ShadowPanel2.Size = New Size(1520, 85)
        Guna2ShadowPanel2.TabIndex = 73
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stencil", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(565, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(265, 51)
        Label5.TabIndex = 42
        Label5.Text = "All STAFFS"
        ' 
        ' view_teachers
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(1544, 948)
        Controls.Add(Guna2ShadowPanel2)
        Controls.Add(Panel1)
        Controls.Add(staffviewgrid)
        FormBorderStyle = FormBorderStyle.None
        Name = "view_teachers"
        Text = "view_teachers"
        CType(staffviewgrid, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Guna2ShadowPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.PerformLayout()
        Guna2ShadowPanel2.ResumeLayout(False)
        Guna2ShadowPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents staffviewgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents searchstaffid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents searchstaffname As TextBox
    Friend WithEvents clearbutton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents searchstaffbtn As Guna.UI2.WinForms.Guna2ImageButton
End Class
