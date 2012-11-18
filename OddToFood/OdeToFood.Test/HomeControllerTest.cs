using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OddToFood.Controllers;

namespace OdeToFood.Test
{
    [TestFixture]
    class HomeControllerIndexTest
    {
        [Test]
        public void Puts_Message_In_ViewBag()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result.ViewBag.Message);

        }

        
    }
}
