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
            ProductGroup objProductGroup1 = new ProductGroup()
           {
               ProductGroupID = 1,
               ProductGroupName = "Dairy"
           };

           ProductGroup objProductGroup2 = new ProductGroup()
           {
               ProductGroupID = 2,
               ProductGroupName = "Chocolate"
           };

           ProductGroup objProductGroup3 = new ProductGroup()
           {
               ProductGroupID = 3,
               ProductGroupName = "FruitJuice"
           };

           ProductGroup objProductGroup4 = new ProductGroup()
           {
               ProductGroupID = 4,
               ProductGroupName = "Cakes"
           };

           List<ProductGroup> ProductGroup1= new List<ProductGroup>();
           ProductGroup1.Add(objProductGroup1);
           ProductGroup1.Add(objProductGroup2);
           ProductGroup1.Add(objProductGroup3);
           ProductGroup1.Add(objProductGroup4);

           return ProductGroup1;

        }


        public List<ProductInfo> ProductFill()
        {
            ProductInfo objProductInfo1=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Dairy"),
                ProductID=1,
                ProductName="Go Cheese",
                ProductDescription="Go Cheese 180g",
                ProductRate=115,
            };

            ProductInfo objProductInfo2=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Dairy"),
                ProductID=2,
                ProductName="Amul Cheese",
                ProductDescription="Amul Cheese 210g",
                ProductRate=125,
            };


            ProductInfo objProductInfo3=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Dairy"),
                ProductID=3,
                ProductName="Britannia Cheese",
                ProductDescription="Brittania Cheese 180g",
                ProductRate=130,
            };


            ProductInfo objProductInfo4=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Chocolate"),
                ProductID=4,
                ProductName="Nestle bar",
                ProductDescription="Nestle bar 180g",
                ProductRate=120,
            };


            ProductInfo objProductInfo5=new ProductInfo()
            {
                GroupID=FindGroup.FindID("FruitJuice"),
                ProductID=5,
                ProductName="Straw Joy",
                ProductDescription="Straw Joy 180g",
                ProductRate=150,
            };


            ProductInfo objProductInfo6=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Cakes"),
                ProductID=6,
                ProductName="Anmol Cakes",
                ProductDescription="Anmol Cakes 130g",
                ProductRate=70,
            };


            ProductInfo objProductInfo7=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Chocolate"),
                ProductID=7,
                ProductName="Cadbury Silk",
                ProductDescription="Cadbury Silk 150g",
                ProductRate=90,
            };

            ProductInfo objProductInfo8=new ProductInfo()
            {
                GroupID=FindGroup.FindID("Cakes"),
                ProductID=7,
                ProductName="Cadbury Milan",
                ProductDescription="Cadbury Milan 250g",
                ProductRate=120,
            }; 

            ProductInfo objProductInfo9=new ProductInfo()
            {
                GroupID=FindGroup.FindID("FruitJuice"),
                ProductID=7,
                ProductName="Real Mango",
                ProductDescription="Real Mango 250g",
                ProductRate=130,
            };

            List<ProductInfo> ProductInfo1=new List<ProductInfo>();
            ProductInfo1.Add(objProductInfo1);
            ProductInfo1.Add(objProductInfo2);
            ProductInfo1.Add(objProductInfo3);
            ProductInfo1.Add(objProductInfo4);
            ProductInfo1.Add(objProductInfo5);
            ProductInfo1.Add(objProductInfo6);
            ProductInfo1.Add(objProductInfo7);
            ProductInfo1.Add(objProductInfo8);
            ProductInfo1.Add(objProductInfo9);

            return ProductInfo1;

        }

        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.ProductName.CompareTo(y.ProductName);
        }

        public IEnumerable<ProductInfo> ProductSort(List<ProductInfo> ProductInfo)
        {
            ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();
            ProductInfo.Sort(objProductDetailsFill);
            return ProductInfo;
        }

        public List<ProductInfo> ProductDelete1(List<ProductInfo> ProductInfo)
        {
            ProductInfo.RemoveAll( product => product.ProductRate>100);
            return ProductInfo;
        }

        public List<ProductInfo> ProductDelete2(List<ProductInfo> ProductInfo, int num)
        {    
            ProductInfo.RemoveAt(num);
            return ProductInfo;
        } 

        
        public List<ProductInfo> ProductDelete3(List<ProductInfo> ProductInfo,int start, int end)
        {
            ProductInfo.RemoveRange(start, end);
            return ProductInfo;
        }
                           
    }
}