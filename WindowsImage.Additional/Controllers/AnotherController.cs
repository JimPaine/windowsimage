using System.Web.Mvc;

namespace WindowsImage.Additional.Controllers
{
    public class AnotherController : Controller
    {
        public ActionResult Index()
        {
            var v = View();
            return v;
        }
    }
}