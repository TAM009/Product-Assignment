using System;
using System.Collections.Generic;
using Product;

namespace ProductInterface
{
    interface IProduct
    {
        List<ProductGroup> ProductGroupFill();
        List<ProductInfo> ProductFill();

        IEnumerable<ProductInfo> ProductSort(List<ProductInfo> PInfo);

        List<ProductInfo> ProductDelete1 (List<ProductInfo>PInfo1);

        List<ProductInfo> ProductDelete2 (List<ProductInfo>PInfo1, int i);

        List<ProductInfo> ProductDelete3 (List<ProductInfo>PInfo1, int i , int j);

    }
}