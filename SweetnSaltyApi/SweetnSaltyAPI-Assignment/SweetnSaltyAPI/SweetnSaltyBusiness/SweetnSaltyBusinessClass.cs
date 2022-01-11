using SweetnSaltyDbAccess;
using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness
{
    public class SweetnSaltyBusinessClass : ISweetnSaltyBusinessClass
    {
        private readonly ISweetnSaltyDbAccessClass _dbAccess;
        private readonly IMapper _mapper;

        public SweetnSaltyBusinessClass(ISweetnSaltyDbAccessClass Dbaccess, IMapper mapper)//you need a reference to the DbAccess Layer 
        {
            this._mapper = mapper;
            this._dbAccess = Dbaccess;
        }

        public Task<List<Flavor>> GetAllFlavors()
        {
            throw new NotImplementedException();
        }

        public Task<Flavor> GetFlavor(string flavor)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetPerson(string fname, string lname)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetPersonAndFlavors(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Flavor> PostFlavor(string flavor)
        {
            SqlDataReader dr = await this._dbAccess.PostFlavor(flavor);
            if (dr.Read())
            {
                Flavor p = this._mapper.EntityToFlavor(dr);
                return p;
            }
            else return null;
        }

        public Task<Person> PostPerson(string fname, string lname)
        {
            throw new NotImplementedException();
        }
    }
}
