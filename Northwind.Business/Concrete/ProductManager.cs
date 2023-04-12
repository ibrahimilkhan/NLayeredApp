using Norhwind.Entities.Concrete;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;  //Dependency Injection deseni
                                  //--> IProducDal interfaceini implemente etmiş herhangi bir class'ı kullanabilmek için.
                                  //Böyle farklı ORM araçları kullanmamız gerektiğinde kodumuzu kolayca değiştirebiliriz. İster EntityFramework ister NHibernate
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //Business code. Kişi ürünleri çekmek istiyor ama buna izin verecek miyiz? aslında bu yazılır.
            return _productDal.GetAll();
        }
        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByProductName(string searchKey)
        {
            return _productDal.GetAll(p => p.ProductName.Contains(searchKey)).ToList();
        }
    }
}