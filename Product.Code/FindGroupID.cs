using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class FindGroup
    {
        public static int FindID(string str)
        {
            try
            {
                ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();

                List <ProductGroup> productGroup= objProductDetailsFill.ProductGroupFill();

                foreach( ProductGroup product in productGroup)
                {
                    if(product.ProductGroupName=="Dairy" && product.ProductGroupName==str)
                    return 1;
                    else if(product.ProductGroupName=="Chocolate" && product.ProductGroupName==str)
                    return 2;
                    if(product.ProductGroupName=="FruitJuice" && product.ProductGroupName==str)
                    return 3;
                    else if(product.ProductGroupName=="Cakes" && product.ProductGroupName==str)
                    return 4;
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return 0;

        }
    }
}