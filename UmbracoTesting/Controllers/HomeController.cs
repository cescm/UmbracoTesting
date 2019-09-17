using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoTesting.Controllers
{
    public class HomeController: SurfaceController
    {
        public ActionResult RenderFeatured()
        {
            return PartialView("~/Views/Partials/Home/_Featured.cshtml");
        }

        public ActionResult RenderServices()
        {
            return PartialView("~/Views/Partials/Home/_Services.cshtml");
        }

        public ActionResult RenderBlog()
        {
            return PartialView("~/Views/Partials/Home/_Blog.cshtml");
        }

        public ActionResult RenderClient()
        {
            return PartialView("~/Views/Partials/Home/_Client.cshtml");
        }
    }
}