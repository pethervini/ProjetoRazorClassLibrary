using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjetoRCL.MyFeature.Pages
{
    public class Page1Model : PageModel
    {
        public void OnGet()
        {
            TempData["Horario"] = DateTime.Now;
            TempData["Usuario"] = "Petherson";
        }
    }
}