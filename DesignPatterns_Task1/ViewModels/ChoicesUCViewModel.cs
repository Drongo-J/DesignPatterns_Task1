using DesignPatterns_Task1.Commands;
using DesignPatterns_Task1.Models;
using DesignPatterns_Task1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Task1.ViewModels
{
    public class ChoicesUCViewModel : BaseViewModel
    {
        public RelayCommand VictorianCommand { get; set; }
        public RelayCommand ModernCommand { get; set; }
        public RelayCommand ArtDecoCommand { get; set; }

        public ChoicesUCViewModel()
        {
            var furnituresView = new FurnituresUC();
            var furnituresViewModel = new FurnituresUCViewModel();
            furnituresView.DataContext = furnituresViewModel;

            VictorianCommand = new RelayCommand((v) =>
             {
                 App.MyGrid.Children.Clear();
                 var furnitures = App.VictorianFurnitureFactory.GetFurnitures();
                 AddFurnitureeCells(furnitures, furnituresView);
             });

            ModernCommand = new RelayCommand((v) =>
            {
                App.MyGrid.Children.Clear();
                var furnitures = App.ModernFurnitureFactory.GetFurnitures();
                AddFurnitureeCells(furnitures, furnituresView);
            });

            ArtDecoCommand = new RelayCommand((v) =>
            {
                App.MyGrid.Children.Clear();
                var furnitures = App.ArtDecoFurnitureFactory.GetFurnitures();
                AddFurnitureeCells(furnitures, furnituresView);
            });
        }

        public static void AddFurnitureeCells(List<IProduct> furnitures, FurnituresUC furnituresView)
        {
            foreach (var item in furnitures)
            {
                var furnitureCellView = new FurnitureCell();
                var furnitureCellViewModel = new FurnitureCellUCViewModel();
                furnitureCellView.DataContext = furnitureCellViewModel;
                furnitureCellViewModel.ImageSource = item.ImagePath;
                furnitureCellViewModel.Text = item.Category.ToString();
                furnituresView.Furnitures.Children.Add(furnitureCellView);
            }
            App.MyGrid.Children.Add(furnituresView);
        }
    }
}
