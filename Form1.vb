Imports System.Threading
Imports System.Runtime.InteropServices

Public Class frmAim
    Dim productVersion As String = "1.0.0.0"
    Dim updateNotes As String = "You have the most latest version of Aim Help!" & vbNewLine & vbNewLine & "Update Notes:" & vbNewLine & "This is version 1.0.0.0"

    Dim aimhelp_version As String = "https://www.dropbox.com/s/nodycsmbro6ws3m/aimhelpversion.txt?dl=1"

    Dim timeCounter As Integer = 0

    Dim currentTarget As PictureBox = New PictureBox

    Dim topmoststr As String = ""

    Dim xMax As Integer = 725
    Dim yMax As Integer = 500

    Dim startup As Boolean = True

    Dim rand As New Random

    Dim totalClicks As Integer = 0
    Dim correctClicks As Integer = 0
    Dim targetsSpawned As Integer = 1

    Dim multiplier As Double = 1

    Dim game_started As Boolean = False

    Dim colorAccent As System.Drawing.Color

    Dim acceptable As Boolean = False

    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#95")>
    Public Shared Function GetImmersiveColorFromColorSetEx(ByVal dwImmersiveColorSet As UInteger, ByVal dwImmersiveColorType As UInteger, ByVal bIgnoreHighContrast As Boolean, ByVal dwHighContrastCacheMode As UInteger) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#96")>
    Public Shared Function GetImmersiveColorTypeFromName(ByVal pName As IntPtr) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#98")>
    Public Shared Function GetImmersiveUserColorSetPreference(ByVal bForceCheckRegistry As Boolean, ByVal bSkipCheckOnFail As Boolean) As UInteger
    End Function



    Private Sub frmAim_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, lblStart.Click
        If acceptable = True Then
            If startup = True Then
                If BackgroundWorker1.IsBusy = True Then
                    Exit Sub
                End If
                Me.Controls.Add(currentTarget)
                lblStart.CheckForIllegalCrossThreadCalls = False
                BackgroundWorker1.RunWorkerAsync()
            End If

            tmrGen.Start()
            tmrCheck.Start()

            totalClicks += 1
        End If
    End Sub

    Private Sub tmrGen_Tick(sender As Object, e As EventArgs) Handles tmrGen.Tick
        If BackgroundWorker1.IsBusy = False Then
            timeCounter += tmrGen.Interval
            If CDbl(timeCounter) = CDbl(1000 * multiplier) Then
                SpawnTarget()
            End If
        End If
    End Sub
    Private Sub correctclicked()
        '   My.Computer.Audio.Play("hit.wav")
        tmrGen.Stop()
        correctClicks += 1
        totalClicks += 1
        SpawnTarget()
    End Sub
    Private Sub SpawnTarget()
        timeCounter = 0
        currentTarget.Hide()
        currentTarget.Location = New Point(rand.Next(0, xMax), rand.Next(0, yMax))
        currentTarget.Show()
        targetsSpawned += 1
        If tmrGen.Enabled = False Then
            tmrGen.Start()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim count As Integer = 3
        Do
            If count = 3 Then
                lblStart.ForeColor = Color.Red
            ElseIf count = 2 Then
                lblStart.ForeColor = Color.Yellow
            ElseIf count = 1 Then
                lblStart.ForeColor = Color.YellowGreen
            End If
            lblStart.Text = "                   " & count
            Refresh()
            Thread.Sleep(1000)
            count -= 1
            If count = 0 Then
                lblStart.ForeColor = Color.Green
                lblStart.Font = New Font("Times New Roman", 50, FontStyle.Bold)
                lblStart.Text = "       GO!"
                lblStart.Location = New Point(lblStart.Location.X, lblStart.Location.Y - 20)
                Exit Do
            End If
        Loop



        Refresh()
        Thread.Sleep(250)
        lblStart.Hide()

        currentTarget.Size = New Size(50, 50)
        currentTarget.BackColor = Color.Red
        currentTarget.Location = New Point(rand.Next(0, xMax), rand.Next(0, yMax))
        currentTarget.Image = My.Resources.Black_background_target
        currentTarget.SizeMode = PictureBoxSizeMode.StretchImage
        AddHandler currentTarget.Click, AddressOf correctclicked

        correctClicks = 0
        totalClicks = 0

        startup = False
        game_started = True
        e.Cancel = True
    End Sub

    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        If BackgroundWorker1.IsBusy = False Then
            lblClicksCorrect.Text = "Correct Clicks: " & correctClicks
            lblClicksTotal.Text = "Total Clicks: " & totalClicks
            lblSpawned.Text = "Targets Spawned: " & targetsSpawned
        End If
    End Sub

    Private Sub frmAim_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, btnTM.KeyDown, btnSave.KeyDown, btnLeaderboard.KeyDown, btnColor.KeyDown, pnlMenu.KeyDown, pnlSettings.KeyDown, pnlLeaderboard.KeyDown, btnHigher.KeyDown, btnLower.KeyDown, ListView1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If topmoststr = "menu" Then
                If pnlMenu.Location.Y = 28 Then

                    For Each c As Control In Controls
                        c.Enabled = True
                    Next
                    tmrCheck.Stop()
                    tmrGen.Stop()
                    pnlMenu.Enabled = False
                    pnlSettings.Enabled = True

                    For i As Integer = 0 To 15
                        pnlMenu.Location = New Point(pnlMenu.Location.X, pnlMenu.Location.Y + 40)
                        Refresh()
                        Thread.Sleep(1)
                    Next
                    My.Computer.Audio.Stop()
                    acceptable = True
                    If game_started = True Then
                        tmrCheck.Start()
                        tmrGen.Start()
                    End If
                Else
                    tmrCheck.Stop()
                    tmrGen.Stop()
                    For Each c As Control In Controls
                        c.Enabled = False
                    Next
                    pnlMenu.Enabled = True
                    pnlSettings.Enabled = True
                    pnlLeaderboard.Enabled = True
                    For i As Integer = 0 To 15
                        pnlMenu.Location = New Point(pnlMenu.Location.X, pnlMenu.Location.Y - 40)
                        Refresh()
                        Thread.Sleep(1)
                    Next
                    Try
                        My.Computer.Audio.Play("themeback.wav", AudioPlayMode.BackgroundLoop)
                    Catch ex As Exception
                        MessageBox.Show("The sound file cannot be found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    acceptable = False
                    lblClicksCorrect.Enabled = True
                    lblClicksTotal.Enabled = True
                    lblSpawned.Enabled = True

                    topmoststr = "menu"
                    pnlSettings.Select()
                End If
            ElseIf topmoststr = "settings" Then
                closeopenSettings()
            ElseIf topmoststr = "leaderboard" Then
                closeopenLeaderboard()
            End If
        End If
    End Sub
    Private Sub refreshLeaderboard()
        ListView1.Items.Clear()
        Dim leaderstuff() As String = Split(My.Settings.scoreboard, "|")
        For i As Integer = 0 To leaderstuff.Length - 1
            Dim leadnewstuff() As String = Split(leaderstuff(i), ":")
            Dim lsvitem As ListViewItem = New ListViewItem(leadnewstuff)
            ListView1.Items.Add(lsvitem)
        Next
    End Sub
    Private Sub frmAim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshLeaderboard()
        btnTM.PerformClick()

        topmoststr = "menu"
        pnlSettings.Visible = False
        pnlSettings.Location = New Point(593, 28)

        pnlLeaderboard.Visible = False
        pnlLeaderboard.Location = New Point(593, 28)

        Dim colorSystemAccent As UInteger = GetImmersiveColorFromColorSetEx(GetImmersiveUserColorSetPreference(False, False), GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveSystemAccent")), False, 0)
        colorAccent = System.Drawing.Color.FromArgb((&HFF000000 And colorSystemAccent) >> 24, &HFF And colorSystemAccent, (&HFF00 And colorSystemAccent) >> 8, (&HFF0000 And colorSystemAccent) >> 16)

        setColor(colorAccent)

        Me.Text = "Aimer | BETA | " & productVersion

        Try
            My.Computer.Audio.Play("themeback.wav", AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MessageBox.Show("The sound file cannot be found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Select()
    End Sub

    Private Sub setColor(giverColor As Color)
        picBorderTop.BackColor = giverColor
        picBorderBottom.BackColor = giverColor
        picBorderMid.BackColor = giverColor
        picBorderLeft.BackColor = giverColor
        picBorderRight.BackColor = giverColor

        lblMenu.ForeColor = giverColor
        lblLeaderboard.ForeColor = giverColor
        lblSettings.ForeColor = giverColor

        lblClicksTotal.ForeColor = giverColor
        lblClicksCorrect.ForeColor = giverColor
        lblSpawned.ForeColor = giverColor
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim tm As Boolean = TopMost
        Me.TopMost = False
        Dim potentialscoreboard As String = InputBox("Username to save as", "Username", "")
        If potentialscoreboard <> "" And potentialscoreboard <> " " And potentialscoreboard <> Nothing Then
            btnSave.Text = "Saving..."
            My.Settings.scoreboard &= "|" & potentialscoreboard & ":" & totalClicks & ":" & correctClicks & ":" & targetsSpawned
            My.Settings.Save()
            My.Settings.Reload()
        End If
        Me.TopMost = tm
    End Sub
    Private Function checkUpdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(aimhelp_version)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim rawData As String = sr.ReadToEnd()

        Dim info() As String = Split(rawData, "|")
        If productVersion = info(0) Then
            MessageBox.Show(updateNotes, "Update Notes", MessageBoxButtons.OK)
            Return False
        Else

            Dim versionnodots As String = Nothing
            For Each c As Char In info(0)
                If c <> "." Then
                    versionnodots &= c
                End If
            Next
            MsgBox(Application.StartupPath)
            Using Client As New System.Net.WebClient()
                Client.DownloadFile(info(1), Application.StartupPath & "\Aim Help v" & versionnodots & ".exe")
            End Using
            MessageBox.Show("Aim Help Version " & info(1) & " has been downloaded!", "Download Complete!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        End If
    End Function


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        closeopenSettings()
    End Sub
    Private Sub closeopenSettings()
        If pnlSettings.Location.X = 593 Then
            pnlSettings.Visible = True
            For i As Integer = 0 To 9
                pnlSettings.Location = New Point(pnlSettings.Location.X - 38, pnlSettings.Location.Y)
                pnlMenu.Location = New Point(pnlMenu.Location.X - 58, pnlMenu.Location.Y) 'OPTIONAL LINE OF CODE
                Refresh()
                Thread.Sleep(1)
            Next
            topmoststr = "settings"
            pnlSettings.Select()
        Else
            For i As Integer = 0 To 9
                pnlSettings.Location = New Point(pnlSettings.Location.X + 38, pnlSettings.Location.Y)
                pnlMenu.Location = New Point(pnlMenu.Location.X + 58, pnlMenu.Location.Y) 'OPTIONAL LINE OF CODE
                Refresh()
                Thread.Sleep(1)
            Next
            pnlMenu.Select()
            pnlSettings.Visible = False
            topmoststr = "menu"
        End If
    End Sub
    Private Sub closeopenLeaderboard()
        If pnlLeaderboard.Location.X = 593 Then
            pnlLeaderboard.Visible = True
            lblLeaderboard.Enabled = True
            For i As Integer = 0 To 9
                pnlLeaderboard.Location = New Point(pnlLeaderboard.Location.X - 38, pnlLeaderboard.Location.Y)
                pnlMenu.Location = New Point(pnlMenu.Location.X - 58, pnlMenu.Location.Y) 'OPTIONAL LINE OF CODE
                Refresh()
                Thread.Sleep(1)
            Next
            topmoststr = "leaderboard"
            pnlLeaderboard.Select()
            lblLeaderboard.Enabled = True
        Else
            For i As Integer = 0 To 9
                pnlLeaderboard.Location = New Point(pnlLeaderboard.Location.X + 38, pnlLeaderboard.Location.Y)
                pnlMenu.Location = New Point(pnlMenu.Location.X + 58, pnlMenu.Location.Y) 'OPTIONAL LINE OF CODE
                Refresh()
                Thread.Sleep(1)
            Next
            pnlMenu.Select()
            pnlLeaderboard.Visible = False
            topmoststr = "menu"
        End If
    End Sub

    Private Sub btnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        refreshLeaderboard()
        closeopenLeaderboard()
    End Sub

    Private Sub btnHigher_Click(sender As Object, e As EventArgs) Handles btnHigher.Click
        Dim addval As Double = 1

        If CDbl(lblIntervalval.Text < 1) Then
            addval = 0.1
        End If


        lblIntervalval.Text = CStr(CDbl(lblIntervalval.Text) + addval)
        multiplier += addval
        timeCounter = 0
    End Sub

    Private Sub btnLower_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        Dim subval As Double = 1

        If CDbl(lblIntervalval.Text <= 1) Then
            subval = 0.1
        End If

        lblIntervalval.Text = CStr(CDbl(lblIntervalval.Text) - subval)
            multiplier -= subval
        timeCounter = 0
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        ColorDialog1.ShowDialog()
        Dim newcolor As Color = ColorDialog1.Color
        setColor(newcolor)
    End Sub

    Private Sub btnTM_Click(sender As Object, e As EventArgs) Handles btnTM.Click
        If btnTM.Text.Contains("Off") Then
            Me.TopMost = True
            btnTM.Text = "TopMost: On"
        Else
            Me.TopMost = False
            btnTM.Text = "TopMost: Off"
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        checkUpdates()
    End Sub
End Class
