using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public class DivingSuitRepository
    {
        private static List<DivingSuit> DivingSuits = new List<DivingSuit>
        {
            new DivingSuit {Brand = "Scubapro", Model = "Definition", Size = Size.M, Type = SuitType.Våddragt, Gender = Gender.Herre, Thickness = 3, Price = 100},
            new DivingSuit {Brand = "Scubapro", Model = "Definition", Size = Size.M, Type = SuitType.Våddragt, Gender = Gender.Herre, Thickness = 5, Price = 100},
            new DivingSuit {Brand = "Scubapro", Model = "Definition", Size = Size.M, Type = SuitType.Våddragt, Gender = Gender.Herre, Thickness = 7, Price = 100},
            new DivingSuit {Brand = "Waterproof", Model = "W5", Size = Size.M, Type = SuitType.Våddragt, Gender = Gender.Herre, Thickness = 3.5, Price = 100},
            new DivingSuit {Brand = "Fourth Element", Model = "Proteus", Size = Size.M, Type = SuitType.Våddragt, Gender = Gender.Herre, Thickness = 5, Price = 120},
            new DivingSuit {Brand = "Scubapro", Model = "Exodry 4.0", Size = Size.M, Type = SuitType.Tørdragt, Gender = Gender.Herre, Price = 300},
            new DivingSuit {Brand = "Waterproof", Model = "D7 Evo", Size = Size.M, Type = SuitType.Tørdragt, Gender = Gender.Herre, Price = 320},
            new DivingSuit {Brand = "Santi", Model = "E.Lite Plus", Size = Size.M, Type = SuitType.Tørdragt, Gender = Gender.Herre, Price = 350},

            // Har sat dem alle til at være herre, men det skal være begge 
            // Der skal egentligt være flere forskellige størrelser
        };
        public static List<DivingSuit> GetAllDivingSuits()
        {
            return DivingSuits;
        }

    }
}
