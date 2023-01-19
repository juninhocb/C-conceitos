using Microsoft.AspNetCore.Mvc;

namespace MoviesMsft.Controllers
{
    
    public class ExplorerController : Controller
    {
        private readonly IConfiguration Configuration;

        public ExplorerController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewData["AppSettingsJson-Teste"] = Configuration["Teste"];
            ViewData["AppSettingsJson-Position-Title"] = Configuration["Position:Title"];
            ViewData["AppSettingsJson-Position-Name"] = Configuration["Position:Name"];
            return View();
        }

        public IActionResult Welcome(string name, int numTimes)
        {
            //url: https://localhost:7091/Explorer/Welcome?name=rick&numTimes=3
            
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

    }
}
