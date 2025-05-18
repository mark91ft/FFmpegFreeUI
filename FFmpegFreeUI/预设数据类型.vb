
<Serializable()>
Public Class 预设数据类型
    Public Property 输出容器 As String = ""
    Public Property 自动混流同名字幕 As Boolean = False
    Public Property 解码器 As String = ""

    Public Property 视频参数_启用编码器参数 As Boolean = False
    Public Property 视频参数_编码器_类别 As String = ""
    Public Property 视频参数_编码器_具体编码 As String = ""
    Public Property 视频参数_编码器_质量 As String = ""
    Public Property 视频参数_启用分辨率参数 As Boolean = False
    Public Property 视频参数_分辨率 As String = ""
    Public Property 视频参数_分辨率自动计算 As Boolean = False
    Public Property 视频参数_分辨率_宽度 As String = ""
    Public Property 视频参数_分辨率_高度 As String = ""
    Public Property 视频参数_启用帧速率参数 As Boolean = False
    Public Property 视频参数_帧速率 As String = ""
    Public Property 视频参数_帧速率_自动丢弃多余帧 As Boolean = False
    Public Property 视频参数_启用比特率参数 As Boolean = False
    Public Property 视频参数_比特率_控制方式 As String = ""
    Public Property 视频参数_比特率_基础 As String = ""
    Public Property 视频参数_比特率_质量值 As String = ""
    Public Property 视频参数_比特率_HQ前瞻分析帧数 As String = ""
    Public Property 视频参数_比特率_最低值 As String = ""
    Public Property 视频参数_比特率_最高值 As String = ""
    Public Property 视频参数_比特率_缓冲区 As String = ""
    Public Property 视频参数_启用快速剪辑参数 As Boolean = False
    Public Property 视频参数_快速剪辑_入点 As String = ""
    Public Property 视频参数_快速剪辑_出点 As String = ""
    Public Property 视频参数_启用画面视觉参数 As Boolean = False
    Public Property 视频参数_画面视觉_规格 As String = ""
    Public Property 视频参数_画面视觉_像素格式 As String = ""
    Public Property 视频参数_启用编码技术参数 As Boolean = False
    Public Property 视频参数_编码技术_场景优化 As String = ""
    Public Property 视频参数_编码技术_级别 As String = ""
    Public Property 视频参数_启用自定义参数 As Boolean = False
    Public Property 视频参数_自定义参数 As String = ""

    Public Property 音频参数_启用编码器参数 As Boolean = False
    Public Property 音频参数_编码器_类别 As String = ""
    Public Property 音频参数_编码器_编码名称 As String = ""
    Public Property 音频参数_启用比特率参数 As Boolean = False
    Public Property 音频参数_比特率_控制方式 As String = ""
    Public Property 音频参数_比特率_基础 As String = ""
    Public Property 音频参数_比特率_质量值 As String = ""
    Public Property 音频参数_启用声道数参数 As Boolean = False
    Public Property 音频参数_声道数 As String = ""
    Public Property 音频参数_启用采样率参数 As Boolean = False
    Public Property 音频参数_采样率 As String = ""
    Public Property 音频参数_启用响度标准化参数 As Boolean = False
    Public Property 音频参数_响度标准化_目标响度 As String = ""
    Public Property 音频参数_响度标准化_动态范围 As String = ""
    Public Property 音频参数_响度标准化_峰值电平 As String = ""
    Public Property 音频参数_启用自定义参数 As Boolean = False
    Public Property 音频参数_自定义参数 As String = ""

    Public Property 图片参数_启用编码器参数 As Boolean = False
    Public Property 图片参数_编码器_编码名称 As String = ""
    Public Property 图片参数_编码器_参数 As String = ""
    Public Property 图片参数_启用分辨率参数 As Boolean = False
    Public Property 图片参数_分辨率_宽度 As String = ""
    Public Property 图片参数_分辨率_高度 As String = ""
    Public Property 图片参数_启用自定义参数 As Boolean = False
    Public Property 图片参数_自定义参数 As String = ""

End Class
