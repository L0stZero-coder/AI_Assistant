
using System;
using System.Diagnostics;

public static class CommandHandler
{
    public static void Handle(string cmd)
    {
        if (cmd.Contains("open notepad"))
            InputController.LaunchApp("notepad.exe");
        else if (cmd.Contains("close notepad"))
            InputController.KillApp("notepad");
        else if (cmd.Contains("move mouse"))
            InputController.MoveMouse(800, 400);
        else if (cmd.Contains("click"))
            InputController.LeftClick();
        else if (cmd.Contains("type"))
            InputController.TypeText(cmd.Replace("type", "").Trim());
        else if (cmd.StartsWith("search") || cmd.Contains("what is") || cmd.Contains("who is") || cmd.Contains("how to"))
        {
            string query = Uri.EscapeDataString(cmd.Replace("search", "").Trim());
            Process.Start("cmd", $"/c start https://www.google.com/search?q={query}");
            VoiceManager.Speak("Searching Google.");
        }
        else
        {
            VoiceManager.Speak("I don't know that. Let me search it.");
            string fallback = Uri.EscapeDataString(cmd);
            Process.Start("cmd", $"/c start https://www.google.com/search?q={fallback}");
        }
    }
}
