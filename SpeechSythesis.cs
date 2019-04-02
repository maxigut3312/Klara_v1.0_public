using System.Speech.Synthesis;

namespace Main
{
    class SpeechSynthesis
    {
        public static void synthesize(string text)
        {
            string selectedVoice = "Microsoft Zira Desktop";
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.SelectVoice(selectedVoice);
            synthesizer.Speak(text);
        }
    }
}
