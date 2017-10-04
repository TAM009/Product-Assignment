using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class Display
    {
        
        public void DisplaySortProd()
        {
            try
            {
            ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

            List<ProductGroup> PGroup = objProductDetailsFill.ProductGroupFill();
            List<ProductInfo> PInfo = objProductDetailsFill.ProductFill();
            IEnumerable<ProductInfo> EnumProductInfo = objProductDetailsFill.ProductSort(PInfo);

            foreach(ProductGroup product1 in PGroup)
            {
                foreach(ProductInfo product2 in EnumProductInfo)
                {
                    if(product1.ProductGroupID==product2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: "+product1.ProductGroupName+" || Product Name: "+product2.ProductName+" || Product Description: "+product2.ProductDescription+" || Product Rate: "+product2.ProductRate);
                    }
                }
            }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void DisplayAllItems()
        {
            try
            {
            ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

            List<ProductGroup> PGroup = objProductDetailsFill.ProductGroupFill();
            List<ProductInfo> PInfo = objProductDetailsFill.ProductFill();

            foreach(ProductGroup product1 in PGroup)
            {
                foreach(ProductInfo product2 in PInfo)
                {
                    if(product1.ProductGroupID==product2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: " +product1.ProductGroupName+ " || Product Name: " +product2.ProductName+ " || Product Description: " +product2.ProductDescription+ " || Product Rate: " +product2.ProductRate);
                    }
                }
            }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void DisplayTracked(string search)
        {
            if(search==null)
            Console.WriteLine("Please enter a string!");

            else
            {
                try
                {
                ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

                List<ProductGroup> PGroup = objProductDetailsFill.ProductGroupFill();
                List<ProductInfo> PInfo = objProductDetailsFill.ProductFill();

                var res=PInfo.Where(p =>p.ProductName.ToUpper().Contains(search.ToUpper()));

                foreach(ProductGroup product1 in PGroup)
                {
                    foreach(ProductInfo product2 in res)
                    {
                        if(product1.ProductGroupID==product2.GroupID)
                        {
                            Console.WriteLine("Product Group Name: " +product1.ProductGroupName+ " || Product Name: " +product2.ProductName+ " || Product Description: " +product2.ProductDescription+ " || Product Rate: " +product2.ProductRate);
                        }
                    }
                }

                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }

        public void DisplayAfterDeletion1()
        {
            try
            {
            ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

            List<ProductGroup> PGroup = objProductDetailsFill.ProductGroupFill();
            List<ProductInfo> PInfo = objProductDetailsFill.ProductFill();

            List<ProductInfo> PDel1= objProductDetailsFill.ProductDelete1(PInfo);

            foreach(ProductGroup product1 in PGroup)
            {
                foreach(ProductInfo product2 in PDel1)
                {
                    if(product1.ProductGroupID==product2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: " +product1.ProductGroupName+ " || Product Name: " +product2.ProductName+ " || Product Description: " +product2.ProductDescription+ " || Product Rate: " +product2.ProductRate);
                    }
                }
            }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void DisplayAfterDeletion2(int num)
        {
            try
            {
            ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

            List<ProductGroup> PGroup = objProductDetailsFill.ProductGroupFill();
            List<ProductInfo> PInfo = objProductDetailsFill.ProductFill();

            List<ProductInfo> PDel2= objProductDetailsFill.ProductDelete2(PInfo, num);

            foreach(ProductGroup product1 in PGroup)
            {
                foreach(ProductInfo product2 in PDel2)
                {
                    if(product1.ProductGroupID==product2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: " +product1.ProductGroupName+ " || Product Name: " +product2.ProductName+ " || Product Description: " +product2.ProductDescription+ " || Product Rate: " +product2.ProductRate);
                    }
                }
            }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

         public void DisplayAfterDeletion3(int num1,int num2)
        {
            try
            {
            ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

            List<ProductGroup> PGroup = objProductDetailsFill.ProductGroupFill();
            List<ProductInfo> PInfo = objProductDetailsFill.ProductFill();

            List<ProductInfo> PDel3= objProductDetailsFill.ProductDelete3(PInfo, num1, num2);

            foreach(ProductGroup product1 in PGroup)
            {
                foreach(ProductInfo product2 in PDel3)
                {
                    if(product1.ProductGroupID==product2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: " +product1.ProductGroupName+ " || Product Name: " +product2.ProductName+ " || Product Description: " +product2.ProductDescription+ " || Product Rate: " +product2.ProductRate);
                    }
                }
            }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}