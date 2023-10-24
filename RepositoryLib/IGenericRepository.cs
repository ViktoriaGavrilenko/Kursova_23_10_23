using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLib
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        // CRUD
        // Create (insert) вставка
        void Add(TEntity entity);

        //Read(select) select * from .... where id = 1
        TEntity FindById(params object[] id);
        // select * from
        IEnumerable<TEntity> GetAll();
        // select * from ... where name='?' adn price =?
        // x => x.name == '@' @@ x.price == 10
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);

        // delete
        void Remove(TEntity entity);

        // update
        void Update(TEntity entity);
    }
}
