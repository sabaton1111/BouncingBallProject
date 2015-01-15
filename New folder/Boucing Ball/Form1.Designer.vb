<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.BallMove = New System.Windows.Forms.Timer(Me.components)
        Me.DirectionC = New System.Windows.Forms.Timer(Me.components)
        Me.Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.TestTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CountdownLabel = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.MinutesLabel = New System.Windows.Forms.Label()
        Me.SecondsLabel = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Bulb2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Bulb1PictureBox = New System.Windows.Forms.PictureBox()
        Me.Време = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RandomTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RandomTextBox = New System.Windows.Forms.TextBox()
        Me.SizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ChangeSizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Bulb2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bulb1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BallMove
        '
        Me.BallMove.Interval = 1
        '
        'DirectionC
        '
        Me.DirectionC.Interval = 3000
        '
        'Countdown
        '
        Me.Countdown.Interval = 1000
        '
        'TestTimer
        '
        Me.TestTimer.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CountdownLabel)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(160, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 740)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(393, 703)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 703)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Пропуснати : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 703)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 703)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Грешни : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 702)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 702)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Верни : "
        '
        'CountdownLabel
        '
        Me.CountdownLabel.AutoSize = True
        Me.CountdownLabel.BackColor = System.Drawing.Color.Transparent
        Me.CountdownLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CountdownLabel.Location = New System.Drawing.Point(473, 333)
        Me.CountdownLabel.Name = "CountdownLabel"
        Me.CountdownLabel.Size = New System.Drawing.Size(99, 108)
        Me.CountdownLabel.TabIndex = 17
        Me.CountdownLabel.Text = "5"
        Me.CountdownLabel.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1041, 738)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Transparent
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape1.Location = New System.Drawing.Point(370, 249)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(277, 277)
        '
        'MinutesLabel
        '
        Me.MinutesLabel.AutoSize = True
        Me.MinutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MinutesLabel.Location = New System.Drawing.Point(1278, 9)
        Me.MinutesLabel.Name = "MinutesLabel"
        Me.MinutesLabel.Size = New System.Drawing.Size(24, 16)
        Me.MinutesLabel.TabIndex = 19
        Me.MinutesLabel.Text = "00"
        '
        'SecondsLabel
        '
        Me.SecondsLabel.AutoSize = True
        Me.SecondsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SecondsLabel.Location = New System.Drawing.Point(1308, 9)
        Me.SecondsLabel.Name = "SecondsLabel"
        Me.SecondsLabel.Size = New System.Drawing.Size(24, 16)
        Me.SecondsLabel.TabIndex = 18
        Me.SecondsLabel.Text = "00"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 694)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 16
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Bulb2PictureBox
        '
        Me.Bulb2PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Bulb2PictureBox.BackgroundImage = Global.Boucing_Ball.My.Resources.Resources.darkgray
        Me.Bulb2PictureBox.Location = New System.Drawing.Point(1217, 292)
        Me.Bulb2PictureBox.Name = "Bulb2PictureBox"
        Me.Bulb2PictureBox.Size = New System.Drawing.Size(121, 150)
        Me.Bulb2PictureBox.TabIndex = 2
        Me.Bulb2PictureBox.TabStop = False
        '
        'Bulb1PictureBox
        '
        Me.Bulb1PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Bulb1PictureBox.BackgroundImage = Global.Boucing_Ball.My.Resources.Resources.darkgray
        Me.Bulb1PictureBox.Location = New System.Drawing.Point(23, 292)
        Me.Bulb1PictureBox.Name = "Bulb1PictureBox"
        Me.Bulb1PictureBox.Size = New System.Drawing.Size(118, 150)
        Me.Bulb1PictureBox.TabIndex = 1
        Me.Bulb1PictureBox.TabStop = False
        '
        'Време
        '
        Me.Време.AutoSize = True
        Me.Време.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Време.Location = New System.Drawing.Point(1209, 9)
        Me.Време.Name = "Време"
        Me.Време.Size = New System.Drawing.Size(63, 16)
        Me.Време.TabIndex = 20
        Me.Време.Text = "Време :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(1300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = ":"
        '
        'RandomTimer
        '
        Me.RandomTimer.Interval = 4000
        '
        'RandomTextBox
        '
        Me.RandomTextBox.Location = New System.Drawing.Point(12, 242)
        Me.RandomTextBox.Name = "RandomTextBox"
        Me.RandomTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RandomTextBox.TabIndex = 22
        Me.RandomTextBox.Text = "0"
        Me.RandomTextBox.Visible = False
        '
        'SizeTimer
        '
        Me.SizeTimer.Interval = 1000
        '
        'ChangeSizeTimer
        '
        Me.ChangeSizeTimer.Enabled = True
        Me.ChangeSizeTimer.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.RandomTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Време)
        Me.Controls.Add(Me.MinutesLabel)
        Me.Controls.Add(Me.SecondsLabel)
        Me.Controls.Add(Me.Bulb2PictureBox)
        Me.Controls.Add(Me.Bulb1PictureBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Bulb2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bulb1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DirectionC As System.Windows.Forms.Timer
    Friend WithEvents Countdown As System.Windows.Forms.Timer
    Friend WithEvents TestTimer As System.Windows.Forms.Timer
    Private WithEvents BallMove As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents CountdownLabel As System.Windows.Forms.Label
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents MinutesLabel As System.Windows.Forms.Label
    Friend WithEvents SecondsLabel As System.Windows.Forms.Label
    Friend WithEvents Bulb1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Bulb2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Време As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RandomTimer As System.Windows.Forms.Timer
    Friend WithEvents RandomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SizeTimer As System.Windows.Forms.Timer
    Friend WithEvents ChangeSizeTimer As System.Windows.Forms.Timer

End Class
