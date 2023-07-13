using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

class Program
{
    static string YourSubscriptionKey = "Token"; // your subscription key
    static string YourServiceRegion = "Region";  // your service region

    static void OutputSpeechSynthesisResult(SpeechSynthesisResult speechSynthesisResult, string text)
    {
        switch (speechSynthesisResult.Reason)
        {
            case ResultReason.SynthesizingAudioCompleted:
                Console.WriteLine($"Speech synthesized for text: [{text}]");
                break;
            case ResultReason.Canceled:
                var cancellation = SpeechSynthesisCancellationDetails.FromResult(speechSynthesisResult);
                Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");

                if (cancellation.Reason == CancellationReason.Error)
                {
                    Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                    Console.WriteLine($"CANCELED: ErrorDetails=[{cancellation.ErrorDetails}]");
                    Console.WriteLine($"CANCELED: Did you set the speech resource key and region values?");
                }
                break;
            default:
                break;
        }
    }

    async static Task Main(string[] args)
    {
        var speechConfig = SpeechConfig.FromSubscription(YourSubscriptionKey, YourServiceRegion);

        using var audioConfig = AudioConfig.FromWavFileOutput("file.wav"); // file output format and directory save path


        // The language of the voice that speaks.
        speechConfig.SpeechSynthesisVoiceName = "pt-BR-FranciscaNeural"; // changing the language of the voice

        using (var speechSynthesizer = new SpeechSynthesizer(speechConfig, audioConfig)) // new speechSynthesizer instance with too exit format audio directory
        {
            // Get text from the console and synthesize to the default speaker.
            Console.WriteLine("Enter some text that you want to speak >");
            string text = "string that you want to speak";

            var speechSynthesisResult = await speechSynthesizer.SpeakTextAsync(text);
            OutputSpeechSynthesisResult(speechSynthesisResult, text);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        // verify is
    }
}
