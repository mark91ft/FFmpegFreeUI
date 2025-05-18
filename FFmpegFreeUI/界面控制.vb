
Public Class 界面控制

    Public Shared Sub 初始化()
        Form1.UiComboBox21.SelectedIndex = 0

        AddHandler Form1.UiTabControlMenu1.SelectedIndexChanged, AddressOf 界面校准
        暗黑列表视图自绘制.绑定列表视图事件(Form1.ListView1)
        暗黑列表视图自绘制.绑定列表视图事件(Form1.ListView2)


        AddHandler Form1.UiButton3.Click, AddressOf 界面控制_编码队列.开始任务
        AddHandler Form1.UiButton1.Click, AddressOf 界面控制_编码队列.暂停任务
        AddHandler Form1.UiButton2.Click, AddressOf 界面控制_编码队列.恢复任务
        AddHandler Form1.UiButton5.Click, AddressOf 界面控制_编码队列.停止任务
        AddHandler Form1.UiButton6.Click, AddressOf 界面控制_编码队列.移除任务
        AddHandler Form1.UiButton16.Click, AddressOf 界面控制_编码队列.重置任务
        AddHandler Form1.UiButton4.Click, AddressOf 界面控制_编码队列.全选任务
        AddHandler Form1.UiButton9.Click, AddressOf 界面控制_编码队列.定位输出
        AddHandler Form1.UiButton8.Click, AddressOf 界面控制_编码队列.重新配置
        AddHandler Form1.UiButton7.Click, AddressOf 界面控制_编码队列.导出配置
        AddHandler Form1.UiButton15.Click, AddressOf 界面控制_编码队列.复制命令行

        AddHandler Form1.UiButton14.Click, AddressOf 界面控制_添加文件.加入编码队列
        AddHandler Form1.ListView2.DragEnter, AddressOf 界面控制_添加文件.ListView2_DragEnter
        AddHandler Form1.ListView2.DragDrop, AddressOf 界面控制_添加文件.ListView2_DragDrop
        AddHandler Form1.UiButton18.Click, AddressOf 界面控制_添加文件.添加文件
        AddHandler Form1.UiButton10.Click, AddressOf 界面控制_添加文件.打开文件夹添加全部文件
        AddHandler Form1.UiButton11.Click, AddressOf 界面控制_添加文件.批量移除选中项
        AddHandler Form1.UiButton12.Click, AddressOf 界面控制_添加文件.移除全部项
        AddHandler Form1.UiComboBox21.SelectedIndexChanged, AddressOf 界面控制_添加文件.选择输出目录

        AddHandler Form1.UiCheckBox6.CheckedChanged, AddressOf 界面控制_视频参数.视频编码器参数开关事件
        AddHandler Form1.UiComboBox2.SelectedIndexChanged, AddressOf 界面控制_视频参数.视频编码类别改动事件
        AddHandler Form1.UiComboBox3.SelectedIndexChanged, AddressOf 界面控制_视频参数.视频具体编码改动事件
        AddHandler Form1.UiCheckBox3.Click, AddressOf 界面控制_视频参数.视频分辨率参数开关按下事件
        AddHandler Form1.UiComboBox5.TextChanged, AddressOf 界面控制_视频参数.视频分辨率文本框文本变动事件
        AddHandler Form1.UiCheckBox2.Click, AddressOf 界面控制_视频参数.视频分辨率自动计算开关按下事件
        AddHandler Form1.UiTextBox1.TextChanged, AddressOf 界面控制_视频参数.视频分辨率宽度文本框文本变动事件
        AddHandler Form1.UiTextBox2.TextChanged, AddressOf 界面控制_视频参数.视频分辨率高度文本框文本变动事件





        AddHandler Form1.UiCheckBox5.Click, AddressOf 界面控制_视频参数.视频帧速率参数开关按下事件
        AddHandler Form1.UiComboBox4.TextChanged, AddressOf 界面控制_视频参数.视频帧速率改动事件
        AddHandler Form1.UiCheckBox4.Click, AddressOf 界面控制_视频参数.视频帧速率动态帧率开关按下事件





        AddHandler Form1.UiCheckBox9.Click, AddressOf 界面控制_视频参数.视频画面视觉参数开关按下事件
        AddHandler Form1.UiComboBox6.SelectedIndexChanged, AddressOf 界面控制_视频参数.视频比特率控制方式改动事件
        AddHandler Form1.UiComboBox8.SelectedIndexChanged, AddressOf 界面控制_视频参数.视频画面规格改动事件
        AddHandler Form1.UiComboBox9.SelectedIndexChanged, AddressOf 界面控制_视频参数.视频像素格式改动事件



        AddHandler Form1.UiButton22.Click, AddressOf 预设管理.保存预设到文件
        AddHandler Form1.UiButton21.Click, AddressOf 预设管理.从文件读取预设
        AddHandler Form1.UiButton13.Click, AddressOf 预设管理.重置全部包含在预设中的设置
        Form1.是否初始化 = True
    End Sub

    Public Shared Sub 界面校准()
        Form1.Timer1.Enabled = False
        Dim 选项卡 As TabPage = Form1.UiTabControlMenu1.SelectedTab
        Select Case True
            Case 选项卡.IsEqual(Form1.TabPage编码队列)
                Form1.Label1.Width = Form1.Panel1.Width - Form1.Panel1.Padding.Left - Form1.Label2.Width - Form1.Label3.Width - Form1.Label4.Width - Form1.Label5.Width - Form1.Label6.Width - Form1.Label7.Width - 200 * Form1.DPI
                Form1.ListView1.Columns(0).Width = Form1.Label1.Width - 5 * Form1.DPI
                Form1.ListView1.Columns(1).Width = Form1.Label2.Width
                Form1.ListView1.Columns(2).Width = Form1.Label3.Width
                Form1.ListView1.Columns(3).Width = Form1.Label4.Width
                Form1.ListView1.Columns(4).Width = Form1.Label5.Width
                Form1.ListView1.Columns(5).Width = Form1.Label6.Width
                Form1.ListView1.Columns(6).Width = Form1.Label7.Width
                Form1.ListView1.Columns(7).Width = Form1.Label8.Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI * 2
            Case 选项卡.IsEqual(Form1.TabPage添加文件)
                Form1.ListView2.Columns(0).Width = Form1.ListView2.Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI * 2
            Case 选项卡.IsEqual(Form1.TabPage调试)
                Form1.Timer1.Enabled = True

        End Select
    End Sub



End Class
