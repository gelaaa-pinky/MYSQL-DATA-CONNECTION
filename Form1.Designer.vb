<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnTest = New Button()
        TextBox1 = New TextBox()
        Login_Click = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTest.Location = New Point(30, 38)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(259, 40)
        btnTest.TabIndex = 0
        btnTest.Text = "CHECK CONNECTION"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 8.25F)
        TextBox1.Location = New Point(300, 135)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 20)
        TextBox1.TabIndex = 1
        ' 
        ' Login_Click
        ' 
        Login_Click.FlatStyle = FlatStyle.System
        Login_Click.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login_Click.Location = New Point(325, 258)
        Login_Click.Name = "Login_Click"
        Login_Click.Size = New Size(153, 47)
        Login_Click.TabIndex = 2
        Login_Click.Text = "LOGIN"
        Login_Click.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(168, 134)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.Yes
        Label1.Size = New Size(111, 21)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(168, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 21)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(300, 193)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(208, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Login_Click)
        Controls.Add(TextBox1)
        Controls.Add(btnTest)
        Name = "Form1"
        Text = "MYSQLDB DATA CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Login_Click As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox

End Class
