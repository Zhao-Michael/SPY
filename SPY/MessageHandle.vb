Public Class MessageHandle


    Private Sub MessageHandle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler SpyForm.Intance.HwndChanged, AddressOf GetMainHwnd
    End Sub

    Private Sub MessageHandle_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        GetMainHwnd()
    End Sub

    Sub GetMainHwnd()
        If (CheckBoxAutoSync.Checked) Then
            TextBoxHwnd.Text = SpyForm.Intance.textBoxHwnd.Text
        End If
    End Sub

    Private Sub TextBoxHwnd_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHwnd.TextChanged
        Dim hex = 0
        Integer.TryParse(TextBoxHwnd.Text, hex)
        LabelHwnd16.Text = "0x" & Convert.ToString(hex, 16)
    End Sub

    Private Sub TextBoxMsgID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMsgID.TextChanged
        Dim hex = 0
        Integer.TryParse(TextBoxMsgID.Text, hex)
        LabelMsg16.Text = "0x" & Convert.ToString(hex, 16)
    End Sub

    Private Sub TextBoxLP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLP.TextChanged
        Dim hex = 0
        Integer.TryParse(TextBoxLP.Text, hex)
        LabelLP16.Text = "0x" & Convert.ToString(hex, 16)
    End Sub

    Private Sub TextBoxWP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxWP.TextChanged
        Dim hex = 0
        Integer.TryParse(TextBoxWP.Text, hex)
        LabelWP16.Text = "0x" & Convert.ToString(hex, 16)
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Try
            SendMessage(TextBoxHwnd.Text, TextBoxMsgID.Text, TextBoxLP.Text, TextBoxWP.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class