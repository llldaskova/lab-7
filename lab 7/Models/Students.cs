using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7.Models
{
    public class Students
    {
        public Students(string Name,string Surname,string Patronymic,string Grade,bool State=false)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.Grade = Grade;
            this.State = State;
        }

        public Avalonia.Media.ISolidColorBrush MyBrush { get; set; }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.All(char.IsLetter))
                    name = value;
                else
                    name= "#ERROR";

            }
        }
        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value.All(char.IsLetter))
                    surname = value;
                else
                    surname = "#ERROR";

            }
        }
        private string patronymic;
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if (value.All(char.IsLetter))
                    patronymic = value;
                else
                    patronymic = "#ERROR";

            }
        }
        private string grade;
        public string Grade
        {
            get
            {
                return grade;
            }
            set
            {
                try
                {
                    double a = double.Parse(value);
                    if (a < 0 || a > 2)
                    {
                        grade = "#ERROR";
                        MyBrush = Brushes.Gray;
                    }
                    else
                    {
                        grade = value;
                        if (a < 1)
                            MyBrush = Brushes.Red;
                        else if (a < 1.5)
                            MyBrush = Brushes.Yellow;
                        else
                            MyBrush = Brushes.Green;
                    }
                }
                catch
                {
                    grade = "#ERROR";
                    MyBrush = Brushes.Gray;
                }
            }
        }
        public bool State { get; set; }
    }
}
