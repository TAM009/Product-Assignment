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
                ProductDetailsFill pf = new ProductDetailsFill();

                List <ProductGroup> pg= pf.ProductGroupFill();

                foreach( ProductGroup prod in pg)
                {
                    if(prod.ProductGroupName=="Dairy" && prod.ProductGroupName==str)
                    return 1;
                    else if(prod.ProductGroupName=="Chocolate" && prod.ProductGroupName==str)
                    return 2;
                    if(prod.ProductGroupName=="FruitJuice" && prod.ProductGroupName==str)
                    return 3;
                    else if(prod.ProductGroupName=="Cakes" && prod.ProductGroupName==str)
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