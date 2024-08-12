using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Book_web2.DataAccess.Data;
using Book_web2.DataAccess.Repository.IRepository;
using Book_web2.Models;

namespace Book_web2.DataAccess.Repository
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {
        private  ApplicationContext _db;
        public ProductRepository(ApplicationContext db) : base(db) 
        {
        
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Author = obj.Author;
                objFromDb.Description = obj.Description;
                objFromDb.Category = obj.Category;
                objFromDb.Price = obj.Price;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Price50 = obj.Price50;
                objFromDb.CategoryId = obj.CategoryId;
                if (obj.ImgURL != null)
                {
                    objFromDb.ImgURL = obj.ImgURL;
                }
            }
        }
    }
}
