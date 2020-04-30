using POS_SYSTEM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_SYSTEM.Model.DataManager
{
    public class ProductListManager: DataRepository<ProductList>
    {
        readonly ProductContext _productContext;

        public ProductListManager(ProductContext context)
        {
            _productContext = context;
        }

        public IEnumerable<ProductList> GetAll()
        {
            return _productContext.ProductLists.ToList();
        }

        public ProductList Get(long id)
        {
            return _productContext.ProductLists
                  .FirstOrDefault(e => e.ProductId == id);
        }

        public void Add(ProductList entity)
        {
            _productContext.ProductLists.Add(entity);
            _productContext.SaveChanges();
        }

        public void Update(ProductList productlist, ProductList entity)
        {
            productlist.ProductId = entity.ProductId;
            productlist.ProductName = entity.ProductName;
            productlist.ProductCode = entity.ProductCode;
            productlist.ProductCatogory = entity.ProductCatogory;
            productlist.ProductCatogoryId = entity.ProductCatogoryId;
            productlist.PriceBuy = entity.PriceBuy;
            productlist.PriceSell = entity.PriceSell;
            _productContext.SaveChanges();
        }

        public void Delete(ProductList productlist)
        {
            _productContext.ProductLists.Remove(productlist);
            _productContext.SaveChanges();
        }
    }
}
