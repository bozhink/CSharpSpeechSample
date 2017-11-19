namespace SpeechConsoleApp
{
    using System.Speech.Synthesis;

    internal class Program
    {
        private static void Main()
        {
            var synth = new SpeechSynthesizer();
            synth.Speak("This example speaks the text in a string.");
        }
    }
}
