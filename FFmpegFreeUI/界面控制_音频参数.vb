Public Class 界面控制_音频参数
    Public Shared Sub 音频编码器参数开关按下事件()
        If Not Form1.UiCheckBox音频编码器.Checked Then
            Form1.UiComboBox音频编码器.Text = ""
        End If
    End Sub
    Public Shared Sub 音频编码器参数变动事件()
        If Form1.UiComboBox音频编码器.Text <> "" Then
            Form1.UiCheckBox音频编码器.Checked = True
        End If
    End Sub

    '==============================================

    Public Shared Sub 音频比特率参数开关按下事件()
        If Not Form1.UiCheckBox音频比特率.Checked Then
            Form1.UiComboBox音频比特率控制方式.Text = ""
            Form1.UiTextBox音频基础比特率.Text = ""
            Form1.UiTextBox音频比特率质量值.Text = ""
        End If
    End Sub
    Public Shared Sub 音频比特率参数变动事件()
        If Form1.UiComboBox音频比特率控制方式.Text <> "" AndAlso
          Form1.UiTextBox音频基础比特率.Text <> "" AndAlso
          Form1.UiTextBox音频比特率质量值.Text <> "" Then
            Form1.UiCheckBox音频比特率.Checked = True
        End If
    End Sub

    '==============================================

    Public Shared Sub 音频声道布局参数开关按下事件()
        If Not Form1.UiCheckBox声道布局.Checked Then
            Form1.UiComboBox声道布局.Text = ""
        End If
    End Sub
    Public Shared Sub 音频声道布局参数变动事件()
        If Form1.UiComboBox声道布局.Text <> "" Then
            Form1.UiCheckBox声道布局.Checked = True
        End If
    End Sub

    '==============================================

    Public Shared Sub 音频采样率参数开关按下事件()
        If Not Form1.UiCheckBox采样率.Checked Then
            Form1.UiComboBox采样率.Text = ""
        End If
    End Sub
    Public Shared Sub 音频采样率参数变动事件()
        If Form1.UiComboBox采样率.Text <> "" Then
            Form1.UiCheckBox采样率.Checked = True
        End If
    End Sub

    '==============================================

    Public Shared Sub 音频响度标准化参数开关按下事件()
        If Not Form1.UiCheckBox响度标准化.Checked Then
            Form1.UiTextBox响度标准化目标响度.Text = ""
            Form1.UiTextBox响度标准化动态范围.Text = ""
            Form1.UiTextBox响度标准化峰值电平.Text = ""
        End If
    End Sub
    Public Shared Sub 音频响度标准化参数变动事件()
        If Form1.UiTextBox响度标准化目标响度.Text <> "" AndAlso
            Form1.UiTextBox响度标准化动态范围.Text <> "" AndAlso
            Form1.UiTextBox响度标准化峰值电平.Text <> "" Then
            Form1.UiCheckBox响度标准化.Checked = True
        End If
    End Sub

    '==============================================

    Public Shared Sub 音频自定义滤镜开关按下事件()
        If Not Form1.UiCheckBox自定义音频滤镜.Checked Then
            Form1.UiTextBox自定义音频滤镜.Text = ""
        End If
    End Sub
    Public Shared Sub 音频自定义滤镜参数变动事件()
        If Form1.UiTextBox自定义音频滤镜.Text = "" Then
            Form1.UiCheckBox自定义音频滤镜.Checked = False
        Else
            Form1.UiCheckBox自定义音频滤镜.Checked = True
        End If
    End Sub
    Public Shared Sub 音频自定义参数开关按下事件()
        If Not Form1.UiCheckBox自定义音频参数.Checked Then
            Form1.UiTextBox自定义音频参数.Text = ""
        End If
    End Sub
    Public Shared Sub 音频自定义参数变动事件()
        If Form1.UiTextBox自定义音频参数.Text = "" Then
            Form1.UiCheckBox自定义音频参数.Checked = False
        Else
            Form1.UiCheckBox自定义音频参数.Checked = True
        End If
    End Sub

End Class
