using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icatu.EmployeeManagerAPI.Repositorio
{
    public interface IRepositorio<T> where T:class
    {
        List<T> ListAll();
    }
}
