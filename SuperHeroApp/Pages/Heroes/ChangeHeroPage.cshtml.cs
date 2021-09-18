using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aardvark.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperHeroApp.Data;
using Tweetinvi.Core.Helpers;

namespace SuperHeroApp.UI.Pages.Heroes
{
    public class ChangeHeroPageModel : PageModel
    {
        [BindProperty]
        public SuperHeroModel SuperHero { get; set; } = new SuperHeroModel();

        public List<SuperHeroModel> ListOfSuperHeros = ListAllHeroesModel.Heroes;
        public List<Powers> SuperPowerList { get; set; } = Enum.GetValues(typeof(Powers)).Cast<Powers>().ToList();
        public List<string> powerList { get; set; } = new List<string>();

        [BindProperty]
        public string NewName { get; set; }
        [BindProperty]
        public string NewPower { get; set; }
        public void OnGet()
        {
            ViewData["SuperHeroList"] = ListOfSuperHeros.Select(a => a.Name);

            foreach (var item in SuperPowerList)
            {
                powerList.Add(item.ToString().Replace("_", " "));

            }

        }
        public void OnPost(int id)
        {
            var hero = ListOfSuperHeros.Where(hero => hero.Id == id).FirstOrDefault();
            if (NewName != null)
            {
                hero.Name = NewName;
            }
            hero.Powers = NewPower;

        }
    }
}
