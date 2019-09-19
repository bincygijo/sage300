using FrameworkPageObjectModel.Global;
using FrameworkPageObjectModel.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkPageObjectModel.Test
{
  public class MainClass
    {
        [TestFixture]
        [Category("Sprint_1")]
        class Sprint_1_Administration : Base
        {

                       
            [Test]
            public void ValidatePromotion()
            {
                // starting test
                test = extent.StartTest("Validate promotion test case starts");
                Promotion objPromotion = new Promotion();
                objPromotion.AddPublicPromo();


            }



        }
    }
}
