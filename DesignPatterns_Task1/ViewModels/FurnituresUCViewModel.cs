using DesignPatterns_Task1.Commands;
using DesignPatterns_Task1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Task1.ViewModels
{
    public class FurnituresUCViewModel : BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

        public FurnituresUCViewModel()
        {
            BackCommand = new RelayCommand((b) => 
            {
                App.MyGrid.Children.Clear();
                var chociesView = new ChoicesUC();
                var choicesViewModel = new ChoicesUCViewModel();
                chociesView.DataContext = choicesViewModel;
                App.MyGrid.Children.Add(chociesView);
            });
        }
    }
}
