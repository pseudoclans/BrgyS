﻿Imports Avalonia.Controls.Documents
Imports Avalonia.Styling

Public Class Form2
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        switchPanel(Form3)
        Guna2Button1.FillColor = Color.FromArgb(30, 71, 125)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Font = New Font(Guna2Button1.Font, FontStyle.Bold)
        Guna2Button2.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button2.FillColor = Color.White
        Guna2Button2.ForeColor = Color.Black
        Guna2Button3.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button3.FillColor = Color.White
        Guna2Button3.ForeColor = Color.Black
        Guna2Button5.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button5.FillColor = Color.White
        Guna2Button5.ForeColor = Color.Black
    End Sub


    Sub switchPanel(ByVal panel As Form)
        Guna2Panel1.Controls.Clear()
        panel.TopLevel = False
        Guna2Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        switchPanel(Form5)
        Guna2Button1.FillColor = Color.White
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Font = New Font(Guna2Button1.Font, FontStyle.Regular)
        Guna2Button3.FillColor = Color.White
        Guna2Button3.ForeColor = Color.Black
        Guna2Button3.Font = New Font(Guna2Button1.Font, FontStyle.Regular)
        Guna2Button2.Font = New Font(Guna2Button2.Font, FontStyle.Bold)
        Guna2Button2.FillColor = Color.FromArgb(30, 71, 125)
        Guna2Button2.ForeColor = Color.White
        Guna2Button5.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button5.FillColor = Color.White
        Guna2Button5.ForeColor = Color.Black
    End Sub
    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        SearchonPress
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set time and name for clerk after login
    End Sub

    'funtions
    Public Sub SearchonPress()
        'Dim txtid As String = TextBox1.Text.Trim

        'Try
        '    openCon()
        '    Dim query As String = "SELECT * FROM addemp WHERE emp_id LIKE @searchText "

        '    Using command As New MySqlCommand(query, con)
        '        command.Parameters.AddWithValue("@searchText", "%" & txtid & "%")

        '        ' Execute the query and read the result
        '        Using reader As MySqlDataReader = command.ExecuteReader()
        '            If reader.Read() Then


        '                ' Display the data in TextBoxes
        '                TextBox7.Text = reader("fname").ToString()
        '                TextBox8.Text = reader("lname").ToString()
        '                Dim DoB As Date = Convert.ToDateTime(reader("date_emp"))
        '                ' Set the DateTimePicker value based on the retrieved date
        '                DateTimePicker2.Value = DoB
        '                Dim gender As String = reader("gender").ToString()

        '                ' Set the RadioButton based on the retrieved gender
        '                If gender = "Male" Then
        '                    RadioButton1.Checked = True
        '                ElseIf gender = "Female" Then
        '                    RadioButton2.Checked = True
        '                End If
        '                TextBox10.Text = reader("email").ToString()
        '                TextBox9.Text = reader("Cnum").ToString()
        '                TextBox6.Text = reader("address").ToString()
        '                ComboBox2.Text = reader("stat").ToString()
        '                ' Retrieve the value
        '                Dim dateHired As Date = Convert.ToDateTime(reader("date_hired"))
        '                ' Set the DateTimePicker value based on the retrieved date
        '                DateTimePicker1.Value = dateHired
        '                ' Retrieve the picture filename
        '                Dim picFileName As String = reader("pic_file").ToString()
        '                Label10.Text = picFileName
        '                PictureBox1.Image = Image.FromFile(picFileName)

        '                ComboBox1.Text = reader("j_title").ToString()


        '            End If
        '        End Using
        '    End Using

        'Catch ex As Exception
        '    ' Handle exceptions, such as database connection issues or query errors
        '    'MessageBox.Show("Error Searching data: " & ex.Message)
        'Finally
        '    con.Close() ' Ensure to close the connection in the finally block if it is open
        'End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        switchPanel(Form6)
        Guna2Button3.FillColor = Color.FromArgb(30, 71, 125)
        Guna2Button3.ForeColor = Color.White
        Guna2Button3.Font = New Font(Guna2Button1.Font, FontStyle.Bold)
        Guna2Button1.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button1.FillColor = Color.White
        Guna2Button1.ForeColor = Color.Black
        Guna2Button2.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button2.FillColor = Color.White
        Guna2Button2.ForeColor = Color.Black
        Guna2Button5.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button5.FillColor = Color.White
        Guna2Button5.ForeColor = Color.Black
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim form1 As New Form1()
            form1.Show() ' Show the login form (Form1) again
            Me.Close() ' Close the current form (Form2) to log out
        End If

        Guna2Button5.FillColor = Color.FromArgb(30, 71, 125)
        Guna2Button5.ForeColor = Color.White
        Guna2Button5.Font = New Font(Guna2Button1.Font, FontStyle.Bold)
        Guna2Button1.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button1.FillColor = Color.White
        Guna2Button1.ForeColor = Color.Black
        Guna2Button2.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button2.FillColor = Color.White
        Guna2Button2.ForeColor = Color.Black
        Guna2Button3.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button3.FillColor = Color.White
        Guna2Button3.ForeColor = Color.Black
        Guna2Button4.Font = New Font(Guna2Button2.Font, FontStyle.Regular)
        Guna2Button4.FillColor = Color.White
        Guna2Button4.ForeColor = Color.Black
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs)

    End Sub
End Class