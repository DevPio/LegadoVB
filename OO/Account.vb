Namespace Models
    Public Class Account

        Public Titular As Client

        Public Agencia As Integer
        Public Conta As Integer
        Private _saldo As Double

        Public Property Saldo() As Double
            Get
                Return _saldo
            End Get
            Private Set(ByVal value As Double)
                If value >= 0 Then
                    _saldo = value
                End If

            End Set
        End Property


        Public Extrato As List(Of String) = New List(Of String)

        Public Sub New(client As Client, agencia As Integer, conta As Integer, saldo As Double)
            Me.Titular = client
            Me.Agencia = agencia
            Me.Conta = conta
            Me.Saldo = saldo
        End Sub

        Public Sub New()

        End Sub

        Public Function Deposito(value As Double) As Boolean

            If value > 0 Then
                Me.Saldo += value

            End If

            Return True

        End Function

        Public Function Saque(value As Double) As Boolean

            If value > 0 And Me.Saldo >= value Then
                Me.Saldo -= value
                Return True
            End If
            Return False
        End Function

        Public Function Transferencia(account As Account, value As Double)

            If value > 0 And Me.Saldo >= value Then

                Me.Saque(value)
                account.Deposito(value)
            End If

        End Function

        Public Overrides Function ToString() As String
            Return $"{Me.Titular.Nome} - {Me.Agencia}"
        End Function
    End Class

End Namespace