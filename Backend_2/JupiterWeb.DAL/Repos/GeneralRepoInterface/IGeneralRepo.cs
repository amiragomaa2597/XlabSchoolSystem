using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;

    public interface IGeneralRepo<T> where T : class
{
    Task<T> GetById(int id);

    

    Task<IEnumerable<T>> GetAll();
    Task Add(T entity);

    
    Task Delete(T entity);
}

