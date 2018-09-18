using Icatu.EmployeeManagerAPI.Models;
using System.Linq;
using System.Web.Http;
using Icatu.EmployeeManagerAPI.Utils;

namespace Icatu.EmployeeManagerAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        
        Context _context = new Context();

        [HttpGet]
        public IHttpActionResult Pagination(int pageSize, int page)
        {

            int skip = (pageSize - 1) * page;
            int total = _context.Employees.Count();
            var userFilterPaging = _context.Employees
                .OrderBy(c => c.Id)
                .Skip(skip)
                .Take(page)
                .ToList();

            return Ok(new Paginacao<Employee>(userFilterPaging, pageSize, page, total));
        }


        [HttpGet]
        public IHttpActionResult Get()
        {
            var model = _context.Employees.ToList();
            return Ok(model);
        }

        [HttpPost]
        public IHttpActionResult Post(Employee Employees)
        {
            _context.Employees.Add(Employees);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(Employee _func)
        {
            var Employees = _context.Employees.Where(x => x.Id == _func.Id).FirstOrDefault();
            if (Employees == null)
            {
                return NotFound();
            }
            Employees.Nome = _func.Nome;
            Employees.Email = _func.Email;
            Employees.Departamento = _func.Departamento;

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (id < 0)
            {
                return BadRequest("Identificador Inválido :" + id);
            }
            Models.Context _context = new Models.Context();
            var Employee= _context.Employees.Where(x => x.Id == id).FirstOrDefault();

            if (Employee== null)
            {
                return NotFound();
            }

            _context.Employees.Remove(Employee);

            _context.SaveChanges();

            return Ok();
        }

        

    }
}
