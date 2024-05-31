using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GetStartedApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object sender, RoutedEventArgs e)
    {
        Debug.WriteLine("Clicked!");
    }
}