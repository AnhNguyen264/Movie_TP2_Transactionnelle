using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using TP2.Models;
using TP2.Models.Data;

namespace TP2.Controllers
{
    public class HomeController : Controller
    {

        private BaseDonnees _baseDonnees { get; set; }
        //private readonly ILogger<HomeController> _logger;

        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(BaseDonnees baseDonnees, IStringLocalizer<HomeController> localizer)
        {
            _baseDonnees = baseDonnees;
            //_logger = logger;

            _localizer = localizer;
        }

        [Route("")]
        [Route("home/index")]
        [Route("index")]

        public IActionResult Index()
        {
            //ViewData["titre"] = "Acceuil";
            return View(_baseDonnees.Parents.ToList());
        }

       

        public IActionResult Consulter(int id)
        {


            //ViewData["titre"] = "Acceuil";
            var parentRecherche = _baseDonnees.Parents.Where(p => p.Id == id).Select(x=>x).SingleOrDefault();
                
            if (parentRecherche == null)
            {
                return View("NonTrouvé", "La liste de film n'a pas été trouvé!");
            }
            else
            {
                return View(parentRecherche);
            }
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            var cookie = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture));
            var name = CookieRequestCultureProvider.DefaultCookieName;

            Response.Cookies.Append(name, cookie, new CookieOptions
            {
                Path = "/",
                Expires = DateTimeOffset.UtcNow.AddYears(1),
            });

            return LocalRedirect(returnUrl);
        }


    }
}
