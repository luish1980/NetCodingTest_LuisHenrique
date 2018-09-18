using Icatu.EmployeeManagerAPI.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icatu.EmployeeManagerAPI.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T:class
    {
        
        //DbSet Entity;
        ////public List<T> ListAll() => _contexto.Set<T>().ToList();

        public List<T> ListAll()
        {
            Context _contexto = new Context();
            //object type = typeof(T);
            //DbSet<T> dbSet = _contexto.Set<T>();

            return _contexto.Set<T>().ToList();
        }

    }
}
