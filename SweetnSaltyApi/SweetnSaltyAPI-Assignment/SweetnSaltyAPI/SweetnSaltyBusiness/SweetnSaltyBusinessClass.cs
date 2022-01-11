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
        private object person;

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

        //public Task<Person> GetPerson(string fname, string lname)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<Person> GetPersonAndFlavors(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Flavor> PostFlavor(string flavor)
        {
            SqlDataReader dr1 = await this._dbAccess.PostFlavor(flavor);
            if (dr1.Read())
            {
                Flavor p = this._mapper.EntityToFlavor(dr1);
                return p;
            }
            else return null;
        }

        public async Task<Person> PostPerson(string fname, string lname, string flavorname)
        {
            SqlDataReader dr2 = await this._dbAccess.PostPerson(fname, lname, flavorname);
            if (dr2.Read())
            {
                Person p2 = this._mapper.EntityToPerson(dr2);
                return p2;
            }
            else return null;
        }

        public async Task<Person> GetPerson(int PersonId, string fname, string lname)
        {
            SqlDataReader dr3 = await this._dbAccess.GetPerson( PersonId, fname, lname);
            if (dr3.Read())
            {
                Person p3 = this._mapper.EntityToPerson(dr3);
                return p3;
            }
            else return null;
        }
    }
}
