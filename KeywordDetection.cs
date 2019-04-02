using System;
using System.Speech.Recognition;

namespace Main
{
    class KeywordDetection
    {
        public void Start()
        {
            Console.WriteLine("Waiting for Keyword 'Klara'");
            SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
            Choices commands = new Choices();
            commands.Add(new string[] { "Klara" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            while (true)
            {
                recEngine.Recognize();
            }
        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Klara":
                    Luis.HearIntent();
                    break;
            }
        }
    }
}



