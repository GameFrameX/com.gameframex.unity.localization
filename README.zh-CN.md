<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X Localization

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使**

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · [QQ群](https://qm.qq.com/q/5s5e1e6e6e)

**语言**: [English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## 项目简介

Game Frame X Localization 是一个基于 GameFrameX 框架的 Unity 本地化功能包，提供完整的多语言本地化解决方案，支持动态语言切换、字符串格式化和系统语言检测。

**Localization 本地化组件** - 提供本地化相关的接口。

## 快速开始

### 系统要求

- Unity 2019.4 或更高版本
- GameFrameX 框架 1.1.1 或更高版本

### 安装

任选以下方式之一：

1. 直接在 `manifest.json` 的文件中的 `dependencies` 节点下添加以下内容：
   ```json
   {"com.gameframex.unity.localization": "https://github.com/AlianBlank/com.gameframex.unity.localization.git"}
   ```

2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加库，地址为：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.localization.git
   ```

3. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。

## 使用示例

```csharp
// 标准方式：通过 GameEntry（不依赖 com.gameframex.unity.entry）
var localization = GameEntry.GetComponent<LocalizationComponent>();

// 设置语言
localization.Language = "zh_CN";
localization.Language = "en_US";

// 获取本地化字符串
string text = localization.GetString("UI.Button.OK");

// 带参数的本地化字符串
string message = localization.GetString("UI.Message.Welcome", playerName);
string info = localization.GetString("UI.Info.Score", score, level);

// 字典管理
bool exists = localization.HasRawString("UI.Button.Cancel");
string rawText = localization.GetRawString("UI.Button.Cancel");
localization.AddRawString("UI.Button.NewButton", "新按钮");
bool removed = localization.RemoveRawString("UI.Button.Cancel");
localization.RemoveAllRawStrings();
```

## 依赖项

- `com.gameframex.unity`: GameFrameX 核心框架
- `com.gameframex.unity.asset`: 资源管理模块
- `com.gameframex.unity.event`: 事件系统模块

## 文档与资源

- 文档地址: https://gameframex.doc.alianblank.com
- 仓库地址: https://github.com/GameFrameX/com.gameframex.unity.localization
- 问题反馈: https://github.com/GameFrameX/com.gameframex.unity.localization/issues

## 开源协议

本项目遵循 MIT 许可证。详细信息请查看 [LICENSE](LICENSE.md) 文件。
