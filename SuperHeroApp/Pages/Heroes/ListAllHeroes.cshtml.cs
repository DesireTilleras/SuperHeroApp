using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroApp.Data;
using SuperHeroApp.Application;

namespace SuperHeroApp.UI.Pages
{
    public class ListAllHeroesModel : PageModel
    {
        public static List<SuperHeroModel> Heroes { get; set; } = SuperHeroManager.ListOfHeroes;


        public void OnGet()
        {              
        }
    }
}
