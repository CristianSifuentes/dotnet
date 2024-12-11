using Microsoft.AspNetCore.Mvc;
using LacanMvc.Models;

namespace LacanMvc.Controllers
{
    public class MirrorStageController : Controller
    {
        // Displays the Mirror Stage simulation page
        public IActionResult Index()
        {
            var model = new MirrorStageModel
            {
                IdealI = "Ideal Self (What I want to be)",
                ImaginaryI = "Imaginary Self (What I think I am)",
                SymbolicI = "Symbolic Self (How society sees me)"
            };

            return View(model);
        }

        // Processes the user's reflection on the Mirror Stage
        [HttpPost]
        public IActionResult Reflect(MirrorStageModel model)
        {
            // Simulate Lacanian reflection logic
            model.ReflectionResult = $"You confront the {model.IdealI}, " +
                                     $"struggle with the {model.ImaginaryI}, " +
                                     $"and adapt to the {model.SymbolicI}.";

            return View("Index", model);
        }
    }
}
