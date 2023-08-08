<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Dim connection As String = ""
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
        Lbl_Principal = New Label()
        Lbl_Rendimento = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Lbl_Principal
        ' 
        Lbl_Principal.AutoSize = True
        Lbl_Principal.Location = New Point(38, 54)
        Lbl_Principal.Name = "Lbl_Principal"
        Lbl_Principal.Size = New Size(53, 20)
        Lbl_Principal.TabIndex = 0
        Lbl_Principal.Text = "Label1"
        ' 
        ' Lbl_Rendimento
        ' 
        Lbl_Rendimento.AutoSize = True
        Lbl_Rendimento.Location = New Point(361, 54)
        Lbl_Rendimento.Name = "Lbl_Rendimento"
        Lbl_Rendimento.Size = New Size(53, 20)
        Lbl_Rendimento.TabIndex = 1
        Lbl_Rendimento.Text = "Label1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(38, 106)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(265, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(361, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(298, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(40, 259)
        Button1.Name = "Button1"
        Button1.Size = New Size(487, 84)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 5
        Label1.Text = "Label1"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(40, 207)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(258, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(361, 207)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(258, 27)
        TextBox4.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(361, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(185, 387)
        Button2.Name = "Button2"
        Button2.Size = New Size(217, 28)
        Button2.TabIndex = 9
        Button2.Text = "To"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(TextBox4)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Lbl_Rendimento)
        Controls.Add(Lbl_Principal)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Lbl_Rendimento As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
