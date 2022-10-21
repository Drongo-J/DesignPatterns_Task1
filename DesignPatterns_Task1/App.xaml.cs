using DesignPatterns_Task1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DesignPatterns_Task1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<Product> Products { get; set; }
        public static ModernFurnitureFactory ModernFurnitureFactory { get; set; } = new ModernFurnitureFactory();
        public static VictorianFurnitureFactory VictorianFurnitureFactory { get; set; } = new VictorianFurnitureFactory();
        public static ArtDecoFurnitureFactory ArtDecoFurnitureFactory { get; set; } = new ArtDecoFurnitureFactory();
        public static Grid MyGrid { get; internal set; }
    }
}
