﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HomeMvc.Controllers;

namespace HomeMvc.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : HomeMvcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
