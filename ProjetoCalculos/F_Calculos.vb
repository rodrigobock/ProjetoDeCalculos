Public Class F_Calculos

    Dim nomeTela As String

    Private Sub F_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitar()
        lblMensagem.Text = ""
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        tb_num1.Enabled = True
        tb_num2.Enabled = True
        BtnCalcular.Enabled = True
        BtnLimpar.Enabled = True

        tb_num1.Text = ""
        tb_num2.Text = ""
        lblMensagem.Text = ""
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        tb_num1.Text = ""
        tb_num2.Text = ""
        lblMensagem.Text = ""

        tb_num1.Focus()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        calcular()
        desabilitar()
    End Sub

    Sub calcular()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim total As Integer

        Try
            num1 = tb_num1.Text
            num2 = tb_num2.Text

            total = num1 + num2

            lblMensagem.Text = "Resultado: " & total
        Catch ex As Exception
            MsgBox("É necessário preencher os 2 campos corretamente. Erro: " & ex.Message)
        End Try

    End Sub

    Sub desabilitar()
        tb_num1.Enabled = False
        tb_num2.Enabled = False
        BtnCalcular.Enabled = False
    End Sub

End Class
