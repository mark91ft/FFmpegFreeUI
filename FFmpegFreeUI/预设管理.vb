Imports System.IO
Imports System.Text.Json
Imports Sunny.UI

Public Class 预设管理

    Public Shared Sub 显示预设(a As 预设数据类型)
        Form1.UiComboBox1.Text = a.输出容器
        Form1.UiCheckBox25.Checked = a.自动混流同名字幕

        重置解码器选择()
        Select Case a.解码器
            Case "cpu"
                Form1.UiRadioButton1.Checked = True
            Case "auto"
                Form1.UiRadioButton2.Checked = True
            Case "d3d11va"
                Form1.UiRadioButton3.Checked = True
            Case "qsv"
                Form1.UiRadioButton4.Checked = True
            Case "cuda"
                Form1.UiRadioButton5.Checked = True
            Case "dxva2"
                Form1.UiRadioButton6.Checked = True
            Case "opencl"
                Form1.UiRadioButton7.Checked = True
        End Select

        Form1.UiCheckBox6.Checked = a.视频参数_启用编码器参数
        Form1.UiComboBox2.Text = a.视频参数_编码器_类别
        Form1.UiComboBox3.Text = a.视频参数_编码器_具体编码
        Form1.UiComboBox7.Text = a.视频参数_编码器_质量
        Form1.UiCheckBox3.Checked = a.视频参数_启用分辨率参数
        Form1.UiComboBox5.Text = a.视频参数_分辨率
        Form1.UiCheckBox2.Checked = a.视频参数_分辨率自动计算
        Form1.UiTextBox1.Text = a.视频参数_分辨率_宽度
        Form1.UiTextBox2.Text = a.视频参数_分辨率_高度
        Form1.UiCheckBox5.Checked = a.视频参数_启用帧速率参数
        Form1.UiComboBox4.Text = a.视频参数_帧速率
        Form1.UiCheckBox4.Checked = a.视频参数_帧速率_自动丢弃多余帧
        Form1.UiCheckBox8.Checked = a.视频参数_启用比特率参数
        '动态码率 VBR - 存储首选，硬件加速首选
        '动态码率 VBR HQ - 硬件加速专用，极致质量
        '恒定质量 CRF - 存储首选，软件编码首选
        '恒定量化 CQP - 不推荐，主用于研究和特定场景
        '平均码率 ABR - 折中方案，在一定范围内波动
        '二次编码 TPE - 花费时间节省比特率
        '恒定速率 CBR - 流媒体常用，不适合存储
        Select Case a.视频参数_比特率_控制方式
            Case "VBR"
                Form1.UiComboBox6.SelectedIndex = 1
            Case "VBR HQ"
                Form1.UiComboBox6.SelectedIndex = 2
            Case "CRF"
                Form1.UiComboBox6.SelectedIndex = 3
            Case "CQP"
                Form1.UiComboBox6.SelectedIndex = 4
            Case "ABR"
                Form1.UiComboBox6.SelectedIndex = 5
            Case "TPE"
                Form1.UiComboBox6.SelectedIndex = 6
            Case "CBR"
                Form1.UiComboBox6.SelectedIndex = 7
        End Select
        Form1.UiTextBox3.Text = a.视频参数_比特率_基础
        Form1.UiTextBox4.Text = a.视频参数_比特率_质量值
        Form1.UiTextBox13.Text = a.视频参数_比特率_HQ前瞻分析帧数
        Form1.UiTextBox6.Text = a.视频参数_比特率_最低值
        Form1.UiTextBox7.Text = a.视频参数_比特率_最高值
        Form1.UiTextBox8.Text = a.视频参数_比特率_缓冲区
        Form1.UiCheckBox17.Checked = a.视频参数_启用快速剪辑参数
        Form1.UiTextBox5.Text = a.视频参数_快速剪辑_入点
        Form1.UiTextBox18.Text = a.视频参数_快速剪辑_出点
        Form1.UiCheckBox9.Checked = a.视频参数_启用画面视觉参数
        Form1.UiComboBox8.Text = a.视频参数_画面视觉_规格
        Form1.UiComboBox9.Text = a.视频参数_画面视觉_像素格式
        Form1.UiCheckBox7.Checked = a.视频参数_启用编码技术参数
        Form1.UiComboBox11.Text = a.视频参数_编码技术_场景优化
        Form1.UiTextBox9.Text = a.视频参数_编码技术_级别
        Form1.UiCheckBox10.Checked = a.视频参数_启用自定义参数
        Form1.UiTextBox10.Text = a.视频参数_自定义参数

        Form1.UiCheckBox12.Checked = a.音频参数_启用编码器参数
        Form1.UiComboBox10.Text = a.音频参数_编码器_编码名称
        Form1.UiCheckBox13.Checked = a.音频参数_启用比特率参数
        Select Case a.音频参数_比特率_控制方式
            Case "CBR"
                Form1.UiComboBox13.SelectedIndex = 1
            Case "VBR"
                Form1.UiComboBox13.SelectedIndex = 2
            Case "FLAC"
                Form1.UiComboBox13.SelectedIndex = 3
        End Select
        Form1.UiTextBox11.Text = a.音频参数_比特率_基础
        Form1.UiTextBox12.Text = a.音频参数_比特率_质量值
        Form1.UiCheckBox15.Checked = a.音频参数_启用声道数参数
        Form1.UiComboBox14.Text = a.音频参数_声道数
        Form1.UiCheckBox14.Checked = a.音频参数_启用采样率参数
        Form1.UiComboBox15.Text = a.音频参数_采样率
        Form1.UiCheckBox16.Checked = a.音频参数_启用响度标准化参数
        Form1.UiTextBox17.Text = a.音频参数_响度标准化_目标响度
        Form1.UiTextBox15.Text = a.音频参数_响度标准化_动态范围
        Form1.UiTextBox16.Text = a.音频参数_响度标准化_峰值电平
        Form1.UiCheckBox20.Checked = a.音频参数_启用自定义参数
        Form1.UiTextBox25.Text = a.音频参数_自定义参数

        Form1.UiCheckBox29.Checked = a.图片参数_启用编码器参数
        Form1.UiComboBox20.Text = a.图片参数_编码器_编码名称
        Form1.UiTextBox30.Text = a.图片参数_编码器_参数
        Form1.UiCheckBox27.Checked = a.图片参数_启用分辨率参数
        Form1.UiTextBox29.Text = a.图片参数_分辨率_宽度
        Form1.UiTextBox28.Text = a.图片参数_分辨率_高度
        Form1.UiCheckBox26.Checked = a.图片参数_启用自定义参数
        Form1.UiTextBox31.Text = a.图片参数_自定义参数

    End Sub

    Public Shared Sub 储存预设(ByRef a As 预设数据类型)
        a.输出容器 = Form1.UiComboBox1.Text
        a.自动混流同名字幕 = Form1.UiCheckBox25.Checked

        If Form1.UiRadioButton1.Checked Then a.解码器 = "cpu"
        If Form1.UiRadioButton2.Checked Then a.解码器 = "auto"
        If Form1.UiRadioButton3.Checked Then a.解码器 = "d3d11va"
        If Form1.UiRadioButton4.Checked Then a.解码器 = "qsv"
        If Form1.UiRadioButton5.Checked Then a.解码器 = "cuda"
        If Form1.UiRadioButton6.Checked Then a.解码器 = "dxva2"
        If Form1.UiRadioButton7.Checked Then a.解码器 = "opencl"

        a.视频参数_启用编码器参数 = Form1.UiCheckBox6.Checked
        a.视频参数_编码器_类别 = Form1.UiComboBox2.Text
        a.视频参数_编码器_具体编码 = Form1.UiComboBox3.Text
        a.视频参数_编码器_质量 = Form1.UiComboBox7.Text
        a.视频参数_启用分辨率参数 = Form1.UiCheckBox3.Checked
        a.视频参数_分辨率 = Form1.UiComboBox5.Text
        a.视频参数_分辨率自动计算 = Form1.UiCheckBox2.Checked
        a.视频参数_分辨率_宽度 = Form1.UiTextBox1.Text
        a.视频参数_分辨率_高度 = Form1.UiTextBox2.Text
        a.视频参数_启用帧速率参数 = Form1.UiCheckBox5.Checked
        a.视频参数_帧速率 = Form1.UiComboBox4.Text
        a.视频参数_帧速率_自动丢弃多余帧 = Form1.UiCheckBox4.Checked
        a.视频参数_启用比特率参数 = Form1.UiCheckBox8.Checked
        '动态码率 VBR - 存储首选，硬件加速首选
        '动态码率 VBR HQ - 硬件加速专用，极致质量
        '恒定质量 CRF - 存储首选，软件编码首选
        '恒定量化 CQP - 不推荐，主用于研究和特定场景
        '平均码率 ABR - 折中方案，在一定范围内波动
        '二次编码 TPE - 花费时间节省比特率
        '恒定速率 CBR - 流媒体常用，不适合存储
        If Form1.UiComboBox6.SelectedIndex = 1 Then a.视频参数_比特率_控制方式 = "VBR"
        If Form1.UiComboBox6.SelectedIndex = 2 Then a.视频参数_比特率_控制方式 = "VBR HQ"
        If Form1.UiComboBox6.SelectedIndex = 3 Then a.视频参数_比特率_控制方式 = "CRF"
        If Form1.UiComboBox6.SelectedIndex = 4 Then a.视频参数_比特率_控制方式 = "CQP"
        If Form1.UiComboBox6.SelectedIndex = 5 Then a.视频参数_比特率_控制方式 = "ABR"
        If Form1.UiComboBox6.SelectedIndex = 6 Then a.视频参数_比特率_控制方式 = "TPE"
        If Form1.UiComboBox6.SelectedIndex = 7 Then a.视频参数_比特率_控制方式 = "CBR"
        a.视频参数_比特率_基础 = Form1.UiTextBox3.Text
        a.视频参数_比特率_质量值 = Form1.UiTextBox4.Text
        a.视频参数_比特率_HQ前瞻分析帧数 = Form1.UiTextBox13.Text
        a.视频参数_比特率_最低值 = Form1.UiTextBox6.Text
        a.视频参数_比特率_最高值 = Form1.UiTextBox7.Text
        a.视频参数_比特率_缓冲区 = Form1.UiTextBox8.Text
        a.视频参数_启用快速剪辑参数 = Form1.UiCheckBox17.Checked
        a.视频参数_快速剪辑_入点 = Form1.UiTextBox5.Text
        a.视频参数_快速剪辑_出点 = Form1.UiTextBox18.Text
        a.视频参数_启用画面视觉参数 = Form1.UiCheckBox9.Checked
        a.视频参数_画面视觉_规格 = Form1.UiComboBox8.Text
        a.视频参数_画面视觉_像素格式 = Form1.UiComboBox9.Text
        a.视频参数_启用编码技术参数 = Form1.UiCheckBox7.Checked
        a.视频参数_编码技术_场景优化 = Form1.UiComboBox11.Text
        a.视频参数_编码技术_级别 = Form1.UiTextBox9.Text
        a.视频参数_启用自定义参数 = Form1.UiCheckBox10.Checked
        a.视频参数_自定义参数 = Form1.UiTextBox10.Text

        a.音频参数_启用编码器参数 = Form1.UiCheckBox12.Checked
        a.音频参数_编码器_编码名称 = Form1.UiComboBox10.Text
        a.音频参数_启用比特率参数 = Form1.UiCheckBox13.Checked
        If Form1.UiComboBox13.SelectedIndex = 1 Then a.音频参数_比特率_控制方式 = "CBR"
        If Form1.UiComboBox13.SelectedIndex = 2 Then a.音频参数_比特率_控制方式 = "VBR"
        If Form1.UiComboBox13.SelectedIndex = 3 Then a.音频参数_比特率_控制方式 = "FLAC"
        a.音频参数_比特率_基础 = Form1.UiTextBox11.Text
        a.音频参数_比特率_质量值 = Form1.UiTextBox12.Text
        a.音频参数_启用声道数参数 = Form1.UiCheckBox15.Checked
        a.音频参数_声道数 = Form1.UiComboBox14.Text
        a.音频参数_启用采样率参数 = Form1.UiCheckBox14.Checked
        a.音频参数_采样率 = Form1.UiComboBox15.Text
        a.音频参数_启用响度标准化参数 = Form1.UiCheckBox16.Checked
        a.音频参数_响度标准化_目标响度 = Form1.UiTextBox17.Text
        a.音频参数_响度标准化_动态范围 = Form1.UiTextBox15.Text
        a.音频参数_响度标准化_峰值电平 = Form1.UiTextBox16.Text
        a.音频参数_启用自定义参数 = Form1.UiCheckBox20.Checked
        a.音频参数_自定义参数 = Form1.UiTextBox25.Text

        a.图片参数_启用编码器参数 = Form1.UiCheckBox29.Checked
        a.图片参数_编码器_编码名称 = Form1.UiComboBox20.Text
        a.图片参数_编码器_参数 = Form1.UiTextBox30.Text
        a.图片参数_启用分辨率参数 = Form1.UiCheckBox27.Checked
        a.图片参数_分辨率_宽度 = Form1.UiTextBox29.Text
        a.图片参数_分辨率_高度 = Form1.UiTextBox28.Text
        a.图片参数_启用自定义参数 = Form1.UiCheckBox26.Checked
        a.图片参数_自定义参数 = Form1.UiTextBox31.Text

    End Sub

    Public Shared Sub 重置解码器选择()
        Form1.UiRadioButton1.Checked = False
        Form1.UiRadioButton2.Checked = True
        Form1.UiRadioButton3.Checked = False
        Form1.UiRadioButton4.Checked = False
        Form1.UiRadioButton5.Checked = False
        Form1.UiRadioButton6.Checked = False
        Form1.UiRadioButton6.Checked = False
    End Sub

    Public Shared Sub 保存预设到文件()
        Dim d As New SaveFileDialog With {.Filter = "Json|*.json"}
        d.ShowDialog(Form1)
        If d.FileName = "" Then Exit Sub
        Dim a As New 预设数据类型
        储存预设(a)
        File.WriteAllText(d.FileName, JsonSerializer.Serialize(a, JsonSO))
    End Sub

    Public Shared Sub 从文件读取预设()
        Dim d As New OpenFileDialog With {.Filter = "Json|*.json"}
        d.ShowDialog(Form1)
        If Not File.Exists(d.FileName) Then Exit Sub
        显示预设(JsonSerializer.Deserialize(Of 预设数据类型)(File.ReadAllText(d.FileName)))
    End Sub

    Public Shared Sub 重置全部包含在预设中的设置()
        Form1.UiComboBox1.Text = ""
        Form1.UiCheckBox25.Checked = False
        重置解码器选择()
        Form1.UiRadioButton2.Checked = True
        Form1.UiCheckBox6.Checked = False
        Form1.UiComboBox2.Text = ""
        Form1.UiComboBox3.Text = ""
        Form1.UiComboBox7.Text = ""
        Form1.UiCheckBox3.Checked = False
        Form1.UiComboBox5.Text = ""
        Form1.UiCheckBox2.Checked = False
        Form1.UiTextBox1.Text = ""
        Form1.UiTextBox2.Text = ""
        Form1.UiCheckBox5.Checked = False
        Form1.UiComboBox4.Text = ""
        Form1.UiCheckBox4.Checked = False
        Form1.UiCheckBox8.Checked = False
        Form1.UiComboBox6.Text = ""
        Form1.UiTextBox3.Text = ""
        Form1.UiTextBox4.Text = ""
        Form1.UiTextBox6.Text = ""
        Form1.UiTextBox7.Text = ""
        Form1.UiTextBox8.Text = ""
        Form1.UiCheckBox17.Checked = False
        Form1.UiTextBox5.Text = ""
        Form1.UiTextBox18.Text = ""
        Form1.UiCheckBox9.Checked = False
        Form1.UiComboBox8.Text = ""
        Form1.UiComboBox9.Text = ""
        Form1.UiCheckBox7.Checked = False
        Form1.UiComboBox11.Text = ""
        Form1.UiTextBox9.Text = ""
        Form1.UiCheckBox10.Checked = False
        Form1.UiTextBox10.Text = ""

        Form1.UiCheckBox12.Checked = False
        Form1.UiComboBox10.Text = ""
        Form1.UiCheckBox13.Checked = False
        Form1.UiComboBox13.Text = ""
        Form1.UiTextBox11.Text = ""
        Form1.UiTextBox12.Text = ""
        Form1.UiCheckBox15.Checked = False
        Form1.UiComboBox14.Text = ""
        Form1.UiCheckBox14.Checked = False
        Form1.UiComboBox15.Text = ""
        Form1.UiCheckBox16.Checked = False
        Form1.UiTextBox17.Text = ""
        Form1.UiTextBox15.Text = ""
        Form1.UiTextBox16.Text = ""
        Form1.UiCheckBox20.Checked = False
        Form1.UiTextBox25.Text = ""

        Form1.UiCheckBox29.Checked = False
        Form1.UiComboBox20.Text = ""
        Form1.UiTextBox30.Text = ""
        Form1.UiCheckBox27.Checked = False
        Form1.UiTextBox29.Text = ""
        Form1.UiTextBox28.Text = ""
        Form1.UiCheckBox26.Checked = False
        Form1.UiTextBox31.Text = ""

    End Sub

    Public Shared Function 将预设数据转换为命令行(a As 预设数据类型, 输入文件 As String, 输出文件 As String) As String
        Dim 视频滤镜参数集 As New List(Of String)

        Dim 输入文件的文件夹 As String = Path.GetDirectoryName(输入文件)
        Dim 将自动混流的SRT字幕 As String = Path.Combine(输入文件的文件夹, Path.GetFileNameWithoutExtension(输入文件) & ".srt")
        Dim 将自动混流的ASS字幕 As String = Path.Combine(输入文件的文件夹, Path.GetFileNameWithoutExtension(输入文件) & ".ass")
        Dim 将自动混流的SSA字幕 As String = Path.Combine(输入文件的文件夹, Path.GetFileNameWithoutExtension(输入文件) & ".ssa")
        Dim 是否自动混流了字幕 As Boolean = False



        Dim arg As String = "-hide_banner "

        If a.解码器 <> "" Then arg &= $"-hwaccel {a.解码器} "

        arg &= $"-i {""""}{输入文件}{""""} "

        If a.自动混流同名字幕 Then
            If FileIO.FileSystem.FileExists(将自动混流的SRT字幕) Then
                arg &= $"-i {""""}{将自动混流的SRT字幕}{""""} "
                是否自动混流了字幕 = True
            ElseIf FileIO.FileSystem.FileExists(将自动混流的ASS字幕) Then
                arg &= $"-i {""""}{将自动混流的ASS字幕}{""""} "
                是否自动混流了字幕 = True
            ElseIf FileIO.FileSystem.FileExists(将自动混流的SSA字幕) Then
                arg &= $"-i {""""}{将自动混流的SSA字幕}{""""} "
                是否自动混流了字幕 = True
            End If
            If 是否自动混流了字幕 Then arg &= $"-map 0 -map 1  "
        End If

        If a.视频参数_编码器_类别 = "禁用" Then arg &= $"-vn "
        If a.视频参数_启用编码器参数 Then
            If a.视频参数_编码器_具体编码 <> "" Then arg &= $"-c:v {a.视频参数_编码器_具体编码} "
            If a.视频参数_编码器_质量 <> "" Then arg &= $"-preset {a.视频参数_编码器_质量} "
        End If
        If a.视频参数_启用分辨率参数 Then
            If a.视频参数_分辨率 <> "" Then
                arg &= $"-s {a.视频参数_分辨率} "
            Else
                If a.视频参数_分辨率自动计算 Then
                    If a.视频参数_分辨率_宽度 <> "" Then
                        视频滤镜参数集.Add($"scale={a.视频参数_分辨率_宽度}:-2")
                    ElseIf a.视频参数_分辨率_高度 <> "" Then
                        视频滤镜参数集.Add($"scale=-2:{a.视频参数_分辨率_高度}")
                    End If
                End If
            End If
        End If
        If a.视频参数_启用帧速率参数 Then
            If a.视频参数_帧速率 <> "" Then arg &= $"-r {a.视频参数_帧速率} "
            If a.视频参数_帧速率_自动丢弃多余帧 Then arg &= "-vsync vfr "
        End If
        If a.视频参数_启用比特率参数 Then
            '动态码率 VBR - 存储首选，硬件加速首选
            '动态码率 VBR HQ - 硬件加速专用，极致质量
            '恒定质量 CRF - 存储首选，软件编码首选
            '恒定量化 CQP - 不推荐，主用于研究和特定场景
            '平均码率 ABR - 折中方案，在一定范围内波动
            '二次编码 TPE - 花费时间节省比特率
            '恒定速率 CBR - 流媒体常用，不适合存储
            Select Case a.视频参数_比特率_控制方式
                Case "VBR"
                    arg &= $"-rc vbr "
                    If a.视频参数_比特率_基础 <> "" Then arg &= $"-b:v {a.视频参数_比特率_基础} "
                    If a.视频参数_比特率_质量值 <> "" Then arg &= $"-cq {a.视频参数_比特率_质量值} "
                Case "VBR HQ"
                    Select Case a.视频参数_编码器_具体编码
                        Case "hevc_nvenc", "h264_nvenc"
                            arg &= $"-rc vbr_hq "
                            If a.视频参数_比特率_质量值 <> "" Then arg &= $"-cq {a.视频参数_比特率_质量值} "
                            If a.视频参数_比特率_HQ前瞻分析帧数 <> "" Then arg &= $"-rc-lookahead {a.视频参数_比特率_HQ前瞻分析帧数} "
                        Case "hevc_amf", "h264_amf"
                            arg &= $"-rc vbr_peak "
                            If a.视频参数_比特率_质量值 <> "" Then arg &= $"-cq {a.视频参数_比特率_质量值} "
                            arg &= $"-quality quality "
                        Case "hevc_qsv", "h264_qsv"
                            arg &= $"-rc la_icq "
                            If a.视频参数_比特率_质量值 <> "" Then arg &= $"-cq {a.视频参数_比特率_质量值} "
                            If a.视频参数_比特率_HQ前瞻分析帧数 <> "" Then arg &= $"-look_ahead_depth {a.视频参数_比特率_HQ前瞻分析帧数} "
                        Case Else
                            Exit Select
                    End Select
                    'HQ模式不支持码率设置
                Case "CRF"
                    If a.视频参数_比特率_基础 <> "" Then arg &= $"-b:v {a.视频参数_比特率_基础} "
                    If a.视频参数_比特率_质量值 <> "" Then arg &= $"-crf {a.视频参数_比特率_质量值} "
                Case "CQP"
                    If a.视频参数_比特率_基础 <> "" Then arg &= $"-b:v {a.视频参数_比特率_基础} "
                    If a.视频参数_比特率_质量值 <> "" Then arg &= $"-qp {a.视频参数_比特率_质量值} "
                Case "ABR"
                    If a.视频参数_比特率_基础 <> "" Then arg &= $"-b:v {a.视频参数_比特率_基础} "
                    If a.视频参数_比特率_最低值 <> "" Then arg &= $"-minrate {a.视频参数_比特率_最低值} "
                    If a.视频参数_比特率_最高值 <> "" Then arg &= $"-maxrate {a.视频参数_比特率_最高值} "
                    If a.视频参数_比特率_缓冲区 <> "" Then arg &= $"-bufsize {a.视频参数_比特率_缓冲区} "
                Case "TPE"
                    If a.视频参数_比特率_基础 <> "" Then arg &= $"-b:v {a.视频参数_比特率_基础} "
                    arg &= $"-pass 2 "
                Case "CBR"
                    arg &= $"-rc cbr "
                    If a.视频参数_比特率_基础 <> "" Then arg &= $"-b:v {a.视频参数_比特率_基础} "
                    If a.视频参数_比特率_最低值 <> "" Then arg &= $"-minrate {a.视频参数_比特率_最低值} "
                    If a.视频参数_比特率_最高值 <> "" Then arg &= $"-maxrate {a.视频参数_比特率_最高值} "
                    If a.视频参数_比特率_缓冲区 <> "" Then arg &= $"-bufsize {a.视频参数_比特率_缓冲区} "
            End Select
        End If
        If a.视频参数_启用快速剪辑参数 Then
            If a.视频参数_快速剪辑_入点 <> "" AndAlso a.视频参数_快速剪辑_出点 <> "" Then
                arg &= $"-ss {a.视频参数_快速剪辑_入点} -to {a.视频参数_快速剪辑_出点} "
            End If
        End If
        If a.视频参数_启用画面视觉参数 Then
            If a.视频参数_画面视觉_规格 <> "" Then arg &= $"-profile:v {a.视频参数_画面视觉_规格} "
            If a.视频参数_画面视觉_像素格式 <> "" Then arg &= $"-pix_fmt {a.视频参数_画面视觉_像素格式} "
        End If
        If a.视频参数_启用编码技术参数 Then
            If a.视频参数_编码技术_场景优化 <> "" Then arg &= $"-tune {a.视频参数_编码技术_场景优化} "
            If a.视频参数_编码技术_级别 <> "" Then arg &= $"-level {a.视频参数_编码技术_级别} "
        End If
        If a.视频参数_启用自定义参数 AndAlso a.视频参数_自定义参数 <> "" Then
            arg &= a.视频参数_自定义参数 & " "
        End If


        If a.音频参数_启用编码器参数 AndAlso a.音频参数_编码器_编码名称 <> "" Then
            Select Case a.音频参数_编码器_编码名称
                Case "复制流"
                    arg &= $"-c:a copy "
                Case "AAC"
                    arg &= $"-c:a aac "
                Case "LAME MP3"
                    arg &= $"-c:a libmp3lame "
                Case "FLAC"
                    arg &= $"-c:a flac "
                Case "ALAC"
                    arg &= $"-c:a alac "
                Case "WAV 16bit"
                    arg &= $"-c:a pcm_s16le "
                Case "WAV 24bit"
                    arg &= $"-c:a pcm_s24le "
                Case "WAV 32bit Float"
                    arg &= $"-c:a pcm_f32le "
                Case "Dolby Digital AC3"
                    arg &= $"-c:a ac3 "
                Case "DTS Coherent Acoustics"
                    arg &= $"-c:a dca "
                Case "Opus"
                    arg &= $"-c:a libopus "
                Case "Vorbis"
                    arg &= $"-c:a libvorbis "
                Case "True Audio"
                    arg &= $"-c:a tta "
                Case "禁用"
                    arg &= $"-an "
            End Select
        End If
        If a.音频参数_启用比特率参数 Then
            Select Case a.音频参数_比特率_控制方式
                Case "CBR"
                    If a.音频参数_比特率_基础 <> "" Then arg &= $"-b:a {a.音频参数_比特率_基础} "
                Case "VBR"
                    If a.音频参数_比特率_基础 <> "" Then arg &= $"-b:a {a.音频参数_比特率_基础} "
                    If a.音频参数_比特率_质量值 <> "" Then arg &= $"-q:a {a.音频参数_比特率_质量值} "
                Case "FLAC"
                    If a.音频参数_比特率_质量值 <> "" Then arg &= $"-compression_level {a.音频参数_比特率_质量值} "
            End Select
        End If
        If a.音频参数_启用声道数参数 Then
            If a.音频参数_声道数 <> "" Then arg &= $"-channel_layout {a.音频参数_声道数} "
        End If
        If a.音频参数_启用采样率参数 Then
            If a.音频参数_采样率 <> "" Then arg &= $"-ar {a.音频参数_采样率} "
        End If
        If a.音频参数_启用响度标准化参数 Then
            arg &= $"-af loudnorm=I={If(a.音频参数_响度标准化_目标响度 <> "", a.音频参数_响度标准化_目标响度, -16)}:LRA={If(a.音频参数_响度标准化_动态范围 <> "", a.音频参数_响度标准化_动态范围, 1)}:tp={If(a.音频参数_响度标准化_峰值电平 <> "", a.音频参数_响度标准化_峰值电平, -1)}  "
        End If
        If a.音频参数_启用自定义参数 Then
            If a.音频参数_自定义参数 <> "" Then arg &= a.音频参数_自定义参数 & " "
        End If

        If a.图片参数_启用编码器参数 Then
            Select Case a.图片参数_编码器_编码名称
                Case "无损压缩 PNG 已强制最高压缩度"
                    arg &= $"-c:v png -compression_level 100 "
                Case "有损压缩 JPEG \ JPG 质量控制越小越高 1~31"
                    arg &= $"-c:v mjpeg -q:v {If(a.图片参数_编码器_参数 <> "", a.图片参数_编码器_参数, 1)} "
                Case "有损压缩 WEBP 质量控制越大越高 0~100"
                    arg &= $"-c:v libwebp -q:v {If(a.图片参数_编码器_参数 <> "", a.图片参数_编码器_参数, 100)} "
                Case "无损压缩 WEBP"
                    arg &= $"-c:v libwebp -lossless 1 "
                Case "无损压缩 TIFF"
                    arg &= $"-c:v tiff "
                Case "有损压缩 AVIF 质量控制越大越高 0~100"
                    arg &= $"-c:v libavif -q:v {If(a.图片参数_编码器_参数 <> "", a.图片参数_编码器_参数, 100)} "
                Case "无损压缩 AVIF"
                    arg &= $"-c:v libavif -lossless 1 "
                Case "传统动画 GIF"
                    arg &= $"-c:v gif "
                Case "原画位图 BMP"
                    arg &= $"-c:v bmp "
                Case "医学影像 JPEG - LS"
                    arg &= $"-c:v jpegls "
                Case "电影扫描 DPX"
                    arg &= $"-c:v dpx "
                Case "工业光魔 OpenEXR"
                    arg &= $"-c:v exr "
            End Select
        End If
        If a.图片参数_启用分辨率参数 Then
            If a.图片参数_分辨率_宽度 <> "" AndAlso a.图片参数_分辨率_高度 <> "" Then
                视频滤镜参数集.Add($"scale={a.图片参数_分辨率_宽度}:{a.图片参数_分辨率_高度}")
            ElseIf a.图片参数_分辨率_宽度 <> "" AndAlso a.图片参数_分辨率_高度 = "" Then
                视频滤镜参数集.Add($"scale={a.图片参数_分辨率_宽度}:-2")
            ElseIf a.图片参数_分辨率_宽度 = "" AndAlso a.图片参数_分辨率_高度 <> "" Then
                视频滤镜参数集.Add($"scale=-2:{a.图片参数_分辨率_高度}")
            End If
        End If
        If a.图片参数_启用自定义参数 Then
            If a.图片参数_自定义参数 <> "" Then arg &= a.图片参数_自定义参数 & " "
        End If

        If 视频滤镜参数集.Count > 0 Then
            Dim vf As String = String.Join(",", 视频滤镜参数集)
            arg &= $"-vf ""{vf}"" "
        End If

        arg &= $"{""""}{输出文件}{""""} -y "

        Return arg
    End Function

    Public Shared Function 将预设数据转换为描述摘要(a As 预设数据类型) As String
        Dim str As String = "预设数据描述摘要"


        Return str
    End Function



End Class
