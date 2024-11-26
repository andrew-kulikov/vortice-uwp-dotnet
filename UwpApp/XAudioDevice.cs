using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Vortice.XAudio2;

namespace UwpApp;

internal class XAudioDevice
{
    private IXAudio2 _device;

    static XAudioDevice()
    {
        // Uncomment the following line to preload the library
        //NativeLibrary.TryLoad("xaudio2_9.dll", Assembly.GetExecutingAssembly(), DllImportSearchPath.LegacyBehavior, out var handle);
    }

    public XAudioDevice()
    {
        try
        {
            _device = XAudio2.XAudio2Create();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    public string Ptr => _device?.NativePointer.ToString() ?? "Not loaded";
}
