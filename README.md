## FFmpegFreeUI

![GitHub Downloads](https://img.shields.io/github/downloads/Lake1059/FFmpegFreeUI/total?label=全部下载量)

FFmpegFreeUI（简称 3FUI）是在 Windows 上的 [FFmpeg](https://ffmpeg.org/) 的专业交互外壳，使用 .NET 10 框架，使用纯 WinForm 开发，配合 SunnyUI 和自绘制打造专业高效的暗黑风格界面。

设计定位：3FUI 的目标是做一款轻度专业参数调整的转码软件，并非行业深度专业软件；让普通人能够通过图形化界面接触到较为全面的通用参数来轻松压制和转换格式。

> 广告词：难以忍受格式工厂的烦人捆绑？行业专业软件限制太多？小作坊产品过于业余？来用 3FUI 就对了，专注转码，不干别的，真免费，真自由，真专业，真开源！

## 特点

- 底层逻辑基于预设，可以很方便地导入导出
- 专业参数，而非业余表述，大多数地方直接标出参数名
- 智能交互，非常的细节
- 准确显示 ffmpeg 输出的信息，更易于尝试新方案
- 实时计算剩余时间
- 可暂停！是的，可暂停
- 完成后自动开始下一个
- 干净无垃圾，不保存任何信息

## 截图

<img src="IMG\mi.png"  />

![](IMG\vp.png)

## 准备步骤

1. 首先需要明确，这只能用于 Windows，我没有能力开发其他系统的版本。
2. 前往 [FFmpeg 官网](https://ffmpeg.org/) 下载最新的发行版，gyan.dev 和 BtbN 两者的发行皆可。
   - 若选择 gyan.dev 的发行版，应该下载 ffmpeg-release-full.7z
   - 若选择 BtbN 的发行版，应该下载 ffmpeg-master-latest-win64-gpl.zip
3. 找到压缩包中的 ffmpeg.exe 可执行文件。
4. 将 ffmpeg.exe 和我的 FFmpegFreeUI.exe 放在同一个文件夹中。<br>或者将 ffmpeg.exe 加入环境变量中也可。
5. 然后就可以正常使用了。

## 反馈

- 如果我的设计对你有帮助，请考虑资金支持一下：[前往爱发电](https://afdian.com/a/1059Studio)
- 3FUI 没有针对酒吧的炒饭进行预防，非正常操作极易引发报错。
- 要反馈任何问题，请到Q群：1050613952

## 许可

- 3FUI 使用 MIT 开源许可，可以自由地使用和分发此软件。
- 但需注意的是，本软件中使用了需授权的商用许可组件！
- 仅发布于 GitHub，在其他平台看到的源代码都不是本人！

## 已收录的参数

### 视频编码器

| 编码器类别 | 提供的编码                                                   |
| ---------- | ------------------------------------------------------------ |
| 复制流     | N/A                                                          |
| H.266/VVC  | libx266<br />vvenc                                           |
| AV1        | libaom-av1<br />av1_nvenc<br />av1_qsv<br />av1_amf<br />libsvtav1<br />rav1e |
| H.265/HEVC | libx265<br />hevc_nvenc<br />hevc_qsv<br />hevc_amf          |
| H.264/AVC  | libx264<br />h264_nvenc<br />h264_qsv<br />h264_amf          |
| ProRes     | prores_ks                                                    |
| VP9        | libvpx-vp9                                                   |
| 禁用       | N/A                                                          |

### 音频编码器

- 复制流
- AAC
- LAME MP3
- FLAC
- ALAC
- WAV 16bit
- WAV 24bit
- WAV 32bit Float
- Dolby Digital AC3
- DTS Coherent Acoustics
- Opus
- Vorbis
- True Audio
- 禁用

### 图片编码器

- PNG
- JPEG\JPG
- WEBP
- TIFF
- AVIF
- GIF
- BMP
- JPEG-LS
- DPX
- OpenEXR

### 视频滤镜

- 画面缩放维持比例 scale
- 智能抽帧 select='gt(scene,?)',setpts=N/FRAME_RATE/TB
- 色彩管理 zscale
- 降噪 hqdn3d、nlmeans、atadenoise、bm3d
- 锐化 unsharp
- 转逐行 yadif
- 转隔行 setfield

### 音频滤镜

- 响度标准化 loudnorm

