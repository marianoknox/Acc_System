<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.btnMinimize = New MetroFramework.Controls.MetroLink()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New MetroFramework.Controls.MetroLink()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.lblPosition = New MetroFramework.Controls.MetroLabel()
        Me.lblUser = New MetroFramework.Controls.MetroLabel()
        Me.pnlTools = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblActiveYear = New System.Windows.Forms.Label()
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel8.SuspendLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(-38, 698)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1251, 23)
        Me.Panel1.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Controls.Add(Me.lblDate)
        Me.Panel8.Controls.Add(Me.MetroLink2)
        Me.Panel8.Controls.Add(Me.btnMinimize)
        Me.Panel8.Controls.Add(Me.lblTime)
        Me.Panel8.Controls.Add(Me.Panel2)
        Me.Panel8.Controls.Add(Me.btnClose)
        Me.Panel8.Controls.Add(Me.pbUser)
        Me.Panel8.Controls.Add(Me.lblPosition)
        Me.Panel8.Controls.Add(Me.lblUser)
        Me.Panel8.Location = New System.Drawing.Point(805, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(395, 53)
        Me.Panel8.TabIndex = 14
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDate.Location = New System.Drawing.Point(54, 32)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(84, 17)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "Oct. 12, 2015"
        '
        'MetroLink2
        '
        Me.MetroLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink2.Image = CType(resources.GetObject("MetroLink2.Image"), System.Drawing.Image)
        Me.MetroLink2.ImageSize = 30
        Me.MetroLink2.Location = New System.Drawing.Point(3, 15)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(36, 34)
        Me.MetroLink2.TabIndex = 16
        Me.MetroLink2.UseSelectable = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageSize = 25
        Me.btnMinimize.Location = New System.Drawing.Point(332, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 28)
        Me.btnMinimize.TabIndex = 30
        Me.btnMinimize.UseSelectable = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblTime.Location = New System.Drawing.Point(49, -4)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(137, 40)
        Me.lblTime.TabIndex = 18
        Me.lblTime.Text = "12:30 PM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 2)
        Me.Panel2.TabIndex = 29
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = 25
        Me.btnClose.Location = New System.Drawing.Point(362, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 28)
        Me.btnClose.TabIndex = 3
        Me.btnClose.UseSelectable = True
        '
        'pbUser
        '
        Me.pbUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(204, 5)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(36, 38)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUser.TabIndex = 0
        Me.pbUser.TabStop = False
        '
        'lblPosition
        '
        Me.lblPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPosition.AutoSize = True
        Me.lblPosition.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblPosition.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblPosition.Location = New System.Drawing.Point(246, 27)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(80, 15)
        Me.lblPosition.Style = MetroFramework.MetroColorStyle.Blue
        Me.lblPosition.TabIndex = 2
        Me.lblPosition.Text = "Administrator"
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblUser.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblUser.Location = New System.Drawing.Point(246, 8)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(30, 15)
        Me.lblUser.Style = MetroFramework.MetroColorStyle.Blue
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "User"
        '
        'pnlTools
        '
        Me.pnlTools.Controls.Add(Me.Panel3)
        Me.pnlTools.Controls.Add(Me.lblActiveYear)
        Me.pnlTools.Location = New System.Drawing.Point(226, 5)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(105, 53)
        Me.pnlTools.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(105, 2)
        Me.Panel3.TabIndex = 28
        '
        'lblActiveYear
        '
        Me.lblActiveYear.AutoSize = True
        Me.lblActiveYear.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveYear.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveYear.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblActiveYear.Location = New System.Drawing.Point(0, -1)
        Me.lblActiveYear.Margin = New System.Windows.Forms.Padding(0)
        Me.lblActiveYear.Name = "lblActiveYear"
        Me.lblActiveYear.Size = New System.Drawing.Size(111, 54)
        Me.lblActiveYear.TabIndex = 19
        Me.lblActiveYear.Text = "2015"
        Me.lblActiveYear.Visible = False
        '
        'tmrDateTime
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.pnlTools)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMain"
        Me.Text = "Accounting System"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.pnlTools.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnMinimize As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroLink
    Friend WithEvents pbUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblPosition As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblActiveYear As System.Windows.Forms.Label

End Class
