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
            ProductDetailsFill pf= new ProductDetailsFill();

            List<ProductGroup> PGroup = pf.ProductGroupFill();
            List<ProductInfo> PInfo = pf.ProductFill();
            IEnumerable<ProductInfo> p = pf.ProductSort(PInfo);

            foreach(ProductGroup prod1 in PGroup)
            {
                foreach(ProductInfo prod2 in p)
                {
                    if(prod1.ProductGroupID==prod2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: "+prod1.ProductGroupName+" || Product Name: "+prod2.ProductName+" || Product Description: "+prod2.ProductDescription+" || Product Rate: "+prod2.ProductRate);
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
            ProductDetailsFill pf= new ProductDetailsFill();

            List<ProductGroup> PGroup = pf.ProductGroupFill();
            List<ProductInfo> PInfo = pf.ProductFill();

            foreach(ProductGroup prod1 in PGroup)
            {
                foreach(ProductInfo prod2 in PInfo)
                {
                    if(prod1.ProductGroupID==prod2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: " +prod1.ProductGroupName+ " || Product Name: " +prod2.ProductName+ " || Product Description: " +prod2.ProductDescription+ " || Product Rate: " +prod2.ProductRate);
                    }
                }
            }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void DisplayTracked(string src)
        {
            if(src==null)
            Console.WriteLine("Please enter a string!");

            else
            {
                try
                {
                ProductDetailsFill pf= new ProductDetailsFill();

                List<ProductGroup> PGroup = pf.ProductGroupFill();
                List<ProductInfo> PInfo = pf.ProductFill();

                var res=PInfo.Where(p =>p.ProductName.ToUpper().Contains(src.ToUpper()));

                foreach(ProductGroup prod1 in PGroup)
                {
                    foreach(ProductInfo prod2 in res)
                    {
                        if(prod1.ProductGroupID==prod2.GroupID)
                        {
                            Console.WriteLine("Product Group Name: " +prod1.ProductGroupName+ " || Product Name: " +prod2.ProductName+ " || Product Description: " +prod2.ProductDescription+ " || Product Rate: " +prod2.ProductRate);
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
            ProductDetailsFill pf= new ProductDetailsFill();

            List<ProductGroup> PGroup = pf.ProductGroupFill();
            List<ProductInfo> PInfo = pf.ProductFill();

            List<ProductInfo> PDel1= pf.ProductDelete1(PInfo);

            foreach(ProductGroup prod1 in PGroup)
            {
                foreach(ProductInfo prod2 in PDel1)
                {
                    if(prod1.ProductGroupID==prod2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: " +prod1.ProductGroupName+ " || Product Name: " +prod2.ProductName+ " || Product Description: " +prod2.ProductDescription+ " || Product Rate: " +prod2.ProductRate);
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
            ProductDetailsFill pf= new ProductDetailsFill();

            List<ProductGroup> PGroup = pf.ProductGroupFill();
            List<ProductInfo> PInfo = pf.ProductFill();

            List<ProductInfo> PDel2= pf.ProductDelete2(PInfo, num);

            foreach(ProductGroup prod1 in PGroup)
            {
                foreach(ProductInfo prod2 in PDel2)
                {
                    if(prod1.ProductGroupID==prod2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: " +prod1.ProductGroupName+ " || Product Name: " +prod2.ProductName+ " || Product Description: " +prod2.ProductDescription+ " || Product Rate: " +prod2.ProductRate);
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
            ProductDetailsFill pf= new ProductDetailsFill();

            List<ProductGroup> PGroup = pf.ProductGroupFill();
            List<ProductInfo> PInfo = pf.ProductFill();

            List<ProductInfo> PDel3= pf.ProductDelete3(PInfo, num1, num2);

            foreach(ProductGroup prod1 in PGroup)
            {
                foreach(ProductInfo prod2 in PDel3)
                {
                    if(prod1.ProductGroupID==prod2.GroupID)
                    {
                        Console.WriteLine("Product Group Name: " +prod1.ProductGroupName+ " || Product Name: " +prod2.ProductName+ " || Product Description: " +prod2.ProductDescription+ " || Product Rate: " +prod2.ProductRate);
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