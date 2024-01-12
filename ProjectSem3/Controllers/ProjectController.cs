using Microsoft.AspNetCore.Mvc;

namespace ProjectSem3.Controllers
{
    public class ProjectController : Controller
    {
        public string Home()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
