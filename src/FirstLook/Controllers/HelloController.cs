using FirstLookLibrary;
using Microsoft.AspNet.Mvc;
using System.Reflection;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstLook.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {

            var greeter = new Greeter();

            //var greeting = greeter.


#if dnx451
            return Assembly.GetExecutingAssembly().FullName;
#endif
#if dnxcore50
            return "hello";
#endif
            return null;
        }
    }
}
