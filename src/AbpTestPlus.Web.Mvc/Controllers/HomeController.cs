﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpTestPlus.Controllers;

namespace AbpTestPlus.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpTestPlusControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
