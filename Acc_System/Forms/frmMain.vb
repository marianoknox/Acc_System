Imports MetroFramework

Public Class frmMain

    '-------------------------------------------------
    'Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or 33554432
    '        Return cp
    '    End Get
    'End Property

    'Private Sub PreventFlicker()
    '    With Me
    '        .SetStyle(ControlStyles.UserPaint, True)
    '        .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    '        .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    '        .UpdateStyles()
    '    End With
    'End Sub
    '------------------------------------------------------------

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'adjust the height of control to avoid glitch in frames
        'If Screen.PrimaryScreen.Bounds.Size.Height > 720 Then
        '    Me.Height = Screen.PrimaryScreen.Bounds.Size.Height - 50
        'End If



        tmrDateTime.Enabled = True
        Dim pnl As New pnlLogin(Me)
        pnl.swipe(True)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim closing = MetroMessageBox.Show(Owner, "Do you want to close the system now?", "System Close", _
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        If closing = Windows.Forms.DialogResult.OK Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub MetroLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink2.Click
        EditEntry = False

        Dim pnl As New pnlHome(Me)
        pnl.swipe(True)
    End Sub
    Private Sub tmrDateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDateTime.Tick
        lblTime.Text = Format(TimeOfDay, "hh:mm tt")
        lblDate.Text = Format(Date.Today, "MMMM dd, yyyy")
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
