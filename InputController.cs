
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

public static class InputController
{
    [DllImport("user32.dll")] static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
    [DllImport("user32.dll")] static extern bool SetCursorPos(int X, int Y);
    [DllImport("user32.dll")] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
    [DllImport("user32.dll")] private static extern short VkKeyScan(char ch);

    private const uint LEFTDOWN = 0x02, LEFTUP = 0x04;
    private const int KEYDOWN = 0x0000, KEYUP = 0x0002;

    public static void MoveMouse(int x, int y) => SetCursorPos(x, y);

    public static void LeftClick()
    {
        mouse_event(LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(50);
        mouse_event(LEFTUP, 0, 0, 0, 0);
    }

    public static void TypeText(string text)
    {
        foreach (char c in text)
        {
            short keyCode = VkKeyScan(c);
            byte vk = (byte)(keyCode & 0xff);
            keybd_event(vk, 0, KEYDOWN, 0);
            keybd_event(vk, 0, KEYUP, 0);
            Thread.Sleep(50);
        }
    }

    public static void LaunchApp(string path)
    {
        try { Process.Start(path); } catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
    }

    public static void KillApp(string name)
    {
        foreach (var p in Process.GetProcessesByName(name)) p.Kill();
    }
}
