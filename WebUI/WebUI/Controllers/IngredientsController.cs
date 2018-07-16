using WebUI.Models.Abstract;
using WebUI.Models.Concrete;
using System.Linq;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class IngredientsController : Controller
    {
        private IIngredientsRepository ingredientsRepository;

        public IngredientsController(IIngredientsRepository ingredientsRepository)
        {
            this.ingredientsRepository = ingredientsRepository;
        }

        public ViewResult List()
        {
            return View(ingredientsRepository.Ingredients.ToList());
        }
    }
}