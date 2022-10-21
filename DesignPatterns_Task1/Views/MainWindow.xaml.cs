using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesignPatterns_Task1.Helper.FileHelper;
using DesignPatterns_Task1.Models;
using DesignPatterns_Task1.ViewModels;
using DesignPatterns_Task1.Views;

namespace DesignPatterns_Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Filename = "products.json";

        public MainWindow()
        {
            InitializeComponent();
            #region Initialilizing
            //var modernFurnitureFactory = new ModernFurnitureFactory();
            //var victorianFurnitureFactory = new VictorianFurnitureFactory();
            //var artDecoFurnitureFactory = new ArtDecoFurnitureFactory();

            //List<IProduct> products = new List<IProduct>();
            //IProduct modern_product1 = modernFurnitureFactory.CreateChair();
            //modern_product1.ImagePath = @"/Images/modernChair1.jpeg";
            //modern_product1.Category = Category.Modern;
            //IProduct modern_product2 = modernFurnitureFactory.CreateChair();
            //modern_product2.ImagePath = @"/Images/modernChair2.jpeg";
            //modern_product2.Category = Category.Modern;
            //IProduct modern_product3 = modernFurnitureFactory.CreateChair();
            //modern_product3.ImagePath = @"/Images/modernChair3.jpeg";
            //modern_product2.Category = Category.Modern;
            //IProduct modern_product4 = modernFurnitureFactory.CreateChair();
            //modern_product4.ImagePath = @"/Images/modernChair4.jpeg";
            //modern_product2.Category = Category.Modern;

            //IProduct modern_product5 = modernFurnitureFactory.CreateTable();
            //modern_product5.ImagePath = @"/Images/modernTable1.jpeg";
            //modern_product5.Category = Category.Modern;
            //IProduct modern_product6 = modernFurnitureFactory.CreateTable();
            //modern_product6.ImagePath = @"/Images/modernTable2.jpeg";
            //modern_product6.Category = Category.Modern;
            //IProduct modern_product7 = modernFurnitureFactory.CreateTable();
            //modern_product7.ImagePath = @"/Images/modernTable3.jpeg";
            //modern_product7.Category = Category.Modern;

            //IProduct modern_product8 = modernFurnitureFactory.CreateSofa();
            //modern_product8.ImagePath = @"/Images/modernSofa1.jpeg";
            //modern_product8.Category = Category.Modern;
            //IProduct modern_product9 = modernFurnitureFactory.CreateSofa();
            //modern_product9.ImagePath = @"/Images/modernSofa2.jpeg";
            //modern_product9.Category = Category.Modern;
            //IProduct modern_product10 = modernFurnitureFactory.CreateSofa();
            //modern_product10.ImagePath = @"/Images/modernSofa3.jpeg";
            //modern_product10.Category = Category.Modern;

            //products.Add(modern_product1);
            //products.Add(modern_product2);
            //products.Add(modern_product3);
            //products.Add(modern_product4);
            //products.Add(modern_product5);
            //products.Add(modern_product6);
            //products.Add(modern_product7);
            //products.Add(modern_product8);
            //products.Add(modern_product9);
            //products.Add(modern_product10);

            //IProduct victorian_product1 = victorianFurnitureFactory.CreateChair();
            //victorian_product1.ImagePath = @"/Images/victorianChair1.jpeg";
            //victorian_product1.Category = Category.Victorian;
            //IProduct victorian_product2 = victorianFurnitureFactory.CreateChair();
            //victorian_product2.ImagePath = @"/Images/victorianChair2.jpeg";
            //victorian_product2.Category = Category.Victorian;
            //IProduct victorian_product3 = victorianFurnitureFactory.CreateChair();
            //victorian_product3.ImagePath = @"/Images/victorianChair3.jpeg";
            //victorian_product3.Category = Category.Victorian;
            //IProduct victorian_product4 = victorianFurnitureFactory.CreateChair();
            //victorian_product4.ImagePath = @"/Images/victorianChair4.jpeg";
            //victorian_product4.Category = Category.Victorian;

            //IProduct victorian_product5 = victorianFurnitureFactory.CreateTable();
            //victorian_product5.ImagePath = @"/Images/victorianTable1.jpeg";
            //victorian_product5.Category = Category.Victorian;
            //IProduct victorian_product6 = victorianFurnitureFactory.CreateTable();
            //victorian_product6.ImagePath = @"/Images/victorianTable2.jpeg";
            //victorian_product6.Category = Category.Victorian;
            //IProduct victorian_product7 = victorianFurnitureFactory.CreateTable();
            //victorian_product7.ImagePath = @"/Images/victorianTable3.jpeg";
            //victorian_product7.Category = Category.Victorian;

            //IProduct victorian_product8 = victorianFurnitureFactory.CreateSofa();
            //victorian_product8.ImagePath = @"/Images/victorianSofa1.jpeg";
            //victorian_product8.Category = Category.Victorian;
            //IProduct victorian_product9 = victorianFurnitureFactory.CreateSofa();
            //victorian_product9.ImagePath = @"/Images/victorianSofa2.jpeg";
            //victorian_product9.Category = Category.Victorian;
            //IProduct victorian_product10 = victorianFurnitureFactory.CreateSofa();
            //victorian_product10.ImagePath = @"/Images/victorianSofa3.jpeg";
            //victorian_product10.Category = Category.Victorian;

            //products.Add(victorian_product1);
            //products.Add(victorian_product2);
            //products.Add(victorian_product3);
            //products.Add(victorian_product4);
            //products.Add(victorian_product5);
            //products.Add(victorian_product6);
            //products.Add(victorian_product7);
            //products.Add(victorian_product8);
            //products.Add(victorian_product9);
            //products.Add(victorian_product10);


            //IProduct artDeco_product1 = artDecoFurnitureFactory.CreateChair();
            //artDeco_product1.ImagePath = @"/Images/artDecoChair1.jpeg";
            //artDeco_product1.Category = Category.ArtDeco;
            //IProduct artDeco_product2 = artDecoFurnitureFactory.CreateChair();
            //artDeco_product2.ImagePath = @"/Images/artDecoChair2.jpeg";
            //artDeco_product2.Category = Category.ArtDeco;
            //IProduct artDeco_product3 = artDecoFurnitureFactory.CreateChair();
            //artDeco_product3.ImagePath = @"/Images/artDecoChair3.jpeg";
            //artDeco_product3.Category = Category.ArtDeco;
            //IProduct artDeco_product4 = artDecoFurnitureFactory.CreateChair();
            //artDeco_product4.ImagePath = @"/Images/artDecoChair4.jpeg";
            //artDeco_product4.Category = Category.ArtDeco;

            //IProduct artDeco_product5 = artDecoFurnitureFactory.CreateTable();
            //artDeco_product5.ImagePath = @"/Images/artDecoTable1.jpeg";
            //artDeco_product5.Category = Category.ArtDeco;
            //IProduct artDeco_product6 = artDecoFurnitureFactory.CreateTable();
            //artDeco_product6.ImagePath = @"/Images/artDecoTable2.jpeg";
            //artDeco_product6.Category = Category.ArtDeco;
            //IProduct artDeco_product7 = artDecoFurnitureFactory.CreateTable();
            //artDeco_product7.ImagePath = @"/Images/artDecoTable3.jpeg";
            //artDeco_product7.Category = Category.ArtDeco;

            //IProduct artDeco_product8 = artDecoFurnitureFactory.CreateSofa();
            //artDeco_product8.ImagePath = @"/Images/artDecoSofa1.jpeg";
            //artDeco_product8.Category = Category.ArtDeco;
            //IProduct artDeco_product9 = artDecoFurnitureFactory.CreateSofa();
            //artDeco_product9.ImagePath = @"/Images/artDecoSofa2.jpeg";
            //artDeco_product9.Category = Category.ArtDeco;
            //IProduct artDeco_product10 = artDecoFurnitureFactory.CreateSofa();
            //artDeco_product10.ImagePath = @"/Images/artDecoSofa3.jpeg";
            //artDeco_product10.Category = Category.ArtDeco;

            //products.Add(artDeco_product1);
            //products.Add(artDeco_product2);
            //products.Add(artDeco_product3);
            //products.Add(artDeco_product4);
            //products.Add(artDeco_product5);
            //products.Add(artDeco_product6);
            //products.Add(artDeco_product7);
            //products.Add(artDeco_product8);
            //products.Add(artDeco_product9);
            //products.Add(artDeco_product10);

            //JsonHelper<IProduct>.Serialize(products, Filename);
            #endregion
            App.Products = JsonHelper<Product>.Deserialize(Filename);
            App.MyGrid = MyGrid;
            var chociesView = new ChoicesUC();
            var choicesViewModel = new ChoicesUCViewModel();
            chociesView.DataContext = choicesViewModel;
            App.MyGrid.Children.Add(chociesView);
        }
    }
}
