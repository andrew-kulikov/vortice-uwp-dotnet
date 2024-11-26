using Vortice.XAudio2;

var device = XAudio2.XAudio2Create();

Console.WriteLine(device.NativePointer);
