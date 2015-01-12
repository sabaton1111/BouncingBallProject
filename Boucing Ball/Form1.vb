Imports Microsoft.VisualBasic.PowerPacks

Public Class Form1
    Dim Random2 As Integer
    'Speed of the Ball
    Dim Xr As Integer
    Dim Yr As Integer

    'If True going left
    Dim DirectionX As Boolean
    'if true going up
    Dim DirectionY As Boolean

    'Times how long until the ball changes direction and speeds
    Dim ChangeDT As Integer

    Dim ChangeX As Byte
    Dim ChangeY As Byte

    Dim Ball As OvalShape
    Dim point As New Point()

    Dim MouseLeavee As Boolean = False
    Dim MouseCursor As Boolean = False
    Dim up As Boolean = False
    Dim down As Boolean = False
    Dim leftt As Boolean = False
    Dim rightt As Boolean = False

    Sub Directions()
        Randomize()
        Xr = (Rnd() * 4) + 1
        Yr = (Rnd() * 4) + 1
    End Sub
    Sub Minute1()
        If MinutesLabel.Text = 1 Then
            CountdownLabel.Text = "Times up"
            CountdownLabel.Visible = True
            Countdown.Enabled = False
            System.Windows.Forms.Cursor.Show()
            BallMove.Stop()
            DirectionC.Stop()
            TestTimer.Stop()
            BallMove.Enabled = False
            MouseLeavee = False
        End If
    End Sub
    Sub BallMoveStart()
        BallMove.Enabled = True
        Ball = OvalShape1
        Directions()
        BallMove.Enabled = True
        DirectionC.Enabled = True
        Randomize()
        ChangeDT = (Rnd() * 5000) + 1


        Randomize()
        ChangeX = (Rnd() * 1) + 1
        ChangeY = (Rnd() * 1) + 1

        If ChangeX = 0 Then
            DirectionX = False

        ElseIf ChangeX >= 1 Then
            DirectionX = True
        End If

        If ChangeY = 0 Then
            DirectionY = False

        ElseIf ChangeY >= 1 Then
            DirectionY = True
        End If
    End Sub
 
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles BallMove.Tick

        If DirectionX = True Then
            Ball.Left -= Xr
        End If
        If DirectionX = False Then
            Ball.Left += Xr
        End If

        If DirectionY = True Then
            Ball.Top -= Yr
        End If

        If DirectionY = False Then
            Ball.Top += Yr
        End If


        If Ball.Left <= 0 Then

            DirectionX = False
            Directions()
        End If

        If Ball.Left >= Me.Width - 80 Then

            DirectionX = True
            Directions()
        End If


        If Ball.Top <= 0 Then


            DirectionY = False
            Directions()

        End If



        If Ball.Top >= Me.Height - 80 Then


            DirectionY = True
            Directions()
        End If


    End Sub

    Private Sub DirectionC_Tick(sender As System.Object, e As System.EventArgs) Handles DirectionC.Tick

        Directions()

        If ChangeX = 0 Then
            DirectionX = False

        ElseIf ChangeX >= 1 Then
            DirectionX = True
        End If

        If ChangeY = 0 Then
            DirectionY = False

        ElseIf ChangeY >= 1 Then
            DirectionY = True
        End If


    End Sub
    Private Sub Countdown_Tick(sender As Object, e As EventArgs) Handles Countdown.Tick
        CountdownLabel.Text -= 1
        If CountdownLabel.Text = "0" Then
            Countdown.Enabled = False
            CountdownLabel.Visible = False
            BallMoveStart()
            MouseLeavee = True
            TestTimer.Enabled = True
            RandomTimer.Start()
        End If
    End Sub
    Private Sub OvalShape1_MouseHover(sender As Object, e As EventArgs) Handles OvalShape1.MouseHover
        System.Windows.Forms.Cursor.Show()
    End Sub
    Private Sub OvalShape1_MouseLeave(sender As Object, e As EventArgs) Handles OvalShape1.MouseLeave
        If MouseLeavee = True Then
            CountdownLabel.Visible = True
            CountdownLabel.Text = "Game Over"
            BallMove.Enabled = False
            Me.Cursor = Cursors.Arrow
            RandomTimer.Stop()
            TestTimer.Stop()
            Countdown.Stop()
            DirectionC.Stop()
            BallMove.Stop()
        End If
    End Sub

    Private Sub TestTimer_Tick(sender As Object, e As EventArgs) Handles TestTimer.Tick
        SecondsLabel.Text += 1
        If SecondsLabel.Text = "60" Then
            SecondsLabel.Text = "00"
            MinutesLabel.Text += 1
        End If
        Minute1()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.ShiftKey Then
            If RandomTextBox.Text = 1 Or RandomTextBox.Text = 3 Then
                Label3.Text += 1
            Else : Label4.Text += 1
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        up = True
        down = True
        leftt = True
        rightt = True
    End Sub
    Private Sub MinutesLabel_Click(sender As Object, e As EventArgs)
        Minute1()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        CountdownLabel.Visible = True
        Countdown.Enabled = True
        Me.Cursor = New Cursor(My.Resources.ball1.Handle)
    End Sub

    Private Sub RandomTimer_Tick(sender As Object, e As EventArgs) Handles RandomTimer.Tick
        Dim vqrno As Random
        vqrno = New Random
        Random2 = vqrno.Next(1, 8)
        RandomTextBox.Text = Random2.ToString
        If Random2 = 1 Then
            Bulb1PictureBox.Image = My.Resources.green
            Bulb2PictureBox.Image = My.Resources.darkgray
        End If
        If Random2 = 2 Then
            Bulb1PictureBox.Image = My.Resources.red
            Bulb2PictureBox.Image = My.Resources.darkgray
        End If
        If Random2 = 3 Then
            Bulb2PictureBox.Image = My.Resources.green
            Bulb1PictureBox.Image = My.Resources.darkgray
        End If
        If Random2 = 4 Then
            Bulb2PictureBox.Image = My.Resources.red
            Bulb1PictureBox.Image = My.Resources.darkgray
        End If
        If Random2 = 5 Then
            Bulb1PictureBox.Image = My.Resources.darkgray
            Bulb2PictureBox.Image = My.Resources.darkgray
        End If
        If Random2 = 6 Then
            Bulb1PictureBox.Image = My.Resources.darkgray
            Bulb2PictureBox.Image = My.Resources.darkgray
        End If
        If Random2 = 7 Then
            Bulb1PictureBox.Image = My.Resources.darkgray
            Bulb2PictureBox.Image = My.Resources.darkgray
        End If
        If Random2 = 8 Then
            Bulb1PictureBox.Image = My.Resources.darkgray
            Bulb2PictureBox.Image = My.Resources.darkgray
        End If
        If CountdownLabel.Text <> "GameOver" And CountdownLabel.Text <> "Times up" Then
            If RandomTextBox.Text = 1 Or RandomTextBox.Text = 2 Or RandomTextBox.Text = 3 Or RandomTextBox.Text = 4 Then
                BallMove.Enabled = False
            Else
                BallMove.Enabled = True
                Me.Cursor = New Cursor(My.Resources.ball1.Handle)
            End If
        End If
    End Sub
End Class
