A powerful C# AI assistant that can control mouse and keyboard, launch and close applications, respond to voice commands using speech recognition and synthesis, and automatically search Google when it encounters unknown topics. Designed to interact with users through voice chat and execute real-time system operations, this assistant simulates intelligent desktop behavior with automation and communication capabilities.


-> Project Overview: C# AI Assistant with Mouse/Keyboard Control + Voice Chat + Google Search
This assistant allows a trained AI model to:

Control your PC (mouse/keyboard)

Launch/close apps

Speak and listen using voice synthesis/recognition

Automatically search Google for unknown topics

Interact with users via voice chat


⚠️ Important Warnings
1. Admin Privileges
Controlling mouse/keyboard at a system level requires Administrator access.

Without admin mode, input simulation may silently fail.

2. Microphone/Audio Access
This application uses real-time voice commands.

Ensure your microphone is plugged in and recognized by Windows.

3. Web Search Dependency
When AI doesn’t understand a command, it automatically opens Google Search.

This launches your default browser with a search query based on what was said.
If no internet connection is available, this fallback will fail.

4. Security Considerations
The system uses keybd_event() and mouse_event(), which may be flagged by antivirus software or Windows Defender as suspicious (since they resemble automation tools).

Never distribute this tool without proper sandboxing or disclaimers.

5. Limited Context Awareness
This version doesn’t support persistent memory or contextual threading.

You can integrate it with GPT-4, LLM APIs, or memory buffers for better reasoning.

6. No Direct Audio Chat with Other People Yet
This version uses Text-to-Speech and Speech Recognition, but does not yet support streaming voice conversations over Discord/Zoom/etc.

To enable full voice communication, you’ll need to integrate with VoIP APIs or bots.

