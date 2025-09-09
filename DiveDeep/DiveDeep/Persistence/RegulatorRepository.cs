using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public static class RegulatorRepository
    {

        private static List<Regulator> Regulators = new List<Regulator>
        {
            new Regulator {Brand = "Scubapro",StageOne = "MK25EVO", StageTwo = "S600", Octopus = "R105" , Price = 125},
            new Regulator {Brand = "Scubapro",StageOne = "MK17EVO", StageTwo = "C370", Octopus = "R095" , Price = 100},
            new Regulator {Brand = "Scubapro",StageOne = "MK25EVO BT", StageTwo = "A700 Carbon BT", Octopus = "S270" , Price = 150}

        };
        public static List<Regulator> GetAllRegulators()
        {
            return Regulators;
        }
        public static Regulator? GetByID(int id)
        {
            return Regulators.FirstOrDefault(x => x.Id == id);
        }
    }
}
