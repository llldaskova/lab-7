using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using lab_7.Models;
using Newtonsoft.Json;
using ReactiveUI;
using Avalonia.Media;
namespace lab_7.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Item = new ObservableCollection<Students>();
           
        }
      

        public void MenuLoad(string Path)
        {
            var str = File.ReadAllText(Path);
            if (str != null)
            {
                this.Item = JsonConvert.DeserializeObject<ObservableCollection<Students>>
                (str);
            }
                
        }
        public void MenuSave(string Path)
        {
            if (Item.Count != 0)
                File.WriteAllText(Path, JsonConvert.SerializeObject(Item));
        }
        public void RemoveStudentButton()
        {
            var neededStudents = this.Item.Where(x => x.State).ToList();
            foreach (var neededStudent in neededStudents)
            {
                this.Item.Remove(neededStudent);
            }
        }

        private ObservableCollection<Students> item;
        public ObservableCollection<Students> Item
        {
            get
            {
                return item;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref item, value);
            }
        }
        


    }
}
