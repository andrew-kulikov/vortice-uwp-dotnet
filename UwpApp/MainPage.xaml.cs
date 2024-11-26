using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UwpApp;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void myButton_Click(object sender, RoutedEventArgs e)
    {
        var device = new XAudioDevice();
        myButton.Content = device.Ptr;
    }
}