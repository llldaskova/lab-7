using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using Newtonsoft.Json;
namespace lab_7.ViewModels
{
    public class AddStudentViewModel : ViewModelBase
    {
        private string name;
        public string NameText
        {
            get
            {
                return name;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref name, value);
            }
        }

        private string surname;
        public string SurnameText
        {
            get
            {
                return surname;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref surname, value);
            }
        }

        private string patronymic;
        public string PatronymicText
        {
            get
            {
                return patronymic;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref patronymic, value);
            }
        }

        private string grade;
        public string GradeText
        {
            get
            {
                return grade;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref grade, value);
            }
        }
    }
}
