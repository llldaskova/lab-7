using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace lab_7.Views
{
    public partial class AddStudentView : Window
    {
        public AddStudentView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("OK").Click += delegate
            {
               
                var surnameBox = this.FindControl<TextBox>("SurnameBox");
                var nameBox = this.FindControl<TextBox>("NameBox");
                var patronymicBox = this.FindControl<TextBox>("PatronymicBox");
                var gradeBox = this.FindControl<TextBox>("GradeBox");
                string?[] str = new string[] { surnameBox.Text, nameBox.Text, patronymicBox.Text, gradeBox.Text};
                for(int i=0; i<str.Length;i++)
                {
                    if(string.IsNullOrWhiteSpace(str[i]))
                    {
                        Close();
                    }
                }
                Close(str);
            };
            this.FindControl<Button>("Cancel").Click += delegate
            {
                Close();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
