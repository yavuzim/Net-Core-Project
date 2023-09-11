using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void Add(Blog entity)
        {
            using var item = new Context();
            item.Add(entity);
            item.SaveChanges();
        }

        public void Delete(Blog entity)
        {
            using var item = new Context();
            item.Remove(entity);
            item.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var item = new Context();
            return item.Blogs.Find(id);
        }

        public List<Blog> ListAll()
        {
            using var item = new Context();
            return item.Blogs.ToList();
        }

        public void Update(Blog entity)
        {
            using var item = new Context();
            item.Update(entity);
            item.SaveChanges();
        }
    }
}
