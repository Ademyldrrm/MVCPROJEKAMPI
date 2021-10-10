using DataAccesLayer.Abotrack;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();

        DbSet<Category> _object;

        public CategoryRepository()
        {
        }

        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            return _object.ToList();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}

/*
 *tolist =listelemek için
 *add=eklemek için
 *Remwe=güncelllemek için
 *find=bulma için 
 
 */
