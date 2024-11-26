using Microsoft.UI.Xaml;
using UwpApp;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3App;

/// <summary>
///     An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void myButton_Click(object sender, RoutedEventArgs e)
    {
        var device = new XAudioDevice();
        myButton.Content = device.Ptr;
    }
}
