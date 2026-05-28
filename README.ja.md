<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Localization

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援**

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · [QQグループ](https://qm.qq.com/q/5s5e1e6e6e)

**言語**: [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)


</div>

---

## プロジェクト概要

Game Frame X Localization は、GameFrameX フレームワークに基づく Unity ローカリゼーションパッケージで、動的言語切り替え、文字列フォーマット、システム言語検出を備えた完全な多言語ローカリゼーションソリューションを提供します。

**Localization コンポーネント** - ローカリゼーション関連のインターフェースを提供します。

## クイックスタート

### 動作環境

- Unity 2019.4 以上
- GameFrameX フレームワーク 1.1.1 以上

### インストール

以下のいずれかの方法をお選びください：

1. プロジェクトの `manifest.json` の `dependencies` セクションに以下を追加：
   ```json
   {"com.gameframex.unity.localization": "https://github.com/AlianBlank/com.gameframex.unity.localization.git"}
   ```

2. Unity の Package Manager で `Git URL` を使用：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.localization.git
   ```

3. リポジトリをダウンロードして Unity プロジェクトの `Packages` ディレクトリに配置。自動的にロードされます。

## 使用例

```csharp
// 標準: GameEntry 経由（com.gameframex.unity.entry 非依存）
var localization = GameEntry.GetComponent<LocalizationComponent>();

// 言語の設定
localization.Language = "ja_JP";
localization.Language = "en_US";

// ローカライズされた文字列の取得
string text = localization.GetString("UI.Button.OK");

// パラメータ付きローカライズ文字列の取得
string message = localization.GetString("UI.Message.Welcome", playerName);
string info = localization.GetString("UI.Info.Score", score, level);

// 辞書管理
bool exists = localization.HasRawString("UI.Button.Cancel");
string rawText = localization.GetRawString("UI.Button.Cancel");
localization.AddRawString("UI.Button.NewButton", "新しいボタン");
bool removed = localization.RemoveRawString("UI.Button.Cancel");
localization.RemoveAllRawStrings();
```

## 依存関係

- `com.gameframex.unity`: GameFrameX コアフレームワーク
- `com.gameframex.unity.asset`: アセット管理モジュール
- `com.gameframex.unity.event`: イベントシステムモジュール

## ドキュメントとリソース

- ドキュメント: https://gameframex.doc.alianblank.com
- リポジトリ: https://github.com/GameFrameX/com.gameframex.unity.localization
- Issues: https://github.com/GameFrameX/com.gameframex.unity.localization/issues

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE](LICENSE.md) ファイルを参照してください。
