<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addstudentdatagridview
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
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        SN = New DataGridViewTextBoxColumn()
        stdfirstname = New DataGridViewTextBoxColumn()
        stdlastname = New DataGridViewTextBoxColumn()
        stdrollno = New DataGridViewTextBoxColumn()
        stdaddress = New DataGridViewTextBoxColumn()
        stdgender = New DataGridViewTextBoxColumn()
        stddob = New DataGridViewTextBoxColumn()
        stdcontact = New DataGridViewTextBoxColumn()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(247), CByte(216), CByte(189))
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Guna2DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2DataGridView1.BackgroundColor = Color.Silver
        Guna2DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 34
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.Columns.AddRange(New DataGridViewColumn() {SN, stdfirstname, stdlastname, stdrollno, stdaddress, stdgender, stddob, stdcontact})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(249), CByte(229), CByte(211))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(238), CByte(169), CByte(107))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(245), CByte(209), CByte(177))
        Guna2DataGridView1.Location = New Point(8, 107)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowHeadersWidth = 82
        Guna2DataGridView1.Size = New Size(1534, 836)
        Guna2DataGridView1.TabIndex = 1
        Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(247), CByte(216), CByte(189))
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.Silver
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(245), CByte(209), CByte(177))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 34
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(249), CByte(229), CByte(211))
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.Black
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 41
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(238), CByte(169), CByte(107))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' SN
        ' 
        SN.FillWeight = 51.28205F
        SN.HeaderText = "SN."
        SN.MinimumWidth = 10
        SN.Name = "SN"
        ' 
        ' stdfirstname
        ' 
        stdfirstname.FillWeight = 106.959709F
        stdfirstname.HeaderText = "First Name"
        stdfirstname.MinimumWidth = 10
        stdfirstname.Name = "stdfirstname"
        ' 
        ' stdlastname
        ' 
        stdlastname.FillWeight = 106.959709F
        stdlastname.HeaderText = "Last Name"
        stdlastname.MinimumWidth = 10
        stdlastname.Name = "stdlastname"
        ' 
        ' stdrollno
        ' 
        stdrollno.FillWeight = 106.959709F
        stdrollno.HeaderText = "Roll No"
        stdrollno.MinimumWidth = 10
        stdrollno.Name = "stdrollno"
        ' 
        ' stdaddress
        ' 
        stdaddress.FillWeight = 106.959709F
        stdaddress.HeaderText = "Address"
        stdaddress.MinimumWidth = 10
        stdaddress.Name = "stdaddress"
        ' 
        ' stdgender
        ' 
        stdgender.FillWeight = 106.959709F
        stdgender.HeaderText = "Gender"
        stdgender.MinimumWidth = 10
        stdgender.Name = "stdgender"
        ' 
        ' stddob
        ' 
        stddob.FillWeight = 106.959709F
        stddob.HeaderText = "DOB"
        stddob.MinimumWidth = 10
        stddob.Name = "stddob"
        ' 
        ' stdcontact
        ' 
        stdcontact.FillWeight = 106.959709F
        stdcontact.HeaderText = "Contact"
        stdcontact.MinimumWidth = 10
        stdcontact.Name = "stdcontact"
        ' 
        ' addstudentdatagridview
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1544, 948)
        Controls.Add(Guna2DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "addstudentdatagridview"
        Text = "addstudentdatagridview"
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SN As DataGridViewTextBoxColumn
    Friend WithEvents stdfirstname As DataGridViewTextBoxColumn
    Friend WithEvents stdlastname As DataGridViewTextBoxColumn
    Friend WithEvents stdrollno As DataGridViewTextBoxColumn
    Friend WithEvents stdaddress As DataGridViewTextBoxColumn
    Friend WithEvents stdgender As DataGridViewTextBoxColumn
    Friend WithEvents stddob As DataGridViewTextBoxColumn
    Friend WithEvents stdcontact As DataGridViewTextBoxColumn
End Class
