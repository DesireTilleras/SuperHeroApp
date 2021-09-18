using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroApp.Application;
using SuperHeroApp.Data;

namespace SuperHeroApp.UI.Pages.Heroes
{
    public class SignUpPageModel : PageModel
    {
        [BindProperty]
        public SuperHeroModel SuperHero { get; set; } = new SuperHeroModel();
        public Powers Powers { get; set; }
        public static int IdCounter { get; set; }
        public List<Powers> SuperPowerList { get; set; } = Enum.GetValues(typeof(Powers)).Cast<Powers>().ToList();
        public List<string> powerList { get; set; } = new List<string>();
        public void OnGet()
        {
            foreach (var item in SuperPowerList)
            {
                powerList.Add(item.ToString().Replace("_", " "));

            }
        }
        public void OnPost()
        {
            
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 10);
            string numbers= number.ToString();

            string url = "/SuperHerosPics/*.jpeg";
            string picture = url.Replace("*", numbers);

            SuperHero.ImageURL = picture;

            IdCounter = 1;

            foreach (var hero in ListAllHeroesModel.Heroes)
            {
                IdCounter++;

            }

            SuperHero.Id = IdCounter;
 
            ListAllHeroesModel.Heroes.Add(SuperHero);       

            
        }
    }
}
