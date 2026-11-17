# Obywatelu, pomożecie? 🕵️‍♂️ (Projekt Cyberiada 2026–2027)

Psychologiczny thriller detektywistyczny w realiach PRL.



## 🛠️ Wymagania wstępne

Aby uruchomić, potrzeba:

1. **.NET 8.0 SDK (x64)**  
   - Pobierz z oficjalnej strony: [dotnet.microsoft.com/download/dotnet/8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
   - Sprawdź instalację w terminalu:
     ```bash
     dotnet --version
     ```

2. **Godot Engine 4.x - .NET Edition**  
   - Pobierz wersję z dopiskiem **.NET** (np. `Godot_v4.x_mono_win64.zip`): [godotengine.org/download](https://godotengine.org/download)
   - *Uwaga:* Standardowa wersja Godota (bez wsparcia .NET) nie obsługuje C#!



## Pierwsze uruchomienie projektu

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/SknTROJAN/Obywatelu-Pomozecie.git
   ```
2. Otwórz **Godot Engine (.NET)**, kliknij **Import** i wskaż plik `project/project.godot`.
3. Zbuduj solucję klikając w prawym górnym rogu Godota w ikonę **Build** (młotek) lub w terminalu w katalogu `/project`:
   ```bash
   dotnet build
   ```
4. Uruchom grę klawiszem **F5**. W oknie *Output* powinien pojawić się komunikat startowy z wersją projektu.

## 📂 Struktura katalogów

- `/project` – Silnik gry (Godot 4, C#)
  - `Scenes/` – Sceny (`UI/`, `Common/`)
  - `Scripts/` – Kod logiczny (`Core/`, )
  - `Assets/` – Grafiki, audio, czcionki, shadery
  - `Config/` – Pliki konfiguracyjne
- `/backend` – Proxy API (ASP.NET Core łączące z LLM)
- `/docs` – Dokumentacja techniczna i GDD