using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        
        //this method to call all product list
         public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude( x=> x.ProductBrand);

        }

        // this method to call prduct by id

        public ProductsWithTypesAndBrandsSpecification(int id)
         : base(x =>x.Id == id)
        {
              AddInclude(x => x.ProductType);
            AddInclude( x=> x.ProductBrand);
        }
    }
}

