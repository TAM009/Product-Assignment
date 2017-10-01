using System;
using System.Collections.Generic;
using System.Linq;
using ProductInterface;

namespace Product
{
    public class ProductDetailsFill: IProduct, IComparer<ProductInfo>
    {
        public List<ProductGroup> ProductGroupFill()
        {
            ProductGroup pg1 = new ProductGroup()
           {
               ProductGroupID = 1,
               ProductGroupName = "Dairy"
           };

           ProductGroup pg2 = new ProductGroup()
           {
               ProductGroupID = 2,
               ProductGroupName = "Chocolate"
           };

           ProductGroup pg3 = new ProductGroup()
           {
               ProductGroupID = 3,
               ProductGroupName = "FruitJuice"
           };

           ProductGroup pg4 = new ProductGroup()
           {
               ProductGroupID = 4,
               ProductGroupName = "Cakes"
           };

           List<ProductGroup> PGroup1= new List<ProductGroup>();
           PGroup1.Add(pg1);
           PGroup1.Add(pg2);
           PGroup1.Add(pg3);
           PGroup1.Add(pg4);

           return PGroup1;

        }


        public List<ProductInfo> ProductFill()
        {
            ProductInfo pi1=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Dairy"),
                ProductID=1,
                ProductName="Go Cheese",
                ProductDescription="Go Cheese 180g",
                ProductRate=115,
            };

            ProductInfo pi2=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Dairy"),
                ProductID=2,
                ProductName="Amul Cheese",
                ProductDescription="Amul Cheese 210g",
                ProductRate=125,
            };


            ProductInfo pi3=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Dairy"),
                ProductID=3,
                ProductName="Britannia Cheese",
                ProductDescription="Brittania Cheese 180g",
                ProductRate=130,
            };


            ProductInfo pi4=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Chocolate"),
                ProductID=4,
                ProductName="Nestle bar",
                ProductDescription="Nestle bar 180g",
                ProductRate=120,
            };


            ProductInfo pi5=new ProductInfo()
            {
                GroupID=FindGroup.FindID("FruitJuice"),
                ProductID=5,
                ProductName="Straw Joy",
                ProductDescription="Straw Joy 180g",
                ProductRate=150,
            };


            ProductInfo pi6=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Cakes"),
                ProductID=6,
                ProductName="Anmol Cakes",
                ProductDescription="Anmol Cakes 130g",
                ProductRate=70,
            };


            ProductInfo pi7=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Chocolate"),
                ProductID=7,
                ProductName="Cadbury Silk",
                ProductDescription="Cadbury Silk 150g",
                ProductRate=90,
            };

            ProductInfo pi8=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Cakes"),
                ProductID=7,
                ProductName="Cadbury Milan",
                ProductDescription="Cadbury Milan 250g",
                ProductRate=120,
            }; 

            ProductInfo pi9=new ProductInfo()
            {
                GroupID=FindGroup.FindID("FruitJuice"),
                ProductID=7,
                ProductName="Real Mango",
                ProductDescription="Real Mango 250g",
                ProductRate=130,
            };

            List<ProductInfo> PInfo1=new List<ProductInfo>();
            PInfo1.Add(pi1);
            PInfo1.Add(pi2);
            PInfo1.Add(pi3);
            PInfo1.Add(pi4);
            PInfo1.Add(pi5);
            PInfo1.Add(pi6);
            PInfo1.Add(pi7);
            PInfo1.Add(pi8);
            PInfo1.Add(pi9);

            return PInfo1;

        }

        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.ProductName.CompareTo(y.ProductName);
        }

        public  IEnumerable<ProductInfo> ProductSort(List<ProductInfo> PInfo)
        {
            ProductDetailsFill P = new ProductDetailsFill();
            PInfo.Sort(P);
            return PInfo;
        }

        public List<ProductInfo> ProductDelete2(List<ProductInfo> PInfo, int num)
        {    
            PInfo.RemoveAt(num);
            return PInfo;
        } 

         public List<ProductInfo> ProductDelete1(List<ProductInfo> PInfo)
         {
             PInfo.RemoveAll( prod => prod.ProductRate>100);
             return PInfo;
         }
         
         public List<ProductInfo> ProductDelete3(List<ProductInfo> PInfo,int start, int end)
         {
             PInfo.RemoveRange(start, end);
             return PInfo;
         }
                           

    }
}