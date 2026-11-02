# HelloTap_Kudrevatykh

Практика № 1 по дисциплине «Программирование мобильных игр» — мини-игра «Hello Tap»:
по нажатию кнопки «Тапни меня» увеличивается счётчик. Вариант B (индивидуальное задание).

Автор: Кудреватых Артем Андреевич.

## Окружение

- Unity 6000.6.5f1 (Unity 6.6), шаблон 2D (URP)
- Android Build Support: встроенные Android SDK, NDK r27c, OpenJDK 17
- uGUI + TextMeshPro, Input System

## Структура

- `Assets/Scenes/SampleScene.unity` — сцена с Canvas, заголовком, счётом и кнопкой
- `Assets/Scripts/TapCounter.cs` — логика счётчика (комментарии в коде)
- `Screenshots/` — скриншоты работающего приложения

## Сборка

File → Build Profiles → Android → Switch Platform, затем Build (APK).
Package Name: `com.kudrevatykh.hellotap`, IL2CPP, ARM64, минимальный API 26.
