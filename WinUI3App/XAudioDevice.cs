using System;
using System.Diagnostics;
using Vortice.XAudio2;

namespace UwpApp;

internal class XAudioDevice
{
    private readonly IXAudio2 _device;

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
