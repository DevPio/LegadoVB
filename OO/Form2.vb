Public Class Form2

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        Label1.Text = "Work with class"

        Lbl_saque.Text = "Valor a ser sacado"
        Btn_saque.Text = "Efetuar saque"

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class