using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace lab_7.Views
{
    public partial class ErrorView : Window
    {
        public ErrorView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
