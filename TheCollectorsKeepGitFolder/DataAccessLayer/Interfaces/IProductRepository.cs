using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IProductRepository
    {
        List<DataModels.Product> GetAll();
        DataModels.Product? GetById(int id);
        void Add(DataModels.Product product);
        void Update(DataModels.Product product);
        void Delete(int id);
        void Save();
    }
}
