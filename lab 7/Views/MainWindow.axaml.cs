using Avalonia.Controls;
using Avalonia.Interactivity;
using lab_7.ViewModels;
using System.Reactive;
using Avalonia.Media;
namespace lab_7.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
               


        }


        private async void MenuSaveClick(object sender, RoutedEventArgs e)
        {
            var taskPath = new OpenFileDialog()
            {
                Title = "Open file",
                Filters = null
            }.ShowAsync((Window)this.VisualRoot);
            string[]? path = await taskPath;
            
            try
            {
                var context = this.DataContext as MainWindowViewModel;
                string Path = string.Join(@"\", path);
                context.MenuSave(Path);
            }
            catch
            {
                await new ErrorView().ShowDialog<Unit>((Window)this.VisualRoot);
            }
        
    }
        private async void  MenuLoadClick(object sender, RoutedEventArgs e)
        {
            var taskPath = new OpenFileDialog()
            {
                Title = "Open file",
                Filters = null
            }.ShowAsync((Window)this.VisualRoot);
            string[]? path = await taskPath;
            
            try
            {
                var context = this.DataContext as MainWindowViewModel;
                string Path = string.Join(@"\", path);
                context.MenuLoad(Path);
                }
            catch
            {
                await new ErrorView().ShowDialog<Unit>((Window)this.VisualRoot);
            }
        }

        private  void MenuExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void AddStudentButton(object sender, RoutedEventArgs e)
        {
            string?[] str = await new AddStudentView().ShowDialog<string?[]>((Window)this.VisualRoot);
            if (str != null)
            {
                var contextMain = this.DataContext as MainWindowViewModel;
                contextMain.Item.Add(new Models.Students(str[1], str[0], str[2], str[3]));
            }
        }

        private async void MenuAboutClick(object sender, RoutedEventArgs e)
        {
            await new AboutView().ShowDialog<Unit>((Window)this.VisualRoot);
           
        }

    }
}
