<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewstudents
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewstudents))
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        stdviewDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        stdgradebox = New Guna.UI2.WinForms.Guna2ComboBox()
        Label10 = New Label()
        Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        studentlabel = New Label()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Label12 = New Label()
        studentsearchbtn = New Guna.UI2.WinForms.Guna2ImageButton()
        stdrollno = New TextBox()
        clearbutton = New Guna.UI2.WinForms.Guna2Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        CType(stdviewDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ShadowPanel2.SuspendLayout()
        Guna2ShadowPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' stdviewDataGridView
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(247), CByte(216), CByte(189))
        stdviewDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        stdviewDataGridView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        stdviewDataGridView.BackgroundColor = Color.Silver
        stdviewDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        stdviewDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        stdviewDataGridView.ColumnHeadersHeight = 34
        stdviewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(249), CByte(229), CByte(211))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(238), CByte(169), CByte(107))
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        stdviewDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        stdviewDataGridView.GridColor = Color.FromArgb(CByte(245), CByte(209), CByte(177))
        stdviewDataGridView.Location = New Point(0, 398)
        stdviewDataGridView.Name = "stdviewDataGridView"
        stdviewDataGridView.RowHeadersVisible = False
        stdviewDataGridView.RowHeadersWidth = 82
        stdviewDataGridView.Size = New Size(1544, 544)
        stdviewDataGridView.TabIndex = 0
        stdviewDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot
        stdviewDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(247), CByte(216), CByte(189))
        stdviewDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        stdviewDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        stdviewDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        stdviewDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        stdviewDataGridView.ThemeStyle.BackColor = Color.Silver
        stdviewDataGridView.ThemeStyle.GridColor = Color.FromArgb(CByte(245), CByte(209), CByte(177))
        stdviewDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        stdviewDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised
        stdviewDataGridView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        stdviewDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        stdviewDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        stdviewDataGridView.ThemeStyle.HeaderStyle.Height = 34
        stdviewDataGridView.ThemeStyle.ReadOnly = False
        stdviewDataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(249), CByte(229), CByte(211))
        stdviewDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        stdviewDataGridView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        stdviewDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black
        stdviewDataGridView.ThemeStyle.RowsStyle.Height = 41
        stdviewDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(238), CByte(169), CByte(107))
        stdviewDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' stdgradebox
        ' 
        stdgradebox.AutoCompleteCustomSource.AddRange(New String() {"NURSERY", "L.K.G", "U.K.G", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Tewlve"})
        stdgradebox.AutoRoundedCorners = True
        stdgradebox.BackColor = Color.Transparent
        stdgradebox.BorderRadius = 17
        stdgradebox.CustomizableEdges = CustomizableEdges6
        stdgradebox.DrawMode = DrawMode.OwnerDrawFixed
        stdgradebox.DropDownStyle = ComboBoxStyle.DropDownList
        stdgradebox.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        stdgradebox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        stdgradebox.Font = New Font("Segoe UI", 10F)
        stdgradebox.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        stdgradebox.ItemHeight = 30
        stdgradebox.Items.AddRange(New Object() {"NURSERY", "L.K.G", "U.K.G", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Tewlve"})
        stdgradebox.Location = New Point(19, 150)
        stdgradebox.Name = "stdgradebox"
        stdgradebox.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        stdgradebox.Size = New Size(308, 36)
        stdgradebox.TabIndex = 28
        stdgradebox.Tag = ""
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(38, 104)
        Label10.Name = "Label10"
        Label10.Size = New Size(93, 32)
        Label10.TabIndex = 29
        Label10.Text = "Grade*"
        ' 
        ' Guna2ShadowPanel2
        ' 
        Guna2ShadowPanel2.BackColor = Color.Transparent
        Guna2ShadowPanel2.Controls.Add(studentlabel)
        Guna2ShadowPanel2.FillColor = Color.WhiteSmoke
        Guna2ShadowPanel2.Location = New Point(12, 317)
        Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Guna2ShadowPanel2.ShadowColor = Color.Black
        Guna2ShadowPanel2.Size = New Size(1520, 85)
        Guna2ShadowPanel2.TabIndex = 74
        ' 
        ' studentlabel
        ' 
        studentlabel.AutoSize = True
        studentlabel.Font = New Font("Stencil", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentlabel.Location = New Point(359, 17)
        studentlabel.Name = "studentlabel"
        studentlabel.Size = New Size(0, 51)
        studentlabel.TabIndex = 42
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(Label12)
        Guna2ShadowPanel1.FillColor = SystemColors.ButtonFace
        Guna2ShadowPanel1.Location = New Point(461, 7)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.Size = New Size(509, 61)
        Guna2ShadowPanel1.TabIndex = 75
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.DarkRed
        Label12.Location = New Point(130, 7)
        Label12.Name = "Label12"
        Label12.Size = New Size(228, 45)
        Label12.TabIndex = 70
        Label12.Text = "Filter / Search"
        ' 
        ' studentsearchbtn
        ' 
        studentsearchbtn.BackColor = Color.Transparent
        studentsearchbtn.CheckedState.ImageSize = New Size(64, 64)
        studentsearchbtn.HoverState.ImageSize = New Size(64, 64)
        studentsearchbtn.Image = CType(resources.GetObject("studentsearchbtn.Image"), Image)
        studentsearchbtn.ImageOffset = New Point(0, 0)
        studentsearchbtn.ImageRotate = 0F
        studentsearchbtn.Location = New Point(1049, 138)
        studentsearchbtn.Name = "studentsearchbtn"
        studentsearchbtn.PressedState.ImageSize = New Size(64, 64)
        studentsearchbtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        studentsearchbtn.Size = New Size(80, 64)
        studentsearchbtn.TabIndex = 81
        ' 
        ' stdrollno
        ' 
        stdrollno.Location = New Point(469, 148)
        stdrollno.Name = "stdrollno"
        stdrollno.Size = New Size(200, 39)
        stdrollno.TabIndex = 76
        ' 
        ' clearbutton
        ' 
        clearbutton.CustomizableEdges = CustomizableEdges9
        clearbutton.DisabledState.BorderColor = Color.DarkGray
        clearbutton.DisabledState.CustomBorderColor = Color.DarkGray
        clearbutton.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        clearbutton.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        clearbutton.FillColor = Color.SteelBlue
        clearbutton.Font = New Font("Segoe UI", 9F)
        clearbutton.ForeColor = Color.White
        clearbutton.Location = New Point(1188, 138)
        clearbutton.Name = "clearbutton"
        clearbutton.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        clearbutton.Size = New Size(174, 54)
        clearbutton.TabIndex = 80
        clearbutton.Text = "clear"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(363, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 32)
        Label2.TabIndex = 77
        Label2.Text = "Roll no :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(808, 149)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 39)
        TextBox2.TabIndex = 79
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(696, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 32)
        Label3.TabIndex = 78
        Label3.Text = "Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1026, 205)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 32)
        Label1.TabIndex = 82
        Label1.Text = "View profile"
        ' 
        ' viewstudents
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(1544, 948)
        Controls.Add(Label1)
        Controls.Add(studentsearchbtn)
        Controls.Add(stdrollno)
        Controls.Add(clearbutton)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Guna2ShadowPanel1)
        Controls.Add(Guna2ShadowPanel2)
        Controls.Add(Label10)
        Controls.Add(stdgradebox)
        Controls.Add(stdviewDataGridView)
        FormBorderStyle = FormBorderStyle.None
        Name = "viewstudents"
        Text = "viewstudents"
        CType(stdviewDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Guna2ShadowPanel2.ResumeLayout(False)
        Guna2ShadowPanel2.PerformLayout()
        Guna2ShadowPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents stdviewDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents stdgradebox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents studentlabel As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents studentsearchbtn As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents stdrollno As TextBox
    Friend WithEvents clearbutton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
