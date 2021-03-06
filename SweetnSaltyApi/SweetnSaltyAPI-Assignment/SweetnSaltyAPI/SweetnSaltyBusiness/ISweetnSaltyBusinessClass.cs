using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness
{
    public interface ISweetnSaltyBusinessClass
    {
        Task<Flavor> PostFlavor(string flavor);
        Task<Flavor> GetFlavor(string flavor);

        Task<Person> PostPerson(string fname, string lname, string flavorname);
        Task<Person> GetPerson(int PersonId, string fname, string lname);

        Task<Person> GetPersonAndFlavors(int id);
        Task<List<Flavor>> GetAllFlavors();
    }
}
