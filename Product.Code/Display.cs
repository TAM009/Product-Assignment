using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class Display
    {
        
        public void DisplaySortedProducts()
        {
            try
            {
                ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

                List<ProductGroup> objListProductGroup = objProductDetailsFill.ProductGroupFill();
                List<ProductInfo> objListproductInfo = objProductDetailsFill.ProductFill();
                IEnumerable<ProductInfo> EnumProductInfo = objProductDetailsFill.ProductSort(objListproductInfo);

                foreach(ProductGroup product1 in objListProductGroup)
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

                List<ProductGroup> objListProductGroup = objProductDetailsFill.ProductGroupFill();
                List<ProductInfo> objListproductInfo = objProductDetailsFill.ProductFill();

                foreach(ProductGroup product1 in objListProductGroup)
                {
                    foreach(ProductInfo product2 in objListproductInfo)
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

        public void DisplayFoundItems(string search)
        {
            if(search==null)
            Console.WriteLine("Please enter a string!");

            else
            {
                try
                {
                    ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

                    List<ProductGroup> objListProductGroup = objProductDetailsFill.ProductGroupFill();
                    List<ProductInfo> objListproductInfo = objProductDetailsFill.ProductFill();

                    var result=objListproductInfo.Where(p =>p.ProductName.ToUpper().Contains(search.ToUpper()));

                    foreach(ProductGroup product1 in objListProductGroup)
                    {
                        foreach(ProductInfo product2 in result)
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

                List<ProductGroup> objListProductGroup = objProductDetailsFill.ProductGroupFill();
                List<ProductInfo> objListproductInfo = objProductDetailsFill.ProductFill();

                List<ProductInfo> objProductDelete1= objProductDetailsFill.ProductDelete1(objListproductInfo);

                foreach(ProductGroup product1 in objListProductGroup)
                {
                    foreach(ProductInfo product2 in objProductDelete1)
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

                List<ProductGroup> objListProductGroup = objProductDetailsFill.ProductGroupFill();
                List<ProductInfo> objListproductInfo = objProductDetailsFill.ProductFill();

                List<ProductInfo> objProductDelete2= objProductDetailsFill.ProductDelete2(objListproductInfo, num);

                foreach(ProductGroup product1 in objListProductGroup)
                {
                    foreach(ProductInfo product2 in objProductDelete2)
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

                List<ProductGroup> objListProductGroup = objProductDetailsFill.ProductGroupFill();
                List<ProductInfo> objListproductInfo = objProductDetailsFill.ProductFill();

                List<ProductInfo> objProductDelete3= objProductDetailsFill.ProductDelete3(objListproductInfo, num1, num2);

                foreach(ProductGroup product1 in objListProductGroup)
                {
                    foreach(ProductInfo product2 in objProductDelete3)
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

         public void DisplayAfterDeletion4(string delete)
        {
            try
            {
                ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

                List<ProductGroup> objListProductGroup = objProductDetailsFill.ProductGroupFill();
                List<ProductInfo> objListproductInfo = objProductDetailsFill.ProductFill();
                
                bool flag = false;
                
                foreach(ProductInfo testProduct in objListproductInfo)
                {
                    if(testProduct.ProductName.Trim().ToUpper()==(delete.Trim().ToUpper()))
                    {
                        flag=true;
                        break;
                    }
                }
                
                if(flag==false){
                    Console.WriteLine("Invalid product name");
                }
                
                else
                {
                    List<ProductInfo> objProductDelete4= objProductDetailsFill.ProductDelete4(objListproductInfo, delete);
                
                    foreach(ProductGroup product1 in objListProductGroup)
                    {
                        foreach(ProductInfo product2 in objProductDelete4)
                        {
                            if(product1.ProductGroupID==product2.GroupID)
                            {
                                Console.WriteLine("Product Group Name: " +product1.ProductGroupName+ " || Product Name: " +product2.ProductName+ " || Product Description: " +product2.ProductDescription+ " || Product Rate: " +product2.ProductRate+"Reached");
                            }
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