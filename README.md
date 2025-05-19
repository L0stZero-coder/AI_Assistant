# 🧠 C# AI Assistant: Voice Control + Automation + Web Search

A powerful C# AI assistant that interacts with users through voice chat, simulates intelligent behavior, and executes real-time system operations. This assistant can control the mouse and keyboard, launch and close applications, respond to voice commands via speech recognition and synthesis, and even perform automated Google searches when encountering unknown topics.

---

## 🔍 Project Overview

This assistant enables a trained AI model to:

- 🖱️ Control your PC (mouse and keyboard simulation)
- 🚀 Launch and close applications
- 🎤 Use real-time voice recognition and speech synthesis
- 🌐 Automatically search Google for unfamiliar commands
- 🗣️ Engage with users through voice chat interaction

---

## ⚠️ Important Warnings

### 1. Admin Privileges Required
- Mouse and keyboard simulation via `keybd_event()` and `mouse_event()` requires **Administrator access**.
- Without elevated permissions, input actions may silently fail.

### 2. Microphone/Audio Input
- Ensure your **microphone is connected and detected** by Windows.
- The assistant uses `System.Speech.Recognition` for live voice input.

### 3. Google Search Dependency
- If the assistant does **not recognize a command**, it performs an **automatic Google Search** by launching the default web browser with the spoken query.
- Requires an **active internet connection** to function properly.

### 4. Security Considerations
- Uses system-level input simulation functions which may be flagged as suspicious by:
  - Antivirus software
  - Windows Defender
- ⚠️ Do **not distribute** this tool without sandboxing or an appropriate disclaimer.

### 5. Context Limitations
- This version does **not include persistent memory** or advanced contextual awareness.
- To enhance reasoning, consider integrating with:
  - GPT-4 / other LLMs
  - Memory modules / semantic buffers

### 6. No VoIP Communication Yet
- Currently supports **TTS (Text-to-Speech)** and **Speech Recognition** only.
- No support yet for voice streaming in **Discord**, **Zoom**, or other VoIP platforms.
- For full audio interaction, you must integrate external VoIP APIs.

---

## 🧰 Technologies Used

- C# (.NET 6 or Framework)
- `System.Speech.Recognition` (Voice Input)
- `System.Speech.Synthesis` (TTS)
- Native Windows API (`mouse_event`, `keybd_event`)
- Process Control (`System.Diagnostics`)
- Google Search via `Process.Start()` and browser redirection

---

## 🚀 Future Enhancements

- 🧠 GPT-4 or LLM Integration for intelligent contextual understanding
- 💾 Memory module for persistent conversations
- 🔊 Discord/VoIP API integration for two-way voice chat
- 🔐 Secure sandbox mode for safe distribution

---

## 📄 License

For educational and experimental purposes only. Use responsibly.

---

## 🙌 Contributions

Contributions, pull requests, and ideas are welcome. Fork the repo and help evolve the assistant!
