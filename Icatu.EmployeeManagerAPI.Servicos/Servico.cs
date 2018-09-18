using Icatu.EmployeeManagerAPI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icatu.EmployeeManagerAPI.Servicos
{
    public class Servico<T> : IServico<T> where T:class
    {
        Repositorio<T> _repository = new Repositorio<T>();

        public List<T> ListAll()
        {
            return _repository.ListAll();
        }
    }

    
}
