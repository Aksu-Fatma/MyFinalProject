using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract  List<Product> GetAllByCategory(int categoryId);
{
    //IEntityRepository product için yapılandırdın 
    public interface IProductDal: IEntityRepository<Product>

    {
    }
}
