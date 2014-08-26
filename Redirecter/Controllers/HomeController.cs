﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redirecter.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        const string baseUrl = "http://WhereShouldIBuy.apphb.com";
        public ActionResult Index(string q = "")
        {
            UriBuilder builder = new UriBuilder(baseUrl);
            if (!string.IsNullOrEmpty(q)) builder.Path = q;

            return RedirectPermanent(builder.Uri.ToString());
        }

    }
}
