using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public class FinRepository
    {
        private static List<Fin> Fins = new List<Fin>
        {
            new Fin {Brand = "Scubapro", Model = "Jet Fin", Size = Size.M, Price = 50},
            new Fin {Brand = "Scubapro", Model = "GO Travel", Size = Size.M, Price = 50},
            new Fin {Brand = "Scubapro", Model = "Seawing Supernova", Size = Size.M, Price = 60},
            new Fin {Brand = "Seac", Model = "Propulsion", Size = Size.M, Price = 50},
            new Fin {Brand = "Seac", Model = "ALA", Size = Size.M, Price = 50},
            new Fin {Brand = "Fourth Element", Model = "Tech", Size = Size.M, Price = 75},
            new Fin {Brand = "Fourth Element", Model = "Rec Fin", Size = Size.M, Price = 80}
            
            // Der skal egentligt være flere forskellige størrelser
        };
        public static List<Fin> GetAllFins()
        {
            return Fins;
        }

    }
}
