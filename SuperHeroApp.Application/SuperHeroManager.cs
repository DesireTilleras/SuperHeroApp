using System;
using System.Collections.Generic;
using SuperHeroApp.Data;

namespace SuperHeroApp.Application
{
    public class SuperHeroManager
    {
        public static List<SuperHeroModel> ListOfHeroes { get { return AllHeroes(); } set { } }

        public static List<SuperHeroModel> AllHeroes()
        {
            var list = new List<SuperHeroModel>();

            list.Add(new SuperHeroModel 
            {
                Id = 1, 
                Name= "Desiré", 
                SecretIdentity="Dessi", 
                Powers = Powers.Flight.ToString(), 
                ImageURL = "/SuperHerosPics/8.jpeg"});
            
            list.Add(new SuperHeroModel 
            { 
                Id = 2, 
                Name = "Tintin", 
                SecretIdentity = "Tin", 
                Powers = Powers.Immortality.ToString(), 
                ImageURL = "/SuperHerosPics/7.jpeg"});
           
            list.Add(new SuperHeroModel
            {
                Id = 3,
                Name = "Jobbe",
                SecretIdentity = "Jobbe",
                Powers = Powers.Invisibilty.ToString(),
                ImageURL = "/SuperHerosPics/5.jpeg"
            });

            return list;
        }
    }
}
