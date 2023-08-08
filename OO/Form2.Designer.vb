<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Lbl_saque = New Label()
        Txt_saque = New TextBox()
        Btn_saque = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Lbl_saque
        ' 
        Lbl_saque.AutoSize = True
        Lbl_saque.Location = New Point(20, 81)
        Lbl_saque.Name = "Lbl_saque"
        Lbl_saque.Size = New Size(53, 20)
        Lbl_saque.TabIndex = 1
        Lbl_saque.Text = "Label2"
        ' 
        ' Txt_saque
        ' 
        Txt_saque.Location = New Point(25, 124)
        Txt_saque.Name = "Txt_saque"
        Txt_saque.Size = New Size(280, 27)
        Txt_saque.TabIndex = 2
        ' 
        ' Btn_saque
        ' 
        Btn_saque.Location = New Point(23, 178)
        Btn_saque.Name = "Btn_saque"
        Btn_saque.Size = New Size(94, 29)
        Btn_saque.TabIndex = 3
        Btn_saque.Text = "Button1"
        Btn_saque.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_saque)
        Controls.Add(Txt_saque)
        Controls.Add(Lbl_saque)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_saque As Label
    Friend WithEvents Txt_saque As TextBox
    Friend WithEvents Btn_saque As Button
End Class
