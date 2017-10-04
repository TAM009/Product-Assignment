using System;
using System.Collections.Generic;
using Xunit;

namespace Product.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            ProductInfo objProductInfo1=new ProductInfo();
            ProductInfo objProductInfo2=new ProductInfo();
            ProductInfo objProductInfo3=new ProductInfo();

            ProductDetailsFill objProductDetailsFill= new ProductDetailsFill();

            List<ProductInfo> ProductInfo1= new List<ProductInfo>(9);
            List<ProductInfo> ProductInfo2= new List<ProductInfo>();

            ProductInfo1.Add(objProductInfo1);
            ProductInfo1.Add(objProductInfo2);
            ProductInfo1.Add(objProductInfo3);

            //Act
            int intCount1=ProductInfo1.Count;
            ProductInfo2=objProductDetailsFill.ProductDelete2(ProductInfo1,2);
            int intCount2=ProductInfo2.Count;

            //Assert
            Assert.IsType<int> (intCount1);
            Assert.IsType<int> (intCount2);
            Assert.Equal(intCount2+1,intCount1);
            Assert.NotEqual(intCount2,intCount1);

        }
    }
}
