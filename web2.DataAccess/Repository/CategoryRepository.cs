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
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        private readonly ApplicationContext _db;
        public CategoryRepository(ApplicationContext db) : base(db) 
        {
        
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
