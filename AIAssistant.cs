
using System;

public static class AIAssistant
{
    public static void Main(string[] args)
    {
        VoiceManager.Speak("Hello, I am your AI assistant. Listening now.");
        VoiceManager.Init(CommandHandler.Handle);
    }
}
