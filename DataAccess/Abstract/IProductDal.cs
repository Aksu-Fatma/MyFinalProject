using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //IEntityRepository product için yapılandırdın 
    public interface IProductDal : IEntityRepository<Product>
    {
        //List<Product> GetAllByCategory(int categoryId);
        List<ProductDetailDto> GetProductDetails();
    }
}
        // Code Refactoring 
