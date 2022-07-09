using System;
using System.Globalization;
using System.Speech.Synthesis;

namespace TeachAssist.Utils
{
    public class CommonUtils
    {
        public static void Speak(string content, bool randomVoice = false)
        {
            var speechSynthesizer = new SpeechSynthesizer();

            if (randomVoice)
            {
                var voices = speechSynthesizer.GetInstalledVoices(CultureInfo.CurrentCulture);
                var idx = new Random().Next(0, voices.Count);
                var vname = voices[idx].VoiceInfo.Name;
                speechSynthesizer.SelectVoice(vname);
            }

            speechSynthesizer.Volume = 100;
            //speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
            speechSynthesizer.SpeakAsync(content);
        }
    }
}
