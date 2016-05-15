<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlLogin
    Inherits pnlSlidingControl
    Sub New(ByVal owner As Form)
        MyBase.New(owner)

        InitializeComponent()
    End Sub

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlLogin))
        Me.lnkChangeYear = New MetroFramework.Controls.MetroLink()
        Me.MetroLink17 = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLink14 = New MetroFramework.Controls.MetroLink()
        Me.lblVPN = New MetroFramework.Controls.MetroLink()
        Me.lblIP = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lblLAN = New MetroFramework.Controls.MetroLink()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlYear = New System.Windows.Forms.Panel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.btnAddYear = New MetroFramework.Controls.MetroButton()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnSetYear = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cbYear = New MetroFramework.Controls.MetroComboBox()
        Me.tbUsername = New MetroFramework.Controls.MetroTextBox()
        Me.tbPassword = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.pnlConnect = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlYear.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConnect.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnkChangeYear
        '
        Me.lnkChangeYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkChangeYear.BackColor = System.Drawing.Color.Transparent
        Me.lnkChangeYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkChangeYear.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.lnkChangeYear.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.lnkChangeYear.Image = CType(resources.GetObject("lnkChangeYear.Image"), System.Drawing.Image)
        Me.lnkChangeYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkChangeYear.ImageSize = 25
        Me.lnkChangeYear.Location = New System.Drawing.Point(737, 583)
        Me.lnkChangeYear.Name = "lnkChangeYear"
        Me.lnkChangeYear.Size = New System.Drawing.Size(97, 31)
        Me.lnkChangeYear.Style = MetroFramework.MetroColorStyle.Blue
        Me.lnkChangeYear.TabIndex = 25
        Me.lnkChangeYear.Text = "&Set Year"
        Me.lnkChangeYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lnkChangeYear.UseSelectable = True
        '
        'MetroLink17
        '
        Me.MetroLink17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLink17.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.MetroLink17.Image = CType(resources.GetObject("MetroLink17.Image"), System.Drawing.Image)
        Me.MetroLink17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink17.ImageSize = 30
        Me.MetroLink17.Location = New System.Drawing.Point(17, 596)
        Me.MetroLink17.Name = "MetroLink17"
        Me.MetroLink17.Size = New System.Drawing.Size(170, 23)
        Me.MetroLink17.TabIndex = 24
        Me.MetroLink17.Text = "System's Documentation"
        Me.MetroLink17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLink17.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(17, 545)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel10.TabIndex = 23
        Me.MetroLabel10.Text = "About"
        '
        'MetroLink14
        '
        Me.MetroLink14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLink14.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.MetroLink14.Image = CType(resources.GetObject("MetroLink14.Image"), System.Drawing.Image)
        Me.MetroLink14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink14.ImageSize = 30
        Me.MetroLink14.Location = New System.Drawing.Point(17, 567)
        Me.MetroLink14.Name = "MetroLink14"
        Me.MetroLink14.Size = New System.Drawing.Size(77, 23)
        Me.MetroLink14.TabIndex = 22
        Me.MetroLink14.Text = "Tutorial"
        Me.MetroLink14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLink14.UseSelectable = True
        '
        'lblVPN
        '
        Me.lblVPN.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lblVPN.Image = CType(resources.GetObject("lblVPN.Image"), System.Drawing.Image)
        Me.lblVPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVPN.ImageSize = 15
        Me.lblVPN.Location = New System.Drawing.Point(98, 294)
        Me.lblVPN.Name = "lblVPN"
        Me.lblVPN.NoFocusImage = CType(resources.GetObject("lblVPN.NoFocusImage"), System.Drawing.Image)
        Me.lblVPN.Size = New System.Drawing.Size(117, 15)
        Me.lblVPN.TabIndex = 20
        Me.lblVPN.Text = "Connect via VPN"
        Me.lblVPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblVPN.UseSelectable = True
        '
        'lblIP
        '
        Me.lblIP.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lblIP.Image = CType(resources.GetObject("lblIP.Image"), System.Drawing.Image)
        Me.lblIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblIP.ImageSize = 15
        Me.lblIP.Location = New System.Drawing.Point(98, 273)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.NoFocusImage = CType(resources.GetObject("lblIP.NoFocusImage"), System.Drawing.Image)
        Me.lblIP.Size = New System.Drawing.Size(141, 15)
        Me.lblIP.TabIndex = 19
        Me.lblIP.Text = "Connect via Public IP"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblIP.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(98, 226)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(141, 19)
        Me.MetroLabel5.TabIndex = 18
        Me.MetroLabel5.Text = "Modular Connections"
        '
        'lblLAN
        '
        Me.lblLAN.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lblLAN.Image = CType(resources.GetObject("lblLAN.Image"), System.Drawing.Image)
        Me.lblLAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLAN.ImageSize = 15
        Me.lblLAN.Location = New System.Drawing.Point(98, 250)
        Me.lblLAN.Name = "lblLAN"
        Me.lblLAN.NoFocusImage = CType(resources.GetObject("lblLAN.NoFocusImage"), System.Drawing.Image)
        Me.lblLAN.Size = New System.Drawing.Size(132, 17)
        Me.lblLAN.TabIndex = 17
        Me.lblLAN.Text = "Local Area Network"
        Me.lblLAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLAN.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pnlYear)
        Me.Panel1.Controls.Add(Me.lnkChangeYear)
        Me.Panel1.Location = New System.Drawing.Point(347, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 628)
        Me.Panel1.TabIndex = 5
        '
        'pnlYear
        '
        Me.pnlYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlYear.Controls.Add(Me.MetroButton2)
        Me.pnlYear.Controls.Add(Me.btnAddYear)
        Me.pnlYear.Controls.Add(Me.tbReference)
        Me.pnlYear.Controls.Add(Me.MetroLabel2)
        Me.pnlYear.Controls.Add(Me.btnSetYear)
        Me.pnlYear.Controls.Add(Me.MetroLabel1)
        Me.pnlYear.Controls.Add(Me.cbYear)
        Me.pnlYear.Location = New System.Drawing.Point(598, 342)
        Me.pnlYear.Name = "pnlYear"
        Me.pnlYear.Size = New System.Drawing.Size(232, 238)
        Me.pnlYear.TabIndex = 26
        Me.pnlYear.Visible = False
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(8, 187)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(96, 28)
        Me.MetroButton2.TabIndex = 27
        Me.MetroButton2.Text = "Delete"
        Me.MetroButton2.UseSelectable = True
        '
        'btnAddYear
        '
        Me.btnAddYear.Location = New System.Drawing.Point(161, 50)
        Me.btnAddYear.Name = "btnAddYear"
        Me.btnAddYear.Size = New System.Drawing.Size(61, 28)
        Me.btnAddYear.TabIndex = 26
        Me.btnAddYear.Text = "Add"
        Me.btnAddYear.UseSelectable = True
        '
        'tbReference
        '
        '
        '
        '
        Me.tbReference.CustomButton.Image = Nothing
        Me.tbReference.CustomButton.Location = New System.Drawing.Point(119, 1)
        Me.tbReference.CustomButton.Name = ""
        Me.tbReference.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbReference.CustomButton.TabIndex = 1
        Me.tbReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbReference.CustomButton.UseSelectable = True
        Me.tbReference.CustomButton.Visible = False
        Me.tbReference.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbReference.Lines = New String(-1) {}
        Me.tbReference.Location = New System.Drawing.Point(8, 49)
        Me.tbReference.MaxLength = 32767
        Me.tbReference.Name = "tbReference"
        Me.tbReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbReference.SelectedText = ""
        Me.tbReference.SelectionLength = 0
        Me.tbReference.SelectionStart = 0
        Me.tbReference.Size = New System.Drawing.Size(147, 29)
        Me.tbReference.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbReference.TabIndex = 25
        Me.tbReference.UseSelectable = True
        Me.tbReference.WaterMark = "Enter Year"
        Me.tbReference.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbReference.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(8, 19)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(147, 25)
        Me.MetroLabel2.TabIndex = 24
        Me.MetroLabel2.Text = "Open New Year : "
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'btnSetYear
        '
        Me.btnSetYear.Location = New System.Drawing.Point(110, 187)
        Me.btnSetYear.Name = "btnSetYear"
        Me.btnSetYear.Size = New System.Drawing.Size(112, 28)
        Me.btnSetYear.TabIndex = 23
        Me.btnSetYear.Text = "Set as Default"
        Me.btnSetYear.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 124)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(109, 25)
        Me.MetroLabel1.TabIndex = 22
        Me.MetroLabel1.Text = "Select Year : "
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.ItemHeight = 23
        Me.cbYear.Location = New System.Drawing.Point(8, 152)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(214, 29)
        Me.cbYear.TabIndex = 2
        Me.cbYear.UseSelectable = True
        '
        'tbUsername
        '
        '
        '
        '
        Me.tbUsername.CustomButton.Image = Nothing
        Me.tbUsername.CustomButton.Location = New System.Drawing.Point(219, 2)
        Me.tbUsername.CustomButton.Name = ""
        Me.tbUsername.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbUsername.CustomButton.TabIndex = 1
        Me.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbUsername.CustomButton.UseSelectable = True
        Me.tbUsername.CustomButton.Visible = False
        Me.tbUsername.DisplayIcon = True
        Me.tbUsername.Icon = CType(resources.GetObject("tbUsername.Icon"), System.Drawing.Image)
        Me.tbUsername.Lines = New String(-1) {}
        Me.tbUsername.Location = New System.Drawing.Point(98, 131)
        Me.tbUsername.MaxLength = 32767
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.SelectionLength = 0
        Me.tbUsername.SelectionStart = 0
        Me.tbUsername.Size = New System.Drawing.Size(243, 26)
        Me.tbUsername.Style = MetroFramework.MetroColorStyle.Red
        Me.tbUsername.TabIndex = 2
        Me.tbUsername.UseSelectable = True
        Me.tbUsername.WaterMark = "Username"
        Me.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbPassword
        '
        '
        '
        '
        Me.tbPassword.CustomButton.Image = Nothing
        Me.tbPassword.CustomButton.Location = New System.Drawing.Point(219, 2)
        Me.tbPassword.CustomButton.Name = ""
        Me.tbPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbPassword.CustomButton.TabIndex = 1
        Me.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbPassword.CustomButton.UseSelectable = True
        Me.tbPassword.DisplayIcon = True
        Me.tbPassword.Icon = CType(resources.GetObject("tbPassword.Icon"), System.Drawing.Image)
        Me.tbPassword.Lines = New String(-1) {}
        Me.tbPassword.Location = New System.Drawing.Point(98, 163)
        Me.tbPassword.MaxLength = 32767
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.SelectionLength = 0
        Me.tbPassword.SelectionStart = 0
        Me.tbPassword.ShowButton = True
        Me.tbPassword.Size = New System.Drawing.Size(243, 26)
        Me.tbPassword.Style = MetroFramework.MetroColorStyle.Red
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSelectable = True
        Me.tbPassword.UseSystemPasswordChar = True
        Me.tbPassword.WaterMark = "Password"
        Me.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(174, 45)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(76, 28)
        Me.MetroButton1.TabIndex = 29
        Me.MetroButton1.Text = "Save"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(215, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(7, 10)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(243, 29)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTextBox1.TabIndex = 28
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "IP / Server Name"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(50, 45)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(118, 28)
        Me.MetroButton3.TabIndex = 30
        Me.MetroButton3.Text = "Test Connection"
        Me.MetroButton3.UseSelectable = True
        '
        'pnlConnect
        '
        Me.pnlConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConnect.Controls.Add(Me.MetroButton1)
        Me.pnlConnect.Controls.Add(Me.MetroButton3)
        Me.pnlConnect.Controls.Add(Me.MetroTextBox1)
        Me.pnlConnect.Location = New System.Drawing.Point(347, 237)
        Me.pnlConnect.Name = "pnlConnect"
        Me.pnlConnect.Size = New System.Drawing.Size(258, 86)
        Me.pnlConnect.TabIndex = 31
        Me.pnlConnect.Visible = False
        '
        'pnlLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.pnlConnect)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLink17)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLink14)
        Me.Controls.Add(Me.lblVPN)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.lblLAN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.tbPassword)
        Me.DoubleBuffered = True
        Me.Name = "pnlLogin"
        Me.Size = New System.Drawing.Size(1200, 643)
        Me.Panel1.ResumeLayout(False)
        Me.pnlYear.ResumeLayout(False)
        Me.pnlYear.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConnect.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblVPN As MetroFramework.Controls.MetroLink
    Friend WithEvents lblIP As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLAN As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink17 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink14 As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkChangeYear As MetroFramework.Controls.MetroLink
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlYear As System.Windows.Forms.Panel
    Friend WithEvents cbYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSetYear As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddYear As MetroFramework.Controls.MetroButton
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlConnect As System.Windows.Forms.Panel

End Class
