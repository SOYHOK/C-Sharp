//Not correct yet
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
class TVBrand
    {
        protected string strBrandName;
        private float fltPrice;
        public TVBrand(string strBrandName, float fltPrice)
        {
            this.strBrandName = strBrandName;
            this.fltPrice = fltPrice;
        }
        public float Price
        {
            get { return fltPrice; }
        }
        public virtual string GetInfo()
        {
            return "TV brand: " + strBrandName + "Price: " + fltPrice;
        }
    } 

    class TVType : TVBrand
    {
        private string strType;
        public TVType(string Type, string BrandName, float Price): base(BrandName, Price)
        {
            this.strType = Type;
        }
        public override string GetInfo()
        {
            return " TV brand: " + strBrandName + " Type: " + strType + "Price: " + Price;
        }
        public string GetFinalPrice(string isMember)
        {
            if (isMember == "Y")
                return " "
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TVType Obj1, Obj2;
            Console.Write("Enter TV brand #1: ");
            string Brand = Console.ReadLine();
            Console.Write("Enter Type #1: ")
            string Type = Console.ReadLine();
            Console.Write("Enter price of TV #1: ");
            float price = float.Parse(Console.ReadLine());
            Obj1 = new TVType(Brand, Type, Price);

            Console.Write("Enter TV brand #1: ");
            Brand = Console.ReadLine();
            Console.Write("Enter Type #1: ")
            Type = Console.ReadLine();
            Console.Write("Enter price of TV #1: ");
            price = float.Parse(Console.ReadLine());
            Obj2 = new TVType(Brand, Type, Price);

            Console.WriteLine("SHOPPING CART: {0}", Obj1.GetInfo());
            Console.WriteLine("SHOPPING CART: {0}", Obj2.GetInfo());
        }
    }
}
