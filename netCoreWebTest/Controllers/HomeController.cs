using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Repository.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace netCoreWebTest.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly SysUserInfoRepository sysUserInfoRepository;
        public HomeController(SysUserInfoRepository _sysUserInfoRepository)
        {
            sysUserInfoRepository = _sysUserInfoRepository;
        }
        public string aaa()
        {
            return "hello word";
        }
        public string bbb()
        {
            string s = sysUserInfoRepository.getTest();
            return s;
        }
    }
}
