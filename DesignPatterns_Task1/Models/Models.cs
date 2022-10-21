using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Task1.Models
{
    public enum Category
    {
        Modern,
        Victorian,
        ArtDeco
    }

    public interface IProduct
    {
        string ImagePath { get; set; }
        Category Category { get; set; }
    }

    // Interaceleri json filedan deserialize etmek olmadigi ucun base product classi
    public class Product : IProduct
    {
        public string ImagePath { get; set; }
        public Category Category { get; set; }
    }

    public interface IChair : IProduct
    {
        bool HasLegs();
        bool SitOn();
    }

    public class ArtDecoChair : Product, IChair
    {
        public bool HasLegs()
        {
            return true;
        }
        public bool SitOn()
        {
            return true;
        }
    }


    public class ModernChair : Product, IChair
    {
        public bool HasLegs()
        {
            return false;
        }

        public bool SitOn()
        {
            return true;
        }
    }


    public class VictorianChair : Product, IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public bool SitOn()
        {
            return true;
        }
    }

    public interface ITable : IProduct
    {
        bool CanOpen();
        bool CanRotate();
    }


    public class ArtDecoTable : Product, ITable
    {
        public bool CanOpen()
        {
            return true;
        }

        public bool CanRotate()
        {
            return true;
        }
    }


    public class ModernTable : Product, ITable
    {
        public bool CanOpen()
        {
            return false;
        }

        public bool CanRotate()
        {
            return true;
        }
    }

    public class VictorianTable : Product, ITable
    {
        public bool CanOpen()
        {
            return false;
        }

        public bool CanRotate()
        {
            return false;
        }
    }

    public interface ISofa : IProduct
    {
        bool CanEnlarge();
    }

    public class ArtDecoSofa : Product, ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }
    }

    public class ModernSofa : Product, ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }
    }


    public class VictorianSofa : Product, ISofa
    {
        public bool CanEnlarge()
        {
            return false;
        }
    }

    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
        ISofa CreateSofa();
        List<IProduct> GetFurnitures();
    }

    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }

        public List<IProduct> GetFurnitures()
        { 
            return StaticHelpers.GetFurnituresByCategory(Category.Modern);;
        }
    }



    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }

        public List<IProduct> GetFurnitures()
        {
            return StaticHelpers.GetFurnituresByCategory(Category.Victorian);
        }
    }


    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public ITable CreateTable()
        {
            return new ArtDecoTable();
        }

        public List<IProduct> GetFurnitures()
        {
            return StaticHelpers.GetFurnituresByCategory(Category.ArtDeco);
        }
    }

    public class StaticHelpers
    {
        public static List<IProduct> GetFurnituresByCategory(Category category)
        {
            var list = new List<IProduct>();
            if (App.Products != null)
            {
                foreach (var product in App.Products)
                {
                    if (product.Category == category)
                    {
                        list.Add(product);
                    }
                }
            }
            return list;
        }
    }
}
