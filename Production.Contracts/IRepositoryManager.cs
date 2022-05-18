using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        //IAddProduct AddProduct { get; } 
        IAddProd ProdukBaru { get; }
 //       ICOBA Nyoba { get; }

//        IServiceManager ServiceManager { get; }
        void Save();
        Task SaveAsync();
    }
}
