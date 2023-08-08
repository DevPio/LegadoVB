Imports OO.Models
Public Class Form1

    Dim accounts As List(Of
        Account) = New List(Of Account)

    Dim account As Account

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        accounts.Add(New Account(New Client("Luccas"), 1234, 5678, 300))
        accounts.Add(New Account(New Client("Gabriela"), 1234, 5678, 600))

        account = accounts(0)
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        CommonFields()
        CommonFiedTransferencia()
        Me.InitiComponent()
        UpdateScreen(True)

    End Sub

    Public Sub CommonFields()
        For Each ac In accounts
            CB_Accounts.Items.Add(ac.Titular.Nome)
        Next
    End Sub
    Public Function InitiComponent()

        Lbl_TrocaConta.Text = "Trocar conta"
        Lbl_Transferencia.Text = "Transferencia"
        Btn_Transferencia.Text = "Transferir"
        Lbl_Sacar.Text = "Valor a ser sacado"

        Btn_Sacar.Text = "Efetuar o saque"

        Lbl_Saldo.Text = "Saldo"

        Lbl_RSaque.Text = "Resultado"

        Lbl_SaldoAtual.Text = "Saldo Atual"

        Lbl_Welcome.Text = $"Bem vindo {account.Titular.Nome}"
        Txt_SaldoA.Text = account.Saldo
        Btn_Depositar.Text = "Depositar"

        Txt_Extrato.ReadOnly = True
        Txt_SaldoA.ReadOnly = True
        Txt_Saldo.ReadOnly = True
        Txt_RSaque.ReadOnly = True
    End Function
    Private Function UpdateScreen(success As Boolean) As Boolean
        If success Then
            Txt_SaldoA.Text = account.Saldo
            Txt_Saldo.Text = account.Saldo
            Txt_RSaque.Text = "Saque realizado com sucesso"

            Return True
        End If



        Txt_RSaque.Text = "Saldo insuficinte"

        Return False

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Sacar.Click

        Dim value As Double

        Double.TryParse(Txt_Sacar.Text, value)

        If value = 0 Then
            MsgBox("Digite um valor para sacar")
        End If

        If account.Saque(value) Then
            UpdateScreen(True)
            account.Extrato.Add($"Houve um Saque de {value} {Date.Now}" + Environment.NewLine)
            Extrato()

            Return
        End If


        UpdateScreen(False)

    End Sub


    Private Sub CommonFiedTransferencia()
        CB_Transferencia.ResetText()
        CB_Transferencia.Items.Clear()
        For Each acc In accounts.Where(Function(c) c.Titular.Nome <> account.Titular.Nome)
            CB_Transferencia.Items.Add(acc.Titular.Nome
                                       )
        Next
    End Sub

    Private Sub Extrato()

        Txt_Extrato.Clear()
        For Each value In account.Extrato
            Txt_Extrato.AppendText(value)
        Next
    End Sub
    Private Sub Btn_Depositar_Click(sender As Object, e As EventArgs) Handles Btn_Depositar.Click
        Dim value As Double

        Double.TryParse(Txt_Sacar.Text, value)

        If value = 0 Then
            MsgBox("Digite um valor para deposito")
        End If

        If account.Deposito(value) Then
            UpdateScreen(True)

            account.Extrato.Add($"Houve um depósito de {value} {Date.Now}" + Environment.NewLine)
            Extrato()
            Return
        End If

        UpdateScreen(False)
    End Sub

    Private Sub CB_Accounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Accounts.SelectedIndexChanged
        Dim person As String = CB_Accounts.SelectedItem.ToString()


        Dim findAccount As Account = accounts.Where(Function(acc) acc.Titular.Nome = person).FirstOrDefault()

        account = findAccount

        Me.InitiComponent()
        UpdateScreen(True)
        Extrato()
        CommonFiedTransferencia()

    End Sub

    Private Sub Btn_Transferencia_Click(sender As Object, e As EventArgs) Handles Btn_Transferencia.Click
        Dim value As Double

        Double.TryParse(Txt_Sacar.Text, value)

        Dim person As Account = accounts.Where(Function(c) c.Titular.Nome = CB_Transferencia.SelectedItem.ToString()).FirstOrDefault()

        account.Extrato.Add($"Houve um transferencia para a pessoa {person.Titular.Nome} {Date.Now}" + Environment.NewLine)
        person.Extrato.Add($"Voce recebeu uma transferencia da pessoa {account.Titular.Nome} {Date.Now}" + Environment.NewLine)

        account.Transferencia(person, value)

        UpdateScreen(True)
        Extrato()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
