<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAim))
        Me.lblStart = New System.Windows.Forms.Label()
        Me.tmrGen = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.lblClicksTotal = New System.Windows.Forms.Label()
        Me.lblClicksCorrect = New System.Windows.Forms.Label()
        Me.lblSpawned = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnLeaderboard = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblPEC2 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.picBorderBottom = New System.Windows.Forms.PictureBox()
        Me.picBorderTop = New System.Windows.Forms.PictureBox()
        Me.picBorderMid = New System.Windows.Forms.PictureBox()
        Me.picBorderRight = New System.Windows.Forms.PictureBox()
        Me.picBorderLeft = New System.Windows.Forms.PictureBox()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.btnTM = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnHigher = New System.Windows.Forms.Button()
        Me.btnLower = New System.Windows.Forms.Button()
        Me.lblIntervalval = New System.Windows.Forms.Label()
        Me.lblinterval = New System.Windows.Forms.Label()
        Me.lblPEC3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.pnlLeaderboard = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.chUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTotalClicks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCorrectClicks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTargetsSpawned = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPEC1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.lblLeaderboard = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.pnlMenu.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorderBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorderTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorderMid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorderRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorderLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettings.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeaderboard.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Times New Roman", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(206, 250)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(385, 38)
        Me.lblStart.TabIndex = 4
        Me.lblStart.Text = "Click Anywhere To Start!"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrGen
        '
        '
        'BackgroundWorker1
        '
        '
        'tmrCheck
        '
        Me.tmrCheck.Interval = 500
        '
        'lblClicksTotal
        '
        Me.lblClicksTotal.AutoSize = True
        Me.lblClicksTotal.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblClicksTotal.ForeColor = System.Drawing.Color.White
        Me.lblClicksTotal.Location = New System.Drawing.Point(12, 572)
        Me.lblClicksTotal.Name = "lblClicksTotal"
        Me.lblClicksTotal.Size = New System.Drawing.Size(165, 31)
        Me.lblClicksTotal.TabIndex = 6
        Me.lblClicksTotal.Text = "Total Clicks:"
        '
        'lblClicksCorrect
        '
        Me.lblClicksCorrect.AutoSize = True
        Me.lblClicksCorrect.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblClicksCorrect.ForeColor = System.Drawing.Color.White
        Me.lblClicksCorrect.Location = New System.Drawing.Point(260, 572)
        Me.lblClicksCorrect.Name = "lblClicksCorrect"
        Me.lblClicksCorrect.Size = New System.Drawing.Size(195, 31)
        Me.lblClicksCorrect.TabIndex = 7
        Me.lblClicksCorrect.Text = "Correct Clicks:"
        '
        'lblSpawned
        '
        Me.lblSpawned.AutoSize = True
        Me.lblSpawned.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblSpawned.ForeColor = System.Drawing.Color.White
        Me.lblSpawned.Location = New System.Drawing.Point(512, 572)
        Me.lblSpawned.Name = "lblSpawned"
        Me.lblSpawned.Size = New System.Drawing.Size(222, 31)
        Me.lblSpawned.TabIndex = 8
        Me.lblSpawned.Text = "Targets Spawned:"
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Black
        Me.pnlMenu.Controls.Add(Me.btnUpdate)
        Me.pnlMenu.Controls.Add(Me.btnSettings)
        Me.pnlMenu.Controls.Add(Me.btnLeaderboard)
        Me.pnlMenu.Controls.Add(Me.btnSave)
        Me.pnlMenu.Controls.Add(Me.lblPEC2)
        Me.pnlMenu.Controls.Add(Me.PictureBox9)
        Me.pnlMenu.Controls.Add(Me.PictureBox8)
        Me.pnlMenu.Controls.Add(Me.PictureBox7)
        Me.pnlMenu.Controls.Add(Me.PictureBox6)
        Me.pnlMenu.Controls.Add(Me.lblMenu)
        Me.pnlMenu.Location = New System.Drawing.Point(213, 28)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(367, 502)
        Me.pnlMenu.TabIndex = 9
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.Location = New System.Drawing.Point(149, 368)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(70, 70)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.White
        Me.btnSettings.BackgroundImage = CType(resources.GetObject("btnSettings.BackgroundImage"), System.Drawing.Image)
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnSettings.Location = New System.Drawing.Point(149, 127)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(70, 70)
        Me.btnSettings.TabIndex = 16
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnLeaderboard
        '
        Me.btnLeaderboard.BackColor = System.Drawing.Color.White
        Me.btnLeaderboard.BackgroundImage = CType(resources.GetObject("btnLeaderboard.BackgroundImage"), System.Drawing.Image)
        Me.btnLeaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaderboard.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnLeaderboard.Location = New System.Drawing.Point(149, 209)
        Me.btnLeaderboard.Name = "btnLeaderboard"
        Me.btnLeaderboard.Size = New System.Drawing.Size(70, 70)
        Me.btnLeaderboard.TabIndex = 14
        Me.btnLeaderboard.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(149, 290)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 70)
        Me.btnSave.TabIndex = 13
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblPEC2
        '
        Me.lblPEC2.AutoSize = True
        Me.lblPEC2.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPEC2.ForeColor = System.Drawing.Color.White
        Me.lblPEC2.Location = New System.Drawing.Point(60, 449)
        Me.lblPEC2.Name = "lblPEC2"
        Me.lblPEC2.Size = New System.Drawing.Size(243, 31)
        Me.lblPEC2.TabIndex = 10
        Me.lblPEC2.Text = "Press Esc To Close!"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.White
        Me.PictureBox9.Location = New System.Drawing.Point(3, 498)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(367, 4)
        Me.PictureBox9.TabIndex = 12
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(367, 4)
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(363, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(4, 502)
        Me.PictureBox7.TabIndex = 11
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(4, 502)
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.Font = New System.Drawing.Font("Times New Roman", 50.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(87, 7)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(200, 76)
        Me.lblMenu.TabIndex = 10
        Me.lblMenu.Text = "Menu"
        '
        'picBorderBottom
        '
        Me.picBorderBottom.BackColor = System.Drawing.Color.White
        Me.picBorderBottom.Location = New System.Drawing.Point(0, 613)
        Me.picBorderBottom.Name = "picBorderBottom"
        Me.picBorderBottom.Size = New System.Drawing.Size(784, 8)
        Me.picBorderBottom.TabIndex = 5
        Me.picBorderBottom.TabStop = False
        '
        'picBorderTop
        '
        Me.picBorderTop.BackColor = System.Drawing.Color.White
        Me.picBorderTop.Location = New System.Drawing.Point(0, 0)
        Me.picBorderTop.Name = "picBorderTop"
        Me.picBorderTop.Size = New System.Drawing.Size(784, 8)
        Me.picBorderTop.TabIndex = 3
        Me.picBorderTop.TabStop = False
        '
        'picBorderMid
        '
        Me.picBorderMid.BackColor = System.Drawing.Color.White
        Me.picBorderMid.Location = New System.Drawing.Point(0, 553)
        Me.picBorderMid.Name = "picBorderMid"
        Me.picBorderMid.Size = New System.Drawing.Size(784, 8)
        Me.picBorderMid.TabIndex = 2
        Me.picBorderMid.TabStop = False
        '
        'picBorderRight
        '
        Me.picBorderRight.BackColor = System.Drawing.Color.White
        Me.picBorderRight.Location = New System.Drawing.Point(776, 0)
        Me.picBorderRight.Name = "picBorderRight"
        Me.picBorderRight.Size = New System.Drawing.Size(8, 621)
        Me.picBorderRight.TabIndex = 1
        Me.picBorderRight.TabStop = False
        '
        'picBorderLeft
        '
        Me.picBorderLeft.BackColor = System.Drawing.Color.White
        Me.picBorderLeft.Location = New System.Drawing.Point(0, 0)
        Me.picBorderLeft.Name = "picBorderLeft"
        Me.picBorderLeft.Size = New System.Drawing.Size(8, 621)
        Me.picBorderLeft.TabIndex = 0
        Me.picBorderLeft.TabStop = False
        '
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.Black
        Me.pnlSettings.Controls.Add(Me.lblIntervalval)
        Me.pnlSettings.Controls.Add(Me.PictureBox14)
        Me.pnlSettings.Controls.Add(Me.btnTM)
        Me.pnlSettings.Controls.Add(Me.btnColor)
        Me.pnlSettings.Controls.Add(Me.btnHigher)
        Me.pnlSettings.Controls.Add(Me.btnLower)
        Me.pnlSettings.Controls.Add(Me.lblinterval)
        Me.pnlSettings.Controls.Add(Me.lblPEC3)
        Me.pnlSettings.Controls.Add(Me.PictureBox4)
        Me.pnlSettings.Controls.Add(Me.PictureBox2)
        Me.pnlSettings.Controls.Add(Me.PictureBox3)
        Me.pnlSettings.Controls.Add(Me.PictureBox1)
        Me.pnlSettings.Controls.Add(Me.lblSettings)
        Me.pnlSettings.Location = New System.Drawing.Point(392, 18)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(367, 502)
        Me.pnlSettings.TabIndex = 10
        '
        'btnTM
        '
        Me.btnTM.BackColor = System.Drawing.Color.White
        Me.btnTM.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnTM.Location = New System.Drawing.Point(83, 351)
        Me.btnTM.Name = "btnTM"
        Me.btnTM.Size = New System.Drawing.Size(202, 39)
        Me.btnTM.TabIndex = 25
        Me.btnTM.Text = "TopMost: Off"
        Me.btnTM.UseVisualStyleBackColor = False
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.White
        Me.btnColor.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnColor.Location = New System.Drawing.Point(83, 396)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(202, 39)
        Me.btnColor.TabIndex = 17
        Me.btnColor.Text = "Change Color"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnHigher
        '
        Me.btnHigher.BackColor = System.Drawing.Color.White
        Me.btnHigher.BackgroundImage = CType(resources.GetObject("btnHigher.BackgroundImage"), System.Drawing.Image)
        Me.btnHigher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHigher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHigher.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnHigher.Location = New System.Drawing.Point(242, 162)
        Me.btnHigher.Name = "btnHigher"
        Me.btnHigher.Size = New System.Drawing.Size(74, 51)
        Me.btnHigher.TabIndex = 24
        Me.btnHigher.Text = ">"
        Me.btnHigher.UseVisualStyleBackColor = False
        '
        'btnLower
        '
        Me.btnLower.BackColor = System.Drawing.Color.White
        Me.btnLower.BackgroundImage = CType(resources.GetObject("btnLower.BackgroundImage"), System.Drawing.Image)
        Me.btnLower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLower.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnLower.Location = New System.Drawing.Point(46, 162)
        Me.btnLower.Name = "btnLower"
        Me.btnLower.Size = New System.Drawing.Size(74, 51)
        Me.btnLower.TabIndex = 17
        Me.btnLower.Text = "<"
        Me.btnLower.UseVisualStyleBackColor = False
        '
        'lblIntervalval
        '
        Me.lblIntervalval.AutoSize = True
        Me.lblIntervalval.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblIntervalval.ForeColor = System.Drawing.Color.White
        Me.lblIntervalval.Location = New System.Drawing.Point(167, 171)
        Me.lblIntervalval.Name = "lblIntervalval"
        Me.lblIntervalval.Size = New System.Drawing.Size(28, 31)
        Me.lblIntervalval.TabIndex = 23
        Me.lblIntervalval.Text = "1"
        '
        'lblinterval
        '
        Me.lblinterval.AutoSize = True
        Me.lblinterval.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblinterval.ForeColor = System.Drawing.Color.White
        Me.lblinterval.Location = New System.Drawing.Point(127, 119)
        Me.lblinterval.Name = "lblinterval"
        Me.lblinterval.Size = New System.Drawing.Size(108, 31)
        Me.lblinterval.TabIndex = 22
        Me.lblinterval.Text = "Interval"
        '
        'lblPEC3
        '
        Me.lblPEC3.AutoSize = True
        Me.lblPEC3.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPEC3.ForeColor = System.Drawing.Color.White
        Me.lblPEC3.Location = New System.Drawing.Point(60, 449)
        Me.lblPEC3.Name = "lblPEC3"
        Me.lblPEC3.Size = New System.Drawing.Size(243, 31)
        Me.lblPEC3.TabIndex = 17
        Me.lblPEC3.Text = "Press Esc To Close!"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(3, 498)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(367, 4)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(363, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(4, 502)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(4, 502)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 4)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblSettings.Font = New System.Drawing.Font("Times New Roman", 50.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.White
        Me.lblSettings.Location = New System.Drawing.Point(60, 7)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(260, 76)
        Me.lblSettings.TabIndex = 17
        Me.lblSettings.Text = "Settings"
        '
        'pnlLeaderboard
        '
        Me.pnlLeaderboard.BackColor = System.Drawing.Color.Black
        Me.pnlLeaderboard.Controls.Add(Me.ListView1)
        Me.pnlLeaderboard.Controls.Add(Me.lblPEC1)
        Me.pnlLeaderboard.Controls.Add(Me.PictureBox5)
        Me.pnlLeaderboard.Controls.Add(Me.PictureBox10)
        Me.pnlLeaderboard.Controls.Add(Me.PictureBox11)
        Me.pnlLeaderboard.Controls.Add(Me.PictureBox12)
        Me.pnlLeaderboard.Controls.Add(Me.lblLeaderboard)
        Me.pnlLeaderboard.Location = New System.Drawing.Point(0, 28)
        Me.pnlLeaderboard.Name = "pnlLeaderboard"
        Me.pnlLeaderboard.Size = New System.Drawing.Size(367, 502)
        Me.pnlLeaderboard.TabIndex = 22
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chUser, Me.chTotalClicks, Me.chCorrectClicks, Me.chTargetsSpawned})
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(26, 99)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(313, 336)
        Me.ListView1.TabIndex = 22
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'chUser
        '
        Me.chUser.Text = "Username"
        '
        'chTotalClicks
        '
        Me.chTotalClicks.Text = "Total Clicks"
        Me.chTotalClicks.Width = 72
        '
        'chCorrectClicks
        '
        Me.chCorrectClicks.Text = "Correct Clicks"
        Me.chCorrectClicks.Width = 81
        '
        'chTargetsSpawned
        '
        Me.chTargetsSpawned.Text = "Targets Spawned"
        Me.chTargetsSpawned.Width = 100
        '
        'lblPEC1
        '
        Me.lblPEC1.AutoSize = True
        Me.lblPEC1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPEC1.ForeColor = System.Drawing.Color.White
        Me.lblPEC1.Location = New System.Drawing.Point(60, 449)
        Me.lblPEC1.Name = "lblPEC1"
        Me.lblPEC1.Size = New System.Drawing.Size(243, 31)
        Me.lblPEC1.TabIndex = 17
        Me.lblPEC1.Text = "Press Esc To Close!"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(3, 498)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(367, 4)
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.White
        Me.PictureBox10.Location = New System.Drawing.Point(363, 0)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(4, 502)
        Me.PictureBox10.TabIndex = 20
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(4, 502)
        Me.PictureBox11.TabIndex = 19
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(367, 4)
        Me.PictureBox12.TabIndex = 18
        Me.PictureBox12.TabStop = False
        '
        'lblLeaderboard
        '
        Me.lblLeaderboard.AutoSize = True
        Me.lblLeaderboard.BackColor = System.Drawing.Color.Transparent
        Me.lblLeaderboard.Font = New System.Drawing.Font("Times New Roman", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblLeaderboard.ForeColor = System.Drawing.Color.White
        Me.lblLeaderboard.Location = New System.Drawing.Point(23, 9)
        Me.lblLeaderboard.Name = "lblLeaderboard"
        Me.lblLeaderboard.Size = New System.Drawing.Size(326, 62)
        Me.lblLeaderboard.TabIndex = 17
        Me.lblLeaderboard.Text = "Leaderboard"
        '
        'PictureBox13
        '
        Me.PictureBox13.Location = New System.Drawing.Point(3, 553)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(769, 68)
        Me.PictureBox13.TabIndex = 23
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackgroundImage = CType(resources.GetObject("PictureBox14.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox14.Location = New System.Drawing.Point(142, 162)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(81, 51)
        Me.PictureBox14.TabIndex = 26
        Me.PictureBox14.TabStop = False
        '
        'frmAim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 621)
        Me.Controls.Add(Me.lblSpawned)
        Me.Controls.Add(Me.lblClicksCorrect)
        Me.Controls.Add(Me.lblClicksTotal)
        Me.Controls.Add(Me.picBorderBottom)
        Me.Controls.Add(Me.picBorderMid)
        Me.Controls.Add(Me.picBorderRight)
        Me.Controls.Add(Me.picBorderLeft)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlLeaderboard)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.picBorderTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aim"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorderBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorderTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorderMid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorderRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorderLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeaderboard.ResumeLayout(False)
        Me.pnlLeaderboard.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBorderLeft As PictureBox
    Friend WithEvents picBorderRight As PictureBox
    Friend WithEvents picBorderMid As PictureBox
    Friend WithEvents picBorderTop As PictureBox
    Friend WithEvents lblStart As Label
    Friend WithEvents tmrGen As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrCheck As Timer
    Friend WithEvents picBorderBottom As PictureBox
    Friend WithEvents lblClicksTotal As Label
    Friend WithEvents lblClicksCorrect As Label
    Friend WithEvents lblSpawned As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents lblMenu As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblPEC2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLeaderboard As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents lblSettings As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblPEC3 As Label
    Friend WithEvents pnlLeaderboard As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chUser As ColumnHeader
    Friend WithEvents chTotalClicks As ColumnHeader
    Friend WithEvents chCorrectClicks As ColumnHeader
    Friend WithEvents chTargetsSpawned As ColumnHeader
    Friend WithEvents lblPEC1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents lblLeaderboard As Label
    Friend WithEvents btnHigher As Button
    Friend WithEvents btnLower As Button
    Friend WithEvents lblIntervalval As Label
    Friend WithEvents lblinterval As Label
    Friend WithEvents btnColor As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnTM As Button
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PictureBox14 As PictureBox
End Class
