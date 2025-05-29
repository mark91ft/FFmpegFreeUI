Public Class 界面控制_解码选项

    Public Shared Sub 解码器参数开关按下事件()
        If Not Form1.UiCheckBox解码器.Checked Then
            Form1.UiComboBox解码器.Text = ""
        End If
    End Sub

    Public Shared Sub 解码器参数变动事件()
        If Form1.UiComboBox解码器.Text <> "" Then
            Form1.UiCheckBox解码器.Checked = True
        End If
    End Sub

    Public Shared Sub 解码数据格式参数开关按下事件()
        If Not Form1.UiCheckBox解码数据格式.Checked Then
            Form1.UiComboBox解码数据格式.Text = ""
        End If
    End Sub

    Public Shared Sub 解码数据格式参数变动事件()
        If Form1.UiComboBox解码数据格式.Text <> "" Then
            Form1.UiCheckBox解码数据格式.Checked = True
        End If
    End Sub

End Class
