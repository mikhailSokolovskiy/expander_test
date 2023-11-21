using System.Threading;
using Avalonia.Controls;
using Avalonia.Input;
using ReactiveUI;

namespace expander_test.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void InputElement_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        Thread.Sleep(200);
        TextBlock tb = sender as TextBlock;
        Block.Text = tb.Text;
    }

   
}