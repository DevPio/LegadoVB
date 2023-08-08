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
        Btn_Sacar = New Button()
        Lbl_Sacar = New Label()
        Txt_Sacar = New TextBox()
        Lbl_Saldo = New Label()
        Txt_Saldo = New TextBox()
        Txt_RSaque = New TextBox()
        Lbl_RSaque = New Label()
        Txt_SaldoA = New TextBox()
        Lbl_SaldoAtual = New Label()
        Lbl_Welcome = New Label()
        Btn_Depositar = New Button()
        Txt_Extrato = New TextBox()
        CB_Accounts = New ComboBox()
        Lbl_Transferencia = New Label()
        Btn_Transferencia = New Button()
        Lbl_TrocaConta = New Label()
        CB_Transferencia = New ComboBox()
        SuspendLayout()
        ' 
        ' Btn_Sacar
        ' 
        Btn_Sacar.Location = New Point(40, 295)
        Btn_Sacar.Name = "Btn_Sacar"
        Btn_Sacar.Size = New Size(441, 36)
        Btn_Sacar.TabIndex = 0
        Btn_Sacar.Text = "Button1"
        Btn_Sacar.UseVisualStyleBackColor = True
        ' 
        ' Lbl_Sacar
        ' 
        Lbl_Sacar.AutoSize = True
        Lbl_Sacar.Location = New Point(43, 239)
        Lbl_Sacar.Name = "Lbl_Sacar"
        Lbl_Sacar.Size = New Size(53, 20)
        Lbl_Sacar.TabIndex = 1
        Lbl_Sacar.Text = "Label1"
        ' 
        ' Txt_Sacar
        ' 
        Txt_Sacar.Location = New Point(40, 262)
        Txt_Sacar.Name = "Txt_Sacar"
        Txt_Sacar.Size = New Size(439, 27)
        Txt_Sacar.TabIndex = 2
        ' 
        ' Lbl_Saldo
        ' 
        Lbl_Saldo.AutoSize = True
        Lbl_Saldo.Location = New Point(42, 378)
        Lbl_Saldo.Name = "Lbl_Saldo"
        Lbl_Saldo.Size = New Size(53, 20)
        Lbl_Saldo.TabIndex = 3
        Lbl_Saldo.Text = "Label1"
        ' 
        ' Txt_Saldo
        ' 
        Txt_Saldo.Location = New Point(42, 401)
        Txt_Saldo.Name = "Txt_Saldo"
        Txt_Saldo.Size = New Size(439, 27)
        Txt_Saldo.TabIndex = 4
        ' 
        ' Txt_RSaque
        ' 
        Txt_RSaque.Location = New Point(40, 463)
        Txt_RSaque.Name = "Txt_RSaque"
        Txt_RSaque.Size = New Size(441, 27)
        Txt_RSaque.TabIndex = 6
        ' 
        ' Lbl_RSaque
        ' 
        Lbl_RSaque.AutoSize = True
        Lbl_RSaque.Location = New Point(40, 440)
        Lbl_RSaque.Name = "Lbl_RSaque"
        Lbl_RSaque.Size = New Size(53, 20)
        Lbl_RSaque.TabIndex = 5
        Lbl_RSaque.Text = "Label1"
        ' 
        ' Txt_SaldoA
        ' 
        Txt_SaldoA.Location = New Point(40, 197)
        Txt_SaldoA.Name = "Txt_SaldoA"
        Txt_SaldoA.Size = New Size(439, 27)
        Txt_SaldoA.TabIndex = 8
        ' 
        ' Lbl_SaldoAtual
        ' 
        Lbl_SaldoAtual.AutoSize = True
        Lbl_SaldoAtual.Location = New Point(43, 165)
        Lbl_SaldoAtual.Name = "Lbl_SaldoAtual"
        Lbl_SaldoAtual.Size = New Size(53, 20)
        Lbl_SaldoAtual.TabIndex = 7
        Lbl_SaldoAtual.Text = "Label1"
        ' 
        ' Lbl_Welcome
        ' 
        Lbl_Welcome.AutoSize = True
        Lbl_Welcome.Location = New Point(40, 19)
        Lbl_Welcome.Name = "Lbl_Welcome"
        Lbl_Welcome.Size = New Size(53, 20)
        Lbl_Welcome.TabIndex = 9
        Lbl_Welcome.Text = "Label1"
        ' 
        ' Btn_Depositar
        ' 
        Btn_Depositar.Location = New Point(40, 337)
        Btn_Depositar.Name = "Btn_Depositar"
        Btn_Depositar.Size = New Size(441, 38)
        Btn_Depositar.TabIndex = 10
        Btn_Depositar.Text = "Button1"
        Btn_Depositar.UseVisualStyleBackColor = True
        ' 
        ' Txt_Extrato
        ' 
        Txt_Extrato.Location = New Point(549, 156)
        Txt_Extrato.Multiline = True
        Txt_Extrato.Name = "Txt_Extrato"
        Txt_Extrato.ScrollBars = ScrollBars.Vertical
        Txt_Extrato.Size = New Size(351, 334)
        Txt_Extrato.TabIndex = 11
        ' 
        ' CB_Accounts
        ' 
        CB_Accounts.FormattingEnabled = True
        CB_Accounts.Location = New Point(43, 105)
        CB_Accounts.Name = "CB_Accounts"
        CB_Accounts.Size = New Size(436, 28)
        CB_Accounts.TabIndex = 12
        ' 
        ' Lbl_Transferencia
        ' 
        Lbl_Transferencia.AutoSize = True
        Lbl_Transferencia.Location = New Point(545, 28)
        Lbl_Transferencia.Name = "Lbl_Transferencia"
        Lbl_Transferencia.Size = New Size(53, 20)
        Lbl_Transferencia.TabIndex = 13
        Lbl_Transferencia.Text = "Label1"
        ' 
        ' Btn_Transferencia
        ' 
        Btn_Transferencia.Location = New Point(729, 104)
        Btn_Transferencia.Name = "Btn_Transferencia"
        Btn_Transferencia.Size = New Size(159, 29)
        Btn_Transferencia.TabIndex = 15
        Btn_Transferencia.Text = "Button1"
        Btn_Transferencia.UseVisualStyleBackColor = True
        ' 
        ' Lbl_TrocaConta
        ' 
        Lbl_TrocaConta.AutoSize = True
        Lbl_TrocaConta.Location = New Point(43, 62)
        Lbl_TrocaConta.Name = "Lbl_TrocaConta"
        Lbl_TrocaConta.Size = New Size(53, 20)
        Lbl_TrocaConta.TabIndex = 16
        Lbl_TrocaConta.Text = "Label1"
        ' 
        ' CB_Transferencia
        ' 
        CB_Transferencia.FormattingEnabled = True
        CB_Transferencia.Location = New Point(551, 65)
        CB_Transferencia.Name = "CB_Transferencia"
        CB_Transferencia.Size = New Size(349, 28)
        CB_Transferencia.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(921, 502)
        Controls.Add(CB_Transferencia)
        Controls.Add(Lbl_TrocaConta)
        Controls.Add(Btn_Transferencia)
        Controls.Add(Lbl_Transferencia)
        Controls.Add(CB_Accounts)
        Controls.Add(Txt_Extrato)
        Controls.Add(Btn_Depositar)
        Controls.Add(Lbl_Welcome)
        Controls.Add(Txt_SaldoA)
        Controls.Add(Lbl_SaldoAtual)
        Controls.Add(Txt_RSaque)
        Controls.Add(Lbl_RSaque)
        Controls.Add(Txt_Saldo)
        Controls.Add(Lbl_Saldo)
        Controls.Add(Txt_Sacar)
        Controls.Add(Lbl_Sacar)
        Controls.Add(Btn_Sacar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_Sacar As Button
    Friend WithEvents Lbl_Sacar As Label
    Friend WithEvents Txt_Sacar As TextBox
    Friend WithEvents Lbl_Saldo As Label
    Friend WithEvents Txt_Saldo As TextBox
    Friend WithEvents Txt_RSaque As TextBox
    Friend WithEvents Lbl_RSaque As Label
    Friend WithEvents Txt_SaldoA As TextBox
    Friend WithEvents Lbl_SaldoAtual As Label
    Friend WithEvents Lbl_Welcome As Label
    Friend WithEvents Btn_Depositar As Button
    Friend WithEvents Txt_Extrato As TextBox
    Friend WithEvents CB_Accounts As ComboBox
    Friend WithEvents Lbl_Transferencia As Label
    Friend WithEvents Btn_Transferencia As Button
    Friend WithEvents Lbl_TrocaConta As Label
    Friend WithEvents CB_Transferencia As ComboBox
End Class
