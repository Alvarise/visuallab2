using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks.Dataflow;


namespace AvaloniaApplication2;

public partial class MainWindow : Window
{
    public void ClickHandler(object sender, RoutedEventArgs args)
    {
        var colbutton = sender as Button;
        if (MainBlock != null && colbutton != null)
        {
            MainBlock.Fill = colbutton.Background;
        }
    }
    public MainWindow()
    {
        InitializeComponent();
    }
}