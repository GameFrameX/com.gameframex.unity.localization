<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X Localization

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.localization?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.localization/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현**

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · [QQ 그룹](https://qm.qq.com/q/5s5e1e6e6e)

**언어**: [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

---

## 프로젝트 개요

Game Frame X Localization은 GameFrameX 프레임워크 기반의 Unity 현지화 패키지로, 동적 언어 전환, 문자열 포맷팅 및 시스템 언어 감지를 갖춘 완전한 다국어 현지화 솔루션을 제공합니다.

**Localization 컴포넌트** - 현지화 관련 인터페이스를 제공합니다.

## 빠른 시작

### 시스템 요구 사항

- Unity 2019.4 이상
- GameFrameX 프레임워크 1.1.1 이상

### 설치

다음 방법 중 하나를 선택하세요:

1. 프로젝트의 `manifest.json` 파일의 `dependencies` 섹션에 다음을 추가:
   ```json
   {"com.gameframex.unity.localization": "https://github.com/AlianBlank/com.gameframex.unity.localization.git"}
   ```

2. Unity의 Package Manager에서 `Git URL` 사용:
   ```
   https://github.com/AlianBlank/com.gameframex.unity.localization.git
   ```

3. 저장소를 다운로드하여 Unity 프로젝트의 `Packages` 디렉토리에 배치. 자동으로 로드됩니다.

## 사용 예시

```csharp
// 표준: GameEntry를 통해 (com.gameframex.unity.entry 비의존)
var localization = GameEntry.GetComponent<LocalizationComponent>();

// 언어 설정
localization.Language = "ko_KR";
localization.Language = "en_US";

// 현지화된 문자열 가져오기
string text = localization.GetString("UI.Button.OK");

// 매개변수가 있는 현지화된 문자열 가져오기
string message = localization.GetString("UI.Message.Welcome", playerName);
string info = localization.GetString("UI.Info.Score", score, level);

// 사전 관리
bool exists = localization.HasRawString("UI.Button.Cancel");
string rawText = localization.GetRawString("UI.Button.Cancel");
localization.AddRawString("UI.Button.NewButton", "새 버튼");
bool removed = localization.RemoveRawString("UI.Button.Cancel");
localization.RemoveAllRawStrings();
```

## 의존성

- `com.gameframex.unity`: GameFrameX 핵심 프레임워크
- `com.gameframex.unity.asset`: 에셋 관리 모듈
- `com.gameframex.unity.event`: 이벤트 시스템 모듈

## 문서 및 자료

- 문서: https://gameframex.doc.alianblank.com
- 저장소: https://github.com/GameFrameX/com.gameframex.unity.localization
- Issues: https://github.com/GameFrameX/com.gameframex.unity.localization/issues

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE](LICENSE.md) 파일을 참조하세요.
