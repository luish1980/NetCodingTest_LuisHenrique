using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Icatu.EmployeeManagerAPI;
using Icatu.EmployeeManagerAPI.Controllers;

namespace Icatu.EmployeeManagerAPI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Organizar
            HomeController controller = new HomeController();
            FuncionariosController fc = new FuncionariosController();

            //var result3 = fc.Get();
            

            // Agir
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
