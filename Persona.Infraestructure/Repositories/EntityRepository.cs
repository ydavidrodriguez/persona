using Microsoft.EntityFrameworkCore;
using Persona.Domain.Services.IRepository;


namespace Persona.Infraestructure.Repositories
{
    public class EntityRepository<T> : IRepository<T> where T : class
    {
        private readonly DataBase.DataBaseService _context;
        private readonly DbSet<T> _dbSet;

        public EntityRepository(DataBase.DataBaseService context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
