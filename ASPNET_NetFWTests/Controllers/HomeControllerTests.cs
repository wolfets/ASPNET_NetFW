using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPNET_NetFW.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Diagnostics;
using ASPNET_NetFW.Models;

namespace ASPNET_NetFW.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            HomeController homeController = new HomeController();
            ActionResult result = homeController.Index();
            //Debug.WriteLine(result);
            Assert.IsInstanceOfType(result, typeof(System.Web.Mvc.ViewResult));
        }

        [TestMethod()]
        public void AboutTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]//https://stackoverflow.com/questions/18865257/how-to-unit-test-an-action-when-return-type-is-actionresult
        public void ContactTest()
        {
            HomeController homeController = new HomeController();
            ActionResult result = homeController.Contact();
            //Debug.WriteLine(result);
            //Assert.IsInstanceOfType(result, typeof(System.Web.Mvc.ViewResult));

            ViewResult vResult = result as ViewResult;
            if (vResult != null)
            {
                Assert.IsInstanceOfType(vResult.Model, typeof(ModelBidon));
                ModelBidon model = vResult.Model as ModelBidon;
                Debug.WriteLine(model.message);
                //string xxx = vResult.ViewBag["Message"] as string;
                bool isT = (model.message == "hello");// && xxx == "Your contact page.");
                Assert.IsTrue(isT == true);
            }

            //RedirectToRouteResult routeResult = result as ActionResult;
            //Assert.AreEqual(routeResult.RouteValues["action"], "asd");
            //Assert.Fail();
        }
    }
}