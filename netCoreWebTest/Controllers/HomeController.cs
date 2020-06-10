using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace netCoreWebTest.Controllers
{
    public class HomeController : ControllerBase
    {
        public string aaa() {
            return "hello word";
        }
    }
}
