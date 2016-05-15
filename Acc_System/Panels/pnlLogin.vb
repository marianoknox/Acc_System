Imports MetroFramework

Public Class pnlLogin

    

    Private Sub pnlLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.lblActiveYear.Visible = False
        tbUsername.Focus()

    End Sub

    Private Sub tbPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPassword.ButtonClick
        Dim pass = testConnect()
        If pass = False Then
            Exit Sub
        End If

        Dim pnl As New pnlHome(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub lnkChangeYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkChangeYear.Click
        If pnlYear.Visible = True Then
            pnlYear.Visible = False
        Else
            pnlYear.Visible = True
        End If
    End Sub

    Private Sub btnSetYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetYear.Click
        Dim setYear = MetroMessageBox.Show(frmMain, "Change year now?", "Change Year", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        If setYear = DialogResult.OK Then

            MetroMessageBox.Show(frmMain, "Default year has been altered. The system will be needing a complete reload to complete the changes", "Change Year", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmMain.Close()
        End If
    End Sub

    Private Sub lblLAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLAN.Click
        showConnect()

    End Sub
    Private Sub showConnect()
        If pnlConnect.Visible = True Then
            pnlConnect.Visible = False
        Else
            pnlConnect.Visible = True
        End If
    End Sub

    Private Sub lblIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIP.Click
        showConnect()
    End Sub

    Private Sub lblVPN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVPN.Click
        showConnect()
    End Sub
End Class
