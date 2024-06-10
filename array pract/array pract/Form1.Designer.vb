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
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        ListBox1 = New ListBox()
        GroupBox3 = New GroupBox()
        Button4 = New Button()
        ListBox2 = New ListBox()
        GroupBox4 = New GroupBox()
        Button5 = New Button()
        ListBox3 = New ListBox()
        txtName = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(266, 172)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(107, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(50, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 31)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(ListBox1)
        GroupBox2.Location = New Point(12, 201)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(266, 392)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(15, 350)
        Button3.Name = "Button3"
        Button3.Size = New Size(172, 31)
        Button3.TabIndex = 3
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(15, 313)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 31)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(15, 22)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(176, 274)
        ListBox1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button4)
        GroupBox3.Controls.Add(ListBox2)
        GroupBox3.Location = New Point(303, 22)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(267, 305)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "GroupBox3"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(34, 251)
        Button4.Name = "Button4"
        Button4.Size = New Size(172, 31)
        Button4.TabIndex = 4
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(6, 22)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(123, 154)
        ListBox2.TabIndex = 4
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(txtName)
        GroupBox4.Controls.Add(Button5)
        GroupBox4.Controls.Add(ListBox3)
        GroupBox4.Location = New Point(303, 333)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(387, 287)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "GroupBox4"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(57, 36)
        Button5.Name = "Button5"
        Button5.Size = New Size(84, 31)
        Button5.TabIndex = 4
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 15
        ListBox3.Location = New Point(57, 82)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(285, 199)
        ListBox3.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(158, 44)
        txtName.Name = "txtName"
        txtName.Size = New Size(184, 23)
        txtName.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1646, 632)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents txtName As TextBox

End Class
