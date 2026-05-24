<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X Localization

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams**

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/5s5e1e6e6e)

**Language**: **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## Project Overview

Game Frame X Localization is a Unity localization package based on the GameFrameX framework, providing a complete multi-language localization solution with dynamic language switching, string formatting, and system language detection.

**Localization Component** - Provides localization-related interfaces.

## Quick Start

### System Requirements

- Unity 2019.4 or higher
- GameFrameX framework 1.1.1 or higher

### Installation

Choose one of the following methods:

1. Add the following to the `dependencies` section in your project's `manifest.json`:
   ```json
   {"com.gameframex.unity.localization": "https://github.com/AlianBlank/com.gameframex.unity.localization.git"}
   ```

2. Use `Git URL` in Unity's Package Manager:
   ```
   https://github.com/AlianBlank/com.gameframex.unity.localization.git
   ```

3. Download the repository and place it in your Unity project's `Packages` directory. It will be loaded automatically.

## Usage Examples

```csharp
// Standard: via GameEntry (no dependency on com.gameframex.unity.entry)
var localization = GameEntry.GetComponent<LocalizationComponent>();

// Set language
localization.Language = "zh_CN";
localization.Language = "en_US";

// Get localized string
string text = localization.GetString("UI.Button.OK");

// Get localized string with parameters
string message = localization.GetString("UI.Message.Welcome", playerName);
string info = localization.GetString("UI.Info.Score", score, level);

// Dictionary management
bool exists = localization.HasRawString("UI.Button.Cancel");
string rawText = localization.GetRawString("UI.Button.Cancel");
localization.AddRawString("UI.Button.NewButton", "New Button");
bool removed = localization.RemoveRawString("UI.Button.Cancel");
localization.RemoveAllRawStrings();
```

## Dependencies

- `com.gameframex.unity`: GameFrameX core framework
- `com.gameframex.unity.asset`: Asset management module
- `com.gameframex.unity.event`: Event system module

## Documentation & Resources

- Documentation: https://gameframex.doc.alianblank.com
- Repository: https://github.com/GameFrameX/com.gameframex.unity.localization
- Issues: https://github.com/GameFrameX/com.gameframex.unity.localization/issues

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE.md) for details.
