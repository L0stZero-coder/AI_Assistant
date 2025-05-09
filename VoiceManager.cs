
using System;
using System.Speech.Synthesis;
using System.Speech.Recognition;

public static class VoiceManager
{
    public static SpeechSynthesizer Synth = new SpeechSynthesizer();
    public static SpeechRecognitionEngine Recognizer = new SpeechRecognitionEngine();

    public static void Init(Action<string> onCommand)
    {
        Recognizer.LoadGrammar(new DictationGrammar());
        Recognizer.SetInputToDefaultAudioDevice();
        Recognizer.SpeechRecognized += (s, e) =>
        {
            string command = e.Result.Text.ToLower();
            Synth.Speak("You said " + command);
            onCommand?.Invoke(command);
        };
        Recognizer.RecognizeAsync(RecognizeMode.Multiple);
    }

    public static void Speak(string message) => Synth.Speak(message);
}
