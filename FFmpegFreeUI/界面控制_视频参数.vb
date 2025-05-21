Imports Sunny.UI

Public Class 界面控制_视频参数

    Public Shared Sub 视频编码器参数开关事件()
        If Form1.UiCheckBox6.Checked Then
            If Form1.UiComboBox2.Text = "" Then Form1.UiComboBox2.SelectedIndex = 0
        Else
            Form1.UiComboBox2.Text = ""
            Form1.UiComboBox3.Items.Clear()
            Form1.UiComboBox3.Text = ""
            Form1.UiComboBox7.Items.Clear()
            Form1.UiComboBox7.Text = ""
        End If
    End Sub
    Public Shared Sub 视频编码类别改动事件()
        Form1.UiComboBox3.Items.Clear()
        Form1.UiComboBox3.Text = ""
        Select Case Form1.UiComboBox2.SelectedIndex
            Case 0
                Form1.UiComboBox3.Items.Add("copy")
                Form1.UiCheckBox6.Checked = True
                Form1.UiComboBox3.SelectedIndex = 0
            Case 1    'H.266/VVC
                Form1.UiComboBox3.Items.Add("libx266")
                Form1.UiComboBox3.Items.Add("vvenc")
                Form1.UiCheckBox6.Checked = True
                Form1.UiComboBox3.SelectedIndex = 0
            Case 2    'AV1
                Form1.UiComboBox3.Items.Add("libaom-av1")
                Form1.UiComboBox3.Items.Add("av1_nvenc")
                Form1.UiComboBox3.Items.Add("av1_qsv")
                Form1.UiComboBox3.Items.Add("av1_amf")
                Form1.UiComboBox3.Items.Add("libsvtav1")
                Form1.UiComboBox3.Items.Add("rav1e")
                Form1.UiCheckBox6.Checked = True
                Form1.UiComboBox3.SelectedIndex = 0
            Case 3    'H.265/HEVC
                Form1.UiComboBox3.Items.Add("libx265")
                Form1.UiComboBox3.Items.Add("hevc_nvenc")
                Form1.UiComboBox3.Items.Add("hevc_qsv")
                Form1.UiComboBox3.Items.Add("hevc_amf")
                Form1.UiCheckBox6.Checked = True
                Form1.UiComboBox3.SelectedIndex = 0
            Case 4    'H.264/AVC
                Form1.UiComboBox3.Items.Add("libx264")
                Form1.UiComboBox3.Items.Add("h264_nvenc")
                Form1.UiComboBox3.Items.Add("h264_qsv")
                Form1.UiComboBox3.Items.Add("h264_amf")
                Form1.UiCheckBox6.Checked = True
                Form1.UiComboBox3.SelectedIndex = 0
            Case 5    'VP9
                Form1.UiComboBox3.Items.Add("libvpx-vp9")
                Form1.UiCheckBox6.Checked = True
                Form1.UiComboBox3.SelectedIndex = 0
        End Select
    End Sub
    Public Shared Sub 视频具体编码改动事件()
        Form1.UiComboBox7.Items.Clear()
        Form1.UiComboBox7.Text = ""
        Select Case Form1.UiComboBox3.Text
            Case "libx266", "vvenc"
                'H.266 专用预设
                Form1.UiComboBox7.Items.Add("")
                Form1.UiComboBox7.Items.Add("slow")
                Form1.UiComboBox7.Items.Add("medium")
                Form1.UiComboBox7.Items.Add("fast")
            Case "av1_nvenc", "hevc_nvenc", "h264_nvenc"
                'NVIDIA NVENC 专用预设
                Form1.UiComboBox7.Items.Add("")
                Form1.UiComboBox7.Items.Add("p7")
                Form1.UiComboBox7.Items.Add("p6")
                Form1.UiComboBox7.Items.Add("p5")
                Form1.UiComboBox7.Items.Add("p4")
                Form1.UiComboBox7.Items.Add("p3")
                Form1.UiComboBox7.Items.Add("p2")
                Form1.UiComboBox7.Items.Add("p1")
            Case "av1_qsv", "hevc_qsv", "h264_qsv"
                'Intel QSV 专用预设
                Form1.UiComboBox7.Items.Add("")
                Form1.UiComboBox7.Items.Add("veryslow")
                Form1.UiComboBox7.Items.Add("slower")
                Form1.UiComboBox7.Items.Add("slow")
                Form1.UiComboBox7.Items.Add("medium")
                Form1.UiComboBox7.Items.Add("fast")
                Form1.UiComboBox7.Items.Add("faster")
                Form1.UiComboBox7.Items.Add("veryfast")
            Case "av1_amf", "hevc_amf", "h264_amf"
                'AMD AMF 专用预设
                Form1.UiComboBox7.Items.Add("")
                Form1.UiComboBox7.Items.Add("quality")
                Form1.UiComboBox7.Items.Add("balanced")
                Form1.UiComboBox7.Items.Add("speed")
            Case "libaom-av1", "libsvtav1", "rav1e", "libx265", "libx264", "libvpx-vp9"
                'CPU 通用预设
                Form1.UiComboBox7.Items.Add("")
                Form1.UiComboBox7.Items.Add("veryslow")
                Form1.UiComboBox7.Items.Add("slower")
                Form1.UiComboBox7.Items.Add("slow")
                Form1.UiComboBox7.Items.Add("medium")
                Form1.UiComboBox7.Items.Add("fast")
                Form1.UiComboBox7.Items.Add("faster")
                Form1.UiComboBox7.Items.Add("veryfast")
                Form1.UiComboBox7.Items.Add("superfast")
                Form1.UiComboBox7.Items.Add("ultrafast")
        End Select
        If Form1.UiComboBox3.Text <> "" Then
            Form1.UiComboBox7.SelectedIndex = 1
        End If
    End Sub

    Public Shared Sub 视频分辨率参数开关按下事件()
        If Not Form1.UiCheckBox3.Checked Then
            Form1.UiComboBox5.Text = ""
            Form1.UiCheckBox2.Checked = False
            Form1.UiTextBox1.Text = ""
            Form1.UiTextBox2.Text = ""
        End If
    End Sub
    Public Shared Sub 视频分辨率文本框文本变动事件()
        If Form1.UiComboBox5.Text = "" Then
            If Not Form1.UiCheckBox2.Checked Then
                Form1.UiCheckBox3.Checked = False
                Form1.UiTextBox1.Text = ""
                Form1.UiTextBox2.Text = ""
            End If
        Else
            Form1.UiCheckBox3.Checked = True
            Form1.UiCheckBox2.Checked = False
            Form1.UiTextBox1.Text = ""
            Form1.UiTextBox2.Text = ""
        End If
    End Sub
    Public Shared Sub 视频分辨率自动计算开关按下事件()
        If Form1.UiCheckBox2.Checked Then
            Form1.UiCheckBox3.Checked = True
            Form1.UiComboBox5.Text = ""
        Else
            Form1.UiTextBox1.Text = ""
            Form1.UiTextBox2.Text = ""
            If Form1.UiComboBox5.Text = "" Then Form1.UiCheckBox3.Checked = False
        End If
    End Sub
    Public Shared Sub 视频分辨率宽度文本框文本变动事件()
        If Form1.UiTextBox1.Text <> "" Then
            Form1.UiTextBox2.Text = ""
            Form1.UiCheckBox2.Checked = True
            Form1.UiCheckBox3.Checked = True
            Form1.UiComboBox5.Text = ""
        Else
            If Form1.UiTextBox2.Text = "" Then Form1.UiCheckBox2.Checked = False
            If Form1.UiCheckBox2.Checked = False AndAlso Form1.UiComboBox5.Text = "" Then
                Form1.UiCheckBox3.Checked = False
            End If
        End If
    End Sub
    Public Shared Sub 视频分辨率高度文本框文本变动事件()
        If Form1.UiTextBox2.Text <> "" Then
            Form1.UiTextBox1.Text = ""
            Form1.UiCheckBox2.Checked = True
            Form1.UiCheckBox3.Checked = True
            Form1.UiComboBox5.Text = ""
        Else
            If Form1.UiTextBox1.Text = "" Then Form1.UiCheckBox2.Checked = False
            If Form1.UiCheckBox2.Checked = False AndAlso Form1.UiComboBox5.Text = "" Then
                Form1.UiCheckBox3.Checked = False
            End If
        End If
    End Sub

    Public Shared Sub 视频帧速率参数开关按下事件()
        If Not Form1.UiCheckBox5.Checked Then
            Form1.UiComboBox4.Text = ""
            Form1.UiCheckBox4.Checked = False
        End If
    End Sub
    Public Shared Sub 视频帧速率改动事件()
        If Form1.UiComboBox4.Text = "" Then
            If Not Form1.UiCheckBox4.Checked Then
                Form1.UiCheckBox5.Checked = False
            Else
                Form1.UiCheckBox5.Checked = True
            End If
        Else
            Form1.UiCheckBox5.Checked = True
        End If
    End Sub
    Public Shared Sub 视频帧速率动态帧率开关按下事件()
        If Form1.UiCheckBox4.Checked Then
            Form1.UiCheckBox5.Checked = True
        Else
            If Form1.UiComboBox4.Text = "" Then
                Form1.UiCheckBox5.Checked = False
            End If
        End If
    End Sub

    Public Shared Sub 视频比特率参数开关按下事件()
        If Not Form1.UiCheckBox8.Checked Then
            Form1.UiComboBox6.Text = ""
            Form1.UiTextBox3.Text = ""
            Form1.UiTextBox4.Text = ""
            Form1.UiTextBox13.Text = ""
            Form1.UiTextBox6.Text = ""
            Form1.UiTextBox7.Text = ""
            Form1.UiTextBox8.Text = ""
            Form1.Panel20.Visible = False
            Form1.Panel9.Visible = False
            Form1.Panel22.Visible = False
        End If
    End Sub
    Public Shared Sub 视频比特率控制方式改动事件()
        Select Case Form1.UiComboBox6.SelectedIndex
            Case 1
                Form1.Panel20.Visible = True
                Form1.Panel9.Visible = False
                Form1.Panel22.Visible = False
            Case 2
                Form1.Panel20.Visible = True
                Form1.Panel9.Visible = True
                Form1.Panel22.Visible = False
            Case 3, 4
                Form1.Panel20.Visible = True
                Form1.Panel9.Visible = False
                Form1.Panel22.Visible = False
            Case 5, 7
                Form1.Panel20.Visible = False
                Form1.Panel9.Visible = False
                Form1.Panel22.Visible = True
            Case Else
                Form1.Panel20.Visible = False
                Form1.Panel9.Visible = False
                Form1.Panel22.Visible = False
        End Select
    End Sub

    Public Shared Sub 视频快速剪辑参数开关按下事件()
        If Not Form1.UiCheckBox17.Checked Then
            Form1.UiTextBox5.Text = ""
            Form1.UiTextBox18.Text = ""
        End If
    End Sub
    Public Shared Sub 视频快速剪辑文本框文本变动事件()
        If Form1.UiTextBox5.Text = "" AndAlso Form1.UiTextBox18.Text = "" Then
            Form1.UiCheckBox17.Checked = False
        Else
            Form1.UiCheckBox17.Checked = True
        End If
    End Sub

    Public Shared Sub 视频画面视觉参数开关按下事件()
        If Not Form1.UiCheckBox9.Checked Then
            Form1.UiComboBox8.Text = ""
            Form1.UiComboBox9.Text = ""
        End If
    End Sub
    Public Shared Sub 视频画面规格改动事件()
        If Form1.UiComboBox8.Text = "" AndAlso Form1.UiComboBox9.Text = "" Then
            Form1.UiCheckBox9.Checked = False
        Else
            Form1.UiCheckBox9.Checked = True
        End If
    End Sub
    Public Shared Sub 视频像素格式改动事件()
        If Form1.UiComboBox9.Text.Contains("="c) Then Form1.UiComboBox9.Text = ""
        If Form1.UiComboBox8.Text = "" AndAlso Form1.UiComboBox9.Text = "" Then
            Form1.UiCheckBox9.Checked = False
        Else
            Form1.UiCheckBox9.Checked = True
        End If
    End Sub

    Public Shared Sub 视频编码技术参数开关按下事件()
        If Not Form1.UiCheckBox7.Checked Then
            Form1.UiComboBox11.Text = ""
            Form1.UiTextBox9.Text = ""
        End If
    End Sub
    Public Shared Sub 视频编码技术文本框文本变动事件()
        If Form1.UiComboBox11.Text = "" AndAlso Form1.UiTextBox9.Text = "" Then
            Form1.UiCheckBox7.Checked = False
        Else
            Form1.UiCheckBox7.Checked = True
        End If
    End Sub

    Public Shared Sub 视频自定义参数开关按下事件()
        If Not Form1.UiCheckBox10.Checked Then
            Form1.UiTextBox10.Text = ""
        End If
    End Sub
    Public Shared Sub 视频自定义参数文本框文本变动事件()
        If Form1.UiTextBox10.Text = "" Then
            Form1.UiCheckBox10.Checked = False
        Else
            Form1.UiCheckBox10.Checked = True
        End If
    End Sub

End Class
