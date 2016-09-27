using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FileContent()
        {
            string id = (string)Request.RequestContext.RouteData.Values["id"];

            string readFile = Properties.Resources.ResourceManager.GetString(id, Properties.Resources.Culture);
            //readFile = readFile.Replace("\r\n", "<br />");
            //readFile = readFile.Replace(" ", "&nbsp;");
            return View((object)readFile);
        }
    }
}