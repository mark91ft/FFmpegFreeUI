Imports System.ComponentModel
Public Class Form1
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Shared Property DPI As Single = Form1.CreateGraphics.DpiX / 96

    Public 是否初始化 As Boolean = False
    Private 上一次窗口状态 As FormWindowState


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        界面控制.初始化()
        上一次窗口状态 = Me.WindowState
    End Sub

    Private Async Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        界面控制.界面校准()
        重新创建句柄()
        If DPI <> 1 Then DPI变动时校准界面()

        '检测是否有网络
        If My.Computer.Network.IsAvailable Then
            Dim a As New GitHubAPI.Release
            Dim s1 As String = Await a.获取仓库发布版信息Async("Lake1059/FFmpegFreeUI", "")
            If s1 <> "" Then
                Label130.Text = s1
            Else
                Label130.Text =
                    "发布标题：" & a.发布标题 & vbCrLf &
                    "最新标签：" & a.版本标签 & vbCrLf &
                    "发布用户：" & a.发布者用户名 & vbCrLf &
                    "文件数量：" & a.可供下载的文件.Count & vbCrLf &
                    "发布时间：" & a.发布时间
            End If
        Else
            Label130.Text = "无网络连接！联网后重启应用程序以重试"
        End If
    End Sub

    Private Sub Form1_DpiChanged(sender As Object, e As DpiChangedEventArgs) Handles Me.DpiChanged
        DPI = e.DeviceDpiNew / 96
        DPI变动时校准界面()
    End Sub

    Public Sub 重新创建句柄()
        If Not Me.IsHandleCreated Then Me.CreateHandle()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If 是否初始化 = False Then Exit Sub
        If Me.WindowState = FormWindowState.Minimized Then Exit Sub
        If Me.WindowState <> 上一次窗口状态 Then
            界面控制.界面校准()
            上一次窗口状态 = Me.WindowState
        Else
            界面控制.界面校准()
        End If
    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move
        If 是否初始化 = False Then Exit Sub
        界面控制.界面校准()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.ListView1.SelectedItems.Count = 1 Then
            Label74.Text = 编码任务.队列(Me.ListView1.SelectedItems(0).Index).实时输出
            Label76.Text = String.Join(vbCrLf, 编码任务.队列(Me.ListView1.SelectedItems(0).Index).错误列表)
        Else
            Label74.Text = ""
            Label76.Text = ""
        End If
    End Sub

    Sub DPI变动时校准界面()
        Me.MinimumSize = New Size(0, 0)
        Me.ClientSize = New Size(1300 * DPI, 800 * DPI)
        Me.MinimumSize = Me.Size
        Me.UiTabControlMenu1.ItemSize = New Size(150 * DPI, 40 * DPI)
        Me.ImageList1.ImageSize = New Size(1, 30 * DPI)
    End Sub

End Class
