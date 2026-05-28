<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Localization

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使**

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · [QQ群](https://qm.qq.com/q/5s5e1e6e6e)

**語言**: [English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)


</div>

---

## 項目簡介

Game Frame X Localization 是一個基於 GameFrameX 框架的 Unity 本地化功能包，提供完整的多語言本地化解決方案，支持動態語言切換、字符串格式化和系統語言檢測。

**Localization 本地化組件** - 提供本地化相關的接口。

## 快速開始

### 系統要求

- Unity 2019.4 或更高版本
- GameFrameX 框架 1.1.1 或更高版本

### 安裝

任選以下方式之一：

1. 直接在 `manifest.json` 的文件中的 `dependencies` 節點下添加以下內容：
   ```json
   {"com.gameframex.unity.localization": "https://github.com/AlianBlank/com.gameframex.unity.localization.git"}
   ```

2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加庫，地址為：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.localization.git
   ```

3. 直接下載倉庫放置到 Unity 項目的 `Packages` 目錄下，會自動加載識別。

## 使用範例

```csharp
// 標準方式：透過 GameEntry（不依賴 com.gameframex.unity.entry）
var localization = GameEntry.GetComponent<LocalizationComponent>();

// 設置語言
localization.Language = "zh_TW";
localization.Language = "en_US";

// 獲取本地化字符串
string text = localization.GetString("UI.Button.OK");

// 帶參數的本地化字符串
string message = localization.GetString("UI.Message.Welcome", playerName);
string info = localization.GetString("UI.Info.Score", score, level);

// 字典管理
bool exists = localization.HasRawString("UI.Button.Cancel");
string rawText = localization.GetRawString("UI.Button.Cancel");
localization.AddRawString("UI.Button.NewButton", "新按鈕");
bool removed = localization.RemoveRawString("UI.Button.Cancel");
localization.RemoveAllRawStrings();
```

## 依賴項

- `com.gameframex.unity`: GameFrameX 核心框架
- `com.gameframex.unity.asset`: 資源管理模組
- `com.gameframex.unity.event`: 事件系統模組

## 文檔與資源

- 文檔地址: https://gameframex.doc.alianblank.com
- 倉庫地址: https://github.com/GameFrameX/com.gameframex.unity.localization
- 問題反饋: https://github.com/GameFrameX/com.gameframex.unity.localization/issues

## 開源協議

本項目遵循 MIT 許可證。詳細信息請查看 [LICENSE](LICENSE.md) 文件。
