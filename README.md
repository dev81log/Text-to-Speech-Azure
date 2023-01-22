![Asher_Duarte_Microsoft CognitiveServices Speech_182ed9d7-987d-4044-8cf1-5deab11cbbe9 (1)](https://user-images.githubusercontent.com/105469529/213919709-07f17e87-c0f9-48df-a366-3a3934e13a16.png)
# Speech Synthesis Example
This is an example of how to use the Microsoft Cognitive Services Speech library for speech synthesis.
The application accepts text input and then uses the Text-to-Speech API to generate an audio file that is saved to a specified location.

## Getting Started
1. Replace `YourSubscriptionKey` and `YourServiceRegion` with your own subscription key and service region values.
2. Replace `"file.wav"` in `AudioConfig.FromWavFileOutput("file.wav")` with the desired file output format and directory save path.
3. Replace `"string that you want to speak"` with the text you want to be spoken.
4. Replace `pt-BR-FranciscaNeural` with the language of the voice you want to use.

### Note
Make sure you have the [Microsoft.CognitiveServices.Speech package](https://www.nuget.org/packages/Microsoft.CognitiveServices.Speech)  installed.

### Output
The program will output the synthesized speech and save the audio to the specified file path.
