# Speech Synthesis Example
This is an example of how to use the Microsoft Cognitive Services Speech library for speech synthesis.
The application accepts text input and then uses the Text-to-Speech API to generate an audio file that is saved to a specified location.

## Getting Started
Replace YourSubscriptionKey and YourServiceRegion with your own subscription key and service region values.
Replace "file.wav" in AudioConfig.FromWavFileOutput("file.wav") with the desired file output format and directory save path.
Replace "string that you want to speak" with the text you want to be spoken.
Replace pt-BR-FranciscaNeural with the language of the voice you want to use.

### Note
Make sure you have the Microsoft.CognitiveServices.Speech package https://www.nuget.org/packages/Microsoft.CognitiveServices.Speech installed.

### Output
The program will output the synthesized speech and save the audio to the specified file path.
